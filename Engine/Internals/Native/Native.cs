using System.Runtime.InteropServices;
using System.Text;
using System;

namespace Engine
{
    // String
    internal static unsafe partial class Native
    {
        public static byte* StringToNative(string value, NativeProvider provider)
        {
            value ??= string.Empty;
            int byteCount = Encoding.UTF8.GetByteCount(value);
            byte* ptr = provider.Allocate((nuint)(byteCount + 1));

            if (ptr == null)
            {
                throw new OutOfMemoryException();
            }

            Encoding.UTF8.GetBytes(value, new Span<byte>(ptr, byteCount));
            ptr[byteCount] = 0;
            return ptr;
        }

        public static string NativeToString(byte* ptr, NativeProvider provider = null)
        {
            try
            {
                if (ptr == null)
                {
                    return string.Empty;
                }
                
                return Marshal.PtrToStringUTF8((IntPtr)ptr) ?? string.Empty;
            }
            finally
            {
                if (ptr != null && provider != null)
                {
                    provider?.Free(ptr);
                }
            }
        }
    }
}