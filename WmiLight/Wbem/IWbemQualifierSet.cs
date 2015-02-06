namespace WmiLight.Wbem
{
    using System;
    using System.Runtime.InteropServices;

    #region Description
    /// <summary>
    /// Acts as a container for the entire set of named qualifiers for a single property or entire object (a class or instance).
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391860(v=vs.85).aspx"/></remarks>
    #endregion
    internal interface IWbemQualifierSet
    {
        #region Description
        /// <summary>
        /// Resets prior to an enumeration of all qualifiers.
        /// </summary>
        /// <param name="flags">Specifies the qualifiers to include in the enumeration. (<see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391861(v=vs.85).aspx"/>)</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult BeginEnumeration(
            [In]  
            int flags);

        #region Description
        /// <summary>
        /// Deletes the specified named qualifier.
        /// </summary>
        /// <param name="name">Name of the qualifier to delete. </param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Delete(
            [In, MarshalAs(UnmanagedType.LPWStr)]  
            string name);

        #region Description
        /// <summary>
        /// Ends an enumeration of qualifiers.
        /// </summary>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult EndEnumeration();

        #region Description
        /// <summary>
        /// Reads a particular named qualifier.
        /// </summary>
        /// <param name="name">Name of the qualifier for which the value is being requested.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="value">The correct type and value for the qualifier. </param>
        /// <param name="flavor">
        /// Can be NULL. 
        /// If not NULL, this must point to a LONG that receives the qualifier flavor bits for the requested qualifier. For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392900(v=vs.85).aspx"/>.
        /// </param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Get(
            [In, MarshalAs(UnmanagedType.LPWStr)]   
            string name,
            [In]   
            int flags,
            [Out]  
            out object value,
            [Out]  
            out int flavor);

        #region Description
        /// <summary>
        /// Gets the names of qualifiers subject to certain filters.
        /// </summary>
        /// <param name="flags">Default 0 (<see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391868(v=vs.85).aspx"/>).</param>
        /// <param name="names">A new <see cref="UnmanagedType.SafeArray"/> is created that contains the requested names.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult GetNames(
            [In]   
            int flags,
            [Out, MarshalAs(UnmanagedType.SafeArray)]
            out IntPtr names);

        #region Description
        /// <summary>
        /// Gets the next qualifier during an enumeration of all qualifiers.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="name">This parameter receives the name of the qualifier.</param>
        /// <param name="value">This parameter receives the value for the qualifier.</param>
        /// <param name="flavor">
        /// If not NULL, the value pointed to is set to the qualifier flavor. <para />
        /// For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392900(v=vs.85).aspx"/>.
        /// </param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Next(
            [In]   
            int flags,
            [Out, MarshalAs(UnmanagedType.BStr)]  
            out string name,
            [Out]  
            out object value,
            [Out]  
            out int flavor);

        #region Description
        /// <summary>
        /// Writes a particular named qualifier.
        /// </summary>
        /// <param name="name">Name of the qualifier that is being written.</param>
        /// <param name="value">
        /// The qualifier value to be written. <para />
        /// Only variants and arrays of type <see cref="VarEnum.VT_I4"/>, <see cref="VarEnum.VT_R8"/>, <see cref="VarEnum.VT_BSTR"/>, <see cref="VarEnum.VT_BOOL"/> are supported.
        /// </param>
        /// <param name="flavor">Desired qualifier flavors for this qualifier.The default value is 0.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Put(
            [In, MarshalAs(UnmanagedType.LPWStr)]  
            string name,
            [In]  
            object value,
            [In]  
            int flavor);
    }
}
