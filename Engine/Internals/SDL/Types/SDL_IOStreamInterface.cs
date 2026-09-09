using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_IOStreamInterface
    {
        private uint version;

        private IntPtr size;

        private IntPtr seek;

        private IntPtr read;

        private IntPtr write;

        private IntPtr flush;

        private IntPtr close;
    }
}