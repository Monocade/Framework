using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_TouchFingerEvent
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

        public ulong TouchID
        {
            get => touchID;
            set => touchID = value;
        }

        public ulong FingerID
        {
            get => fingerID;
            set => fingerID = value;
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

        public float Dx
        {
            get => dx;
            set => dx = value;
        }

        public float Dy
        {
            get => dy;
            set => dy = value;
        }

        public float Pressure
        {
            get => pressure;
            set => pressure = value;
        }

        public uint WindowID
        {
            get => windowID;
            set => windowID = value;
        }
    }
}