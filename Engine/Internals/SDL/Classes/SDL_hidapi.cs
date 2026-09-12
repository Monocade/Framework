using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_hid_init()
        {
            return iSDL_hid_init();
        }

        public static int SDL_hid_exit()
        {
            return iSDL_hid_exit();
        }

        public static uint SDL_hid_device_change_count()
        {
            return iSDL_hid_device_change_count();
        }

        public static SDL_hid_device_info* SDL_hid_enumerate(ushort vendorId, ushort productId)
        {
            return iSDL_hid_enumerate(vendorId, productId);
        }

        public static void SDL_hid_free_enumeration(SDL_hid_device_info* devs)
        {
            iSDL_hid_free_enumeration(devs);
        }

        public static SDL_hid_device* SDL_hid_open(ushort vendorId, ushort productId, string serialNumber)
        {
            fixed (byte* ptr1 = SDL_StringToNative(serialNumber))
            {
                return iSDL_hid_open(vendorId, productId, (ushort*)ptr1);
            }
        }

        public static SDL_hid_device* SDL_hid_open_path(byte* path)
        {
            return iSDL_hid_open_path(path);
        }

        public static uint SDL_hid_get_properties(SDL_hid_device* dev)
        {
            return iSDL_hid_get_properties(dev);
        }

        public static int SDL_hid_write(SDL_hid_device* dev, IntPtr data, UIntPtr length)
        {
            return iSDL_hid_write(dev, (byte*)data, length);
        }

        public static int SDL_hid_read_timeout(SDL_hid_device* dev, IntPtr data, UIntPtr length, int milliseconds)
        {
            return iSDL_hid_read_timeout(dev, (byte*)data, length, milliseconds);
        }

        public static int SDL_hid_read(SDL_hid_device* dev, IntPtr data, UIntPtr length)
        {
            return iSDL_hid_read(dev, (byte*)data, length);
        }

        public static int SDL_hid_set_nonblocking(SDL_hid_device* dev, int nonblock)
        {
            return iSDL_hid_set_nonblocking(dev, nonblock);
        }

        public static int SDL_hid_send_feature_report(SDL_hid_device* dev, IntPtr data, UIntPtr length)
        {
            return iSDL_hid_send_feature_report(dev, (byte*)data, length);
        }

        public static int SDL_hid_get_feature_report(SDL_hid_device* dev, IntPtr data, UIntPtr length)
        {
            return iSDL_hid_get_feature_report(dev, (byte*)data, length);
        }

        public static int SDL_hid_get_input_report(SDL_hid_device* dev, IntPtr data, UIntPtr length)
        {
            return iSDL_hid_get_input_report(dev, (byte*)data, length);
        }

        public static int SDL_hid_close(SDL_hid_device* dev)
        {
            return iSDL_hid_close(dev);
        }

        public static int SDL_hid_get_manufacturer_string(SDL_hid_device* dev, string @string, UIntPtr maxLength)
        {
            fixed (byte* ptr1 = SDL_StringToNative(@string))
            {
                return iSDL_hid_get_manufacturer_string(dev, (ushort*)ptr1, maxLength);
            }
        }

        public static int SDL_hid_get_product_string(SDL_hid_device* dev, string @string, UIntPtr maxLength)
        {
            fixed (byte* ptr1 = SDL_StringToNative(@string))
            {
                return iSDL_hid_get_product_string(dev, (ushort*)ptr1, maxLength);
            }
        }

        public static int SDL_hid_get_serial_number_string(SDL_hid_device* dev, string @string, UIntPtr maxLength)
        {
            fixed (byte* ptr1 = SDL_StringToNative(@string))
            {
                return iSDL_hid_get_serial_number_string(dev, (ushort*)ptr1, maxLength);
            }
        }

        public static int SDL_hid_get_indexed_string(SDL_hid_device* dev, int stringIndex, string @string, UIntPtr maxLength)
        {
            fixed (byte* ptr1 = SDL_StringToNative(@string))
            {
                return iSDL_hid_get_indexed_string(dev, stringIndex, (ushort*)ptr1, maxLength);
            }
        }

        public static SDL_hid_device_info* SDL_hid_get_device_info(SDL_hid_device* dev)
        {
            return iSDL_hid_get_device_info(dev);
        }

        public static int SDL_hid_get_report_descriptor(SDL_hid_device* dev, IntPtr buf, UIntPtr bufSize)
        {
            return iSDL_hid_get_report_descriptor(dev, (byte*)buf, bufSize);
        }

        public static void SDL_hid_ble_scan(bool active)
        {
            iSDL_hid_ble_scan(active);
        }
    }
}