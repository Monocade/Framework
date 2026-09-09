using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUSamplerCreateInfo
    {
        private SDL_GPUFilter min_filter;

        private SDL_GPUFilter mag_filter;

        private SDL_GPUSamplerMipmapMode mipmap_mode;

        private SDL_GPUSamplerAddressMode address_mode_u;

        private SDL_GPUSamplerAddressMode address_mode_v;

        private SDL_GPUSamplerAddressMode address_mode_w;

        private float mip_lod_bias;

        private float max_anisotropy;

        private SDL_GPUCompareOp compare_op;

        private float min_lod;

        private float max_lod;

        private SDL_Bool enable_anisotropy;

        private SDL_Bool enable_compare;

        private byte padding1;

        private byte padding2;

        private uint props;
    }
}