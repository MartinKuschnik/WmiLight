namespace WmiLight
{
    #region Description
    /// <summary>
    /// The exception that is thrown when a specified WMI parameter is invalid.
    /// </summary>
    #endregion
    public sealed class InvalidParameterException : WmiException
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidParameterException"/> class.
        /// </summary>
        /// <param name="hresultInfo">The <see cref="HResultInfo"/>.</param>
        #endregion
        internal InvalidParameterException(HResultInfo hresultInfo)
            : base(hresultInfo)
        {
        }

        #endregion
    }
}
