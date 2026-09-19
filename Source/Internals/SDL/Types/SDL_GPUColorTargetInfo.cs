using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUColorTargetInfo
    {
        public SDL_GPUTexture* Texture
        {
            get => texture;
            set => texture = value;
        }

        public uint MipLevel
        {
            get => mip_level;
            set => mip_level = value;
        }

        public uint LayerOrDepthPlane
        {
            get => layer_or_depth_plane;
            set => layer_or_depth_plane = value;
        }

        public SDL_FColor ClearColor
        {
            get => clear_color;
            set => clear_color = value;
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

        public SDL_GPUTexture* ResolveTexture
        {
            get => resolve_texture;
            set => resolve_texture = value;
        }

        public uint ResolveMipLevel
        {
            get => resolve_mip_level;
            set => resolve_mip_level = value;
        }

        public uint ResolveLayer
        {
            get => resolve_layer;
            set => resolve_layer = value;
        }

        public bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }

        public bool CycleResolveTexture
        {
            get => cycle_resolve_texture;
            set => cycle_resolve_texture = value;
        }
    }
}