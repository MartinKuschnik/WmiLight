namespace WmiLight
{
    using System;
    using System.Diagnostics;
    using System.Net;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using WmiLight.Wbem;
    
    #region Description
    /// <summary>
    /// Represents a connection to the WMI-provider of a computer.
    /// </summary>
    #endregion
    [DebuggerDisplay("{path}")]
    public partial class WmiConnection : IDisposable
    {
        #region Constants

        #region Description
        /// <summary>
        /// The default value of the <see cref="WmiConnection.path" />-field.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultPath = @"\\.\root\cimv2";

        #endregion

        #region Fields

        #region Description
        /// <summary>
        /// The lock object to sync the connect process.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object connectLockObject = new object();

        #region Description
        /// <summary>
        /// The credential to make a remote connection.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly NetworkCredential credential;

        #region Description
        /// <summary>
        /// The object path of the correct WMI namespace.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string path;

        #region Description
        /// <summary>
        /// All settings to make the WMI connection.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WmiConnectionOptions options = new WmiConnectionOptions();

        #region Description
        /// <summary>
        /// true if the instance is already disposed, otherwise false.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isDisposed = false;

        #region Description
        /// <summary>
        /// true if the <see cref="IWbemServices"/> is connected, otherwise false.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isConnected = false;

        #region Description
        /// <summary>
        /// true if the credential will be ignored, otherwise false.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool ignoreCredential = false;

        #region Description
        /// <summary>
        /// The native <see cref="IWbemServices"/> object.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IWbemServices wbemServices;

#pragma warning disable 0649 // Field is never assigned to, and will always have its default value 'null'.
        #region Description
        /// <summary>
        /// The native <see cref="IWbemContext"/> object.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IWbemContext context;
#pragma warning restore 0649

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiConnection"/> class.
        /// </summary>
        #endregion
        public WmiConnection()
        {
            this.path = WmiConnection.DefaultPath;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiConnection"/> class.
        /// </summary>
        /// <param name="options">Specifies all settings required to make a WMI connection.</param>
        #endregion
        public WmiConnection(WmiConnectionOptions options)
            : base()
        {
            this.options = options;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiConnection"/> class.
        /// </summary>
        /// <param name="path">
        /// The object path of the correct WMI namespace.
        /// <para/>
        /// For local access to the default namespace, use a simple object path: "root\default" or "\\.\root\default". 
        /// <para />
        /// For access to the default namespace on a remote computer using COM or Microsoft-compatible networking, include the computer name: "\\server\root\default". 
        /// </param>
        #endregion
        public WmiConnection(string path)
        {
            this.path = path;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiConnection"/> class.
        /// </summary>
        /// <param name="path">
        /// The object path of the correct WMI namespace.
        /// <para/>
        /// For local access to the default namespace, use a simple object path: "root\default" or "\\.\root\default". 
        /// <para />
        /// For access to the default namespace on a remote computer using COM or Microsoft-compatible networking, include the computer name: "\\server\root\default". 
        /// </param>
        /// <param name="options">Specifies all settings required to make a WMI connection.</param>
        #endregion
        public WmiConnection(string path, WmiConnectionOptions options)
        {
            this.path = path;
            this.options = options;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiConnection"/> class.
        /// </summary>
        /// <param name="path">
        /// The object path of the correct WMI namespace.
        /// <para/>
        /// For local access to the default namespace, use a simple object path: "root\default" or "\\.\root\default". 
        /// <para />
        /// For access to the default namespace on a remote computer using COM or Microsoft-compatible networking, include the computer name: "\\server\root\default". 
        /// </param>
        /// <param name="credential">The credential to make a remote connection.</param>
        #endregion
        public WmiConnection(string path, NetworkCredential credential)
        {
            this.path = path;
            this.credential = credential;
        }
        
        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiConnection"/> class.
        /// </summary>
        /// <param name="path">
        /// The object path of the correct WMI namespace.
        /// <para/>
        /// For local access to the default namespace, use a simple object path: "root\default" or "\\.\root\default". 
        /// <para />
        /// For access to the default namespace on a remote computer using COM or Microsoft-compatible networking, include the computer name: "\\server\root\default". 
        /// </param>
        /// <param name="credential">The credential to make a remote connection.</param>
        /// <param name="options">Specifies all settings required to make a WMI connection.</param>
        #endregion
        public WmiConnection(string path, NetworkCredential credential, WmiConnectionOptions options)
        {
            this.path = path;
            this.credential = credential;
            this.options = options;
        }

        #endregion

        #region Properties
        
        #region Description
        /// <summary>
        /// Gets a value indicating whether the connection is currently bound to a WMI server and namespace.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public bool IsConnected
        {
            get
            {
                if (this.isDisposed)
                {
                    throw new ObjectDisposedException(typeof(WmiConnection).Name);
                }

                return this.isConnected ? true : false;
            }
        }

        #region Description
        /// <summary>
        /// Gets the Authority for a remote connection.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Authority 
        {
            get 
            {
                if (this.credential != null && !string.IsNullOrWhiteSpace(this.credential.Domain))
                {
                    if (this.options.AuthenticationProtocol == AuthenticationProtocol.Kerberos)
                    {
                        return string.Format("Kerberos: {0}", this.credential.Domain);
                    }
                    else
                    {
                        return string.Format("NTLMDOMAIN: {0}", this.credential.Domain);
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        #region Description
        /// <summary>
        /// Gets a value indicating whether the configuration is remote.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsRemote
        {
            get
            {
                return this.credential != null && !this.ignoreCredential;
            }
        }

        #endregion

        #region Functions

        #region Description
        /// <summary>
        /// Establishes a connection to the WMI server and namespace.
        /// </summary>
        #endregion
        public void Open()
        {
            if (this.isDisposed)
            {
                throw new ObjectDisposedException(typeof(WmiConnection).FullName);
            }

            if (!this.isConnected)
            {
                IWbemLocator locator = new WbemLocator();

                lock (this.connectLockObject)
                {
                    if (!this.isConnected)
                    {
                        AuthenticationLevel authLevel = this.options.EnablePackageEncryption ? AuthenticationLevel.PacketIntegrity : AuthenticationLevel.PacketPrivacy;

                        if (this.IsRemote)
                        {
                            try
                            {
                                this.wbemServices = locator.ConnectServer(this.path, this.credential.UserName, this.credential.Password, null, WbemConnectOption.None, this.Authority, this.context);
                                this.wbemServices.SetProxy(this.credential.UserName, this.credential.Password, this.Authority, ImpersonationLevel.Impersonate, authLevel);
                            }
                            catch (LocalCredentialsException)
                            {
                                // try again without credential
                                this.ignoreCredential = true;
                                this.Open();
                                return; // exit method
                            }
                        }
                        else
                        {
                            this.wbemServices = locator.ConnectServer(this.path, null, null, null, WbemConnectOption.None, null, this.context);
                            this.wbemServices.SetProxy(ImpersonationLevel.Impersonate, authLevel);
                        }

                        this.isConnected = true;
                    }
                }
            }
        }

        #region Description
        /// <summary>
        /// Closes the connection and allows reuse of the connection.
        /// </summary>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public void Close()
        {
            if (this.isDisposed)
            {
                throw new ObjectDisposedException(typeof(WmiConnection).FullName);
            }

            if (this.isConnected)
            {
                lock (this.connectLockObject)
                {
                    if (this.isConnected)
                    {
                        if (this.wbemServices != null)
                        {
                            Marshal.ReleaseComObject(this.wbemServices);

                            this.wbemServices = null;
                        }

                        this.isConnected = false;
                    }
                }
            }
        }

        #region Description
        /// <summary>
        /// Creates a <see cref="WmiQuery"/> for the given <see cref="string"/>.
        /// </summary>
        /// <param name="wql">The query.</param>
        /// <returns>The created <see cref="WmiQuery"/>.</returns>
        #endregion
        public WmiQuery CreateQuery(string wql)
        {
            return new WmiQuery(this, wql);
        }

        #region Description
        /// <summary>
        /// Executes a query to retrieve objects.
        /// </summary>
        /// <param name="query">The query which will be executed.</param>
        /// <returns>An object collection that contains the result set of the query.</returns>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        /// <exception cref="System.ArgumentNullException"><paramref name="query"/> is null.</exception>
        #endregion
        public WmiObjectEnumerator ExecuteQuery(string query)
        {
            return new WmiObjectEnumerator(this.InternalExecuteQuery(query));
        }

        #region Description
        /// <summary>
        /// Releases all resources used by the <see cref="WmiConnection"/>.
        /// </summary>
        #endregion
        public void Dispose()
        {
            if (!this.isDisposed)
            {
                this.Close();

                this.isDisposed = true;
            }
        }

        #region Description
        /// <summary>
        /// Executes a query to retrieve objects.
        /// </summary>
        /// <param name="query">The query which will be executed.</param>
        /// <param name="behaviorOption">The flag to influence the behavior of the enumerator.</param>
        /// <returns>An object collection that contains the result set of the query.</returns>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        /// <exception cref="System.ArgumentNullException"><paramref name="query"/> is null.</exception>
        #endregion
        internal IWbemClassObjectEnumerator InternalExecuteQuery(string query, WbemClassObjectEnumeratorBehaviorOption behaviorOption = WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately)
        {
            if (this.isDisposed)
            {
                throw new ObjectDisposedException(typeof(WmiConnection).FullName);
            }

            if (query == null)
            {
                throw new ArgumentNullException(MethodBase.GetCurrentMethod().GetParameters()[0].Name);
            }

            this.Open();

            IWbemClassObjectEnumerator enumerator;

            if (this.IsRemote)
            {
                AuthenticationLevel authLevel = this.options.EnablePackageEncryption ? AuthenticationLevel.PacketPrivacy : AuthenticationLevel.PacketIntegrity;

                // use the native function by the extension method for a faster call
                enumerator = this.wbemServices.ExecQuery(query, behaviorOption, this.context, authLevel, ImpersonationLevel.Impersonate, this.credential.UserName, this.credential.Password, this.Authority);
            }
            else
            {
                enumerator = this.wbemServices.ExecQuery(query, behaviorOption, this.context);
            }

            return enumerator;
        }
        
        #endregion
    }
}
