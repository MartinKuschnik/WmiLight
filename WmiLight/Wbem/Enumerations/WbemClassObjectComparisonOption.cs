namespace WmiLight.Wbem
{
    using System;

    #region Description
    /// <summary>
    /// Options for <see cref="IWbemClassObject"/> object comparison.
    /// </summary>
    #endregion
    [Flags]
    internal enum WbemClassObjectComparisonOption
    {
        #region Description
        /// <summary>
        /// Considered all features.
        /// </summary>
        #endregion
        IncludeAll          = 0,
        #region Description
        /// <summary>
        /// Ignore all qualifiers (including Key and Dynamic) in comparison.
        /// </summary>
        #endregion
        IgnoreQualifiers    = 1,
        #region Description
        /// <summary>
        /// Ignore the source of the objects, namely the server and the namespace they came from, in comparison to other objects.
        /// </summary>
        #endregion
        IgnoreObjectSource  = 2,
        #region Description
        /// <summary>
        /// Ignore default values of properties. This option is only meaningful when comparing classes.
        /// </summary>
        #endregion
        IgnoreDefaultValues = 4,
        #region Description
        /// <summary>
        /// Assume that the objects being compared are instances of the same class. 
        /// Consequently, this option compares instance-related information only.
        /// Use this flag to optimize performance. 
        /// If the objects are not of the same class, the results are undefined.
        /// </summary>
        #endregion
        IgnoreClass         = 8,
        #region Description
        /// <summary>
        /// Compare string values in a case-insensitive manner. 
        /// This applies both to strings and to qualifier values. 
        /// Property and qualifier names are always compared in a case-insensitive manner whether this option is specified or not.
        /// </summary>
        #endregion
        IgnoreCase          = 16,
        #region Description
        /// <summary>
        /// Ignore qualifier flavors. 
        /// This flag still takes qualifier values into account, but ignores flavor distinctions such as propagation rules and override restrictions (for more information, see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa392900(v=vs.85).aspx"/>).
        /// </summary>
        #endregion
        IgnoreFlavor        = 32
    }
}
