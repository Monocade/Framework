using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVulkanOptions
    {
        public uint Vulkan_api_version
        {
            get => vulkan_api_version;
            set => vulkan_api_version = value;
        }

        public IntPtr Feature_list
        {
            get => feature_list;
            set => feature_list = value;
        }

        public IntPtr Vulkan_10_physical_device_features
        {
            get => vulkan_10_physical_device_features;
            set => vulkan_10_physical_device_features = value;
        }

        public uint Device_extension_count
        {
            get => device_extension_count;
            set => device_extension_count = value;
        }

        public byte** Device_extension_names
        {
            get => device_extension_names;
            set => device_extension_names = value;
        }

        public uint Instance_extension_count
        {
            get => instance_extension_count;
            set => instance_extension_count = value;
        }

        public byte** Instance_extension_names
        {
            get => instance_extension_names;
            set => instance_extension_names = value;
        }
    }
}