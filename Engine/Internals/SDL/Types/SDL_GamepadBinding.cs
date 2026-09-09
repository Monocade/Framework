using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GamepadBinding
    {
        private SDL_GamepadBindingType input_type;

        private _input_e__Union input;

        private SDL_GamepadBindingType output_type;

        private _output_e__Union output;
    }
}