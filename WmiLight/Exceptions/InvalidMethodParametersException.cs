using WmiLight.Wbem;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// The exception that is thrown when the provided parameters for a WMI method are not valid.
    /// </summary>
    #endregion
    public sealed class InvalidMethodParametersException : WmiException
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidMethodParametersException"/> class.
        /// </summary>
        /// <param name="methodName">The method name.</param>
        /// <param name="className">The class name.</param>
        /// <param name="hresult">The HRESULT.</param>
        #endregion
        internal InvalidMethodParametersException(string methodName, string className, WbemStatus hresult)
            : base($"Parameters provided for the method {methodName} ({className}) are not valid.")
        {
            this.HResult = (int)hresult;
        }

        #endregion
    }
}
