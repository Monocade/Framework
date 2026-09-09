using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Event
    {
[FieldOffset(0)]
        private uint type;

        [FieldOffset(0)]
        private SDL_CommonEvent common;

        [FieldOffset(0)]
        private SDL_DisplayEvent display;

        [FieldOffset(0)]
        private SDL_WindowEvent window;

        [FieldOffset(0)]
        private SDL_KeyboardDeviceEvent kdevice;

        [FieldOffset(0)]
        private SDL_KeyboardEvent key;

        [FieldOffset(0)]
        private SDL_TextEditingEvent edit;

        [FieldOffset(0)]
        private SDL_TextEditingCandidatesEvent edit_candidates;

        [FieldOffset(0)]
        private SDL_TextInputEvent text;

        [FieldOffset(0)]
        private SDL_MouseDeviceEvent mdevice;

        [FieldOffset(0)]
        private SDL_MouseMotionEvent motion;

        [FieldOffset(0)]
        private SDL_MouseButtonEvent button;

        [FieldOffset(0)]
        private SDL_MouseWheelEvent wheel;

        [FieldOffset(0)]
        private SDL_JoyDeviceEvent jdevice;

        [FieldOffset(0)]
        private SDL_JoyAxisEvent jaxis;

        [FieldOffset(0)]
        private SDL_JoyBallEvent jball;

        [FieldOffset(0)]
        private SDL_JoyHatEvent jhat;

        [FieldOffset(0)]
        private SDL_JoyButtonEvent jbutton;

        [FieldOffset(0)]
        private SDL_JoyBatteryEvent jbattery;

        [FieldOffset(0)]
        private SDL_GamepadDeviceEvent gdevice;

        [FieldOffset(0)]
        private SDL_GamepadAxisEvent gaxis;

        [FieldOffset(0)]
        private SDL_GamepadButtonEvent gbutton;

        [FieldOffset(0)]
        private SDL_GamepadTouchpadEvent gtouchpad;

        [FieldOffset(0)]
        private SDL_GamepadSensorEvent gsensor;

        [FieldOffset(0)]
        private SDL_GamepadCapSenseEvent gcapsense;

        [FieldOffset(0)]
        private SDL_AudioDeviceEvent adevice;

        [FieldOffset(0)]
        private SDL_CameraDeviceEvent cdevice;

        [FieldOffset(0)]
        private SDL_SensorEvent sensor;

        [FieldOffset(0)]
        private SDL_QuitEvent quit;

        [FieldOffset(0)]
        private SDL_UserEvent user;

        [FieldOffset(0)]
        private SDL_TouchFingerEvent tfinger;

        [FieldOffset(0)]
        private SDL_PinchFingerEvent pinch;

        [FieldOffset(0)]
        private SDL_PenProximityEvent pproximity;

        [FieldOffset(0)]
        private SDL_PenTouchEvent ptouch;

        [FieldOffset(0)]
        private SDL_PenMotionEvent pmotion;

        [FieldOffset(0)]
        private SDL_PenButtonEvent pbutton;

        [FieldOffset(0)]
        private SDL_PenAxisEvent paxis;

        [FieldOffset(0)]
        private SDL_RenderEvent render;

        [FieldOffset(0)]
        private SDL_DropEvent drop;

        [FieldOffset(0)]
        private SDL_ClipboardEvent clipboard;

        [FieldOffset(0)]
        private SDL_NotificationEvent notification;

        [FieldOffset(0)]
        private _padding_e__FixedBuffer padding;
    }
}