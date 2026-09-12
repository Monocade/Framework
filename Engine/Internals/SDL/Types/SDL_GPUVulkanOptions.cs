using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVulkanOptions
    {
        public uint VulkanApiVersion
        {
            get => vulkan_api_version;
            set => vulkan_api_version = value;
        }

        public IntPtr FeatureList
        {
            get => feature_list;
            set => feature_list = value;
        }

        public IntPtr Vulkan10PhysicalDeviceFeatures
        {
            get => vulkan_10_physical_device_features;
            set => vulkan_10_physical_device_features = value;
        }

        public uint DeviceExtensionCount
        {
            get => device_extension_count;
            set => device_extension_count = value;
        }

        public byte** DeviceExtensionNames
        {
            get => device_extension_names;
            set => device_extension_names = value;
        }

        public uint InstanceExtensionCount
        {
            get => instance_extension_count;
            set => instance_extension_count = value;
        }

        public byte** InstanceExtensionNames
        {
            get => instance_extension_names;
            set => instance_extension_names = value;
        }
    }
}