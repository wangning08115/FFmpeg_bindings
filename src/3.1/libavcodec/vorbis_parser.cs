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
using FFmpeg;

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
    public unsafe static partial class libavcodec
    {
        public const sbyte VORBIS_FLAG_HEADER = 0x1;

        public const sbyte VORBIS_FLAG_COMMENT = 0x2;

        public const sbyte VORBIS_FLAG_SETUP = 0x4;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVVorbisParseContext
        {
        }

        /// <summary>
        /// Allocate and initialize the Vorbis parser using headers in the
        /// extradata.
        /// </summary>
        /// <param name="avctx">
        /// codec context
        /// </param>
        /// <param name="s">
        /// Vorbis parser context
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_vorbis_parse_init")]
        public static extern libavcodec.AVVorbisParseContext* av_vorbis_parse_init(byte* extradata, int extradata_size);

        /// <summary>
        /// Free the parser and everything associated with it.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_vorbis_parse_free")]
        public static extern void av_vorbis_parse_free(libavcodec.AVVorbisParseContext** s);

        /// <summary>
        /// Free the parser and everything associated with it.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_vorbis_parse_free")]
        public static extern void av_vorbis_parse_free(ref libavcodec.AVVorbisParseContext* s);

        /// <summary>
        /// Get the duration for a Vorbis packet.
        /// 
        /// If @p flags is @c NULL,
        /// special frames are considered invalid.
        /// </summary>
        /// <param name="s">
        /// Vorbis parser context
        /// </param>
        /// <param name="buf">
        /// buffer containing a Vorbis frame
        /// </param>
        /// <param name="buf_size">
        /// size of the buffer
        /// </param>
        /// <param name="flags">
        /// flags for special frames
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_vorbis_parse_frame_flags")]
        public static extern int av_vorbis_parse_frame_flags(libavcodec.AVVorbisParseContext* s, byte* buf, int buf_size, int* flags);

        /// <summary>
        /// Get the duration for a Vorbis packet.
        /// </summary>
        /// <param name="s">
        /// Vorbis parser context
        /// </param>
        /// <param name="buf">
        /// buffer containing a Vorbis frame
        /// </param>
        /// <param name="buf_size">
        /// size of the buffer
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_vorbis_parse_frame")]
        public static extern int av_vorbis_parse_frame(libavcodec.AVVorbisParseContext* s, byte* buf, int buf_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_vorbis_parse_reset")]
        public static extern void av_vorbis_parse_reset(libavcodec.AVVorbisParseContext* s);
    }
}
