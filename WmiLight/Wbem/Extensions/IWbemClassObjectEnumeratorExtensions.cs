namespace WmiLight.Wbem
{
    using System;
    using System.Threading;

    #region Description
    /// <summary>
    /// Static class with extension methods for the <see cref="WmiLight.Wbem.IWbemClassObjectEnumerator"/> interface.
    /// </summary>
    #endregion
    internal static class IWbemClassObjectEnumeratorExtensions
    {
        #region Description
        /// <summary>
        /// Sets the authentication information that will be used to make calls on the specified proxy.
        /// </summary>
        /// <param name="this">The <see cref="WmiLight.Wbem.IWbemClassObjectEnumerator"/> object which will by wrapped with a proxy.</param>
        /// <param name="userName">The name of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="authority">
        /// The authority to be used to authenticate the specified user.
        /// <para />
        /// Example: "ntlmdomain:MYDOMAIN"
        /// </param>
        /// <param name="impersonationLevel">The impersonation level which will be used.</param>
        /// <param name="authenticationLevel">The authentication level which will be used.</param>
        #endregion
        internal static void SetProxy(this IWbemClassObjectEnumerator @this, string userName, string password, string authority, ImpersonationLevel impersonationLevel, AuthenticationLevel authenticationLevel)
        {
            HResult hr = NativeMethods.CoSetProxyBlanketForIWbemClassObjectEnumerator.Invoke(@this, userName, password, authority, impersonationLevel, authenticationLevel);

            if (hr.Failed)
            {
                throw (Exception)hr;
            }
        }

        #region Description
        /// <summary>
        /// Retrieves the next object in the enumeration starting from the current position.
        /// </summary>
        /// <param name="this">The <see cref="WmiLight.Wbem.IWbemClassObjectEnumerator"/> which will be moved.</param>
        /// <returns>The next object in the enumeration.</returns>
        #endregion
        internal static IWbemClassObject Next(this IWbemClassObjectEnumerator @this)
        {
            IWbemClassObject current = null;
            uint returnedCount;

            HResult hresult = @this.Next(Timeout.Infinite, 1, out current, out returnedCount);

            if (hresult.Failed)
            {
                throw (Exception)hresult;
            }

            return current;
        }
    }
}
