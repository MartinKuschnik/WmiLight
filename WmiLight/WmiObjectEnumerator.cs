namespace WmiLight
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
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
        /// The native <see cref="WbemClassObjectEnumerator"/> object.
        /// </summary>
        #endregion
        private readonly WbemClassObjectEnumerator wbemClassObjectEnumerator;

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
        /// <param name="enumerator">The the native enumerator.</param>
        /// <exception cref="ArgumentNullException"><paramref name="enumerator"/> is null.</exception>
        #endregion
        internal WmiObjectEnumerator(WbemClassObjectEnumerator enumerator)
        {
            if (enumerator == null)
                throw new ArgumentNullException(nameof(enumerator));

            this.wbemClassObjectEnumerator = enumerator;

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


            if (this.wbemClassObjectEnumerator.Next(out WbemClassObject currentWmiObject))
            {
                this.Current = new WmiObject(currentWmiObject);
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
