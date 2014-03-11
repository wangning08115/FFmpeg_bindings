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
        public unsafe partial struct AVAES
        {
        }

        /// <summary>
        /// Initialize an AVAES context.
        /// @param key_bits 128, 192 or 256
        /// @param decrypt 0 for encryption, 1 for decryption
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_aes_init")]
        public static extern int av_aes_init(libavutil.AVAES* a, byte* key, int key_bits, int decrypt);

        /// <summary>
        /// Encrypt or decrypt a buffer using a previously initialized context.
        /// @param count number of 16 byte blocks
        /// @param dst destination array, can be equal to src
        /// @param src source array, can be equal to dst
        /// @param iv initialization vector for CBC mode, if NULL then ECB will be
        /// used
        /// @param decrypt 0 for encryption, 1 for decryption
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_aes_crypt")]
        public static extern void av_aes_crypt(libavutil.AVAES* a, byte* dst, byte* src, int count, byte* iv, int decrypt);
    }
}