﻿namespace WmiLight.Wbem
{
    using System;

    internal class WbemLocator : IUnknown
    {
        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WbemLocator"/> class.
        /// </summary>
        #endregion
        public WbemLocator()
            : base(CreateWbemLocator())
        {
        }

        #endregion

        #region Methods

        private static IntPtr CreateWbemLocator()
        {
            IntPtr nativeWbemLocator;

            HResult hResult = NativeMethods.CreateWbemLocator(out nativeWbemLocator);

            if (hResult.Failed)
                throw (Exception)hResult;

            return nativeWbemLocator;
        }

        #region Description
        /// <summary>
        /// Creates a connection through DCOM to a WMI namespace on the computer specified in the <paramref name="networkResource"/> parameter.
        /// </summary>
        /// <param name="networkResource">
        /// The object path of the correct WMI namespace.
        /// <para/>
        /// For local access to the default namespace, use a simple object path: "root\default" or "\\.\root\default". 
        /// <para />
        /// For access to the default namespace on a remote computer using COM or Microsoft-compatible networking, include the computer name: "\\server\root\default". 
        /// </param>
        /// <param name="userName">
        /// The user name you need for a connection. A NULL value indicates the current security context. If the user name is from a domain different from the current domain, the string may contain the domain name and user name separated by a backslash.
        /// <para />
        /// The <paramref name="userName"/> parameter cannot be an empty string. Note that if the domain is specified in <paramref name="authority"/>, then it must not be specified here. Specifying the domain in both parameters results in an invalid parameter error.
        /// <para /> 
        /// You can use the user principal name (UPN) format, which is Username@DomainName to specify the <paramref name="userName"/>.
        /// <para />
        /// <para />
        /// Windows 2000 and Windows NT 4.0:  You cannot use the user principal name (UPN) format.
        /// </param>
        /// <param name="userPassword">The password you need for a connection. A NULL value indicates the current security context. A blank string "" specifies a valid zero-length password.</param>
        /// <param name="locale">
        /// If NULL, the current locale is used. If not NULL, this parameter must indicates the correct locale for information retrieval. 
        /// For Microsoft locale identifiers, the format of the string is "MS_xxx", where xxx is a string in hexadecimal form that indicates the Local Identification (LCID), for example, American English would appear as "MS_409". 
        /// If an invalid locale is specified, then the method returns <see cref="WbemStatus.WBEM_E_INVALID_PARAMETER"/>.
        /// <para />
        /// <para />
        /// Windows 7:  If an invalid locale is specified, then the default locale of the server is used unless there is a server-supported locale provided by the user application.
        /// </param>
        /// <param name="wbemConnectOption">The connection flag.</param>
        /// <param name="authority">
        /// This parameter contains the name of the domain of the user to authenticate.
        /// <para />
        /// <paramref name="authority"/> can have the following values:
        /// <para />
        /// - blank: If you leave this parameter blank, NTLM authentication is used and the NTLM domain of the current user is used. If the domain is specified in <paramref name="userName"/>, 
        /// which is the recommended location, then it must not be specified here. Specifying the domain in both parameters results in an invalid parameter error.
        /// - Kerberos: &lt;principal name&lt; (Kerberos authentication is used and this parameter should contain a Kerberos principal name.)
        /// - NTLMDOMAIN: &lt;domain name&gt; (NT LAN Manager authentication is used and this parameter should contain an NTLM domain name.)
        /// </param>
        /// <param name="ctx">
        /// Typically, this is NULL. 
        /// Otherwise, this is an IWbemContext object required by one or more dynamic class providers.
        /// The values in the context object must be specified in the documentation for the providers in question. 
        /// For more information about this parameter, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392303(v=vs.85).aspx"/>.
        /// </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391769(v=vs.85).aspx"/></remarks>
        #endregion
        internal WbemServices ConnectServer(string networkResource, string userName, string userPassword, string locale, WbemConnectOption wbemConnectOption, string authority, IntPtr ctx)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemLocator));

            IntPtr wbemServices;

            HResult hResult = NativeMethods.ConnectServer(this, networkResource, userName, userPassword, locale, wbemConnectOption, authority, ctx, out wbemServices);

            if (hResult.Failed)
            {
                switch (hResult)
                {
                    case (int)WbemStatus.WBEM_E_INVALID_NAMESPACE:
                        throw new InvalidNamespaceException(networkResource);
                    default:
                        throw (Exception)hResult;
                }
            }

            return new WbemServices(wbemServices);
        }

        #endregion
    }
}
