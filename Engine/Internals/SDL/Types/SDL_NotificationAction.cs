using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_NotificationAction
    {
        [FieldOffset(0)]
        private SDL_NotificationActionType type;

        [FieldOffset(0)]
        private _button_e__Struct button;

        [FieldOffset(0)]
        private _padding_e__FixedBuffer padding;
    }
}