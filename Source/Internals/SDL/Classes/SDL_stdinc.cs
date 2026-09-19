using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        // Missing due to ClangSharp generator
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcpy", ExactSpelling = true)]
        private static extern IntPtr iSDL_memcpy(IntPtr dst, IntPtr src, UIntPtr len);
        public static IntPtr SDL_memcpy(IntPtr dst, IntPtr src, UIntPtr len)
        {
            return iSDL_memcpy(dst, src, len);
        }
        
        public static IntPtr SDL_malloc(UIntPtr size)
        {
            return iSDL_malloc(size);
        }
        
        public static void SDL_free(IntPtr mem)
        {
            iSDL_free(mem);
        }
    }
}