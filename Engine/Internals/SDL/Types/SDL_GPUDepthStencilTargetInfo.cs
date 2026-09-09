using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUDepthStencilTargetInfo
    {
        public SDL_GPUTexture* Texture
        {
            get => texture;
            set => texture = value;
        }

        public float Clear_depth
        {
            get => clear_depth;
            set => clear_depth = value;
        }

        public SDL_GPULoadOp Load_op
        {
            get => load_op;
            set => load_op = value;
        }

        public SDL_GPUStoreOp Store_op
        {
            get => store_op;
            set => store_op = value;
        }

        public SDL_GPULoadOp Stencil_load_op
        {
            get => stencil_load_op;
            set => stencil_load_op = value;
        }

        public SDL_GPUStoreOp Stencil_store_op
        {
            get => stencil_store_op;
            set => stencil_store_op = value;
        }

        public SDL_Bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }

        public byte Clear_stencil
        {
            get => clear_stencil;
            set => clear_stencil = value;
        }

        public byte Mip_level
        {
            get => mip_level;
            set => mip_level = value;
        }

        public byte Layer
        {
            get => layer;
            set => layer = value;
        }
    }
}