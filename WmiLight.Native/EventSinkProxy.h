#pragma once

#include <Wbemidl.h>

/// <summary>
/// Proxy that forewardes the event calls to the managed sink.
/// </summary>
class EventSinkProxy : public IWbemObjectSink
{
public:

    typedef HRESULT(*IndicateFunction)(void*, long, IWbemClassObject**);
    typedef HRESULT(*SetStatusFunction)(void*, long, HRESULT, wchar_t*, IWbemClassObject*);    

private:

    long _lRef;

    void* _pEventSink;
    const IndicateFunction _indicateFunction;
    const SetStatusFunction _setStatusFunction;

public:
    EventSinkProxy(void* pEventSink, IndicateFunction indicateFunction, SetStatusFunction setStatusFunction) noexcept;

    ~EventSinkProxy() noexcept = default;

    virtual ULONG STDMETHODCALLTYPE AddRef();

    virtual ULONG STDMETHODCALLTYPE Release();

    virtual HRESULT STDMETHODCALLTYPE QueryInterface(REFIID riid, void** ppv);

    virtual HRESULT STDMETHODCALLTYPE Indicate(long lObjectCount, IWbemClassObject** apObjArray);

    virtual HRESULT STDMETHODCALLTYPE SetStatus(long lFlags, HRESULT hResult, wchar_t* strParam, IWbemClassObject* pObjParam);
};