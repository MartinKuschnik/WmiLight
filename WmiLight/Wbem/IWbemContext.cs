namespace WmiLight.Wbem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    
    #region Description
    /// <summary>
    /// The <see cref="IWbemContext"/> interface is optionally used to communicate additional context information 
    /// to providers when submitting <see cref="IWbemServices"/> calls to WMI. 
    /// All primary calls in IWbemServices take an optional parameter pointing to an object of this type.
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391465(v=vs.85).aspx"/></remarks>
    #endregion
    [ComImport]
    [Guid("44aca674-e8fc-11d0-a07c-00c04fb68820")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IWbemContext
    {
        #region Description
        /// <summary>
        /// Creates a complete copy of the current <see cref="IWbemContext"/> object.
        /// </summary>
        /// <param name="newCopy">The new object containing the clone of the current object.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Clone(
            [Out]
            out IWbemContext newCopy);

        #region Description
        /// <summary>
        /// Retrieves the names of all of the context values available.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="names">
        /// If no error is returned, on exit <paramref name="names"/> receives a pointer to a new SAFEARRAY structure of type VT_BSTR containing all the context value names.<para />
        /// The caller must call SafeArrayDestroy on the returned pointer when the array is no longer required. If an error code is returned, the pointer is left unmodified.
        /// </param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult GetNames(
            [In]
            uint flags, 
            [Out, MarshalAs(UnmanagedType.SafeArray)]
            out IntPtr names);

        #region Description
        /// <summary>
        /// Begins an enumeration of all context values in the  object.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult BeginEnumeration(
            [In] uint flags);

        #region Description
        /// <summary>
        /// Retrieves the next value in an enumeration of all context values beginning with <see cref="IWbemContext.BeginEnumeration"/>.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="name">The context value name.</param>
        /// <param name="value">The context value.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Next( 
            [In]
            uint flags,
            [Out, MarshalAs(UnmanagedType.BStr)] 
            out string name,
            [Out] 
            out object value);

        #region Description
        /// <summary>
        /// Ends an enumeration begun with <see cref="IWbemContext.BeginEnumeration"/> and <see cref="IWbemContext.Next"/>.
        /// </summary>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult EndEnumeration();

        #region Description
        /// <summary>
        /// Sets a specific named context value.
        /// </summary>
        /// <param name="name">The context value name.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="value">The named context value.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult SetValue(
            [In, MarshalAs(UnmanagedType.LPWStr)] 
            string name,
            [In] 
            uint flags,
            [In] 
            object value);

        #region Description
        /// <summary>
        /// Retrieves the names of all of the context values available.
        /// </summary>
        /// <param name="name">Name for which the value is to be retrieved.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="value">The context value.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult GetValue(
            [In, MarshalAs(UnmanagedType.LPWStr)] 
            string name,
            [In] 
            uint flags,
            [Out] 
            out object value);

        #region Description
        /// <summary>
        /// Removes the specified context value.
        /// </summary>
        /// <param name="name">The named context value to delete.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult DeleteValue(
            [In, MarshalAs(UnmanagedType.LPWStr)] 
            string name,
            [In] 
            uint flags);

        #region Description
        /// <summary>
        /// Removes all context values, emptying the <see cref="IWbemContext"/> object.
        /// </summary>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult DeleteAll();
    }
}
