using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_NotificationAction
    {
        public SDL_NotificationActionType Type
        {
            get => type;
            set => type = value;
        }

        public _button_e__Struct Button
        {
            get => button;
            set => button = value;
        }

        public _padding_e__FixedBuffer Padding
        {
            get => padding;
            set => padding = value;
        }
    }
}