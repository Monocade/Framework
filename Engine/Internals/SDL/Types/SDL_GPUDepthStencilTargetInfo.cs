using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUDepthStencilTargetInfo
    {
        private SDL_GPUTexture* texture;

        private float clear_depth;

        private SDL_GPULoadOp load_op;

        private SDL_GPUStoreOp store_op;

        private SDL_GPULoadOp stencil_load_op;

        private SDL_GPUStoreOp stencil_store_op;

        private SDL_Bool cycle;

        private byte clear_stencil;

        private byte mip_level;

        private byte layer;
    }
}