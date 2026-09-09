using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_VirtualJoystickDesc
    {
        private uint version;

        private ushort type;

        private ushort padding;

        private ushort vendor_id;

        private ushort product_id;

        private ushort naxes;

        private ushort nbuttons;

        private ushort nballs;

        private ushort nhats;

        private ushort ntouchpads;

        private ushort nsensors;

        private _padding2_e__FixedBuffer padding2;

        private uint button_mask;

        private uint axis_mask;

        private byte* name;

        private SDL_VirtualJoystickTouchpadDesc* touchpads;

        private SDL_VirtualJoystickSensorDesc* sensors;

        private IntPtr userdata;

        private IntPtr Update;

        private IntPtr SetPlayerIndex;

        private IntPtr Rumble;

        private IntPtr RumbleTriggers;

        private IntPtr SetLED;

        private IntPtr SendEffect;

        private IntPtr SetSensorsEnabled;

        private IntPtr Cleanup;
    }
}