#if NET7_0_OR_GREATER

namespace WmiLight
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.Marshalling;
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
            [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemLocator,
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
            [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pIUnknown,
            [MarshalAs(UnmanagedType.LPWStr)]
            string username,
            [MarshalAs(UnmanagedType.LPWStr)]
            string password,
            [MarshalAs(UnmanagedType.LPWStr)]
            string domain,
            ImpersonationLevel impersonationLevel,
            AuthenticationLevel authenticationLevel);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult ExecQuery(
            [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string queryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            WbemClassObjectEnumeratorBehaviorOption behaviorOption,
            IntPtr ctx,
            out IntPtr pEnumerator);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult ExecNotificationQueryAsync(
            [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemServices,
            [MarshalAs(UnmanagedType.LPWStr)]
            string queryLanguage,
            [MarshalAs(UnmanagedType.LPWStr)]
            string query,
            IntPtr ctx,
            [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pEventSinkProxy);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult CancelAsyncCall([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemServices, [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pEventSinkProxy);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetClass([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string className, IntPtr ctx, out IntPtr pObject);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult ExecMethod([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string classNameOrPath, [MarshalAs(UnmanagedType.LPWStr)] string methodName, IntPtr ctx, [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown inParams, out IntPtr outParams);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult DeleteInstance([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemServices, [MarshalAs(UnmanagedType.LPWStr)] string strObjectPath, IntPtr ctx);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult CreateEventSinkStub([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pUnsecApp, IntPtr pEventSink, Indicate indicateFunction, SetStatus setStatusFunction, out IntPtr eventSinkStub);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult Next([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pEnumerator, int timeout, out IntPtr pClassObject);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult Reset([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pEnumerator);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static unsafe partial HResult Get(
            [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pClassObject,
            [MarshalAs(UnmanagedType.LPWStr)]
            string propertyName,
            VARIANT* value,
            out CimType valueType);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetMethod([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string methodName, out IntPtr pInSignature, out IntPtr pOutSignature);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult SpawnInstance([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pClassObject, out IntPtr pNewInstance);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static unsafe partial HResult Put([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string wszName, VARIANT* pvar, CimType cimType);

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

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult PutInstance([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pWbemServices, [MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pInst, IntPtr ctx);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetType([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pClassObject, [MarshalAs(UnmanagedType.LPWStr)] string propertyName, out CimType cimType);

        [LibraryImport(NATIVE_DLL_NAME)]
        [UnmanagedCallConv(CallConvs = new Type[] { typeof(CallConvStdcall) })]
        public static partial HResult GetNames([MarshalUsing(typeof(IUnknownMarshaller))] IUnknown pClassObject, out IntPtr pNames);


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