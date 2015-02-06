namespace WmiLight
{
    using System;

    #region Description
    /// <summary>
    /// Attribute to declare an exception for a value of an <see cref="HResult"/> enum.
    /// </summary>
    #endregion
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class ExceptionAttribute : Attribute
    {
        #region Fields

        #region Description
        /// <summary>
        /// The type of the exception.
        /// </summary>
        #endregion
        private readonly Type exceptionType = typeof(WmiException);

        #region Description
        /// <summary>
        /// The message of the exception.
        /// </summary>
        #endregion
        private readonly string exceptionMessage;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionAttribute"/> class.
        /// </summary>
        #endregion
        internal ExceptionAttribute()
        {
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionAttribute"/> class.
        /// </summary>
        /// <param name="exceptionType">The type of the exception.</param>
        #endregion
        internal ExceptionAttribute(Type exceptionType)
        {
            this.exceptionType = exceptionType;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionAttribute"/> class.
        /// </summary>
        /// <param name="exceptionMessage">The message of the exception.</param>
        #endregion
        internal ExceptionAttribute(string exceptionMessage)
        {
            this.exceptionMessage = exceptionMessage;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionAttribute"/> class.
        /// </summary>
        /// <param name="exceptionMessage">The message of the exception.</param>
        /// <param name="exceptionType">The type of the exception.</param>
        #endregion
        internal ExceptionAttribute(string exceptionMessage, Type exceptionType)
        {
            this.exceptionType = exceptionType;
            this.exceptionMessage = exceptionMessage;
        }
        
        #endregion

        #region Properties

        #region Description
        /// <summary>
        /// Gets the type of the exception.
        /// </summary>
        #endregion
        internal Type ExceptionType
        {
            get 
            { 
                return this.exceptionType; 
            }
        }

        #region Description
        /// <summary>
        /// Gets the message of the exception.
        /// </summary>
        #endregion
        internal string ExceptionMessage
        {
            get
            {
                return this.exceptionMessage;
            }
        }
        
        #endregion
    }
}
