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
        public const ulong AV_BUFFER_FLAG_READONLY = (1 << 0);

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVBuffer
        {
        }

        /// <summary>
        /// A reference to a data buffer.
        /// 
        /// The size of this struct is not a part of the public ABI and it is not
        /// meant
        /// to be allocated directly.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVBufferRef
        {
            public libavutil.AVBuffer* buffer;

            /// <summary>
            /// The data buffer. It is considered writable if and only if
            /// this is the only reference to the buffer, in which case
            /// av_buffer_is_writable() returns 1.
            /// </summary>
            public byte* data;

            /// <summary>
            /// Size of data in bytes.
            /// </summary>
            public int size;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVBufferPool
        {
        }

        /// <summary>
        /// Allocate an AVBuffer of the given size using av_malloc().
        /// </summary>
        /// <returns>
        /// an AVBufferRef of given size or NULL when out of memory
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_alloc")]
        public static extern libavutil.AVBufferRef* av_buffer_alloc(int size);

        /// <summary>
        /// Same as av_buffer_alloc(), except the returned buffer will be
        /// initialized
        /// to zero.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_allocz")]
        public static extern libavutil.AVBufferRef* av_buffer_allocz(int size);

        /// <summary>
        /// Create an AVBuffer from an existing array.
        /// 
        /// If this function is successful, data is owned by the AVBuffer. The
        /// caller may
        /// only access data through the returned AVBufferRef and references
        /// derived from
        /// it.
        /// If this function fails, data is left untouched.
        /// </summary>
        /// <param name="data">
        /// data array
        /// </param>
        /// <param name="size">
        /// size of data in bytes
        /// </param>
        /// <param name="free">
        /// a callback for freeing this buffer's data
        /// </param>
        /// <param name="opaque">
        /// parameter to be got for processing or passed to free
        /// </param>
        /// <param name="flags">
        /// a combination of AV_BUFFER_FLAG_
        /// </param>
        /// <returns>
        /// an AVBufferRef referring to data on success, NULL on failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_create")]
        public static extern libavutil.AVBufferRef* av_buffer_create(byte* data, int size, global::System.IntPtr free, void* opaque, int flags);

        /// <summary>
        /// Default free callback, which calls av_free() on the buffer data.
        /// This function is meant to be passed to av_buffer_create(), not called
        /// directly.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_default_free")]
        public static extern void av_buffer_default_free(void* opaque, byte* data);

        /// <summary>
        /// Create a new reference to an AVBuffer.
        /// </summary>
        /// <returns>
        /// a new AVBufferRef referring to the same AVBuffer as buf or NULL on
        /// failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_ref")]
        public static extern libavutil.AVBufferRef* av_buffer_ref(libavutil.AVBufferRef* buf);

        /// <summary>
        /// Free a given reference and automatically free the buffer if there are
        /// no more
        /// references to it.
        /// </summary>
        /// <param name="buf">
        /// the reference to be freed. The pointer is set to NULL on return.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_unref")]
        public static extern void av_buffer_unref(libavutil.AVBufferRef** buf);

        /// <summary>
        /// Free a given reference and automatically free the buffer if there are
        /// no more
        /// references to it.
        /// </summary>
        /// <param name="buf">
        /// the reference to be freed. The pointer is set to NULL on return.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_unref")]
        public static extern void av_buffer_unref(ref libavutil.AVBufferRef* buf);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// 1 if the caller may write to the data referred to by buf (which is
        /// true if and only if buf is the only reference to the underlying
        /// AVBuffer).
        /// Return 0 otherwise.
        /// A positive answer is valid until av_buffer_ref() is called on buf.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_is_writable")]
        public static extern int av_buffer_is_writable(libavutil.AVBufferRef* buf);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// the opaque parameter set by av_buffer_create.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_get_opaque")]
        public static extern void* av_buffer_get_opaque(libavutil.AVBufferRef* buf);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_get_ref_count")]
        public static extern int av_buffer_get_ref_count(libavutil.AVBufferRef* buf);

        /// <summary>
        /// Create a writable reference from a given buffer reference, avoiding
        /// data copy
        /// if possible.
        /// </summary>
        /// <param name="buf">
        /// buffer reference to make writable. On success, buf is either left
        /// untouched, or it is unreferenced and a new writable AVBufferRef is
        /// written in its place. On failure, buf is left untouched.
        /// </param>
        /// <returns>
        /// 0 on success, a negative AVERROR on failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_make_writable")]
        public static extern int av_buffer_make_writable(libavutil.AVBufferRef** buf);

        /// <summary>
        /// Create a writable reference from a given buffer reference, avoiding
        /// data copy
        /// if possible.
        /// </summary>
        /// <param name="buf">
        /// buffer reference to make writable. On success, buf is either left
        /// untouched, or it is unreferenced and a new writable AVBufferRef is
        /// written in its place. On failure, buf is left untouched.
        /// </param>
        /// <returns>
        /// 0 on success, a negative AVERROR on failure.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_make_writable")]
        public static extern int av_buffer_make_writable(ref libavutil.AVBufferRef* buf);

        /// <summary>
        /// Reallocate a given buffer.
        /// </summary>
        /// <param name="buf">
        /// a buffer reference to reallocate. On success, buf will be
        /// unreferenced and a new reference with the required size will be
        /// written in its place. On failure buf will be left untouched. *buf
        /// may be NULL, then a new buffer is allocated.
        /// </param>
        /// <param name="size">
        /// required new buffer size.
        /// </param>
        /// <returns>
        /// 0 on success, a negative AVERROR on failure.
        /// </returns>
        /// <remark>
        /// the buffer is actually reallocated with av_realloc() only if it was
        /// initially allocated through av_buffer_realloc(NULL) and there is only
        /// one
        /// reference to it (i.e. the one passed to this function). In all other
        /// cases
        /// a new buffer is allocated and the data is copied.
        /// </remark>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_realloc")]
        public static extern int av_buffer_realloc(libavutil.AVBufferRef** buf, int size);

        /// <summary>
        /// Reallocate a given buffer.
        /// </summary>
        /// <param name="buf">
        /// a buffer reference to reallocate. On success, buf will be
        /// unreferenced and a new reference with the required size will be
        /// written in its place. On failure buf will be left untouched. *buf
        /// may be NULL, then a new buffer is allocated.
        /// </param>
        /// <param name="size">
        /// required new buffer size.
        /// </param>
        /// <returns>
        /// 0 on success, a negative AVERROR on failure.
        /// </returns>
        /// <remark>
        /// the buffer is actually reallocated with av_realloc() only if it was
        /// initially allocated through av_buffer_realloc(NULL) and there is only
        /// one
        /// reference to it (i.e. the one passed to this function). In all other
        /// cases
        /// a new buffer is allocated and the data is copied.
        /// </remark>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_realloc")]
        public static extern int av_buffer_realloc(ref libavutil.AVBufferRef* buf, int size);

        /// <summary>
        /// Allocate and initialize a buffer pool.
        /// </summary>
        /// <param name="size">
        /// size of each buffer in this pool
        /// </param>
        /// <param name="alloc">
        /// a function that will be used to allocate new buffers when the
        /// pool is empty. May be NULL, then the default allocator will be used
        /// (av_buffer_alloc()).
        /// </param>
        /// <returns>
        /// newly created buffer pool on success, NULL on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_pool_init")]
        public static extern libavutil.AVBufferPool* av_buffer_pool_init(int size, global::System.IntPtr alloc);

        /// <summary>
        /// Allocate and initialize a buffer pool with a more complex allocator.
        /// </summary>
        /// <param name="size">
        /// size of each buffer in this pool
        /// </param>
        /// <param name="opaque">
        /// arbitrary user data used by the allocator
        /// </param>
        /// <param name="alloc">
        /// a function that will be used to allocate new buffers when the
        /// pool is empty.
        /// </param>
        /// <param name="pool_free">
        /// a function that will be called immediately before the pool
        /// is freed. I.e. after av_buffer_pool_can_uninit() is called
        /// by the pool and all the frames are returned to the pool and
        /// freed. It is intended to uninitialize the user opaque data.
        /// </param>
        /// <returns>
        /// newly created buffer pool on success, NULL on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_pool_init2")]
        public static extern libavutil.AVBufferPool* av_buffer_pool_init2(int size, void* opaque, global::System.IntPtr alloc, global::System.IntPtr pool_free);

        /// <summary>
        /// Mark the pool as being available for freeing. It will actually be freed
        /// only
        /// once all the allocated buffers associated with the pool are released.
        /// Thus it
        /// is safe to call this function while some of the allocated buffers are
        /// still
        /// in use.
        /// </summary>
        /// <param name="pool">
        /// pointer to the pool to be freed. It will be set to NULL.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_pool_uninit")]
        public static extern void av_buffer_pool_uninit(libavutil.AVBufferPool** pool);

        /// <summary>
        /// Mark the pool as being available for freeing. It will actually be freed
        /// only
        /// once all the allocated buffers associated with the pool are released.
        /// Thus it
        /// is safe to call this function while some of the allocated buffers are
        /// still
        /// in use.
        /// </summary>
        /// <param name="pool">
        /// pointer to the pool to be freed. It will be set to NULL.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_pool_uninit")]
        public static extern void av_buffer_pool_uninit(ref libavutil.AVBufferPool* pool);

        /// <summary>
        /// Allocate a new AVBuffer, reusing an old buffer from the pool when
        /// available.
        /// This function may be called simultaneously from multiple threads.
        /// </summary>
        /// <returns>
        /// a reference to the new buffer on success, NULL on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffer_pool_get")]
        public static extern libavutil.AVBufferRef* av_buffer_pool_get(libavutil.AVBufferPool* pool);
    }
}
