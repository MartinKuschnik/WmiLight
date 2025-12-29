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

        internal CimType GetCimType(string propertyName)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            CimType cimType;

            HResult hResult = NativeMethods.GetType(this, propertyName, out cimType);

            if (hResult.Failed)
                throw (Exception)hResult;

            return cimType;
        }

        public unsafe object Get(string propertyName)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = default;
            CimType valueType;

            try
            {
                HResult hResult = NativeMethods.Get(this, propertyName, &value, out valueType);

                if (hResult.Failed)
                    throw (Exception)hResult;

                if (value.vt == VARENUM.VT_NULL)
                    return null;

                return VariantToObject(ref value, valueType);
            }
            finally
            {
                NativeMethods.VariantClear(&value);
            }
        }

        public unsafe TResult Get<TResult>(string propertyName)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = default;
            CimType valueType;

            try
            {
                HResult hResult = NativeMethods.Get(this, propertyName, &value, out valueType);

                if (hResult.Failed)
                    throw (Exception)hResult;

                if (value.vt == VARENUM.VT_NULL)
                    return default(TResult);

                return (TResult)VariantToObject(ref value, valueType);
            }
            finally
            {
                NativeMethods.VariantClear(&value);
            }
        }

        internal IEnumerable<string> GetNames()
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            HResult hResult = NativeMethods.GetNames(this, out IntPtr pSafeArrayWithNames);

            if (hResult.Failed)
                throw (Exception)hResult;

            try
            {
                foreach (string name in SafeArray.ForEachBSTR(pSafeArrayWithNames))
                    yield return name;
            }
            finally
            {
                NativeMethods.SafeArrayDestroy(pSafeArrayWithNames);
            }
        }

        internal void GetMethod(string methodName, out WbemClassObject inSignatur, out WbemClassObject outSignatur)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            HResult hResult = NativeMethods.GetMethod(this, methodName, out IntPtr pInSignatur, out IntPtr pOutSignatur);

            if (hResult.Failed)
                throw (Exception)hResult;

            inSignatur = pInSignatur == IntPtr.Zero ? null : new WbemClassObject(pInSignatur);
            outSignatur = pOutSignatur == IntPtr.Zero ? null : new WbemClassObject(pOutSignatur);
        }

        internal WbemClassObject SpawnInstance()
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            HResult hResult = NativeMethods.SpawnInstance(this, out IntPtr pNewInstance);

            if (hResult.Failed)
                throw (Exception)hResult;

            return new WbemClassObject(pNewInstance);
        }

        internal unsafe void Put(string propertyName, sbyte propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_I1, SInt8 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, byte propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_UI1, UInt8 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, short propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_I2, SInt16 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, ushort propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_UI2, UInt16 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, int propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_I4, SInt32 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, uint propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_UI4, UInt32 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, long propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_I8, SInt64 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, ulong propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_UI8, UInt64 = propertyValue };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, bool propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = new VARIANT() { vt = VARENUM.VT_BOOL, Boolean = propertyValue ? VT_BOOL.VARIANT_TRUE : VT_BOOL.VARIANT_FALSE };

            HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

            if (hResult.Failed)
                throw (Exception)hResult;
        }

        internal unsafe void Put(string propertyName, string propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            VARIANT value = propertyValue != null
                ? new VARIANT() { vt = VARENUM.VT_BSTR, BStrVal = Marshal.StringToBSTR(propertyValue) }
                : new VARIANT() { vt = VARENUM.VT_NULL, };

            try
            {
                HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

                if (hResult.Failed)
                    throw (Exception)hResult;
            }
            finally
            {
                if (value.BStrVal != IntPtr.Zero)
                    Marshal.FreeBSTR(value.BStrVal);
            }
        }

        internal unsafe void Put(string propertyName, string[] propertyValue)
        {
            if (this.Disposed)
                throw new ObjectDisposedException(nameof(WbemClassObject));

            if (propertyValue != null)
            {
                IntPtr pSafeArray = NativeMethods.SafeArrayCreateVector(VARENUM.VT_BSTR, 0, (uint)propertyValue.Length);

                int index = 0;

                HResult hResult;

                try
                {
                    foreach (string currentPropValue in propertyValue)
                    {
                        IntPtr pCurrentPropValue = Marshal.StringToBSTR(currentPropValue);

                        try
                        {
                            hResult = NativeMethods.SafeArrayPutElement(pSafeArray, new int[] { index++ }, pCurrentPropValue);

                            if (hResult.Failed)
                                throw (Exception)hResult;
                        }
                        finally
                        {
                            Marshal.FreeBSTR(pCurrentPropValue);
                        }
                    }

                    VARIANT value = new VARIANT() { vt = VARENUM.VT_BSTR | VARENUM.VT_ARRAY, BStrVal = pSafeArray };

                    hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

                    if (hResult.Failed)
                        throw (Exception)hResult;
                }
                finally
                {
                    NativeMethods.SafeArrayDestroy(pSafeArray);
                }
            }
            else
            {
                VARIANT value = new VARIANT() { vt = VARENUM.VT_NULL };

                try
                {
                    HResult hResult = NativeMethods.Put(this, propertyName, &value, CimType.None); /* Always CimType.None because this parameter is only for new properties. */

                    if (hResult.Failed)
                        throw (Exception)hResult;
                }
                finally
                {
                    if (value.BStrVal != IntPtr.Zero)
                        Marshal.FreeBSTR(value.BStrVal);
                }
            }
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

                    case CimType.Object:
                        return VariantToArray<WbemClassObject>(ref value, typeWithoutArrayFlag);

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
                        if (value.vt == VARENUM.VT_BSTR)
                            return ulong.Parse(Marshal.PtrToStringBSTR(value.BStrVal));

                        return value.UInt64;

                    case CimType.Char16:
                        return value.Char16;

                    case CimType.DateTime:
                        return Marshal.PtrToStringBSTR(value.BStrVal);

                    case CimType.Object:

                        Guid iid = InterfaceIdentifier.IWbemClassObject;

                        HResult hResult = Marshal.QueryInterface(value.Object, ref iid, out IntPtr pWbemObject);

                        if (hResult.Failed)
                            throw (Exception)hResult;

                        return new WbemClassObject(pWbemObject);

                    case CimType.Reference:

                        if (value.vt == VARENUM.VT_BSTR)
                            return Marshal.PtrToStringBSTR(value.BStrVal);

                        throw new NotSupportedException($"CimType Reference with VARENUM {value.vt} currently not supported.");

                    default:
                        throw new NotSupportedException($"CimType '{type}' currently not supported.");
                }
            }
        }

        internal unsafe static T[] VariantToArray<T>(ref VARIANT value, CimType type)
        {
            uint arrayDims = NativeMethods.SafeArrayGetDim(value.Object);

            if (arrayDims != 1)
                throw new NotSupportedException("Only single-dimensional arrays are supported");

            T[] array = new T[SafeArray.GetLength(value.Object, arrayDims)];

            int index = 0;

            foreach (IntPtr pElement in SafeArray.ForEach(value.Object, arrayDims))
            {
                VARIANT variant = new VARIANT() { vt = value.vt & ~VARENUM.VT_ARRAY, Object = pElement };

                try
                {
                    array[index++] = (T)VariantToObject(ref variant, type);
                }
                finally
                {
                    NativeMethods.VariantClear(&variant);
                }
            }

            return array;
        }
    }
}
