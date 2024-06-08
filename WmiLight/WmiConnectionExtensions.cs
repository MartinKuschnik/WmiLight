using System;
using System.Reflection;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// Static class that contains extension methods for the a <see cref="WmiConnection"/> class.
    /// </summary>
    #endregion
    public static class WmiConnectionExtensions
    {
        #region Description
        /// <summary>
        /// Creates a <see cref="WmiQuery"/> for the given <see cref="string"/>.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wql">The query.</param>
        /// <param name="enumeratorBehaviorOptions">The options that can be used to adjust the behavior of the created enumerator.</param>
        /// <returns>The created <see cref="WmiQuery"/>.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wql"/> is null.</exception>
        #endregion
        public static WmiQuery CreateQuery(this WmiConnection connection, string wql, EnumeratorBehaviorOption enumeratorBehaviorOptions)
        {
            if (wql == null)
                throw new ArgumentNullException(nameof(wql));

            return new WmiQuery(connection, wql, enumeratorBehaviorOptions);
        }

        #region Description
        /// <summary>
        /// Creates a <see cref="WmiQuery"/> for the given <see cref="string"/>.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wql">The query.</param>
        /// <returns>The created <see cref="WmiQuery"/>.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wql"/> is null.</exception>
        #endregion
        public static WmiQuery CreateQuery(this WmiConnection connection, string wql)
        {
            if (wql == null)
                throw new ArgumentNullException(nameof(wql));

            return new WmiQuery(connection, wql);
        }

        /// <summary>
        /// Creates a <see cref="WmiEventWatcher"/> that can be used to subscribes to temporary event notifications based on a specified event query.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wql">A WMI event query, which defines the events for which the watcher will listen.</param>
        /// <returns>The created <see cref="WmiEventWatcher"/>.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wql"/> is null.</exception>
        public static WmiEventWatcher CreateEventWatcher(this WmiConnection connection, string wql)
        {
            if (wql == null)
                throw new ArgumentNullException(nameof(wql));

            return new WmiEventWatcher(connection, wql);
        }

        /// <summary>
        /// Creates a <see cref="WmiEventSubscription"/> that notifies about wmi events.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wql">A WMI event query, which defines the events for which the watcher will listen.</param>
        /// <param name="action">Action that is invoked if the event notification occures.</param>
        /// <returns>The created <see cref="WmiEventSubscription"/>.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wql"/> is null.</exception>
        public static WmiEventSubscription CreateEventSubscription(this WmiConnection connection, string wql, Action<WmiObject> action)
        {
            if (wql == null)
                throw new ArgumentNullException(nameof(wql));

            return connection.ExecNotificationQueryAsync(wql, action);
        }

        #region Description
        /// <summary>
        /// Executes a query to retrieve objects.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="query">The query which will be executed.</param>
        /// <param name="enumeratorBehaviorOptions">The options that can be used to adjust the behavior of the created enumerator.</param>
        /// <returns>An object collection that contains the result set of the query.</returns>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        /// <exception cref="System.ArgumentNullException"><paramref name="query"/> is null.</exception>
        #endregion
        public static WmiObjectEnumerator ExecuteQuery(this WmiConnection connection, string query, EnumeratorBehaviorOption enumeratorBehaviorOptions)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            return connection.ExecuteQuery(connection.CreateQuery(query, enumeratorBehaviorOptions));
        }

        #region Description
        /// <summary>
        /// Executes a query to retrieve objects.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="query">The query which will be executed.</param>
        /// <returns>An object collection that contains the result set of the query.</returns>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        /// <exception cref="System.ArgumentNullException"><paramref name="query"/> is null.</exception>
        #endregion
        public static WmiObjectEnumerator ExecuteQuery(this WmiConnection connection, string query)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            return connection.ExecuteQuery(connection.CreateQuery(query));
        }
    }
}
