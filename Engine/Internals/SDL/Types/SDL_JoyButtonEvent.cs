using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_JoyButtonEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte button;

        private SDL_Bool down;

        private byte padding1;

        private byte padding2;
    }
}