namespace WmiLight.Wbem
{
    using System;
    using System.Runtime.InteropServices;
        
    #region Description
    /// <summary>
    /// The <see cref="IWbemCallResult"/> interface is used for semisynchronous calls of the <see cref="IWbemServices"/> interface. 
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391425(v=vs.85).aspx"/></remarks>
    #endregion
    [ComImport]
    [Guid("44aca675-e8fc-11d0-a07c-00c04fb68820")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IWbemCallResult
    {
        #region Description
        /// <summary>
        /// Returns an <see cref="IWbemClassObject"/>, which is the result of a semisynchronous call to <see cref="IWbemServices.GetObject"/>.
        /// </summary>
        /// <param name="timeout">The maximum time in milliseconds that this call blocks before returning.</param>
        /// <param name="resultObject">The copy of the object when it becomes available.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetResultObject(
            [In] 
            int timeout, 
            [Out] 
            out IWbemClassObject resultObject);

        #region Description
        /// <summary>
        /// Returns an object path, which is the result of a semisynchronous call to <see cref="IWbemServices.PutInstance"/>.
        /// </summary>
        /// <param name="timeout">The maximum time in milliseconds that this call blocks before returning.</param>
        /// <param name="resultString">The assigned object path.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetResultString(
            [In] 
            int timeout, 
            [Out, MarshalAs(UnmanagedType.BStr)]
            out string resultString);

        #region Description
        /// <summary>
        /// Returns the result of a semisynchronous call to <see cref="IWbemServices.OpenNamespace"/> verb action.
        /// </summary>
        /// <param name="timeout">The maximum time in milliseconds that this call blocks before returning.</param>
        /// <param name="services">The <see cref="IWbemServices"/> object.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetResultServices(
            [In] 
            int timeout, 
            [Out]  
            out IWbemServices services);

        #region Description
        /// <summary>
        /// Reports whether a semisynchronous call was successful.
        /// </summary>
        /// <param name="timeout">The maximum time in milliseconds that this call blocks before returning.</param>
        /// <param name="status">The final result status of the call.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetCallStatus(
            [In] 
            int timeout, 
            [Out] 
            out HResult status);  
    }
}
