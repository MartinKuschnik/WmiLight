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
        private const string NATIVE_DLL_NAME = "WmiLight.Native.dll";

        #region Methods

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult CreateWbemLocator(out IntPtr pWbemLocator);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult ReleaseIUnknown(IntPtr pIUnknown);

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
        public static extern HResult Next(IntPtr pEnumerator, out IntPtr pClassObject);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult Reset(IntPtr pEnumerator);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult Get(
            IntPtr pClassObject,
            [MarshalAs(UnmanagedType.LPWStr)]
            string propertyName,
            [MarshalAs(UnmanagedType.Struct)]
            ref object value,
            out CimType valueType);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult GetType(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string propertyName, out CimType cimType);

        [DllImport(NATIVE_DLL_NAME)]
        public static extern HResult GetNames(IntPtr pClassObject, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out string[] pNames);

        #endregion
    }
}
