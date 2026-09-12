using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GamepadBinding
    {
        public SDL_GamepadBindingType InputType
        {
            get => input_type;
            set => input_type = value;
        }

        public _input_e__Union Input
        {
            get => input;
            set => input = value;
        }

        public SDL_GamepadBindingType OutputType
        {
            get => output_type;
            set => output_type = value;
        }

        public _output_e__Union Output
        {
            get => output;
            set => output = value;
        }
        
        internal partial struct _input_e__Union
        {
            public int Button
            {
                get => button;
                set => button = value;
            }

            public _axis_e__Struct Axis
            {
                get => axis;
                set => axis = value;
            }

            public _hat_e__Struct Hat
            {
                get => hat;
                set => hat = value;
            }

            internal partial struct _axis_e__Struct
            {
                public int Axis
                {
                    get => axis;
                    set => axis = value;
                }

                public int AxisMin
                {
                    get => axis_min;
                    set => axis_min = value;
                }

                public int AxisMax
                {
                    get => axis_max;
                    set => axis_max = value;
                }
            }

            internal partial struct _hat_e__Struct
            {
                public int Hat
                {
                    get => hat;
                    set => hat = value;
                }

                public int HatMask
                {
                    get => hat_mask;
                    set => hat_mask = value;
                }
            }
        }

        internal partial struct _output_e__Union
        {
            public SDL_GamepadButton Button
            {
                get => button;
                set => button = value;
            }

            public _axis_e__Struct Axis
            {
                get => axis;
                set => axis = value;
            }

            internal partial struct _axis_e__Struct
            {
                public SDL_GamepadAxis Axis
                {
                    get => axis;
                    set => axis = value;
                }

                public int AxisMin
                {
                    get => axis_min;
                    set => axis_min = value;
                }

                public int AxisMax
                {
                    get => axis_max;
                    set => axis_max = value;
                }
            }
        }
    }
}