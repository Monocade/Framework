using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MouseWheelEvent
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

        public SDL_MouseWheelDirection Direction
        {
            get => direction;
            set => direction = value;
        }

        public float MouseX
        {
            get => mouse_x;
            set => mouse_x = value;
        }

        public float MouseY
        {
            get => mouse_y;
            set => mouse_y = value;
        }

        public int IntegerX
        {
            get => integer_x;
            set => integer_x = value;
        }

        public int IntegerY
        {
            get => integer_y;
            set => integer_y = value;
        }
    }
}