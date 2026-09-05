using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Engine.SDL3
{
    internal partial struct SDL_GUID
    {
        public _data_e__FixedBuffer data;

        [InlineArray(16)]
        public partial struct _data_e__FixedBuffer
        {
            public byte e0;
        }
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GUIDToString", ExactSpelling = true)]
        private static extern void iSDL_GUIDToString(SDL_GUID guid, byte* pszGUID, int cbGUID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StringToGUID", ExactSpelling = true)]
        private static extern SDL_GUID iSDL_StringToGUID(byte* pchGUID);
    }
}
