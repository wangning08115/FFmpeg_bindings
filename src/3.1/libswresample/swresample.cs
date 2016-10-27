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
    public unsafe static partial class libswresample
    {
        public const sbyte SWR_FLAG_RESAMPLE = 1;

        /// <summary>
        /// Dithering algorithms
        /// </summary>
        public enum SwrDitherType
        {
            SWR_DITHER_NONE = 0,
            SWR_DITHER_RECTANGULAR = 1,
            SWR_DITHER_TRIANGULAR = 2,
            SWR_DITHER_TRIANGULAR_HIGHPASS = 3,
            /// <summary>not part of API/ABI</summary>
            SWR_DITHER_NS = 64,
            SWR_DITHER_NS_LIPSHITZ = 65,
            SWR_DITHER_NS_F_WEIGHTED = 66,
            SWR_DITHER_NS_MODIFIED_E_WEIGHTED = 67,
            SWR_DITHER_NS_IMPROVED_E_WEIGHTED = 68,
            SWR_DITHER_NS_SHIBATA = 69,
            SWR_DITHER_NS_LOW_SHIBATA = 70,
            SWR_DITHER_NS_HIGH_SHIBATA = 71,
            /// <summary>not part of API/ABI</summary>
            SWR_DITHER_NB = 72
        }

        /// <summary>
        /// Resampling Engines
        /// </summary>
        public enum SwrEngine
        {
            /// <summary>SW Resampler</summary>
            SWR_ENGINE_SWR = 0,
            /// <summary>SoX Resampler</summary>
            SWR_ENGINE_SOXR = 1,
            /// <summary>not part of API/ABI</summary>
            SWR_ENGINE_NB = 2
        }

        /// <summary>
        /// Resampling Filter Types
        /// </summary>
        public enum SwrFilterType
        {
            /// <summary>Cubic</summary>
            SWR_FILTER_TYPE_CUBIC = 0,
            /// <summary>Blackman Nuttall windowed sinc</summary>
            SWR_FILTER_TYPE_BLACKMAN_NUTTALL = 1,
            /// <summary>Kaiser windowed sinc</summary>
            SWR_FILTER_TYPE_KAISER = 2
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct SwrContext
        {
        }

        /// <summary>
        /// Get the AVClass for SwrContext. It can be used in combination with
        /// AV_OPT_SEARCH_FAKE_OBJ for examining options.
        /// 
        /// @see av_opt_find().
        /// </summary>
        /// <returns>
        /// the AVClass of SwrContext
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_get_class")]
        public static extern libavutil.AVClass* swr_get_class();

        /// <summary>
        /// Allocate SwrContext.
        /// 
        /// If you use this function you will need to set the parameters (manually
        /// or
        /// with swr_alloc_set_opts()) before calling swr_init().
        /// 
        /// @see swr_alloc_set_opts(), swr_init(), swr_free()
        /// </summary>
        /// <returns>
        /// NULL on error, allocated context otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_alloc")]
        public static extern libswresample.SwrContext* swr_alloc();

        /// <summary>
        /// Initialize context after user parameters have been set.
        /// </summary>
        /// <remark>
        /// The context must be configured using the AVOption API.
        /// 
        /// @see av_opt_set_int()
        /// @see av_opt_set_dict()
        /// </remark>
        /// <param name="[in,out]">
        /// s Swr context to initialize
        /// </param>
        /// <returns>
        /// AVERROR error code in case of failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_init")]
        public static extern int swr_init(libswresample.SwrContext* s);

        /// <summary>
        /// Check whether an swr context has been initialized or not.
        /// </summary>
        /// <param name="[in]">
        /// s Swr context to check
        /// @see swr_init()
        /// </param>
        /// <returns>
        /// positive if it has been initialized, 0 if not initialized
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_is_initialized")]
        public static extern int swr_is_initialized(libswresample.SwrContext* s);

        /// <summary>
        /// Allocate SwrContext if needed and set/reset common parameters.
        /// 
        /// This function does not require s to be allocated with swr_alloc(). On
        /// the
        /// other hand, swr_alloc() can use swr_alloc_set_opts() to set the
        /// parameters
        /// on the allocated context.
        /// </summary>
        /// <param name="s">
        /// existing Swr context if available, or NULL if not
        /// </param>
        /// <param name="out_ch_layout">
        /// output channel layout (AV_CH_LAYOUT_*)
        /// </param>
        /// <param name="out_sample_fmt">
        /// output sample format (AV_SAMPLE_FMT_*).
        /// </param>
        /// <param name="out_sample_rate">
        /// output sample rate (frequency in Hz)
        /// </param>
        /// <param name="in_ch_layout">
        /// input channel layout (AV_CH_LAYOUT_*)
        /// </param>
        /// <param name="in_sample_fmt">
        /// input sample format (AV_SAMPLE_FMT_*).
        /// </param>
        /// <param name="in_sample_rate">
        /// input sample rate (frequency in Hz)
        /// </param>
        /// <param name="log_offset">
        /// logging level offset
        /// </param>
        /// <param name="log_ctx">
        /// parent logging context, can be NULL
        /// 
        /// @see swr_init(), swr_free()
        /// </param>
        /// <returns>
        /// NULL on error, allocated context otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_alloc_set_opts")]
        public static extern libswresample.SwrContext* swr_alloc_set_opts(libswresample.SwrContext* s, long out_ch_layout, libavutil.AVSampleFormat out_sample_fmt, int out_sample_rate, long in_ch_layout, libavutil.AVSampleFormat in_sample_fmt, int in_sample_rate, int log_offset, void* log_ctx);

        /// <summary>
        /// Free the given SwrContext and set the pointer to NULL.
        /// </summary>
        /// <param name="[in]">
        /// s a pointer to a pointer to Swr context
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_free")]
        public static extern void swr_free(libswresample.SwrContext** s);

        /// <summary>
        /// Free the given SwrContext and set the pointer to NULL.
        /// </summary>
        /// <param name="[in]">
        /// s a pointer to a pointer to Swr context
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_free")]
        public static extern void swr_free(ref libswresample.SwrContext* s);

        /// <summary>
        /// Closes the context so that swr_is_initialized() returns 0.
        /// 
        /// The context can be brought back to life by running swr_init(),
        /// swr_init() can also be used without swr_close().
        /// This function is mainly provided for simplifying the usecase
        /// where one tries to support libavresample and libswresample.
        /// </summary>
        /// <param name="[in,out]">
        /// s Swr context to be closed
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_close")]
        public static extern void swr_close(libswresample.SwrContext* s);

        /// <summary>
        /// Convert audio.
        /// 
        /// in and in_count can be set to 0 to flush the last few samples out at
        /// the
        /// end.
        /// 
        /// If more input is provided than output space, then the input will be
        /// buffered.
        /// You can avoid this buffering by using swr_get_out_samples() to retrieve
        /// an
        /// upper bound on the required number of output samples for the given
        /// number of
        /// input samples. Conversion will run directly without copying whenever
        /// possible.
        /// </summary>
        /// <param name="s">
        /// allocated Swr context, with parameters set
        /// </param>
        /// <param name="out">
        /// output buffers, only the first one need be set in case of packed audio
        /// </param>
        /// <param name="out_count">
        /// amount of space available for output in samples per channel
        /// </param>
        /// <param name="in">
        /// input buffers, only the first one need to be set in case of packed
        /// audio
        /// </param>
        /// <param name="in_count">
        /// number of input samples available in one channel
        /// </param>
        /// <returns>
        /// number of samples output per channel, negative value on error
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_convert")]
        public static extern int swr_convert(libswresample.SwrContext* s, byte** _out, int out_count, byte** _in, int in_count);

        /// <summary>
        /// Convert audio.
        /// 
        /// in and in_count can be set to 0 to flush the last few samples out at
        /// the
        /// end.
        /// 
        /// If more input is provided than output space, then the input will be
        /// buffered.
        /// You can avoid this buffering by using swr_get_out_samples() to retrieve
        /// an
        /// upper bound on the required number of output samples for the given
        /// number of
        /// input samples. Conversion will run directly without copying whenever
        /// possible.
        /// </summary>
        /// <param name="s">
        /// allocated Swr context, with parameters set
        /// </param>
        /// <param name="out">
        /// output buffers, only the first one need be set in case of packed audio
        /// </param>
        /// <param name="out_count">
        /// amount of space available for output in samples per channel
        /// </param>
        /// <param name="in">
        /// input buffers, only the first one need to be set in case of packed
        /// audio
        /// </param>
        /// <param name="in_count">
        /// number of input samples available in one channel
        /// </param>
        /// <returns>
        /// number of samples output per channel, negative value on error
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_convert")]
        public static extern int swr_convert(libswresample.SwrContext* s, ref byte* _out, int out_count, ref byte* _in, int in_count);

        /// <summary>
        /// Convert the next timestamp from input to output
        /// timestamps are in 1/(in_sample_rate * out_sample_rate) units.
        /// </summary>
        /// <remark>
        /// There are 2 slightly differently behaving modes.
        /// @li When automatic timestamp compensation is not used,
        /// (min_compensation &gt;= FLT_MAX)
        /// in this case timestamps will be passed through with delays compensated
        /// @li When automatic timestamp compensation is used, (min_compensation
        /// &lt; FLT_MAX)
        /// in this case the output timestamps will match output sample numbers.
        /// See ffmpeg-resampler(1) for the two modes of compensation.
        /// </remark>
        /// <param name="s[in]">
        /// initialized Swr context
        /// </param>
        /// <param name="pts[in]">
        /// timestamp for the next input sample, INT64_MIN if unknown
        /// @see swr_set_compensation(), swr_drop_output(), and
        /// swr_inject_silence() are
        /// function used internally for timestamp compensation.
        /// </param>
        /// <returns>
        /// the output timestamp for the next output sample
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_next_pts")]
        public static extern long swr_next_pts(libswresample.SwrContext* s, long pts);

        /// <summary>
        /// Activate resampling compensation ("soft" compensation). This function
        /// is
        /// internally called when needed in swr_next_pts().
        /// </summary>
        /// <param name="[in,out]">
        /// s             allocated Swr context. If it is not initialized,
        /// or SWR_FLAG_RESAMPLE is not set, swr_init() is
        /// called with the flag set.
        /// </param>
        /// <param name="[in]">
        /// sample_delta  delta in PTS per sample
        /// </param>
        /// <param name="[in]">
        /// compensation_distance number of samples to compensate for
        /// </param>
        /// <returns>
        /// &gt;= 0 on success, AVERROR error codes if:
        /// @li @c s is NULL,
        /// @li @c compensation_distance is less than 0,
        /// @li @c compensation_distance is 0 but sample_delta is not,
        /// @li compensation unsupported by resampler, or
        /// @li swr_init() fails when called.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_set_compensation")]
        public static extern int swr_set_compensation(libswresample.SwrContext* s, int sample_delta, int compensation_distance);

        /// <summary>
        /// Set a customized input channel mapping.
        /// </summary>
        /// <param name="[in,out]">
        /// s           allocated Swr context, not yet initialized
        /// </param>
        /// <param name="[in]">
        /// channel_map customized input channel mapping (array of channel
        /// indexes, -1 for a muted channel)
        /// </param>
        /// <returns>
        /// &gt;= 0 on success, or AVERROR error code in case of failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_set_channel_mapping")]
        public static extern int swr_set_channel_mapping(libswresample.SwrContext* s, int* channel_map);

        /// <summary>
        /// Set a customized remix matrix.
        /// </summary>
        /// <param name="s">
        /// allocated Swr context, not yet initialized
        /// </param>
        /// <param name="matrix">
        /// remix coefficients; matrix[i + stride * o] is
        /// the weight of input channel i in output channel o
        /// </param>
        /// <param name="stride">
        /// offset between lines of the matrix
        /// </param>
        /// <returns>
        /// &gt;= 0 on success, or AVERROR error code in case of failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_set_matrix")]
        public static extern int swr_set_matrix(libswresample.SwrContext* s, double* matrix, int stride);

        /// <summary>
        /// Drops the specified number of output samples.
        /// 
        /// This function, along with swr_inject_silence(), is called by
        /// swr_next_pts()
        /// if needed for "hard" compensation.
        /// </summary>
        /// <param name="s">
        /// allocated Swr context
        /// </param>
        /// <param name="count">
        /// number of samples to be dropped
        /// </param>
        /// <returns>
        /// &gt;= 0 on success, or a negative AVERROR code on failure
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_drop_output")]
        public static extern int swr_drop_output(libswresample.SwrContext* s, int count);

        /// <summary>
        /// Injects the specified number of silence samples.
        /// 
        /// This function, along with swr_drop_output(), is called by
        /// swr_next_pts()
        /// if needed for "hard" compensation.
        /// </summary>
        /// <param name="s">
        /// allocated Swr context
        /// </param>
        /// <param name="count">
        /// number of samples to be dropped
        /// </param>
        /// <returns>
        /// &gt;= 0 on success, or a negative AVERROR code on failure
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_inject_silence")]
        public static extern int swr_inject_silence(libswresample.SwrContext* s, int count);

        /// <summary>
        /// Gets the delay the next input sample will experience relative to the
        /// next output sample.
        /// 
        /// Swresample can buffer data if more input has been provided than
        /// available
        /// output space, also converting between sample rates needs a delay.
        /// This function returns the sum of all such delays.
        /// The exact delay is not necessarily an integer value in either input or
        /// output sample rate. Especially when downsampling by a large value, the
        /// output sample rate may be a poor choice to represent the delay,
        /// similarly
        /// for upsampling and the input sample rate.
        /// </summary>
        /// <param name="s">
        /// swr context
        /// </param>
        /// <param name="base">
        /// timebase in which the returned delay will be:
        /// @li if it's set to 1 the returned delay is in seconds
        /// @li if it's set to 1000 the returned delay is in milliseconds
        /// @li if it's set to the input sample rate then the returned
        /// delay is in input samples
        /// @li if it's set to the output sample rate then the returned
        /// delay is in output samples
        /// @li if it's the least common multiple of in_sample_rate and
        /// out_sample_rate then an exact rounding-free delay will be
        /// returned
        /// </param>
        /// <returns>
        /// s     the delay in 1 / @c base units.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_get_delay")]
        public static extern long swr_get_delay(libswresample.SwrContext* s, long _base);

        /// <summary>
        /// Find an upper bound on the number of samples that the next swr_convert
        /// call will output, if called with in_samples of input samples. This
        /// depends on the internal state, and anything changing the internal state
        /// (like further swr_convert() calls) will may change the number of
        /// samples
        /// swr_get_out_samples() returns for the same number of input samples.
        /// </summary>
        /// <param name="in_samples">
        /// number of input samples.
        /// </param>
        /// <remark>
        /// any call to swr_inject_silence(), swr_convert(), swr_next_pts()
        /// or swr_set_compensation() invalidates this limit
        /// </remark>
        /// <remark>
        /// it is recommended to pass the correct available buffer size
        /// to all functions like swr_convert() even if swr_get_out_samples()
        /// indicates that less would be used.
        /// </remark>
        /// <returns>
        /// s an upper bound on the number of samples that the next swr_convert
        /// will output or a negative value to indicate an error
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_get_out_samples")]
        public static extern int swr_get_out_samples(libswresample.SwrContext* s, int in_samples);

        /// <summary>
        /// Return the @ref LIBSWRESAMPLE_VERSION_INT constant.
        /// 
        /// This is useful to check if the build-time libswresample has the same
        /// version
        /// as the run-time one.
        /// </summary>
        /// <returns>
        /// s     the unsigned int-typed version
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swresample_version")]
        public static extern uint swresample_version();

        /// <summary>
        /// Return the swr build-time configuration.
        /// </summary>
        /// <returns>
        /// s     the build-time @c ./configure flags
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swresample_configuration")]
        public static extern sbyte* swresample_configuration();

        /// <summary>
        /// Return the swr license.
        /// </summary>
        /// <returns>
        /// s     the license of libswresample, determined at build-time
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swresample_license")]
        public static extern sbyte* swresample_license();

        /// <summary>
        /// Convert the samples in the input AVFrame and write them to the output
        /// AVFrame.
        /// 
        /// Input and output AVFrames must have channel_layout, sample_rate and
        /// format set.
        /// 
        /// If the output AVFrame does not have the data pointers allocated the
        /// nb_samples
        /// field will be set using av_frame_get_buffer()
        /// is called to allocate the frame.
        /// 
        /// The output AVFrame can be NULL or have fewer allocated samples than
        /// required.
        /// In this case, any remaining samples not written to the output will be
        /// added
        /// to an internal FIFO buffer, to be returned at the next call to this
        /// function
        /// or to swr_convert().
        /// 
        /// If converting sample rate, there may be data remaining in the internal
        /// resampling delay buffer. swr_get_delay() tells the number of
        /// remaining samples. To get this data as output, call this function or
        /// swr_convert() with NULL input.
        /// 
        /// If the SwrContext configuration does not match the output and
        /// input AVFrame settings the conversion does not take place and depending
        /// on
        /// which AVFrame is not matching AVERROR_OUTPUT_CHANGED,
        /// AVERROR_INPUT_CHANGED
        /// or the result of a bitwise-OR of them is returned.
        /// 
        /// @see swr_delay()
        /// @see swr_convert()
        /// @see swr_get_delay()
        /// </summary>
        /// <param name="swr">
        /// audio resample context
        /// </param>
        /// <param name="output">
        /// output AVFrame
        /// </param>
        /// <param name="input">
        /// input AVFrame
        /// </param>
        /// <returns>
        /// 0 on success, AVERROR on failure or nonmatching
        /// configuration.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_convert_frame")]
        public static extern int swr_convert_frame(libswresample.SwrContext* swr, libavutil.AVFrame* output, libavutil.AVFrame* input);

        /// <summary>
        /// Configure or reconfigure the SwrContext using the information
        /// provided by the AVFrames.
        /// 
        /// The original resampling context is reset even on failure.
        /// The function calls swr_close() internally if the context is open.
        /// 
        /// @see swr_close();
        /// </summary>
        /// <param name="swr">
        /// audio resample context
        /// </param>
        /// <param name="output">
        /// output AVFrame
        /// </param>
        /// <param name="input">
        /// input AVFrame
        /// </param>
        /// <returns>
        /// 0 on success, AVERROR on failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(SWRESAMPLE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="swr_config_frame")]
        public static extern int swr_config_frame(libswresample.SwrContext* swr, libavutil.AVFrame* _out, libavutil.AVFrame* _in);
    }
}
