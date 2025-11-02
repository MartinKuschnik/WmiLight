namespace WmiLight
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    [DebuggerDisplay("{vt}")]
    [StructLayout(LayoutKind.Explicit, Size = 24, CharSet = CharSet.Unicode)]
    internal struct VARIANT
    {
        [FieldOffset(0)]
        public VARENUM vt;

        [FieldOffset(8)]
        public sbyte SInt8;

        [FieldOffset(8)]
        public byte UInt8;

        [FieldOffset(8)]
        public short SInt16;

        [FieldOffset(8)]
        public ushort UInt16;

        [FieldOffset(8)]
        public int SInt32;

        [FieldOffset(8)]
        public uint UInt32;

        [FieldOffset(8)]
        public long SInt64;

        [FieldOffset(8)]
        public ulong UInt64;

        [FieldOffset(8)]
        public VT_BOOL Boolean;

        [FieldOffset(8)]
        public char Char16;

        [FieldOffset(8)]
        public float Real32;

        [FieldOffset(8)]
        public double Real64;

        [FieldOffset(8)]
        public IntPtr BStrVal;

        [FieldOffset(8)]
        public IntPtr Object;
    }
}
