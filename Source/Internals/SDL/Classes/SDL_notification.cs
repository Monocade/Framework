using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_RequestNotificationPermission()
        {
            return iSDL_RequestNotificationPermission();
        }

        public static uint SDL_ShowNotificationWithProperties(uint props)
        {
            return iSDL_ShowNotificationWithProperties(props);
        }

        public static uint SDL_ShowNotification(string title, string message, SDL_Surface* image, SDL_NotificationAction[] actions, int numActions)
        {
            var titlePtr = Native.StringToNative(title, SDL_NativeProvider);
            var messagePtr = Native.StringToNative(message, SDL_NativeProvider);
                
            fixed (SDL_NotificationAction* ptr3 = actions)
            {
                var result = iSDL_ShowNotification((byte*)titlePtr, (byte*)messagePtr, image, ptr3, numActions);
                {
                    Native.Free(titlePtr, SDL_NativeProvider);
                    Native.Free(messagePtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static bool SDL_RemoveNotification(uint notification)
        {
            return iSDL_RemoveNotification(notification);
        }
    }
}