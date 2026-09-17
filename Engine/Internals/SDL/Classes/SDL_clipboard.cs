using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_SetClipboardText(string text)
        {
            var textPtr = Native.StringToNative(text, SDL_NativeProvider);
            {
                var result = iSDL_SetClipboardText((byte*)textPtr);
                {
                    Native.Free(textPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static string SDL_GetClipboardText()
        {
            var clipboardTextPtr = (IntPtr)iSDL_GetClipboardText();
            {
                var result = Native.NativeToString(clipboardTextPtr);
                {
                    Native.Free(clipboardTextPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_HasClipboardText()
        {
            return iSDL_HasClipboardText();
        }

        public static bool SDL_SetPrimarySelectionText(string text)
        {
            var textPtr = Native.StringToNative(text, SDL_NativeProvider);
            {
                var result = iSDL_SetPrimarySelectionText((byte*)textPtr);
                {
                    Native.Free(textPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static string SDL_GetPrimarySelectionText()
        {
            var primarySelectionTextPtr = (IntPtr)iSDL_GetPrimarySelectionText();
            {
                var result = Native.NativeToString(primarySelectionTextPtr);
                {
                    Native.Free(primarySelectionTextPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_HasPrimarySelectionText()
        {
            return iSDL_HasPrimarySelectionText();
        }

        public static bool SDL_SetClipboardData(SDL_ClipboardDataCallback callback, SDL_ClipboardCleanupCallback cleanup, IntPtr userdata, IntPtr mimeTypes, UIntPtr numMimeTypes)
        {
            return iSDL_SetClipboardData(Marshal.GetFunctionPointerForDelegate(callback), Marshal.GetFunctionPointerForDelegate(cleanup), userdata, (byte**)mimeTypes, numMimeTypes);
        }

        public static bool SDL_ClearClipboardData()
        {
            return iSDL_ClearClipboardData();
        }

        public static IntPtr SDL_GetClipboardData(string mimeType, out UIntPtr size)
        {
            var mimeTypePtr = Native.StringToNative(mimeType, SDL_NativeProvider);
            
            fixed (UIntPtr* ptr2 = &size)
            {
                var result = iSDL_GetClipboardData((byte*)mimeTypePtr, ptr2);
                {
                    Native.Free(mimeTypePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_HasClipboardData(string mimeType)
        {
            var mimeTypePtr = Native.StringToNative(mimeType, SDL_NativeProvider);
            {
                var result = iSDL_HasClipboardData((byte*)mimeTypePtr);
                {
                    Native.Free(mimeTypePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static string[] SDL_GetClipboardMimeTypes(out UIntPtr numMimeTypes)
        {
            fixed (UIntPtr* ptr = &numMimeTypes)
            {
                var count = checked((int)(*ptr));
                {
                    return SDL_NativeToArray(iSDL_GetClipboardMimeTypes(ptr), count, out _);
                }
            }
        }
    }
}