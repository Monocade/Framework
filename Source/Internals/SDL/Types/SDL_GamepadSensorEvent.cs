using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GamepadSensorEvent
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

        public uint GamepadID
        {
            get => which;
            set => which = value;
        }

        public int Sensor
        {
            get => sensor;
            set => sensor = value;
        }

        public _data_e__FixedBuffer Data
        {
            get => data;
            set => data = value;
        }

        public ulong SensorTimestamp
        {
            get => sensor_timestamp;
            set => sensor_timestamp = value;
        }
    }
}