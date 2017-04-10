using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public static unsafe class Commands
    {
        /// <summary>
        /// 
        /// </summary>
        public const string VulkanDll = "vulkan-1.dll"; 
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateInstance(InstanceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Instance* pInstance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyInstance(Instance instance, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumeratePhysicalDevices(Instance instance, uint* pPhysicalDeviceCount, PhysicalDevice* pPhysicalDevices);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern VoidFunctionDelegate vkGetDeviceProcAddr(Device device, char* pName);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern VoidFunctionDelegate vkGetInstanceProcAddr(Instance instance, char* pName);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, QueueFamilyProperties* pQueueFamilyProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* pMemoryProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* pFeatures);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format, FormatProperties* pFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ImageFormatProperties* pImageFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Device* pDevice);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDevice(Device device, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateInstanceLayerProperties(uint* pPropertyCount, LayerProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateInstanceExtensionProperties(char* pLayerName, uint* pPropertyCount, ExtensionProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* pPropertyCount, LayerProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, char* pLayerName, uint* pPropertyCount, ExtensionProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* pQueue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueSubmit(Queue queue, uint submitCount, SubmitInfo* pSubmits, Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueWaitIdle(Queue queue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDeviceWaitIdle(Device device);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateMemory(Device device, MemoryAllocateInfo* pAllocateInfo, AllocationCallbacks* pAllocator, DeviceMemory* pMemory);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkMapMemory(Device device, DeviceMemory memory, DeviceSize offset, DeviceSize size, MemoryMapFlags flags, void** ppData);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnmapMemory(Device device, DeviceMemory memory);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkFlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* pMemoryRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkInvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* pMemoryRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceMemoryCommitment(Device device, DeviceMemory memory, DeviceSize* pCommittedMemoryInBytes);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* pMemoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements(Device device, Image image, MemoryRequirements* pMemoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindImageMemory(Device device, Image image, DeviceMemory memory, DeviceSize memoryOffset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements(Device device, Image image, uint* pSparseMemoryRequirementCount, SparseImageMemoryRequirements* pSparseMemoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, uint* pPropertyCount, SparseImageFormatProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* pBindInfo, Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateFence(Device device, FenceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Fence* pFence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFence(Device device, Fence fence, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetFences(Device device, uint fenceCount, Fence* pFences);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetFenceStatus(Device device, Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkWaitForFences(Device device, uint fenceCount, Fence* pFences, Bool32 waitAll, ulong timeout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSemaphore(Device device, SemaphoreCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Semaphore* pSemaphore);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateEvent(Device device, EventCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Event* pEvent);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyEvent(Device device, Event @event, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetEventStatus(Device device, Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkSetEvent(Device device, Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetEvent(Device device, Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateQueryPool(Device device, QueryPoolCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, QueryPool* pQueryPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, HostSize dataSize, void* pData, DeviceSize stride, QueryResultFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateBuffer(Device device, BufferCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Buffer* pBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateBufferView(Device device, BufferViewCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, BufferView* pView);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateImage(Device device, ImageCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Image* pImage);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImage(Device device, Image image, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSubresourceLayout(Device device, Image image, ImageSubresource* pSubresource, SubresourceLayout* pLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateImageView(Device device, ImageViewCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, ImageView* pView);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImageView(Device device, ImageView imageView, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateShaderModule(Device device, ShaderModuleCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, ShaderModule* pShaderModule);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreatePipelineCache(Device device, PipelineCacheCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, PipelineCache* pPipelineCache);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPipelineCacheData(Device device, PipelineCache pipelineCache, HostSize* pDataSize, void* pData);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkMergePipelineCaches(Device device, PipelineCache dstCache, uint srcCacheCount, PipelineCache* pSrcCaches);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* pCreateInfos, AllocationCallbacks* pAllocator, Pipeline* pPipelines);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* pCreateInfos, AllocationCallbacks* pAllocator, Pipeline* pPipelines);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreatePipelineLayout(Device device, PipelineLayoutCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, PipelineLayout* pPipelineLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSampler(Device device, SamplerCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Sampler* pSampler);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySampler(Device device, Sampler sampler, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DescriptorSetLayout* pSetLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorPool(Device device, DescriptorPoolCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DescriptorPool* pDescriptorPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetDescriptorPool(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* pAllocateInfo, DescriptorSet* pDescriptorSets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkFreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* pDescriptorSets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* pDescriptorCopies);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateFramebuffer(Device device, FramebufferCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Framebuffer* pFramebuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateRenderPass(Device device, RenderPassCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, RenderPass* pRenderPass);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* pGranularity);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateCommandPool(Device device, CommandPoolCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, CommandPool* pCommandPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetCommandPool(Device device, CommandPool commandPool, CommandPoolResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateCommandBuffers(Device device, CommandBufferAllocateInfo* pAllocateInfo, CommandBuffer* pCommandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* pCommandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* pBeginInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEndCommandBuffer(CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetCommandBuffer(CommandBuffer commandBuffer, CommandBufferResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* pViewports);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* pScissors);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetBlendConstants(CommandBuffer commandBuffer, float blendConstants);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilCompareMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilWriteMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilReference(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, IndexType indexType);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* pBuffers, DeviceSize* pOffsets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatch(CommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBuffer(CommandBuffer commandBuffer, Buffer srcBuffer, Buffer dstBuffer, uint regionCount, BufferCopy* pRegions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, uint regionCount, ImageCopy* pRegions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBlitImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, uint regionCount, ImageBlit* pRegions, Filter filter);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer srcBuffer, Image dstImage, ImageLayout dstImageLayout, uint regionCount, BufferImageCopy* pRegions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImageToBuffer(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Buffer dstBuffer, uint regionCount, BufferImageCopy* pRegions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdUpdateBuffer(CommandBuffer commandBuffer, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize dataSize, void* pData);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdFillBuffer(CommandBuffer commandBuffer, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize size, uint data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* pColor, uint rangeCount, ImageSubresourceRange* pRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* pDepthStencil, uint rangeCount, ImageSubresourceRange* pRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* pAttachments, uint rectCount, ClearRect* pRects);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResolveImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, uint regionCount, ImageResolve* pRegions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* pEvents, PipelineStageFlags srcStageMask, PipelineStageFlags dstStageMask, uint memoryBarrierCount, MemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* pImageMemoryBarriers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPipelineBarrier(CommandBuffer commandBuffer, PipelineStageFlags srcStageMask, PipelineStageFlags dstStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* pImageMemoryBarriers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize stride, QueryResultFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, void* pValues);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* pRenderPassBegin, SubpassContents contents);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass(CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* pCommandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateAndroidSurfaceKHR(Instance instance, AndroidSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceDisplayPropertiesKHR(PhysicalDevice physicalDevice, uint* pPropertyCount, DisplayProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR(PhysicalDevice physicalDevice, uint* pPropertyCount, DisplayPlaneProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayPlaneSupportedDisplaysKHR(PhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, Display* pDisplays);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayModePropertiesKHR(PhysicalDevice physicalDevice, Display display, uint* pPropertyCount, DisplayModeProperties* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDisplayModeKHR(PhysicalDevice physicalDevice, Display display, DisplayModeCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DisplayMode* pMode);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayPlaneCapabilitiesKHR(PhysicalDevice physicalDevice, DisplayMode mode, uint planeIndex, DisplayPlaneCapabilities* pCapabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDisplayPlaneSurfaceKHR(Instance instance, DisplaySurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSharedSwapchainsKHR(Device device, uint swapchainCount, SwapchainCreateInfo* pCreateInfos, AllocationCallbacks* pAllocator, Swapchain* pSwapchains);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateMirSurfaceKHR(Instance instance, MirSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceMirPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySurfaceKHR(Instance instance, Surface surface, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, Surface surface, Bool32* pSupported);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice physicalDevice, Surface surface, SurfaceCapabilities* pSurfaceCapabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice physicalDevice, Surface surface, uint* pSurfaceFormatCount, SurfaceFormat* pSurfaceFormats);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice physicalDevice, Surface surface, uint* pPresentModeCount, PresentMode* pPresentModes);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSwapchainKHR(Device device, SwapchainCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Swapchain* pSwapchain);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySwapchainKHR(Device device, Swapchain swapchain, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSwapchainImagesKHR(Device device, Swapchain swapchain, uint* pSwapchainImageCount, Image* pSwapchainImages);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireNextImageKHR(Device device, Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint* pImageIndex);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueuePresentKHR(Queue queue, PresentInfo* pPresentInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateViSurfaceNN(Instance instance, ViSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateWaylandSurfaceKHR(Instance instance, WaylandSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateWin32SurfaceKHR(Instance instance, Win32SurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateXlibSurfaceKHR(Instance instance, XlibSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* dpy, IntPtr visualID);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateXcbSurfaceKHR(Instance instance, XcbSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection, IntPtr visual_id);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDebugReportCallbackEXT(Instance instance, DebugReportCallbackCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DebugReportCallback* pCallback);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDebugReportCallbackEXT(Instance instance, DebugReportCallback callback, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDebugReportMessageEXT(Instance instance, DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, char* pLayerPrefix, char* pMessage);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDebugMarkerSetObjectNameEXT(Device device, DebugMarkerObjectNameInfo* pNameInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDebugMarkerSetObjectTagEXT(Device device, DebugMarkerObjectTagInfo* pTagInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerBeginEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* pMarkerInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerEndEXT(CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerInsertEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* pMarkerInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceExternalImageFormatPropertiesNV(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ExternalMemoryHandleTypeFlags externalHandleType, ExternalImageFormatProperties* pExternalImageFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandleNV(Device device, DeviceMemory memory, ExternalMemoryHandleTypeFlags handleType, IntPtr* pHandle);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdProcessCommandsNVX(CommandBuffer commandBuffer, CommandProcessCommandsInfo* pProcessCommandsInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdReserveSpaceForCommandsNVX(CommandBuffer commandBuffer, CommandReserveSpaceForCommandsInfo* pReserveSpaceInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateIndirectCommandsLayoutNVX(Device device, IndirectCommandsLayoutCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, IndirectCommandsLayout* pIndirectCommandsLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyIndirectCommandsLayoutNVX(Device device, IndirectCommandsLayout indirectCommandsLayout, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateObjectTableNVX(Device device, ObjectTableCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, ObjectTable* pObjectTable);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyObjectTableNVX(Device device, ObjectTable objectTable, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterObjectsNVX(Device device, ObjectTable objectTable, uint objectCount, ObjectTableEntry** ppObjectTableEntries, uint* pObjectIndices);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkUnregisterObjectsNVX(Device device, ObjectTable objectTable, uint objectCount, ObjectEntryType* pObjectEntryTypes, uint* pObjectIndices);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(PhysicalDevice physicalDevice, DeviceGeneratedCommandsFeatures* pFeatures, DeviceGeneratedCommandsLimits* pLimits);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures2KHR(PhysicalDevice physicalDevice, PhysicalDeviceFeatures2* pFeatures);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceProperties2* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR(PhysicalDevice physicalDevice, Format format, FormatProperties2* pFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceImageFormatProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceImageFormatInfo2* pImageFormatInfo, ImageFormatProperties2* pImageFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR(PhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, QueueFamilyProperties2* pQueueFamilyProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties2* pMemoryProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, SparseImageFormatProperties2* pProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetKHR(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint set, uint descriptorWriteCount, WriteDescriptorSet* pDescriptorWrites);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkTrimCommandPoolKHR(Device device, CommandPool commandPool, CommandPoolTrimFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHX(PhysicalDevice physicalDevice, PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, ExternalBufferProperties* pExternalBufferProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandleKHX(Device device, DeviceMemory memory, ExternalMemoryHandleTypeFlags handleType, IntPtr* pHandle);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandlePropertiesKHX(Device device, ExternalMemoryHandleTypeFlags handleType, IntPtr handle, MemoryWin32HandleProperties* pMemoryWin32HandleProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryFdKHX(Device device, DeviceMemory memory, ExternalMemoryHandleTypeFlags handleType, int* pFd);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryFdPropertiesKHX(Device device, ExternalMemoryHandleTypeFlags handleType, int fd, MemoryFileDescriptorProperties* pMemoryFdProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHX(PhysicalDevice physicalDevice, PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, ExternalSemaphoreProperties* pExternalSemaphoreProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSemaphoreWin32HandleKHX(Device device, Semaphore semaphore, ExternalSemaphoreHandleTypeFlags handleType, IntPtr* pHandle);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkImportSemaphoreWin32HandleKHX(Device device, ImportSemaphoreWin32HandleInfo* pImportSemaphoreWin32HandleInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSemaphoreFdKHX(Device device, Semaphore semaphore, ExternalSemaphoreHandleTypeFlags handleType, int* pFd);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkImportSemaphoreFdKHX(Device device, ImportSemaphoreFileDescriptorInfo* pImportSemaphoreFdInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkReleaseDisplayEXT(PhysicalDevice physicalDevice, Display display);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireXlibDisplayEXT(PhysicalDevice physicalDevice, IntPtr* dpy, Display display);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetRandROutputDisplayEXT(PhysicalDevice physicalDevice, IntPtr* dpy, IntPtr rrOutput, Display* pDisplay);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDisplayPowerControlEXT(Device device, Display display, DisplayPowerInfo* pDisplayPowerInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterDeviceEventEXT(Device device, DeviceEventInfo* pDeviceEventInfo, AllocationCallbacks* pAllocator, Fence* pFence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterDisplayEventEXT(Device device, Display display, DisplayEventInfo* pDisplayEventInfo, AllocationCallbacks* pAllocator, Fence* pFence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSwapchainCounterEXT(Device device, Swapchain swapchain, SurfaceCounterFlags counter, ulong* pCounterValue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceCapabilities2EXT(PhysicalDevice physicalDevice, Surface surface, SurfaceCapabilities2* pSurfaceCapabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumeratePhysicalDeviceGroupsKHX(Instance instance, uint* pPhysicalDeviceGroupCount, PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHX(Device device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, PeerMemoryFeatureFlags* pPeerMemoryFeatures);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindBufferMemory2KHX(Device device, uint bindInfoCount, BindBufferMemoryInfo* pBindInfos);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindImageMemory2KHX(Device device, uint bindInfoCount, BindImageMemoryInfo* pBindInfos);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDeviceMaskKHX(CommandBuffer commandBuffer, uint deviceMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDeviceGroupPresentCapabilitiesKHX(Device device, DeviceGroupPresentCapabilities* pDeviceGroupPresentCapabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDeviceGroupSurfacePresentModesKHX(Device device, Surface surface, DeviceGroupPresentModeFlags* pModes);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireNextImage2KHX(Device device, AcquireNextImageInfo* pAcquireInfo, uint* pImageIndex);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchBaseKHX(CommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDevicePresentRectanglesKHX(PhysicalDevice physicalDevice, Surface surface, uint* pRectCount, Rect2D* pRects);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorUpdateTemplateKHR(Device device, DescriptorUpdateTemplateCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DescriptorUpdateTemplate* pDescriptorUpdateTemplate);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR(Device device, DescriptorUpdateTemplate descriptorUpdateTemplate, AllocationCallbacks* pAllocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR(Device device, DescriptorSet descriptorSet, DescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR(CommandBuffer commandBuffer, DescriptorUpdateTemplate descriptorUpdateTemplate, PipelineLayout layout, uint set, void* pData);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetHdrMetadataEXT(Device device, uint swapchainCount, Swapchain* pSwapchains, HdrMetadata* pMetadata);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetRefreshCycleDurationGOOGLE(Device device, Swapchain swapchain, RefreshCycleDuration* pDisplayTimingProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPastPresentationTimingGOOGLE(Device device, Swapchain swapchain, uint* pPresentationTimingCount, PastPresentationTiming* pPresentationTimings);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateIOSSurfaceMVK(Instance instance, IOSSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateMacOSSurfaceMVK(Instance instance, MacOSSurfaceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, Surface* pSurface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewportWScalingNV(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ViewportWScaling* pViewportWScalings);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDiscardRectangleEXT(CommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, Rect2D* pDiscardRectangles);
    }
}
