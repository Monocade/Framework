using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_SetClipboardText(string text)
        {
            fixed (byte* ptr1 = SDL_StringToNative(text))
            {
                return iSDL_SetClipboardText(ptr1);
            }
        }

        public static string SDL_GetClipboardText()
        {
            return SDL_NativeToString(iSDL_GetClipboardText(), free: true);
        }

        public static bool SDL_HasClipboardText()
        {
            return iSDL_HasClipboardText();
        }

        public static bool SDL_SetPrimarySelectionText(string text)
        {
            fixed (byte* ptr1 = SDL_StringToNative(text))
            {
                return iSDL_SetPrimarySelectionText(ptr1);
            }
        }

        public static string SDL_GetPrimarySelectionText()
        {
            return SDL_NativeToString(iSDL_GetPrimarySelectionText(), free: true);
        }

        public static bool SDL_HasPrimarySelectionText()
        {
            return iSDL_HasPrimarySelectionText();
        }

        public static bool SDL_SetClipboardData(SDL_ClipboardDataCallback callback, SDL_ClipboardCleanupCallback cleanup, IntPtr userdata, IntPtr mime_types, UIntPtr num_mime_types)
        {
            return iSDL_SetClipboardData(Marshal.GetFunctionPointerForDelegate(callback), Marshal.GetFunctionPointerForDelegate(cleanup), userdata, (byte**)mime_types, num_mime_types);
        }

        public static bool SDL_ClearClipboardData()
        {
            return iSDL_ClearClipboardData();
        }

        public static IntPtr SDL_GetClipboardData(string mime_type, out UIntPtr size)
        {
            fixed (byte* ptr1 = SDL_StringToNative(mime_type))
            fixed (nuint* ptr2 = &size)
            {
                return iSDL_GetClipboardData(ptr1, ptr2);
            }
        }

        public static bool SDL_HasClipboardData(string mime_type)
        {
            fixed (byte* ptr1 = SDL_StringToNative(mime_type))
            {
                return iSDL_HasClipboardData(ptr1);
            }
        }

        public static string[] SDL_GetClipboardMimeTypes(out nuint num_mime_types)
        {
            fixed (nuint* ptr = &num_mime_types)
            {
                var count = checked((int)(*ptr));
                {
                    return SDL_NativeToStringArray(iSDL_GetClipboardMimeTypes(ptr), count, out _);
                }
            }
        }
    }
}