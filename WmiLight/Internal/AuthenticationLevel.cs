namespace WmiLight
{
    #region Description
    /// <summary>
    /// Describes the authentication level to be used to connect to WMI. This is used for the COM connection to WMI.
    /// </summary>
    #endregion
    internal enum AuthenticationLevel : int
    {
        #region Description
        /// <summary>
        /// The default COM authentication level. WMI uses the default Windows Authentication setting.
        /// </summary>
        #endregion
        Default = 0,
        #region Description
        /// <summary>
        /// No COM authentication.
        /// </summary>
        #endregion
        None = 1,
        #region Description
        /// <summary>
        /// Connect-level COM authentication.
        /// </summary>
        #endregion
        Connect = 2,
        #region Description
        /// <summary>
        /// Call-level COM authentication.
        /// </summary>
        #endregion
        Call = 3,
        #region Description
        /// <summary>
        /// Packet-level COM authentication.
        /// </summary>
        #endregion
        Packet = 4,
        #region Description
        /// <summary>
        /// Packet Integrity-level COM authentication.
        /// </summary>
        #endregion
        PacketIntegrity = 5,
        #region Description
        /// <summary>
        /// Packet Privacy-level COM authentication.
        /// </summary>
        #endregion
        PacketPrivacy = 6,
        #region Description
        /// <summary>
        /// The default COM authentication level. WMI uses the default Windows Authentication setting.
        /// </summary>
        #endregion
        Unchanged = -1
    }
}
