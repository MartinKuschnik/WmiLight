namespace WmiLight
{
    #region Description
    /// <summary>
    /// Enumeration that is used to distinguish <see cref="WmiObject"/>s between classes and instances. 
    /// </summary>
    #endregion
    public enum WmiObjectGenus
    {
        #region Description
        /// <summary>
        /// Indicates that the <see cref="WmiObject"/> is an class. 
        /// </summary>
        #endregion
        Class = 1,
    
        #region Description
        /// <summary>
        /// Indicates that the <see cref="WmiObject"/> is an instance or an event. 
        /// </summary>
        #endregion
        Instance = 2
    }
}
