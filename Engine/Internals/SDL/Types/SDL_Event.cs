using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Event
    {
        public SDL_EventType Type
        {
            get => (SDL_EventType)type;
            set => type = (uint)value;
        }

        public SDL_CommonEvent CommonEvent
        {
            get => common;
            set => common = value;
        }

        public SDL_DisplayEvent DisplayEvent
        {
            get => display;
            set => display = value;
        }

        public SDL_WindowEvent WindowEvent
        {
            get => window;
            set => window = value;
        }

        public SDL_KeyboardDeviceEvent KeyboardDeviceEvent
        {
            get => kdevice;
            set => kdevice = value;
        }

        public SDL_KeyboardEvent KeyboardEvent
        {
            get => key;
            set => key = value;
        }

        public SDL_TextEditingEvent TextEditingEvent
        {
            get => edit;
            set => edit = value;
        }

        public SDL_TextEditingCandidatesEvent TextEditingCandidatesEvent
        {
            get => edit_candidates;
            set => edit_candidates = value;
        }

        public SDL_TextInputEvent TextInputEvent
        {
            get => text;
            set => text = value;
        }

        public SDL_MouseDeviceEvent MouseDeviceEvent
        {
            get => mdevice;
            set => mdevice = value;
        }

        public SDL_MouseMotionEvent MouseMotionEvent
        {
            get => motion;
            set => motion = value;
        }

        public SDL_MouseButtonEvent MouseButtonEvent
        {
            get => button;
            set => button = value;
        }

        public SDL_MouseWheelEvent MouseWheelEvent
        {
            get => wheel;
            set => wheel = value;
        }

        public SDL_JoyDeviceEvent JoystickDeviceEvent
        {
            get => jdevice;
            set => jdevice = value;
        }

        public SDL_JoyAxisEvent JoystickAxisEvent
        {
            get => jaxis;
            set => jaxis = value;
        }

        public SDL_JoyBallEvent JoystickBallEvent
        {
            get => jball;
            set => jball = value;
        }

        public SDL_JoyHatEvent JoystickHatEvent
        {
            get => jhat;
            set => jhat = value;
        }

        public SDL_JoyButtonEvent JoystickButtonEvent
        {
            get => jbutton;
            set => jbutton = value;
        }

        public SDL_JoyBatteryEvent JoystickBatteryEvent
        {
            get => jbattery;
            set => jbattery = value;
        }

        public SDL_GamepadDeviceEvent GamepadDeviceEvent
        {
            get => gdevice;
            set => gdevice = value;
        }

        public SDL_GamepadAxisEvent GamepadAxisEvent
        {
            get => gaxis;
            set => gaxis = value;
        }

        public SDL_GamepadButtonEvent GamepadButtonEvent
        {
            get => gbutton;
            set => gbutton = value;
        }

        public SDL_GamepadTouchpadEvent GamepadTouchpadEvent
        {
            get => gtouchpad;
            set => gtouchpad = value;
        }

        public SDL_GamepadSensorEvent GamepadSensorEvent
        {
            get => gsensor;
            set => gsensor = value;
        }

        public SDL_GamepadCapSenseEvent GamepadCapSenseEvent
        {
            get => gcapsense;
            set => gcapsense = value;
        }

        public SDL_AudioDeviceEvent AudioDeviceEvent
        {
            get => adevice;
            set => adevice = value;
        }

        public SDL_CameraDeviceEvent CameraDeviceEvent
        {
            get => cdevice;
            set => cdevice = value;
        }

        public SDL_SensorEvent SensorEvent
        {
            get => sensor;
            set => sensor = value;
        }

        public SDL_QuitEvent QuitEvent
        {
            get => quit;
            set => quit = value;
        }

        public SDL_UserEvent UserEvent
        {
            get => user;
            set => user = value;
        }

        public SDL_TouchFingerEvent TouchFingerEvent
        {
            get => tfinger;
            set => tfinger = value;
        }

        public SDL_PinchFingerEvent PinchFingerEvent
        {
            get => pinch;
            set => pinch = value;
        }

        public SDL_PenProximityEvent PenProximityEvent
        {
            get => pproximity;
            set => pproximity = value;
        }

        public SDL_PenTouchEvent PenTouchEvent
        {
            get => ptouch;
            set => ptouch = value;
        }

        public SDL_PenMotionEvent PenMotionEvent
        {
            get => pmotion;
            set => pmotion = value;
        }

        public SDL_PenButtonEvent PenButtonEvent
        {
            get => pbutton;
            set => pbutton = value;
        }

        public SDL_PenAxisEvent PenAxisEvent
        {
            get => paxis;
            set => paxis = value;
        }

        public SDL_RenderEvent RenderEvent
        {
            get => render;
            set => render = value;
        }

        public SDL_DropEvent DropEvent
        {
            get => drop;
            set => drop = value;
        }

        public SDL_ClipboardEvent ClipboardEvent
        {
            get => clipboard;
            set => clipboard = value;
        }

        public SDL_NotificationEvent NotificationEvent
        {
            get => notification;
            set => notification = value;
        }
    }
}