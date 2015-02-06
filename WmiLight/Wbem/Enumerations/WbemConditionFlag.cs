namespace WmiLight.Wbem
{
    #region Description
    /// <summary>
    /// Enumeration to specify a condition for the <see cref="IWbemClassObject.GetNames"/>() method. 
    /// </summary>
    #endregion
    internal enum WbemConditionFlag
    {
        #region Group 1

        #region Description
        /// <summary>
        /// Return all property names. <para />
        /// The <see name="IWbemClassObject.GetNames.qualifierName"/> and <see name="IWbemClassObject.GetNames.qualifierValue"/> parameters are not used.
        /// </summary>
        #endregion
        WBEM_FLAG_ALWAYS = unchecked((int)0x00000000),

        #region Description
        /// <summary>
        /// Return only properties that have a qualifier of the name specified by the parameter <see name="IWbemClassObject.GetNames.qualifierName"/>. <para />
        /// If this flag is used, you must specify <see name="IWbemClassObject.GetNames.qualifierName"/>.
        /// </summary>
        #endregion
        WBEM_FLAG_ONLY_IF_TRUE = unchecked((int)0x00000001),

        #region Description
        /// <summary>
        /// Return only properties that do not have a qualifier of the name specified by the parameter <see name="IWbemClassObject.GetNames.qualifierName"/>. <para />
        /// If this flag is used, you must specify <see name="IWbemClassObject.GetNames.qualifierName"/>.
        /// </summary>
        #endregion
        WBEM_FLAG_ONLY_IF_FALSE = unchecked((int)0x00000002),

        #region Description
        /// <summary>
        /// Return only properties that have a qualifier of the name specified by the parameter <see name="IWbemClassObject.GetNames.qualifierName"/>, 
        /// and also have a value identical to the value specified by the <see name="IWbemClassObject.GetNames.qualifierValue"/> parameter. <para />
        /// </summary>
        #endregion
        WBEM_FLAG_ONLY_IF_IDENTICAL = unchecked((int)0x00000003),

        #endregion

        #region Group 2

        #region Description
        /// <summary>
        /// Return only property names that are object references.
        /// </summary>
        #endregion
        WBEM_FLAG_KEYS_ONLY = unchecked((int)0x00000004),

        #region Description
        /// <summary>
        /// Return only property names that are object references.
        /// </summary>
        #endregion
        WBEM_FLAG_REFS_ONLY = unchecked((int)0x00000008),

        #endregion

        #region Group 3

        #region Description
        /// <summary>
        /// Return only property names that belong to the derived-most class. Exclude properties from the parent class or parent classes.
        /// </summary>
        #endregion
        WBEM_FLAG_LOCAL_ONLY = unchecked((int)0x00000010),

        #region Description
        /// <summary>
        /// Return only property names that belong to the parent class or parent classes.
        /// </summary>
        #endregion
        WBEM_FLAG_PROPAGATED_ONLY = unchecked((int)0x00000020),

        #region Description
        /// <summary>
        /// Return only system properties.
        /// </summary>
        #endregion
        WBEM_FLAG_SYSTEM_ONLY = unchecked((int)0x00000030),

        #region Description
        /// <summary>
        /// Return only property names that are not system properties.
        /// </summary>
        #endregion
        WBEM_FLAG_NONSYSTEM_ONLY = unchecked((int)0x00000040),
        
        #endregion
    }
}
