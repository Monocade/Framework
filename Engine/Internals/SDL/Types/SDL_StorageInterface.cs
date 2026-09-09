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

        public IntPtr Close
        {
            get => close;
            set => close = value;
        }

        public IntPtr Ready
        {
            get => ready;
            set => ready = value;
        }

        public IntPtr Enumerate
        {
            get => enumerate;
            set => enumerate = value;
        }

        public IntPtr Info
        {
            get => info;
            set => info = value;
        }

        public IntPtr Read_file
        {
            get => read_file;
            set => read_file = value;
        }

        public IntPtr Write_file
        {
            get => write_file;
            set => write_file = value;
        }

        public IntPtr Mkdir
        {
            get => mkdir;
            set => mkdir = value;
        }

        public IntPtr Remove
        {
            get => remove;
            set => remove = value;
        }

        public IntPtr Rename
        {
            get => rename;
            set => rename = value;
        }

        public IntPtr Copy
        {
            get => copy;
            set => copy = value;
        }

        public IntPtr Space_remaining
        {
            get => space_remaining;
            set => space_remaining = value;
        }
    }
}