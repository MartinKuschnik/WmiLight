using System;
using System.Collections.Generic;
using System.Globalization;

namespace WmiLight.Wbem
{
    internal class WbemClassObject : IUnknown
    {
        internal WbemClassObject(IntPtr nativePointer)
            : base(nativePointer)
        {
        }

        public CimType GetType(string propertyName)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            CimType cimType;

            HResult hResult = NativeMethods.GetType(this.NativePointer, propertyName, out cimType);

            if (hResult.Failed)
                throw (Exception)hResult;

            return cimType;
        }

        public object Get(string propertyName)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            object value = null;
            CimType valueType;

            HResult hResult = NativeMethods.Get(this.NativePointer, propertyName, ref value, out valueType);

            if (hResult.Failed)
                throw (Exception)hResult;

            if (value == DBNull.Value)
                return null;

            return MapWmiValueToValue(value, valueType);
        }

        public TResult Get<TResult>(string propertyName)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            object value = null;
            CimType valueType;

            HResult hResult = NativeMethods.Get(this.NativePointer, propertyName, ref value, out valueType);

            if (hResult.Failed)
                throw (Exception)hResult;

            if (value == DBNull.Value)
                return default(TResult);

            if (typeof(TResult) == value.GetType())
                return (TResult)value;

            return (TResult)MapWmiValueToValue(value, valueType);
        }

        internal IEnumerable<string> GetNames()
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            string[] names;

            HResult hResult = NativeMethods.GetNames(this.NativePointer, out names);

            if (hResult.Failed)
                throw (Exception)hResult;

            return names;
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
