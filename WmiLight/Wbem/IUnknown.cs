using System;
using System.Runtime.ConstrainedExecution;

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
            // do not throw any exception in destructor
            NativeMethods.ReleaseIUnknown(this.nativePointer);
        }

        public static implicit operator IntPtr(IUnknown iUnknown) => iUnknown.nativePointer;

        protected bool Disposed => this.disposed;

        /// <inheritdoc />
        public void Dispose()
        {
            if (!this.disposed)
            {
                disposed = true;

                NativeMethods.ReleaseIUnknown(this.nativePointer);

                GC.SuppressFinalize(this);
            }
        }
    }
}
