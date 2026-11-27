#if NET7_0_OR_GREATER

namespace WmiLight
{
    using System;
    using System.Runtime.InteropServices.Marshalling;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// Passes an <see cref="IUnknown"/> wrapper to native code as its raw COM pointer.
    /// </summary>
    /// <remarks>
    /// The wrapper is kept reachable until the native call has returned.
    /// Otherwise the GC could finalize it during the call and release the native object while it is still in use.
    /// </remarks>
    #endregion
    [CustomMarshaller(typeof(IUnknown), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
    internal static class IUnknownMarshaller
    {
        public ref struct ManagedToUnmanagedIn
        {
            private IUnknown managed;

            public void FromManaged(IUnknown managed)
            {
                this.managed = managed;
            }

            public IntPtr ToUnmanaged()
            {
                return this.managed is null ? IntPtr.Zero : (IntPtr)this.managed;
            }

            // Called by the generated code directly after the native call has returned.
            public void OnInvoked()
            {
                GC.KeepAlive(this.managed);
            }

            public void Free()
            {
            }
        }
    }
}

#endif
