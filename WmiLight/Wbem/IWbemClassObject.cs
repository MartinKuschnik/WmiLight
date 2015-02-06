namespace WmiLight.Wbem
{
    using System;
    using System.Runtime.InteropServices;
    
    #region Description
    /// <summary>
    /// Contains and manipulates both class definitions and class object instances. Developers need not implement this interface; WMI provides its implementation.
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391433(v=vs.85).aspx"/></remarks>
    #endregion
    [ComImport]
    [Guid("dc12a681-737f-11cf-884d-00aa004b2e24")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IWbemClassObject
    {
        #region Description
        /// <summary>
        /// Allows access to the qualifier set of the entire object.
        /// </summary>
        /// <param name="qualifierSet">The object that allows access to the qualifiers for the class object.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetQualifierSet( 
            [Out] 
            out IWbemQualifierSet qualifierSet);

        #region Description
        /// <summary>
        /// Gets a particular property value.
        /// </summary>
        /// <param name="propertyName">Name of the desired property.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="value">The correct type and value for the qualifier.</param>
        /// <param name="type">The CIM type of the property.</param>
        /// <param name="flavor">The value pointed to receives information about the origin of the property.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult Get( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string propertyName,
            [In] 
            int flags,
            [Out] 
            out object value,
            [Out] 
            out CimType type,
            [Out] 
            out int flavor);

        #region Description
        /// <summary>
        /// Updates or creates a particular property value.
        /// </summary>
        /// <param name="propertyName">A valid property name.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="value">The object, which becomes the new property value.</param>
        /// <param name="type">The correct type and value for the qualifier.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult Put( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string propertyName,
            [In] 
            int flags,
            [In] 
            object value,
            [In] 
            CimType type);

        #region Description
        /// <summary>
        /// Removes the specified property from the object.
        /// </summary>
        /// <param name="propertyName">Property name to delete.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig] 
        HResult Delete(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string propertyName);

        #region Description
        /// <summary>
        /// Obtains a list of the names of the properties in the object.
        /// </summary>
        /// <param name="qualifierName">
        /// A qualifier name which operates as part of a filter
        /// <para/>
        /// Can be NULL.
        /// </param>
        /// <param name="flags">Combination of flags. (see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391447(v=vs.85).aspx"/>)</param>
        /// <param name="qualifierValue">
        /// A valid object initialized to a filter value.
        /// <para/>
        /// Can be NULL.
        /// </param>
        /// <param name="names">The names.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetNames( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string qualifierName,
            [In] 
            WbemConditionFlag flags,
            [In] 
            ref object qualifierValue,
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
            out string[] names);
        
        #region Description
        /// <summary>
        /// Begins an enumeration of the properties.
        /// </summary>
        /// <param name="enumFlags">Combination of flags. (see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391434(v=vs.85).aspx"/>)</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult BeginEnumeration( 
            [In] 
            int enumFlags);

        #region Description
        /// <summary>
        /// Obtains the next property in an enumeration after an initial call to <see cref="IWbemClassObject.BeginEnumeration"/>.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="strName">The property name.</param>
        /// <param name="value">The object filled with the value of the property.</param>
        /// <param name="type">The <see cref="CimType"/> variable into which the type of the property is placed.</param>
        /// <param name="flavor">The origin of the property (see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391453(v=vs.85).aspx"/>)</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult Next( 
            [In] 
            int flags,
            [Out, MarshalAs(UnmanagedType.BStr)]
            string strName,            
            [Out]
            out object value,
            [Out]
            out CimType type,
            [Out]
            out int flavor);

        #region Description
        /// <summary>
        /// Ends an enumeration begun with <see cref="IWbemClassObject.BeginEnumeration"/>.
        /// </summary>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult EndEnumeration();

        #region Description
        /// <summary>
        /// Allows access to the qualifiers of a particular property.
        /// </summary>
        /// <param name="property">Property for which the qualifier set is requested.</param>
        /// <param name="qualifierSet">The <see cref="IWbemQualifierSet"/> instance that allows access to the qualifiers for the named property.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetPropertyQualifierSet( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string property,
            [Out] 
            out IWbemQualifierSet qualifierSet);

        #region Description
        /// <summary>
        /// Makes a copy of the current object.
        /// </summary>
        /// <param name="copy">The copy of the current object.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult Clone( 
            [Out] 
            out IWbemClassObject copy);

        #region Description
        /// <summary>
        /// Obtains the textual rendition of the object in Managed Object Format (MOF) syntax.
        /// </summary>
        /// <param name="flags">
        /// Normally 0. 
        /// <para />
        /// If 1 is specified, qualifiers will be presented without propagation or flavor information.</param>
        /// <param name="objectText">The object text.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetObjectText( 
            [In] 
            int flags,
            [Out, MarshalAs(UnmanagedType.BStr)]
            out string objectText);

        #region Description
        /// <summary>
        /// Creates a new derived class from the current class.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="newClass">The new class definition object.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult SpawnDerivedClass( 
            [In] 
            int flags,
            [Out] 
            out IWbemClassObject newClass);

        #region Description
        /// <summary>
        /// Creates a new instance from the current class.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="newInstance">A new instance of the class.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult SpawnInstance( 
            [In] 
            int flags,
            [Out] 
            out IWbemClassObject newInstance);

        #region Description
        /// <summary>
        /// Tests two objects for equality.
        /// </summary>
        /// <param name="compareOption">
        /// Specifies the object characteristics to consider in comparison to another object. <para />
        /// It can be <see cref="WbemClassObjectComparisonOption.IncludeAll"/> to consider all features, or any combination of these options.
        /// </param>
        /// <param name="compareTo">An <see cref="IWbemClassObject"/> object to compare with this instance.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult CompareTo( 
            [In] 
            WbemClassObjectComparisonOption compareOption,
            [In] 
            IWbemClassObject compareTo);

        #region Description
        /// <summary>
        /// Reports the class in which a particular property was introduced.
        /// </summary>
        /// <param name="name">Property name for which the owning class name is desired.</param>
        /// <param name="className">The parent class name.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetPropertyOrigin( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string name,
            [Out, MarshalAs(UnmanagedType.BStr)]
            out string className);

        #region Description
        /// <summary>
        /// Reports whether the current object inherits from a particular class.
        /// </summary>
        /// <param name="ancestor">The class name that is being tested.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult InheritsFrom( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string ancestor);

        #region Description
        /// <summary>
        /// Gets the in- and out-parameter definitions for a specific method.
        /// </summary>
        /// <param name="name">The method name.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="inSignature">A <see cref="IWbemClassObject"/> object which describes the in parameters to the method.</param>
        /// <param name="outSignature">A <see cref="IWbemClassObject"/> object which describes the out-parameters to the method. </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetMethod( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string name,
            [In] 
            int flags,
            [Out] 
            out IWbemClassObject inSignature,
            [Out] 
            out IWbemClassObject outSignature);

        #region Description
        /// <summary>
        /// Creates a method.
        /// </summary>
        /// <param name="name">The method name that is created.</param>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="inSignature">A <see cref="IWbemClassObject"/> object which describes the in parameters to the method.</param>
        /// <param name="outSignature">A <see cref="IWbemClassObject"/> object which describes the out-parameters to the method. </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult PutMethod( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string name,
            [In] int flags,
            [In] IWbemClassObject inSignature,
            [In] IWbemClassObject outSignature);

        #region Description
        /// <summary>
        /// Removes a method.
        /// </summary>
        /// <param name="name">Method name to be removed from the class definition.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult DeleteMethod( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string name);

        #region Description
        /// <summary>
        /// Begins an enumeration of methods for the object.
        /// </summary>
        /// <param name="enumFlags">Specifies the scope of the enumeration.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult BeginMethodEnumeration( 
            [In] int enumFlags);

        #region Description
        /// <summary>
        /// Retrieves the next method definition in an enumeration of methods.
        /// </summary>
        /// <param name="flags">Reserved. This parameter must be 0.</param>
        /// <param name="name">The method name.</param>
        /// <param name="inSignature">A <see cref="IWbemClassObject"/> object which describes the in parameters to the method.</param>
        /// <param name="outSignature">A <see cref="IWbemClassObject"/> object which describes the out-parameters to the method. </param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult NextMethod( 
            [In] 
            int flags,
            [Out, MarshalAs(UnmanagedType.BStr)]
            string name,
            [Out] 
            out IWbemClassObject inSignature,
            [Out] 
            out IWbemClassObject outSignature);

        #region Description
        /// <summary>
        /// Ends the enumeration of methods for an object.
        /// </summary>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult EndMethodEnumeration();

        #region Description
        /// <summary>
        /// Returns the qualifier set object for a specific method.
        /// </summary>
        /// <param name="method">The method name.</param>
        /// <param name="qualifierSet">The object that allows access to the qualifiers for the method.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetMethodQualifierSet( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string method,
            [Out] 
            out IWbemQualifierSet qualifierSet);

        #region Description
        /// <summary>
        /// Reports the class in which a method is defined.
        /// </summary>
        /// <param name="methodName">Name of the method for the object whose owning class is being requested.</param>
        /// <param name="className">The name of the class which owns the method.</param>
        /// <returns>A value that gives information about the status of an operation.</returns>
        #endregion
        [PreserveSig]
        HResult GetMethodOrigin( 
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string methodName,
            [Out, MarshalAs(UnmanagedType.BStr)]
            out string className);
    }
}
