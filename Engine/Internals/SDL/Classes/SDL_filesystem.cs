using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static string SDL_GetBasePath()
        {
            return SDL_NativeToString(iSDL_GetBasePath());
        }

        public static string SDL_GetPrefPath(string org, string app)
        {
            fixed (byte* ptr1 = SDL_StringToNative(org))
            fixed (byte* ptr2 = SDL_StringToNative(app))
            {
                return SDL_NativeToString(iSDL_GetPrefPath(ptr1, ptr2), free: true);
            }
        }

        public static string SDL_GetUserFolder(SDL_Folder folder)
        {
            return SDL_NativeToString(iSDL_GetUserFolder(folder));
        }

        public static bool SDL_CreateDirectory(string path)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_CreateDirectory(ptr1);
            }
        }

        public static bool SDL_EnumerateDirectory(string path, SDL_EnumerateDirectoryCallback callback, IntPtr userdata)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_EnumerateDirectory(ptr1, Marshal.GetFunctionPointerForDelegate(callback), userdata);
            }
        }

        public static bool SDL_RemovePath(string path)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_RemovePath(ptr1);
            }
        }

        public static bool SDL_RenamePath(string oldpath, string newpath)
        {
            fixed (byte* ptr1 = SDL_StringToNative(oldpath))
            fixed (byte* ptr2 = SDL_StringToNative(newpath))
            {
                return iSDL_RenamePath(ptr1, ptr2);
            }
        }

        public static bool SDL_CopyFile(string oldpath, string newpath)
        {
            fixed (byte* ptr1 = SDL_StringToNative(oldpath))
            fixed (byte* ptr2 = SDL_StringToNative(newpath))
            {
                return iSDL_CopyFile(ptr1, ptr2);
            }
        }

        public static bool SDL_GetPathInfo(string path, out SDL_PathInfo info)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            fixed (SDL_PathInfo* ptr2 = &info)
            {
                return iSDL_GetPathInfo(ptr1, ptr2);
            }
        }

        public static string[] SDL_GlobDirectory(string path, string pattern, SDL_GlobFlags flags, out int count)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            fixed (byte* ptr2 = SDL_StringToNative(pattern))
            {
                int size = 0;
                {
                    return SDL_NativeToArray(iSDL_GlobDirectory(ptr1, ptr2, (uint)flags, &size), size, out count);
                }
            }
        }

        public static string SDL_GetCurrentDirectory()
        {
            return SDL_NativeToString(iSDL_GetCurrentDirectory(), free: true);
        }
    }
}