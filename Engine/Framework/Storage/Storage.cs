using System;
using System.IO;

namespace Engine
{
    // Storage
    public sealed unsafe partial class Storage : Module
    {
        public static string PrefPath(string name) => SDL_GetPrefPath(string.Empty, name);

        public static string BasePath => SDL_GetBasePath();
        
        
        internal Storage(App app) : base(app)
        {
            // Constructor
        }
    }
    
    // Storage API
    public unsafe partial class Storage
    {
        public static StorageContainer Open(StorageType type, string name = null)
        {
            StorageContainer storage;
            
            switch (type)
            {
                case StorageType.File:
                {
                    storage = new FileStorageContainer(SDL_OpenFileStorage(name));
                    break;
                }
                case StorageType.Title:
                {
                    storage = new TitleStorageContainer(SDL_OpenTitleStorage(name, 0));
                    break;
                }
                case StorageType.User:
                {
                    storage = new UserStorageContainer(SDL_OpenUserStorage(string.Empty, name, 0));
                    break;
                }
                default:
                {
                    throw new Exception($"Unknown storage: {type}");
                }
            }
            
            while (!storage.IsReady)
            {
                SDL_Delay(1);
            }

            return storage;
        }

        public static void Close(StorageContainer storage)
        {
            if (storage != null)
            {
                storage.Dispose();
            }
        }
    }
    
    // Directory API
    public unsafe partial class Storage
    {
        public static string[] DirectoryEnumerate(StorageContainer storage, string path, string pattern)
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

        public static void DirectoryCopy(StorageContainer storage, string path, string destination)
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

        public static void DirectoryRename(StorageContainer storage, string path, string destination)
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

        public static bool DirectoryExists(StorageContainer storage, string path)
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

        public static ulong DirectorySize(StorageContainer storage, string path)
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

        public static void DirectoryCreate(StorageContainer storage, string path)
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

        public static void DirectoryDelete(StorageContainer storage, string path)
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

        public static bool IsDirectory(StorageContainer storage, string path)
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
    
    // File API
    public unsafe partial class Storage
    {
        public static void FileCopy(StorageContainer storage, string path, string destination)
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
        
        public static void FileRename(StorageContainer storage, string path, string destination)
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
        
        public static bool FileExists(StorageContainer storage, string path)
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
        
        public static ulong FileSize(StorageContainer storage, string path)
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
        
        public static void FileDelete(StorageContainer storage, string path)
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
        
        public static bool IsFile(StorageContainer storage, string path)
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
        
        public static byte[] FileRead(StorageContainer storage, string path, ulong size = 0)
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

        public static void FileWrite(StorageContainer storage, string path, byte[] buffer, ulong size = 0)
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