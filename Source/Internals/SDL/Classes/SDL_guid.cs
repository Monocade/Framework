using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_GUIDToString(SDL_GUID guid, string pszGUID, int cbGUID)
        {
            var pszGUIDPtr = Native.StringToNative(pszGUID, SDL_NativeProvider);
            {
                iSDL_GUIDToString(guid, (byte*)pszGUIDPtr, cbGUID);
                {
                    Native.Free(pszGUIDPtr, SDL_NativeProvider);
                }
            }
        }

        public static SDL_GUID SDL_StringToGUID(string pchGUID)
        {
            var pchGUIDPtr = Native.StringToNative(pchGUID, SDL_NativeProvider);
            {
                var result = iSDL_StringToGUID((byte*)pchGUIDPtr);
                {
                    Native.Free(pchGUIDPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }
    }
}