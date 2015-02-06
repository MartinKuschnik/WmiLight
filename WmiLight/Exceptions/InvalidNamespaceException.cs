namespace WmiLight
{
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// The exception that is thrown when the specified WMI namespace is invalid.
    /// </summary>
    #endregion
    public sealed class InvalidNamespaceException : WmiException
    {
        #region Constructors
        
        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidNamespaceException"/> class.
        /// </summary>
        /// <param name="hresultInfo">The <see cref="HResultInfo"/>.</param>
        #endregion
        internal InvalidNamespaceException(HResultInfo hresultInfo)
            : base(hresultInfo)
        {
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidNamespaceException"/> class.
        /// </summary>
        /// <param name="path">The invalid namespace.</param>
        #endregion
        internal InvalidNamespaceException(string path)
            : base(string.Format("The specified namespace (\"{0}\") did not exist on the server.", path))
        {
            this.HResult = (int)WbemStatus.WBEM_E_INVALID_NAMESPACE;
            this.Namespace = path;
        }

        #endregion

        #region Properties

        #region Description
        /// <summary>
        /// Gets the invalid namespace.
        /// </summary>
        #endregion
        public string Namespace { get; private set; }

        #endregion
    }
}
