using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageCloseCallback(void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageReadyCallback(void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageEnumerateCallback(void* userdata, byte* path, SDL_EnumerateDirectoryCallback callback, void* callbackUserdata);

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
    internal unsafe delegate bool SDL_StorageRenameCallback(void* userdata, byte* oldPath, byte* newPath);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate bool SDL_StorageCopyCallback(void* userdata, byte* oldPath, byte* newPath);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate ulong SDL_StorageSpaceRemainingCallback(void* userdata);
    
    
    internal static unsafe partial class SDL
    {
        public static SDL_Storage* SDL_OpenTitleStorage(string @override, uint props)
        {
            var @overridePtr = Native.StringToNative(@override, SDL_NativeProvider);
            {
                var result = iSDL_OpenTitleStorage((byte*)overridePtr, props);
                {
                    Native.Free(@overridePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static SDL_Storage* SDL_OpenUserStorage(string org, string app, uint props)
        {
            var orgPtr = Native.StringToNative(org, SDL_NativeProvider);
            var appPtr = Native.StringToNative(app, SDL_NativeProvider);
            {
                var result = iSDL_OpenUserStorage((byte*)orgPtr, (byte*)appPtr, props);
                {
                    Native.Free(orgPtr, SDL_NativeProvider);
                    Native.Free(appPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static SDL_Storage* SDL_OpenFileStorage(string path)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            {
                var result = iSDL_OpenFileStorage((byte*)pathPtr);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static SDL_Storage* SDL_OpenStorage(SDL_StorageInterface* @interface, IntPtr userdata)
        {
            return iSDL_OpenStorage(@interface, userdata);
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
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            
            fixed (ulong* ptr2 = &length)
            {
                var result = iSDL_GetStorageFileSize(storage, (byte*)pathPtr, ptr2);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_ReadStorageFile(SDL_Storage* storage, string path, out byte[] buffer, ulong length)
        {
            buffer = new byte[length];
            {
                var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
                
                fixed (byte* ptr2 = buffer)
                {
                    var result = iSDL_ReadStorageFile(storage, (byte*)pathPtr, (IntPtr)ptr2, length);
                    {
                        Native.Free(pathPtr, SDL_NativeProvider);
                        return result;
                    }
                }
            }
        }

        public static bool SDL_WriteStorageFile(SDL_Storage* storage, string path, byte[] buffer, ulong length)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            
            fixed (byte* ptr2 = buffer)
            {
                var result = iSDL_WriteStorageFile(storage, (byte*)pathPtr, (IntPtr)ptr2, length);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_CreateStorageDirectory(SDL_Storage* storage, string path)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            {
                var result = iSDL_CreateStorageDirectory(storage, (byte*)pathPtr);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_EnumerateStorageDirectory(SDL_Storage* storage, string path, SDL_EnumerateDirectoryCallback callback, IntPtr userdata)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            {
                var result = iSDL_EnumerateStorageDirectory(storage, (byte*)pathPtr, Marshal.GetFunctionPointerForDelegate(callback), userdata);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_RemoveStoragePath(SDL_Storage* storage, string path)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            {
                var result = iSDL_RemoveStoragePath(storage, (byte*)pathPtr);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_RenameStoragePath(SDL_Storage* storage, string oldPath, string newPath)
        {
            var oldPathPtr = Native.StringToNative(oldPath, SDL_NativeProvider);
            var newPathPtr = Native.StringToNative(newPath, SDL_NativeProvider);
            {
                var result = iSDL_RenameStoragePath(storage, (byte*)oldPathPtr, (byte*)newPathPtr);
                {
                    Native.Free(oldPathPtr, SDL_NativeProvider);
                    Native.Free(newPathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_CopyStorageFile(SDL_Storage* storage, string oldPath, string newPath)
        {
            var oldPathPtr = Native.StringToNative(oldPath, SDL_NativeProvider);
            var newPathPtr = Native.StringToNative(newPath, SDL_NativeProvider);
            {
                var result = iSDL_CopyStorageFile(storage, (byte*)oldPathPtr, (byte*)newPathPtr);
                {
                    Native.Free(oldPathPtr, SDL_NativeProvider);
                    Native.Free(newPathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_GetStoragePathInfo(SDL_Storage* storage, string path, out SDL_PathInfo info)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            
            fixed (SDL_PathInfo* ptr2 = &info)
            {
                var result = iSDL_GetStoragePathInfo(storage, (byte*)pathPtr, ptr2);
                {
                    Native.Free(pathPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static ulong SDL_GetStorageSpaceRemaining(SDL_Storage* storage)
        {
            return iSDL_GetStorageSpaceRemaining(storage);
        }

        public static string[] SDL_GlobStorageDirectory(SDL_Storage* storage, string path, string pattern, SDL_GlobFlags flags, out int count)
        {
            var pathPtr = Native.StringToNative(path, SDL_NativeProvider);
            var patternPtr = Native.StringToNative(pattern, SDL_NativeProvider);
            {
                int size = 0;
                {
                    var globStorageDirectoryPtr = (IntPtr)iSDL_GlobStorageDirectory(storage, (byte*)pathPtr, (byte*)patternPtr, (uint)flags, &size);
                    
                    var result = Native.NativeToStringArray(globStorageDirectoryPtr, size, out count);
                    {
                        Native.Free(pathPtr, SDL_NativeProvider);
                        Native.Free(patternPtr, SDL_NativeProvider);
                        Native.Free(globStorageDirectoryPtr, SDL_NativeProvider);
                        return result;
                    }
                }
            }
        }
    }
}