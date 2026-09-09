using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_AsyncIOOutcome
    {
        private SDL_AsyncIO* asyncio;

        private SDL_AsyncIOTaskType type;

        private SDL_AsyncIOResult result;

        private IntPtr buffer;

        private ulong offset;

        private ulong bytes_requested;

        private ulong bytes_transferred;

        private IntPtr userdata;
    }
}