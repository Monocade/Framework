using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUMultisampleState
    {
        public SDL_GPUSampleCount SampleCount
        {
            get => sample_count;
            set => sample_count = value;
        }

        public uint SampleMask
        {
            get => sample_mask;
            set => sample_mask = value;
        }

        public bool EnableMask
        {
            get => enable_mask;
            set => enable_mask = value;
        }

        public bool EnableAlphaToCoverage
        {
            get => enable_alpha_to_coverage;
            set => enable_alpha_to_coverage = value;
        }
    }
}