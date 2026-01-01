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
                string authority,
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
                string authority,
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
            IntPtr pWbemLocator,
            string networkResource,
            string userName,
            string userPassword,
            string locale,
            uint wbemConnectOption,
            string authority,
            IntPtr pCtx,
            out IntPtr pWbemServices)
        {
            if (Environment.Is64BitProcess)
                return x64.ConnectServer(pWbemLocator, networkResource, userName, userPassword, locale, wbemConnectOption, authority, pCtx, out pWbemServices);
            else
                return x86.ConnectServer(pWbemLocator, networkResource, userName, userPassword, locale, wbemConnectOption, authority, pCtx, out pWbemServices);
        }
        public static HResult SetProxy(
            IntPtr pIUnknown,
            string username,
            string password,
            string authority,
            ImpersonationLevel impersonationLevel,
            AuthenticationLevel authenticationLevel)
        {
            if (Environment.Is64BitProcess)
                return x64.SetProxy(pIUnknown, username, password, authority, impersonationLevel, authenticationLevel);
            else
                return x86.SetProxy(pIUnknown, username, password, authority, impersonationLevel, authenticationLevel);
        }
        public static HResult ExecQuery(
            IntPtr pWbemServices,
            string queryLanguage,
            string query,
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            IntPtr ctx,
            out IntPtr pEnumerator)
        {
            if (Environment.Is64BitProcess)
                return x64.ExecQuery(pWbemServices, ueryLanguage, query, behaviorOption, ctx, out pEnumerator);
            else
                return x86.ExecQuery(pWbemServices, ueryLanguage, query, behaviorOption, ctx, out pEnumerator);
        }
        public static HResult ExecNotificationQueryAsync(
            IntPtr pWbemServices,
            string queryLanguage,
            string query,
            IntPtr ctx,
            IntPtr pEventSinkProxy)
        {
            if (Environment.Is64BitProcess)
                return x64.ExecNotificationQueryAsync(pWbemServices, queryLanguage, query, ctx, pEventSinkProxy);
            else
                return x86.ExecNotificationQueryAsync(pWbemServices, queryLanguage, query, ctx, pEventSinkProxy);
        }
        public static HResult CancelAsyncCall(IntPtr pWbemServices, IntPtr pEventSinkProxy)
        {
            if (Environment.Is64BitProcess)
                return x64.CancelAsyncCall(pWbemServices, pEventSinkProxy);
            else
                return x86.CancelAsyncCall(pWbemServices, pEventSinkProxy);
        }

        public static HResult GetClass(IntPtr pWbemServices, string className, IntPtr ctx, out IntPtr pObject)
        {
            if (Environment.Is64BitProcess)
                return x64.GetClass(pWbemServices, className, ctx, out pObject);
            else
                return x86.GetClass(pWbemServices, className, ctx, out pObject);
        }

        public static HResult ExecMethod(IntPtr pWbemServices, string classNameOrPath, string methodName, IntPtr ctx, IntPtr inParams, out IntPtr outParams)
        {
            if (Environment.Is64BitProcess)
                return x64.ExecMethod(pWbemServices, classNameOrPath, methodName, ctx, inParams, out outParams);
            else
                return x86.ExecMethod(pWbemServices, classNameOrPath, methodName, ctx, inParams, out outParams);
        }

        public static HResult DeleteInstance(IntPtr pWbemServices, string strObjectPath, IntPtr ctx)
        {
            if (Environment.Is64BitProcess)
                return x64.DeleteInstance(pWbemServices, strObjectPath, ctx);
            else
                return x86.DeleteInstance(pWbemServices, strObjectPath, ctx);
        }

        public static HResult CreateEventSinkStub(IntPtr pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub)
        {
            if (Environment.Is64BitProcess)
                return x64.CreateEventSinkStub(pUnsecApp, pEventSink, indicateFunction, setStatusFunction, out eventSinkStub);
            else
                return x86.CreateEventSinkStub(pUnsecApp, pEventSink, indicateFunction, setStatusFunction, out eventSinkStub);
        }

        public static HResult Next(IntPtr pEnumerator, int timeout, out IntPtr pClassObject)
        {
            if (Environment.Is64BitProcess)
                return x64.Next(pEnumerator, timeout, out pClassObject);
            else
                return x86.Next(pEnumerator, timeout, out pClassObject);
        }

        public static HResult Reset(IntPtr pEnumerator)
        {
            if (Environment.Is64BitProcess)
                return x64.Reset(pEnumerator);
            else
                return x86.Reset(pEnumerator);
        }

        public static unsafe HResult Get(IntPtr pClassObject, string propertyName, VARIANT* value, out CimType valueType)
        {
            if (Environment.Is64BitProcess)
                return x64.Get(pClassObject, propertyName, value, out valueType);
            else
                return x86.Get(pClassObject, propertyName, value, out valueType);
        }

        public static HResult GetMethod(IntPtr pClassObject, string methodName, out IntPtr pInSignature, out IntPtr pOutSignature)
        {
            if (Environment.Is64BitProcess)
                return x64.GetMethod(pClassObject, methodName, out pInSignature, out pOutSignature);
            else
                return x86.GetMethod(pClassObject, methodName, out pInSignature, out pOutSignature);
        }

        public static HResult SpawnInstance(IntPtr pClassObject, out IntPtr pNewInstance)
        {
            if (Environment.Is64BitProcess)
                return x64.SpawnInstance(pClassObject, out pNewInstance);
            else
                return x86.SpawnInstance(pClassObject, out pNewInstance);
        }

        public static unsafe HResult Put(IntPtr pClassObject, string wszName, VARIANT* pvar, CimType cimType)
        {
            if (Environment.Is64BitProcess)
                return x64.Put(pClassObject, wszName, pvar, cimType);
            else
                return x86.Put(pClassObject, wszName, pvar, cimType);
        }

        public static HResult PutInstance(IntPtr pWbemServices, IntPtr pInst, IntPtr ctx)
        {
            if (Environment.Is64BitProcess)
                return x64.PutInstance(pWbemServices, pInst, ctx);
            else
                return x86.PutInstance(pWbemServices, pInst, ctx);
        }

        public static HResult GetType(IntPtr pClassObject, string propertyName, out CimType cimType)
        {
            if (Environment.Is64BitProcess)
                return x64.GetType(pClassObject, propertyName, out cimType);
            else
                return x86.GetType(pClassObject, propertyName, out cimType);
        }

        public static HResult GetNames(IntPtr pClassObject, out IntPtr pNames)
        {
            if (Environment.Is64BitProcess)
                return x64.GetNames(pClassObject, out pNames);
            else
                return x86.GetNames(pClassObject, out pNames);
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