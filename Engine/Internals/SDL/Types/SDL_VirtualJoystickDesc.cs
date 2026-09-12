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

        public ushort VendorID
        {
            get => vendor_id;
            set => vendor_id = value;
        }

        public ushort ProductID
        {
            get => product_id;
            set => product_id = value;
        }

        public ushort NumAxes
        {
            get => naxes;
            set => naxes = value;
        }

        public ushort NumButtons
        {
            get => nbuttons;
            set => nbuttons = value;
        }

        public ushort NumBalls
        {
            get => nballs;
            set => nballs = value;
        }

        public ushort NumHats
        {
            get => nhats;
            set => nhats = value;
        }

        public ushort NumTouchpads
        {
            get => ntouchpads;
            set => ntouchpads = value;
        }

        public ushort NumSensors
        {
            get => nsensors;
            set => nsensors = value;
        }

        public uint ButtonMask
        {
            get => button_mask;
            set => button_mask = value;
        }

        public uint AxisMask
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

        public IntPtr VirtualUpdate
        {
            get => Update;
            set => Update = value;
        }

        public IntPtr VirtualSetPlayerIndex
        {
            get => SetPlayerIndex;
            set => SetPlayerIndex = value;
        }

        public IntPtr virtualRumble
        {
            get => Rumble;
            set => Rumble = value;
        }

        public IntPtr VirtualRumbleTriggers
        {
            get => RumbleTriggers;
            set => RumbleTriggers = value;
        }

        public IntPtr VirtualSetLED
        {
            get => SetLED;
            set => SetLED = value;
        }

        public IntPtr VirtualSendEffect
        {
            get => SendEffect;
            set => SendEffect = value;
        }

        public IntPtr VirtualSetSensorsEnabled
        {
            get => SetSensorsEnabled;
            set => SetSensorsEnabled = value;
        }

        public IntPtr VirtualCleanup
        {
            get => Cleanup;
            set => Cleanup = value;
        }
    }
}