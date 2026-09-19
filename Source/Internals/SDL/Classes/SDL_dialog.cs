using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_ShowOpenFileDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter[] filters, int numFilters, string defaultLocation, bool allowMany)
        {
            var defaultLocationPtr = Native.StringToNative(defaultLocation, SDL_NativeProvider);
                
            fixed (SDL_DialogFileFilter* ptr1 = filters)
            {
                iSDL_ShowOpenFileDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, numFilters, (byte*)defaultLocationPtr, allowMany);
                {
                    Native.Free(defaultLocationPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_ShowSaveFileDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter[] filters, int numFilters, string defaultLocation)
        {
            var defaultLocationPtr = Native.StringToNative(defaultLocation, SDL_NativeProvider);
                
            fixed (SDL_DialogFileFilter* ptr1 = filters)
            {
                iSDL_ShowSaveFileDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, numFilters, (byte*)defaultLocationPtr);
                {
                    Native.Free(defaultLocationPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_ShowOpenFolderDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, string defaultLocation, bool allowMany)
        {
            var defaultLocationPtr = Native.StringToNative(defaultLocation, SDL_NativeProvider);
            {
                iSDL_ShowOpenFolderDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, (byte*)defaultLocationPtr, allowMany);
                {
                    Native.Free(defaultLocationPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_ShowFileDialogWithProperties(SDL_FileDialogType type, SDL_DialogFileCallback callback, IntPtr userdata, uint props)
        {
            iSDL_ShowFileDialogWithProperties(type, Marshal.GetFunctionPointerForDelegate(callback), userdata, props);
        }
    }
}