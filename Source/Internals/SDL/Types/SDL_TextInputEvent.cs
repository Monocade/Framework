using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_TextInputEvent
    {
        public SDL_EventType Type
        {
            get => type;
            set => type = value;
        }

        public uint Reserved
        {
            get => reserved;
            set => reserved = value;
        }

        public ulong Timestamp
        {
            get => timestamp;
            set => timestamp = value;
        }

        public uint WindowID
        {
            get => windowID;
            set => windowID = value;
        }

        public byte* Text
        {
            get => text;
            set => text = value;
        }
    }
}