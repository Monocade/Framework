using System;

namespace Engine
{
    // Storage
    public sealed partial class FileSystem : Module
    {
        public static string PrefPath(string name) => SDL_GetPrefPath(string.Empty, name);

        public static string Normalize(string path) => path.Replace("\\", "/");
        
        public static string BasePath => SDL_GetBasePath();
        
        
        internal FileSystem(App app) : base(app)
        {
            // Constructor
        }
    }
    
    // Storage API
    public unsafe partial class FileSystem
    {
        public static Storage OpenStorage(StorageProvider provider, string name = null)
        {
            name = Normalize(name);
            {
                Storage storage;
            
                switch (provider)
                {
                    case StorageProvider.File:
                    {
                        storage = new FileStorage(SDL_OpenFileStorage(name));
                        break;
                    }
                    case StorageProvider.Title:
                    {
                        storage = new TitleStorage(SDL_OpenTitleStorage(name, 0));
                        break;
                    }
                    case StorageProvider.User:
                    {
                        storage = new UserStorage(SDL_OpenUserStorage(string.Empty, name, 0));
                        break;
                    }
                    default:
                    {
                        throw new Exception($"Unknown storage: {provider}");
                    }
                }
            
                while (!storage.IsReady)
                {
                    SDL_Delay(1);
                }

                return storage;
            }
        }

        public static void CloseStorage(Storage storage)
        {
            if (storage != null)
            {
                storage.Dispose();
            }
        }
    }

    // Dialog API
    public unsafe partial class FileSystem
    {
        public delegate void DialogCallback(DialogResult result, string[] contents);
        

        private static void DialogHandler(string path, DialogCallback callback, DialogFilter[] filters, DialogMode mode, bool multiple)
        {
            var nativeFilters = new SDL_DialogFileFilter[filters?.Length ?? 0];

            for (int i = 0; i < nativeFilters.Length; i++)
            {
                nativeFilters[i] = new SDL_DialogFileFilter()
                {
                    Name = (byte*)Native.StringToNative(filters?[i].Name, SDL_NativeProvider),
                    Pattern = (byte*)Native.StringToNative(filters?[i].Pattern, SDL_NativeProvider),
                };
            }

            var nativeContext = Native.ObjectToNative
            (
                new DialogContext
                (
                    path,
                    callback,
                    nativeFilters,
                    mode
                )
            );
            
            switch (mode)
            {
                case DialogMode.OpenFile:
                {
                    SDL_ShowOpenFileDialog(DialogCallbackHandler, nativeContext, Window.handle, nativeFilters, nativeFilters.Length, path, multiple);
                    break;
                }
                case DialogMode.SaveFile:
                {
                    SDL_ShowSaveFileDialog(DialogCallbackHandler, nativeContext, Window.handle, nativeFilters, nativeFilters.Length, path);
                    break;
                }
                case DialogMode.OpenFolder:
                {
                    SDL_ShowOpenFolderDialog(DialogCallbackHandler, nativeContext, Window.handle, path, multiple);
                    break;
                }
            }
        }
        
        private static void DialogCallbackHandler(IntPtr nativeContext, byte** fileList, int filter)
        {
            var files = Native.NativeToStringArray((IntPtr)fileList, out var count);
            {
                var context = Native.NativeToObject<DialogContext>(nativeContext);
                {
                    var result = fileList == null ? DialogResult.Failed : count == 0 ? DialogResult.Cancelled : DialogResult.Success;
                    {
                        context.Callback?.Invoke(result, files);
                    }
                }
                
                foreach (var nativeFilter in context.NativeFilters)
                {
                    Native.Free((IntPtr)nativeFilter.Name, SDL_NativeProvider);
                    Native.Free((IntPtr)nativeFilter.Pattern, SDL_NativeProvider);
                }
            }
        }
        
        public static void OpenFolderDialog(string path, DialogCallback callback, DialogFilter[] filters = null, bool multiple = false)
        {
            DialogHandler(path, callback, filters, DialogMode.OpenFolder, multiple);
        }
        
        public static void OpenFileDialog(string path, DialogCallback callback, DialogFilter[] filters = null, bool multiple = false)
        {
            DialogHandler(path, callback, filters, DialogMode.OpenFile, multiple);
        }
        
