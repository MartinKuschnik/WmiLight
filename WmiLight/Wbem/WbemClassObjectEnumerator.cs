using System;

namespace WmiLight.Wbem
{
    internal class WbemClassObjectEnumerator : IUnknown
    {
        internal WbemClassObjectEnumerator(IntPtr nativePointer) 
            : base(nativePointer)
        {
        }

        internal bool Next(out WbemClassObject wbemClassObject)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObjectEnumerator));

            IntPtr pClassObject;
            
            HResult hResult = NativeMethods.Next(this.NativePointer, out pClassObject);

            if (hResult.Failed)
                throw (Exception)hResult;

            if (hResult == WbemStatus.WBEM_S_FALSE)
            {
                wbemClassObject = null;
                return false;
            }

            wbemClassObject = new WbemClassObject(pClassObject);
            return true;
        }

        internal void Reset()
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObjectEnumerator));

            HResult hResult =  NativeMethods.Reset(this.NativePointer);

            if (hResult.Failed)
                throw (Exception)hResult;
        }
    }
}
