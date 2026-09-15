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

        public static void SDL_SetLogPriority(SDL_LogCategory category, SDL_LogPriority priority)
        {
            iSDL_SetLogPriority((int)category, priority);
        }

        public static SDL_LogPriority SDL_GetLogPriority(SDL_LogCategory category)
        {
            return iSDL_GetLogPriority((int)category);
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

        public static void SDL_LogTrace(SDL_LogCategory category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogTrace((int)category, ptr1);
            }
        }

        public static void SDL_LogVerbose(SDL_LogCategory category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogVerbose((int)category, ptr1);
            }
        }

        public static void SDL_LogDebug(SDL_LogCategory category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogDebug((int)category, ptr1);
            }
        }

        public static void SDL_LogInfo(SDL_LogCategory category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogInfo((int)category, ptr1);
            }
        }

        public static void SDL_LogWarn(SDL_LogCategory category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogWarn((int)category, ptr1);
            }
        }

        public static void SDL_LogError(SDL_LogCategory category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogError((int)category, ptr1);
            }
        }

        public static void SDL_LogCritical(SDL_LogCategory category, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogCritical((int)category, ptr1);
            }
        }

        public static void SDL_LogMessage(SDL_LogCategory category, SDL_LogPriority priority, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                iSDL_LogMessage((int)category, priority, ptr1);
            }
        }

        public static void SDL_LogMessageV(SDL_LogCategory category, SDL_LogPriority priority, string fmt, string ap)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            fixed (byte* ptr2 = SDL_StringToNative(ap))
            {
                iSDL_LogMessageV((int)category, priority, ptr1, ptr2);
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