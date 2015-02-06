namespace WmiLight
{
    using System;
    using System.Diagnostics;
    using System.Net;
    using WmiLight.Data;
    using WmiLight.Data.Entities;

    #region Description
    /// <summary>
    /// Represents a connection to the WMI-provider of a computer.
    /// </summary>
    #endregion
    public sealed class OBSOLATED_WmiConnection: IDisposable
    {
        #region Constants

        #region Description
        /// <summary>
        /// The default value of the <see cref="OBSOLATED_WmiConnection.path" />-field.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DEFAULT_PATH = @"\\.\root\cimv2";

        #endregion

        #region Fields

        #region Description
        /// <summary>
        /// The object who is used to sync native handle.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object lock_nativeHandle = new object();

        #region Description
        /// <summary>
        /// The path to the requested service.
        /// <para />
        /// Example: "\\Machine1\ROOT\CIMV2"
        /// </summary>
        #endregion
        private readonly string path;

        #region Description
        /// <summary>
        /// The credential with username, password and domain.
        /// </summary>
        #endregion
        private readonly NetworkCredential credential;

        private readonly bool isRemote = false;

        #region Description
        /// <summary>
        /// The pinter to the native handle.
        /// </summary>
        #endregion
        private IntPtr nativeHandle = IntPtr.Zero;

        #region Description
        /// <summary>
        /// true if the instance is already disposed, otherwise false.
        /// </summary>
        #endregion
        private bool disposed;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="OBSOLATED_WmiConnection"/> class.
        /// </summary>
        #endregion
        public OBSOLATED_WmiConnection()
        {
            this.path = DEFAULT_PATH;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="OBSOLATED_WmiConnection"/> class.
        /// </summary>
        /// <param name="path">
        /// The path to the requested service.
        /// <para />
        /// Example: "\ROOT\CIMV2"
        /// </param>
        #endregion
        public OBSOLATED_WmiConnection(string path)
        {
            this.path = path;
        }

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="OBSOLATED_WmiConnection"/> class.
        /// </summary>
        /// <param name="path">
        /// The path to the requested service.
        /// <para />
        /// Example: "\\Machine1\ROOT\CIMV2"
        /// </param>
        /// <param name="credential">The credential with username, password and domain.</param>
        #endregion
        public OBSOLATED_WmiConnection(string path, NetworkCredential credential)
        {
            if (path == null)
            {
                this.path = DEFAULT_PATH;
            }
            else
            {
                this.path = path;
            }

            if (credential == null)
            {
                this.credential = new NetworkCredential();
            } 
            else
	        {
                this.credential = credential;
	        }

            isRemote = true;
        }

        #endregion        

        #region Destructor

        #region Description
        /// <summary>
        /// Disposes of resources the object is holding. This is the destructor for the object. Finalizers are expressed using destructor syntax.
        /// </summary>
        #endregion
        ~OBSOLATED_WmiConnection()
        {
            Dispose();
        }

        #endregion

        #region Properties
        
        #region Description
        /// <summary>
        /// Gets a value indicating whether the connection is alive.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Object is already disposed.</exception>
        #endregion
        public bool IsConnected 
        {
            get
            {
                if (this.disposed)
                {
                    throw new ObjectDisposedException(typeof(OBSOLATED_WmiConnection).Name);
                }

                lock (lock_nativeHandle)
                {
                    return this.nativeHandle != IntPtr.Zero;
                }
            }
        }

        #endregion

        #region Functions

        #region Description
        /// <summary>
        /// Connect to the Server.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Object is already disposed.</exception>
        #endregion
        public void Connect()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(typeof(OBSOLATED_WmiConnection).Name);
            }

            lock (lock_nativeHandle)
            {
                if (this.nativeHandle == IntPtr.Zero)
                {
                    if (this.isRemote)
                    {
                        this.nativeHandle = NativeMethods_DEP.CreateWmiService(path, credential);
                    }
                    else
                    {
                        this.nativeHandle = NativeMethods_DEP.CreateLocalWmiService(path);
                    }
                    
                }               
            }
        }

        #region Description
        /// <summary>
        /// Executes a query to retrieve objects.
        /// </summary>
        /// <param name="query">The query who query will be executed.</param>
        /// <returns>An object collection that contains the result set of the query.</returns>
        /// <exception cref="ObjectDisposedException">Object is already disposed.</exception>
        #endregion
        internal WmiObjectEnumerator ExecQuery(WmiQuery query)
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(typeof(OBSOLATED_WmiConnection).Name);
            }
            
            this.Connect();

            return new WmiObjectEnumerator(NativeMethods_DEP.ExecQuery(this.nativeHandle, query.ToString()));
        }


        internal EntityEnumerator<T> ExecQuery<T>(WmiQuery<T> query) where T : EntityObject, new()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(typeof(OBSOLATED_WmiConnection).Name);
            }

            this.Connect();

            return new EntityEnumerator<T>(NativeMethods_DEP.ExecQuery(this.nativeHandle, query.ToString()));
        }

        public WmiQuery CreateQuery(string wql)
        {
            return new WmiQuery(this, wql);
        }

        public WmiQuery<T> CreateQuery<T>() where T : EntityObject, new()
        {
            return new WmiQuery<T>(this);
        }

        //public WmiQuery<T> CreateQuery<T>(string wql) where T : EntityObject, new()
        //{
        //    return new WmiQuery<T>(this, wql);
        //}

        #region Description
        /// <summary>
        /// Releases all resources used by the <see cref="OBSOLATED_WmiConnection"/>.
        /// </summary>
        #endregion
        public void Dispose()
        {
            if (!this.disposed)
            {
                try
                {
                    lock (this.lock_nativeHandle)
                    {
                        if (this.nativeHandle != IntPtr.Zero)
                        {
                            NativeMethods_DEP.DisposeWmiService(this.nativeHandle);
                        }                        
                    }
                }
                catch (Exception e)
                {
                    // never pass the exception
                    Debug.WriteLine(e.ToString());
                }

                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        #endregion
    }
}
