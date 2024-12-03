using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WmiLight
{
    internal static class SafeArray
    {
        internal static IEnumerable<IntPtr> ForEach(IntPtr pSafeArray, uint nDim = 1)
        {
            int lBound, uBound;

            HResult hResult = NativeMethods.SafeArrayGetLBound(pSafeArray, nDim, out lBound);

            if (hResult.Failed)
                throw (Exception)hResult;

            hResult = NativeMethods.SafeArrayGetUBound(pSafeArray, nDim, out uBound);

            if (hResult.Failed)
                throw (Exception)hResult;

            for (int i = lBound; i <= uBound; i++)
            {
                hResult = NativeMethods.SafeArrayGetElement(pSafeArray, i, out IntPtr pElement);

                if (hResult.Failed)
                    throw (Exception)hResult;

                yield return pElement;
            }
        }

        internal static IEnumerable<string> ForEachBSTR(IntPtr pSafeArray, uint nDim = 1)
        {
            foreach (IntPtr pElement in ForEach(pSafeArray, nDim))
            {
                string stringValue = Marshal.PtrToStringBSTR(pElement);

                Marshal.FreeBSTR(pElement);

                yield return stringValue;
            }
        }

        internal static int GetLength(IntPtr pSafeArray, uint nDim = 1)
        {
            int lBound, uBound;

            HResult hResult = NativeMethods.SafeArrayGetLBound(pSafeArray, nDim, out lBound);

            if (hResult.Failed)
                throw (Exception)hResult;

            hResult = NativeMethods.SafeArrayGetUBound(pSafeArray, nDim, out uBound);

            if (hResult.Failed)
                throw (Exception)hResult;

            return uBound - lBound + 1;
        }
    }
}
