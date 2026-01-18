using WmiLight.Wbem;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// The exception that is thrown when the specified WMI method is invalid.
    /// </summary>
    #endregion
    public sealed class InvalidMethodException : WmiException
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidMethodException"/> class.
        /// </summary>
        /// <param name="method">The method name.</param>
        /// <param name="wbemStatus">The HRESULT.</param>
        #endregion
        internal InvalidMethodException(string method, WbemStatus wbemStatus)
            : base($"The method '{method}' did not exist on the server.")
        {
            HResult = (int)wbemStatus;
            Method = method;
        }

        #endregion

        #region Description
        /// <summary>
        /// Gets the name of the invalid Method.
        /// </summary>
        #endregion
        public string Method { get;  }
    }
}
