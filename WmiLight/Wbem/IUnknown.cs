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

        public static explicit operator IntPtr(IUnknown iUnknown)
        {
            // A disposed object has already released its native object, so its pointer must not be passed to native code anymore.
            // Every path to native code (IUnknownMarshaller, the DllImport wrappers in NativeMethods) uses this conversion.
            if (iUnknown.disposed)
                throw new ObjectDisposedException(iUnknown.GetType().Name);

            return iUnknown.nativePointer;
        }

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
