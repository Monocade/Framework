using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_IOStreamInterface
    {
        public uint Version
        {
            get => version;
            set => version = value;
        }

        public IntPtr Size
        {
            get => size;
            set => size = value;
        }

        public IntPtr Seek
        {
            get => seek;
            set => seek = value;
        }

        public IntPtr Read
        {
            get => read;
            set => read = value;
        }

        public IntPtr Write
        {
            get => write;
            set => write = value;
        }

        public IntPtr Flush
        {
            get => flush;
            set => flush = value;
        }

        public IntPtr Close
        {
            get => close;
            set => close = value;
        }
    }
}