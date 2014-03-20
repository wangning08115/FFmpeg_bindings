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
        public unsafe partial struct av_intfloat32
        {
            public uint i;

            public float f;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct av_intfloat64
        {
            public ulong i;

            public double f;
        }

        /// <summary>
        /// Reinterpret a 32-bit integer as a float.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_int2float")]
        public static extern float av_int2float(uint i);

        /// <summary>
        /// Reinterpret a float as a 32-bit integer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_float2int")]
        public static extern uint av_float2int(float f);

        /// <summary>
        /// Reinterpret a 64-bit integer as a double.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_int2double")]
        public static extern double av_int2double(ulong i);

        /// <summary>
        /// Reinterpret a double as a 64-bit integer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_double2int")]
        public static extern ulong av_double2int(double f);
    }
}
