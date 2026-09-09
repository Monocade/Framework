using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_TouchFingerEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private ulong touchID;

        private ulong fingerID;

        private float x;

        private float y;

        private float dx;

        private float dy;

        private float pressure;

        private uint windowID;
    }
}