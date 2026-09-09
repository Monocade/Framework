using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTextureCreateInfo
    {
        private SDL_GPUTextureType type;

        private SDL_GPUTextureFormat format;

        private uint usage;

        private uint width;

        private uint height;

        private uint layer_count_or_depth;

        private uint num_levels;

        private SDL_GPUSampleCount sample_count;

        private uint props;
    }
}