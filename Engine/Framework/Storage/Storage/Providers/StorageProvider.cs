using System;
using System.IO;

namespace Engine
{
    // Storage Provider
    public abstract partial class StorageProvider : IDisposable
    {
        public abstract bool IsReady { get; }

        public abstract bool IsWritable { get; }

        public abstract bool IsReadable { get; }


        public abstract string Normalize(string path);
        
        public abstract void Dispose(bool disposing);
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine($"Storage {this} disposed");
        }
    }
    
    // Directory
    public abstract partial class StorageProvider
    {
        public abstract string[] DirectoryEnumerate(string path, string pattern);

        public abstract void DirectoryCopy(string path, string destination);

        public abstract void DirectoryRename(string path, string destination);

        public abstract bool DirectoryExists(string path);

        public abstract ulong DirectorySize(string path);

        public abstract void DirectoryCreate(string path);

        public abstract void DirectoryDelete(string path);

        public abstract bool IsDirectory(string path);
    }
    
    // File
    public abstract partial class StorageProvider
    {
        public abstract bool IsFile(string path);

        public abstract void FileCopy(string path, string destination);

        public abstract void FileRename(string path, string destination);

        public abstract bool FileExists(string path);

        public abstract ulong FileSize(string path);

        public abstract void FileDelete(string path);
        
        public abstract void FileWriteBytes(string path, byte[] buffer, ulong bufferSize = 0);

        public abstract void FileWrite(string path, Stream stream);
        
        public abstract byte[] FileReadBytes(string path, ulong bufferSize = 0);

        public abstract Stream FileRead(string path);
    }
}