namespace WmiLight
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// Represents a collection of <see cref="WmiObject"/>s.
    /// </summary>
    #endregion
    public sealed class WmiObjectEnumerator : IEnumerator<WmiObject>
    {
        #region Fields

        #region Description
        /// <summary>
        /// The native <see cref="WbemServices"/> object.
        /// </summary>
        #endregion
        private readonly WbemServices wbemServices;

        #region Description
        /// <summary>
        /// The native <see cref="WbemClassObjectEnumerator"/> object.
        /// </summary>
        #endregion
        private readonly WbemClassObjectEnumerator wbemClassObjectEnumerator;

        #region Description
        /// <summary>
        /// The timeout for the enumerator or <c>null</c> for no timeout.
        /// </summary>
        #endregion
        private readonly TimeSpan? timeout;

        #region Description
        /// <summary>
        /// true if the instance is already disposed, otherwise false.
        /// </summary>
        #endregion
        private bool disposed;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiObjectEnumerator"/> class.
        /// </summary>
        /// <param name="wbemServices">The native <see cref="WbemServices"/> object.</param>
        /// <param name="enumerator">The the native enumerator.</param>
        /// <param name="timeout">The timeout for the enumerator or <c>null</c> for no timeout.</param>
        /// <exception cref="ArgumentNullException"><paramref name="wbemServices"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="enumerator"/> is null.</exception>
        #endregion
        internal WmiObjectEnumerator(WbemServices wbemServices, WbemClassObjectEnumerator enumerator, TimeSpan? timeout)
        {
            if (wbemServices == null)
                throw new ArgumentNullException(nameof(wbemServices));

            if (enumerator == null)
                throw new ArgumentNullException(nameof(enumerator));

            this.wbemServices = wbemServices;
            this.wbemClassObjectEnumerator = enumerator;
            this.timeout = timeout;

            enumerator.Reset();
        }

        #endregion

        #region Functions

        #region Description
        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        #endregion
        public WmiObject Current { get; private set; }

        #region Description
        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        #endregion
        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        #region Description
        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.</returns>
        #endregion
        public bool MoveNext()
        {
            if (this.disposed)
                throw new ObjectDisposedException(nameof(WmiObjectEnumerator));

            int timeout = this.timeout.HasValue ? (int)this.timeout.Value.TotalMilliseconds : Timeout.Infinite;

            if (this.wbemClassObjectEnumerator.Next(timeout, out WbemClassObject currentWmiObject))
            {
                this.Current = new WmiObject(this.wbemServices, currentWmiObject);
                return true;
            }

            return false;
        }

        #region Description
        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection.
        /// </summary>
        #endregion
        public void Reset()
        {
            if (this.disposed)
                throw new ObjectDisposedException(nameof(WmiObjectEnumerator));

            this.wbemClassObjectEnumerator.Reset();
        }

        #region Description
        /// <summary>
        /// Releases all resources used by the <see cref="WmiObjectEnumerator"/>.
        /// </summary>
        #endregion
        public void Dispose()
        {
            if (!this.disposed)
            {
                this.disposed = true;

                this.wbemClassObjectEnumerator.Dispose();
            }
        }

        #endregion
    }
}
