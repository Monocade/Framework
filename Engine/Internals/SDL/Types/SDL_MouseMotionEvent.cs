using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MouseMotionEvent
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

        public uint MouseID
        {
            get => which;
            set => which = value;
        }

        public SDL_MouseButtonFlags State
        {
            get => (SDL_MouseButtonFlags)state;
            set => state = (uint)value;
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

        public float Xrel
        {
            get => xrel;
            set => xrel = value;
        }

        public float Yrel
        {
            get => yrel;
            set => yrel = value;
        }
    }
}