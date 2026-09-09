using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_KeyboardEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private SDL_Scancode scancode;

        private uint key;

        private ushort mod;

        private ushort raw;

        private SDL_Bool down;

        private SDL_Bool repeat;
    }
}