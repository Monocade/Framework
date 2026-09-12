using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUBlitInfo
    {
        public SDL_GPUBlitRegion Source
        {
            get => source;
            set => source = value;
        }

        public SDL_GPUBlitRegion Destination
        {
            get => destination;
            set => destination = value;
        }

        public SDL_GPULoadOp LoadOp
        {
            get => load_op;
            set => load_op = value;
        }

        public SDL_FColor ClearColor
        {
            get => clear_color;
            set => clear_color = value;
        }

        public SDL_FlipMode FlipMode
        {
            get => flip_mode;
            set => flip_mode = value;
        }

        public SDL_GPUFilter Filter
        {
            get => filter;
            set => filter = value;
        }

        public bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }
    }
}