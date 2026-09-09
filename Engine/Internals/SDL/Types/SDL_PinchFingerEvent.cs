using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_PinchFingerEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private float scale;

        private uint windowID;

        private float span_x;

        private float span_y;

        private float focus_x;

        private float focus_y;
    }
}