using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_StorageInterface
    {
        private uint version;

        private IntPtr close;

        private IntPtr ready;

        private IntPtr enumerate;

        private IntPtr info;

        private IntPtr read_file;

        private IntPtr write_file;

        private IntPtr mkdir;

        private IntPtr remove;

        private IntPtr rename;

        private IntPtr copy;

        private IntPtr space_remaining;
    }
}