using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Process* SDL_CreateProcess(IntPtr args, bool pipeStdio)
        {
            return iSDL_CreateProcess((byte**)args, pipeStdio);
        }

        public static SDL_Process* SDL_CreateProcessWithProperties(uint props)
        {
            return iSDL_CreateProcessWithProperties(props);
        }

        public static uint SDL_GetProcessProperties(SDL_Process* process)
        {
            return iSDL_GetProcessProperties(process);
        }

        public static IntPtr SDL_ReadProcess(SDL_Process* process, out UIntPtr dataSize, out int exitCode)
        {
            fixed (UIntPtr* ptr1 = &dataSize)
            fixed (int* ptr2 = &exitCode)
            {
                return iSDL_ReadProcess(process, ptr1, ptr2);
            }
        }

        public static SDL_IOStream* SDL_GetProcessInput(SDL_Process* process)
        {
            return iSDL_GetProcessInput(process);
        }

        public static SDL_IOStream* SDL_GetProcessOutput(SDL_Process* process)
        {
            return iSDL_GetProcessOutput(process);
        }

        public static bool SDL_KillProcess(SDL_Process* process, bool force)
        {
            return iSDL_KillProcess(process, force);
        }

        public static bool SDL_WaitProcess(SDL_Process* process, bool block, out int exitCode)
        {
            fixed (int* ptr1 = &exitCode)
            {
                return iSDL_WaitProcess(process, block, ptr1);
            }
        }

        public static void SDL_DestroyProcess(SDL_Process* process)
        {
            iSDL_DestroyProcess(process);
        }
    }
}