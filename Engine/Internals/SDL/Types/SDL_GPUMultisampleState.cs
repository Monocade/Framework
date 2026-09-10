using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUMultisampleState
    {
        public SDL_GPUSampleCount Sample_count
        {
            get => sample_count;
            set => sample_count = value;
        }

        public uint Sample_mask
        {
            get => sample_mask;
            set => sample_mask = value;
        }

        public bool Enable_mask
        {
            get => enable_mask;
            set => enable_mask = value;
        }

        public bool Enable_alpha_to_coverage
        {
            get => enable_alpha_to_coverage;
            set => enable_alpha_to_coverage = value;
        }
    }
}