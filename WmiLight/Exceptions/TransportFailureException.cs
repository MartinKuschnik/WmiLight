namespace WmiLight
{
    #region Description
    /// <summary>
    /// The Exception that is thrown when the WMI service returns WBEM_E_TRANSPORT_FAILURE.
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