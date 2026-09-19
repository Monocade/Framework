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
            var prefixPtr = Native.StringToNative(prefix, SDL_NativeProvider);
            {
                var result = iSDL_SetLogPriorityPrefix(priority, (byte*)prefixPtr);
                {
                    Native.Free(prefixPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static void SDL_Log(string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_Log((byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogTrace(SDL_LogCategory category, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogTrace((int)category, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogVerbose(SDL_LogCategory category, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogVerbose((int)category, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogDebug(SDL_LogCategory category, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogDebug((int)category, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogInfo(SDL_LogCategory category, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogInfo((int)category, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogWarn(SDL_LogCategory category, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogWarn((int)category, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogError(SDL_LogCategory category, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogError((int)category, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogCritical(SDL_LogCategory category, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogCritical((int)category, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogMessage(SDL_LogCategory category, SDL_LogPriority priority, string fmt)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            {
                iSDL_LogMessage((int)category, priority, (byte*)fmtPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                }
            }
        }

        public static void SDL_LogMessageV(SDL_LogCategory category, SDL_LogPriority priority, string fmt, string ap)
        {
            var fmtPtr = Native.StringToNative(fmt, SDL_NativeProvider);
            var apPtr = Native.StringToNative(ap, SDL_NativeProvider);
            {
                iSDL_LogMessageV((int)category, priority, (byte*)fmtPtr, (byte*)apPtr);
                {
                    Native.Free(fmtPtr, SDL_NativeProvider);
                    Native.Free(apPtr, SDL_NativeProvider);
                }
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