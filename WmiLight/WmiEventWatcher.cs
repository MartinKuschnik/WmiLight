namespace WmiLight
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Subscribes to temporary event notifications based on a specified event query.
    /// </summary>
    public class WmiEventWatcher : IDisposable
    {
        #region Fileds

        private readonly WmiConnection connection;

        private readonly string notificationQuery;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object syncRoot = new object();

        private WmiEventSubscription subscription;

        private bool disposed = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of the <see cref="WmiEventWatcher"/> class.
        /// </summary>
        /// <param name="connection">The connection that should be used.</param>
        /// <param name="notificationQuery">A WMI event query, which defines the events for which the watcher will listen.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="connection"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="notificationQuery"/> is <c>null</c>.</exception>
        public WmiEventWatcher(WmiConnection connection, string notificationQuery)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
            this.notificationQuery = notificationQuery ?? throw new ArgumentNullException(nameof(notificationQuery));
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when a new event arrives.
        /// </summary>
        public event EventHandler<WmiEventArrivedEventArgs> EventArrived;

        #endregion

        #region Methods

        /// <summary>
        /// Subscribes to events with the given query and delivers them, asynchronously, through the <see cref="EventArrived"/> event.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Object already disposed.</exception>
        public void Start()
        {
            if (this.disposed)
                throw new ObjectDisposedException(nameof(WmiEventWatcher));

            lock (syncRoot)
            {
                if (this.subscription == null)
                {
                    this.subscription = this.connection.ExecNotificationQueryAsync(this.notificationQuery, x => this.EventArrived?.Invoke(this, new WmiEventArrivedEventArgs(x)));
                }
            }
        }

        /// <summary>
        /// Cancels the subscription whether it is synchronous or asynchronous.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Object already disposed.</exception>
        public void Stop()
        {
            if (this.disposed)
                throw new ObjectDisposedException(nameof(WmiEventWatcher));

            lock (syncRoot)
            {
                if (this.subscription != null)
                {
                    this.subscription.Dispose();

                    this.subscription = null;
                }
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            if (!this.disposed)
            {
                this.disposed = true;

                lock (syncRoot)
                {
                    if (this.subscription != null)
                        this.subscription.Dispose();
                }
            }
        }

        #endregion
    }
}
