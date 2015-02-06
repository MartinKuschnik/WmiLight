namespace WmiLight.Wbem
{
    using System;

    #region Description
    /// <summary>
    /// The options to change the behavior of the <see cref="IWbemClassObjectEnumerator"/>.
    /// </summary>
    #endregion
    [Flags]
    internal enum WbemClassObjectEnumeratorBehaviorOption : int
    {
        #region Description
        /// <summary>
        /// This option causes WMI to retain pointers to objects of the enumeration until the client releases the enumerator.
        /// </summary>
        #endregion
        Bidirectional           = 0x00000000,
        #region Description
        /// <summary>
        /// This option is used for prototyping. It does not execute the query and instead returns an object that looks like a typical result object.
        /// </summary>
        #endregion
        Prototype               = 0x00000002,
        #region Description
        /// <summary>
        /// This option causes this to be a semisynchronous call.
        /// <para />
        /// For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384832(v=vs.85).aspx"/>.
        /// </summary>
        #endregion
        ReturnImmediately       = 0x00000010,
        #region Description
        /// <summary>
        /// This flag causes a forward-only enumerator to be returned. 
        /// <para />
        /// Forward-only enumerators are generally much faster and use less memory than conventional enumerators but do not allow calls to 
        /// <see cref="IWbemClassObjectEnumerator.Clone"/> or <see cref="IWbemClassObjectEnumerator.Reset"/>.
        /// </summary>
        #endregion
        ForwardOnly             = 0x00000020,
        #region Description
        /// <summary>
        /// This option causes direct access to the provider for the class specified without any regard to its parent class or subclasses.
        /// </summary>
        #endregion
        DirectRead              = 0x00000200,
        #region Description
        /// <summary>
        /// This option ensures that any returned objects have enough information in them so that the system properties, such as __PATH, __RELPATH, and __SERVER, are non-NULL.
        /// </summary>
        #endregion
        EnsureLocatable         = 0x00000100,
        #region Description
        /// <summary>
        /// If this option is set, WMI retrieves the amended qualifiers stored in the localized namespace of the current connection's locale.
        /// <para />
        /// If not set, only the qualifiers stored in the immediate namespace are retrieved.
        /// </summary>
        #endregion
        UseAmendedQualifiers    = 0x00020000
    }
}
