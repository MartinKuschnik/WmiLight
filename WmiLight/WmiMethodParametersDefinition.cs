﻿using System.Diagnostics;
using System.Linq;
using WmiLight.Wbem;

namespace WmiLight
{
    internal class WmiMethodParametersDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WbemServices wbemServices;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WbemClassObject signatur;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool disposed;

        internal WmiMethodParametersDefinition(WbemServices wbemServices, WbemClassObject signatur)
        {
            this.wbemServices = wbemServices ?? throw new System.ArgumentNullException(nameof(wbemServices));
            this.signatur = signatur ?? throw new System.ArgumentNullException(nameof(signatur));
        }

        #region Description
        /// <summary>
        /// Gets the faked fields for the debugger view.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        private DebuggerFakeField[] DebuggerFakeFields
        {
            get
            {
                return signatur.GetNames().Select(x => new DebuggerFakeField(x, this.signatur.GetCimType(x))).ToArray();
            }
        }

        internal WmiMethodParameters SpawnInstance()
        {
            return new WmiMethodParameters(this.wbemServices, this.signatur.SpawnInstance());
        }

        /// <inheritdoc />
        public void Dispose()
        {
            if (!this.disposed)
            {
                this.signatur.Dispose();
                this.disposed = true;
            }
        }
    }
}
