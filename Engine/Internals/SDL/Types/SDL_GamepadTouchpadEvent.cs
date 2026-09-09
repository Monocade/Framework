using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GamepadTouchpadEvent
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

        public uint Which
        {
            get => which;
            set => which = value;
        }

        public int Touchpad
        {
            get => touchpad;
            set => touchpad = value;
        }

        public int Finger
        {
            get => finger;
            set => finger = value;
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

        public float Pressure
        {
            get => pressure;
            set => pressure = value;
        }
    }
}