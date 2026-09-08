using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static T*[] SDL_NativeToArray<T>(T** ptr, out int count, bool free = true) where T : unmanaged
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

                var result = new T*[count];

                for (int i = 0; i < count; i++)
                {
                    result[i] = ptr[i];
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
        
        public static T[] SDL_NativeToArray<T>(T* ptr, out int count, bool free = true) where T : unmanaged
        {
            count = 0;

            if (ptr == null)
            {
                return [];
            }

            try
            {
                while (!EqualityComparer<T>.Default.Equals(ptr[count], default(T)))
                {
                    count++;
                }

                return new ReadOnlySpan<T>(ptr, count).ToArray();
            }
            finally
            {
                if (free)
                {
                    iSDL_free((IntPtr)ptr);
                }
            }
        }
    }
}