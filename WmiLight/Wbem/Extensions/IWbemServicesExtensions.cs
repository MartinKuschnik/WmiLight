namespace WmiLight.Wbem
{
    using System;

    #region Description
    /// <summary>
    /// Static class with extension methods for the <see cref="WmiLight.Wbem.IWbemServices"/> interface.
    /// </summary>
    #endregion
    internal static class IWbemServicesExtensions
    {
        #region Description
        /// <summary>
        /// Sets the authentication information that will be used to make calls on the specified proxy.
        /// </summary>
        /// <param name="this">The <see cref="WmiLight.Wbem.IWbemServices"/> object which will by wrapped with a proxy.</param>
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
        internal static void SetProxy(this IWbemServices @this, string userName, string password, string authority, ImpersonationLevel impersonationLevel, AuthenticationLevel authenticationLevel)
        {
            HResult hr = NativeMethods.CoSetProxyBlanketForIWbemServices.Invoke(@this, userName, password, authority, impersonationLevel, authenticationLevel);

            if (hr.Failed)
            {
                throw (Exception)hr;
            }
        }
        
        #region Description
        /// <summary>
        /// Sets the local authentication information that will be used to make calls on the specified proxy.
        /// </summary>
        /// <param name="this">The <see cref="WmiLight.Wbem.IWbemServices"/> object which will by wrapped with a proxy.</param>
        /// <param name="impersonationLevel">The impersonation level which will be used.</param>
        /// <param name="authenticationLevel">The authentication level which will be used.</param>
        #endregion
        internal static void SetProxy(this IWbemServices @this, ImpersonationLevel impersonationLevel, AuthenticationLevel authenticationLevel)
        {
            HResult hr = NativeMethods.CoSetProxyBlanketForIWbemServices.Invoke(@this, null, null, null, impersonationLevel, authenticationLevel);

            if (hr.Failed)
            {
                throw (Exception)hr;
            }
        }

        #region Description
        /// <summary>
        /// Executes a query to retrieve objects.
        /// </summary>
        /// <param name="this">The <see cref="IWbemServices"/> object which will be used.</param>
        /// <param name="query">The query which will be executed.</param>
        /// <param name="enumeratorBehaviorOption">Flag for the behavior of the created enumerator.</param>
        /// <param name="ctx">
        /// Typically, this is NULL. 
        /// Otherwise, this is an <see cref="WmiLight.Wbem.IWbemContext"/> object required by one or more dynamic class providers.
        /// </param>
        /// <returns>The enumerator for the results of the query.</returns>
        #endregion
        internal static IWbemClassObjectEnumerator ExecQuery(this IWbemServices @this, string query, WbemClassObjectEnumeratorBehaviorOption enumeratorBehaviorOption, IWbemContext ctx)
        {
            IWbemClassObjectEnumerator enumerator;

            HResult hr = @this.ExecQuery("WQL", query, enumeratorBehaviorOption, ctx, out enumerator);

            if (hr.Failed)
            {
                throw (Exception)hr;
            }

            return enumerator;
        }

        #region Description
        /// <summary>
        /// Sets the authentication information and executes a query to retrieve objects.
        /// </summary>
        /// <param name="this">The <see cref="WmiLight.Wbem.IWbemServices"/> object which will by wrapped with a proxy.</param>
        /// <param name="query">The query which will be executed.</param>
        /// <param name="enumeratorBehaviorOption">Flag for the behavior of the created enumerator.</param>
        /// <param name="ctx">
        /// Typically, this is NULL. 
        /// Otherwise, this is an <see cref="WmiLight.Wbem.IWbemContext"/> object required by one or more dynamic class providers.
        /// </param>
        /// <param name="impersonationLevel">The impersonation level which will be used.</param>
        /// <param name="authenticationLevel">The authentication level which will be used.</param>
        /// <param name="userName">The name of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="authority">
        /// The authority to be used to authenticate the specified user.
        /// <para />
        /// Example: "ntlmdomain:MYDOMAIN"
        /// </param>
        /// <returns>The enumerator for the results of the query.</returns>
        #endregion
        internal static IWbemClassObjectEnumerator ExecQuery(this IWbemServices @this, string query, WbemClassObjectEnumeratorBehaviorOption enumeratorBehaviorOption, IWbemContext ctx, AuthenticationLevel impersonationLevel, ImpersonationLevel authenticationLevel, string userName, string password, string authority)
        {
            IWbemClassObjectEnumerator enumerator;

            HResult hr = NativeMethods.ExecQueryWmi("WQL", query, enumeratorBehaviorOption, ctx, out enumerator, impersonationLevel, authenticationLevel, @this, userName, password, authority);

            if (hr.Failed)
            {
                throw (Exception)hr;
            }

            return enumerator;
        }
    }
}