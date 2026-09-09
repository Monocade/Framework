using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_hid_device_info
    {
        public byte* Path
        {
            get => path;
            set => path = value;
        }

        public ushort Vendor_id
        {
            get => vendor_id;
            set => vendor_id = value;
        }

        public ushort Product_id
        {
            get => product_id;
            set => product_id = value;
        }

        public ushort* Serial_number
        {
            get => serial_number;
            set => serial_number = value;
        }

        public ushort Release_number
        {
            get => release_number;
            set => release_number = value;
        }

        public ushort* Manufacturer_string
        {
            get => manufacturer_string;
            set => manufacturer_string = value;
        }

        public ushort* Product_string
        {
            get => product_string;
            set => product_string = value;
        }

        public ushort Usage_page
        {
            get => usage_page;
            set => usage_page = value;
        }

        public ushort Usage
        {
            get => usage;
            set => usage = value;
        }

        public int Interface_number
        {
            get => interface_number;
            set => interface_number = value;
        }

        public int Interface_class
        {
            get => interface_class;
            set => interface_class = value;
        }

        public int Interface_subclass
        {
            get => interface_subclass;
            set => interface_subclass = value;
        }

        public int Interface_protocol
        {
            get => interface_protocol;
            set => interface_protocol = value;
        }

        public SDL_hid_bus_type Bus_type
        {
            get => bus_type;
            set => bus_type = value;
        }

        public SDL_hid_device_info* Next
        {
            get => next;
            set => next = value;
        }
    }
}