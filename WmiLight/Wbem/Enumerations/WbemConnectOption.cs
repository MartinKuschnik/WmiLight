namespace WmiLight.Wbem
{
    using System.ComponentModel;

    #region Description
    /// <summary>
    /// The connection option for the <see cref="WbemLocator.ConnectServer"/> call.
    /// </summary>
    #endregion
    internal enum WbemConnectOption : uint
    {
        #region Description
        /// <summary>
        /// The call to <see cref="WbemLocator.ConnectServer"/> returning only after connection to the server is established.
        /// </summary>
        #endregion
        None = 0x00,
        #region Description
        /// <summary>
        /// The call to <see cref="WbemLocator.ConnectServer"/> call returns in 2 minutes or less. 
        /// Use this flag to prevent your program from ceasing to respond indefinitely if the server is broken.
        /// </summary>
        /// <remarks>Windows 2000 and Windows NT 4.0: This value is not available.</remarks>
        #endregion
        UseMaxWait = 0x80
    }
}
