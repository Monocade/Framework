using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MouseButtonEvent
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

        public byte Button
        {
            get => button;
            set => button = value;
        }

        public bool Down
        {
            get => down;
            set => down = value;
        }

        public byte Clicks
        {
            get => clicks;
            set => clicks = value;
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
    }
}