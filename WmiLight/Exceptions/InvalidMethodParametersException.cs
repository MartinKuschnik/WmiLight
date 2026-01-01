using WmiLight.Wbem;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// The exception that is thrown when the provided parameters for a WMI method are not valid .
    /// </summary>
    #endregion
    public sealed class InvalidMethodParametersException : WmiException
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidMethodParametersException"/> class.
        /// </summary>
        /// <param name="method">The method name.</param>
        /// <param name="hresult">The HRESULT.</param>
        #endregion
        internal InvalidMethodParametersException(string method, WbemStatus hresult)
            : base($"Parameters provided for the method '{method}' are not valid.")
        {
            this.HResult = (int)hresult;
        }

        #endregion
    }
}
