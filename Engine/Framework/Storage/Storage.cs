using System;

namespace Engine
{
    // Storage
    public sealed unsafe partial class Storage(App app) : Module(app)
    {
        public static string CurrentDirectory => SDL_GetCurrentDirectory();

        public static string BasePath => SDL_GetBasePath();
    }
    
    // Storage API
    public unsafe partial class Storage
    {
        public static StorageContainer Open(StorageType type, string name = null)
        {
            switch (type)
            {
                case StorageType.File:
                {
                    return new FileStorageContainer(SDL_OpenFileStorage(name));
                }
                case StorageType.Title:
                {
                    return new TitleStorageContainer(SDL_OpenTitleStorage(name, 0));
                }
                case StorageType.User:
                {
                    return new FileStorageContainer(SDL_OpenUserStorage(string.Empty, name, 0));
                }
                default:
                {
                    throw new Exception($"Unknown storage: {type}");
                }
            }
        }

        public static void Close(StorageContainer storage)
        {
            if (storage != null)
            {
                storage.Dispose();
            }
        }
        
        public ulong SizeRemaining(StorageContainer storage)
        {
            throw new NotImplementedException();
        }
        
        public ulong Size(StorageContainer storage)
        {
            throw new NotImplementedException();
        }
    }
    
    // Directory API
    public unsafe partial class Storage
    {
        public string[] DirectoryEnumerate(StorageContainer storage, string path, string pattern)
        {
            throw new NotImplementedException();
        }

        public static bool DirectoryCopy(StorageContainer storage, string path, string destination)
        {
            throw new NotImplementedException();
        }

        public bool DirectoryRename(StorageContainer storage, string path, string destination)
        {
            throw new NotImplementedException();
        }

        public bool DirectoryExists(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }

        public ulong DirectorySize(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }

        public bool DirectoryCreate(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }

        public bool DirectoryDelete(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }

        public bool IsDirectory(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }
    }
    
    // File API
    public unsafe partial class Storage
    {
        public static bool FileCopy(StorageContainer storage, string path, string destination)
        {
            throw new NotImplementedException();
        }
        
        public bool FileRename(StorageContainer storage, string path, string destination)
        {
            throw new NotImplementedException();
        }
        
        public bool FileExists(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }
        
        public ulong FileSize(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }
        
        public static byte[] FileRead(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }

        public static bool FileWrite(StorageContainer storage, string path, byte[] bytes)
        {
            throw new NotImplementedException();
        }
        
        public bool FileDelete(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }
        
        public bool IsFile(StorageContainer storage, string path)
        {
            throw new NotImplementedException();
        }
    }
}