//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
// ReSharper disable RedundantUsingDirective
// ReSharper disable CheckNamespace
#pragma warning disable 1584,1711,1572,1581,1580,1573
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "UnusedMember.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "InconsistentNaming")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantUnsafeContext")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "FieldCanBeMadeReadOnly.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "PartialTypeWithSinglePart")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantNameQualifier")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "ArrangeModifiersOrder")]
    public unsafe static partial class libavutil
    {
        public const sbyte AV_BF_ROUNDS = 16;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVBlowfish
        {
            public fixed uint p[18];

            public libavutil.ArrayWrapper_Uint__4 s;
        }

        /// <summary>
        /// Allocate an AVBlowfish context.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_blowfish_alloc")]
        public static extern libavutil.AVBlowfish* av_blowfish_alloc();

        /// <summary>
        /// Initialize an AVBlowfish context.
        /// </summary>
        /// <param name="ctx">
        /// an AVBlowfish context
        /// </param>
        /// <param name="key">
        /// a key
        /// </param>
        /// <param name="key_len">
        /// length of the key
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_blowfish_init")]
        public static extern void av_blowfish_init(libavutil.AVBlowfish* ctx, byte* key, int key_len);

        /// <summary>
        /// Encrypt or decrypt a buffer using a previously initialized context.
        /// </summary>
        /// <param name="ctx">
        /// an AVBlowfish context
        /// </param>
        /// <param name="xl">
        /// left four bytes halves of input to be encrypted
        /// </param>
        /// <param name="xr">
        /// right four bytes halves of input to be encrypted
        /// </param>
        /// <param name="decrypt">
        /// 0 for encryption, 1 for decryption
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_blowfish_crypt_ecb")]
        public static extern void av_blowfish_crypt_ecb(libavutil.AVBlowfish* ctx, uint* xl, uint* xr, int decrypt);

        /// <summary>
        /// Encrypt or decrypt a buffer using a previously initialized context.
        /// </summary>
        /// <param name="ctx">
        /// an AVBlowfish context
        /// </param>
        /// <param name="dst">
        /// destination array, can be equal to src
        /// </param>
        /// <param name="src">
        /// source array, can be equal to dst
        /// </param>
        /// <param name="count">
        /// number of 8 byte blocks
        /// </param>
        /// <param name="iv">
        /// initialization vector for CBC mode, if NULL ECB will be used
        /// </param>
        /// <param name="decrypt">
        /// 0 for encryption, 1 for decryption
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_blowfish_crypt")]
        public static extern void av_blowfish_crypt(libavutil.AVBlowfish* ctx, byte* dst, byte* src, int count, byte* iv, int decrypt);
    }
}
