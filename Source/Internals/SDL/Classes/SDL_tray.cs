using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Tray* SDL_CreateTray(SDL_Surface* icon, string tooltip)
        {
            var tooltipPtr = Native.StringToNative(tooltip, SDL_NativeProvider);
            {
                var result = iSDL_CreateTray(icon, (byte*)tooltipPtr);
                {
                    Native.Free(tooltipPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static SDL_Tray* SDL_CreateTrayWithProperties(uint props)
        {
            return iSDL_CreateTrayWithProperties(props);
        }

        public static void SDL_SetTrayIcon(SDL_Tray* tray, SDL_Surface* icon)
        {
            iSDL_SetTrayIcon(tray, icon);
        }

        public static void SDL_SetTrayTooltip(SDL_Tray* tray, string tooltip)
        {
            var tooltipPtr = Native.StringToNative(tooltip, SDL_NativeProvider);
            {
                iSDL_SetTrayTooltip(tray, (byte*)tooltipPtr);
                {
                    Native.Free(tooltipPtr, SDL_NativeProvider);
                }
            }
        }

        public static SDL_TrayMenu* SDL_CreateTrayMenu(SDL_Tray* tray)
        {
            return iSDL_CreateTrayMenu(tray);
        }

        public static SDL_TrayMenu* SDL_CreateTraySubmenu(SDL_TrayEntry* entry)
        {
            return iSDL_CreateTraySubmenu(entry);
        }

        public static SDL_TrayMenu* SDL_GetTrayMenu(SDL_Tray* tray)
        {
            return iSDL_GetTrayMenu(tray);
        }

        public static SDL_TrayMenu* SDL_GetTraySubmenu(SDL_TrayEntry* entry)
        {
            return iSDL_GetTraySubmenu(entry);
        }

        public static SDL_TrayEntry*[] SDL_GetTrayEntries(SDL_TrayMenu* menu, out int count)
        {
            int size = 0;
            {
                var trayEntriesPtr = iSDL_GetTrayEntries(menu, &size);
                {
                    var result = Native.NativeToArray(trayEntriesPtr, size, out count);
                    {
                        Native.Free((IntPtr)trayEntriesPtr, SDL_NativeProvider);
                        return result;
                    }
                }
            }
        }

        public static void SDL_RemoveTrayEntry(SDL_TrayEntry* entry)
        {
            iSDL_RemoveTrayEntry(entry);
        }

        public static SDL_TrayEntry* SDL_InsertTrayEntryAt(SDL_TrayMenu* menu, int pos, string label, SDL_TrayEntryFlags flags)
        {
            var labelPtr = Native.StringToNative(label, SDL_NativeProvider);
            {
                var result = iSDL_InsertTrayEntryAt(menu, pos, (byte*)labelPtr, (uint)flags);
                {
                    Native.Free(labelPtr, SDL_NativeProvider);
                    return result;
                }
            }
        }

        public static void SDL_SetTrayEntryLabel(SDL_TrayEntry* entry, string label)
        {
            var labelPtr = Native.StringToNative(label, SDL_NativeProvider);
            {
                iSDL_SetTrayEntryLabel(entry, (byte*)labelPtr);
                {
                    Native.Free(labelPtr, SDL_NativeProvider);
                }
            }
        }

        public static string SDL_GetTrayEntryLabel(SDL_TrayEntry* entry)
        {
            return Native.NativeToString((IntPtr)iSDL_GetTrayEntryLabel(entry));
        }

        public static void SDL_SetTrayEntryChecked(SDL_TrayEntry* entry, bool @checked)
        {
            iSDL_SetTrayEntryChecked(entry, @checked);
        }

        public static bool SDL_GetTrayEntryChecked(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryChecked(entry);
        }

        public static void SDL_SetTrayEntryEnabled(SDL_TrayEntry* entry, bool enabled)
        {
            iSDL_SetTrayEntryEnabled(entry, enabled);
        }

        public static bool SDL_GetTrayEntryEnabled(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryEnabled(entry);
        }

        public static void SDL_SetTrayEntryCallback(SDL_TrayEntry* entry, SDL_TrayCallback callback, IntPtr userdata)
        {
            iSDL_SetTrayEntryCallback(entry, Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static void SDL_ClickTrayEntry(SDL_TrayEntry* entry)
        {
            iSDL_ClickTrayEntry(entry);
        }

        public static void SDL_DestroyTray(SDL_Tray* tray)
        {
            iSDL_DestroyTray(tray);
        }

        public static SDL_TrayMenu* SDL_GetTrayEntryParent(SDL_TrayEntry* entry)
        {
            return iSDL_GetTrayEntryParent(entry);
        }

        public static SDL_TrayEntry* SDL_GetTrayMenuParentEntry(SDL_TrayMenu* menu)
        {
            return iSDL_GetTrayMenuParentEntry(menu);
        }

        public static SDL_Tray* SDL_GetTrayMenuParentTray(SDL_TrayMenu* menu)
        {
            return iSDL_GetTrayMenuParentTray(menu);
        }

        public static void SDL_UpdateTrays()
        {
            iSDL_UpdateTrays();
        }
    }
}