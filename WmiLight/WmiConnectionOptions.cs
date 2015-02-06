namespace WmiLight
{
    #region Description
    /// <summary>
    /// Specifies all settings required to make a WMI connection.
    /// </summary>
    #endregion
    public class WmiConnectionOptions
    {
        #region Properties
        
        #region Description
        /// <summary>
        /// Gets or sets the mode of authentication.
        /// </summary>
        #endregion
        public AuthenticationProtocol AuthenticationProtocol { get; set; }
        
        #region Description
        /// <summary>
        /// Gets or sets a value indicating whether the packages will be encrypted.
        /// </summary>
        #endregion
        public bool EnablePackageEncryption { get; set; }        

        #endregion
    }
}
