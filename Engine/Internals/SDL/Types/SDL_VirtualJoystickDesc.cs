using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_VirtualJoystickDesc
    {
        public uint Version
        {
            get => version;
            set => version = value;
        }

        public ushort Type
        {
            get => type;
            set => type = value;
        }

        public ushort Padding
        {
            get => padding;
            set => padding = value;
        }

        public ushort Vendor_id
        {
            get => vendor_id;
            set => vendor_id = value;
        }

        public ushort Product_id
        {
            get => product_id;
            set => product_id = value;
        }

        public ushort Naxes
        {
            get => naxes;
            set => naxes = value;
        }

        public ushort Nbuttons
        {
            get => nbuttons;
            set => nbuttons = value;
        }

        public ushort Nballs
        {
            get => nballs;
            set => nballs = value;
        }

        public ushort Nhats
        {
            get => nhats;
            set => nhats = value;
        }

        public ushort Ntouchpads
        {
            get => ntouchpads;
            set => ntouchpads = value;
        }

        public ushort Nsensors
        {
            get => nsensors;
            set => nsensors = value;
        }

        public _padding2_e__FixedBuffer Padding2
        {
            get => padding2;
            set => padding2 = value;
        }

        public uint Button_mask
        {
            get => button_mask;
            set => button_mask = value;
        }

        public uint Axis_mask
        {
            get => axis_mask;
            set => axis_mask = value;
        }

        public byte* Name
        {
            get => name;
            set => name = value;
        }

        public SDL_VirtualJoystickTouchpadDesc* Touchpads
        {
            get => touchpads;
            set => touchpads = value;
        }

        public SDL_VirtualJoystickSensorDesc* Sensors
        {
            get => sensors;
            set => sensors = value;
        }

        public IntPtr Userdata
        {
            get => userdata;
            set => userdata = value;
        }

        public IntPtr update
        {
            get => Update;
            set => Update = value;
        }

        public IntPtr setPlayerIndex
        {
            get => SetPlayerIndex;
            set => SetPlayerIndex = value;
        }

        public IntPtr rumble
        {
            get => Rumble;
            set => Rumble = value;
        }

        public IntPtr rumbleTriggers
        {
            get => RumbleTriggers;
            set => RumbleTriggers = value;
        }

        public IntPtr setLED
        {
            get => SetLED;
            set => SetLED = value;
        }

        public IntPtr sendEffect
        {
            get => SendEffect;
            set => SendEffect = value;
        }

        public IntPtr setSensorsEnabled
        {
            get => SetSensorsEnabled;
            set => SetSensorsEnabled = value;
        }

        public IntPtr cleanup
        {
            get => Cleanup;
            set => Cleanup = value;
        }
    }
}