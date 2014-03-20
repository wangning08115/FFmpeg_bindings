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
        public const uint AV_CPU_FLAG_FORCE = 80000000;

        public const sbyte AV_CPU_FLAG_MMX = 1;

        public const sbyte AV_CPU_FLAG_MMXEXT = 2;

        public const sbyte AV_CPU_FLAG_MMX2 = 2;

        public const sbyte AV_CPU_FLAG_3DNOW = 4;

        public const sbyte AV_CPU_FLAG_SSE = 8;

        public const sbyte AV_CPU_FLAG_SSE2 = 10;

        public const int AV_CPU_FLAG_SSE2SLOW = 40000000;

        public const sbyte AV_CPU_FLAG_3DNOWEXT = 20;

        public const sbyte AV_CPU_FLAG_SSE3 = 40;

        public const int AV_CPU_FLAG_SSE3SLOW = 20000000;

        public const byte AV_CPU_FLAG_SSSE3 = 80;

        public const int AV_CPU_FLAG_ATOM = 10000000;

        public const short AV_CPU_FLAG_SSE4 = 100;

        public const short AV_CPU_FLAG_SSE42 = 200;

        public const short AV_CPU_FLAG_AVX = 4000;

        public const short AV_CPU_FLAG_XOP = 400;

        public const short AV_CPU_FLAG_FMA4 = 800;

        public const int AV_CPU_FLAG_CMOV = 1001000;

        public const ushort AV_CPU_FLAG_AVX2 = 8000;

        public const int AV_CPU_FLAG_FMA3 = 10000;

        public const int AV_CPU_FLAG_BMI1 = 20000;

        public const int AV_CPU_FLAG_BMI2 = 40000;

        public const sbyte AV_CPU_FLAG_ALTIVEC = 1;

        /// <summary>
        /// Return the flags which specify extensions supported by the CPU.
        /// The returned value is affected by av_force_cpu_flags() if that was used
        /// before. So av_get_cpu_flags() can easily be used in a application to
        /// detect the enabled cpu flags.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_cpu_flags")]
        public static extern int av_get_cpu_flags();

        /// <summary>
        /// Disables cpu detection and forces the specified flags.
        /// -1 is a special case that disables forcing of specific flags.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_force_cpu_flags")]
        public static extern void av_force_cpu_flags(int flags);

        /// <summary>
        /// Set a mask on flags returned by av_get_cpu_flags().
        /// This function is mainly useful for testing.
        /// Please use av_force_cpu_flags() and av_get_cpu_flags() instead which
        /// are more flexible
        /// 
        /// @warning this function is not thread safe.
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_set_cpu_flags_mask")]
        public static extern void av_set_cpu_flags_mask(int mask);

        /// <summary>
        /// Parse CPU flags from a string.
        /// 
        /// The returned flags contain the specified flags as well as related
        /// unspecified flags.
        /// 
        /// This function exists only for compatibility with libav.
        /// Please use av_parse_cpu_caps() when possible.
        /// </summary>
        /// <returns>
        /// a combination of AV_CPU_* flags, negative on error.
        /// </returns>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_parse_cpu_flags")]
        public static extern int av_parse_cpu_flags(string s);

        /// <summary>
        /// Parse CPU caps from a string and update the given AV_CPU_* flags based
        /// on that.
        /// </summary>
        /// <returns>
        /// negative on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_parse_cpu_caps")]
        public static extern int av_parse_cpu_caps(uint* flags, string s);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// the number of logical CPU cores present.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_cpu_count")]
        public static extern int av_cpu_count();
    }
}
