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

            HResult hResult = NativeMethods.SetProxy(this, null, null, null, impersonate, authLevel);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal void SetProxy(string userName, string password, string authority, ImpersonationLevel impersonate, AuthenticationLevel authLevel)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.SetProxy(this, userName, password, authority, impersonate, authLevel);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal WbemClassObjectEnumerator ExecQuery(string query, WbemClassObjectEnumeratorBehaviorOption behaviorOption, IntPtr ctx)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            IntPtr pEnumerator;
            HResult hResult = NativeMethods.ExecQuery(this, "WQL", query, behaviorOption, ctx, out pEnumerator);

            if (hResult.Failed)
                throw (Exception)hResult;

            return new WbemClassObjectEnumerator(pEnumerator);
        }

        internal WbemClassObjectEnumerator ExecQuery(string query, WbemClassObjectEnumeratorBehaviorOption behaviorOption, IntPtr ctx, string userName, string password, string authority, AuthenticationLevel authLevel, ImpersonationLevel impersonate)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            IntPtr pEnumerator;
            HResult hResult = NativeMethods.ExecQuery(this, "WQL", query, behaviorOption, ctx, out pEnumerator);

            if (hResult.Failed)
                throw (Exception)hResult;

            hResult = NativeMethods.SetProxy(pEnumerator, userName, password, authority, impersonate, authLevel);

            if (hResult.Failed)
                throw (Exception)hResult;

            return new WbemClassObjectEnumerator(pEnumerator);
        }

        internal void ExecNotificationQueryAsync(string query, IntPtr ctx, WbemObjectSink sink)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.ExecNotificationQueryAsync(this, "WQL", query, ctx, sink.NativeStub);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal void CancelAsyncCall(WbemObjectSink sink)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.CancelAsyncCall(this, sink.NativeStub);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        #endregion
    }
}
