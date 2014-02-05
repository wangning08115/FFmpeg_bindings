//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libavutil
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AVFifoBuffer
    {
        [FieldOffset(0)]
        public byte* buffer;

        [FieldOffset(4)]
        public byte* rptr;

        [FieldOffset(8)]
        public byte* wptr;

        [FieldOffset(12)]
        public byte* end;

        [FieldOffset(16)]
        public uint rndx;

        [FieldOffset(20)]
        public uint wndx;
    }

    public unsafe partial class libavutil
    {
        /// <summary>
        /// Initialize an AVFifoBuffer.
        /// @param size of FIFO
        /// @return AVFifoBuffer or NULL in case of memory allocation failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_alloc")]
        internal static extern AVFifoBuffer* av_fifo_alloc(uint size);

        /// <summary>
        /// Free an AVFifoBuffer.
        /// @param f AVFifoBuffer to free
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_free")]
        internal static extern void av_fifo_free(AVFifoBuffer* f);

        /// <summary>
        /// Reset the AVFifoBuffer to the state right after av_fifo_alloc, in
        /// particular it is emptied.
        /// @param f AVFifoBuffer to reset
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_reset")]
        internal static extern void av_fifo_reset(AVFifoBuffer* f);

        /// <summary>
        /// Return the amount of data in bytes in the AVFifoBuffer, that is the
        /// amount of data you can read from it.
        /// @param f AVFifoBuffer to read from
        /// @return size
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_size")]
        internal static extern int av_fifo_size(AVFifoBuffer* f);

        /// <summary>
        /// Return the amount of space in bytes in the AVFifoBuffer, that is the
        /// amount of data you can write into it.
        /// @param f AVFifoBuffer to write into
        /// @return size
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_space")]
        internal static extern int av_fifo_space(AVFifoBuffer* f);

        /// <summary>
        /// Feed data from an AVFifoBuffer to a user-supplied callback.
        /// @param f AVFifoBuffer to read from
        /// @param buf_size number of bytes to read
        /// @param func generic read function
        /// @param dest data destination
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_generic_read")]
        internal static extern int av_fifo_generic_read(AVFifoBuffer* f, global::System.IntPtr dest, int buf_size, global::System.IntPtr func);

        /// <summary>
        /// Feed data from a user-supplied callback to an AVFifoBuffer.
        /// @param f AVFifoBuffer to write to
        /// @param src data source; non-const since it may be used as a
        /// modifiable context by the function defined in func
        /// @param size number of bytes to write
        /// @param func generic write function; the first parameter is src,
        /// the second is dest_buf, the third is dest_buf_size.
        /// func must return the number of bytes written to dest_buf, or <= 0 to
        /// indicate no more data available to write.
        /// If func is NULL, src is interpreted as a simple byte array for source
        /// data.
        /// @return the number of bytes written to the FIFO
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_generic_write")]
        internal static extern int av_fifo_generic_write(AVFifoBuffer* f, global::System.IntPtr src, int size, global::System.IntPtr func);

        /// <summary>
        /// Resize an AVFifoBuffer.
        /// In case of reallocation failure, the old FIFO is kept unchanged.
        /// 
        /// @param f AVFifoBuffer to resize
        /// @param size new AVFifoBuffer size in bytes
        /// @return <0 for failure, >=0 otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_realloc2")]
        internal static extern int av_fifo_realloc2(AVFifoBuffer* f, uint size);

        /// <summary>
        /// Enlarge an AVFifoBuffer.
        /// In case of reallocation failure, the old FIFO is kept unchanged.
        /// The new fifo size may be larger than the requested size.
        /// 
        /// @param f AVFifoBuffer to resize
        /// @param additional_space the amount of space in bytes to allocate in
        /// addition to av_fifo_size()
        /// @return <0 for failure, >=0 otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_grow")]
        internal static extern int av_fifo_grow(AVFifoBuffer* f, uint additional_space);

        /// <summary>
        /// Read and discard the specified amount of data from an AVFifoBuffer.
        /// @param f AVFifoBuffer to read from
        /// @param size amount of data to read in bytes
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_drain")]
        internal static extern void av_fifo_drain(AVFifoBuffer* f, int size);

        /// <summary>
        /// Return a pointer to the data stored in a FIFO buffer at a certain
        /// offset.
        /// The FIFO buffer is not modified.
        /// 
        /// @param f    AVFifoBuffer to peek at, f must be non-NULL
        /// @param offs an offset in bytes, its absolute value must be less
        /// than the used buffer size or the returned pointer will
        /// point outside to the buffer data.
        /// The used buffer size can be checked with av_fifo_size().
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_peek2")]
        internal static extern byte* av_fifo_peek2(AVFifoBuffer* f, int offs);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_fifo_peek")]
        internal static extern byte av_fifo_peek(AVFifoBuffer* f, int offs);
    }
}
