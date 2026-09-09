using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_JoyBallEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte ball;

        private byte padding1;

        private byte padding2;

        private byte padding3;

        private short xrel;

        private short yrel;
    }
}