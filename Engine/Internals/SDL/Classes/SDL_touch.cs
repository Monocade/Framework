using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static ulong[] SDL_GetTouchDevices(out int count)
        {
            return SDL_NativeToArray(iSDL_GetTouchDevices(null), out count);
        }

        public static string SDL_GetTouchDeviceName(ulong touchID)
        {
            return SDL_NativeToString(iSDL_GetTouchDeviceName(touchID));
        }

        public static SDL_TouchDeviceType SDL_GetTouchDeviceType(ulong touchID)
        {
            return iSDL_GetTouchDeviceType(touchID);
        }

        public static SDL_Finger*[] SDL_GetTouchFingers(ulong touchID, out int count)
        {
            return SDL_NativeToArray(iSDL_GetTouchFingers(touchID, null), out count);
        }
    }
}