namespace WmiLight
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// Contains and manipulates both class definitions and class object instances.
    /// </summary>
    #endregion
    public class WmiObject : IDisposable
    {
        #region Fields

        #region Description
        /// <summary>
        /// The native <see cref="WbemServices"/> object.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WbemServices wbemServices;

        #region Description
        /// <summary>
        /// The native <see cref="WbemClassObject"/> object.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WbemClassObject wbemClassObject;

        #region Description
        /// <summary>
        /// true if the instance is already disposed, otherwise false.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool disposed;

        #endregion

        #region Constructors

        #region Description
        /// <summary>
        /// Initializes a new instance of the <see cref="WmiObject"/> class.
        /// </summary>
        /// <param name="wbemServices">The native <see cref="WbemServices"/> object.</param>
        /// <param name="wmiObject">The native <see cref="WbemClassObject"/> object.</param>
        #endregion
        internal WmiObject(WbemServices wbemServices, WbemClassObject wmiObject)
        {
            if (wbemServices == null)
                throw new ArgumentNullException(nameof(wbemServices));

            if (wmiObject == null)
                throw new ArgumentNullException(nameof(wmiObject));

            this.wbemServices = wbemServices;
            this.wbemClassObject = wmiObject;
        }

        #endregion        
        
        #region Properties

        #region Description
        /// <summary>
        /// Gets the value that is used to distinguish between classes and instances.
        /// </summary>
        #endregion
        public WmiObjectGenus Genus
        {
            get
            {
                return (WmiObjectGenus)this.GetPropertyValue(WmiObjectProperty.Genus);
            }
        }

        #region Description
        /// <summary>
        /// Gets the Class name.
        /// </summary>
        #endregion
        public string Class
        {
            get
            {
                return (string)this.GetPropertyValue(WmiObjectProperty.Class);
            }
        }

        #region Description
        /// <summary>
        /// Gets the name of the immediate parent class of the class or instance.
        /// </summary>
        #endregion
        public string SuperClass
        {
            get
            {
                return (string)this.GetPropertyValue(WmiObjectProperty.SuperClass);
            }
        }

        #region Description
        /// <summary>
        /// Gets the name of the top-level class from which the class or instance is derived. <para />
        /// When this class or instance is the top-level class, the values of <see cref="Dynasty"/> property and the <see cref="Class"/> property are the same.
        /// </summary>
        #endregion
        public string Dynasty
        {
            get
            {
                return (string)this.GetPropertyValue(WmiObjectProperty.Dynasty);
            }
        }

        #region Description
        /// <summary>
        /// Gets the relative path to the class or instance.
        /// </summary>
        #endregion
        public string Relpath
        {
            get
            {
                return (string)this.GetPropertyValue(WmiObjectProperty.Relpath);
            }
        }

        #region Description
        /// <summary>
        /// Gets the number of nonsystem properties defined for the class or instance.
        /// </summary>
        #endregion
        public int PropertyCount
        {
            get
            {
                return (int)this.GetPropertyValue(WmiObjectProperty.PropertyCount);
            }
        }

        #region Description
        /// <summary>
        /// Gets the class hierarchy of the current class or instance. <para />
        /// The first element is the immediate parent class, the next is its parent, and so on; the last element is the base class.
        /// </summary>
        #endregion
        public string[] Derivation
        {
            get
            {
                return (string[])this.GetPropertyValue(WmiObjectProperty.Derivation);
            }
        }

        #region Description
        /// <summary>
        /// Gets the name of the server supplying the class or instance.
        /// </summary>
        #endregion
        public string Server
        {
            get
            {
                return (string)this.GetPropertyValue(WmiObjectProperty.Server);
            }
        }

        #region Description
        /// <summary>
        /// Gets the name of the namespace of the class or instance.
        /// </summary>
        #endregion
        public string Namespace
        {
            get
            {
                return (string)this.GetPropertyValue(WmiObjectProperty.Namespace);
            }
        }

        #region Description
        /// <summary>
        /// Gets the full path to the class or instance—including server and namespace.
        /// </summary>
        #endregion
        public string Path
        {
            get
            {
                return (string)this.GetPropertyValue(WmiObjectProperty.Path);
            }
        }

        #region Description
        /// <summary>
        /// Gets the faked fields for the debugger view.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        private DebuggerFakeField[] DebuggerFakeFields
        {
            get
            {
                return this.GetPropertyNames().Select(x => new DebuggerFakeField(x, this[x])).ToArray();
            }
        }

        #region Description
        /// <summary>
        /// Gets a particular property value.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns>The particular property value.</returns>
        #endregion
        public object this[string propertyName]
        {
            get
            {
                return this.GetPropertyValue(propertyName);
            }
        }

        #endregion

        #region Functions

        #region Description
        /// <summary>
        /// Gets a WMI method for this class.
        /// </summary>
        /// <param name="methodName">The WMI method name.</param>
        /// <returns>The requested Method.</returns>
        /// <exception cref="System.ArgumentNullException"><paramref name="methodName"/> is null.</exception>
        #endregion
        public WmiMethod GetMethod(string methodName)
        {
            WmiClass wmiClass = new WmiClass(this.wbemServices.GetClass(this.Class));

            return wmiClass.GetMethod(methodName);
        }

        #region Description
        /// <summary>
        /// Gets the names of all properties in the object.
        /// </summary>
        /// <returns>The names of all properties.</returns>
        #endregion
        public IEnumerable<string> GetPropertyNames()
        {
            return this.wbemClassObject.GetNames();
        }

        #region Description
        /// <summary>
        /// Gets a particular property value.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns>The particular property value.</returns>
        #endregion
        public object GetPropertyValue(string propertyName)
        {
            if (this.disposed)
                throw new ObjectDisposedException(nameof(WmiObject));

            object obj = this.wbemClassObject.Get(propertyName);

            if (obj is WbemClassObject wbemClassObject)
                return new WmiObject(this.wbemServices, wbemClassObject);

            if (obj is WbemClassObject[] wbemClassObjectArray)
            {
                WmiObject[] wmiObjects = new WmiObject[wbemClassObjectArray.Length];

                for (int i = 0; i < wmiObjects.Length; i++)
                    wmiObjects[i] = new WmiObject(this.wbemServices, wbemClassObjectArray[i]);

                return wmiObjects;

            }

            return obj;
        }

        #region Description
        /// <summary>
        /// Gets a particular property value.
        /// </summary>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns>The particular property value.</returns>
        #endregion
        public TResult GetPropertyValue<TResult>(string propertyName)
        {
            if (this.disposed)
                throw new ObjectDisposedException(nameof(WmiObject));

            if (typeof(TResult) == typeof(WmiObject))
            {
                return (TResult)(object)new WmiObject(this.wbemServices, wbemClassObject.Get<WbemClassObject>(propertyName));
            }

            if (typeof(TResult) == typeof(WmiObject[]))
            {
                WbemClassObject[] wbemClassObjectArray = wbemClassObject.Get<WbemClassObject[]>(propertyName);

                if (wbemClassObjectArray is null)
                    return (TResult)(object)null;

                WmiObject[] wmiObjects = new WmiObject[wbemClassObjectArray.Length];

                for (int i = 0; i < wmiObjects.Length; i++)
                    wmiObjects[i] = new WmiObject(this.wbemServices, wbemClassObjectArray[i]);

                return (TResult)(object)wmiObjects;
            }

            return wbemClassObject.Get<TResult>(propertyName);
        }

        #region Description
        /// <summary>
        /// Executes a static WMI method.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="outParameters">The out parameters returned by the method.</param>
        /// <returns>The return value of the method.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        #endregion
        public object ExecuteMethod(WmiMethod method, out WmiMethodParameters outParameters)
        {
            if (method is null)
                throw new ArgumentNullException(nameof(method));

            return this.ExecuteMethod<object>(method.Name, IntPtr.Zero, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executes a static WMI method.
        /// </summary>
        /// <typeparam name="TReturnValue">The return value type.</typeparam>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="outParameters">The out parameters returned by the method.</param>
        /// <returns>The return value of the method.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>
        #endregion
        public TReturnValue ExecuteMethod<TReturnValue>(WmiMethod method, out WmiMethodParameters outParameters)
        {
            if (method is null)
                throw new ArgumentNullException(nameof(method));

            return this.ExecuteMethod<TReturnValue>(method.Name, IntPtr.Zero, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executes a static WMI method.
        /// </summary>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="inParameters">The parameters for the method.</param>
        /// <param name="outParameters">The out parameters returned by the method.</param>
        /// <returns>The return value of the method.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>

        #endregion
        public object ExecuteMethod(WmiMethod method, WmiMethodParameters inParameters, out WmiMethodParameters outParameters)
        {
            if (method is null)
                throw new ArgumentNullException(nameof(method));

            if (inParameters is null)
                return this.ExecuteMethod<object>(method, out outParameters);

            return this.ExecuteMethod<object>(method.Name, inParameters, out outParameters);
        }

        #region Description
        /// <summary>
        /// Executes a static WMI method.
        /// </summary>
        /// <typeparam name="TReturnValue">The return value type.</typeparam>
        /// <param name="method">The method that should be executed.</param>
        /// <param name="inParameters">The parameters for the method.</param>
        /// <param name="outParameters">The out parameters returned by the method.</param>
        /// <returns>The return value of the method.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="method"/> parameter is <c>null</c>.</exception>

        #endregion
        public TReturnValue ExecuteMethod<TReturnValue>(WmiMethod method, WmiMethodParameters inParameters, out WmiMethodParameters outParameters)
        {
            if (method is null)
                throw new ArgumentNullException(nameof(method));

            if (inParameters is null)
                return this.ExecuteMethod<TReturnValue>(method, out outParameters);

            return this.ExecuteMethod<TReturnValue>(method.Name, inParameters, out outParameters);
        }

        private TReturnValue ExecuteMethod<TReturnValue>(string method, IntPtr inParameters, out WmiMethodParameters outParameters)
        {
            this.wbemServices.ExecuteMethod(this.Path, method, inParameters, out WbemClassObject wbemOutParams);

            outParameters = new WmiMethodParameters(wbemOutParams);

            return outParameters.GetPropertyValue<TReturnValue>("ReturnValue");
        }

        #region Description
        /// <summary>
        /// Releases all resources used by the <see cref="WmiObject"/>.
        /// </summary>
        #endregion
        public void Dispose()
        {
            if (!this.disposed)
            {
                this.wbemClassObject.Dispose();
                this.disposed = true;
            }
        }
        
        #region Description
        /// <summary>
        /// Returns a string that represents the current <see cref="WmiObject"/>.
        /// </summary>
        /// <returns>A string that represents the current <see cref="WmiObject"/>.</returns>
        #endregion
        public override string ToString()
        {
            return this.Class;
        }

        #endregion
    }
}