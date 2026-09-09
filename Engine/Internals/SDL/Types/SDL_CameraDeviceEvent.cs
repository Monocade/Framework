using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_CameraDeviceEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;
    }
}