//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using FFmpeg;

namespace FFmpeg
{
    /// <summary>
    /// @defgroup lavc_fft FFT functions
    /// @ingroup lavc_misc
    /// 
    /// @{
    /// </summary>
    public unsafe static partial class libavcodec
    {
        public enum RDFTransformType
        {
            DFT_R2C = 0,
            IDFT_C2R = 1,
            IDFT_R2C = 2,
            DFT_C2R = 3
        }

        public enum DCTTransformType
        {
            DCT_II = 0,
            DCT_III = 1,
            DCT_I = 2,
            DST_I = 3
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct FFTComplex
        {
            public float re;

            public float im;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct FFTContext
        {
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct RDFTContext
        {
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct DCTContext
        {
        }

        /// <summary>
        /// Set up a complex FFT.
        /// @param nbits           log2 of the length of the input array
        /// @param inverse         if 0 perform the forward transform, if 1 perform
        /// the inverse
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_fft_init")]
        public static extern libavcodec.FFTContext* av_fft_init(int nbits, int inverse);

        /// <summary>
        /// Do the permutation needed BEFORE calling ff_fft_calc().
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_fft_permute")]
        public static extern void av_fft_permute(libavcodec.FFTContext* s, libavcodec.FFTComplex* z);

        /// <summary>
        /// Do a complex FFT with the parameters defined in av_fft_init(). The
        /// input data must be permuted before. No 1.0/sqrt(n) normalization is
        /// done.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_fft_calc")]
        public static extern void av_fft_calc(libavcodec.FFTContext* s, libavcodec.FFTComplex* z);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_fft_end")]
        public static extern void av_fft_end(libavcodec.FFTContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_mdct_init")]
        public static extern libavcodec.FFTContext* av_mdct_init(int nbits, int inverse, double scale);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_imdct_calc")]
        public static extern void av_imdct_calc(libavcodec.FFTContext* s, float* output, float* input);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_imdct_half")]
        public static extern void av_imdct_half(libavcodec.FFTContext* s, float* output, float* input);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_mdct_calc")]
        public static extern void av_mdct_calc(libavcodec.FFTContext* s, float* output, float* input);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_mdct_end")]
        public static extern void av_mdct_end(libavcodec.FFTContext* s);

        /// <summary>
        /// Set up a real FFT.
        /// @param nbits           log2 of the length of the input array
        /// @param trans           the type of transform
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_rdft_init")]
        public static extern libavcodec.RDFTContext* av_rdft_init(int nbits, libavcodec.RDFTransformType trans);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_rdft_calc")]
        public static extern void av_rdft_calc(libavcodec.RDFTContext* s, float* data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_rdft_end")]
        public static extern void av_rdft_end(libavcodec.RDFTContext* s);

        /// <summary>
        /// Set up DCT.
        /// @param nbits           size of the input array:
        /// (1 << nbits)     for DCT-II, DCT-III and DST-I
        /// (1 << nbits) + 1 for DCT-I
        /// 
        /// @note the first element of the input of DST-I is ignored
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dct_init")]
        public static extern libavcodec.DCTContext* av_dct_init(int nbits, libavcodec.DCTTransformType type);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dct_calc")]
        public static extern void av_dct_calc(libavcodec.DCTContext* s, float* data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dct_end")]
        public static extern void av_dct_end(libavcodec.DCTContext* s);
    }
}
