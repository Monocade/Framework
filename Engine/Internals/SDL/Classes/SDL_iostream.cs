using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_IOStream* SDL_IOFromFile(string file, string mode)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            fixed (byte* ptr2 = SDL_StringToNative(mode))
            {
                return iSDL_IOFromFile(ptr1, ptr2);
            }
        }

        public static SDL_IOStream* SDL_IOFromMem(IntPtr mem, UIntPtr size)
        {
            return iSDL_IOFromMem(mem, size);
        }

        public static SDL_IOStream* SDL_IOFromConstMem(IntPtr mem, UIntPtr size)
        {
            return iSDL_IOFromConstMem(mem, size);
        }

        public static SDL_IOStream* SDL_IOFromDynamicMem()
        {
            return iSDL_IOFromDynamicMem();
        }

        public static SDL_IOStream* SDL_OpenIO(SDL_IOStreamInterface* iface, IntPtr userdata)
        {
            return iSDL_OpenIO(iface, userdata);
        }

        public static bool SDL_CloseIO(SDL_IOStream* context)
        {
            return iSDL_CloseIO(context);
        }

        public static uint SDL_GetIOProperties(SDL_IOStream* context)
        {
            return iSDL_GetIOProperties(context);
        }

        public static SDL_IOStatus SDL_GetIOStatus(SDL_IOStream* context)
        {
            return iSDL_GetIOStatus(context);
        }

        public static long SDL_GetIOSize(SDL_IOStream* context)
        {
            return iSDL_GetIOSize(context);
        }

        public static long SDL_SeekIO(SDL_IOStream* context, long offset, SDL_IOWhence whence)
        {
            return iSDL_SeekIO(context, offset, whence);
        }

        public static long SDL_TellIO(SDL_IOStream* context)
        {
            return iSDL_TellIO(context);
        }

        public static UIntPtr SDL_ReadIO(SDL_IOStream* context, IntPtr ptr, UIntPtr size)
        {
            return iSDL_ReadIO(context, ptr, size);
        }

        public static UIntPtr SDL_WriteIO(SDL_IOStream* context, IntPtr ptr, UIntPtr size)
        {
            return iSDL_WriteIO(context, ptr, size);
        }

        public static UIntPtr SDL_IOprintf(SDL_IOStream* context, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                return iSDL_IOprintf(context, ptr1);
            }
        }

        public static UIntPtr SDL_IOvprintf(SDL_IOStream* context, string fmt, string ap)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            fixed (byte* ptr2 = SDL_StringToNative(ap))
            {
                return iSDL_IOvprintf(context, ptr1, ptr2);
            }
        }

        public static bool SDL_FlushIO(SDL_IOStream* context)
        {
            return iSDL_FlushIO(context);
        }

        public static IntPtr SDL_LoadFile_IO(SDL_IOStream* src, out UIntPtr datasize, bool closeio)
        {
            fixed (UIntPtr* ptr1 = &datasize)
            {
                return iSDL_LoadFile_IO(src, ptr1, closeio);
            }
        }

        public static IntPtr SDL_LoadFile(string file, out UIntPtr datasize)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            fixed (UIntPtr* ptr2 = &datasize)
            {
                return iSDL_LoadFile(ptr1, ptr2);
            }
        }

        public static bool SDL_SaveFile_IO(SDL_IOStream* src, IntPtr data, UIntPtr datasize, bool closeio)
        {
            return iSDL_SaveFile_IO(src, data, datasize, closeio);
        }

        public static bool SDL_SaveFile(string file, IntPtr data, UIntPtr datasize)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_SaveFile(ptr1, data, datasize);
            }
        }

        public static bool SDL_ReadU8(SDL_IOStream* src, out byte value)
        {
            fixed (byte* ptr1 = &value)
            {
                return iSDL_ReadU8(src, ptr1);
            }
        }

        public static bool SDL_ReadS8(SDL_IOStream* src, out sbyte value)
        {
            fixed (sbyte* ptr1 = &value)
            {
                return iSDL_ReadS8(src, ptr1);
            }
        }

        public static bool SDL_ReadU16LE(SDL_IOStream* src, out ushort value)
        {
            fixed (ushort* ptr1 = &value)
            {
                return iSDL_ReadU16LE(src, ptr1);
            }
        }

        public static bool SDL_ReadS16LE(SDL_IOStream* src, out short value)
        {
            fixed (short* ptr1 = &value)
            {
                return iSDL_ReadS16LE(src, ptr1);
            }
        }

        public static bool SDL_ReadU16BE(SDL_IOStream* src, out ushort value)
        {
            fixed (ushort* ptr1 = &value)
            {
                return iSDL_ReadU16BE(src, ptr1);
            }
        }

        public static bool SDL_ReadS16BE(SDL_IOStream* src, out short value)
        {
            fixed (short* ptr1 = &value)
            {
                return iSDL_ReadS16BE(src, ptr1);
            }
        }

        public static bool SDL_ReadU32LE(SDL_IOStream* src, out uint value)
        {
            fixed (uint* ptr1 = &value)
            {
                return iSDL_ReadU32LE(src, ptr1);
            }
        }

        public static bool SDL_ReadS32LE(SDL_IOStream* src, out int value)
        {
            fixed (int* ptr1 = &value)
            {
                return iSDL_ReadS32LE(src, ptr1);
            }
        }

        public static bool SDL_ReadU32BE(SDL_IOStream* src, out uint value)
        {
            fixed (uint* ptr1 = &value)
            {
                return iSDL_ReadU32BE(src, ptr1);
            }
        }

        public static bool SDL_ReadS32BE(SDL_IOStream* src, out int value)
        {
            fixed (int* ptr1 = &value)
            {
                return iSDL_ReadS32BE(src, ptr1);
            }
        }

        public static bool SDL_ReadU64LE(SDL_IOStream* src, out ulong value)
        {
            fixed (ulong* ptr1 = &value)
            {
                return iSDL_ReadU64LE(src, ptr1);
            }
        }

        public static bool SDL_ReadS64LE(SDL_IOStream* src, out long value)
        {
            fixed (long* ptr1 = &value)
            {
                return iSDL_ReadS64LE(src, ptr1);
            }
        }

        public static bool SDL_ReadU64BE(SDL_IOStream* src, out ulong value)
        {
            fixed (ulong* ptr1 = &value)
            {
                return iSDL_ReadU64BE(src, ptr1);
            }
        }

        public static bool SDL_ReadS64BE(SDL_IOStream* src, out long value)
        {
            fixed (long* ptr1 = &value)
            {
                return iSDL_ReadS64BE(src, ptr1);
            }
        }

        public static bool SDL_WriteU8(SDL_IOStream* dst, byte value)
        {
            return iSDL_WriteU8(dst, value);
        }

        public static bool SDL_WriteS8(SDL_IOStream* dst, sbyte value)
        {
            return iSDL_WriteS8(dst, value);
        }

        public static bool SDL_WriteU16LE(SDL_IOStream* dst, ushort value)
        {
            return iSDL_WriteU16LE(dst, value);
        }

        public static bool SDL_WriteS16LE(SDL_IOStream* dst, short value)
        {
            return iSDL_WriteS16LE(dst, value);
        }

        public static bool SDL_WriteU16BE(SDL_IOStream* dst, ushort value)
        {
            return iSDL_WriteU16BE(dst, value);
        }

        public static bool SDL_WriteS16BE(SDL_IOStream* dst, short value)
        {
            return iSDL_WriteS16BE(dst, value);
        }

        public static bool SDL_WriteU32LE(SDL_IOStream* dst, uint value)
        {
            return iSDL_WriteU32LE(dst, value);
        }

        public static bool SDL_WriteS32LE(SDL_IOStream* dst, int value)
        {
            return iSDL_WriteS32LE(dst, value);
        }

        public static bool SDL_WriteU32BE(SDL_IOStream* dst, uint value)
        {
            return iSDL_WriteU32BE(dst, value);
        }

        public static bool SDL_WriteS32BE(SDL_IOStream* dst, int value)
        {
            return iSDL_WriteS32BE(dst, value);
        }

        public static bool SDL_WriteU64LE(SDL_IOStream* dst, ulong value)
        {
            return iSDL_WriteU64LE(dst, value);
        }

        public static bool SDL_WriteS64LE(SDL_IOStream* dst, long value)
        {
            return iSDL_WriteS64LE(dst, value);
        }

        public static bool SDL_WriteU64BE(SDL_IOStream* dst, ulong value)
        {
            return iSDL_WriteU64BE(dst, value);
        }

        public static bool SDL_WriteS64BE(SDL_IOStream* dst, long value)
        {
            return iSDL_WriteS64BE(dst, value);
        }
    }
}