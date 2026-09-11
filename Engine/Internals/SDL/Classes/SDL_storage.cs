using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageCloseCallback(void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageReadyCallback(void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageEnumerateCallback(void* userdata, byte* path, SDL_EnumerateDirectoryCallback callback, void* callback_userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageInfoCallback(void* userdata, byte* path, SDL_PathInfo* info);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageReadFileCallback(void* userdata, byte* path, void* destination, ulong length);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageWriteFileCallback(void* userdata, byte* path, void* source, ulong length);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageMkdirCallback(void* userdata, byte* path);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageRemoveCallback(void* userdata, byte* path);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageRenameCallback(void* userdata, byte* oldpath, byte* newpath);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageCopyCallback(void* userdata, byte* oldpath, byte* newpath);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate ulong SDL_StorageSpaceRemainingCallback(void* userdata);
    
    
    internal static unsafe partial class SDL
    {
        public static SDL_Storage* SDL_OpenTitleStorage(string @override, uint props)
        {
            fixed (byte* ptr1 = SDL_StringToNative(@override))
            {
                return iSDL_OpenTitleStorage(@ptr1, props);
            }
        }

        public static SDL_Storage* SDL_OpenUserStorage(string org, string app, uint props)
        {
            fixed (byte* ptr1 = SDL_StringToNative(org))
            fixed (byte* ptr2 = SDL_StringToNative(app))
            {
                return iSDL_OpenUserStorage(ptr1, ptr2, props);
            }
        }

        public static SDL_Storage* SDL_OpenFileStorage(string path)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_OpenFileStorage(ptr1);
            }
        }

        public static SDL_Storage* SDL_OpenStorage(SDL_StorageInterface* iface, IntPtr userdata)
        {
            return iSDL_OpenStorage(iface, userdata);
        }

        public static bool SDL_CloseStorage(SDL_Storage* storage)
        {
            return iSDL_CloseStorage(storage);
        }

        public static bool SDL_StorageReady(SDL_Storage* storage)
        {
            return iSDL_StorageReady(storage);
        }

        public static bool SDL_GetStorageFileSize(SDL_Storage* storage, string path, out ulong length)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            fixed (ulong* ptr2 = &length)
            {
                return iSDL_GetStorageFileSize(storage, ptr1, ptr2);
            }
        }

        public static bool SDL_ReadStorageFile(SDL_Storage* storage, string path, IntPtr destination, ulong length)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_ReadStorageFile(storage, ptr1, destination, length);
            }
        }

        public static bool SDL_WriteStorageFile(SDL_Storage* storage, string path, IntPtr source, ulong length)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_WriteStorageFile(storage, ptr1, source, length);
            }
        }

        public static bool SDL_CreateStorageDirectory(SDL_Storage* storage, string path)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_CreateStorageDirectory(storage, ptr1);
            }
        }

        public static bool SDL_EnumerateStorageDirectory(SDL_Storage* storage, string path, SDL_EnumerateDirectoryCallback callback, IntPtr userdata)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_EnumerateStorageDirectory(storage, ptr1, Marshal.GetFunctionPointerForDelegate(callback), userdata);
            }
        }

        public static bool SDL_RemoveStoragePath(SDL_Storage* storage, string path)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_RemoveStoragePath(storage, ptr1);
            }
        }

        public static bool SDL_RenameStoragePath(SDL_Storage* storage, string oldpath, string newpath)
        {
            fixed (byte* ptr1 = SDL_StringToNative(oldpath))
            fixed (byte* ptr2 = SDL_StringToNative(newpath))
            {
                return iSDL_RenameStoragePath(storage, ptr1, ptr2);
            }
        }

        public static bool SDL_CopyStorageFile(SDL_Storage* storage, string oldpath, string newpath)
        {
            fixed (byte* ptr1 = SDL_StringToNative(oldpath))
            fixed (byte* ptr2 = SDL_StringToNative(newpath))
            {
                return iSDL_CopyStorageFile(storage, ptr1, ptr2);
            }
        }

        public static bool SDL_GetStoragePathInfo(SDL_Storage* storage, string path, out SDL_PathInfo info)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            fixed (SDL_PathInfo* ptr2 = &info)
            {
                return iSDL_GetStoragePathInfo(storage, ptr1, ptr2);
            }
        }

        public static ulong SDL_GetStorageSpaceRemaining(SDL_Storage* storage)
        {
            return iSDL_GetStorageSpaceRemaining(storage);
        }

        public static string[] SDL_GlobStorageDirectory(SDL_Storage* storage, string path, string pattern, SDL_GlobFlags flags, out int count)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            fixed (byte* ptr2 = SDL_StringToNative(pattern))
            {
                int size = 0;
                {
                    return SDL_NativeToArray(iSDL_GlobStorageDirectory(storage, ptr1, ptr2, (uint)flags, &size), size, out count);
                }
            }
        }
    }
}