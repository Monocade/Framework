using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_JoyBatteryEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private SDL_PowerState state;

        private int percent;
    }
}