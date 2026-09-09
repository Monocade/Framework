using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_OpenURL(byte* url);
    }
}
