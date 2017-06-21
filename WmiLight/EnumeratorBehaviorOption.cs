namespace WmiLight
{
    using System;
    using WmiLight.Wbem;

    #region Description
    /// <summary>
    /// The options to change the behavior of the <see cref="WmiObjectEnumerator"/> created by a <see cref="WmiQuery"/>.
    /// </summary>
    #endregion
    [Flags]
    public enum EnumeratorBehaviorOption
    {
        #region Description
        /// <summary>
        /// This option causes WMI to retain pointers to objects of the enumeration until the client releases the enumerator.
        /// </summary>
        #endregion
        Bidirectional = WbemClassObjectEnumeratorBehaviorOption.Bidirectional,

        #region Description
        /// <summary>
        /// This option is used for prototyping. It does not execute the query and instead returns an object that looks like a typical result object.
        /// </summary>
        #endregion
        Prototype = WbemClassObjectEnumeratorBehaviorOption.Prototype,

        #region Description
        /// <summary>
        /// This option causes this to be a semisynchronous call.
        /// <para />
        /// For more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384832(v=vs.85).aspx"/>.
        /// </summary>
        #endregion
        ReturnImmediately = WbemClassObjectEnumeratorBehaviorOption.ReturnImmediately,

        #region Description
        /// <summary>
        /// This flag causes a forward-only enumerator to be returned.
        /// <para />
        /// Forward-only enumerators are generally much faster and use less memory than conventional enumerators but do not allow calls to clone or reset the enumerator.
        /// </summary>
        #endregion
        ForwardOnly = WbemClassObjectEnumeratorBehaviorOption.ForwardOnly,

        #region Description
        /// <summary>
        /// This option causes direct access to the provider for the class specified without any regard to its parent class or subclasses.
        /// </summary>
        #endregion
        DirectRead = WbemClassObjectEnumeratorBehaviorOption.DirectRead,

        #region Description
        /// <summary>
        /// This option ensures that any returned objects have enough information in them so that the system properties, such as __PATH, __RELPATH, and __SERVER, are non-NULL.
        /// </summary>
        #endregion
        EnsureLocatable = WbemClassObjectEnumeratorBehaviorOption.EnsureLocatable,

        #region Description
        /// <summary>
        /// If this option is set, WMI retrieves the amended qualifiers stored in the localized namespace of the current connection's locale.
        /// <para />
        /// If not set, only the qualifiers stored in the immediate namespace are retrieved.
        /// </summary>
        #endregion
        UseAmendedQualifiers = WbemClassObjectEnumeratorBehaviorOption.UseAmendedQualifiers
    }
}
