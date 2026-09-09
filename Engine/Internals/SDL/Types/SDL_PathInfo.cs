using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_PathInfo
    {
        private SDL_PathType type;

        private ulong size;

        private long create_time;

        private long modify_time;

        private long access_time;
    }
}