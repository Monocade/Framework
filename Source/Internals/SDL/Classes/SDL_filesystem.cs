using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static string SDL_GetBasePath()
        {
            return Native.NativeToString((IntPtr)iSDL_GetBasePath());
        }

        public static string SDL_GetPrefPath(string org, string app)
        {
            var orgPtr = Native.StringToNative(org, SDL_NativeProvider);
            var appPtr = Native.StringToNative(app, SDL_NativeProvider);
            {
                var prefPathPtr = (IntPtr)iSDL_GetPrefPath((byte*)orgPtr, (byte*)appPtr);
                
                var result = Native.NativeToString(prefPathPtr);
                {
                    Native.Free(prefPathPtr, SDL_NativeProvider);
                    Native.Free(orgPtr, SDL_NativeProvider);
                    Native.Free(appPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static string SDL_GetUserFolder(SDL_Folder folder)
        {
            return Native.NativeToString((IntPtr)iSDL_GetUserFolder(folder));
        }

        public static bool SDL_CreateDirectory(string path)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            {
                var result = iSDL_CreateDirectory((byte*)pathPtr);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_EnumerateDirectory(string path, SDL_EnumerateDirectoryCallback callback, IntPtr userdata)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            {
                var result = iSDL_EnumerateDirectory((byte*)pathPtr, Marshal.GetFunctionPointerForDelegate(callback), userdata);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_RemovePath(string path)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            {
                var result = iSDL_RemovePath((byte*)pathPtr);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_RenamePath(string oldPath, string newPath)
        {
            var oldPathPtr = Native.StringToNative(oldPath, SDL_NativeProvider);
            var newPathPtr = Native.StringToNative(newPath, SDL_NativeProvider);
            {
                var result = iSDL_RenamePath((byte*)oldPathPtr, (byte*)newPathPtr);
                {
                    Native.Free(oldPathPtr, SDL_NativeProvider);
                    Native.Free(newPathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_CopyFile(string oldPath, string newPath)
        {
            var oldPathPtr = Native.StringToNative(oldPath, SDL_NativeProvider);
            var newPathPtr = Native.StringToNative(newPath, SDL_NativeProvider);
            {
                var result = iSDL_CopyFile((byte*)oldPathPtr, (byte*)newPathPtr);
                {
                    Native.Free(oldPathPtr, SDL_NativeProvider);
                    Native.Free(newPathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_GetPathInfo(string path, out SDL_PathInfo info)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            
            fixed (SDL_PathInfo* ptr2 = &info)
            {
                var result = iSDL_GetPathInfo((byte*)pathPtr, ptr2);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static string[] SDL_GlobDirectory(string path, string pattern, SDL_GlobFlags flags, out int count)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            var patternPtr = Native.StringToNative(pattern, SDL_NativeProvider);
            {
                int size = 0;
                {
                    var globDirectoryPtr = (IntPtr)iSDL_GlobDirectory((byte*)pathPtr, (byte*)patternPtr, (uint)flags, &size);
                    
                    var result = Native.NativeToStringArray(globDirectoryPtr, size, out count);
                    {
                        Native.Free(pathPtr, SDL_NativeProvider);
                        Native.Free(patternPtr, SDL_NativeProvider);
                        Native.Free(globDirectoryPtr, SDL_NativeProvider);
                        return result;
                    }
                }
            }
        }

        public static string SDL_GetCurrentDirectory()
        {
            var currentDirectoryPtr = (IntPtr)iSDL_GetCurrentDirectory();
            {
                var result = Native.NativeToString(currentDirectoryPtr);
                {
                    Native.Free(currentDirectoryPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }
    }
}