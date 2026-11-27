#if NETFRAMEWORK || NETSTANDARD

namespace WmiLight
{
    using System;
    using System.Runtime.InteropServices;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// The class to call the native COM functions of the C++ library.
    /// </summary>
    #endregion
    internal static class NativeMethods
    {
        #region Constants

        /// <summary>
        /// Name of the native WmiLight DLL.
        /// </summary>
        private const string NATIVE_DLL_NAME = "WmiLight.Native.dll";

        #endregion


        #region Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate HResult Indicate(
            IntPtr pEventSink,
            int lObjectCount,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]
            IntPtr[] apObjArray
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate HResult SetStatus(
            IntPtr pEventSink,
            int lFlags,
            HResult hResult,
            [MarshalAs(UnmanagedType.LPWStr)]
            string strParam,
            IntPtr pObjParam
        );

        #endregion

        #region Methods

        #region WmiLight.Native.dll
        private static class x64
        {
            private const string NATIVE_DLL_NAME_X64 = "WmiLight.Native.x64.dll";

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CreateWbemLocator(out IntPtr pWbemLocator);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CreateWbemUnsecuredApartment(out IntPtr pUnsecuredApartment);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult QueryInterface(IntPtr unknown, ref Guid riid, out IntPtr ppvObject);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ConnectServer(
                IntPtr pWbemLocator,
                [MarshalAs(UnmanagedType.LPWStr)]
                string networkResource,
                [MarshalAs(UnmanagedType.LPWStr)]
                string userName,
                [MarshalAs(UnmanagedType.LPWStr)]
                string userPassword,
                [MarshalAs(UnmanagedType.LPWStr)]
                string locale,
                [MarshalAs (UnmanagedType.U4)]
                uint wbemConnectOption,
                [MarshalAs(UnmanagedType.LPWStr)]
                string authority,
                IntPtr pCtx,
                out IntPtr pWbemServices);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult SetProxy(
                IntPtr pIUnknown,
                [MarshalAs(UnmanagedType.LPWStr)]
                string username,
                [MarshalAs(UnmanagedType.LPWStr)]
                string password,
                [MarshalAs(UnmanagedType.LPWStr)]
                string domain,
                ImpersonationLevel impersonationLevel,
                AuthenticationLevel authenticationLevel);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ExecQuery(
                IntPtr pWbemServices,
                [MarshalAs(UnmanagedType.LPWStr)]
                string queryLanguage,
                [MarshalAs(UnmanagedType.LPWStr)]
                string query,
                WbemClassObjectEnumeratorBehaviorOption behaviorOption,
                IntPtr ctx,
                out IntPtr pEnumerator);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ExecNotificationQueryAsync(
                IntPtr pWbemServices,
                [MarshalAs(UnmanagedType.LPWStr)]
                string queryLanguage,
                [MarshalAs(UnmanagedType.LPWStr)]
                string query,
                IntPtr ctx,
                IntPtr pEventSinkProxy);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CancelAsyncCall(IntPtr pWbemServices, IntPtr pEventSinkProxy);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetClass(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string className, IntPtr ctx, out IntPtr pObject);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ExecMethod(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string classNameOrPath, [MarshalAs(UnmanagedType.LPWStr)] string methodName, IntPtr ctx, IntPtr inParams, out IntPtr outParams);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult DeleteInstance(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string strObjectPath, IntPtr ctx);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CreateEventSinkStub(IntPtr pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult Next(IntPtr pEnumerator, int timeout, out IntPtr pClassObject);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult Reset(IntPtr pEnumerator);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static unsafe extern HResult Get(
                IntPtr pClassObject,
                [MarshalAs(UnmanagedType.LPWStr)]
                string propertyName,
                VARIANT* value,
                out CimType valueType);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetMethod(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string methodName, out IntPtr pInSignature, out IntPtr pOutSignature);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult SpawnInstance(IntPtr pClassObject, out IntPtr pNewInstance);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static unsafe extern HResult Put(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string wszName, VARIANT* pvar, CimType cimType);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult PutInstance(IntPtr pWbemServices, IntPtr pInst, IntPtr ctx);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetType(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string propertyName, out CimType cimType);

            [DllImport(NATIVE_DLL_NAME_X64, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetNames(IntPtr pClassObject, out IntPtr pNames);
        }
        private static class x86
        {
            private const string NATIVE_DLL_NAME_X86 = "WmiLight.Native.x86.dll";

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CreateWbemLocator(out IntPtr pWbemLocator);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CreateWbemUnsecuredApartment(out IntPtr pUnsecuredApartment);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult QueryInterface(IntPtr unknown, ref Guid riid, out IntPtr ppvObject);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ConnectServer(
                IntPtr pWbemLocator,
                [MarshalAs(UnmanagedType.LPWStr)]
                string networkResource,
                [MarshalAs(UnmanagedType.LPWStr)]
                string userName,
                [MarshalAs(UnmanagedType.LPWStr)]
                string userPassword,
                [MarshalAs(UnmanagedType.LPWStr)]
                string locale,
                [MarshalAs (UnmanagedType.U4)]
                uint wbemConnectOption,
                [MarshalAs(UnmanagedType.LPWStr)]
                string authority,
                IntPtr pCtx,
                out IntPtr pWbemServices);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult SetProxy(
                IntPtr pIUnknown,
                [MarshalAs(UnmanagedType.LPWStr)]
                string username,
                [MarshalAs(UnmanagedType.LPWStr)]
                string password,
                [MarshalAs(UnmanagedType.LPWStr)]
                string domain,
                ImpersonationLevel impersonationLevel,
                AuthenticationLevel authenticationLevel);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ExecQuery(
                IntPtr pWbemServices,
                [MarshalAs(UnmanagedType.LPWStr)]
                string queryLanguage,
                [MarshalAs(UnmanagedType.LPWStr)]
                string query,
                WbemClassObjectEnumeratorBehaviorOption behaviorOption,
                IntPtr ctx,
                out IntPtr pEnumerator);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ExecNotificationQueryAsync(
                IntPtr pWbemServices,
                [MarshalAs(UnmanagedType.LPWStr)]
                string queryLanguage,
                [MarshalAs(UnmanagedType.LPWStr)]
                string query,
                IntPtr ctx,
                IntPtr pEventSinkProxy);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CancelAsyncCall(IntPtr pWbemServices, IntPtr pEventSinkProxy);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetClass(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string className, IntPtr ctx, out IntPtr pObject);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult ExecMethod(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string classNameOrPath, [MarshalAs(UnmanagedType.LPWStr)] string methodName, IntPtr ctx, IntPtr inParams, out IntPtr outParams);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult DeleteInstance(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string strObjectPath, IntPtr ctx);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult CreateEventSinkStub(IntPtr pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult Next(IntPtr pEnumerator, int timeout, out IntPtr pClassObject);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult Reset(IntPtr pEnumerator);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static unsafe extern HResult Get(
                IntPtr pClassObject,
                [MarshalAs(UnmanagedType.LPWStr)]
                string propertyName,
                VARIANT* value,
                out CimType valueType);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetMethod(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string methodName, out IntPtr pInSignature, out IntPtr pOutSignature);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult SpawnInstance(IntPtr pClassObject, out IntPtr pNewInstance);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static unsafe extern HResult Put(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string wszName, VARIANT* pvar, CimType cimType);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult PutInstance(IntPtr pWbemServices, IntPtr pInst, IntPtr ctx);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetType(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string propertyName, out CimType cimType);

            [DllImport(NATIVE_DLL_NAME_X86, CallingConvention = CallingConvention.StdCall)]
            public static extern HResult GetNames(IntPtr pClassObject, out IntPtr pNames);
        }

        public static HResult CreateWbemLocator(out IntPtr pWbemLocator)
        {
            if (Environment.Is64BitProcess)
                return x64.CreateWbemLocator(out pWbemLocator);
            else
                return x86.CreateWbemLocator(out pWbemLocator);
        }

        public static HResult CreateWbemUnsecuredApartment(out IntPtr pUnsecuredApartment)
        {
            if (Environment.Is64BitProcess)
                return x64.CreateWbemUnsecuredApartment(out pUnsecuredApartment);
            else
                return x86.CreateWbemUnsecuredApartment(out pUnsecuredApartment);
        }

        public static HResult QueryInterface(IntPtr unknown, ref Guid riid, out IntPtr ppvObject)
        {
            if (Environment.Is64BitProcess)
                return x64.QueryInterface(unknown, ref riid, out ppvObject);
            else
                return x86.QueryInterface(unknown, ref riid, out ppvObject);
        }

        public static HResult ConnectServer(
            IUnknown pWbemLocator,
            string networkResource,
            string userName,
            string userPassword,
            string locale,
            uint wbemConnectOption,
            string authority,
            IntPtr pCtx,
            out IntPtr pWbemServices)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.ConnectServer((IntPtr)pWbemLocator, networkResource, userName, userPassword, locale, wbemConnectOption, authority, pCtx, out pWbemServices);
            else
                hResult = x86.ConnectServer((IntPtr)pWbemLocator, networkResource, userName, userPassword, locale, wbemConnectOption, authority, pCtx, out pWbemServices);

            // Only the raw COM pointer was passed to native code, so pWbemLocator must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pWbemLocator);

            return hResult;
        }
        public static HResult SetProxy(
            IUnknown pIUnknown,
            string username,
            string password,
            string domain,
            ImpersonationLevel impersonationLevel,
            AuthenticationLevel authenticationLevel)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.SetProxy((IntPtr)pIUnknown, username, password, domain, impersonationLevel, authenticationLevel);
            else
                hResult = x86.SetProxy((IntPtr)pIUnknown, username, password, domain, impersonationLevel, authenticationLevel);

            // Only the raw COM pointer was passed to native code, so pIUnknown must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pIUnknown);

            return hResult;
        }
        public static HResult ExecQuery(
            IUnknown pWbemServices,
            string queryLanguage,
            string query,
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            IntPtr ctx,
            out IntPtr pEnumerator)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.ExecQuery((IntPtr)pWbemServices, queryLanguage, query, behaviorOption, ctx, out pEnumerator);
            else
                hResult = x86.ExecQuery((IntPtr)pWbemServices, queryLanguage, query, behaviorOption, ctx, out pEnumerator);

            // Only the raw COM pointer was passed to native code, so pWbemServices must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pWbemServices);

            return hResult;
        }
        public static HResult ExecNotificationQueryAsync(
            IUnknown pWbemServices,
            string queryLanguage,
            string query,
            IntPtr ctx,
            IUnknown pEventSinkProxy)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.ExecNotificationQueryAsync((IntPtr)pWbemServices, queryLanguage, query, ctx, (IntPtr)pEventSinkProxy);
            else
                hResult = x86.ExecNotificationQueryAsync((IntPtr)pWbemServices, queryLanguage, query, ctx, (IntPtr)pEventSinkProxy);

