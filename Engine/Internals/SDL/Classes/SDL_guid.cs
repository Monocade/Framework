using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_GUIDToString(SDL_GUID guid, string pszGUID, int cbGUID)
        {
            fixed (byte* ptr1 = SDL_StringToNative(pszGUID))
            {
                iSDL_GUIDToString(guid, ptr1, cbGUID);
            }
        }

        public static SDL_GUID SDL_StringToGUID(string pchGUID)
        {
            fixed (byte* ptr1 = SDL_StringToNative(pchGUID))
            {
                return iSDL_StringToGUID(ptr1);
            }
        }
    }
}