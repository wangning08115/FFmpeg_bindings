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
        public const sbyte AV_DICT_MATCH_CASE = 1;

        public const sbyte AV_DICT_IGNORE_SUFFIX = 2;

        public const sbyte AV_DICT_DONT_STRDUP_KEY = 4;

        public const sbyte AV_DICT_DONT_STRDUP_VAL = 8;

        public const sbyte AV_DICT_DONT_OVERWRITE = 16;

        public const sbyte AV_DICT_APPEND = 32;

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVDictionaryEntry
        {
            public sbyte* key;

            public sbyte* value;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVDictionary
        {
        }

        /// <summary>
        /// Get a dictionary entry with matching key.
        /// 
        /// @param prev Set to the previous matching element to find the next.
        /// If set to NULL the first matching element is returned.
        /// @param flags Allows case as well as suffix-insensitive comparisons.
        /// @return Found entry or NULL, changing key or value leads to undefined
        /// behavior.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_get")]
        public static extern libavutil.AVDictionaryEntry* av_dict_get(libavutil.AVDictionary* m, string key, libavutil.AVDictionaryEntry* prev, int flags);

        /// <summary>
        /// Get number of entries in dictionary.
        /// 
        /// @param m dictionary
        /// @return  number of entries in dictionary
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_count")]
        public static extern int av_dict_count(libavutil.AVDictionary* m);

        /// <summary>
        /// Set the given entry in *pm, overwriting an existing entry.
        /// 
        /// @param pm pointer to a pointer to a dictionary struct. If *pm is NULL
        /// a dictionary struct is allocated and put in *pm.
        /// @param key entry key to add to *pm (will be av_strduped depending on
        /// flags)
        /// @param value entry value to add to *pm (will be av_strduped depending
        /// on flags).
        /// Passing a NULL value will cause an existing entry to be deleted.
        /// @return >= 0 on success otherwise an error code <0
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_set")]
        public static extern int av_dict_set(libavutil.AVDictionary** pm, string key, string value, int flags);

        /// <summary>
        /// Set the given entry in *pm, overwriting an existing entry.
        /// 
        /// @param pm pointer to a pointer to a dictionary struct. If *pm is NULL
        /// a dictionary struct is allocated and put in *pm.
        /// @param key entry key to add to *pm (will be av_strduped depending on
        /// flags)
        /// @param value entry value to add to *pm (will be av_strduped depending
        /// on flags).
        /// Passing a NULL value will cause an existing entry to be deleted.
        /// @return >= 0 on success otherwise an error code <0
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_set")]
        public static extern int av_dict_set(ref libavutil.AVDictionary* pm, string key, string value, int flags);

        /// <summary>
        /// Copy entries from one AVDictionary struct into another.
        /// @param dst pointer to a pointer to a AVDictionary struct. If *dst is
        /// NULL,
        /// this function will allocate a struct for you and put it in *dst
        /// @param src pointer to source AVDictionary struct
        /// @param flags flags to use when setting entries in *dst
        /// @note metadata is read using the AV_DICT_IGNORE_SUFFIX flag
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_copy")]
        public static extern void av_dict_copy(libavutil.AVDictionary** dst, libavutil.AVDictionary* src, int flags);

        /// <summary>
        /// Copy entries from one AVDictionary struct into another.
        /// @param dst pointer to a pointer to a AVDictionary struct. If *dst is
        /// NULL,
        /// this function will allocate a struct for you and put it in *dst
        /// @param src pointer to source AVDictionary struct
        /// @param flags flags to use when setting entries in *dst
        /// @note metadata is read using the AV_DICT_IGNORE_SUFFIX flag
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_copy")]
        public static extern void av_dict_copy(ref libavutil.AVDictionary* dst, libavutil.AVDictionary* src, int flags);

        /// <summary>
        /// Free all the memory allocated for an AVDictionary struct
        /// and all keys and values.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_free")]
        public static extern void av_dict_free(libavutil.AVDictionary** m);

        /// <summary>
        /// Free all the memory allocated for an AVDictionary struct
        /// and all keys and values.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dict_free")]
        public static extern void av_dict_free(ref libavutil.AVDictionary* m);
    }
}
