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

        public uint Mip_level
        {
            get => mip_level;
            set => mip_level = value;
        }

        public uint Layer_or_depth_plane
        {
            get => layer_or_depth_plane;
            set => layer_or_depth_plane = value;
        }

        public SDL_FColor Clear_color
        {
            get => clear_color;
            set => clear_color = value;
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

        public SDL_GPUTexture* Resolve_texture
        {
            get => resolve_texture;
            set => resolve_texture = value;
        }

        public uint Resolve_mip_level
        {
            get => resolve_mip_level;
            set => resolve_mip_level = value;
        }

        public uint Resolve_layer
        {
            get => resolve_layer;
            set => resolve_layer = value;
        }

        public bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }

        public bool Cycle_resolve_texture
        {
            get => cycle_resolve_texture;
            set => cycle_resolve_texture = value;
        }
    }
}