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

        public SDL_UpdateDelegate JoystickUpdate
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_UpdateDelegate>(Update);
            set => Update = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_SetPlayerIndexDelegate JoystickSetPlayerIndex
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_SetPlayerIndexDelegate>(SetPlayerIndex);
            set => SetPlayerIndex = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_RumbleDelegate JoystickRumble
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_RumbleDelegate>(Rumble);
            set => Rumble = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_RumbleTriggersDelegate JoystickRumbleTriggers
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_RumbleTriggersDelegate>(RumbleTriggers);
            set => RumbleTriggers = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_SetLEDDelegate JoystickSetLED
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_SetLEDDelegate>(SetLED);
            set => SetLED = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_SendEffectDelegate JoystickSendEffect
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_SendEffectDelegate>(SendEffect);
            set => SendEffect = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_SetSensorsEnabledDelegate JoystickSetSensorsEnabled
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_SetSensorsEnabledDelegate>(SetSensorsEnabled);
            set => SetSensorsEnabled = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_CleanupDelegate JoystickCleanup
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_CleanupDelegate>(Cleanup);
            set => Cleanup = Marshal.GetFunctionPointerForDelegate(value);
        }
    }
}