            // Only the raw COM pointers were passed to native code, so pWbemServices and pEventSinkProxy must stay reachable until the call has returned.
            // Otherwise the GC could finalize them during the call and release the native objects while they are still in use.
            GC.KeepAlive(pWbemServices);
            GC.KeepAlive(pEventSinkProxy);

            return hResult;
        }
        public static HResult CancelAsyncCall(IUnknown pWbemServices, IUnknown pEventSinkProxy)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.CancelAsyncCall((IntPtr)pWbemServices, (IntPtr)pEventSinkProxy);
            else
                hResult = x86.CancelAsyncCall((IntPtr)pWbemServices, (IntPtr)pEventSinkProxy);

            // Only the raw COM pointers were passed to native code, so pWbemServices and pEventSinkProxy must stay reachable until the call has returned.
            // Otherwise the GC could finalize them during the call and release the native objects while they are still in use.
            GC.KeepAlive(pWbemServices);
            GC.KeepAlive(pEventSinkProxy);

            return hResult;
        }

        public static HResult GetClass(IUnknown pWbemServices, string className, IntPtr ctx, out IntPtr pObject)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.GetClass((IntPtr)pWbemServices, className, ctx, out pObject);
            else
                hResult = x86.GetClass((IntPtr)pWbemServices, className, ctx, out pObject);

            // Only the raw COM pointer was passed to native code, so pWbemServices must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pWbemServices);

            return hResult;
        }

        public static HResult ExecMethod(IUnknown pWbemServices, string classNameOrPath, string methodName, IntPtr ctx, IUnknown inParams, out IntPtr outParams)
        {
            HResult hResult;

            IntPtr pInParams = inParams is null ? IntPtr.Zero : (IntPtr)inParams; /* inParams is null for methods without in-parameters. */

            if (Environment.Is64BitProcess)
                hResult = x64.ExecMethod((IntPtr)pWbemServices, classNameOrPath, methodName, ctx, pInParams, out outParams);
            else
                hResult = x86.ExecMethod((IntPtr)pWbemServices, classNameOrPath, methodName, ctx, pInParams, out outParams);

            // Only the raw COM pointers were passed to native code, so pWbemServices and inParams must stay reachable until the call has returned.
            // Otherwise the GC could finalize them during the call and release the native objects while they are still in use.
            GC.KeepAlive(pWbemServices);
            GC.KeepAlive(inParams);

            return hResult;
        }

        public static HResult DeleteInstance(IUnknown pWbemServices, string strObjectPath, IntPtr ctx)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.DeleteInstance((IntPtr)pWbemServices, strObjectPath, ctx);
            else
                hResult = x86.DeleteInstance((IntPtr)pWbemServices, strObjectPath, ctx);

            // Only the raw COM pointer was passed to native code, so pWbemServices must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pWbemServices);

            return hResult;
        }

        public static HResult CreateEventSinkStub(IUnknown pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.CreateEventSinkStub((IntPtr)pUnsecApp, pEventSink, indicateFunction, setStatusFunction, out eventSinkStub);
            else
                hResult = x86.CreateEventSinkStub((IntPtr)pUnsecApp, pEventSink, indicateFunction, setStatusFunction, out eventSinkStub);

            // Only the raw COM pointer was passed to native code, so pUnsecApp must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pUnsecApp);

            return hResult;
        }

        public static HResult Next(IUnknown pEnumerator, int timeout, out IntPtr pClassObject)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.Next((IntPtr)pEnumerator, timeout, out pClassObject);
            else
                hResult = x86.Next((IntPtr)pEnumerator, timeout, out pClassObject);

            // Only the raw COM pointer was passed to native code, so pEnumerator must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pEnumerator);

            return hResult;
        }

        public static HResult Reset(IUnknown pEnumerator)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.Reset((IntPtr)pEnumerator);
            else
                hResult = x86.Reset((IntPtr)pEnumerator);

            // Only the raw COM pointer was passed to native code, so pEnumerator must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pEnumerator);

            return hResult;
        }

        public static unsafe HResult Get(IUnknown pClassObject, string propertyName, VARIANT* value, out CimType valueType)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.Get((IntPtr)pClassObject, propertyName, value, out valueType);
            else
                hResult = x86.Get((IntPtr)pClassObject, propertyName, value, out valueType);

            // Only the raw COM pointer was passed to native code, so pClassObject must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pClassObject);

            return hResult;
        }

        public static HResult GetMethod(IUnknown pClassObject, string methodName, out IntPtr pInSignature, out IntPtr pOutSignature)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.GetMethod((IntPtr)pClassObject, methodName, out pInSignature, out pOutSignature);
            else
                hResult = x86.GetMethod((IntPtr)pClassObject, methodName, out pInSignature, out pOutSignature);

            // Only the raw COM pointer was passed to native code, so pClassObject must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pClassObject);

            return hResult;
        }

        public static HResult SpawnInstance(IUnknown pClassObject, out IntPtr pNewInstance)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.SpawnInstance((IntPtr)pClassObject, out pNewInstance);
            else
                hResult = x86.SpawnInstance((IntPtr)pClassObject, out pNewInstance);

            // Only the raw COM pointer was passed to native code, so pClassObject must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pClassObject);

            return hResult;
        }

        public static unsafe HResult Put(IUnknown pClassObject, string wszName, VARIANT* pvar, CimType cimType)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.Put((IntPtr)pClassObject, wszName, pvar, cimType);
            else
                hResult = x86.Put((IntPtr)pClassObject, wszName, pvar, cimType);

            // Only the raw COM pointer was passed to native code, so pClassObject must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pClassObject);

            return hResult;
        }

        // Puts an embedded object. The object is passed inside a VARIANT and not as an IUnknown parameter, so it has to be kept alive here.
        public static unsafe HResult Put(IUnknown pClassObject, string wszName, IUnknown value)
        {
            VARIANT variant = new VARIANT() { vt = VARENUM.VT_UNKNOWN, Object = (IntPtr)value }; /* Put copies the object, so no reference is added or released here. */

            HResult hResult = Put(pClassObject, wszName, &variant, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            // Only the raw COM pointer of value is in the VARIANT, so value must stay reachable until Put has returned.
            // Otherwise the GC could finalize it during the call and release the native object while Put is still copying it.
            GC.KeepAlive(value);

            return hResult;
        }

        public static HResult PutInstance(IUnknown pWbemServices, IUnknown pInst, IntPtr ctx)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.PutInstance((IntPtr)pWbemServices, (IntPtr)pInst, ctx);
            else
                hResult = x86.PutInstance((IntPtr)pWbemServices, (IntPtr)pInst, ctx);

            // Only the raw COM pointers were passed to native code, so pWbemServices and pInst must stay reachable until the call has returned.
            // Otherwise the GC could finalize them during the call and release the native objects while they are still in use.
            GC.KeepAlive(pWbemServices);
            GC.KeepAlive(pInst);

            return hResult;
        }

        public static HResult GetType(IUnknown pClassObject, string propertyName, out CimType cimType)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.GetType((IntPtr)pClassObject, propertyName, out cimType);
            else
                hResult = x86.GetType((IntPtr)pClassObject, propertyName, out cimType);

            // Only the raw COM pointer was passed to native code, so pClassObject must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pClassObject);

            return hResult;
        }

        public static HResult GetNames(IUnknown pClassObject, out IntPtr pNames)
        {
            HResult hResult;

            if (Environment.Is64BitProcess)
                hResult = x64.GetNames((IntPtr)pClassObject, out pNames);
            else
                hResult = x86.GetNames((IntPtr)pClassObject, out pNames);

            // Only the raw COM pointer was passed to native code, so pClassObject must stay reachable until the call has returned.
            // Otherwise the GC could finalize it during the call and release the native object while it is still in use.
            GC.KeepAlive(pClassObject);

            return hResult;
        }

        #endregion

        #region oleaut32.dll

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static unsafe extern HResult VariantClear(VARIANT* variant);

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HResult SafeArrayGetLBound(IntPtr psa, uint nDim, out int plLbound);

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HResult SafeArrayGetUBound(IntPtr psa, uint nDim, out int plUbound);

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HResult SafeArrayGetElement(IntPtr psa, in int rgIndices, out IntPtr pv);

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SafeArrayGetDim(IntPtr psa);

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SafeArrayCreateVector(VARENUM vt, int lLbound, uint cElements);

        [DllImport("Oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HResult SafeArrayPutElement(IntPtr psa, int[] rgIndices, IntPtr pv);

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HResult SafeArrayDestroy(IntPtr psa);

        #endregion

        #region Propsys.dll

        [DllImport("Propsys.dll", CallingConvention = CallingConvention.StdCall)]
        public static unsafe extern uint VariantGetElementCount(VARIANT* variant);

        [DllImport("Propsys.dll", CallingConvention = CallingConvention.StdCall)]
        public static unsafe extern HResult InitVariantFromVariantArrayElem(VARIANT* variant, uint iElem, VARIANT* pvar);

        #endregion

        #endregion
    }
}
#endif