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
        #region Constants

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Genus"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string GenusPropertyName = "__genus";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Class"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string ClassPropertyName = "__class";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.SuperClass"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string SuperClassPropertyName = "__superclass";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Dynasty"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DynastyPropertyName = "__dynasty";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Relpath"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string RelpathPropertyName = "__relpath";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.PropertyCount"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string PropertyCountPropertyName = "__property_count";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Derivation"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DerivationPropertyName = "__derivation";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Server"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string ServerPropertyName = "__server";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Namespace"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string NamespacePropertyName = "__namespace";

        #region Description
        /// <summary>
        /// The property key for the <see cref="WmiObject.Path"/> property.
        /// </summary>
        #endregion
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string PathPropertyName = "__path";

        #endregion

        #region Fields

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
        /// <param name="wmiObject">The native <see cref="WbemClassObject"/> object.</param>
        #endregion
        internal WmiObject(WbemClassObject wmiObject)
        {
            if (wmiObject == null)
                throw new ArgumentNullException(nameof(wmiObject));

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
                return (WmiObjectGenus)this.GetPropertyValue(WmiObject.GenusPropertyName);
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
                return (string)this.GetPropertyValue(WmiObject.ClassPropertyName);
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
                return (string)this.GetPropertyValue(WmiObject.SuperClassPropertyName);
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
                return (string)this.GetPropertyValue(WmiObject.DynastyPropertyName);
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
                return (string)this.GetPropertyValue(WmiObject.RelpathPropertyName);
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
                return (int)this.GetPropertyValue(WmiObject.PropertyCountPropertyName);
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
                return (string[])this.GetPropertyValue(WmiObject.DerivationPropertyName);
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
                return (string)this.GetPropertyValue(WmiObject.ServerPropertyName);
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
                return (string)this.GetPropertyValue(WmiObject.NamespacePropertyName);
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
                return (string)this.GetPropertyValue(WmiObject.PathPropertyName);
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
                return new WmiObject(wbemClassObject);

            if (obj is WbemClassObject[] wbemClassObjectArray)
            {
                WmiObject[] wmiObjects = new WmiObject[wbemClassObjectArray.Length];

                for (int i = 0; i < wmiObjects.Length; i++)
                    wmiObjects[i] = new WmiObject(wbemClassObjectArray[i]);

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
                return (TResult)(object)new WmiObject(wbemClassObject.Get<WbemClassObject>(propertyName));
            }

            if (typeof(TResult) == typeof(WmiObject[]))
            {
                WbemClassObject[] wbemClassObjectArray = wbemClassObject.Get<WbemClassObject[]>(propertyName);

                WmiObject[] wmiObjects = new WmiObject[wbemClassObjectArray.Length];

                for (int i = 0; i < wmiObjects.Length; i++)
                    wmiObjects[i] = new WmiObject(wbemClassObjectArray[i]);

                return (TResult)(object)wmiObjects;
            }

            return wbemClassObject.Get<TResult>(propertyName);
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