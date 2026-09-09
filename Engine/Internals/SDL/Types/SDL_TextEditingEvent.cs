using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_TextEditingEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private byte* text;

        private int start;

        private int length;
    }
}