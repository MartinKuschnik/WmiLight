namespace WmiLight.Wbem
{
    using System.ComponentModel;

    #region Description
    /// <summary>
    /// The <see cref="WbemChangeMode"/> enumeration is used to indicate and update the type of the flag.
    /// </summary>
    #endregion
    internal enum WbemChangeMode : int
    {
        #region Description
        /// <summary>
        /// This flag causes the put operation to update the class or instance if it does not exist, 
        /// or to overwrite the class or instance if it exists already.
        /// </summary>
        #endregion
        CreateOrUpdate = 0x00,
        #region Description
        /// <summary>
        /// This flag causes the put operation to update the class or instance. The class or instance MUST exist for the call to be successful.
        /// </summary>
        #endregion
        Update = 0x01,
        #region Description
        /// <summary>
        /// This flag causes the put operation to create the class or instance. For the call to be successful, the class or instance MUST NOT exist.
        /// </summary>
        #endregion
        Create = 0x02,
        #region Description
        /// <summary>
        /// This flag allows updates of classes even if there are child classes, as long as the change does not cause any conflicts with child classes. An example of an update that this flag allows is the adding of a new property to the base class that was not previously mentioned in any of the child classes. If the class has instances, the update fails.
        /// </summary>
        #endregion
        SafeUpdate = 0x20,
        #region Description
        /// <summary>
        /// This flag forces updates of classes when conflicting child classes exist. An example of an update that this flag forces is when a class qualifier is defined in a child class and the base class tries to add the same qualifier that conflicted with the existing one. In force mode, this conflict is resolved by deleting the conflicting qualifier in the child class.
        /// </summary>
        #endregion
        ForceUpdate = 0x40
    }
}
