using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_ClipboardEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private SDL_Bool owner;

        private int num_mime_types;

        private byte** mime_types;
    }
}