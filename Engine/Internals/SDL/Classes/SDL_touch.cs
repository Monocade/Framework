using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static ulong[] SDL_GetTouchDevices(out int count)
        {
            int size = 0;
            {
                var touchDevicesPtr = iSDL_GetTouchDevices(&size);
                {
                    var result = Native.NativeToArray(touchDevicesPtr, size, out count);
                    {
                        Native.Free((IntPtr)touchDevicesPtr, SDL_NativeProvider);
                        return result;
                    }
                }
            }
        }

        public static string SDL_GetTouchDeviceName(ulong touchID)
        {
            return Native.NativeToString((IntPtr)iSDL_GetTouchDeviceName(touchID));
        }

        public static SDL_TouchDeviceType SDL_GetTouchDeviceType(ulong touchID)
        {
            return iSDL_GetTouchDeviceType(touchID);
        }

        public static SDL_Finger*[] SDL_GetTouchFingers(ulong touchID, out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetTouchFingers(touchID, &size), size, out count);
            }
        }
    }
}