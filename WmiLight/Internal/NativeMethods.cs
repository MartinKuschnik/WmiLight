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

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult CreateWbemLocator(out IntPtr pWbemLocator);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult CreateWbemUnsecuredApartment(out IntPtr pUnsecuredApartment);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
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

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
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

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult ExecQuery(
            IntPtr pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string ueryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            IntPtr ctx,
            out IntPtr pEnumerator);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult ExecNotificationQueryAsync(
            IntPtr pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string ueryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            IntPtr ctx,
            IntPtr pEventSinkProxy);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult CancelAsyncCall(IntPtr pWbemServices, IntPtr pEventSinkProxy);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult GetClass(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string className, IntPtr ctx, out IntPtr pObject);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult ExecMethod(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string classNameOrPath, [MarshalAs(UnmanagedType.LPWStr)] string methodName, IntPtr ctx, IntPtr inParams, out IntPtr outParams);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult DeleteInstance(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string strObjectPath, IntPtr ctx);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult CreateEventSinkStub(IntPtr pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult Next(IntPtr pEnumerator, out IntPtr pClassObject);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult Reset(IntPtr pEnumerator);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult Get(
            IntPtr pClassObject,
            [MarshalAs(UnmanagedType.LPWStr)]
            string propertyName,
            ref VARIANT value,
            out CimType valueType);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult GetMethod(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string methodName, out IntPtr pInSignature, out IntPtr pOutSignature);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult SpawnInstance(IntPtr pClassObject, out IntPtr pNewInstance);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult Put(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string wszName, ref VARIANT pvar, CimType cimType);
     
        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult PutInstance(IntPtr pWbemServices, IntPtr pInst, IntPtr ctx);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult GetType(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string propertyName, out CimType cimType);

        [DllImport(NATIVE_DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern HResult GetNames(IntPtr pClassObject, out IntPtr pNames);

        #endregion

        #region oleaut32.dll

        [DllImport("oleaut32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HResult VariantClear(ref VARIANT variant);

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
        public static extern uint VariantGetElementCount(ref VARIANT variant);

        [DllImport("Propsys.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern HResult InitVariantFromVariantArrayElem(ref VARIANT variant, uint iElem, ref VARIANT pvar);

        #endregion

        #endregion
    }
}
