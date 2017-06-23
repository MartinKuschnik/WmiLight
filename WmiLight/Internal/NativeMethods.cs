namespace WmiLight
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// The class to call the native COM functions of the C++ library.
    /// </summary>
    #endregion
    internal static class NativeMethods
    {        
        #region Fields

        #region Description
        /// <summary>
        /// Sets the authentication information that will be used to make calls on the specified proxy.
        /// </summary>
        #endregion
        internal static readonly CoSetProxyBlanketForIWbemServicesFunction CoSetProxyBlanketForIWbemServices;

        #region Description
        /// <summary>
        /// Sets the authentication information that will be used to make calls on the specified proxy.
        /// </summary>
        #endregion
        internal static readonly CoSetProxyBlanketForIWbemClassObjectEnumeratorFunction CoSetProxyBlanketForIWbemClassObjectEnumerator;

        #region Description
        /// <summary>
        /// Sets the authentication information and executes a query to retrieve objects.
        /// </summary>
        #endregion
        internal static readonly ExecQueryFunction ExecQueryWmi;

        #endregion

        #region Constants

        #region Description
        /// <summary>
        /// The name of the native COM DLL.
        /// </summary>
        #endregion
        private const string UnmanagedWmiLibraryDllName = "wminet_utils.dll";

        #endregion

        #region Static Constructor

        #region Description
        /// <summary>
        /// Initializes static members of the <see cref="NativeMethods" /> class.
        /// </summary>
        #endregion
        static NativeMethods()
        {
            string dllPath = "";
#if NETSTANDARD2_0
            switch (RuntimeInformation.ProcessArchitecture)
            {
                case Architecture.Arm:
                    throw new PlatformNotSupportedException("Arm is not supported");
                case Architecture.Arm64:
                    throw new PlatformNotSupportedException("Arm64 is not supported");

                case Architecture.X64:
                    dllPath = Path.Combine(AppContext.BaseDirectory, "x64", NativeMethods.UnmanagedWmiLibraryDllName);
                    break;
                case Architecture.X86:
                    dllPath = Path.Combine(AppContext.BaseDirectory, "x86", NativeMethods.UnmanagedWmiLibraryDllName);
                    break;
            }
#else
            dllPath = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + Path.DirectorySeparatorChar + NativeMethods.UnmanagedWmiLibraryDllName;
#endif
            IntPtr loadLibrary = LoadLibrary(dllPath);

            if (loadLibrary != IntPtr.Zero)
            {
                IntPtr procAddr = GetProcAddress(loadLibrary, "BlessIWbemServices");
                
                CoSetProxyBlanketForIWbemServices = (CoSetProxyBlanketForIWbemServicesFunction)Marshal.GetDelegateForFunctionPointer(procAddr, typeof(CoSetProxyBlanketForIWbemServicesFunction));

                CoSetProxyBlanketForIWbemClassObjectEnumerator = (CoSetProxyBlanketForIWbemClassObjectEnumeratorFunction)Marshal.GetDelegateForFunctionPointer(procAddr, typeof(CoSetProxyBlanketForIWbemClassObjectEnumeratorFunction));
                
                ExecQueryWmi = (ExecQueryFunction)Marshal.GetDelegateForFunctionPointer(GetProcAddress(loadLibrary, "ExecQueryWmi"), typeof(ExecQueryFunction));
            }
            else
            {
                throw new WmiException(string.Format("Unable to load library {0}.", NativeMethods.UnmanagedWmiLibraryDllName));
            }
        }

        #endregion

        #region Delegates

        #region Description
        /// <summary>
        /// The function to set the authentication information for a <see cref="WmiLight.Wbem.IWbemServices"/> object.
        /// </summary>
        /// <param name="wbemServices">The <see cref="WmiLight.Wbem.IWbemServices"/> object which will by wrapped with a proxy.</param>
        /// <param name="userName">The name of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="authority">
        /// The authority to be used to authenticate the specified user.
        /// <para />
        /// Example: "ntlmdomain:MYDOMAIN"
        /// </param>
        /// <param name="impersonationLevel">The impersonation level which will be used.</param>
        /// <param name="authenticationLevel">The authentication level which will be used.</param>
        /// <returns>A coded numerical value that is assigned to a specific exception.</returns>
        #endregion
        internal delegate HResult CoSetProxyBlanketForIWbemServicesFunction(
            [In, MarshalAs(UnmanagedType.Interface)] 
            IWbemServices wbemServices,
            [In, MarshalAs(UnmanagedType.BStr)]  
            string userName,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string password,
            [In, MarshalAs(UnmanagedType.BStr)]  
            string authority,
            [In]
            ImpersonationLevel impersonationLevel,
            [In]
            AuthenticationLevel authenticationLevel);

        #region Description
        /// <summary>
        /// The function to set the authentication information for a <see cref="WmiLight.Wbem.IWbemClassObjectEnumerator"/> object.
        /// </summary>
        /// <param name="wbemClassObjectEnumerator">The <see cref="WmiLight.Wbem.IWbemClassObjectEnumerator"/> object which will by wrapped with a proxy.</param>
        /// <param name="userName">The name of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="authority">
        /// The authority to be used to authenticate the specified user.
        /// <para />
        /// Example: "ntlmdomain:MYDOMAIN"
        /// </param>
        /// <param name="impersonationLevel">The impersonation level which will be used.</param>
        /// <param name="authenticationLevel">The authentication level which will be used.</param>
        /// <returns>A coded numerical value that is assigned to a specific exception.</returns>
        #endregion
        internal delegate HResult CoSetProxyBlanketForIWbemClassObjectEnumeratorFunction(
            [In, MarshalAs(UnmanagedType.Interface)] 
            IWbemClassObjectEnumerator wbemClassObjectEnumerator,
            [In, MarshalAs(UnmanagedType.BStr)]  
            string userName,
            [In, MarshalAs(UnmanagedType.BStr)] 
            string password,
            [In, MarshalAs(UnmanagedType.BStr)]  
            string authority,
            [In]
            ImpersonationLevel impersonationLevel,
            [In]
            AuthenticationLevel authenticationLevel);

        #region Description
        /// <summary>
        /// Sets the authentication information and executes a query to retrieve objects.
        /// </summary>
        /// <param name="queryLanguage">
        /// The query language. 
        /// <para />
        /// Typically, this is WQL. 
        /// </param>
        /// <param name="query">The query which will be executed.</param>
        /// <param name="enumeratorBehaviorOption">Flag for the behavior of the created enumerator.</param>
        /// <param name="ctx">
        /// Typically, this is NULL. 
        /// Otherwise, this is an <see cref="WmiLight.Wbem.IWbemContext"/> object required by one or more dynamic class providers.
        /// </param>
        /// <param name="enumerator">The enumerator for the results of the query.</param>
        /// <param name="impersonationLevel">The impersonation level which will be used.</param>
        /// <param name="authenticationLevel">The authentication level which will be used.</param>
        /// <param name="wbemService">The <see cref="IWbemServices" /> object./></param>
        /// <param name="userName">The name of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="authority">
        /// The authority to be used to authenticate the specified user.
        /// <para />
        /// Example: "ntlmdomain:MYDOMAIN"
        /// </param>
        /// <returns>A coded numerical value that is assigned to a specific exception.</returns>
        #endregion
        internal delegate HResult ExecQueryFunction(
            [In][MarshalAs(UnmanagedType.BStr)]
            string queryLanguage,
            [In][MarshalAs(UnmanagedType.BStr)]  
            string query,
            [In] 
            WbemClassObjectEnumeratorBehaviorOption enumeratorBehaviorOption,
            [In] 
            IWbemContext ctx,
            [Out] 
            out IWbemClassObjectEnumerator enumerator,
            [In] 
            AuthenticationLevel impersonationLevel,
            [In] 
            ImpersonationLevel authenticationLevel,
            [In] 
            IWbemServices wbemService,
            [In][MarshalAs(UnmanagedType.BStr)]  
            string userName,
            [In][MarshalAs(UnmanagedType.BStr)]  
            string password,
            [In][MarshalAs(UnmanagedType.BStr)]  
            string authority);

        #endregion
        
        #region Methods

        #region Description
        /// <summary>
        /// Loads the specified module into the address space of the calling process. The specified module may cause other modules to be loaded.
        /// </summary>
        /// <param name="fileName">
        /// The name of the module. 
        /// This can be either a library module (a .dll file) or an executable module (an .exe file). 
        /// The name specified is the file name of the module and is not related to the name stored in the library module itself, 
        /// as specified by the LIBRARY keyword in the module-definition (.def) file.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the module.
        /// If the function fails, the return value is NULL.
        /// </returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/ms684175(v=vs.85).aspx"/></remarks>
        #endregion
        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string fileName);

        #region Description
        /// <summary>
        /// Retrieves the address of an exported function or variable from the specified dynamic-link library (DLL).
        /// </summary>
        /// <param name="hModule">A handle to the DLL module that contains the function or variable. </param>
        /// <param name="procname">
        /// The function or variable name, or the function's ordinal value. If this parameter is an ordinal value, it must be in the low-order word; the high-order word must be zero.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is the address of the exported function or variable.
        /// If the function fails, the return value is NULL.
        /// </returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/ms683212(v=vs.85).aspx"/></remarks>
        #endregion
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procname);

        #endregion
    }
}
