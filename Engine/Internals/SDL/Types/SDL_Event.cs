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

        public SDL_CommonEvent Common
        {
            get => common;
            set => common = value;
        }

        public SDL_DisplayEvent Display
        {
            get => display;
            set => display = value;
        }

        public SDL_WindowEvent Window
        {
            get => window;
            set => window = value;
        }

        public SDL_KeyboardDeviceEvent KeyboardDevice
        {
            get => kdevice;
            set => kdevice = value;
        }

        public SDL_KeyboardEvent Keyboard
        {
            get => key;
            set => key = value;
        }

        public SDL_TextEditingEvent TextEditing
        {
            get => edit;
            set => edit = value;
        }

        public SDL_TextEditingCandidatesEvent TextEditingCandidates
        {
            get => edit_candidates;
            set => edit_candidates = value;
        }

        public SDL_TextInputEvent TextInput
        {
            get => text;
            set => text = value;
        }

        public SDL_MouseDeviceEvent MouseDevice
        {
            get => mdevice;
            set => mdevice = value;
        }

        public SDL_MouseMotionEvent MouseMotion
        {
            get => motion;
            set => motion = value;
        }

        public SDL_MouseButtonEvent MouseButton
        {
            get => button;
            set => button = value;
        }

        public SDL_MouseWheelEvent MouseWheel
        {
            get => wheel;
            set => wheel = value;
        }

        public SDL_JoyDeviceEvent JoystickDevice
        {
            get => jdevice;
            set => jdevice = value;
        }

        public SDL_JoyAxisEvent JoystickAxis
        {
            get => jaxis;
            set => jaxis = value;
        }

        public SDL_JoyBallEvent JoystickBall
        {
            get => jball;
            set => jball = value;
        }

        public SDL_JoyHatEvent JoystickHat
        {
            get => jhat;
            set => jhat = value;
        }

        public SDL_JoyButtonEvent JoystickButton
        {
            get => jbutton;
            set => jbutton = value;
        }

        public SDL_JoyBatteryEvent JoystickBattery
        {
            get => jbattery;
            set => jbattery = value;
        }

        public SDL_GamepadDeviceEvent GamepadDevice
        {
            get => gdevice;
            set => gdevice = value;
        }

        public SDL_GamepadAxisEvent GamepadAxis
        {
            get => gaxis;
            set => gaxis = value;
        }

        public SDL_GamepadButtonEvent GamepadButton
        {
            get => gbutton;
            set => gbutton = value;
        }

        public SDL_GamepadTouchpadEvent GamepadTouchpad
        {
            get => gtouchpad;
            set => gtouchpad = value;
        }

        public SDL_GamepadSensorEvent GamepadSensor
        {
            get => gsensor;
            set => gsensor = value;
        }

        public SDL_GamepadCapSenseEvent GampadCapSense
        {
            get => gcapsense;
            set => gcapsense = value;
        }

        public SDL_AudioDeviceEvent AudioDevice
        {
            get => adevice;
            set => adevice = value;
        }

        public SDL_CameraDeviceEvent CameraDevice
        {
            get => cdevice;
            set => cdevice = value;
        }

        public SDL_SensorEvent Sensor
        {
            get => sensor;
            set => sensor = value;
        }

        public SDL_QuitEvent Quit
        {
            get => quit;
            set => quit = value;
        }

        public SDL_UserEvent User
        {
            get => user;
            set => user = value;
        }

        public SDL_TouchFingerEvent TouchFinger
        {
            get => tfinger;
            set => tfinger = value;
        }

        public SDL_PinchFingerEvent PinchFinger
        {
            get => pinch;
            set => pinch = value;
        }

        public SDL_PenProximityEvent PenProximity
        {
            get => pproximity;
            set => pproximity = value;
        }

        public SDL_PenTouchEvent PenTouch
        {
            get => ptouch;
            set => ptouch = value;
        }

        public SDL_PenMotionEvent PenMotion
        {
            get => pmotion;
            set => pmotion = value;
        }

        public SDL_PenButtonEvent PenButton
        {
            get => pbutton;
            set => pbutton = value;
        }

        public SDL_PenAxisEvent PenAxis
        {
            get => paxis;
            set => paxis = value;
        }

        public SDL_RenderEvent Render
        {
            get => render;
            set => render = value;
        }

        public SDL_DropEvent Drop
        {
            get => drop;
            set => drop = value;
        }

        public SDL_ClipboardEvent Clipboard
        {
            get => clipboard;
            set => clipboard = value;
        }

        public SDL_NotificationEvent Notification
        {
            get => notification;
            set => notification = value;
        }
    }
}