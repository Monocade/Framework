using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_GPUSupportsShaderFormats(SDL_GPUShaderFormat formatFlags, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_GPUSupportsShaderFormats((uint)formatFlags, ptr1);
            }
        }

        public static bool SDL_GPUSupportsProperties(uint props)
        {
            return iSDL_GPUSupportsProperties(props);
        }

        public static SDL_GPUDevice* SDL_CreateGPUDevice(SDL_GPUShaderFormat formatFlags, bool debugMode, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_CreateGPUDevice((uint)formatFlags, debugMode, ptr1);
            }
        }

        public static SDL_GPUDevice* SDL_CreateGPUDeviceWithProperties(uint props)
        {
            return iSDL_CreateGPUDeviceWithProperties(props);
        }

        public static void SDL_DestroyGPUDevice(SDL_GPUDevice* device)
        {
            iSDL_DestroyGPUDevice(device);
        }

        public static int SDL_GetNumGPUDrivers()
        {
            return iSDL_GetNumGPUDrivers();
        }

        public static string SDL_GetGPUDriver(int index)
        {
            return SDL_NativeToString(iSDL_GetGPUDriver(index));
        }

        public static string SDL_GetGPUDeviceDriver(SDL_GPUDevice* device)
        {
            return SDL_NativeToString(iSDL_GetGPUDeviceDriver(device));
        }

        public static SDL_GPUShaderFormat SDL_GetGPUShaderFormats(SDL_GPUDevice* device)
        {
            return (SDL_GPUShaderFormat)iSDL_GetGPUShaderFormats(device);
        }

        public static uint SDL_GetGPUDeviceProperties(SDL_GPUDevice* device)
        {
            return iSDL_GetGPUDeviceProperties(device);
        }

        public static SDL_GPUComputePipeline* SDL_CreateGPUComputePipeline(SDL_GPUDevice* device, SDL_GPUComputePipelineCreateInfo* createInfo)
        {
            return iSDL_CreateGPUComputePipeline(device, createInfo);
        }

        public static SDL_GPUGraphicsPipeline* SDL_CreateGPUGraphicsPipeline(SDL_GPUDevice* device, SDL_GPUGraphicsPipelineCreateInfo* createInfo)
        {
            return iSDL_CreateGPUGraphicsPipeline(device, createInfo);
        }

        public static SDL_GPUSampler* SDL_CreateGPUSampler(SDL_GPUDevice* device, SDL_GPUSamplerCreateInfo* createInfo)
        {
            return iSDL_CreateGPUSampler(device, createInfo);
        }

        public static SDL_GPUShader* SDL_CreateGPUShader(SDL_GPUDevice* device, SDL_GPUShaderCreateInfo* createInfo)
        {
            return iSDL_CreateGPUShader(device, createInfo);
        }

        public static SDL_GPUTexture* SDL_CreateGPUTexture(SDL_GPUDevice* device, SDL_GPUTextureCreateInfo* createInfo)
        {
            return iSDL_CreateGPUTexture(device, createInfo);
        }

        public static SDL_GPUBuffer* SDL_CreateGPUBuffer(SDL_GPUDevice* device, SDL_GPUBufferCreateInfo* createInfo)
        {
            return iSDL_CreateGPUBuffer(device, createInfo);
        }

        public static SDL_GPUTransferBuffer* SDL_CreateGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBufferCreateInfo* createInfo)
        {
            return iSDL_CreateGPUTransferBuffer(device, createInfo);
        }

        public static void SDL_SetGPUBufferName(SDL_GPUDevice* device, SDL_GPUBuffer* buffer, string text)
        {
            fixed (byte* ptr1 = SDL_StringToNative(text))
            {
                iSDL_SetGPUBufferName(device, buffer, ptr1);
            }
        }

        public static void SDL_SetGPUTextureName(SDL_GPUDevice* device, SDL_GPUTexture* texture, string text)
        {
            fixed (byte* ptr1 = SDL_StringToNative(text))
            {
                iSDL_SetGPUTextureName(device, texture, ptr1);
            }
        }

        public static void SDL_InsertGPUDebugLabel(SDL_GPUCommandBuffer* commandBuffer, string text)
        {
            fixed (byte* ptr1 = SDL_StringToNative(text))
            {
                iSDL_InsertGPUDebugLabel(commandBuffer, ptr1);
            }
        }

        public static void SDL_PushGPUDebugGroup(SDL_GPUCommandBuffer* commandBuffer, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                iSDL_PushGPUDebugGroup(commandBuffer, ptr1);
            }
        }

        public static void SDL_PopGPUDebugGroup(SDL_GPUCommandBuffer* commandBuffer)
        {
            iSDL_PopGPUDebugGroup(commandBuffer);
        }

        public static void SDL_ReleaseGPUTexture(SDL_GPUDevice* device, SDL_GPUTexture* texture)
        {
            iSDL_ReleaseGPUTexture(device, texture);
        }

        public static void SDL_ReleaseGPUSampler(SDL_GPUDevice* device, SDL_GPUSampler* sampler)
        {
            iSDL_ReleaseGPUSampler(device, sampler);
        }

        public static void SDL_ReleaseGPUBuffer(SDL_GPUDevice* device, SDL_GPUBuffer* buffer)
        {
            iSDL_ReleaseGPUBuffer(device, buffer);
        }

        public static void SDL_ReleaseGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transferBuffer)
        {
            iSDL_ReleaseGPUTransferBuffer(device, transferBuffer);
        }

        public static void SDL_ReleaseGPUComputePipeline(SDL_GPUDevice* device, SDL_GPUComputePipeline* computePipeline)
        {
            iSDL_ReleaseGPUComputePipeline(device, computePipeline);
        }

        public static void SDL_ReleaseGPUShader(SDL_GPUDevice* device, SDL_GPUShader* shader)
        {
            iSDL_ReleaseGPUShader(device, shader);
        }

        public static void SDL_ReleaseGPUGraphicsPipeline(SDL_GPUDevice* device, SDL_GPUGraphicsPipeline* graphicsPipeline)
        {
            iSDL_ReleaseGPUGraphicsPipeline(device, graphicsPipeline);
        }

        public static SDL_GPUCommandBuffer* SDL_AcquireGPUCommandBuffer(SDL_GPUDevice* device)
        {
            return iSDL_AcquireGPUCommandBuffer(device);
        }

        public static void SDL_PushGPUVertexUniformData(SDL_GPUCommandBuffer* commandBuffer, uint slotIndex, IntPtr data, uint length)
        {
            iSDL_PushGPUVertexUniformData(commandBuffer, slotIndex, data, length);
        }

        public static void SDL_PushGPUFragmentUniformData(SDL_GPUCommandBuffer* commandBuffer, uint slotIndex, IntPtr data, uint length)
        {
            iSDL_PushGPUFragmentUniformData(commandBuffer, slotIndex, data, length);
        }

        public static void SDL_PushGPUComputeUniformData(SDL_GPUCommandBuffer* commandBuffer, uint slotIndex, IntPtr data, uint length)
        {
            iSDL_PushGPUComputeUniformData(commandBuffer, slotIndex, data, length);
        }

        public static SDL_GPURenderPass* SDL_BeginGPURenderPass(SDL_GPUCommandBuffer* commandBuffer, SDL_GPUColorTargetInfo[] colorTargetInfos, uint numColorTargets, SDL_GPUDepthStencilTargetInfo* depthStencilTargetInfo)
        {
            fixed(SDL_GPUColorTargetInfo* ptr1 = colorTargetInfos)
            {
                return iSDL_BeginGPURenderPass(commandBuffer, ptr1, numColorTargets, depthStencilTargetInfo);
            }
        }

        public static void SDL_BindGPUGraphicsPipeline(SDL_GPURenderPass* renderPass, SDL_GPUGraphicsPipeline* graphicsPipeline)
        {
            iSDL_BindGPUGraphicsPipeline(renderPass, graphicsPipeline);
        }

        public static void SDL_SetGPUViewport(SDL_GPURenderPass* renderPass, SDL_GPUViewport* viewport)
        {
            iSDL_SetGPUViewport(renderPass, viewport);
        }

        public static void SDL_SetGPUScissor(SDL_GPURenderPass* renderPass, SDL_Rect* scissor)
        {
            iSDL_SetGPUScissor(renderPass, scissor);
        }

        public static void SDL_SetGPUBlendConstants(SDL_GPURenderPass* renderPass, SDL_FColor blendConstants)
        {
            iSDL_SetGPUBlendConstants(renderPass, blendConstants);
        }

        public static void SDL_SetGPUStencilReference(SDL_GPURenderPass* renderPass, byte reference)
        {
            iSDL_SetGPUStencilReference(renderPass, reference);
        }

        public static void SDL_BindGPUVertexBuffers(SDL_GPURenderPass* renderPass, uint firstSlot, SDL_GPUBufferBinding[] bindings, uint numBindings)
        {
            fixed (SDL_GPUBufferBinding* ptr1 = bindings)
            {
                iSDL_BindGPUVertexBuffers(renderPass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUIndexBuffer(SDL_GPURenderPass* renderPass, SDL_GPUBufferBinding* binding, SDL_GPUIndexElementSize indexElementSize)
        {
            iSDL_BindGPUIndexBuffer(renderPass, binding, indexElementSize);
        }

        public static void SDL_BindGPUVertexSamplers(SDL_GPURenderPass* renderPass, uint firstSlot, SDL_GPUTextureSamplerBinding[] textureSamplerBindings, uint numBindings)
        {
            fixed (SDL_GPUTextureSamplerBinding* ptr1 = textureSamplerBindings)
            {
                iSDL_BindGPUVertexSamplers(renderPass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUVertexStorageTextures(SDL_GPURenderPass* renderPass, uint firstSlot, SDL_GPUTexture*[] storageTextures, uint numBindings)
        {
            fixed (SDL_GPUTexture** ptr1 = storageTextures)
            {
                iSDL_BindGPUVertexStorageTextures(renderPass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUVertexStorageBuffers(SDL_GPURenderPass* renderPass, uint firstSlot, SDL_GPUBuffer*[] storageBuffers, uint numBindings)
        {
            fixed (SDL_GPUBuffer** ptr1 = storageBuffers)
            {
                iSDL_BindGPUVertexStorageBuffers(renderPass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUFragmentSamplers(SDL_GPURenderPass* renderPass, uint firstSlot, SDL_GPUTextureSamplerBinding[] textureSamplerBindings, uint numBindings)
        {
            fixed (SDL_GPUTextureSamplerBinding* ptr1 = textureSamplerBindings)
            {
                iSDL_BindGPUFragmentSamplers(renderPass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUFragmentStorageTextures(SDL_GPURenderPass* renderPass, uint firstSlot, SDL_GPUTexture*[] storageTextures, uint numBindings)
        {
            fixed (SDL_GPUTexture** ptr1 = storageTextures)
            {
                iSDL_BindGPUFragmentStorageTextures(renderPass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUFragmentStorageBuffers(SDL_GPURenderPass* renderPass, uint firstSlot, SDL_GPUBuffer*[] storageBuffers, uint numBindings)
        {
            fixed (SDL_GPUBuffer** ptr1 = storageBuffers)
            {
                iSDL_BindGPUFragmentStorageBuffers(renderPass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_DrawGPUIndexedPrimitives(SDL_GPURenderPass* renderPass, uint numIndices, uint numInstances, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            iSDL_DrawGPUIndexedPrimitives(renderPass, numIndices, numInstances, firstIndex, vertexOffset, firstInstance);
        }

        public static void SDL_DrawGPUPrimitives(SDL_GPURenderPass* renderPass, uint numVertices, uint numInstances, uint firstVertex, uint firstInstance)
        {
            iSDL_DrawGPUPrimitives(renderPass, numVertices, numInstances, firstVertex, firstInstance);
        }

        public static void SDL_DrawGPUPrimitivesIndirect(SDL_GPURenderPass* renderPass, SDL_GPUBuffer* buffer, uint offset, uint drawCount)
        {
            iSDL_DrawGPUPrimitivesIndirect(renderPass, buffer, offset, drawCount);
        }

        public static void SDL_DrawGPUIndexedPrimitivesIndirect(SDL_GPURenderPass* renderPass, SDL_GPUBuffer* buffer, uint offset, uint drawCount)
        {
            iSDL_DrawGPUIndexedPrimitivesIndirect(renderPass, buffer, offset, drawCount);
        }

        public static void SDL_EndGPURenderPass(SDL_GPURenderPass* renderPass)
        {
            iSDL_EndGPURenderPass(renderPass);
        }

        public static SDL_GPUComputePass* SDL_BeginGPUComputePass(SDL_GPUCommandBuffer* commandBuffer, SDL_GPUStorageTextureReadWriteBinding[] storageTextureBindings, uint numStorageTextureBindings, SDL_GPUStorageBufferReadWriteBinding[] storageBufferBindings, uint numStorageBufferBindings)
        {
            fixed (SDL_GPUStorageTextureReadWriteBinding* ptr1 = storageTextureBindings)
            fixed (SDL_GPUStorageBufferReadWriteBinding* ptr2 = storageBufferBindings)
            {
                return iSDL_BeginGPUComputePass(commandBuffer, ptr1, numStorageTextureBindings, ptr2, numStorageBufferBindings);
            }
        }

        public static void SDL_BindGPUComputePipeline(SDL_GPUComputePass* computePass, SDL_GPUComputePipeline* computePipeline)
        {
            iSDL_BindGPUComputePipeline(computePass, computePipeline);
        }

        public static void SDL_BindGPUComputeSamplers(SDL_GPUComputePass* computePass, uint firstSlot, SDL_GPUTextureSamplerBinding[] textureSamplerBindings, uint numBindings)
        {
            fixed (SDL_GPUTextureSamplerBinding* ptr1 = textureSamplerBindings)
            {
                iSDL_BindGPUComputeSamplers(computePass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUComputeStorageTextures(SDL_GPUComputePass* computePass, uint firstSlot, SDL_GPUTexture*[] storageTextures, uint numBindings)
        {
            fixed (SDL_GPUTexture** ptr1 = storageTextures)
            {
                iSDL_BindGPUComputeStorageTextures(computePass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_BindGPUComputeStorageBuffers(SDL_GPUComputePass* computePass, uint firstSlot, SDL_GPUBuffer*[] storageBuffers, uint numBindings)
        {
            fixed (SDL_GPUBuffer** ptr1 = storageBuffers)
            {
                iSDL_BindGPUComputeStorageBuffers(computePass, firstSlot, ptr1, numBindings);
            }
        }

        public static void SDL_DispatchGPUCompute(SDL_GPUComputePass* computePass, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            iSDL_DispatchGPUCompute(computePass, groupCountX, groupCountY, groupCountZ);
        }

        public static void SDL_DispatchGPUComputeIndirect(SDL_GPUComputePass* computePass, SDL_GPUBuffer* buffer, uint offset)
        {
            iSDL_DispatchGPUComputeIndirect(computePass, buffer, offset);
        }

        public static void SDL_EndGPUComputePass(SDL_GPUComputePass* computePass)
        {
            iSDL_EndGPUComputePass(computePass);
        }

        public static IntPtr SDL_MapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transferBuffer, bool cycle)
        {
            return iSDL_MapGPUTransferBuffer(device, transferBuffer, cycle);
        }

        public static void SDL_UnmapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transferBuffer)
        {
            iSDL_UnmapGPUTransferBuffer(device, transferBuffer);
        }

        public static SDL_GPUCopyPass* SDL_BeginGPUCopyPass(SDL_GPUCommandBuffer* commandBuffer)
        {
            return iSDL_BeginGPUCopyPass(commandBuffer);
        }

        public static void SDL_UploadToGPUTexture(SDL_GPUCopyPass* copyPass, SDL_GPUTextureTransferInfo* source, SDL_GPUTextureRegion* destination, bool cycle)
        {
            iSDL_UploadToGPUTexture(copyPass, source, destination, cycle);
        }

        public static void SDL_UploadToGPUBuffer(SDL_GPUCopyPass* copyPass, SDL_GPUTransferBufferLocation* source, SDL_GPUBufferRegion* destination, bool cycle)
        {
            iSDL_UploadToGPUBuffer(copyPass, source, destination, cycle);
        }

        public static void SDL_CopyGPUTextureToTexture(SDL_GPUCopyPass* copyPass, SDL_GPUTextureLocation* source, SDL_GPUTextureLocation* destination, uint w, uint h, uint d, bool cycle)
        {
            iSDL_CopyGPUTextureToTexture(copyPass, source, destination, w, h, d, cycle);
        }

        public static void SDL_CopyGPUBufferToBuffer(SDL_GPUCopyPass* copyPass, SDL_GPUBufferLocation* source, SDL_GPUBufferLocation* destination, uint size, bool cycle)
        {
            iSDL_CopyGPUBufferToBuffer(copyPass, source, destination, size, cycle);
        }

        public static void SDL_DownloadFromGPUTexture(SDL_GPUCopyPass* copyPass, SDL_GPUTextureRegion* source, SDL_GPUTextureTransferInfo* destination)
        {
            iSDL_DownloadFromGPUTexture(copyPass, source, destination);
        }

        public static void SDL_DownloadFromGPUBuffer(SDL_GPUCopyPass* copyPass, SDL_GPUBufferRegion* source, SDL_GPUTransferBufferLocation* destination)
        {
            iSDL_DownloadFromGPUBuffer(copyPass, source, destination);
        }

        public static void SDL_EndGPUCopyPass(SDL_GPUCopyPass* copyPass)
        {
            iSDL_EndGPUCopyPass(copyPass);
        }

        public static void SDL_GenerateMipmapsForGPUTexture(SDL_GPUCommandBuffer* commandBuffer, SDL_GPUTexture* texture)
        {
            iSDL_GenerateMipmapsForGPUTexture(commandBuffer, texture);
        }

        public static void SDL_BlitGPUTexture(SDL_GPUCommandBuffer* commandBuffer, SDL_GPUBlitInfo* info)
        {
            iSDL_BlitGPUTexture(commandBuffer, info);
        }

        public static bool SDL_WindowSupportsGPUSwapchainComposition(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchainComposition)
        {
            return iSDL_WindowSupportsGPUSwapchainComposition(device, window, swapchainComposition);
        }

        public static bool SDL_WindowSupportsGPUPresentMode(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUPresentMode presentMode)
        {
            return iSDL_WindowSupportsGPUPresentMode(device, window, presentMode);
        }

        public static bool SDL_ClaimWindowForGPUDevice(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_ClaimWindowForGPUDevice(device, window);
        }

        public static void SDL_ReleaseWindowFromGPUDevice(SDL_GPUDevice* device, SDL_Window* window)
        {
            iSDL_ReleaseWindowFromGPUDevice(device, window);
        }

        public static bool SDL_SetGPUSwapchainParameters(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchainComposition, SDL_GPUPresentMode presentMode)
        {
            return iSDL_SetGPUSwapchainParameters(device, window, swapchainComposition, presentMode);
        }

        public static bool SDL_SetGPUAllowedFramesInFlight(SDL_GPUDevice* device, uint allowedFramesInFlight)
        {
            return iSDL_SetGPUAllowedFramesInFlight(device, allowedFramesInFlight);
        }

        public static SDL_GPUTextureFormat SDL_GetGPUSwapchainTextureFormat(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_GetGPUSwapchainTextureFormat(device, window);
        }

        public static bool SDL_AcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* commandBuffer, SDL_Window* window, out SDL_GPUTexture* swapchainTexture, out uint swapchainTextureWidth, out uint swapchainTextureHeight)
        {
            SDL_GPUTexture* ptr1 = null;

            fixed (uint* ptr2 = &swapchainTextureWidth)
            fixed (uint* ptr3 = &swapchainTextureHeight)
            {
                var result = iSDL_AcquireGPUSwapchainTexture(commandBuffer, window, &ptr1, ptr2, ptr3);
                swapchainTexture = ptr1;
                return result;
            }
        }

        public static bool SDL_WaitForGPUSwapchain(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_WaitForGPUSwapchain(device, window);
        }

        public static bool SDL_WaitAndAcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* commandBuffer, SDL_Window* window, out SDL_GPUTexture* swapchainTexture, out uint swapchainTextureWidth, out uint swapchainTextureHeight)
        {
            SDL_GPUTexture* ptr1 = null;

            fixed (uint* ptr2 = &swapchainTextureWidth)
            fixed (uint* ptr3 = &swapchainTextureHeight)
            {
                var result = iSDL_WaitAndAcquireGPUSwapchainTexture(commandBuffer, window, &ptr1, ptr2, ptr3);
                swapchainTexture = ptr1;
                return result;
            }
        }

        public static bool SDL_SubmitGPUCommandBuffer(SDL_GPUCommandBuffer* commandBuffer)
        {
            return iSDL_SubmitGPUCommandBuffer(commandBuffer);
        }

        public static SDL_GPUFence* SDL_SubmitGPUCommandBufferAndAcquireFence(SDL_GPUCommandBuffer* commandBuffer)
        {
            return iSDL_SubmitGPUCommandBufferAndAcquireFence(commandBuffer);
        }

        public static bool SDL_CancelGPUCommandBuffer(SDL_GPUCommandBuffer* commandBuffer)
        {
            return iSDL_CancelGPUCommandBuffer(commandBuffer);
        }

        public static bool SDL_WaitForGPUIdle(SDL_GPUDevice* device)
        {
            return iSDL_WaitForGPUIdle(device);
        }

        public static bool SDL_WaitForGPUFences(SDL_GPUDevice* device, bool waitAll, SDL_GPUFence*[] fences, uint numFences)
        {
            fixed (SDL_GPUFence** ptr1 = fences)
            {
                return iSDL_WaitForGPUFences(device, waitAll, ptr1, numFences);
            }
        }

        public static bool SDL_QueryGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence)
        {
            return iSDL_QueryGPUFence(device, fence);
        }

        public static void SDL_ReleaseGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence)
        {
            iSDL_ReleaseGPUFence(device, fence);
        }

        public static uint SDL_GPUTextureFormatTexelBlockSize(SDL_GPUTextureFormat format)
        {
            return iSDL_GPUTextureFormatTexelBlockSize(format);
        }

        public static bool SDL_GPUTextureSupportsFormat(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUTextureType type, SDL_GPUTextureUsageFlags usage)
        {
            return iSDL_GPUTextureSupportsFormat(device, format, type, (uint)usage);
        }

        public static bool SDL_GPUTextureSupportsSampleCount(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUSampleCount sampleCount)
        {
            return iSDL_GPUTextureSupportsSampleCount(device, format, sampleCount);
        }

        public static uint SDL_CalculateGPUTextureFormatSize(SDL_GPUTextureFormat format, uint width, uint height, uint depthOrLayerCount)
        {
            return iSDL_CalculateGPUTextureFormatSize(format, width, height, depthOrLayerCount);
        }

        public static SDL_PixelFormat SDL_GetPixelFormatFromGPUTextureFormat(SDL_GPUTextureFormat format)
        {
            return iSDL_GetPixelFormatFromGPUTextureFormat(format);
        }

        public static SDL_GPUTextureFormat SDL_GetGPUTextureFormatFromPixelFormat(SDL_PixelFormat format)
        {
            return iSDL_GetGPUTextureFormatFromPixelFormat(format);
        }
    }
}