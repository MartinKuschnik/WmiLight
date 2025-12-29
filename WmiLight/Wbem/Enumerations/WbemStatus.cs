namespace WmiLight.Wbem
{
    using System;

    #region Description
    /// <summary>
    /// The <see cref="WbemStatus"/> gives information about the status of an operation.
    /// </summary>
    /// <remarks><see url="http://msdn.microsoft.com/en-us/library/cc250949.aspx"/></remarks>
    #endregion
    internal enum WbemStatus : int
    {
        #region ===================== 0x0000**** =====================

        #region Description
        /// <summary>
        /// The operation was successful.
        /// </summary>
        #endregion
        WBEM_S_NO_ERROR = unchecked((int)0x00000000),

        #region Description
        /// <summary>
        /// This value is returned when no more objects
        /// are available, the number of objects returned is less than the number requested,
        /// or at the end of an enumeration.
        /// </summary>
        #endregion
        WBEM_S_FALSE = unchecked((int)0x00000001),

        #endregion

        #region ===================== 0x0004**** =====================

        #region Description
        /// <summary>
        /// The value already exists.
        /// </summary>
        #endregion
        WBEM_S_ALREADY_EXISTS = unchecked((int)0x00040001),

        #region Description
        /// <summary>
        /// An overridden property was deleted. 
        /// This value is returned to signal that the original, non-overridden value has been restored as a result of the deletion.
        /// </summary>
        #endregion
        WBEM_S_RESET_TO_DEFAULT = unchecked((int)0x00040002),

        #region Description
        /// <summary>
        /// The compared items (such as objects and classes) are not identical.
        /// </summary>
        #endregion
        WBEM_S_DIFFERENT = unchecked((int)0x00040003),

        #region Description
        /// <summary>
        /// A call timed out. This is not an error condition; therefore, some results may have been returned.
        /// </summary>
        #endregion
        WBEM_S_TIMEDOUT = unchecked((int)0x00040004),

        #region Description
        /// <summary>
        /// No more data is available from the enumeration; the user should terminate the enumeration.
        /// </summary>
        #endregion
        WBEM_S_NO_MORE_DATA = unchecked((int)0x00040005),

        #region Description
        /// <summary>
        /// The operation was canceled.
        /// </summary>
        #endregion
        WBEM_S_OPERATION_CANCELLED = unchecked((int)0x00040006),

        #region Description
        /// <summary>
        /// A request is still in progress; however, the results are not yet available.
        /// </summary>
        #endregion
        WBEM_S_PENDING = unchecked((int)0x00040007),

        #region Description
        /// <summary>
        /// More than one copy of the same object was detected in
        /// the result set of an enumeration.
        /// </summary>
        #endregion
        WBEM_S_DUPLICATE_OBJECTS = unchecked((int)0x00040008),

        #region Description
        /// <summary>
        /// The access was denied.
        /// </summary>
        #endregion
        WBEM_S_ACCESS_DENIED = unchecked((int)0x00040009),

        #region Description
        /// <summary>
        /// The user did not receive all of the requested objects
        /// because of inaccessible resources (other than security violations).
        /// </summary>
        #endregion
        WBEM_S_PARTIAL_RESULTS = unchecked((int)0x00040010),

        #region Description
        /// <summary>
        /// The source was not available.
        /// </summary>
        #endregion
        WBEM_S_SOURCE_NOT_AVAILABLE = unchecked((int)0x00040017),

        #endregion

        #region ===================== 0x8004**** =====================

        #region Description
        /// <summary>
        /// The call failed.
        /// </summary>
        #endregion
        WBEM_E_FAILED = unchecked((int)0x80041001),

        #region Description
        /// <summary>
        /// The current user does not have permission to perform the action.
        /// </summary>
        #endregion
        WBEM_E_ACCESS_DENIED = unchecked((int)0x80041003),

        #region Description
        /// <summary>
        /// There was not enough memory for the operation.
        /// </summary>
        #endregion
        WBEM_E_OUT_OF_MEMORY = unchecked((int)0x80041006),

        #region Description
        /// <summary>
        /// One of the parameters to the call is not correct.
        /// </summary>
        #endregion
        WBEM_E_INVALID_PARAMETER = unchecked((int)0x80041008),

        #region Description
        /// <summary>
        /// The specified namespace could not be found.
        /// </summary>
        #endregion
        WBEM_E_INVALID_NAMESPACE = unchecked((int)0x8004100E),

        #region Description
        /// <summary>
        /// A networking error that prevents normal operation has occurred.
        /// </summary>
        #endregion
        WBEM_E_TRANSPORT_FAILURE = unchecked((int)0x80041015),

        #region Description
        /// <summary>
        /// The user specified a username, password, or authority on a
        /// local connection. The user must use an empty user name and password and rely on
        /// default security.
        /// </summary>
        #endregion
        WBEM_E_LOCAL_CREDENTIALS = unchecked((int)0x80041064),

        #region Description
        /// <summary>
        /// The object could not be found.
        /// </summary>
        #endregion
        WBEM_E_NOT_FOUND = unchecked((int)0x80041002),

        #region Description
        /// <summary>
        /// The provider failed after initialization.
        /// </summary>
        #endregion
        WBEM_E_PROVIDER_FAILURE = unchecked((int)0x80041004),

        #region Description
        /// <summary>
        /// The context object is not valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_CONTEXT = unchecked((int)0x80041007),

        #region Description
        /// <summary>
        /// A type mismatch occurred.
        /// </summary>
        #endregion
        WBEM_E_TYPE_MISMATCH = unchecked((int)0x80041005),

        #region Description
        /// <summary>
        /// The resource, typically a remote server, is not
        /// currently available.
        /// </summary>
        #endregion
        WBEM_E_NOT_AVAILABLE = unchecked((int)0x80041009),

        #region Description
        /// <summary>
        /// An internal, critical, and unexpected error occurred. 
        /// Report this error to Microsoft Product Support Services.
        /// </summary>
        #endregion
        WBEM_E_CRITICAL_ERROR = unchecked((int)0x8004100A),

        #region Description
        /// <summary>
        /// One or more network packets were corrupted during a remote session.
        /// </summary>
        #endregion
        WBEM_E_INVALID_STREAM = unchecked((int)0x8004100B),

        #region Description
        /// <summary>
        /// The feature or operation is not supported.
        /// </summary>
        #endregion
        WBEM_E_NOT_SUPPORTED = unchecked((int)0x8004100C),

        #region Description
        /// <summary>
        /// The specified base class is not valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_SUPERCLASS = unchecked((int)0x8004100D),

        #region Description
        /// <summary>
        /// The specified instance is not valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_OBJECT = unchecked((int)0x8004100F),

        #region Description
        /// <summary>
        /// The specified class is not valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_CLASS = unchecked((int)0x80041010),

        #region Description
        /// <summary>
        /// A provider referenced in the schema does not have a corresponding registration.
        /// </summary>
        #endregion
        WBEM_E_PROVIDER_NOT_FOUND = unchecked((int)0x80041011),

        #region Description
        /// <summary>
        /// A provider referenced in the schema has an incorrect or incomplete registration.
        /// </summary>
        #endregion
        WBEM_E_INVALID_PROVIDER_REGISTRATION = unchecked((int)0x80041012),

        #region Description
        /// <summary>
        /// COM cannot locate a provider referenced in the schema.
        /// </summary>
        #endregion
        WBEM_E_PROVIDER_LOAD_FAILURE = unchecked((int)0x80041013),

        #region Description
        /// <summary>
        /// A component, such as a provider, failed to initialize for internal reasons.
        /// </summary>
        #endregion
        WBEM_E_INITIALIZATION_FAILURE = unchecked((int)0x80041014),

        #region Description
        /// <summary>
        /// The requested operation is not valid. This error usually
        /// applies to invalid attempts to delete classes or properties.
        /// </summary>
        #endregion
        WBEM_E_INVALID_OPERATION = unchecked((int)0x80041016),

        #region Description
        /// <summary>
        /// The query was not syntactically valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_QUERY = unchecked((int)0x80041017),

        #region Description
        /// <summary>
        /// The requested query language is not supported.
        /// </summary>
        #endregion
        WBEM_E_INVALID_QUERY_TYPE = unchecked((int)0x80041018),

        #region Description
        /// <summary>
        /// In a put operation, the <see cref="WmiLight.Wbem.WbemChangeMode.Create"/>
        /// flag was specified, but the instance already exists.
        /// </summary>
        #endregion
        WBEM_E_ALREADY_EXISTS = unchecked((int)0x80041019),

        #region Description
        /// <summary>
        /// The add operation cannot be performed on the qualifier
        /// because the owning object does not permit overrides.
        /// </summary>
        #endregion
        WBEM_E_OVERRIDE_NOT_ALLOWED = unchecked((int)0x8004101A),

        #region Description
        /// <summary>
        /// The user attempted to delete a qualifier that was not
        /// owned. The qualifier was inherited from a parent class.
        /// </summary>
        #endregion
        WBEM_E_PROPAGATED_QUALIFIER = unchecked((int)0x8004101B),

        #region Description
        /// <summary>
        /// The user attempted to delete a property that was not owned. The property was inherited from a parent class.
        /// </summary>
        #endregion
        WBEM_E_PROPAGATED_PROPERTY = unchecked((int)0x8004101C),

        #region Description
        /// <summary>
        /// The client made an unexpected and illegal sequence of calls.
        /// </summary>
        #endregion
        WBEM_E_UNEXPECTED = unchecked((int)0x8004101D),

        #region Description
        /// <summary>
        /// The user requested an illegal operation, such as
        /// spawning a class from an instance.
        /// </summary>
        #endregion
        WBEM_E_ILLEGAL_OPERATION = unchecked((int)0x8004101E),

        #region Description
        /// <summary>
        /// There was an illegal attempt to specify a key qualifier
        /// on a property that cannot be a key. The keys are specified in the class
        /// definition for an object and cannot be altered on a per-instance basis.
        /// </summary>
        #endregion
        WBEM_E_CANNOT_BE_KEY = unchecked((int)0x8004101F),

        #region Description
        /// <summary>
        /// The current object is not a valid class definition.
        /// </summary>
        #endregion
        WBEM_E_INCOMPLETE_CLASS = unchecked((int)0x80041020),

        #region Description
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        #endregion
        WBEM_E_INVALID_SYNTAX = unchecked((int)0x80041021),

        #region Description
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        #endregion
        WBEM_E_NONDECORATED_OBJECT = unchecked((int)0x80041022),

        #region Description
        /// <summary>
        /// The property that you are attempting to modify is read-only.
        /// </summary>
        #endregion
        WBEM_E_READ_ONLY = unchecked((int)0x80041023),

        #region Description
        /// <summary>
        /// The provider cannot perform the requested operation, such
        /// as requesting a query that is too complex, retrieving an instance, creating or
        /// updating a class, deleting a class, or enumerating a class.
        /// </summary>
        #endregion
        WBEM_E_PROVIDER_NOT_CAPABLE = unchecked((int)0x80041024),

        #region Description
        /// <summary>
        /// An attempt was made to make a change that would invalidate a derived class.
        /// </summary>
        #endregion
        WBEM_E_CLASS_HAS_CHILDREN = unchecked((int)0x80041025),

        #region Description
        /// <summary>
        /// An attempt has been made to delete or modify a class that has instances.
        /// </summary>
        #endregion
        WBEM_E_CLASS_HAS_INSTANCES = unchecked((int)0x80041026),

        #region Description
        /// <summary>
        ///  Reserved for future use.
        /// </summary>
        #endregion
        WBEM_E_QUERY_NOT_IMPLEMENTED = unchecked((int)0x80041027),

        #region Description
        /// <summary>
        /// A value of null was specified for a property that may
        /// not be null, such as one that is marked by a Key, Indexed, or
        /// Not_Null qualifier.
        /// </summary>
        #endregion
        WBEM_E_ILLEGAL_NULL = unchecked((int)0x80041028),

        #region Description
        /// <summary>
        /// The value provided for a qualifier was not a
        ///  legal qualifier type.
        /// </summary>
        #endregion
        WBEM_E_INVALID_QUALIFIER_TYPE = unchecked((int)0x80041029),

        #region Description
        /// <summary>
        /// The CIM type specified for a property is not valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_PROPERTY_TYPE = unchecked((int)0x8004102A),

        #region Description
        /// <summary>
        /// The request was made with an out-of-range value, or is
        /// incompatible with the type. 
        /// </summary>
        #endregion
        WBEM_E_VALUE_OUT_OF_RANGE = unchecked((int)0x8004102B),

        #region Description
        /// <summary>
        /// An illegal attempt was made to make a class singleton,
        /// such as when the class is derived from a non-singleton class.
        /// </summary>
        #endregion
        WBEM_E_CANNOT_BE_SINGLETON = unchecked((int)0x8004102C),

        #region Description
        /// <summary>
        /// The CIM type specified is not valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_CIM_TYPE = unchecked((int)0x8004102D),

        #region Description
        /// <summary>
        /// The requested method is not available.
        /// </summary>
        #endregion
        WBEM_E_INVALID_METHOD = unchecked((int)0x8004102E),

        #region Description
        /// <summary>
        /// The parameters provided for the method are not valid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_METHOD_PARAMETERS = unchecked((int)0x8004102F),

        #region Description
        /// <summary>
        /// There was an attempt to get qualifiers on a system property.
        /// </summary>
        #endregion
        WBEM_E_SYSTEM_PROPERTY = unchecked((int)0x80041030),

        #region Description
        /// <summary>
        /// The property type is not recognized.
        /// </summary>
        #endregion
        WBEM_E_INVALID_PROPERTY = unchecked((int)0x80041031),

        #region Description
        /// <summary>
        /// An asynchronous process has been canceled internally or
        /// by the user. Note that because of the timing and nature of the asynchronous
        /// operation, the operation may not have been truly canceled.
        /// </summary>
        #endregion
        WBEM_E_CALL_CANCELLED = unchecked((int)0x80041032),

        #region Description
        /// <summary>
        /// The user has requested an operation while WMI is in the
        /// process of quitting.
        /// </summary>
        #endregion
        WBEM_E_SHUTTING_DOWN = unchecked((int)0x80041033),

        #region Description
        /// <summary>
        /// An attempt was made to reuse an existing method name from
        /// a base class, and the signatures did not match.
        /// </summary>
        #endregion
        WBEM_E_PROPAGATED_METHOD = unchecked((int)0x80041034),

        #region Description
        /// <summary>
        /// One or more parameter values, such as a query text, is
        /// too complex or unsupported. WMI is requested to retry the operation
        /// with simpler parameters.
        /// </summary>
        #endregion
        WBEM_E_UNSUPPORTED_PARAMETER = unchecked((int)0x80041035),

        #region Description
        /// <summary>
        /// A parameter was missing from the method call.
        /// </summary>
        #endregion
        WBEM_E_MISSING_PARAMETER_ID = unchecked((int)0x80041036),

        #region Description
        /// <summary>
        /// A method parameter has an invalid ID-qualifier.
        /// </summary>
        #endregion
        WBEM_E_INVALID_PARAMETER_ID = unchecked((int)0x80041037),

        #region Description
        /// <summary>
        /// One or more of the method parameters have ID-qualifiers that are out of sequence.
        /// </summary>
        #endregion
        WBEM_E_NONCONSECUTIVE_PARAMETER_IDS = unchecked((int)0x80041038),

        #region Description
        /// <summary>
        /// The return value for a method has an ID-qualifier.
        /// </summary>
        #endregion
        WBEM_E_PARAMETER_ID_ON_RETVAL = unchecked((int)0x80041039),

        #region Description
        /// <summary>
        /// The specified object path was invalid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_OBJECT_PATH = unchecked((int)0x8004103A),

        #region Description
        /// <summary>
        /// There is not enough free disk space to continue the operation. 
        /// </summary>
        #endregion
        WBEM_E_OUT_OF_DISK_SPACE = unchecked((int)0x8004103B),

        #region Description
        /// <summary>
        /// The supplied buffer was too small to hold all the objects in the enumerator or to read a string property.
        /// </summary>
        #endregion
        WBEM_E_BUFFER_TOO_SMALL = unchecked((int)0x8004103C),

        #region Description
        /// <summary>
        /// The provider does not support the requested put operation.
        /// </summary>
        #endregion
        WBEM_E_UNSUPPORTED_PUT_EXTENSION = unchecked((int)0x8004103D),

        #region Description
        /// <summary>
        /// An object with an incorrect type or version was encountered during marshaling.
        /// </summary>
        #endregion
        WBEM_E_UNKNOWN_OBJECT_TYPE = unchecked((int)0x8004103E),

        #region Description
        /// <summary>
        /// A packet with an incorrect type or version was encountered during marshaling.
        /// </summary>
        #endregion
        WBEM_E_UNKNOWN_PACKET_TYPE = unchecked((int)0x8004103F),

        #region Description
        /// <summary>
        /// The packet has an unsupported version.
        /// </summary>
        #endregion
        WBEM_E_MARSHAL_VERSION_MISMATCH = unchecked((int)0x80041040),

        #region Description
        /// <summary>
        /// The packet is corrupted.
        /// </summary>
        #endregion
        WBEM_E_MARSHAL_INVALID_SIGNATURE = unchecked((int)0x80041041),

        #region Description
        /// <summary>
        /// An attempt has been made to mismatch qualifiers, such as putting [key] on an object instead of a property.
        /// </summary>
        #endregion
        WBEM_E_INVALID_QUALIFIER = unchecked((int)0x80041042),

        #region Description
        /// <summary>
        /// A duplicate parameter has been declared in a CIM method.
        /// </summary>
        #endregion
        WBEM_E_INVALID_DUPLICATE_PARAMETER = unchecked((int)0x80041043),

        #region Description
        /// <summary>
        /// Reserved for future use. 
        /// </summary>
        #endregion
        WBEM_E_TOO_MUCH_DATA = unchecked((int)0x80041044),

        #region Description
        /// <summary>
        /// The delivery of an event has failed. The provider may choose to re-raise the event.
        /// </summary>
        #endregion
        WBEM_E_SERVER_TOO_BUSY = unchecked((int)0x80041045),

        #region Description
        /// <summary>
        /// The specified flavor was invalid.
        /// </summary>
        #endregion
        WBEM_E_INVALID_FLAVOR = unchecked((int)0x80041046),

        #region Description
        /// <summary>
        /// An attempt has been made to create a reference that is circular (for example, deriving a class from itself).
        /// </summary>
        #endregion
        WBEM_E_CIRCULAR_REFERENCE = unchecked((int)0x80041047),

        #region Description
        /// <summary>
        /// The specified class is not supported.
        /// </summary>
        #endregion
        WBEM_E_UNSUPPORTED_CLASS_UPDATE = unchecked((int)0x80041048),

        #region Description
        /// <summary>
        /// An attempt was made to change a key when instances or derived classes are already using the key. 
        /// </summary>
        #endregion
        WBEM_E_CANNOT_CHANGE_KEY_INHERITANCE = unchecked((int)0x80041049),

        #region Description
        /// <summary>
        /// An attempt was made to change an index when instances or derived classes are already using the index.
        /// </summary>
        #endregion
        WBEM_E_CANNOT_CHANGE_INDEX_INHERITANCE = unchecked((int)0x80041050),

        #region Description
        /// <summary>
        /// An attempt was made to create more properties than the current version of the class supports.
        /// </summary>
        #endregion
        WBEM_E_TOO_MANY_PROPERTIES = unchecked((int)0x80041051),

        #region Description
        /// <summary>
        /// A property was redefined with a conflicting type in a derived class.
        /// </summary>
        #endregion
        WBEM_E_UPDATE_TYPE_MISMATCH = unchecked((int)0x80041052),

        #region Description
        /// <summary>
        /// An attempt was made in a derived class to override a non-overrideable qualifier.
        /// </summary>
        #endregion
        WBEM_E_UPDATE_OVERRIDE_NOT_ALLOWED = unchecked((int)0x80041053),

        #region Description
        /// <summary>
        /// A method was redeclared with a conflicting signature in a derived class.
        /// </summary>
        #endregion
        WBEM_E_UPDATE_PROPAGATED_METHOD = unchecked((int)0x80041054),

        #region Description
        /// <summary>
        /// An attempt was made to execute a method not marked with [implemented] in any relevant class.
        /// </summary>
        #endregion
        WBEM_E_METHOD_NOT_IMPLEMENTED = unchecked((int)0x80041055),

        #region Description
        /// <summary>
        /// An attempt was made to execute a method marked with [disabled].
        /// </summary>
        #endregion
        WBEM_E_METHOD_DISABLED = unchecked((int)0x80041056),

        #region Description
        /// <summary>
        /// The refresher is busy with another operation.
        /// </summary>
        #endregion
        WBEM_E_REFRESHER_BUSY = unchecked((int)0x80041057),

        #region Description
        /// <summary>
        /// The filtering query is syntactically invalid.
        /// </summary>
        #endregion
        WBEM_E_UNPARSABLE_QUERY = unchecked((int)0x80041058),

        #region Description
        /// <summary>
        /// The FROM clause of a filtering query references a class that is not an event class.
        /// </summary>
        #endregion
        WBEM_E_NOT_EVENT_CLASS = unchecked((int)0x80041059),

        #region Description
        /// <summary>
        /// A GROUP BY clause was used without the corresponding GROUP WITHIN clause.
        /// </summary>
        #endregion
        WBEM_E_MISSING_GROUP_WITHIN = unchecked((int)0x8004105A),

        #region Description
        /// <summary>
        /// A GROUP BY clause was used. Aggregation on all properties is not supported.
        /// </summary>
        #endregion
        WBEM_E_MISSING_AGGREGATION_LIST = unchecked((int)0x8004105B),

        #region Description
        /// <summary>
        /// Dot notation was used on a property that is not an embedded object. 
        /// </summary>
        #endregion
        WBEM_E_PROPERTY_NOT_AN_OBJECT = unchecked((int)0x8004105C),

        #region Description
        /// <summary>
        /// A GROUP BY clause references a property that is an embedded object without using dot notation.
        /// </summary>
        #endregion
        WBEM_E_AGGREGATING_BY_OBJECT = unchecked((int)0x8004105D),

        #region Description
        /// <summary>
        /// An event provider registration query did not specify the classes for which events were provided.
        /// </summary>
        #endregion
        WBEM_E_UNINTERPRETABLE_PROVIDER_QUERY = unchecked((int)0x8004105F),

        #region Description
        /// <summary>
        /// An request was made to back up or restore the repository while <see langword="WinMgmt.exe"/> was using it.
        /// </summary>
        #endregion
        WBEM_E_BACKUP_RESTORE_WINMGMT_RUNNING = unchecked((int)0x80041060),

        #region Description
        /// <summary>
        /// The asynchronous delivery queue overflowed from the event consumer being too slow.
        /// </summary>
        #endregion
        WBEM_E_QUEUE_OVERFLOW = unchecked((int)0x80041061),

        #region Description
        /// <summary>
        /// The operation failed because the client did not have the necessary security privilege.
        /// </summary>
        #endregion
        WBEM_E_PRIVILEGE_NOT_HELD = unchecked((int)0x80041062),

        #region Description
        /// <summary>
        /// The operator is not valid for this property type.
        /// </summary>
        #endregion
        WBEM_E_INVALID_OPERATOR = unchecked((int)0x80041063),

        #region Description
        /// <summary>
        /// The class was made abstract when its base class is not abstract.
        /// </summary>
        #endregion
        WBEM_E_CANNOT_BE_ABSTRACT = unchecked((int)0x80041065),

        #region Description
        /// <summary>
        /// An amended object was used in a put operation without the
        /// WBEM_FLAG_USE_AMENDED_QUALIFIERS flag being specified.
        /// </summary>
        #endregion
        WBEM_E_AMENDED_OBJECT = unchecked((int)0x80041066),

        #region Description
        /// <summary>
        /// The client was not retrieving objects quickly enough from
        /// an enumeration.
        /// </summary>
        #endregion
        WBEM_E_CLIENT_TOO_SLOW = unchecked((int)0x80041067),

        #region Description
        /// <summary>
        /// The provider registration overlaps with the system event domain.
        /// </summary>
        #endregion
        WBEMESS_E_REGISTRATION_TOO_BROAD = unchecked((int)0x80042001),

        #region Description
        /// <summary>
        /// A WITHIN clause was not used in this query.
        /// </summary>
        #endregion
        WBEMESS_E_REGISTRATION_TOO_PRECISE = unchecked((int)0x80042002),

        #endregion
    }
}
