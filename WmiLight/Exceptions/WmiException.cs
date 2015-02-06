namespace WmiLight
{
    using System;

    #region Description
    /// <summary>
    /// The exception that is thrown when a WMI error occurs.
    /// </summary>
    #endregion
    [Serializable]
    public class WmiException : Exception
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiException"/> class.
        /// </summary>
        /// <param name="message">The error message string.</param>
        #endregion
        internal WmiException(string message)
            : base(message)
        {
        }
        
        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiException"/> class.
        /// </summary>
        /// <param name="hresultInfo">The <see cref="HResultInfo"/>.</param>
        #endregion
        internal WmiException(HResultInfo hresultInfo)
            : base(hresultInfo.ErrorMessage)
        {
            base.HResult = (int)hresultInfo.HResult;
        }
        
        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiException"/> class.
        /// </summary>
        /// <param name="message">The error message string.</param>
        /// <param name="innerException">The inner exception reference.</param>
        #endregion
        internal WmiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        
        #endregion

        #region Properties

        #region Description
        /// <summary>
        /// Gets or sets the <see cref="HResult"/>, a coded numerical value that is assigned to a specific exception.
        /// </summary>
        #endregion
        public new int HResult
        {
            get
            {
                return base.HResult;
            }

            protected internal set
            {
                base.HResult = value;
            }
        }

        #endregion
    }
}
