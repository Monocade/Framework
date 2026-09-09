using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUSamplerCreateInfo
    {
        public SDL_GPUFilter Min_filter
        {
            get => min_filter;
            set => min_filter = value;
        }

        public SDL_GPUFilter Mag_filter
        {
            get => mag_filter;
            set => mag_filter = value;
        }

        public SDL_GPUSamplerMipmapMode Mipmap_mode
        {
            get => mipmap_mode;
            set => mipmap_mode = value;
        }

        public SDL_GPUSamplerAddressMode Address_mode_u
        {
            get => address_mode_u;
            set => address_mode_u = value;
        }

        public SDL_GPUSamplerAddressMode Address_mode_v
        {
            get => address_mode_v;
            set => address_mode_v = value;
        }

        public SDL_GPUSamplerAddressMode Address_mode_w
        {
            get => address_mode_w;
            set => address_mode_w = value;
        }

        public float Mip_lod_bias
        {
            get => mip_lod_bias;
            set => mip_lod_bias = value;
        }

        public float Max_anisotropy
        {
            get => max_anisotropy;
            set => max_anisotropy = value;
        }

        public SDL_GPUCompareOp Compare_op
        {
            get => compare_op;
            set => compare_op = value;
        }

        public float Min_lod
        {
            get => min_lod;
            set => min_lod = value;
        }

        public float Max_lod
        {
            get => max_lod;
            set => max_lod = value;
        }

        public SDL_Bool Enable_anisotropy
        {
            get => enable_anisotropy;
            set => enable_anisotropy = value;
        }

        public SDL_Bool Enable_compare
        {
            get => enable_compare;
            set => enable_compare = value;
        }

        public byte Padding1
        {
            get => padding1;
            set => padding1 = value;
        }

        public byte Padding2
        {
            get => padding2;
            set => padding2 = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}