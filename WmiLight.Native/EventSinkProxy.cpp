#include "pch.h"

#include "EventSinkProxy.h"

EventSinkProxy::EventSinkProxy(void* pEventSink, IndicateFunction indicateFunction, SetStatusFunction setStatusFunction) noexcept
	: _pEventSink(pEventSink), _indicateFunction(indicateFunction), _setStatusFunction(setStatusFunction)
{
	_lRef = 0;
}

ULONG EventSinkProxy::AddRef()
{
	return ::InterlockedIncrement(&_lRef);
}

ULONG EventSinkProxy::Release()
{
	long lRef = ::InterlockedDecrement(&_lRef);

	if (lRef == 0)
		delete this;

	return lRef;
}

HRESULT EventSinkProxy::QueryInterface(REFIID riid, void** ppv)
{
	if (riid == IID_IUnknown || riid == IID_IWbemObjectSink)
	{
		*ppv = (IWbemObjectSink*)this;

		this->AddRef();

		return WBEM_S_NO_ERROR;
	}

	return E_NOINTERFACE;
}

HRESULT EventSinkProxy::Indicate(long lObjectCount, IWbemClassObject** apObjArray)
{
	return this->_indicateFunction(this->_pEventSink, lObjectCount, apObjArray);
}

HRESULT EventSinkProxy::SetStatus(long lFlags, HRESULT hResult, wchar_t* strParam, IWbemClassObject* pObjParam)
{
	return this->_setStatusFunction(this->_pEventSink, lFlags, hResult, strParam, pObjParam);
}