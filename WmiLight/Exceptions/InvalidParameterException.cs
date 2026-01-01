using WmiLight.Wbem;

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

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidParameterException"/> class.
        /// </summary>
        /// <param name="methodName">The method name.</param>
        /// <param name="className">The class name.</param>
        /// <param name="hresult">The HRESULT.</param>
        #endregion
        internal InvalidParameterException(string methodName, string className, WbemStatus hresult)
            : base($"Parameters provided for the method {methodName} ({className}) are not valid.")
        {
            this.HResult = (int)hresult;
        }

        #endregion
    }
}
