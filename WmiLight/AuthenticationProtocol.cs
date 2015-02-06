namespace WmiLight
{
    #region Description
    /// <summary>
    /// Specify different authentication modes.
    /// </summary>
    #endregion
    public enum AuthenticationProtocol : int
    {
        #region Description
        /// <summary>
        /// Authentication over the NTLM protocol.
        /// </summary>
        #endregion
        NTLM = 0,
        #region Description
        /// <summary>
        /// Authentication over the Kerberos protocol.
        /// </summary>
        #endregion
        Kerberos = 1
    }
}
