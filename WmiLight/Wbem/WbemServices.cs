using System;

namespace WmiLight.Wbem
{
    internal class WbemServices : IUnknown
    {
        #region Constructors

        public WbemServices(IntPtr nativeWbemServices)
            : base(nativeWbemServices)
        {
        }

        #endregion

        #region Methods

        internal void SetProxy(ImpersonationLevel impersonate, AuthenticationLevel authLevel)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.SetProxy(this.NativePointer, null, null, null, impersonate, authLevel);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal void SetProxy(string userName, string password, string authority, ImpersonationLevel impersonate, AuthenticationLevel authLevel)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.SetProxy(this.NativePointer, userName, password, authority, impersonate, authLevel);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal WbemClassObjectEnumerator ExecQuery(string query, WbemClassObjectEnumeratorBehaviorOption behaviorOption, IntPtr ctx)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            IntPtr pEnumerator;
            HResult hResult = NativeMethods.ExecQuery(this.NativePointer, "WQL", query, behaviorOption, ctx, out pEnumerator);

            if (hResult.Failed)
                throw (Exception)hResult;

            return new WbemClassObjectEnumerator(pEnumerator);
        }

        internal WbemClassObjectEnumerator ExecQuery(string query, WbemClassObjectEnumeratorBehaviorOption behaviorOption, IntPtr ctx, string userName, string password, string authority, AuthenticationLevel authLevel, ImpersonationLevel impersonate)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            IntPtr pEnumerator;
            HResult hResult = NativeMethods.ExecQuery(this.NativePointer, "WQL", query, behaviorOption, ctx, out pEnumerator);

            if (hResult.Failed)
                throw (Exception)hResult;

            hResult = NativeMethods.SetProxy(pEnumerator, userName, password, authority, impersonate, authLevel);

            if (hResult.Failed)
                throw (Exception)hResult;

            return new WbemClassObjectEnumerator(pEnumerator);
        }

        #endregion
    }
}
