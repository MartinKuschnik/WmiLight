using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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

            VARIANT value = default;
            CimType valueType;

            try
            {
                HResult hResult = NativeMethods.Get(this.NativePointer, propertyName, ref value, out valueType);

                if (hResult.Failed)
                    throw (Exception)hResult;

                if (value.vt == VARENUM.VT_NULL)
                    return null;

                return VariantToObject(ref value, valueType);
            }
            finally
            {
                NativeMethods.VariantClear(ref value);
            }
        }

        public TResult Get<TResult>(string propertyName)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = default;
            CimType valueType;

            try
            {
                HResult hResult = NativeMethods.Get(this.NativePointer, propertyName, ref value, out valueType);

                if (hResult.Failed)
                    throw (Exception)hResult;

                if (value.vt == VARENUM.VT_NULL)
                    return default(TResult);

                return (TResult)VariantToObject(ref value, valueType);
            }
            finally
            {
                NativeMethods.VariantClear(ref value);
            }
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

        private static object VariantToObject(ref VARIANT value, CimType type)
        {
            if (type.HasFlag(CimType.ArrayFlag))
            {
                CimType typeWithoutArrayFlag = type & ~CimType.ArrayFlag;

                switch (typeWithoutArrayFlag)
                {
                    case CimType.SInt16:
                        return VariantToArray<short>(ref value, typeWithoutArrayFlag);

                    case CimType.SInt32:
                        return VariantToArray<int>(ref value, typeWithoutArrayFlag);

                    case CimType.Real32:
                        return VariantToArray<float>(ref value, typeWithoutArrayFlag);

                    case CimType.Real64:
                        return VariantToArray<double>(ref value, typeWithoutArrayFlag);

                    case CimType.String:
                        return VariantToArray<string>(ref value, typeWithoutArrayFlag);

                    case CimType.Boolean:
                        return VariantToArray<bool>(ref value, typeWithoutArrayFlag);

                    case CimType.SInt8:
                        return VariantToArray<sbyte>(ref value, typeWithoutArrayFlag);

                    case CimType.UInt8:
                        return VariantToArray<byte>(ref value, typeWithoutArrayFlag);

                    case CimType.UInt16:
                        return VariantToArray<ushort>(ref value, typeWithoutArrayFlag);

                    case CimType.UInt32:
                        return VariantToArray<uint>(ref value, typeWithoutArrayFlag);

                    case CimType.SInt64:
                        return VariantToArray<long>(ref value, typeWithoutArrayFlag);

                    case CimType.UInt64:
                        return VariantToArray<ulong>(ref value, typeWithoutArrayFlag);

                    case CimType.Char16:
                        return VariantToArray<char>(ref value, typeWithoutArrayFlag);

                    case CimType.DateTime:
                        return VariantToArray<string>(ref value, typeWithoutArrayFlag);

                    default:
                        throw new NotSupportedException($"CimType '{typeWithoutArrayFlag}[]' currently not supported.");
                }
            }
            else
            {
                switch (type)
                {
                    case CimType.SInt16:
                        if (value.vt == VARENUM.VT_BSTR)
                            return short.Parse(Marshal.PtrToStringBSTR(value.BStrVal));
                        return value.SInt16;

                    case CimType.SInt32:
                        if (value.vt == VARENUM.VT_BSTR)
                            return int.Parse(Marshal.PtrToStringBSTR(value.BStrVal));
                        return value.SInt32;

                    case CimType.Real32:
                        return value.Real32;

                    case CimType.Real64:
                        return value.Real64;

                    case CimType.String:
                        return Marshal.PtrToStringBSTR(value.BStrVal);

                    case CimType.Boolean:
                        return value.Boolean == VT_BOOL.VARIANT_TRUE;

                    case CimType.SInt8:
                        if (value.vt == VARENUM.VT_BSTR)
                            return sbyte.Parse(Marshal.PtrToStringBSTR(value.BStrVal));
                        return value.SInt8;

                    case CimType.UInt8:
                        if (value.vt == VARENUM.VT_BSTR)
                            return byte.Parse(Marshal.PtrToStringBSTR(value.BStrVal));
                        return value.UInt8;

                    case CimType.UInt16:
                        if (value.vt == VARENUM.VT_BSTR)
                            return ushort.Parse(Marshal.PtrToStringBSTR(value.BStrVal));
                        return value.UInt16;

                    case CimType.UInt32:

                        if (value.vt == VARENUM.VT_BSTR)
                            return uint.Parse(Marshal.PtrToStringBSTR(value.BStrVal));
                        return value.UInt32;

                    case CimType.SInt64:
                        if (value.vt == VARENUM.VT_BSTR)
                            return long.Parse(Marshal.PtrToStringBSTR(value.BStrVal));
                        return value.SInt64;

                    case CimType.UInt64:
                        if(value.vt == VARENUM.VT_BSTR)
                            return ulong.Parse(Marshal.PtrToStringBSTR(value.BStrVal));

                        return value.UInt64;

                    case CimType.Char16:
                        return value.Char16;

                    case CimType.DateTime:
                        return Marshal.PtrToStringBSTR(value.BStrVal);

                    default:
                        throw new NotSupportedException($"CimType '{type}' currently not supported.");
                }
            }
        }

        private static T[] VariantToArray<T>(ref VARIANT value, CimType type)
        {
            uint elementCount = NativeMethods.VariantGetElementCount(ref value);

            T[] array = new T[elementCount];

            for (uint i = 0; i < elementCount; i++)
            {
                VARIANT variant = default;

                try
                {
                    HResult hResult = NativeMethods.InitVariantFromVariantArrayElem(ref value, i, ref variant);

                    if (hResult.Failed)
                        throw (Exception)hResult;

                    array[i] = (T)VariantToObject(ref variant, type);
                }
                finally
                {
                    NativeMethods.VariantClear(ref variant);
                }
            }

            return array;
        }
    }
}
