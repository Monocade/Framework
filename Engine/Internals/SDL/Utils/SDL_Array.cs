using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static T*[] SDL_NativeToArray<T>(T** ptr, int size, out int count, bool free = true) where T : unmanaged
        {
            count = 0;

            try
            {
                if (ptr == null || size <= 0)
                {
                    return [];
                }

                var result = new T*[size];

                for (int i = 0; i < size; i++)
                {
                    result[i] = ptr[i];
                }

                count = size;
                return result;
            }
            finally
            {
                if (free && ptr != null)
                {
                    iSDL_free((IntPtr)ptr);
                }
            }
        }
        
        public static T[] SDL_NativeToArray<T>(T* ptr, int size, out int count, bool free = true) where T : unmanaged
        {
            count = 0;

            try
            {
                if (ptr == null || size <= 0)
                {
                    return [];
                }

                count = size;
                return new ReadOnlySpan<T>(ptr, size).ToArray();
            }
            finally
            {
                if (free && ptr != null)
                {
                    iSDL_free((IntPtr)ptr);
                }
            }
        }
        
        public static string[] SDL_NativeToStringArray(byte** ptr, int size, out int count, bool free = true)
        {
            count = 0;

            try
            {
                if (ptr == null || size <= 0)
                {
                    return [];
                }

                var result = new string[size];

                for (int i = 0; i < size; i++)
                {
                    result[i] = SDL_NativeToString(ptr[i]);
                }

                count = size;
                return result;
            }
            finally
            {
                if (free && ptr != null)
                {
                    iSDL_free((IntPtr)ptr);
                }
            }
        }
    }
}