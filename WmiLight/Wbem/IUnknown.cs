using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace WmiLight.Wbem
{
    internal class IUnknown : CriticalFinalizerObject, IDisposable
    {
        private readonly IntPtr nativePointer;

        private bool disposed = false;

        internal IUnknown(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }

        ~IUnknown()
        {
            if (this.nativePointer != IntPtr.Zero)
                Marshal.Release(this.nativePointer);
        }

        public static implicit operator IntPtr(IUnknown iUnknown) => iUnknown.nativePointer;

        protected bool Disposed => this.disposed;

        /// <inheritdoc />
        public void Dispose()
        {
            if (!this.disposed)
            {
                disposed = true;

                if (this.nativePointer != IntPtr.Zero)
                    Marshal.Release(this.nativePointer);

                GC.SuppressFinalize(this);
            }
        }
    }
}