        public static void OpenSaveDialog(string path, DialogCallback callback, DialogFilter[] filters = null)
        {
            DialogHandler(path, callback, filters, DialogMode.SaveFile, false);
        }
    }
    
    // Directory API
    public unsafe partial class FileSystem
    {
        public static string[] DirectoryEnumerate(Storage storage, string path, string pattern)
        {
            pattern = Normalize(pattern);
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!DirectoryExists(storage, path))
                {
                    throw new Exception($"Path {path} is not a valid directory");
                }

                var result = SDL_GlobStorageDirectory(storage.Handle, path, pattern, SDL_GlobFlags.SDL_GLOB_CASEINSENSITIVE, out _);
                {
                    return result;
                }
            }
        }

        public static void DirectoryCopy(Storage storage, string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                if (!DirectoryExists(storage, path))
                {
                    throw new Exception($"Path {path} is not a valid directory");
                }

                DirectoryCreate(storage, destination);
                {
                    foreach (var entry in DirectoryEnumerate(storage, path, "*"))
                    {
                        var source = string.IsNullOrEmpty(path) ? entry : $"{path}/{entry}";
                        var relative = string.IsNullOrEmpty(path) ? entry : source.Substring(path.Length + 1);
                        var target = string.IsNullOrEmpty(destination) ? relative : $"{destination}/{relative}";

                        if (IsDirectory(storage, source))
                        {
                            DirectoryCopy(storage, source, target);
                        }

                        if (IsFile(storage, source))
                        {
                            FileCopy(storage, source, target);
                        }
                    }
                }
            }
        }

        public static void DirectoryRename(Storage storage, string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RenameStoragePath(storage.Handle, path, destination);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to rename {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }

        public static bool DirectoryExists(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_DIRECTORY;
                }
            }
        }

        public static ulong DirectorySize(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to get directory size {path}: {SDL_GetError()}");
                    }

                    if (info.Type != SDL_PathType.SDL_PATHTYPE_DIRECTORY)
                    {
                        throw new Exception($"Failed to get directory size {path}: Not a valid directory");
                    }
                }

                return info.Size;
            }
        }

        public static void DirectoryCreate(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_CreateStorageDirectory(storage.Handle, path);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to create directory {path}: {SDL_GetError()}");
                    }
                }
            }
        }

        public static void DirectoryDelete(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RemoveStoragePath(storage.Handle, path);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to delete directory {path}: {SDL_GetError()}");
                    }
                }
            }
        }

        public static bool IsDirectory(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_DIRECTORY;
                }
            }
        }
    }
    
    // File API
    public unsafe partial class FileSystem
    {
        public static void FileCopy(Storage storage, string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_CopyStorageFile(storage.Handle, path, destination);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to copy file from {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public static void FileRename(Storage storage, string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RenameStoragePath(storage.Handle, path, destination);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to rename file from {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public static bool FileExists(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_FILE;
                }
            }
        }
        
        public static ulong FileSize(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to get file size {path}: {SDL_GetError()}");
                    }

                    if (info.Type != SDL_PathType.SDL_PATHTYPE_FILE)
                    {
                        throw new Exception($"Failed to get file size {path}: Not a valid file");
                    }
                }

                return info.Size;
            }
        }
        
        public static void FileDelete(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RemoveStoragePath(storage.Handle, path);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to delete file {path}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public static bool IsFile(Storage storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_FILE;
                }
            }
        }
        
        public static byte[] FileRead(Storage storage, string path, ulong size = 0)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var total = size > 0 ? size : FileSize(storage, path);

                var result = SDL_ReadStorageFile(storage.Handle, path, out byte[] buffer, total);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to read file {path}: {SDL_GetError()}");
                    }
                }

                return buffer;
            }
        }

        public static void FileWrite(Storage storage, string path, byte[] buffer, ulong size = 0)
        {
            path = Normalize(path);
            {
                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var total = size > 0 ? size : (ulong)buffer.Length;

                var result = SDL_WriteStorageFile(storage.Handle, path, buffer, total);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to write file {path}: {SDL_GetError()}");
                    }
                }
            }
        }
    }
}