using System;

namespace Engine
{
    // SDL Storage Provider
    public sealed unsafe class SDLStorageProvider(App app) : StorageProvider(app)
    {
        public override string PrefPath(string app, string name) => SDL_GetPrefPath(app, name);
        
        public override string Normalize(string path) => path.Replace("\\", "/");
        
        public override string BasePath => SDL_GetBasePath();
        
        public override string UserPath(UserFolder folder)
        {
            return SDL_GetUserFolder(folder switch
            {
                UserFolder.Desktop => SDL_Folder.SDL_FOLDER_DESKTOP,
                UserFolder.Documents => SDL_Folder.SDL_FOLDER_DOCUMENTS,
                UserFolder.Downloads => SDL_Folder.SDL_FOLDER_DOWNLOADS,
                UserFolder.Music => SDL_Folder.SDL_FOLDER_MUSIC,
                UserFolder.Pictures => SDL_Folder.SDL_FOLDER_PICTURES,
                UserFolder.Videos => SDL_Folder.SDL_FOLDER_VIDEOS,

                _ => throw new Exception($"User folder {folder} is not valid")
            });
        }
        
        
        public override StorageContainer OpenUserStorage(string app, string user)
        {
            return new SDLStorageContainer(App, (IntPtr)SDL_OpenUserStorage(app, user, 0));
        }

        public override StorageContainer OpenTitleStorage(string path)
        {
            return new SDLStorageContainer(App, (IntPtr)SDL_OpenTitleStorage(path, 0));
        }

        public override StorageContainer OpenFileStorage(string path)
        {
            return new SDLStorageContainer(App, (IntPtr)SDL_OpenFileStorage(path));
        }
        
        public override void CloseStorage(StorageContainer container)
        {
            container?.Dispose();
        }
    }
}