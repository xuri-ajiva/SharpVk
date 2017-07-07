// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.Khronos.Swapchain[] CreateSharedSwapchains(this SharpVk.Device extendedHandle, SharpVk.Khronos.SwapchainCreateInfo[] createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain[] result = default(SharpVk.Khronos.Swapchain[]);
                CommandCache commandCache = default(CommandCache);
                uint swapchainCount = default(uint);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                commandCache = extendedHandle.commandCache;
                swapchainCount = (uint)(createInfos?.Length ?? 0);
                if (createInfos != null)
                {
                    var fieldPointer = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.SwapchainCreateInfo>(createInfos.Length).ToPointer());
                    for(int index = 0; index < (uint)(createInfos.Length); index++)
                    {
                        createInfos[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledCreateInfos = fieldPointer;
                }
                else
                {
                    marshalledCreateInfos = null;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(swapchainCount));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate>("vkCreateSharedSwapchainsKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, swapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledSwapchains != null)
                {
                    var fieldPointer = new SharpVk.Khronos.Swapchain[(uint)(swapchainCount)];
                    for(int index = 0; index < (uint)(swapchainCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchains[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.Khronos.Swapchain CreateSwapchain(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface, uint minImageCount, SharpVk.Format imageFormat, SharpVk.Khronos.ColorSpace imageColorSpace, SharpVk.Extent2D imageExtent, uint imageArrayLayers, SharpVk.ImageUsageFlags imageUsage, SharpVk.SharingMode imageSharingMode, uint[] queueFamilyIndices, SharpVk.Khronos.SurfaceTransformFlags preTransform, SharpVk.Khronos.CompositeAlphaFlags compositeAlpha, SharpVk.Khronos.PresentMode presentMode, bool clipped, SharpVk.Khronos.Swapchain oldSwapchain, SharpVk.Khronos.SwapchainCreateFlags? flags = default(SharpVk.Khronos.SwapchainCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain result = default(SharpVk.Khronos.Swapchain);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain marshalledSwapchain = default(SharpVk.Interop.Khronos.Swapchain);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SwapchainCreateInfoKhr;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.SwapchainCreateFlags);
                }
                marshalledCreateInfo->Surface = surface?.handle ?? default(SharpVk.Interop.Khronos.Surface);
                marshalledCreateInfo->MinImageCount = minImageCount;
                marshalledCreateInfo->ImageFormat = imageFormat;
                marshalledCreateInfo->ImageColorSpace = imageColorSpace;
                marshalledCreateInfo->ImageExtent = imageExtent;
                marshalledCreateInfo->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfo->ImageUsage = imageUsage;
                marshalledCreateInfo->ImageSharingMode = imageSharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(queueFamilyIndices?.Length ?? 0);
                if (queueFamilyIndices != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(queueFamilyIndices.Length).ToPointer());
                    for(int index = 0; index < (uint)(queueFamilyIndices.Length); index++)
                    {
                        fieldPointer[index] = queueFamilyIndices[index];
                    }
                    marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                marshalledCreateInfo->PreTransform = preTransform;
                marshalledCreateInfo->CompositeAlpha = compositeAlpha;
                marshalledCreateInfo->PresentMode = presentMode;
                marshalledCreateInfo->Clipped = clipped;
                marshalledCreateInfo->OldSwapchain = oldSwapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate>("vkCreateSwapchainKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSwapchain);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchain);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe SharpVk.Khronos.DescriptorUpdateTemplate CreateDescriptorUpdateTemplate(this SharpVk.Device extendedHandle, SharpVk.Khronos.DescriptorUpdateTemplateEntry[] descriptorUpdateEntries, SharpVk.Khronos.DescriptorUpdateTemplateType templateType, SharpVk.DescriptorSetLayout descriptorSetLayout, SharpVk.PipelineLayout pipelineLayout, SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags? flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags?), SharpVk.PipelineBindPoint? pipelineBindPoint = default(SharpVk.PipelineBindPoint?), uint? set = default(uint?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.DescriptorUpdateTemplate result = default(SharpVk.Khronos.DescriptorUpdateTemplate);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.DescriptorUpdateTemplate marshalledDescriptorUpdateTemplate = default(SharpVk.Interop.Khronos.DescriptorUpdateTemplate);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DescriptorUpdateTemplateCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorUpdateTemplateCreateInfoKhr;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.DescriptorUpdateTemplateCreateFlags);
                }
                marshalledCreateInfo->DescriptorUpdateEntryCount = (uint)(descriptorUpdateEntries?.Length ?? 0);
                if (descriptorUpdateEntries != null)
                {
                    var fieldPointer = (SharpVk.Khronos.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khronos.DescriptorUpdateTemplateEntry>(descriptorUpdateEntries.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorUpdateEntries.Length); index++)
                    {
                        fieldPointer[index] = descriptorUpdateEntries[index];
                    }
                    marshalledCreateInfo->DescriptorUpdateEntries = fieldPointer;
                }
                else
                {
                    marshalledCreateInfo->DescriptorUpdateEntries = null;
                }
                marshalledCreateInfo->TemplateType = templateType;
                marshalledCreateInfo->DescriptorSetLayout = descriptorSetLayout?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                if (pipelineBindPoint != null)
                {
                    marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint.Value;
                }
                else
                {
                    marshalledCreateInfo->PipelineBindPoint = default(SharpVk.PipelineBindPoint);
                }
                marshalledCreateInfo->PipelineLayout = pipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                if (set != null)
                {
                    marshalledCreateInfo->Set = set.Value;
                }
                else
                {
                    marshalledCreateInfo->Set = default(uint);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateDescriptorUpdateTemplateDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceCreateDescriptorUpdateTemplateDelegate>("vkCreateDescriptorUpdateTemplateKHR", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorUpdateTemplate);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.DescriptorUpdateTemplate(extendedHandle, marshalledDescriptorUpdateTemplate);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe void UpdateDescriptorSetWithTemplate(this SharpVk.Device extendedHandle, SharpVk.DescriptorSet descriptorSet, SharpVk.Khronos.DescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceUpdateDescriptorSetWithTemplateDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkDeviceUpdateDescriptorSetWithTemplateDelegate>("vkUpdateDescriptorSetWithTemplateKHR", "instance");
                commandDelegate(extendedHandle.handle, descriptorSet?.handle ?? default(SharpVk.Interop.DescriptorSet), descriptorUpdateTemplate?.handle ?? default(SharpVk.Interop.Khronos.DescriptorUpdateTemplate), data.ToPointer());
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
