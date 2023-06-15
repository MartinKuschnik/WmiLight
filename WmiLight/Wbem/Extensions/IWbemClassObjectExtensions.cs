namespace WmiLight.Wbem
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    #region Description
    /// <summary>
    /// Static class with extension methods for the <see cref="WmiLight.Wbem.IWbemClassObject"/> interface.
    /// </summary>
    #endregion
    internal static class IWbemClassObjectExtensions
    {
        #region Description
        /// <summary>
        /// Gets the names of all properties in the object.
        /// </summary>
        /// <param name="this">The <see cref="IWbemClassObject"/> object which will be used to execute the method.</param>
        /// <param name="flags">Combination of flags. (see <see url="http://msdn.microsoft.com/en-us/library/windows/desktop/aa391447(v=vs.85).aspx"/>)</param>
        /// <returns>The names of all properties.</returns>
        #endregion
        internal static IEnumerable<string> GetNames(this IWbemClassObject @this, WbemConditionFlag flags = WbemConditionFlag.WBEM_FLAG_NONSYSTEM_ONLY)
        {
            string[] names = null;
            HResult hr = @this.GetNames(null, flags, null, out names);

            if (hr.Failed)
            {
                throw (Exception)hr;
            }

            return names;
        }

        #region Description
        /// <summary>
        /// Gets a particular property value.
        /// </summary>
        /// <param name="this">The <see cref="IWbemClassObject"/> object which will be used to execute the method.</param>
        /// <param name="propertyName">Name of the desired property.</param>
        /// <returns>The correct type and value for the qualifier.</returns>
        #endregion
        internal static object Get(this IWbemClassObject @this, string propertyName)
        {
            object value;
            CimType type;
            int flavor;

            HResult hresult = @this.Get(propertyName, 0, out value, out type, out flavor);

            if (hresult.Failed)
            {
                throw (Exception)hresult;
            }

            return value == DBNull.Value ? null : MapWmiValueToValue(value, type);
        }

        private static object MapWmiValueToValue(object wmiValue, CimType type)
        {
            if (type.HasFlag(CimType.ArrayFlag))
            {
                object val;
                Array wmiValueArray = (Array)wmiValue;
                int length = wmiValueArray.Length;

                switch (type & ~CimType.ArrayFlag)
                {
                    case CimType.UInt16:
                        val = new ushort[length];

                        for (int i = 0; i < length; i++)
                            ((ushort[])val)[i] = (ushort)((int)(wmiValueArray.GetValue(i)));
                        return val;

                    case CimType.UInt32:
                        val = new uint[length];

                        for (int i = 0; i < length; i++)
                            ((uint[])val)[i] = (uint)((int)(wmiValueArray.GetValue(i)));
                        return val;

                    case CimType.UInt64:
                        val = new ulong[length];

                        for (int i = 0; i < length; i++)
                            ((ulong[])val)[i] = Convert.ToUInt64((string)(wmiValueArray.GetValue(i)), (IFormatProvider)CultureInfo.CurrentCulture.GetFormat(typeof(ulong)));
                        return val;

                    case CimType.SInt8:
                        val = new sbyte[length];

                        for (int i = 0; i < length; i++)
                            ((sbyte[])val)[i] = (sbyte)((short)(wmiValueArray.GetValue(i)));

                        return val;

                    case CimType.SInt64:
                        val = new long[length];

                        for (int i = 0; i < length; i++)
                            ((long[])val)[i] = Convert.ToInt64((string)(wmiValueArray.GetValue(i)), (IFormatProvider)CultureInfo.CurrentCulture.GetFormat(typeof(long)));

                        return val;

                    case CimType.Char16:
                        val = new char[length];

                        for (int i = 0; i < length; i++)
                            ((char[])val)[i] = (char)((short)(wmiValueArray.GetValue(i)));

                        return val;

                    case CimType.Object:
                        throw new NotSupportedException("CimType 'Object[]' currently not supported.");
                        //val = new ManagementBaseObject[length];

                        //for (int i = 0; i < length; i++)
                        //    ((ManagementBaseObject[])val)[i] = new ManagementBaseObject(new IWbemClassObjectFreeThreaded(Marshal.GetIUnknownForObject(wmiValueArray.GetValue(i))));
                        //break;

                    default:
                        return wmiValue;
                }
            }
            else
            {
                switch (type)
                {
                    case CimType.SInt8:
                        return (sbyte)((short)wmiValue);
                    case CimType.UInt16:
                        return (ushort)((int)wmiValue);
                    case CimType.UInt32:
                        return (uint)((int)wmiValue);
                    case CimType.UInt64:
                        return Convert.ToUInt64((string)wmiValue, (IFormatProvider)CultureInfo.CurrentCulture.GetFormat(typeof(ulong)));
                    case CimType.SInt64:
                        return Convert.ToInt64((string)wmiValue, (IFormatProvider)CultureInfo.CurrentCulture.GetFormat(typeof(long)));
                    case CimType.Char16:
                        return (char)((short)wmiValue);
                    case CimType.Object:
                        throw new NotSupportedException("CimType 'Object' currently not supported.");
                    //    return new ManagementBaseObject(new IWbemClassObjectFreeThreaded(Marshal.GetIUnknownForObject(value)));
                    default:
                        return wmiValue;
                }
            }
        }
    }
}