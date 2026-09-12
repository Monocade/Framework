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

        public float ClearDepth
        {
            get => clear_depth;
            set => clear_depth = value;
        }

        public SDL_GPULoadOp LoadOp
        {
            get => load_op;
            set => load_op = value;
        }

        public SDL_GPUStoreOp StoreOp
        {
            get => store_op;
            set => store_op = value;
        }

        public SDL_GPULoadOp StencilLoadOp
        {
            get => stencil_load_op;
            set => stencil_load_op = value;
        }

        public SDL_GPUStoreOp StencilStoreOp
        {
            get => stencil_store_op;
            set => stencil_store_op = value;
        }

        public bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }

        public byte ClearStencil
        {
            get => clear_stencil;
            set => clear_stencil = value;
        }

        public byte MipLevel
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