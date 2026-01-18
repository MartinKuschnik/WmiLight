namespace WmiLight
{        
    #region Description
    /// <summary>
    /// The Exception for the case that the Username, password, or domain are specified for a local <see cref="WmiLight.WmiConnection"/>.
    /// </summary>
    #endregion
    public class LocalCredentialsException : WmiException
    {
        #region Constructors
        
        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCredentialsException"/> class.
        /// </summary>
        /// <param name="hresultInfo">The <see cref="HResultInfo"/>.</param>
        #endregion
        internal LocalCredentialsException(HResultInfo hresultInfo)
            : base(hresultInfo)
        {
        }

        #endregion
    }
}
