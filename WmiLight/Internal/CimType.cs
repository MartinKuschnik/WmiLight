namespace WmiLight
{
    #region Description
    /// <summary>
    /// Describes the possible CIM types for properties, qualifiers, or method parameters.
    /// </summary>
    #endregion
    internal enum CimType
    {
        #region Description
        /// <summary>
        /// Invalid Type.
        /// </summary>
        #endregion
        None = 0,
        #region Description
        /// <summary>
        /// A signed 16-bit integer.
        /// </summary>
        #endregion
        SInt16 = 2,
        #region Description
        /// <summary>
        /// A signed 32-bit integer.
        /// </summary>
        #endregion
        SInt32 = 3,
        #region Description
        /// <summary>
        /// A floating-point 32-bit number.
        /// </summary>
        #endregion
        Real32 = 4,
        #region Description
        /// <summary>
        /// A floating point 64-bit number.
        /// </summary>
        #endregion
        Real64 = 5,
        #region Description
        /// <summary>
        /// A string.
        /// </summary>
        #endregion
        String = 8,
        #region Description
        /// <summary>
        /// A boolean.
        /// </summary>
        #endregion
        Boolean = 11,
        #region Description
        /// <summary>
        /// An embedded object.
        /// <para />
        /// Note that embedded objects differ from references in that the embedded object doesn't have a path and its lifetime is identical to the lifetime of the containing object.
        /// </summary>
        #endregion
        Object = 13,
        #region Description
        /// <summary>
        /// A signed 8-bit integer.
        /// </summary>
        #endregion
        SInt8 = 16,
        #region Description
        /// <summary>
        /// An unsigned 8-bit integer.
        /// </summary>
        #endregion
        UInt8 = 17,
        #region Description
        /// <summary>
        /// An unsigned 16-bit integer.
        /// </summary>
        #endregion
        UInt16 = 18,
        #region Description
        /// <summary>
        /// An unsigned 32-bit integer.
        /// </summary>
        #endregion
        UInt32 = 19,
        #region Description
        /// <summary>
        /// A signed 64-bit integer.
        /// </summary>
        #endregion
        SInt64 = 20,
        #region Description
        /// <summary>
        /// An unsigned 64-bit integer.
        /// </summary>
        #endregion
        UInt64 = 21,
        #region Description
        /// <summary>
        /// A date or time value, represented in a string in DMTF date/time format: yyyymmddHHMMSS.mmmmmmsUUU
        /// <para>where:</para>
        /// <para>yyyymmdd - is the date in year/month/day</para>
        /// <para>HHMMSS - is the time in hours/minutes/seconds</para>
        /// <para>mmmmmm - is the number of microseconds in 6 digits</para>
        /// <para>sUUU - is a sign (+ or -) and a 3-digit UTC offset</para>
        /// </summary>
        #endregion
        DateTime = 101,
        #region Description
        /// <summary>
        /// A reference to another object. This is represented by a string containing the path to the referenced object.
        /// </summary>
        #endregion
        Reference = 102,
        #region Description
        /// <summary>
        /// A 16-bit character.
        /// </summary>
        #endregion
        Char16 = 103,
    }
}
