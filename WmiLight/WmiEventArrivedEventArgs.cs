namespace WmiLight
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Holds the event data for the <see cref="WmiEventWatcher.EventArrived"/> event.
    /// </summary>
    public class WmiEventArrivedEventArgs : EventArgs
    {
        #region Fields

        /// <summary>
        /// The WMI event that was delivered.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WmiObject newEvent;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Creates a new instance of the <see cref="WmiEventArrivedEventArgs"/> class.
        /// </summary>
        /// <param name="newEvent">The WMI event that was delivered.</param>
        /// <exception cref="ArgumentNullException"><paramref name="newEvent"/> is null.</exception>
        #endregion
        internal WmiEventArrivedEventArgs(WmiObject newEvent)
        {
            this.newEvent = newEvent ?? throw new ArgumentNullException(nameof(newEvent));
        }

        #endregion

        #region Properties

        #region Description
        /// <summary>
        /// Gets the WMI event that was delivered.
        /// </summary>
        #endregion
        public WmiObject NewEvent => newEvent; 

        #endregion
    }
}
