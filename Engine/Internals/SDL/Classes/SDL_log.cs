using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static void SDL_SetLogPriorities(SDL_LogPriority priority)
        {
            iSDL_SetLogPriorities(priority);
        }

        public static void SDL_SetLogPriority(int category, SDL_LogPriority priority)
        {
            iSDL_SetLogPriority(category, priority);
        }

        public static SDL_LogPriority SDL_GetLogPriority(int category)
        {
            return iSDL_GetLogPriority(category);
        }

        public static void SDL_ResetLogPriorities()
        {
            iSDL_ResetLogPriorities();
        }

        public static bool SDL_SetLogPriorityPrefix(SDL_LogPriority priority, string prefix)
        {
            fixed (byte* ptr1 = SDL_StringToNative(prefix))
            {
                return iSDL_SetLogPriorityPrefix(priority, ptr1);
            }
        }

        public static void SDL_Log(string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_Log(ptr1);
            }
        }

        public static void SDL_LogTrace(int category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogTrace(category, ptr1);
            }
        }

        public static void SDL_LogVerbose(int category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogVerbose(category, ptr1);
            }
        }

        public static void SDL_LogDebug(int category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogDebug(category, ptr1);
            }
        }

        public static void SDL_LogInfo(int category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogInfo(category, ptr1);
            }
        }

        public static void SDL_LogWarn(int category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogWarn(category, ptr1);
            }
        }

        public static void SDL_LogError(int category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogError(category, ptr1);
            }
        }

        public static void SDL_LogCritical(int category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogCritical(category, ptr1);
            }
        }

        public static void SDL_LogMessage(int category, SDL_LogPriority priority, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogMessage(category, priority, ptr1);
            }
        }

        public static void SDL_LogMessageV(int category, SDL_LogPriority priority, string fmt, string ap)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            fixed (byte* ptr2 = SDL_StringToNative(ap))
            {
                iSDL_LogMessageV(category, priority, ptr1, ptr2);
            }
        }

        public static SDL_LogOutputFunction SDL_GetDefaultLogOutputFunction()
        {
            return Marshal.GetDelegateForFunctionPointer<SDL_LogOutputFunction>(iSDL_GetDefaultLogOutputFunction());
        }

        public static void SDL_GetLogOutputFunction(out SDL_LogOutputFunction callback, out IntPtr userdata)
        {
            IntPtr ptr1 = IntPtr.Zero;
            fixed (IntPtr* ptr2 = &userdata)
            {
                iSDL_GetLogOutputFunction(&ptr1, ptr2);
                callback = Marshal.GetDelegateForFunctionPointer<SDL_LogOutputFunction>(ptr1);
            }
        }

        public static void SDL_SetLogOutputFunction(SDL_LogOutputFunction callback, IntPtr userdata)
        {
            iSDL_SetLogOutputFunction(Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }
    }
}