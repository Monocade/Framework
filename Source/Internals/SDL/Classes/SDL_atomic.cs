using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_TryLockSpinlock(ref int @lock)
        {
            return iSDL_TryLockSpinlock((int*)@lock);
        }

        public static void SDL_LockSpinlock(ref int @lock)
        {
            iSDL_LockSpinlock((int*)@lock);
        }

        public static void SDL_UnlockSpinlock(ref int @lock)
        {
            iSDL_UnlockSpinlock((int*)@lock);
        }

        public static void SDL_MemoryBarrierReleaseFunction()
        {
            iSDL_MemoryBarrierReleaseFunction();
        }

        public static void SDL_MemoryBarrierAcquireFunction()
        {
            iSDL_MemoryBarrierAcquireFunction();
        }

        public static bool SDL_CompareAndSwapAtomicInt(SDL_AtomicInt* a, int oldValue, int newValue)
        {
            return iSDL_CompareAndSwapAtomicInt(a, oldValue, newValue);
        }

        public static int SDL_SetAtomicInt(SDL_AtomicInt* a, int v)
        {
            return iSDL_SetAtomicInt(a, v);
        }

        public static int SDL_GetAtomicInt(SDL_AtomicInt* a)
        {
            return iSDL_GetAtomicInt(a);
        }

        public static int SDL_AddAtomicInt(SDL_AtomicInt* a, int v)
        {
            return iSDL_AddAtomicInt(a, v);
        }

        public static bool SDL_CompareAndSwapAtomicU32(SDL_AtomicU32* a, uint oldValue, uint newValue)
        {
            return iSDL_CompareAndSwapAtomicU32(a, oldValue, newValue);
        }

        public static uint SDL_SetAtomicU32(SDL_AtomicU32* a, uint v)
        {
            return iSDL_SetAtomicU32(a, v);
        }

        public static uint SDL_GetAtomicU32(SDL_AtomicU32* a)
        {
            return iSDL_GetAtomicU32(a);
        }

        public static uint SDL_AddAtomicU32(SDL_AtomicU32* a, int v)
        {
            return iSDL_AddAtomicU32(a, v);
        }

        public static bool SDL_CompareAndSwapAtomicPointer(ref IntPtr a, IntPtr oldValue, IntPtr newValue)
        {
            fixed (IntPtr* ptr1 = &a)
            {
                return iSDL_CompareAndSwapAtomicPointer(ptr1, oldValue, newValue);
            }
        }

        public static IntPtr SDL_SetAtomicPointer(ref IntPtr a, IntPtr v)
        {
            fixed (IntPtr* ptr1 = &a)
            {
                return iSDL_SetAtomicPointer(ptr1, v);
            }
        }

        public static IntPtr SDL_GetAtomicPointer(ref IntPtr a)
        {
            fixed (IntPtr* ptr1 = &a)
            {
                return iSDL_GetAtomicPointer(ptr1);
            }
        }
    }
}