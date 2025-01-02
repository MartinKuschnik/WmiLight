using System;
using System.Diagnostics;
using WmiLight.Wbem;

namespace WmiLight
{
    #region Description
    /// <summary>
    /// Represents the in and out parameters of a WMI defined method.
    /// </summary>
    #endregion
    public class WmiMethodParameters : WmiObject
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WbemClassObject signatur;

        internal WmiMethodParameters(WbemServices wbemServices, WbemClassObject signatur)
            :base(wbemServices, signatur)
        {
            this.signatur = signatur ?? throw new ArgumentNullException(nameof(signatur));
        }

        /// <inheritdoc />
        public override void Put()
        {
            throw new NotSupportedException();
        }

        #region Description
        /// <summary>
        /// Implicit conversion from <see cref="WmiMethodParameters"/> to <see cref="IntPtr"/>.
        /// </summary>
        /// <param name="parameters">The <see cref="WmiMethodParameters"/> value to convert to <see cref="IntPtr"/>.</param>
        /// <returns>The <see cref="IntPtr"/> value as <see cref="WmiMethodParameters"/>.</returns>
        #endregion
        public static implicit operator IntPtr(WmiMethodParameters parameters) => parameters.signatur;
    }
}
