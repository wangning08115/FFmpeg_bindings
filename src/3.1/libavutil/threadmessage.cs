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
        public enum AVThreadMessageFlags
        {
            /// <summary>Perform non-blocking operation. If this flag is set, send and recv operations are non-blocking and return AVERROR(EAGAIN) immediately if they can not proceed.</summary>
            AV_THREAD_MESSAGE_NONBLOCK = 1
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVThreadMessageQueue
        {
        }

        /// <summary>
        /// Allocate a new message queue.
        /// </summary>
        /// <param name="mq">
        /// pointer to the message queue
        /// </param>
        /// <param name="nelem">
        /// maximum number of elements in the queue
        /// </param>
        /// <param name="elsize">
        /// size of each element in the queue
        /// </param>
        /// <returns>
        /// &gt;=0 for success; &lt;0 for error, in particular AVERROR(ENOSYS) if
        /// lavu was built without thread support
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_alloc")]
        public static extern int av_thread_message_queue_alloc(libavutil.AVThreadMessageQueue** mq, uint nelem, uint elsize);

        /// <summary>
        /// Allocate a new message queue.
        /// </summary>
        /// <param name="mq">
        /// pointer to the message queue
        /// </param>
        /// <param name="nelem">
        /// maximum number of elements in the queue
        /// </param>
        /// <param name="elsize">
        /// size of each element in the queue
        /// </param>
        /// <returns>
        /// &gt;=0 for success; &lt;0 for error, in particular AVERROR(ENOSYS) if
        /// lavu was built without thread support
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_alloc")]
        public static extern int av_thread_message_queue_alloc(ref libavutil.AVThreadMessageQueue* mq, uint nelem, uint elsize);

        /// <summary>
        /// Free a message queue.
        /// 
        /// The message queue must no longer be in use by another thread.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_free")]
        public static extern void av_thread_message_queue_free(libavutil.AVThreadMessageQueue** mq);

        /// <summary>
        /// Free a message queue.
        /// 
        /// The message queue must no longer be in use by another thread.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_free")]
        public static extern void av_thread_message_queue_free(ref libavutil.AVThreadMessageQueue* mq);

        /// <summary>
        /// Send a message on the queue.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_send")]
        public static extern int av_thread_message_queue_send(libavutil.AVThreadMessageQueue* mq, void* msg, uint flags);

        /// <summary>
        /// Receive a message from the queue.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_recv")]
        public static extern int av_thread_message_queue_recv(libavutil.AVThreadMessageQueue* mq, void* msg, uint flags);

        /// <summary>
        /// Set the sending error code.
        /// 
        /// If the error code is set to non-zero, av_thread_message_queue_send()
        /// will
        /// return it immediately. Conventional values, such as AVERROR_EOF or
        /// AVERROR(EAGAIN), can be used to cause the sending thread to stop or
        /// suspend its operation.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_set_err_send")]
        public static extern void av_thread_message_queue_set_err_send(libavutil.AVThreadMessageQueue* mq, int err);

        /// <summary>
        /// Set the receiving error code.
        /// 
        /// If the error code is set to non-zero, av_thread_message_queue_recv()
        /// will
        /// return it immediately when there are no longer available messages.
        /// Conventional values, such as AVERROR_EOF or AVERROR(EAGAIN), can be
        /// used
        /// to cause the receiving thread to stop or suspend its operation.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_set_err_recv")]
        public static extern void av_thread_message_queue_set_err_recv(libavutil.AVThreadMessageQueue* mq, int err);

        /// <summary>
        /// Set the optional free message callback function which will be called if
        /// an
        /// operation is removing messages from the queue.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_queue_set_free_func")]
        public static extern void av_thread_message_queue_set_free_func(libavutil.AVThreadMessageQueue* mq, global::System.IntPtr free_func);

        /// <summary>
        /// Flush the message queue
        /// 
        /// This function is mostly equivalent to reading and free-ing every
        /// message
        /// except that it will be done in a single operation (no lock/unlock
        /// between
        /// reads).
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_thread_message_flush")]
        public static extern void av_thread_message_flush(libavutil.AVThreadMessageQueue* mq);
    }
}
