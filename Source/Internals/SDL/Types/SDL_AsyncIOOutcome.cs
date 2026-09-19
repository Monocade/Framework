using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_AsyncIOOutcome
    {
        public SDL_AsyncIO* Asyncio
        {
            get => asyncio;
            set => asyncio = value;
        }

        public SDL_AsyncIOTaskType Type
        {
            get => type;
            set => type = value;
        }

        public SDL_AsyncIOResult Result
        {
            get => result;
            set => result = value;
        }

        public IntPtr Buffer
        {
            get => buffer;
            set => buffer = value;
        }

        public ulong Offset
        {
            get => offset;
            set => offset = value;
        }

        public ulong BytesRequested
        {
            get => bytes_requested;
            set => bytes_requested = value;
        }

        public ulong BytesTransferred
        {
            get => bytes_transferred;
            set => bytes_transferred = value;
        }

        public IntPtr Userdata
        {
            get => userdata;
            set => userdata = value;
        }
    }
}