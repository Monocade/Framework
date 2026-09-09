using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GamepadAxisEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte axis;

        private byte padding1;

        private byte padding2;

        private byte padding3;

        private short value;

        private ushort padding4;
    }
}