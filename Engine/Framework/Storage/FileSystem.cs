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
        public static Storage StorageOpen(StorageProvider provider, string name = null)
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

        public static void StorageClose(Storage storage)
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
        public delegate void DialogCallbacks(string[] contents);
        
        public delegate void DialogCallback(string content);
        
        
        public static void DialogOpenFile(DialogCallbacks callback, string path)
        {
            path = Normalize(path);
            {
                void Callback(IntPtr userdata, byte** fileList, int filter)
                {
                    var files = SDL_NativeToArray(fileList, false);
                    {
                        if (files.Length > 0)
                        {
                            callback(files);
                        }
                    }
                }

                SDL_ShowOpenFileDialog(Callback, IntPtr.Zero, Window.handle, null, 0, path, true);
            }
        }
        
        public static void DialogOpenFile(DialogCallback callback, string path)
        {
            path = Normalize(path);
            {
                void Callback(IntPtr userdata, byte** fileList, int filter)
                {
                    var files = SDL_NativeToArray(fileList, false);
                    {
                        if (files.Length > 0)
                        {
                            callback(files[0]);
                        }
                    }
                }

                SDL_ShowOpenFileDialog(Callback, IntPtr.Zero, Window.handle, null, 0, path, true);
            }
        }
        
        public static void DialogOpenFolder(DialogCallbacks callback, string path)
        {
            path = Normalize(path);
            {
                void Callback(IntPtr userdata, byte** fileList, int filter)
                {
                    var files = SDL_NativeToArray(fileList, false);
                    {
                        if (files.Length > 0)
                        {
                            callback(files);
                        }
                    }
                }

                SDL_ShowOpenFolderDialog(Callback, IntPtr.Zero, Window.handle, path, true);
            }
        }
        
        public static void DialogOpenFolder(DialogCallback callback, string path)
        {
            path = Normalize(path);
            {
                void Callback(IntPtr userdata, byte** fileList, int filter)
                {
                    var files = SDL_NativeToArray(fileList, false);
                    {
                        if (files.Length > 0)
                        {
                            callback(files[0]);
                        }
                    }
                }

                SDL_ShowOpenFolderDialog(Callback, IntPtr.Zero, Window.handle, path, false);
            }
        }
        
        public static void DialogSaveFile(DialogCallback callback, string path)
        {
            path = Normalize(path);
            {
                void Callback(IntPtr userdata, byte** fileList, int filter)
                {
                    var files = SDL_NativeToArray(fileList, false);
                    {
                        if (files.Length > 0)
                        {
                            callback(files[0]);
                        }
                    }
                }

                SDL_ShowSaveFileDialog(Callback, IntPtr.Zero, Window.handle, null, 0, path);
            }
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