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
        /// <summary>
        /// Return non-zero if pfx is a prefix of str. If it is, *ptr is set to
        /// the address of the first character in str after the prefix.
        /// 
        /// @param str input string
        /// @param pfx prefix to test
        /// @param ptr updated if the prefix is matched inside str
        /// @return non-zero if the prefix matches, zero otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strstart")]
        public static extern int av_strstart(string str, string pfx, sbyte** ptr);

        /// <summary>
        /// Return non-zero if pfx is a prefix of str. If it is, *ptr is set to
        /// the address of the first character in str after the prefix.
        /// 
        /// @param str input string
        /// @param pfx prefix to test
        /// @param ptr updated if the prefix is matched inside str
        /// @return non-zero if the prefix matches, zero otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strstart")]
        public static extern int av_strstart(string str, string pfx, ref string ptr);

        /// <summary>
        /// Return non-zero if pfx is a prefix of str independent of case. If
        /// it is, *ptr is set to the address of the first character in str
        /// after the prefix.
        /// 
        /// @param str input string
        /// @param pfx prefix to test
        /// @param ptr updated if the prefix is matched inside str
        /// @return non-zero if the prefix matches, zero otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_stristart")]
        public static extern int av_stristart(string str, string pfx, sbyte** ptr);

        /// <summary>
        /// Return non-zero if pfx is a prefix of str independent of case. If
        /// it is, *ptr is set to the address of the first character in str
        /// after the prefix.
        /// 
        /// @param str input string
        /// @param pfx prefix to test
        /// @param ptr updated if the prefix is matched inside str
        /// @return non-zero if the prefix matches, zero otherwise
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_stristart")]
        public static extern int av_stristart(string str, string pfx, ref string ptr);

        /// <summary>
        /// Locate the first case-independent occurrence in the string haystack
        /// of the string needle.  A zero-length string needle is considered to
        /// match at the start of haystack.
        /// 
        /// This function is a case-insensitive version of the standard strstr().
        /// 
        /// @param haystack string to search in
        /// @param needle   string to search for
        /// @return         pointer to the located match within haystack
        /// or a null pointer if no match
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_stristr")]
        public static extern sbyte* av_stristr(string haystack, string needle);

        /// <summary>
        /// Copy the string src to dst, but no more than size - 1 bytes, and
        /// null-terminate dst.
        /// 
        /// This function is the same as BSD strlcpy().
        /// 
        /// @param dst destination buffer
        /// @param src source string
        /// @param size size of destination buffer
        /// @return the length of src
        /// 
        /// @warning since the return value is the length of src, src absolutely
        /// _must_ be a properly 0-terminated string, otherwise this will read
        /// beyond
        /// the end of the buffer and possibly crash.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strlcpy")]
        public static extern global::System.UIntPtr av_strlcpy(System.Text.StringBuilder dst, string src, global::System.UIntPtr size);

        /// <summary>
        /// Append the string src to the string dst, but to a total length of
        /// no more than size - 1 bytes, and null-terminate dst.
        /// 
        /// This function is similar to BSD strlcat(), but differs when
        /// size <= strlen(dst).
        /// 
        /// @param dst destination buffer
        /// @param src source string
        /// @param size size of destination buffer
        /// @return the total length of src and dst
        /// 
        /// @warning since the return value use the length of src and dst, these
        /// absolutely _must_ be a properly 0-terminated strings, otherwise this
        /// will read beyond the end of the buffer and possibly crash.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strlcat")]
        public static extern global::System.UIntPtr av_strlcat(System.Text.StringBuilder dst, string src, global::System.UIntPtr size);

        /// <summary>
        /// Append output to a string, according to a format. Never write out of
        /// the destination buffer, and always put a terminating 0 within
        /// the buffer.
        /// @param dst destination buffer (string to which the output is
        /// appended)
        /// @param size total size of the destination buffer
        /// @param fmt printf-compatible format string, specifying how the
        /// following parameters are used
        /// @return the length of the string that would have been generated
        /// if enough space had been available
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strlcatf")]
        public static extern global::System.UIntPtr av_strlcatf(System.Text.StringBuilder dst, global::System.UIntPtr size, string fmt);

        /// <summary>
        /// Print arguments following specified format into a large enough auto
        /// allocated buffer. It is similar to GNU asprintf().
        /// @param fmt printf-compatible format string, specifying how the
        /// following parameters are used.
        /// @return the allocated string
        /// @note You have to free the string yourself with av_free().
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_asprintf")]
        public static extern sbyte* av_asprintf(string fmt);

        /// <summary>
        /// Convert a number to a av_malloced string.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_d2str")]
        public static extern sbyte* av_d2str(double d);

        /// <summary>
        /// Unescape the given string until a non escaped terminating char,
        /// and return the token corresponding to the unescaped string.
        /// 
        /// The normal \ and ' escaping is supported. Leading and trailing
        /// whitespaces are removed, unless they are escaped with '\' or are
        /// enclosed between ''.
        /// 
        /// @param buf the buffer to parse, buf will be updated to point to the
        /// terminating char
        /// @param term a 0-terminated list of terminating chars
        /// @return the malloced unescaped string, which must be av_freed by
        /// the user, NULL in case of allocation failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_token")]
        public static extern sbyte* av_get_token(sbyte** buf, string term);

        /// <summary>
        /// Unescape the given string until a non escaped terminating char,
        /// and return the token corresponding to the unescaped string.
        /// 
        /// The normal \ and ' escaping is supported. Leading and trailing
        /// whitespaces are removed, unless they are escaped with '\' or are
        /// enclosed between ''.
        /// 
        /// @param buf the buffer to parse, buf will be updated to point to the
        /// terminating char
        /// @param term a 0-terminated list of terminating chars
        /// @return the malloced unescaped string, which must be av_freed by
        /// the user, NULL in case of allocation failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_token")]
        public static extern sbyte* av_get_token(ref string buf, string term);

        /// <summary>
        /// Split the string into several tokens which can be accessed by
        /// successive calls to av_strtok().
        /// 
        /// A token is defined as a sequence of characters not belonging to the
        /// set specified in delim.
        /// 
        /// On the first call to av_strtok(), s should point to the string to
        /// parse, and the value of saveptr is ignored. In subsequent calls, s
        /// should be NULL, and saveptr should be unchanged since the previous
        /// call.
        /// 
        /// This function is similar to strtok_r() defined in POSIX.1.
        /// 
        /// @param s the string to parse, may be NULL
        /// @param delim 0-terminated list of token delimiters, must be non-NULL
        /// @param saveptr user-provided pointer which points to stored
        /// information necessary for av_strtok() to continue scanning the same
        /// string. saveptr is updated to point to the next character after the
        /// first delimiter found, or to NULL if the string was terminated
        /// @return the found token, or NULL when no token is found
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strtok")]
        public static extern sbyte* av_strtok(System.Text.StringBuilder s, string delim, sbyte** saveptr);

        /// <summary>
        /// Split the string into several tokens which can be accessed by
        /// successive calls to av_strtok().
        /// 
        /// A token is defined as a sequence of characters not belonging to the
        /// set specified in delim.
        /// 
        /// On the first call to av_strtok(), s should point to the string to
        /// parse, and the value of saveptr is ignored. In subsequent calls, s
        /// should be NULL, and saveptr should be unchanged since the previous
        /// call.
        /// 
        /// This function is similar to strtok_r() defined in POSIX.1.
        /// 
        /// @param s the string to parse, may be NULL
        /// @param delim 0-terminated list of token delimiters, must be non-NULL
        /// @param saveptr user-provided pointer which points to stored
        /// information necessary for av_strtok() to continue scanning the same
        /// string. saveptr is updated to point to the next character after the
        /// first delimiter found, or to NULL if the string was terminated
        /// @return the found token, or NULL when no token is found
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strtok")]
        public static extern sbyte* av_strtok(System.Text.StringBuilder s, string delim, ref System.Text.StringBuilder saveptr);

        /// <summary>
        /// Locale-independent conversion of ASCII characters to uppercase.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_toupper")]
        public static extern int av_toupper(int c);

        /// <summary>
        /// Locale-independent conversion of ASCII characters to lowercase.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_tolower")]
        public static extern int av_tolower(int c);

        /// <summary>
        /// Locale-independent case-insensitive compare.
        /// @note This means only ASCII-range characters are case-insensitive
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strcasecmp")]
        public static extern int av_strcasecmp(string a, string b);

        /// <summary>
        /// Locale-independent case-insensitive compare.
        /// @note This means only ASCII-range characters are case-insensitive
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strncasecmp")]
        public static extern int av_strncasecmp(string a, string b, global::System.UIntPtr n);
    }
}