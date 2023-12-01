﻿using System;
using System.Runtime.ConstrainedExecution;

namespace WmiLight.Wbem
{
    internal class IUnknown : CriticalFinalizerObject, IDisposable
    {
        private readonly IntPtr nativePointer;

        private bool disposed = false;

        protected IUnknown(IntPtr nativePointer)
        {
            this.nativePointer = nativePointer;
        }

        ~IUnknown()
        {
            HResult hResult = NativeMethods.ReleaseIUnknown(this.nativePointer);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        protected IntPtr NativePointer => this.nativePointer;

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
