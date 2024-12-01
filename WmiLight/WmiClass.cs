namespace WmiLight
{
    using System;
    using System.Diagnostics;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// Represents a WMI defined class.
    /// </summary>
    #endregion
    [DebuggerDisplay("{Name,nq}")]
    public class WmiClass : IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WbemServices wbemServices;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WbemClassObject wbemClassObject;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool disposed;

        internal WmiClass(WbemServices wbemServices, WbemClassObject wbemClassObject)
        {
            if (wbemServices is null)
                throw new ArgumentNullException(nameof(wbemServices));

            if (wbemClassObject is null)
                throw new ArgumentNullException(nameof(wbemClassObject));

            this.wbemServices = wbemServices;
            this.wbemClassObject = wbemClassObject;
        }

        #region Description
        /// <summary>
        /// Gets the Class name.
        /// </summary>
        #endregion
        public string Name => this.wbemClassObject.Get<string>(WmiObjectProperty.Class);

        #region Description
        /// <summary>
        /// Gets the name of the namespace of the class or instance.
        /// </summary>
        #endregion
        public string Namespace => this.wbemClassObject.Get<string>(WmiObjectProperty.Namespace);

        #region Description
        /// <summary>
        /// Gets the full path to the class or instance—including server and namespace.
        /// </summary>
        #endregion
        public string Path => this.wbemClassObject.Get<string>(WmiObjectProperty.Path);

        #region Description
        /// <summary>
        /// Gets a method of the class.
        /// </summary>
        /// <param name="methodName">The name of the method.</param>
        /// <returns>The requested WMI method.</returns>
        /// <exception cref="ObjectDisposedException">Object already disposed.</exception>
        /// <exception cref="ArgumentNullException">The <paramref name="methodName"/> parameter is <c>null</c>.</exception>
        #endregion
        public WmiMethod GetMethod(string methodName)
        {
            if (methodName is null)
                throw new ArgumentNullException(nameof(methodName));

            if (this.disposed)
                throw new ObjectDisposedException(nameof(WmiObject));

            this.wbemClassObject.GetMethod(methodName, out WbemClassObject inSignatur, out WbemClassObject outSignatur);

            return new WmiMethod(this, methodName, inSignatur == null ? null : new WmiMethodParametersDefinition(this.wbemServices, inSignatur), outSignatur == null ? null : new WmiMethodParametersDefinition( this.wbemServices, outSignatur));
        }

        #region Description
        /// <summary>
        /// Releases all resources used by the <see cref="WmiClass"/>.
        /// </summary>
        #endregion
        public void Dispose()
        {
            if (!this.disposed)
            {
                this.wbemClassObject.Dispose();
                this.disposed = true;
            }
        }

    }
}
