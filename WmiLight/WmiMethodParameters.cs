using System;
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
        internal WmiMethodParameters(WbemServices wbemServices, WbemClassObject signatur)
            :base(wbemServices, signatur)
        {
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
        /// <returns>The raw COM pointer of the <see cref="WmiMethodParameters"/>.</returns>
        /// <remarks>
        /// Only the raw COM pointer is returned. It does not keep the <see cref="WmiMethodParameters"/> alive,
        /// so the GC may finalize the object and release the native object while the pointer is still in use.
        /// The caller must keep the <see cref="WmiMethodParameters"/> reachable for as long as the pointer is used (e.g. with <see cref="GC.KeepAlive(object)"/>).
        /// </remarks>
        #endregion
        [Obsolete("Only the raw COM pointer is returned, which does not keep the WmiMethodParameters alive. The caller must keep the object reachable (e.g. with GC.KeepAlive) for as long as the pointer is used.")]
        public static implicit operator IntPtr(WmiMethodParameters parameters) => (IntPtr)parameters.WbemClassObject;
    }
}
