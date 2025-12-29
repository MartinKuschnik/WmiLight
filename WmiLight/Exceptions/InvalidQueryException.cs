using WmiLight.Wbem;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// The exception that is thrown when the specified WMI query is invalid.
    /// </summary>
    #endregion
    public sealed class InvalidQueryException : WmiException
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidQueryException"/> class.
        /// </summary>
        /// <param name="hresultInfo">The <see cref="HResultInfo"/>.</param>
        #endregion
        internal InvalidQueryException(HResultInfo hresultInfo)
            : base(hresultInfo)
        {
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidQueryException"/> class.
        /// </summary>
        /// <param name="query">The invalid query.</param>
        #endregion
        internal InvalidQueryException(string query)
            : base($"The specified query `{query}` is not valid.")
        {
            this.HResult = (int)WbemStatus.WBEM_E_INVALID_QUERY;
            this.Query = query;
        }

        #endregion

        #region Properties

        #region Description
        /// <summary>
        /// Gets the invalid query.
        /// </summary>
        /// <remarks>
        /// The <see cref="Query"/> property is only set if the <see cref="WmiConnection.ExecuteQuery(WmiQuery)"/> is called with a query that has the <see cref="EnumeratorBehaviorOption.DirectRead"/> set.
        /// Otherwise the <see cref="Query"/> property is <c>null</c>.
        /// </remarks>
        #endregion
        public string Query { get; private set; }

        #endregion
    }
}

