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

        public uint KeyboardID
        {
            get => which;
            set => which = value;
        }

        public SDL_Scancode Scancode
        {
            get => scancode;
            set => scancode = value;
        }

        public SDL_Keycode Key
        {
            get => (SDL_Keycode)key;
            set => key = (uint)value;
        }

        public SDL_Keymod Mod
        {
            get => (SDL_Keymod)mod;
            set => mod = (ushort)value;
        }

        public ushort Raw
        {
            get => raw;
            set => raw = value;
        }

        public bool Down
        {
            get => down;
            set => down = value;
        }

        public bool Repeat
        {
            get => repeat;
            set => repeat = value;
        }
    }
}