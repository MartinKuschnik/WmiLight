#include "pch.h"

#include "EventSinkProxy.h"

#include <Wbemidl.h>

#ifdef __cplusplus
extern "C" {  // only need to export C interface if
	// used by C++ source code
#endif

	enum WbemConnectOption : unsigned long
	{
		WbemConnectOption_None = 0x00,
		WbemConnectOption_UseMaxWait = 0x80
	};

	enum ImpersonationLevel : DWORD
	{
		ImpersonationLevel_Default = 0,
		ImpersonationLevel_Anonymous = 1,
		ImpersonationLevel_Identify = 2,
		ImpersonationLevel_Impersonate = 3,
		ImpersonationLevel_Delegate = 4
	};

	enum AuthenticationLevel : DWORD
	{
		AuthenticationLevel_Default = 0,
		AuthenticationLevel_None = 1,
		AuthenticationLevel_Connect = 2,
		AuthenticationLevel_Call = 3,
		AuthenticationLevel_Packet = 4,
		AuthenticationLevel_PacketIntegrity = 5,
		AuthenticationLevel_PacketPrivacy = 6,
	};

	enum WbemClassObjectEnumeratorBehaviorOption : long
	{
		WbemClassObjectEnumeratorBehaviorOption_Bidirectional = 0x00000000,
		WbemClassObjectEnumeratorBehaviorOption_Prototype = 0x00000002,
		WbemClassObjectEnumeratorBehaviorOption_ReturnImmediately = 0x00000010,
		WbemClassObjectEnumeratorBehaviorOption_ForwardOnly = 0x00000020,
		WbemClassObjectEnumeratorBehaviorOption_DirectRead = 0x00000200,
		WbemClassObjectEnumeratorBehaviorOption_EnsureLocatable = 0x00000100,
		WbemClassObjectEnumeratorBehaviorOption_UseAmendedQualifiers = 0x00020000
	};

	__declspec(dllexport) HRESULT _stdcall CreateWbemLocator(IWbemLocator** locator)
	{
		return CoCreateInstance(CLSID_WbemLocator, nullptr, CLSCTX_INPROC_SERVER, IID_IWbemLocator, reinterpret_cast<LPVOID*>(locator));
	}

	__declspec(dllexport) HRESULT _stdcall CreateWbemUnsecuredApartment(IWbemUnsecuredApartment** unsecuredApartment)
	{
		return CoCreateInstance(CLSID_UnsecuredApartment, nullptr, CLSCTX_LOCAL_SERVER, IID_IUnsecuredApartment, reinterpret_cast<void**>(unsecuredApartment));
	}

	__declspec(dllexport) HRESULT _stdcall ConnectServer(
		IWbemLocator* wbemLocator,
		wchar_t* networkResource,
		wchar_t* userName,
		wchar_t* userPassword,
		wchar_t* locale,
		const WbemConnectOption wbemConnectOption,
		wchar_t* authority,
		IWbemContext* ctx,
		IWbemServices** wbemServices)
	{
		if (wbemLocator == nullptr)
			return E_POINTER;

		return wbemLocator->ConnectServer(
			networkResource,
			userName,
			userPassword,
			locale,
			wbemConnectOption,
			authority,
			ctx,
			wbemServices
		);
	}


	__declspec(dllexport) HRESULT _stdcall SetProxy(
		IUnknown* pIUnknown,
		wchar_t* username,
		wchar_t* password,
		wchar_t* authority,
		ImpersonationLevel impersonationLevel,
		AuthenticationLevel authenticationLevel)
	{
		if (pIUnknown == nullptr)
			return E_POINTER;

		if (username == nullptr && password == nullptr && authority == nullptr)
		{
			return CoSetProxyBlanket(
				pIUnknown,
				RPC_C_AUTHZ_DEFAULT,
				RPC_C_AUTHZ_DEFAULT,
				nullptr,
				authenticationLevel,
				impersonationLevel,
				nullptr,
				EOAC_NONE);
		}

		SEC_WINNT_AUTH_IDENTITY authInfo{};

		authInfo.User = (unsigned short*)username;
		authInfo.UserLength = username == nullptr ? 0 : static_cast<unsigned long>(wcslen(username));

		authInfo.Domain = (unsigned short*)authority;
		authInfo.DomainLength = authority == nullptr ? 0 : static_cast<unsigned long>(wcslen(authority));

		authInfo.Password = (unsigned short*)password;
		authInfo.PasswordLength = password == nullptr ? 0 : static_cast<unsigned long>(wcslen(password));

		authInfo.Flags = SEC_WINNT_AUTH_IDENTITY_UNICODE;

		return CoSetProxyBlanket(
			pIUnknown,
			RPC_C_AUTHN_DEFAULT,
			RPC_C_AUTHZ_DEFAULT,
			nullptr,
			authenticationLevel,
			impersonationLevel,
			&authInfo,
			EOAC_NONE
		);
	}

	__declspec(dllexport) HRESULT _stdcall ExecQuery(
		IWbemServices* wbemServices,
		wchar_t* ueryLanguage,
		wchar_t* query,
		WbemClassObjectEnumeratorBehaviorOption behaviorOption,
		IWbemContext* ctx,
		IEnumWbemClassObject** pEnumerator)
	{
		if (wbemServices == nullptr)
			return E_POINTER;

		return wbemServices->ExecQuery(ueryLanguage, query, behaviorOption, ctx, pEnumerator);
	}

	__declspec(dllexport) HRESULT _stdcall CreateEventSinkStub(
		IWbemUnsecuredApartment* pUnsecApp,
		void* pEventSink,
		EventSinkProxy::IndicateFunction indicateFunction,
		EventSinkProxy::SetStatusFunction setStatusFunction,
		IWbemObjectSink** pEventSinkStub)
	{
		if (pUnsecApp == nullptr || pEventSink == nullptr)
			return E_POINTER;

		EventSinkProxy* pSink = new EventSinkProxy(pEventSink, indicateFunction, setStatusFunction);

		// Allows us to delete the object from the heap by calling Release() if the CreateObjectStub() call fails.
		pSink->AddRef();

		IUnknown* pStubUnk = NULL;
		HRESULT hr = pUnsecApp->CreateObjectStub(pSink, &pStubUnk);

		if (FAILED(hr))
		{
			// delete the object from the heap because stub creation failed
			pSink->Release();

			return hr;
		}

		hr = pStubUnk->QueryInterface(IID_IWbemObjectSink, reinterpret_cast<void**>(pEventSinkStub));

		// This Release call does not delete the object from the heap because the sink is referended by the sink stub
		pSink->Release();

		// decrease ref count, object keeps alive by other referneces
		pStubUnk->Release();

		return hr;
	}

	__declspec(dllexport) HRESULT _stdcall CancelAsyncCall(IWbemServices* wbemServices, IWbemObjectSink* pEventSinkProxy)
	{
		if (wbemServices == nullptr || pEventSinkProxy == nullptr)
			return E_POINTER;

		return wbemServices->CancelAsyncCall(pEventSinkProxy);
	}

	__declspec(dllexport) HRESULT _stdcall ExecNotificationQueryAsync(IWbemServices* wbemServices, wchar_t* ueryLanguage, wchar_t* query, IWbemContext* ctx, IWbemObjectSink* pStubSink)
	{
		if (wbemServices == nullptr)
			return E_POINTER;

		return wbemServices->ExecNotificationQueryAsync(ueryLanguage, query, 0, ctx, pStubSink);
	}

	__declspec(dllexport) HRESULT _stdcall Next(
		IEnumWbemClassObject* pEnumerator,
		long timeout,
		IWbemClassObject** pClassObject)
	{
		if (pEnumerator == nullptr)
			return E_POINTER;

		ULONG uReturn;

		return pEnumerator->Next(timeout, 1, pClassObject, &uReturn);
	}

	__declspec(dllexport) HRESULT _stdcall Reset(
		IEnumWbemClassObject* pEnumerator)
	{
		if (pEnumerator == nullptr)
			return E_POINTER;

		return pEnumerator->Reset();
	}

	__declspec(dllexport) HRESULT _stdcall Get(
		IWbemClassObject* pClassObject,
		wchar_t* propertyName,
		VARIANT* value,
		CIMTYPE* pType)
	{
		if (pClassObject == nullptr)
			return E_POINTER;

		VariantInit(value);

		HRESULT hr = pClassObject->Get(propertyName, 0, value, pType, 0);

		if (FAILED(hr))
		{
			VariantClear(value);
			return hr;
		}

		return hr;
	}

	__declspec(dllexport) HRESULT _stdcall GetType(
		IWbemClassObject* pClassObject,
		wchar_t* propertyName,
		CIMTYPE* cimType)
	{
		if (pClassObject == nullptr)
			return E_POINTER;

		return pClassObject->Get(propertyName, 0 /*reserved*/, nullptr, cimType, NULL);
	}

	__declspec(dllexport) HRESULT _stdcall GetNames(
		IWbemClassObject* pClassObject,
		SAFEARRAY** pNames)
	{
		if (pClassObject == nullptr)
			return E_POINTER;

		return pClassObject->GetNames(nullptr, WBEM_FLAG_NONSYSTEM_ONLY, nullptr, pNames);
	}

	__declspec(dllexport) HRESULT _stdcall GetMethod(
		IWbemClassObject* pClassObject,
		wchar_t* methodName,
		IWbemClassObject** ppInSignature,
		IWbemClassObject** ppOutSignature)
	{
		if (pClassObject == nullptr)
			return E_POINTER;

		return pClassObject->GetMethod(methodName, 0, ppInSignature, ppOutSignature);
	}

	__declspec(dllexport) HRESULT _stdcall GetClass(
		IWbemServices* wbemServices,
		wchar_t* className,
		IWbemContext* ctx,
		IWbemClassObject** pClassDef)
	{
		if (wbemServices == nullptr)
			return E_POINTER;

		return wbemServices->GetObject(className, WBEM_FLAG_RETURN_WBEM_COMPLETE, ctx, pClassDef, nullptr);
	}

	__declspec(dllexport) HRESULT _stdcall SpawnInstance(IWbemClassObject* pClassObject, IWbemClassObject** ppNewInstance)
	{
		if (pClassObject == nullptr)
			return E_POINTER;

		return pClassObject->SpawnInstance(0, ppNewInstance);
	}

	__declspec(dllexport) HRESULT _stdcall Put(IWbemClassObject* pClassObject, wchar_t* wszName, VARIANT* pVal, CIMTYPE type)
	{
		if (pClassObject == nullptr)
			return E_POINTER;

		return pClassObject->Put(wszName, 0, pVal, type);
	}

	__declspec(dllexport) HRESULT _stdcall PutInstance(IWbemServices* wbemServices, IWbemClassObject* pInst, IWbemContext* ctx)
	{
		if (wbemServices == nullptr)
			return E_POINTER;

		return wbemServices->PutInstance(pInst, WBEM_FLAG_CREATE_OR_UPDATE, ctx, nullptr);
	}

	__declspec(dllexport) HRESULT _stdcall ExecMethod(
		IWbemServices* wbemServices,
		wchar_t* classNameOrPath,
		wchar_t* methodName,
		IWbemContext* ctx,
		IWbemClassObject* pInParams,
		IWbemClassObject** pOutParams)
	{
		if (wbemServices == nullptr)
			return E_POINTER;

		return wbemServices->ExecMethod(classNameOrPath, methodName, 0, ctx, pInParams, pOutParams, nullptr);
	}

	__declspec(dllexport) HRESULT _stdcall DeleteInstance(IWbemServices* wbemServices, wchar_t* strObjectPath, IWbemContext* ctx)
	{
		if (wbemServices == nullptr)
			return E_POINTER;

		return wbemServices->DeleteInstance(strObjectPath, 0, ctx, nullptr);
	}

#ifdef __cplusplus
}
#endif
