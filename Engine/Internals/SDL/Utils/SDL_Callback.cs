using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static IntPtr SDL_CreateCallback<T>(T value) where T : class
        {
            return GCHandle.ToIntPtr(GCHandle.Alloc(value));
        }

        public static T SDL_FreeCallback<T>(IntPtr handle) where T : class
        {
            var gcHandle = GCHandle.FromIntPtr(handle);

            try
            {
                return gcHandle.Target as T;
            }
            finally
            {
                gcHandle.Free();
            }
        }
    }
}