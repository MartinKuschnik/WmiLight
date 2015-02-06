namespace WmiLight
{
    #region Description
    /// <summary>
    /// The Exception for the case that the Username, password, or authority are specified for a local <see cref="WmiLight.WmiConnection"/>.
    /// </summary>
    #endregion
    public class TransportFailureException : WmiException
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportFailureException"/> class.
        /// </summary>
        /// <param name="hresultInfo">The <see cref="HResultInfo"/>.</param>
        #endregion
        internal TransportFailureException(HResultInfo hresultInfo)
            : base(hresultInfo)
        {
        }

        #endregion
    }
}