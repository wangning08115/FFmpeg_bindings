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
        public const sbyte AV_TIMECODE_STR_SIZE = 16;

        [Flags]
        public enum AVTimecodeFlag
        {
            /// <summary>timecode is drop frame</summary>
            AV_TIMECODE_FLAG_DROPFRAME = 1,
            /// <summary>timecode wraps after 24 hours</summary>
            AV_TIMECODE_FLAG_24HOURSMAX = 2,
            /// <summary>negative time values are allowed</summary>
            AV_TIMECODE_FLAG_ALLOWNEGATIVE = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVTimecode
        {
            /// <summary>
            /// timecode frame start (first base frame number)
            /// </summary>
            public int start;

            /// <summary>
            /// flags such as drop frame, +24 hours support, ...
            /// </summary>
            public uint flags;

            /// <summary>
            /// frame rate in rational form
            /// </summary>
            public libavutil.AVRational rate;

            /// <summary>
            /// frame per second; must be consistent with the rate field
            /// </summary>
            public uint fps;
        }

        /// <summary>
        /// Adjust frame number for NTSC drop frame time code.
        /// 
        /// @param framenum frame number to adjust
        /// @return         adjusted frame number
        /// @warning        adjustment is only valid in NTSC 29.97
        /// @deprecated     use av_timecode_adjust_ntsc_framenum2 instead
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_adjust_ntsc_framenum")]
        public static extern int av_timecode_adjust_ntsc_framenum(int framenum);

        /// <summary>
        /// Adjust frame number for NTSC drop frame time code.
        /// 
        /// @param framenum frame number to adjust
        /// @param fps      frame per second, 30 or 60
        /// @return         adjusted frame number
        /// @warning        adjustment is only valid in NTSC 29.97 and 59.94
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_adjust_ntsc_framenum2")]
        public static extern int av_timecode_adjust_ntsc_framenum2(int framenum, int fps);

        /// <summary>
        /// Convert frame number to SMPTE 12M binary representation.
        /// 
        /// @param tc       timecode data correctly initialized
        /// @param framenum frame number
        /// @return         the SMPTE binary representation
        /// 
        /// @note Frame number adjustment is automatically done in case of drop
        /// timecode,
        /// you do NOT have to call av_timecode_adjust_ntsc_framenum().
        /// @note The frame number is relative to tc->start.
        /// @note Color frame (CF), binary group flags (BGF) and biphase mark
        /// polarity
        /// correction (PC) bits are set to zero.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_get_smpte_from_framenum")]
        public static extern uint av_timecode_get_smpte_from_framenum(libavutil.AVTimecode* tc, int framenum);

        /// <summary>
        /// Load timecode string in buf.
        /// 
        /// @param buf      destination buffer, must be at least
        /// AV_TIMECODE_STR_SIZE long
        /// @param tc       timecode data correctly initialized
        /// @param framenum frame number
        /// @return         the buf parameter
        /// 
        /// @note Timecode representation can be a negative timecode and have more
        /// than
        /// 24 hours, but will only be honored if the flags are correctly set.
        /// @note The frame number is relative to tc->start.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_make_string")]
        public static extern sbyte* av_timecode_make_string(libavutil.AVTimecode* tc, System.Text.StringBuilder buf, int framenum);

        /// <summary>
        /// Get the timecode string from the SMPTE timecode format.
        /// 
        /// @param buf        destination buffer, must be at least
        /// AV_TIMECODE_STR_SIZE long
        /// @param tcsmpte    the 32-bit SMPTE timecode
        /// @param prevent_df prevent the use of a drop flag when it is known the
        /// DF bit
        /// is arbitrary
        /// @return           the buf parameter
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_make_smpte_tc_string")]
        public static extern sbyte* av_timecode_make_smpte_tc_string(System.Text.StringBuilder buf, uint tcsmpte, int prevent_df);

        /// <summary>
        /// Get the timecode string from the 25-bit timecode format (MPEG GOP
        /// format).
        /// 
        /// @param buf     destination buffer, must be at least
        /// AV_TIMECODE_STR_SIZE long
        /// @param tc25bit the 25-bits timecode
        /// @return        the buf parameter
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_make_mpeg_tc_string")]
        public static extern sbyte* av_timecode_make_mpeg_tc_string(System.Text.StringBuilder buf, uint tc25bit);

        /// <summary>
        /// Init a timecode struct with the passed parameters.
        /// 
        /// @param log_ctx     a pointer to an arbitrary struct of which the first
        /// field
        /// is a pointer to an AVClass struct (used for av_log)
        /// @param tc          pointer to an allocated AVTimecode
        /// @param rate        frame rate in rational form
        /// @param flags       miscellaneous flags such as drop frame, +24 hours,
        /// ...
        /// (see AVTimecodeFlag)
        /// @param frame_start the first frame number
        /// @return            0 on success, AVERROR otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_init")]
        public static extern int av_timecode_init(libavutil.AVTimecode* tc, libavutil.AVRational rate, int flags, int frame_start, void* log_ctx);

        /// <summary>
        /// Parse timecode representation (hh:mm:ss[:;.]ff).
        /// 
        /// @param log_ctx a pointer to an arbitrary struct of which the first
        /// field is a
        /// pointer to an AVClass struct (used for av_log).
        /// @param tc      pointer to an allocated AVTimecode
        /// @param rate    frame rate in rational form
        /// @param str     timecode string which will determine the frame start
        /// @return        0 on success, AVERROR otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_init_from_string")]
        public static extern int av_timecode_init_from_string(libavutil.AVTimecode* tc, libavutil.AVRational rate, string str, void* log_ctx);

        /// <summary>
        /// Check if the timecode feature is available for the given frame rate
        /// 
        /// @return 0 if supported, <0 otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_timecode_check_frame_rate")]
        public static extern int av_timecode_check_frame_rate(libavutil.AVRational rate);
    }
}
