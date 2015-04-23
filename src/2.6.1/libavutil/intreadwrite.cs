//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    public unsafe static partial class libavutil
    {
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct av_alias64
        {
            public ulong u64;

            public fixed uint u32[2];

            public fixed ushort u16[4];

            public fixed byte u8[8];

            public double f64;

            public fixed float f32[2];
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct av_alias32
        {
            public uint u32;

            public fixed ushort u16[2];

            public fixed byte u8[4];

            public float f32;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct av_alias16
        {
            public ushort u16;

            public fixed byte u8[2];
        }
    }
}