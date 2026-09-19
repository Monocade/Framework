using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_DropEvent
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

        public float X
        {
            get => x;
            set => x = value;
        }

        public float Y
        {
            get => y;
            set => y = value;
        }

        public byte* Source
        {
            get => source;
            set => source = value;
        }

        public byte* Data
        {
            get => data;
            set => data = value;
        }
    }
}