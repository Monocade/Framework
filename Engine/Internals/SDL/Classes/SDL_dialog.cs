using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_ShowOpenFileDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter[] filters, int numFilters, string defaultLocation, bool allowMany)
        {
            fixed (SDL_DialogFileFilter* ptr1 = filters)
            fixed (byte* ptr2 = SDL_StringToNative(defaultLocation))
            {
                iSDL_ShowOpenFileDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, numFilters, ptr2, allowMany);
            }
        }

        public static void SDL_ShowSaveFileDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter[] filters, int numFilters, string defaultLocation)
        {
            fixed (SDL_DialogFileFilter* ptr1 = filters)
            fixed (byte* ptr2 = SDL_StringToNative(defaultLocation))
            {
                iSDL_ShowSaveFileDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, numFilters, ptr2);
            }
        }

        public static void SDL_ShowOpenFolderDialog(SDL_DialogFileCallback callback, IntPtr userdata, SDL_Window* window, string defaultLocation, bool allowMany)
        {
            fixed (byte* ptr1 = SDL_StringToNative(defaultLocation))
            {
                iSDL_ShowOpenFolderDialog(Marshal.GetFunctionPointerForDelegate(callback), userdata, window, ptr1, allowMany);
            }
        }

        public static void SDL_ShowFileDialogWithProperties(SDL_FileDialogType type, SDL_DialogFileCallback callback, IntPtr userdata, uint props)
        {
            iSDL_ShowFileDialogWithProperties(type, Marshal.GetFunctionPointerForDelegate(callback), userdata, props);
        }
    }
}