namespace WmiLight
{
    #region Description
    /// <summary>
    /// Class with information about a <see cref="HResult"/>.
    /// </summary>
    #endregion
    internal class HResultInfo
    {
        #region Fields

        #region Description
        /// <summary>
        /// The error message.
        /// </summary>
        #endregion
        private readonly string errorMessage;

        #region Description
        /// <summary>
        /// The label.
        /// </summary>
        #endregion
        private readonly string label;

        #region Description
        /// <summary>
        /// The associated <see cref="HResult"/>.
        /// </summary>
        #endregion
        private readonly HResult hresult;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="HResultInfo"/> class.
        /// </summary>
        /// <param name="hresult">The associated <see cref="HResult"/>.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="label">The label.</param>
        #endregion
        internal HResultInfo(HResult hresult, string errorMessage, string label)
        {
            this.label = label;
            this.hresult = hresult;
            this.errorMessage = errorMessage;
        }

        #endregion

        #region Properties

        #region Description
        /// <summary>
        /// Gets the associated <see cref="HResult"/>.
        /// </summary>
        #endregion
        internal HResult HResult 
        {
            get
            {
                return this.hresult;
            }
        }

        #region Description
        /// <summary>
        /// Gets the error message.
        /// </summary>
        #endregion
        internal string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }
        }

        #region Description
        /// <summary>
        /// Gets the label.
        /// </summary>
        #endregion
        internal string Label
        {
            get
            {
                return this.label;
            }
        }

        #endregion
    }
}
