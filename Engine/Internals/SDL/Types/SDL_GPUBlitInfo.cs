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

        public SDL_GPULoadOp Load_op
        {
            get => load_op;
            set => load_op = value;
        }

        public SDL_FColor Clear_color
        {
            get => clear_color;
            set => clear_color = value;
        }

        public SDL_FlipMode Flip_mode
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

        public byte Padding3
        {
            get => padding3;
            set => padding3 = value;
        }
    }
}