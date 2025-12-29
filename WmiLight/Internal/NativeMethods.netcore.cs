#if NET7_0_OR_GREATER

namespace WmiLight
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// The class to call the native COM functions of the C++ library.
    /// </summary>
    #endregion
    internal static partial class NativeMethods
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

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult CreateWbemLocator(out IntPtr pWbemLocator);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult CreateWbemUnsecuredApartment(out IntPtr pUnsecuredApartment);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult QueryInterface(IntPtr unknown, ref Guid riid, out IntPtr ppvObject);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult ConnectServer(
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

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SetProxy(
            IntPtr pIUnknown,
            [MarshalAs(UnmanagedType.LPWStr)]
            string username,
            [MarshalAs(UnmanagedType.LPWStr)]
            string password,
            [MarshalAs(UnmanagedType.LPWStr)]
            string authority,
            ImpersonationLevel impersonationLevel,
            AuthenticationLevel authenticationLevel);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult ExecQuery(
            IntPtr pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string ueryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            IntPtr ctx,
            out IntPtr pEnumerator);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult ExecNotificationQueryAsync(
            IntPtr pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string ueryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            IntPtr ctx,
            IntPtr pEventSinkProxy);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult CancelAsyncCall(IntPtr pWbemServices, IntPtr pEventSinkProxy);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetClass(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string className, IntPtr ctx, out IntPtr pObject);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult ExecMethod(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string classNameOrPath, [MarshalAs(UnmanagedType.LPWStr)] string methodName, IntPtr ctx, IntPtr inParams, out IntPtr outParams);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult DeleteInstance(IntPtr pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string strObjectPath, IntPtr ctx);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult CreateEventSinkStub(IntPtr pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult Next(IntPtr pEnumerator, int timeout, out IntPtr pClassObject);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult Reset(IntPtr pEnumerator);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static unsafe partial HResult Get(
            IntPtr pClassObject,
            [MarshalAs(UnmanagedType.LPWStr)]
            string propertyName,
            VARIANT* value,
            out CimType valueType);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetMethod(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string methodName, out IntPtr pInSignature, out IntPtr pOutSignature);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SpawnInstance(IntPtr pClassObject, out IntPtr pNewInstance);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static unsafe partial HResult Put(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string wszName, VARIANT* pvar, CimType cimType);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult PutInstance(IntPtr pWbemServices, IntPtr pInst, IntPtr ctx);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetType(IntPtr pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string propertyName, out CimType cimType);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetNames(IntPtr pClassObject, out IntPtr pNames);


        #endregion

        #region oleaut32.dll

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static unsafe partial HResult VariantClear(VARIANT* variant);

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SafeArrayGetLBound(IntPtr psa, uint nDim, out int plLbound);

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SafeArrayGetUBound(IntPtr psa, uint nDim, out int plUbound);

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SafeArrayGetElement(IntPtr psa, in int rgIndices, out IntPtr pv);

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial uint SafeArrayGetDim(IntPtr psa);

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial IntPtr SafeArrayCreateVector(VARENUM vt, int lLbound, uint cElements);

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SafeArrayPutElement(IntPtr psa, int[] rgIndices, IntPtr pv);

        [LibraryImport("oleaut32.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SafeArrayDestroy(IntPtr psa);

        #endregion

        #region Propsys.dll

        [LibraryImport("Propsys.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static unsafe partial uint VariantGetElementCount(VARIANT* variant);

        [LibraryImport("Propsys.dll")]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static unsafe partial HResult InitVariantFromVariantArrayElem(VARIANT* variant, uint iElem, VARIANT* pvar);

        #endregion

        #endregion
    }
}

#endif