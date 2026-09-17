using System.Runtime.InteropServices;
using System.Text;
using System;

namespace Engine
{
    // String
    internal static unsafe partial class Native
    {
        internal static string NativeToString(IntPtr ptr, NativeProvider provider = null, bool free = false)
        {
            try
            {
                if (ptr == IntPtr.Zero)
                {
                    return string.Empty;
                }

                return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
            }
            finally
            {
                if (ptr != IntPtr.Zero && provider != null && free)
                {
                    Free(ptr, provider);
                }
            }
        }

        internal static IntPtr StringToNative(string value, NativeProvider provider)
        {
            value ??= string.Empty;
            int byteCount = Encoding.UTF8.GetByteCount(value);
            byte* ptr = (byte*)provider.Allocate((nuint)(byteCount + 1));

            if (ptr == null)
            {
                throw new OutOfMemoryException();
            }
                
            Encoding.UTF8.GetBytes(value, new Span<byte>(ptr, byteCount));
            ptr[byteCount] = 0;
            return (IntPtr)ptr;
        }
    }
    
    // Free
    internal static unsafe partial class Native
    {
        public static void Free(IntPtr ptr, NativeProvider provider)
        {
            if (provider != null)
            {
                provider?.Free(ptr);
            }
        }
    }
}