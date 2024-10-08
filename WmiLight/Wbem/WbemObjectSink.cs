﻿namespace WmiLight.Wbem
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Object that received the notification from the native code.
    /// </summary>
    internal class WbemObjectSink : IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool cancelled = false;

        private readonly IUnknown nativeStub;

        internal WbemObjectSink(IntPtr pUnsecApp)
        {
            IntPtr pNativeStub;

            HResult hResult = NativeMethods.CreateEventSinkStub(pUnsecApp, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.WeakTrackResurrection)), WbemObjectSink.Indicate, WbemObjectSink.SetStatus, out pNativeStub);

            if (hResult.Failed)
                throw (Exception)hResult;

            this.nativeStub = new IUnknown(pNativeStub);
        }

        internal IUnknown NativeStub => this.nativeStub;

        internal bool Cancelled => this.cancelled;

        internal event EventHandler<WbemObjectSinkIndicatedEventArgs> Indicated;

        /// <summary>
        /// The <see cref="Indicate"/> method is called by a source to provide a notification. Typically, WMI calls the client implementation of this interface after the client executes one of the asynchronous methods.
        /// In other cases, various types of providers call an implementation exported by WMI to deliver events. Therefore, client code may have to implement this interface in some cases, and use a different component's implementation in other cases.
        /// </summary>
        /// <param name="pEventSink">The pointer to the sink object.</param>
        /// <param name="lObjectCount">Number of objects in the following array of pointers.</param>
        /// <param name="apObjArray">Array of objects.</param>
        /// <returns>This method returns an HRESULT that indicates the status of the method call.</returns>
        internal static HResult Indicate(IntPtr pEventSink, int lObjectCount, IntPtr[] apObjArray)
        {
            GCHandle gcHandle = GCHandle.FromIntPtr(pEventSink);

            if (gcHandle.IsAllocated)
            {
                try
                {
                    WbemObjectSink target = gcHandle.Target as WbemObjectSink;

                    if (target != null)
                    {
                        EventHandler<WbemObjectSinkIndicatedEventArgs> eventHandler = target.Indicated;

                        if (eventHandler != null)
                        {
                            WbemClassObject[] objects = new WbemClassObject[lObjectCount];

                            for (int i = 0; i < lObjectCount; i++)
                            {
                                IntPtr pWbemClassObject = apObjArray[i];

                                // It's necessary to increment the ref count here. Otherwise the object is deleted
                                // directly after the native call. This would case a AccessViolationException when the GC calls
                                // the destructor of the WbemClassObject that calls the ReleaseIUnknown method to an already deleted
                                // object.
                                //
                                // from MSDN: https://learn.microsoft.com/en-us/windows/win32/api/wbemcli/nf-wbemcli-iwbemobjectsink-indicate
                                // The array memory itself is read-only, and is owned by the caller of the method.
                                // Because this is an in parameter, the implementation has the option of calling AddRef on any object pointer
                                // in the array and holding it before returning if the objects will be used after the method has returned,
                                // in accordance with COM rules. If the objects are only used for the duration of the Indicate call,
                                // then you do not need to call AddRef on each object pointer.

                                Marshal.AddRef(pWbemClassObject);

                                objects[i] = new WbemClassObject(pWbemClassObject);
                            }

                            eventHandler.Invoke(target, new WbemObjectSinkIndicatedEventArgs(objects));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine($"Unhandled Exception caught: {ex}");
                }
            }

            return WbemStatus.WBEM_S_NO_ERROR;
        }

        /// <summary>
        /// The <see cref="SetStatus" /> method is called by sources to indicate the end of a notification sequence, or to send other status codes to the sink. The <see cref="Indicate"/> method may or may not have been called before the call to <see cref="SetStatus" />.
        /// </summary>
        /// <param name="pEventSink">The pointer to the sink object.</param>
        /// <param name="lFlags">Bitmask of status information. The status of the operation can be obtained by examining the <paramref name="hResult"/> parameter.</param>
        /// <param name="hResult">This parameter is set to the HRESULT of the asynchronous operation or notification. This is either an error code, if an error occurred, or the amount of progress that has been made on an asynchronous call.</param>
        /// <param name="strParam">Receives a pointer to a read-only string, if the original asynchronous operation returns a string.</param>
        /// <param name="pObjParam">In cases where a complex error or status object is returned, this contains a pointer to the error object.</param>
        /// <returns>This method returns an HRESULT that indicates the status of the method call.</returns>
        internal static HResult SetStatus(
            IntPtr pEventSink,
            int lFlags,
            HResult hResult,
            [MarshalAs(UnmanagedType.LPWStr)]
            string strParam,
            IntPtr pObjParam
        )
        {
            GCHandle gcHandle = GCHandle.FromIntPtr(pEventSink);

            if (gcHandle.IsAllocated)
            {
                WbemObjectSink target = gcHandle.Target as WbemObjectSink;

                if (target != null)
                {
                    if (hResult == WbemStatus.WBEM_E_CALL_CANCELLED)
                        target.cancelled = true;
                }
            }

            return WbemStatus.WBEM_S_NO_ERROR;
        }

        public void Dispose()
        {
            this.nativeStub.Dispose();
        }
    }
}
