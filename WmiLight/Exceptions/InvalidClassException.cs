using WmiLight.Wbem;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// The exception that is thrown when the specified WMI class is invalid.
    /// </summary>
    #endregion
    public sealed class InvalidClassException : WmiException
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidClassException"/> class.
        /// </summary>
        /// <param name="hresultInfo">The <see cref="HResultInfo"/>.</param>
        #endregion
        internal InvalidClassException(HResultInfo hresultInfo)
            : base(hresultInfo)
        {
        }

        #endregion
    }
}
