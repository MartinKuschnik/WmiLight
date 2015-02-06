namespace WmiLight
{
    #region Description
    /// <summary>
    /// Describes the impersonation level to be used to connect to WMI.
    /// </summary>
    #endregion
    internal enum ImpersonationLevel : int
    {
        #region Description
        /// <summary>
        /// Default impersonation.
        /// </summary>
        #endregion
        Default = 0,
        #region Description
        /// <summary>
        /// Anonymous COM impersonation level that hides the identity of the caller. Calls to WMI may fail with this impersonation level.
        /// </summary>
        #endregion
        Anonymous = 1,
        #region Description
        /// <summary>
        /// Identify-level COM impersonation level that allows objects to query the credentials of the caller. Calls to WMI may fail with this impersonation level.
        /// </summary>
        #endregion
        Identify = 2,
        #region Description
        /// <summary>
        /// Impersonate-level COM impersonation level that allows objects to use the credentials of the caller. This is the recommended impersonation level for WMI calls.
        /// </summary>
        #endregion
        Impersonate = 3,
        #region Description
        /// <summary>
        /// Delegate-level COM impersonation level that allows objects to permit other objects to use the credentials of the caller. 
        /// This level, which will work with WMI calls but may constitute an unnecessary security risk, is supported only under Windows 2000.
        /// </summary>
        #endregion
        Delegate = 4
    }
}
