using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUColorTargetInfo
    {
        private SDL_GPUTexture* texture;

        private uint mip_level;

        private uint layer_or_depth_plane;

        private SDL_FColor clear_color;

        private SDL_GPULoadOp load_op;

        private SDL_GPUStoreOp store_op;

        private SDL_GPUTexture* resolve_texture;

        private uint resolve_mip_level;

        private uint resolve_layer;

        private SDL_Bool cycle;

        private SDL_Bool cycle_resolve_texture;

        private byte padding1;

        private byte padding2;
    }
}