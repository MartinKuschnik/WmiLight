namespace WmiLight.Wbem
{
    using System;
    using System.Runtime.InteropServices;

    #region Description
    /// <summary>
    /// Used to receive both the results of <see cref="IWbemServices"/> and certain types of event notifications.
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391787(v=vs.85).aspx"/></remarks>
    #endregion
    [ComImport]
    [Guid("7c857801-7381-11cf-884d-00aa004b2e24")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IWbemObjectSink
    {
        #region Description
        /// <summary>
        /// Receives notification objects.
        /// </summary>
        /// <param name="objectCount">Number of objects in the following array of pointers.</param>
        /// <param name="objArray">Array of <see cref="IWbemClassObject"/> interfaces.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Indicate(
            [In]
            int objectCount,
            [In]
            IWbemClassObject[] objArray);

        #region Description
        /// <summary>
        /// Receives notification status.
        /// </summary>
        /// <param name="flags">Bitmask of status information. The status of the operation can be obtained by examining the <paramref name="hresult"/> parameter.</param>
        /// <param name="hresult">The HRESULT of the asynchronous operation or notification.</param>
        /// <param name="param">For example, when using <see cref="IWbemServices.PutInstanceAsync"/>, <see cref="SetStatus"/> is called with this parameter set to the object path of the newly created instance.</param>
        /// <param name="objectParam">In cases where a complex error or status object is returned, this contains the error object.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult SetStatus(
            [In]  
            int flags,
            [In]  
            HResult hresult,
            [In, MarshalAs(UnmanagedType.BStr)]
            string param,
            [In]  
            IWbemClassObject objectParam);
    }
}
