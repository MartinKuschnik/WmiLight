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
            {
                switch (hResult)
                {
                    // The error indicating that the query is invalid is only returned here if the EnumeratorBehaviorOption DirectRead is set.
                    case (int)WbemStatus.WBEM_E_INVALID_QUERY:
                        throw new InvalidQueryException(query);

                    default:
                        throw (Exception)hResult;
                }
            }

            return new WbemClassObjectEnumerator(pEnumerator);
        }

        internal WbemClassObjectEnumerator ExecQuery(string query, WbemClassObjectEnumeratorBehaviorOption behaviorOption, IntPtr ctx, string userName, string password, string authority, AuthenticationLevel authLevel, ImpersonationLevel impersonate)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            IntPtr pEnumerator;
            HResult hResult = NativeMethods.ExecQuery(this, "WQL", query, behaviorOption, ctx, out pEnumerator);

            if (hResult.Failed)
            {
                switch (hResult)
                {
                    // The error indicating that the query is invalid is only returned here if the EnumeratorBehaviorOption DirectRead is set.
                    case (int)WbemStatus.WBEM_E_INVALID_QUERY:
                        throw new InvalidQueryException(query);

                    default:
                        throw (Exception)hResult;
                }
            }

            hResult = NativeMethods.SetProxy(pEnumerator, userName, password, authority, impersonate, authLevel);

            if (hResult.Failed)
                throw (Exception)hResult;

            return new WbemClassObjectEnumerator(pEnumerator);
        }

        internal void PutInstance(WbemClassObject wbemClassObject, IntPtr ctx)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.PutInstance(this, wbemClassObject, ctx);

            if (hResult.Failed)
                throw (Exception)hResult;
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

        internal WbemClassObject GetClass(string className)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            IntPtr pClassDef;

            HResult hResult = NativeMethods.GetClass(this, className, IntPtr.Zero, out pClassDef);

            if (hResult.Failed)
            {
                switch (hResult)
                {
                    case (int)WbemStatus.WBEM_E_NOT_FOUND:
                        throw new InvalidClassException(className, WbemStatus.WBEM_E_NOT_FOUND);

                    default:
                        throw (Exception)hResult;
                }
            }

            return new WbemClassObject(pClassDef);
        }

        internal void DeleteInstance(string strObjectPath)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.DeleteInstance(this, strObjectPath, IntPtr.Zero);

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal void ExecuteMethod(string classNameOrPath, string methodName, IntPtr inParams, out WbemClassObject outParams)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemServices));

            HResult hResult = NativeMethods.ExecMethod(this, classNameOrPath, methodName, IntPtr.Zero, inParams, out IntPtr pOutParams);

            if (hResult.Failed)
            {
                switch (hResult)
                {
                    case (int)WbemStatus.WBEM_E_INVALID_METHOD_PARAMETERS:
                        throw new InvalidParameterException(methodName, classNameOrPath, WbemStatus.WBEM_E_INVALID_METHOD_PARAMETERS);

                    case (int)WbemStatus.WBEM_E_INVALID_PARAMETER:
                        throw new InvalidParameterException(methodName, classNameOrPath, WbemStatus.WBEM_E_INVALID_PARAMETER);

                    default:
                        throw (Exception)hResult;
                }
            }

            if (pOutParams != IntPtr.Zero)
                outParams = new WbemClassObject(pOutParams);
            else
                outParams = null;
        }

        #endregion
    }
}
