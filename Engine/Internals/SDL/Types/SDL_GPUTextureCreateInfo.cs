using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTextureCreateInfo
    {
        public SDL_GPUTextureType Type
        {
            get => type;
            set => type = value;
        }

        public SDL_GPUTextureFormat Format
        {
            get => format;
            set => format = value;
        }

        public SDL_GPUTextureUsageFlags Usage
        {
            get => (SDL_GPUTextureUsageFlags)usage;
            set => usage = (uint)value;
        }

        public uint Width
        {
            get => width;
            set => width = value;
        }

        public uint Height
        {
            get => height;
            set => height = value;
        }

        public uint Layer_count_or_depth
        {
            get => layer_count_or_depth;
            set => layer_count_or_depth = value;
        }

        public uint Num_levels
        {
            get => num_levels;
            set => num_levels = value;
        }

        public SDL_GPUSampleCount Sample_count
        {
            get => sample_count;
            set => sample_count = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}