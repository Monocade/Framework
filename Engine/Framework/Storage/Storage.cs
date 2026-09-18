using System;
using System.IO;

namespace Engine
{
    // Storage
    public sealed partial class Storage : Module
    {
        public static string PrefPath(string name) => SDL_GetPrefPath(string.Empty, name);

        public static string Normalize(string path) => path.Replace("\\", "/");
        
        public static string BasePath => SDL_GetBasePath();
        
        
        internal Storage(App app) : base(app)
        {
            // Constructor
        }
    }
    
    // Storage API
    public unsafe partial class Storage
    {
        public static StorageProvider OpenStorage(StorageType type, string name = null)
        {
            name = Normalize(name);
            {
                StorageProvider storageProvider;
            
                switch (type)
                {
                    case StorageType.File:
                    {
                        storageProvider = new FileStorageProvider(SDL_OpenFileStorage(name));
                        break;
                    }
                    case StorageType.Title:
                    {
                        storageProvider = new TitleStorageProvider(SDL_OpenTitleStorage(name, 0));
                        break;
                    }
                    case StorageType.User:
                    {
                        storageProvider = new UserStorageProvider(SDL_OpenUserStorage(string.Empty, name, 0));
                        break;
                    }
                    default:
                    {
                        throw new Exception($"Unknown storage: {type}");
                    }
                }
            
                while (!storageProvider.IsReady)
                {
                    SDL_Delay(1);
                }

                return storageProvider;
            }
        }

        public static void CloseStorage(StorageProvider storageProvider)
        {
            if (storageProvider != null)
            {
                storageProvider.Dispose();
            }
        }
    }

    // Dialog API
    public unsafe partial class Storage
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
                    SDL_ShowOpenFileDialog(DialogCallbackHandler, nativeContext, Window.Handle, nativeFilters, nativeFilters.Length, path, multiple);
                    break;
                }
                case DialogMode.SaveFile:
                {
                    SDL_ShowSaveFileDialog(DialogCallbackHandler, nativeContext, Window.Handle, nativeFilters, nativeFilters.Length, path);
                    break;
                }
                case DialogMode.OpenFolder:
                {
                    SDL_ShowOpenFolderDialog(DialogCallbackHandler, nativeContext, Window.Handle, path, multiple);
                    break;
                }
            }
        }
        
        private static void DialogCallbackHandler(IntPtr nativeContext, byte** nativeFiles, int nativeFilter)
        {
            var files = Native.NativeToStringArray((IntPtr)nativeFiles, out var count);
            {
                var context = Native.NativeToObject<DialogContext>(nativeContext);
                {
                    var result = nativeFiles == null ? DialogResult.Failed : count == 0 ? DialogResult.Cancelled : DialogResult.Success;
                    {
                        context.Callback?.Invoke(result, files);
                    }
                }
                
                foreach (var filter in context.NativeFilters)
                {
                    Native.Free((IntPtr)filter.Name, SDL_NativeProvider);
                    Native.Free((IntPtr)filter.Pattern, SDL_NativeProvider);
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
    public unsafe partial class Storage
    {
        public static string[] DirectoryEnumerate(StorageProvider storage, string path, string pattern)
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
                    if (result == null)
                    {
                        throw new Exception($"Failed to enumerate directory {path}: {SDL_GetError()}");
                    }
                }
                
                return result;
            }
        }

        public static void DirectoryCopy(StorageProvider storage, string path, string destination)
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
                    throw new Exception($"Failed to copy directory {path}: Not a valid directory");
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
                        else if (IsFile(storage, source))
                        {
                            FileCopy(storage, source, target);
                        }
                    }
                }
            }
        }

        public static void DirectoryRename(StorageProvider storage, string path, string destination)
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

        public static bool DirectoryExists(StorageProvider storage, string path)
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

        public static ulong DirectorySize(StorageProvider storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    if (!result)
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

        public static void DirectoryCreate(StorageProvider storage, string path)
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
                    if (!result)
                    {
                        throw new Exception($"Failed to create directory {path}: {SDL_GetError()}");
                    }
                }
            }
        }

        public static void DirectoryDelete(StorageProvider storage, string path)
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
                    if (!result)
                    {
                        throw new Exception($"Failed to delete directory {path}: {SDL_GetError()}");
                    }
                }
            }
        }

        public static bool IsDirectory(StorageProvider storage, string path)
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
    public unsafe partial class Storage
    {
        public static bool IsFile(StorageProvider storage, string path)
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
        
        public static void FileCopy(StorageProvider storage, string path, string destination)
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
                    if (!result)
                    {
                        throw new Exception($"Failed to copy file from {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public static void FileRename(StorageProvider storage, string path, string destination)
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
                    if (!result)
                    {
                        throw new Exception($"Failed to rename file from {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public static bool FileExists(StorageProvider storage, string path)
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
        
        public static ulong FileSize(StorageProvider storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(storage.Handle, path, out var info);
                {
                    if (!result)
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
        
        public static void FileDelete(StorageProvider storage, string path)
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
                    if (!result)
                    {
                        throw new Exception($"Failed to delete file {path}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public static byte[] FileReadBytes(StorageProvider storage, string path, ulong bufferSize = 0)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var size = bufferSize;
                var fileSize = FileSize(storage, path);
                
                if (bufferSize <= 0 || bufferSize > fileSize)
                {
                    size = fileSize;
                }

                var result = SDL_ReadStorageFile(storage.Handle, path, out byte[] buffer, size);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to read file {path}: {SDL_GetError()}");
                    }
                }
                    
                return buffer;
            }
        }
        
        public static void FileWriteBytes(StorageProvider storage, string path, byte[] buffer, ulong bufferSize = 0)
        {
            path = Normalize(path);
            {
                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var size = bufferSize;
                
                if (size <= 0 || size > (ulong)buffer.Length)
                {
                    size = (ulong)buffer.Length;
                }

                var result = SDL_WriteStorageFile(storage.Handle, path, buffer, bufferSize > 0 ? bufferSize : size);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to write file {path}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public static Stream FileRead(StorageProvider storage, string path)
        {
            path = Normalize(path);
            {
                if (!storage.IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_ReadStorageFile(storage.Handle, path, out byte[] buffer, FileSize(storage, path));
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to read file {path}: {SDL_GetError()}");
                    }
                }

                return new MemoryStream(buffer);
            }
        }
        
        public static void FileWrite(StorageProvider storage, string path, Stream stream)
        {
            path = Normalize(path);
            {
                if (!storage.IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                using var memory = new MemoryStream();
                stream.CopyTo(memory);
                
                var result = SDL_WriteStorageFile(storage.Handle, path, memory.ToArray(), (ulong)memory.Length);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to write file {path}: {SDL_GetError()}");
                    }
                }
            }
        }
    }
}