namespace WmiLight
{
    using System;
    using System.Diagnostics;
    using System.Net;
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
        /// true if the <see cref="WbemServices"/> is connected, otherwise false.
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
        /// The native <see cref="WbemServices"/> object.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WbemServices wbemServices;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Lazy<WbemUnsecuredApartment> wbemUnsecuredApartment = new Lazy<WbemUnsecuredApartment>();

#pragma warning disable 0649 // Field is never assigned to, and will always have its default value 'null'.
        #region Description
        /// <summary>
        /// The native context object.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IntPtr context;
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
                    throw new ObjectDisposedException(nameof(WmiConnection));
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
                throw new ObjectDisposedException(nameof(WmiConnection));
            }

            if (!this.isConnected)
            {
                using (WbemLocator locator = new WbemLocator())
                {
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
                throw new ObjectDisposedException(nameof(WmiConnection));

            if (this.isConnected)
            {
                lock (this.connectLockObject)
                {
                    if (this.isConnected)
                    {
                        if (this.wbemServices != null)
                        {
                            this.wbemServices.Dispose();
                            this.wbemServices = null;
                        }

                        this.isConnected = false;
                    }
                }
            }
        }

        #region Description
        /// <summary>
        /// Executes a query to retrieve objects.
        /// </summary>
        /// <param name="query">The query which will be executed.</param>
        /// <returns>An object collection that contains the result set of the query.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="query"/> is null.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public WmiObjectEnumerator ExecuteQuery(WmiQuery query)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            this.Open();

            return new WmiObjectEnumerator(this.wbemServices, this.InternalExecuteQuery(query));
        }

        #region Description
        /// <summary>
        /// Gets a WMI method.
        /// </summary>
        /// <param name="className">The name of the requested WMI method.</param>
        /// <returns>The requested WMI method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="className"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public WmiClass GetClass(string className)
        {
            if (className is null)
                throw new ArgumentNullException(nameof(className));

            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            this.Open();

            return new WmiClass(this.wbemServices.GetClass(className));
        }


        #region Description
        /// <summary>
        /// Deletes an instance of an existing WMI class.
        /// </summary>
        /// <param name="instance">The instance to delete.</param>
        /// <exception cref="System.ArgumentNullException">The <paramref name="instance"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public void DeleteInstance(WmiObject instance)
        {
            if (instance is null)
                throw new ArgumentNullException(nameof(instance));

            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            this.Open();

            this.wbemServices.DeleteInstance(instance.Path);
        }

        #region Description
        /// <summary>
        /// Executed a static WMI method without in parameters.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public object ExecuteMethod(WmiMethod method, out WmiMethodParameters outParameters)
        {
            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            return ExecuteMethod<object>(method.Class.Name, method.Name, IntPtr.Zero, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executed a static WMI method without in parameters.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public TResult ExecuteMethod<TResult>(WmiMethod method, out WmiMethodParameters outParameters)
        {
            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            return ExecuteMethod<TResult>(method.Class.Name, method.Name, IntPtr.Zero, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executed a static WMI method.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="inParameters">The method in parameters.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public object ExecuteMethod(WmiMethod method, WmiMethodParameters inParameters, out WmiMethodParameters outParameters)
        {
            if (inParameters is null)
                return this.ExecuteMethod<object>(method, out outParameters);

            return ExecuteMethod<object>(method.Class.Name, method.Name, inParameters, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executed a static WMI method.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="inParameters">The method in parameters.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public TResult ExecuteMethod<TResult>(WmiMethod method, WmiMethodParameters inParameters, out WmiMethodParameters outParameters)
        {
            if (inParameters is null)
                return this.ExecuteMethod<TResult>(method, out outParameters);

            return ExecuteMethod<TResult>(method.Class.Name, method.Name, inParameters, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executed a none-static WMI method without in parameters.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="instance">The WMI class instance.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public object ExecuteMethod(WmiMethod method, WmiObject instance, out WmiMethodParameters outParameters)
        {
            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            return ExecuteMethod<object>(instance.Path, method.Name, IntPtr.Zero, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executed a none-static WMI method without in parameters.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="instance">The WMI class instance.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public TResult ExecuteMethod<TResult>(WmiMethod method, WmiObject instance, out WmiMethodParameters outParameters)
        {
            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            return ExecuteMethod<TResult>(instance.Path, method.Name, IntPtr.Zero, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executed a none-static WMI method.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="instance">The WMI class instance.</param>
        /// <param name="inParameters">The method in parameters.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public object ExecuteMethod(WmiMethod method, WmiObject instance, WmiMethodParameters inParameters, out WmiMethodParameters outParameters)
        {
            if (inParameters is null)
                return this.ExecuteMethod<object>(method, instance, out outParameters);

            return ExecuteMethod<object>(instance.Path, method.Name, inParameters, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executed a none-static WMI method.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="instance">The WMI class instance.</param>
        /// <param name="inParameters">The method in parameters.</param>
        /// <param name="outParameters">The out parameters of the WMI method.</param>
        /// <returns>The value returned by the method.</returns>
        /// <exception cref="System.ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        /// <exception cref="System.ObjectDisposedException">Object already disposed.</exception>
        #endregion
        public TResult ExecuteMethod<TResult>(WmiMethod method, WmiObject instance, WmiMethodParameters inParameters, out WmiMethodParameters outParameters)
        {
            if (inParameters is null)
                return this.ExecuteMethod<TResult>(method, instance, out outParameters);

            return ExecuteMethod<TResult>(instance.Path, method.Name, inParameters, out outParameters);
        }

        private TResult ExecuteMethod<TResult>(string classNameOrPath, string methodName, IntPtr inParameters, out WmiMethodParameters outParameters)
        {
            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            this.Open();

            this.wbemServices.ExecuteMethod(classNameOrPath, methodName, inParameters, out WbemClassObject wbemOutParams);

            outParameters = new WmiMethodParameters(wbemOutParams);

            return outParameters.GetPropertyValue<TResult>("ReturnValue");
        }

        internal WmiEventSubscription ExecNotificationQueryAsync(string query, Action<WmiObject> action)
        {
            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            if (query == null)
                throw new ArgumentNullException(nameof(query));

            this.Open();

            WbemObjectSink sink = this.wbemUnsecuredApartment.Value.CreateObjectSink();

            // no distinction between remote and local needed
            this.wbemServices.ExecNotificationQueryAsync(query.ToString(), this.context, sink);

            return new WmiEventSubscription(this.wbemServices, sink, action);
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

                if (this.wbemUnsecuredApartment.IsValueCreated)
                    this.wbemUnsecuredApartment.Value.Dispose();

                this.isDisposed = true;
            }
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
        internal WbemClassObjectEnumerator InternalExecuteQuery(WmiQuery query)
        {
            if (this.isDisposed)
                throw new ObjectDisposedException(nameof(WmiConnection));

            if (query == null)
                throw new ArgumentNullException(nameof(query));

            WbemClassObjectEnumeratorBehaviorOption behaviorOption = (WbemClassObjectEnumeratorBehaviorOption)query.EnumeratorBehaviorOption;

            if (this.IsRemote)
            {
                AuthenticationLevel authLevel = this.options.EnablePackageEncryption ? AuthenticationLevel.PacketPrivacy : AuthenticationLevel.PacketIntegrity;

                return this.wbemServices.ExecQuery(query.ToString(), behaviorOption, this.context, this.credential.UserName, this.credential.Password, this.Authority, authLevel, ImpersonationLevel.Impersonate);
            }
            else
            {
                return this.wbemServices.ExecQuery(query.ToString(), behaviorOption, this.context);
            }
        }

        #endregion
    }
}
