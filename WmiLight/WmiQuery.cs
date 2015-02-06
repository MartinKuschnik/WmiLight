namespace WmiLight
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;

    #region Description
    /// <summary>
    /// A object to requests wmi.
    /// </summary>
    #endregion
    public sealed class WmiQuery : IEnumerable<WmiObject>
    {
        #region Fields

        #region Description
        /// <summary>
        /// The WQL.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string wql;

        #region Description
        /// <summary>
        /// The <see cref="WmiConnection"/> to execute the query.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WmiConnection connection;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiQuery"/> class.
        /// </summary>
        /// <param name="connection">The wmi connection who should be used.</param>
        /// <param name="wql">
        /// The string representation of a WMI Query Language (WQL) .
        /// <para />
        /// Example: SELECT * FROM Win32_LogicalDisk WHERE FreeSpace &lt; 2097152
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="connection"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="wql"/> is null.</exception>
        #endregion
        public WmiQuery(WmiConnection connection, string wql)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(MethodBase.GetCurrentMethod().GetParameters()[0].Name);
            }

            if (wql == null)
            {
                throw new ArgumentNullException(MethodBase.GetCurrentMethod().GetParameters()[1].Name);
            }

            this.wql = wql;

            this.connection = connection;
        }

        #endregion  
      
        #region Functions

        #region Description
        /// <summary>
        /// Returns the representation as WQL.
        /// </summary>
        /// <returns>The representation as WQL.</returns>
        #endregion
        public override string ToString()
        {
            return this.wql;
        }

        #region Description
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A object that can be used to iterate through the collection.</returns>
        #endregion
        public IEnumerator<WmiObject> GetEnumerator()
        {
            return this.connection.ExecuteQuery(this.wql);
        }

        #region Description
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A IEnumerator that can be used to iterate through the collection.</returns>
        #endregion
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion
    }
}
