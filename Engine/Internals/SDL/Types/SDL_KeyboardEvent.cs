using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_KeyboardEvent
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

        public uint Which
        {
            get => which;
            set => which = value;
        }

        public SDL_Scancode Scancode
        {
            get => scancode;
            set => scancode = value;
        }

        public uint Key
        {
            get => key;
            set => key = value;
        }

        public ushort Mod
        {
            get => mod;
            set => mod = value;
        }

        public ushort Raw
        {
            get => raw;
            set => raw = value;
        }

        public SDL_Bool Down
        {
            get => down;
            set => down = value;
        }

        public SDL_Bool Repeat
        {
            get => repeat;
            set => repeat = value;
        }
    }
}