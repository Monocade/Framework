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
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_SetPointerPropertyWithCleanup(props, (byte*)namePtr, value, Marshal.GetFunctionPointerForDelegate(cleanup), userdata);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetPointerProperty(uint props, string name, IntPtr value)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_SetPointerProperty(props, (byte*)namePtr, value);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetStringProperty(uint props, string name, string value)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            var valuePtr = Native.StringToNative(value, SDL_NativeProvider);
            {
                var result = iSDL_SetStringProperty(props, (byte*)namePtr, (byte*)valuePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    Native.Free(valuePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetNumberProperty(uint props, string name, long value)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_SetNumberProperty(props, (byte*)namePtr, value);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetFloatProperty(uint props, string name, float value)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_SetFloatProperty(props, (byte*)namePtr, value);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_SetBooleanProperty(uint props, string name, bool value)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_SetBooleanProperty(props, (byte*)namePtr, value);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_HasProperty(uint props, string name)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_HasProperty(props, (byte*)namePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static SDL_PropertyType SDL_GetPropertyType(uint props, string name)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_GetPropertyType(props, (byte*)namePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static IntPtr SDL_GetPointerProperty(uint props, string name, IntPtr defaultValue)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_GetPointerProperty(props, (byte*)namePtr, defaultValue);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static string SDL_GetStringProperty(uint props, string name, string defaultValue)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            var defaultValuePtr = Native.StringToNative(defaultValue, SDL_NativeProvider);
            {
                var result = Native.NativeToString((IntPtr)iSDL_GetStringProperty(props, (byte*)namePtr, (byte*)defaultValuePtr));
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    Native.Free(defaultValuePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static long SDL_GetNumberProperty(uint props, string name, long defaultValue)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_GetNumberProperty(props, (byte*)namePtr, defaultValue);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static float SDL_GetFloatProperty(uint props, string name, float defaultValue)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_GetFloatProperty(props, (byte*)namePtr, defaultValue);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_GetBooleanProperty(uint props, string name, bool defaultValue)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_GetBooleanProperty(props, (byte*)namePtr, defaultValue);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_ClearProperty(uint props, string name)
        {
            var namePtr = Native.StringToNative(name, SDL_NativeProvider);
            {
                var result = iSDL_ClearProperty(props, (byte*)namePtr);
                {
                    Native.Free(namePtr, SDL_NativeProvider);
                    return result;
                }
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