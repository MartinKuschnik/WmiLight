﻿namespace WmiLight
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
        private const string NATIVE_DLL_NAME = "WmiLight.Native.dll";

        #region Delegates

        public delegate HResult Indicate(
            IntPtr pEventSink,
            int lObjectCount,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]
            IntPtr[] apObjArray
        );

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

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult CreateWbemLocator(out IntPtr pWbemLocator);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult CreateWbemUnsecuredApartment(out IntPtr pUnsecuredApartment);        

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult ReleaseIUnknown(IntPtr pIUnknown);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult QueryInterface(IntPtr pIUnknown, Guid riid, out IntPtr ppvObject);

        [DllImport(NATIVE_DLL_NAME)]
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
            WbemConnectOption wbemConnectOption,
            [MarshalAs(UnmanagedType.LPWStr)]
            string authority,
            IntPtr pCtx,
            out IntPtr pWbemServices);

        [DllImport(NATIVE_DLL_NAME)]
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

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult ExecQuery(
            IntPtr pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string ueryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            IntPtr ctx,
            out IntPtr pEnumerator);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult ExecNotificationQueryAsync(
            IntPtr pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string ueryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            IntPtr ctx,
            IntPtr pEventSinkProxy);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult CancelAsyncCall(IntPtr pWbemServices, IntPtr pEventSinkProxy);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult CreateEventSinkStub(IntPtr pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult Next(IntPtr pEnumerator, out IntPtr pClassObject);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult Reset(IntPtr pEnumerator);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult Get(
            IntPtr pClassObject,
            [MarshalAs(UnmanagedType.LPWStr)]
            string propertyName,
            ref VARIANT value,
            out CimType valueType);

        [DllImport("oleaut32.dll", SetLastError = true)]
        public static extern HResult VariantClear(ref VARIANT variant);

        [DllImport("Propsys.dll")]
        public static extern uint VariantGetElementCount(ref VARIANT variant);

        [DllImport("Propsys.dll")]
        public static extern HResult InitVariantFromVariantArrayElem(ref VARIANT variant, uint iElem, ref VARIANT pvar);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult GetType(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string propertyName, out CimType cimType);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult GetNames(IntPtr pClassObject, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] pNames);

        #endregion
    }
}
