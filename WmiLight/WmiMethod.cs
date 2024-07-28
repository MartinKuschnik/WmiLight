using System;
using System.Diagnostics;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// Represents a WMI defined method.
    /// </summary>
    #endregion
    [DebuggerDisplay("{Name,nq} ({Class.Name,nq})")]
    public class WmiMethod : IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool disposed;

        internal WmiMethod(WmiClass wmiClass, string name, WmiMethodParametersDefinition inParams, WmiMethodParametersDefinition outParams)
        {
            this.Class = wmiClass ?? throw new ArgumentNullException(nameof(wmiClass));
            this.Name = name ?? throw new ArgumentNullException(nameof(name));

            this.InParameters = inParams;
            this.OutParameters = outParams;
        }

        #region Description
        /// <summary>
        /// Gets the method name.
        /// </summary>
        #endregion
        public string Name { get; }

        #region Description
        /// <summary>
        /// Gets the associates WMI class.
        /// </summary>
        #endregion
        public WmiClass Class { get; }

        #region Description
        /// <summary>
        /// <c>true</c> if the WMI method has any in parameter.
        /// </summary>
        #endregion
        public bool HasInParameters => this.InParameters != null;

        private WmiMethodParametersDefinition InParameters { get; }

        private WmiMethodParametersDefinition OutParameters { get; }

        #region Description
        /// <summary>
        /// Creates an object representing the in parameters for a call of WMI this method.
        /// </summary>
        /// <returns>An object representing the in parameters for a call of WMI this method or <c>null</c> if no parameters are </returns>
        #endregion
        public WmiMethodParameters CreateInParameters()
        {
            if (!this.HasInParameters)
                throw new InvalidOperationException($"The WMI method {this.Name} ({this.Class.Name}) does not has any in parameters.");

            return this.InParameters.SpawnInstance();
        }

        #region Description
        /// <summary>
        /// Releases all resources used by the <see cref="WmiMethod"/>.
        /// </summary>
        #endregion
        public void Dispose()
        {
            if (!this.disposed)
            {
                this.InParameters?.Dispose();
                this.OutParameters?.Dispose();
                this.disposed = true;
            }
        }
    }
}
