namespace WmiLight.Wbem
{
    using System;
    using System.Runtime.InteropServices;

    #region Description
    /// <summary>
    /// Enumerator that works with objects of type <see cref="IWbemClassObject"/>.
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa390857(v=vs.85).aspx"/></remarks>
    #endregion
    [ComImport]
    [Guid("027947e1-d731-11ce-a357-000000000001")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [TypeLibTypeAttribute(TypeLibTypeFlags.FRestricted)]
    internal interface IWbemClassObjectEnumerator
    {
        #region Description
        /// <summary>
        /// Resets an enumeration sequence back to the beginning.
        /// </summary>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Reset();

        #region Description
        /// <summary>
        /// Retrieves the next object (or objects) in the enumeration starting from the current position.
        /// </summary>
        /// <param name="timeOut">
        /// Specifies the maximum amount of time in milliseconds that the call blocks before returning. <para />
        /// If you use the constant <see cref="System.Threading.Timeout.Infinite"/>, the call blocks until objects are available. <para />
        /// If you use the value 0, the call returns immediately, whether any objects are available or not.
        /// </param>
        /// <param name="count">Number of requested objects.</param>
        /// <param name="objects">The requested object.</param>
        /// <param name="returnedCount">The number of objects returned.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Next(
          [In]   
          int timeOut,
          [In]   
          uint count,
          [Out]   
          out IWbemClassObject objects,
          [Out]  
          out uint returnedCount);

        #region Description
        /// <summary>
        /// Retrieves the next object or objects using asynchronous integration with <see cref="IWbemObjectSink"/>.
        /// </summary>
        /// <param name="count">Number of objects being requested.</param>
        /// <param name="sink">Sink to receive the objects. The sink must be implemented by the caller.</param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult NextAsync( 
             [In] uint count,
             [In] IWbemObjectSink sink);

        #region Description
        /// <summary>
        /// Makes a copy of the enumerator.
        /// </summary>
        /// <param name="enumerator">A new <see cref="IWbemClassObjectEnumerator"/> object. </param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Clone(
            [Out]
            out IWbemClassObjectEnumerator enumerator);

        #region Description
        /// <summary>
        /// Causes the enumeration to skip ahead so that future calls to the Next method retrieve objects one, or more, ahead of the current location in the enumeration.
        /// </summary>
        /// <param name="timeOut">
        /// Maximum amount of time in milliseconds that the call to Skip blocks before returning. <para />
        /// If you use the constant <see cref="System.Threading.Timeout.Infinite"/>, the call blocks until the operation succeeds. <para />
        /// If Skip cannot complete the operation before the <paramref name="timeOut"/> value expires, the call returns <see cref="WbemStatus.WBEM_S_TIMEDOUT"/>.
        /// </param>
        /// <param name="count">
        /// Number of objects to skip. <para />
        /// If this parameter is greater than the number of objects left to enumerate, then this call skips to the end of the enumeration and <see cref="WbemStatus.WBEM_S_FALSE"/> is returned.
        /// </param>
        /// <returns>A value that gives information about the status of an operation</returns>
        #endregion
        [PreserveSig]
        HResult Skip(
            [In]  
            int timeOut,
            [In]  
            uint count);
    }
}
