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
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log2_c")]
        public static extern int av_log2_c(uint v);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log2_16bit_c")]
        public static extern int av_log2_16bit_c(uint v);

        /// <summary>
        /// Clip a signed integer value into the amin-amax range.
        /// @param a value to clip
        /// @param amin minimum value of the clip range
        /// @param amax maximum value of the clip range
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clip_c")]
        public static extern int av_clip_c(int a, int amin, int amax);

        /// <summary>
        /// Clip a signed integer value into the 0-255 range.
        /// @param a value to clip
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clip_uint8_c")]
        public static extern byte av_clip_uint8_c(int a);

        /// <summary>
        /// Clip a signed integer value into the -128,127 range.
        /// @param a value to clip
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clip_int8_c")]
        public static extern sbyte av_clip_int8_c(int a);

        /// <summary>
        /// Clip a signed integer value into the 0-65535 range.
        /// @param a value to clip
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clip_uint16_c")]
        public static extern ushort av_clip_uint16_c(int a);

        /// <summary>
        /// Clip a signed integer value into the -32768,32767 range.
        /// @param a value to clip
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clip_int16_c")]
        public static extern short av_clip_int16_c(int a);

        /// <summary>
        /// Clip a signed 64-bit integer value into the -2147483648,2147483647
        /// range.
        /// @param a value to clip
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clipl_int32_c")]
        public static extern int av_clipl_int32_c(long a);

        /// <summary>
        /// Clip a signed integer to an unsigned power of two range.
        /// @param  a value to clip
        /// @param  p bit position to clip at
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clip_uintp2_c")]
        public static extern uint av_clip_uintp2_c(int a, int p);

        /// <summary>
        /// Add two signed 32-bit values with saturation.
        /// 
        /// @param  a one value
        /// @param  b another value
        /// @return sum with signed saturation
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_sat_add32_c")]
        public static extern int av_sat_add32_c(int a, int b);

        /// <summary>
        /// Add a doubled value to another value with saturation at both stages.
        /// 
        /// @param  a first value
        /// @param  b value doubled and added to a
        /// @return sum with signed saturation
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_sat_dadd32_c")]
        public static extern int av_sat_dadd32_c(int a, int b);

        /// <summary>
        /// Clip a float value into the amin-amax range.
        /// @param a value to clip
        /// @param amin minimum value of the clip range
        /// @param amax maximum value of the clip range
        /// @return clipped value
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_clipf_c")]
        public static extern float av_clipf_c(float a, float amin, float amax);

        /// <summary>
        /// Compute ceil(log2(x)).
        /// @param x value used to compute ceil(log2(x))
        /// @return computed ceiling of log2(x)
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_ceil_log2_c")]
        public static extern int av_ceil_log2_c(int x);

        /// <summary>
        /// Count number of bits set to one in x
        /// @param x value to count bits of
        /// @return the number of bits set to one in x
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_popcount_c")]
        public static extern int av_popcount_c(uint x);

        /// <summary>
        /// Count number of bits set to one in x
        /// @param x value to count bits of
        /// @return the number of bits set to one in x
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_popcount64_c")]
        public static extern int av_popcount64_c(ulong x);
    }
}
