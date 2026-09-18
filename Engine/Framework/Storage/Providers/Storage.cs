using System;
using System.IO;

namespace Engine
{
    // Storage
    public abstract unsafe partial class Storage : IDisposable
    {
        private string Normalize(string path) => path.Replace("\\", "/");
        
        public abstract bool IsWritable { get; }

        public abstract bool IsReadable { get; }

        public abstract bool IsReady { get; }
        
        internal SDL_Storage* Handle
        {
            get; private set;
        }

        
        internal Storage(SDL_Storage* handle)
        {
            if (handle == null)
            {
                throw new Exception($"Failed to open storage: {SDL_GetError()}");
            }
            
            Handle = handle;
        }

        public void Dispose()
        {
            if (Handle != null)
            {
                Console.WriteLine("Disposed");
                SDL_CloseStorage(Handle);
                Handle = null;
            }
        }
    }
    
    // Storage Directory
    public unsafe partial class Storage
    {
        public string[] DirectoryEnumerate(string path, string pattern)
        {
            pattern = Normalize(pattern);
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!DirectoryExists(path))
                {
                    throw new Exception($"Path {path} is not a valid directory");
                }

                var result = SDL_GlobStorageDirectory(Handle, path, pattern, SDL_GlobFlags.SDL_GLOB_CASEINSENSITIVE, out _);
                {
                    if (result == null)
                    {
                        throw new Exception($"Failed to enumerate directory {path}: {SDL_GetError()}");
                    }
                }
                
                return result;
            }
        }

        public void DirectoryCopy(string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                if (!DirectoryExists(path))
                {
                    throw new Exception($"Failed to copy directory {path}: Not a valid directory");
                }

                DirectoryCreate(destination);
                {
                    foreach (var entry in DirectoryEnumerate(path, "*"))
                    {
                        var source = string.IsNullOrEmpty(path) ? entry : $"{path}/{entry}";
                        var relative = string.IsNullOrEmpty(path) ? entry : source.Substring(path.Length + 1);
                        var target = string.IsNullOrEmpty(destination) ? relative : $"{destination}/{relative}";

                        if (IsDirectory(source))
                        {
                            DirectoryCopy(source, target);
                        }
                        else if (IsFile(source))
                        {
                            FileCopy(source, target);
                        }
                    }
                }
            }
        }

        public void DirectoryRename(string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RenameStoragePath(Handle, path, destination);
                {
                    if (result == false)
                    {
                        throw new Exception($"Failed to rename {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }

        public bool DirectoryExists(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_DIRECTORY;
                }
            }
        }

        public ulong DirectorySize(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(Handle, path, out var info);
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

        public void DirectoryCreate(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_CreateStorageDirectory(Handle, path);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to create directory {path}: {SDL_GetError()}");
                    }
                }
            }
        }

        public void DirectoryDelete(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RemoveStoragePath(Handle, path);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to delete directory {path}: {SDL_GetError()}");
                    }
                }
            }
        }

        public bool IsDirectory(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_DIRECTORY;
                }
            }
        }
    }
    
    // Storage File
    public abstract unsafe partial class Storage
    {
        public bool IsFile(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_FILE;
                }
            }
        }
        
        public void FileCopy(string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_CopyStorageFile(Handle, path, destination);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to copy file from {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public void FileRename(string path, string destination)
        {
            destination = Normalize(destination);
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RenameStoragePath(Handle, path, destination);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to rename file from {path} to {destination}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public bool FileExists(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(Handle, path, out var info);
                {
                    return result && info.Type == SDL_PathType.SDL_PATHTYPE_FILE;
                }
            }
        }
        
        public ulong FileSize(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_GetStoragePathInfo(Handle, path, out var info);
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
        
        public void FileDelete(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var result = SDL_RemoveStoragePath(Handle, path);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to delete file {path}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public byte[] FileReadBytes(string path, ulong bufferSize = 0)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var size = bufferSize;
                var fileSize = FileSize(path);
                
                if (bufferSize <= 0 || bufferSize > fileSize)
                {
                    size = fileSize;
                }

                var result = SDL_ReadStorageFile(Handle, path, out byte[] buffer, size);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to read file {path}: {SDL_GetError()}");
                    }
                }
                    
                return buffer;
            }
        }
        
        public void FileWriteBytes(string path, byte[] buffer, ulong bufferSize = 0)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                var size = bufferSize;
                
                if (size <= 0 || size > (ulong)buffer.Length)
                {
                    size = (ulong)buffer.Length;
                }

                var result = SDL_WriteStorageFile(Handle, path, buffer, bufferSize > 0 ? bufferSize : size);
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to write file {path}: {SDL_GetError()}");
                    }
                }
            }
        }
        
        public Stream FileRead(string path)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsReadable)
                {
                    throw new Exception("Storage is not readable");
                }

                var result = SDL_ReadStorageFile(Handle, path, out byte[] buffer, FileSize(path));
                {
                    if (!result)
                    {
                        throw new Exception($"Failed to read file {path}: {SDL_GetError()}");
                    }
                }

                return new MemoryStream(buffer);
            }
        }
        
        public void FileWrite(string path, Stream stream)
        {
            path = Normalize(path);
            {
                if (!IsReady)
                {
                    throw new Exception("Storage is not ready");
                }
                
                if (!IsWritable)
                {
                    throw new Exception("Storage is not writable");
                }

                using var memory = new MemoryStream();
                stream.CopyTo(memory);
                
                var result = SDL_WriteStorageFile(Handle, path, memory.ToArray(), (ulong)memory.Length);
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