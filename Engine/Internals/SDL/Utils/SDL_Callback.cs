using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static IntPtr SDL_CreateCallback<T>(T value) where T : class
        {
            var handle = GCHandle.Alloc(value);
            var ptr = GCHandle.ToIntPtr(handle);

            return ptr;
        }

        public static T SDL_FreeCallback<T>(nint handle) where T : class
        {
            var gcHandle = GCHandle.FromIntPtr(handle);

            try
            {
                var value = gcHandle.Target as T;

                return value;
            }
            finally
            {
                gcHandle.Free();
            }
        }
    }
}