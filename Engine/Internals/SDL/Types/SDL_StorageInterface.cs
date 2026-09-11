using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_StorageInterface
    {
        public uint Version
        {
            get => version;
            set => version = value;
        }

        public SDL_StorageCloseCallback Close
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageCloseCallback>(close);
            set => close = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageReadyCallback Ready
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageReadyCallback>(ready);
            set => ready = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageEnumerateCallback Enumerate
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageEnumerateCallback>(enumerate);
            set => enumerate = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageInfoCallback Info
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageInfoCallback>(info);
            set => info = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageReadFileCallback ReadFile
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageReadFileCallback>(read_file);
            set => read_file = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageWriteFileCallback WriteFile
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageWriteFileCallback>(write_file);
            set => write_file = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageMkdirCallback Mkdir
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageMkdirCallback>(mkdir);
            set => mkdir = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageRemoveCallback Remove
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageRemoveCallback>(remove);
            set => remove = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageRenameCallback Rename
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageRenameCallback>(rename);
            set => rename = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageCopyCallback Copy
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageCopyCallback>(copy);
            set => copy = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_StorageSpaceRemainingCallback SpaceRemaining
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_StorageSpaceRemainingCallback>(space_remaining);
            set => space_remaining = Marshal.GetFunctionPointerForDelegate(value);
        }
    }
}