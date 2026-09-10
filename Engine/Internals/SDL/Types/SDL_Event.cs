using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Event
    {
        public uint Type
        {
            get => type;
            set => type = value;
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

        public SDL_KeyboardDeviceEvent Kdevice
        {
            get => kdevice;
            set => kdevice = value;
        }

        public SDL_KeyboardEvent Key
        {
            get => key;
            set => key = value;
        }

        public SDL_TextEditingEvent Edit
        {
            get => edit;
            set => edit = value;
        }

        public SDL_TextEditingCandidatesEvent Edit_candidates
        {
            get => edit_candidates;
            set => edit_candidates = value;
        }

        public SDL_TextInputEvent Text
        {
            get => text;
            set => text = value;
        }

        public SDL_MouseDeviceEvent Mdevice
        {
            get => mdevice;
            set => mdevice = value;
        }

        public SDL_MouseMotionEvent Motion
        {
            get => motion;
            set => motion = value;
        }

        public SDL_MouseButtonEvent Button
        {
            get => button;
            set => button = value;
        }

        public SDL_MouseWheelEvent Wheel
        {
            get => wheel;
            set => wheel = value;
        }

        public SDL_JoyDeviceEvent Jdevice
        {
            get => jdevice;
            set => jdevice = value;
        }

        public SDL_JoyAxisEvent Jaxis
        {
            get => jaxis;
            set => jaxis = value;
        }

        public SDL_JoyBallEvent Jball
        {
            get => jball;
            set => jball = value;
        }

        public SDL_JoyHatEvent Jhat
        {
            get => jhat;
            set => jhat = value;
        }

        public SDL_JoyButtonEvent Jbutton
        {
            get => jbutton;
            set => jbutton = value;
        }

        public SDL_JoyBatteryEvent Jbattery
        {
            get => jbattery;
            set => jbattery = value;
        }

        public SDL_GamepadDeviceEvent Gdevice
        {
            get => gdevice;
            set => gdevice = value;
        }

        public SDL_GamepadAxisEvent Gaxis
        {
            get => gaxis;
            set => gaxis = value;
        }

        public SDL_GamepadButtonEvent Gbutton
        {
            get => gbutton;
            set => gbutton = value;
        }

        public SDL_GamepadTouchpadEvent Gtouchpad
        {
            get => gtouchpad;
            set => gtouchpad = value;
        }

        public SDL_GamepadSensorEvent Gsensor
        {
            get => gsensor;
            set => gsensor = value;
        }

        public SDL_GamepadCapSenseEvent Gcapsense
        {
            get => gcapsense;
            set => gcapsense = value;
        }

        public SDL_AudioDeviceEvent Adevice
        {
            get => adevice;
            set => adevice = value;
        }

        public SDL_CameraDeviceEvent Cdevice
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

        public SDL_TouchFingerEvent Tfinger
        {
            get => tfinger;
            set => tfinger = value;
        }

        public SDL_PinchFingerEvent Pinch
        {
            get => pinch;
            set => pinch = value;
        }

        public SDL_PenProximityEvent Pproximity
        {
            get => pproximity;
            set => pproximity = value;
        }

        public SDL_PenTouchEvent Ptouch
        {
            get => ptouch;
            set => ptouch = value;
        }

        public SDL_PenMotionEvent Pmotion
        {
            get => pmotion;
            set => pmotion = value;
        }

        public SDL_PenButtonEvent Pbutton
        {
            get => pbutton;
            set => pbutton = value;
        }

        public SDL_PenAxisEvent Paxis
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