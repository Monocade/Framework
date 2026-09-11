using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal partial struct SDL_IOStreamInterface
    {
        public uint Version
        {
            get => version;
            set => version = value;
        }

        public SDL_IOStreamSizeCallback Size
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_IOStreamSizeCallback>(size);
            set => size = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_IOStreamSeekCallback Seek
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_IOStreamSeekCallback>(seek);
            set => seek = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_IOStreamReadCallback Read
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_IOStreamReadCallback>(read);
            set => read = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_IOStreamWriteCallback Write
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_IOStreamWriteCallback>(write);
            set => write = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_IOStreamFlushCallback Flush
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_IOStreamFlushCallback>(flush);
            set => flush = Marshal.GetFunctionPointerForDelegate(value);
        }

        public SDL_IOStreamCloseCallback Close
        {
            get => Marshal.GetDelegateForFunctionPointer<SDL_IOStreamCloseCallback>(close);
            set => close = Marshal.GetFunctionPointerForDelegate(value);
        }
    }
}