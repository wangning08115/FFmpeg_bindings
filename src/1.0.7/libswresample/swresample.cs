//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libswresample
{
    public enum SwrDitherType
    {
        SWR_DITHER_NONE = 0,
        SWR_DITHER_RECTANGULAR = 1,
        SWR_DITHER_TRIANGULAR = 2,
        SWR_DITHER_TRIANGULAR_HIGHPASS = 3,
        /// <summary>not part of API/ABI</summary>
        SWR_DITHER_NB = 4
    }

    /// <summary>
    /// </summary>
    public enum SwrFilterType
    {
        /// <summary>Cubic</summary>
        SWR_FILTER_TYPE_CUBIC = 0,
        /// <summary>Blackman Nuttall Windowed Sinc</summary>
        SWR_FILTER_TYPE_BLACKMAN_NUTTALL = 1,
        /// <summary>Kaiser Windowed Sinc</summary>
        SWR_FILTER_TYPE_KAISER = 2
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SwrContext
    {
    }

    public unsafe partial class libswresample
    {
        /// <summary>
        /// Get the AVClass for swrContext. It can be used in combination with
        /// AV_OPT_SEARCH_FAKE_OBJ for examining options.
        /// 
        /// @see av_opt_find().
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_get_class")]
        internal static extern AVClass* swr_get_class();

        /// <summary>
        /// Allocate SwrContext.
        /// 
        /// If you use this function you will need to set the parameters (manually
        /// or
        /// with swr_alloc_set_opts()) before calling swr_init().
        /// 
        /// @see swr_alloc_set_opts(), swr_init(), swr_free()
        /// @return NULL on error, allocated context otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_alloc")]
        internal static extern SwrContext* swr_alloc();

        /// <summary>
        /// Initialize context after user parameters have been set.
        /// 
        /// @return AVERROR error code in case of failure.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_init")]
        internal static extern int swr_init(SwrContext* s);

        /// <summary>
        /// Allocate SwrContext if needed and set/reset common parameters.
        /// 
        /// This function does not require s to be allocated with swr_alloc(). On
        /// the
        /// other hand, swr_alloc() can use swr_alloc_set_opts() to set the
        /// parameters
        /// on the allocated context.
        /// 
        /// @param s               Swr context, can be NULL
        /// @param out_ch_layout   output channel layout (AV_CH_LAYOUT_*)
        /// @param out_sample_fmt  output sample format (AV_SAMPLE_FMT_*).
        /// @param out_sample_rate output sample rate (frequency in Hz)
        /// @param in_ch_layout    input channel layout (AV_CH_LAYOUT_*)
        /// @param in_sample_fmt   input sample format (AV_SAMPLE_FMT_*).
        /// @param in_sample_rate  input sample rate (frequency in Hz)
        /// @param log_offset      logging level offset
        /// @param log_ctx         parent logging context, can be NULL
        /// 
        /// @see swr_init(), swr_free()
        /// @return NULL on error, allocated context otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_alloc_set_opts")]
        internal static extern SwrContext* swr_alloc_set_opts(SwrContext* s, long out_ch_layout, AVSampleFormat out_sample_fmt, int out_sample_rate, long in_ch_layout, AVSampleFormat in_sample_fmt, int in_sample_rate, int log_offset, global::System.IntPtr log_ctx);

        /// <summary>
        /// Free the given SwrContext and set the pointer to NULL.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_free")]
        internal static extern void swr_free(SwrContext* s);

        /// <summary>
        /// Convert audio.
        /// 
        /// in and in_count can be set to 0 to flush the last few samples out at
        /// the
        /// end.
        /// 
        /// If more input is provided than output space then the input will be
        /// buffered.
        /// You can avoid this buffering by providing more output space than input.
        /// Convertion will run directly without copying whenever possible.
        /// 
        /// @param s         allocated Swr context, with parameters set
        /// @param out       output buffers, only the first one need be set in case
        /// of packed audio
        /// @param out_count amount of space available for output in samples per
        /// channel
        /// @param in        input buffers, only the first one need to be set in
        /// case of packed audio
        /// @param in_count  number of input samples available in one channel
        /// 
        /// @return number of samples output per channel, negative value on error
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_convert")]
        internal static extern int swr_convert(SwrContext* s, byte* @out, int out_count, byte* @in, int in_count);

        /// <summary>
        /// Convert the next timestamp from input to output
        /// timestampe are in 1/(in_sample_rate * out_sample_rate) units.
        /// 
        /// @note There are 2 slightly differently behaving modes.
        /// First is when automatic timestamp compensation is not used,
        /// (min_compensation >= FLT_MAX)
        /// in this case timestamps will be passed through with delays compensated
        /// Second is when automatic timestamp compensation is used,
        /// (min_compensation < FLT_MAX)
        /// in this case the output timestamps will match output sample numbers
        /// 
        /// @param pts   timstamp for the next input sample, INT64_MIN if unknown
        /// @returns the output timestamp for the next output sample
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_next_pts")]
        internal static extern long swr_next_pts(SwrContext* s, long pts);

        /// <summary>
        /// Activate resampling compensation.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_set_compensation")]
        internal static extern int swr_set_compensation(SwrContext* s, int sample_delta, int compensation_distance);

        /// <summary>
        /// Set a customized input channel mapping.
        /// 
        /// @param s           allocated Swr context, not yet initialized
        /// @param channel_map customized input channel mapping (array of channel
        /// indexes, -1 for a muted channel)
        /// @return AVERROR error code in case of failure.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_set_channel_mapping")]
        internal static extern int swr_set_channel_mapping(SwrContext* s, int* channel_map);

        /// <summary>
        /// Set a customized remix matrix.
        /// 
        /// @param s       allocated Swr context, not yet initialized
        /// @param matrix  remix coefficients; matrix[i + stride * o] is
        /// the weight of input channel i in output channel o
        /// @param stride  offset between lines of the matrix
        /// @return  AVERROR error code in case of failure.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_set_matrix")]
        internal static extern int swr_set_matrix(SwrContext* s, double* matrix, int stride);

        /// <summary>
        /// Drops the specified number of output samples.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_drop_output")]
        internal static extern int swr_drop_output(SwrContext* s, int count);

        /// <summary>
        /// Injects the specified number of silence samples.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_inject_silence")]
        internal static extern int swr_inject_silence(SwrContext* s, int count);

        /// <summary>
        /// Gets the delay the next input sample will experience relative to the
        /// next output sample.
        /// 
        /// Swresample can buffer data if more input has been provided than
        /// available
        /// output space, also converting between sample rates needs a delay.
        /// This function returns the sum of all such delays.
        /// 
        /// @param s     swr context
        /// @param base  timebase in which the returned delay will be
        /// if its set to 1 the returned delay is in seconds
        /// if its set to 1000 the returned delay is in milli seconds
        /// if its set to the input sample rate then the returned delay is in input
        /// samples
        /// if its set to the output sample rate then the returned delay is in
        /// output samples
        /// an exact rounding free delay can be found by using LCM(in_sample_rate,
        /// out_sample_rate)
        /// @returns     the delay in 1/base units.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swr_get_delay")]
        internal static extern long swr_get_delay(SwrContext* s, long @base);

        /// <summary>
        /// Return the LIBSWRESAMPLE_VERSION_INT constant.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swresample_version")]
        internal static extern uint swresample_version();

        /// <summary>
        /// Return the swr build-time configuration.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swresample_configuration")]
        internal static extern global::System.IntPtr swresample_configuration();

        /// <summary>
        /// Return the swr license.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("swresample-if-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="swresample_license")]
        internal static extern global::System.IntPtr swresample_license();
    }
}
