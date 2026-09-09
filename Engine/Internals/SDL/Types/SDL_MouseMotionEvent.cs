using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MouseMotionEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private uint state;

        private float x;

        private float y;

        private float xrel;

        private float yrel;
    }
}