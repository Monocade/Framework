using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUSamplerCreateInfo
    {
        public SDL_GPUFilter MinFilter
        {
            get => min_filter;
            set => min_filter = value;
        }

        public SDL_GPUFilter MagFilter
        {
            get => mag_filter;
            set => mag_filter = value;
        }

        public SDL_GPUSamplerMipmapMode MipmapMode
        {
            get => mipmap_mode;
            set => mipmap_mode = value;
        }

        public SDL_GPUSamplerAddressMode AddressModeU
        {
            get => address_mode_u;
            set => address_mode_u = value;
        }

        public SDL_GPUSamplerAddressMode AddressModeV
        {
            get => address_mode_v;
            set => address_mode_v = value;
        }

        public SDL_GPUSamplerAddressMode AddressModeW
        {
            get => address_mode_w;
            set => address_mode_w = value;
        }

        public float MipLodBias
        {
            get => mip_lod_bias;
            set => mip_lod_bias = value;
        }

        public float MaxAnisotropy
        {
            get => max_anisotropy;
            set => max_anisotropy = value;
        }

        public SDL_GPUCompareOp CompareOp
        {
            get => compare_op;
            set => compare_op = value;
        }

        public float MinLod
        {
            get => min_lod;
            set => min_lod = value;
        }

        public float MaxLod
        {
            get => max_lod;
            set => max_lod = value;
        }

        public bool EnableAnisotropy
        {
            get => enable_anisotropy;
            set => enable_anisotropy = value;
        }

        public bool EnableCompare
        {
            get => enable_compare;
            set => enable_compare = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}