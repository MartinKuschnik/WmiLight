using System;

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
        /// <param name="enumeratorTimeout">The timeout for the enumerator.</param>
        /// <returns>The created <see cref="WmiQuery"/>.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wql"/> is null.</exception>
        #endregion
        public static WmiQuery CreateQuery(this WmiConnection connection, string wql, EnumeratorBehaviorOption enumeratorBehaviorOptions, TimeSpan enumeratorTimeout)
        {
            if (wql == null)
                throw new ArgumentNullException(nameof(wql));

            return new WmiQuery(connection, wql, enumeratorBehaviorOptions, enumeratorTimeout);
        }

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

        #region Description
        /// <summary>
        /// Creates a <see cref="WmiQuery"/> for the given <see cref="string"/>.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wql">The query.</param>
        /// <param name="enumeratorTimeout">The timeout for the enumerator.</param>
        /// <returns>The created <see cref="WmiQuery"/>.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wql"/> is null.</exception>
        #endregion
        public static WmiQuery CreateQuery(this WmiConnection connection, string wql, TimeSpan enumeratorTimeout)
        {
            if (wql == null)
                throw new ArgumentNullException(nameof(wql));

            return new WmiQuery(connection, wql, enumeratorTimeout);
        }


        #region Description
        /// <summary>
        /// Creates a WMI query to retrieve all objects related to the 
        /// specified <see cref="WmiObject"/> using its <see cref="WmiObject.Relpath"/>.
        /// The query is constructed as an <c>ASSOCIATORS OF {Relpath}</c> WQL statement.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wmiObject">The source WMI object whose associated objects should be retrieved.</param>
        /// <returns>
        /// A <see cref="WmiQuery"/> representing an <c>ASSOCIATORS OF &#123;Relpath&#125;</c> WQL query.
        /// </returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wmiObject"/> is null.</exception>
        #endregion
        public static WmiQuery CreateQueryForRelated(this WmiConnection connection, WmiObject wmiObject)
        {
            if (wmiObject is null)
                throw new ArgumentNullException(nameof(wmiObject));

            return new WmiQuery(connection, $"ASSOCIATORS OF {{{wmiObject.Relpath}}}");
        }

        #region Description
        /// <summary>
        /// Creates a WMI query to retrieve all objects of a specific class related to the 
        /// specified <see cref="WmiObject"/> using its <see cref="WmiObject.Relpath"/>.
        /// The query is constructed as an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL statement.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wmiObject">The source WMI object whose associated objects should be retrieved.</param>
        /// <param name="relatedClass">The name of the WMI class to filter the related objects.</param>
        /// <returns>
        /// A <see cref="WmiQuery"/> representing an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL query.
        /// </returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wmiObject"/> or <paramref name="relatedClass"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="relatedClass"/> is empty.</exception>
        #endregion
        public static WmiQuery CreateQueryForRelated(this WmiConnection connection, WmiObject wmiObject, string relatedClass)
        {
            if (wmiObject is null)
                throw new ArgumentNullException(nameof(wmiObject));

            if (relatedClass is null)
                throw new ArgumentNullException(nameof(relatedClass));

            if (relatedClass.Length == 0)
                throw new ArgumentException("The related class must not be empty.", nameof(relatedClass));

            return new WmiQuery(connection, $"ASSOCIATORS OF {{{wmiObject.Relpath}}} WHERE ResultClass = {relatedClass}");
        }

        #region Description
        /// <summary>
        /// Creates a WMI query to retrieve all objects of a specific class related to the 
        /// specified <see cref="WmiObject"/> using its <see cref="WmiObject.Relpath"/>.
        /// The query is constructed as an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL statement.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wmiObject">The source WMI object whose associated objects should be retrieved.</param>
        /// <param name="relatedClass">The name of the WMI class to filter the related objects.</param>
        /// <param name="enumeratorBehaviorOptions">The options that can be used to adjust the behavior of the created enumerator.</param>
        /// <param name="enumeratorTimeout">The timeout for the enumerator.</param>
        /// <returns>
        /// A <see cref="WmiQuery"/> representing an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL query.
        /// </returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wmiObject"/> or <paramref name="relatedClass"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="relatedClass"/> is empty.</exception>
        #endregion
        public static WmiQuery CreateQueryForRelated(this WmiConnection connection, WmiObject wmiObject, string relatedClass, EnumeratorBehaviorOption enumeratorBehaviorOptions, TimeSpan enumeratorTimeout)
        {
            if (wmiObject is null)
                throw new ArgumentNullException(nameof(wmiObject));

            if (relatedClass is null)
                throw new ArgumentNullException(nameof(relatedClass));

            if (relatedClass.Length == 0)
                throw new ArgumentException("The related class must not be empty.", nameof(relatedClass));

            return new WmiQuery(connection, $"ASSOCIATORS OF {{{wmiObject.Relpath}}} WHERE ResultClass = {relatedClass}", enumeratorBehaviorOptions, enumeratorTimeout);
        }

        #region Description
        /// <summary>
        /// Creates a WMI query to retrieve all objects of a specific class related to the 
        /// specified <see cref="WmiObject"/> using its <see cref="WmiObject.Relpath"/>.
        /// The query is constructed as an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL statement.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wmiObject">The source WMI object whose associated objects should be retrieved.</param>
        /// <param name="relatedClass">The name of the WMI class to filter the related objects.</param>
        /// <param name="enumeratorBehaviorOptions">The options that can be used to adjust the behavior of the created enumerator.</param>
        /// <returns>
        /// A <see cref="WmiQuery"/> representing an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL query.
        /// </returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wmiObject"/> or <paramref name="relatedClass"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="relatedClass"/> is empty.</exception>
        #endregion
        public static WmiQuery CreateQueryForRelated(this WmiConnection connection, WmiObject wmiObject, string relatedClass, EnumeratorBehaviorOption enumeratorBehaviorOptions)
        {
            if (wmiObject is null)
                throw new ArgumentNullException(nameof(wmiObject));

            if (relatedClass is null)
                throw new ArgumentNullException(nameof(relatedClass));

            if (relatedClass.Length == 0)
                throw new ArgumentException("The related class must not be empty.", nameof(relatedClass));

            return new WmiQuery(connection, $"ASSOCIATORS OF {{{wmiObject.Relpath}}} WHERE ResultClass = {relatedClass}", enumeratorBehaviorOptions);
        }

        #region Description
        /// <summary>
        /// Creates a WMI query to retrieve all objects of a specific class related to the 
        /// specified <see cref="WmiObject"/> using its <see cref="WmiObject.Relpath"/>.
        /// The query is constructed as an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL statement.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="wmiObject">The source WMI object whose associated objects should be retrieved.</param>
        /// <param name="relatedClass">The name of the WMI class to filter the related objects.</param>
        /// <param name="enumeratorTimeout">The timeout for the enumerator.</param>
        /// <returns>
        /// A <see cref="WmiQuery"/> representing an <c>ASSOCIATORS OF {Relpath} WHERE ResultClass = &lt;relatedClass&gt;</c> WQL query.
        /// </returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="wmiObject"/> or <paramref name="relatedClass"/> is null.</exception>
        /// <exception cref="System.ArgumentException"><paramref name="relatedClass"/> is empty.</exception>
        #endregion
        public static WmiQuery CreateQueryForRelated(this WmiConnection connection, WmiObject wmiObject, string relatedClass, TimeSpan enumeratorTimeout)
        {
            if (wmiObject is null)
                throw new ArgumentNullException(nameof(wmiObject));

            if (relatedClass is null)
                throw new ArgumentNullException(nameof(relatedClass));

            if (relatedClass.Length == 0)
                throw new ArgumentException("The related class must not be empty.", nameof(relatedClass));

            return new WmiQuery(connection, $"ASSOCIATORS OF {{{wmiObject.Relpath}}} WHERE ResultClass = {relatedClass}", enumeratorTimeout);
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
        /// <param name="enumeratorBehaviorOptions">The options that can be used to adjust the behavior of the created enumerator.</param>
        /// <param name="enumeratorTimeout">The timeout for the enumerator.</param>
        /// <returns>An object collection that contains the result set of the query.</returns>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        /// <exception cref="System.ArgumentNullException"><paramref name="query"/> is null.</exception>
        #endregion
        public static WmiObjectEnumerator ExecuteQuery(this WmiConnection connection, string query, EnumeratorBehaviorOption enumeratorBehaviorOptions, TimeSpan enumeratorTimeout)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            return connection.ExecuteQuery(connection.CreateQuery(query, enumeratorBehaviorOptions, enumeratorTimeout));
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

        #region Description
        /// <summary>
        /// Gets a WMI method of a specified WMI class.
        /// </summary>
        /// <param name="connection">the extended <see cref="WmiConnection"/> object.</param>
        /// <param name="className">The WMI class name.</param>
        /// <param name="methodName">The WMI method name.</param>
        /// <returns>The requested Method.</returns>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        /// <exception cref="System.ArgumentNullException"><paramref name="className"/> is null.</exception>
        /// <exception cref="System.ArgumentNullException"><paramref name="methodName"/> is null.</exception>
        /// <exception cref="InvalidClassException">The class was not found.</exception>
        /// <exception cref="InvalidMethodException">The method was not found.</exception>
        #endregion
        public static WmiMethod GetMethod(this WmiConnection connection, string className, string methodName)
        {
            if (className is null)
                throw new ArgumentNullException(nameof(className));

            if (methodName is null)
                throw new ArgumentNullException(nameof(methodName));

            return connection.GetClass(className).GetMethod(methodName);
        }
    }
}
