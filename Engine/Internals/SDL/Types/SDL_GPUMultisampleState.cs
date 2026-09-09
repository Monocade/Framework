using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUMultisampleState
    {
        private SDL_GPUSampleCount sample_count;

        private uint sample_mask;

        private SDL_Bool enable_mask;

        private SDL_Bool enable_alpha_to_coverage;

        private byte padding2;

        private byte padding3;
    }
}