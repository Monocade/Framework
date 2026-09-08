using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_ShowOpenFileDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter[] filters, int nfilters, string default_location, bool allow_many)
        {
            fixed (SDL_DialogFileFilter* ptr1 = filters)
            fixed (byte* ptr2 = SDL_StringToNative(default_location))
            {
                iSDL_ShowOpenFileDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, nfilters, ptr2, allow_many);
            }
        }

        public static void SDL_ShowSaveFileDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter[] filters, int nfilters, string default_location)
        {
            fixed (SDL_DialogFileFilter* ptr1 = filters)
            fixed (byte* ptr2 = SDL_StringToNative(default_location))
            {
                iSDL_ShowSaveFileDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, nfilters, ptr2);
            }
        }

        public static void SDL_ShowOpenFolderDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, string default_location, bool allow_many)
        {
            fixed (byte* ptr1 = SDL_StringToNative(default_location))
            {
                iSDL_ShowOpenFolderDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, allow_many);
            }
        }

        public static void SDL_ShowFileDialogWithProperties(SDL_FileDialogType type, SDL_DialogFileCallback callback, IntPtr userdata, uint props)
        {
            iSDL_ShowFileDialogWithProperties(type, Marshal.GetFunctionPointerForDelegate(callback), userdata, props);
        }
    }
}