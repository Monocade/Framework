using System;

namespace Engine
{
    // Storage Provider
    public abstract class StorageProvider(App app)
    {
        protected readonly App App = app;
        
        public abstract string PrefPath(string app, string name);
        
        public abstract string UserPath(UserFolder userFolder);
        
        public abstract string Normalize(string path);
        
        public abstract string BasePath { get; }
        
        
        public abstract StorageContainer OpenUserStorage(string app, string user);
        
        public abstract StorageContainer OpenTitleStorage(string path);
        
        public abstract StorageContainer OpenFileStorage(string path);
        
        public abstract void CloseStorage(StorageContainer container);
    }
}