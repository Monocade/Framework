using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static uint SDL_GetGlobalProperties()
        {
            return iSDL_GetGlobalProperties();
        }

        public static uint SDL_CreateProperties()
        {
            return iSDL_CreateProperties();
        }

        public static bool SDL_CopyProperties(uint src, uint dst)
        {
            return iSDL_CopyProperties(src, dst);
        }

        public static bool SDL_LockProperties(uint props)
        {
            return iSDL_LockProperties(props);
        }

        public static void SDL_UnlockProperties(uint props)
        {
            iSDL_UnlockProperties(props);
        }

        public static bool SDL_SetPointerPropertyWithCleanup(uint props, string name, IntPtr value, SDL_CleanupPropertyCallback cleanup, IntPtr userdata)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_SetPointerPropertyWithCleanup(props, ptr1, value, Marshal.GetFunctionPointerForDelegate(cleanup), userdata);
            }
        }

        public static bool SDL_SetPointerProperty(uint props, string name, IntPtr value)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_SetPointerProperty(props, ptr1, value);
            }
        }

        public static bool SDL_SetStringProperty(uint props, string name, string value)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            fixed (byte* ptr2 = SDL_StringToNative(value))
            {
                return iSDL_SetStringProperty(props, ptr1, ptr2);
            }
        }

        public static bool SDL_SetNumberProperty(uint props, string name, long value)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_SetNumberProperty(props, ptr1, value);
            }
        }

        public static bool SDL_SetFloatProperty(uint props, string name, float value)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_SetFloatProperty(props, ptr1, value);
            }
        }

        public static bool SDL_SetBooleanProperty(uint props, string name, bool value)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_SetBooleanProperty(props, ptr1, value);
            }
        }

        public static bool SDL_HasProperty(uint props, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_HasProperty(props, ptr1);
            }
        }

        public static SDL_PropertyType SDL_GetPropertyType(uint props, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GetPropertyType(props, ptr1);
            }
        }

        public static IntPtr SDL_GetPointerProperty(uint props, string name, IntPtr defaultValue)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GetPointerProperty(props, ptr1, defaultValue);
            }
        }

        public static string SDL_GetStringProperty(uint props, string name, string defaultValue)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            fixed (byte* ptr2 = SDL_StringToNative(defaultValue))
            {
                return SDL_NativeToString(iSDL_GetStringProperty(props, ptr1, ptr2));
            }
        }

        public static long SDL_GetNumberProperty(uint props, string name, long defaultValue)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GetNumberProperty(props, ptr1, defaultValue);
            }
        }

        public static float SDL_GetFloatProperty(uint props, string name, float defaultValue)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GetFloatProperty(props, ptr1, defaultValue);
            }
        }

        public static bool SDL_GetBooleanProperty(uint props, string name, bool defaultValue)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GetBooleanProperty(props, ptr1, defaultValue);
            }
        }

        public static bool SDL_ClearProperty(uint props, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_ClearProperty(props, ptr1);
            }
        }

        public static int SDL_GetNumProperties(uint props)
        {
            return iSDL_GetNumProperties(props);
        }

        public static bool SDL_EnumerateProperties(uint props, SDL_EnumeratePropertiesCallback callback, IntPtr userdata)
        {
            return iSDL_EnumerateProperties(props, Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static void SDL_DestroyProperties(uint props)
        {
            iSDL_DestroyProperties(props);
        }
    }
}