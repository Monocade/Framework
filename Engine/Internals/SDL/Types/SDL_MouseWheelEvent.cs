using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MouseWheelEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private float x;

        private float y;

        private SDL_MouseWheelDirection direction;

        private float mouse_x;

        private float mouse_y;

        private int integer_x;

        private int integer_y;
    }
}