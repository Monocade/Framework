using System.Runtime.InteropServices;
using System;
using System.Linq;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_HasKeyboard()
        {
            return iSDL_HasKeyboard();
        }

        public static uint[] SDL_GetKeyboards(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetKeyboards(&size), size, out count);
            }
        }

        public static string SDL_GetKeyboardNameForID(uint instance_id)
        {
            return SDL_NativeToString(iSDL_GetKeyboardNameForID(instance_id));
        }

        public static SDL_Window* SDL_GetKeyboardFocus()
        {
            return iSDL_GetKeyboardFocus();
        }

        public static bool[] SDL_GetKeyboardState(out int numkeys)
        {
            int size = 0;
            {
                var result = SDL_NativeToArray(iSDL_GetKeyboardState(&size), size, out numkeys);
                
                var output = new bool[result.Length];

                for (int i = 0; i < result.Length; i++)
                {
                    output[i] = result[i];
                }

                return output;
            }
        }

        public static void SDL_ResetKeyboard()
        {
            iSDL_ResetKeyboard();
        }

        public static SDL_Keymod SDL_GetModState()
        {
            return (SDL_Keymod)iSDL_GetModState();
        }

        public static void SDL_SetModState(SDL_Keymod modstate)
        {
            iSDL_SetModState((ushort)modstate);
        }

        public static SDL_Keycode SDL_GetKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modstate, bool key_event)
        {
            return (SDL_Keycode)iSDL_GetKeyFromScancode(scancode, (ushort)modstate, key_event);
        }

        public static SDL_Scancode SDL_GetScancodeFromKey(SDL_Keycode key, ref SDL_Keymod modstate)
        {
            fixed (SDL_Keymod* ptr1 = &modstate)
            {
                return iSDL_GetScancodeFromKey((uint)key, (ushort*)ptr1);
            }
        }

        public static bool SDL_SetScancodeName(SDL_Scancode scancode, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_SetScancodeName(scancode, ptr1);
            }
        }

        public static string SDL_GetScancodeName(SDL_Scancode scancode)
        {
            return SDL_NativeToString(iSDL_GetScancodeName(scancode));
        }

        public static SDL_Scancode SDL_GetScancodeFromName(string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GetScancodeFromName(ptr1);
            }
        }

        public static string SDL_GetKeyName(SDL_Keycode key)
        {
            return SDL_NativeToString(iSDL_GetKeyName((uint)key));
        }

        public static SDL_Keycode SDL_GetKeyFromName(string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return (SDL_Keycode)iSDL_GetKeyFromName(ptr1);
            }
        }

        public static bool SDL_StartTextInput(SDL_Window* window)
        {
            return iSDL_StartTextInput(window);
        }

        public static bool SDL_StartTextInputWithProperties(SDL_Window* window, uint props)
        {
            return iSDL_StartTextInputWithProperties(window, props);
        }

        public static bool SDL_TextInputActive(SDL_Window* window)
        {
            return iSDL_TextInputActive(window);
        }

        public static bool SDL_StopTextInput(SDL_Window* window)
        {
            return iSDL_StopTextInput(window);
        }

        public static bool SDL_ClearComposition(SDL_Window* window)
        {
            return iSDL_ClearComposition(window);
        }

        public static bool SDL_SetTextInputArea(SDL_Window* window, SDL_Rect* rect, int cursor)
        {
            return iSDL_SetTextInputArea(window, rect, cursor);
        }

        public static bool SDL_GetTextInputArea(SDL_Window* window, out SDL_Rect rect, out int cursor)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            fixed (int* ptr2 = &cursor)
            {
                return iSDL_GetTextInputArea(window, ptr1, ptr2);
            }
        }

        public static bool SDL_HasScreenKeyboardSupport()
        {
            return iSDL_HasScreenKeyboardSupport();
        }

        public static bool SDL_ScreenKeyboardShown(SDL_Window* window)
        {
            return iSDL_ScreenKeyboardShown(window);
        }
    }
}