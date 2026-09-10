using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_ClipboardEvent
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

        public bool Owner
        {
            get => owner;
            set => owner = value;
        }

        public int Num_mime_types
        {
            get => num_mime_types;
            set => num_mime_types = value;
        }

        public byte** Mime_types
        {
            get => mime_types;
            set => mime_types = value;
        }
    }
}