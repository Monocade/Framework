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

        public uint Which
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

        public float Mouse_x
        {
            get => mouse_x;
            set => mouse_x = value;
        }

        public float Mouse_y
        {
            get => mouse_y;
            set => mouse_y = value;
        }

        public int Integer_x
        {
            get => integer_x;
            set => integer_x = value;
        }

        public int Integer_y
        {
            get => integer_y;
            set => integer_y = value;
        }
    }
}