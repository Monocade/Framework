using System.Runtime.InteropServices;
using System.Text;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static string[] SDL_NativeToStringArray(byte** ptr, out int count, bool free = true)
        {
            count = 0;

            if (ptr == null)
            {
                return [];
            }

            try
            {
                while (ptr[count] != null)
                {
                    count++;
                }

                var result = new string[count];

                for (int i = 0; i < count; i++)
                {
                    result[i] = SDL_NativeToString(ptr[i]);
                }

                return result;
            }
            finally
            {
                if (free)
                {
                    iSDL_free((IntPtr)ptr);
                }
            }
        }
        
        public static string SDL_NativeToString(byte* ptr, bool free = false)
        {
            if (ptr == null)
            {
                return string.Empty;
            }

            try
            {
                return Marshal.PtrToStringUTF8((IntPtr)ptr) ?? string.Empty;
            }
            finally
            {
                if (free)
                {
                    iSDL_free((IntPtr)ptr);
                }
            }
        }

        public static byte[] SDL_StringToNative(string value)
        {
            return Encoding.UTF8.GetBytes((value ?? string.Empty) + '\0');
        }
    }
}