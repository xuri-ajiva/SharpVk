
using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
	public struct Bool32
	{
		private uint value;

		public Bool32(bool value)
		{
			this.value = value ? 1u : 0;
		}

		public static implicit operator Bool32(bool value)
		{
			return new Bool32(value);
		}

		public static implicit operator bool(Bool32 value)
		{
			return value.value != 0;
		}
	}

	public struct DeviceSize
	{
		private ulong value;

		public static implicit operator DeviceSize(ulong iValue)
		{
			return new DeviceSize { value = iValue };
		}

		public static implicit operator ulong(DeviceSize size)
		{
			return size.value;
		}
	}

	public unsafe struct VkOffset2D
	{
		public static VkOffset2D* Create()
		{
			return (VkOffset2D*)HeapUtil.AllocateAndClear<VkOffset2D>();
		}

	}

	public unsafe struct VkOffset3D
	{
		public static VkOffset3D* Create()
		{
			return (VkOffset3D*)HeapUtil.AllocateAndClear<VkOffset3D>();
		}

	}

	public unsafe struct VkExtent2D
	{
		public static VkExtent2D* Create()
		{
			return (VkExtent2D*)HeapUtil.AllocateAndClear<VkExtent2D>();
		}

	}

	public unsafe struct VkExtent3D
	{
		public static VkExtent3D* Create()
		{
			return (VkExtent3D*)HeapUtil.AllocateAndClear<VkExtent3D>();
		}

	}

	public unsafe struct VkViewport
	{
		public static VkViewport* Create()
		{
			return (VkViewport*)HeapUtil.AllocateAndClear<VkViewport>();
		}

	}

	public unsafe struct VkRect2D
	{
		public static VkRect2D* Create()
		{
			return (VkRect2D*)HeapUtil.AllocateAndClear<VkRect2D>();
		}

	}

	public unsafe struct VkRect3D
	{
		public static VkRect3D* Create()
		{
			return (VkRect3D*)HeapUtil.AllocateAndClear<VkRect3D>();
		}

	}

	public unsafe struct VkClearRect
	{
		public static VkClearRect* Create()
		{
			return (VkClearRect*)HeapUtil.AllocateAndClear<VkClearRect>();
		}

	}

	public unsafe struct VkComponentMapping
	{
		public static VkComponentMapping* Create()
		{
			return (VkComponentMapping*)HeapUtil.AllocateAndClear<VkComponentMapping>();
		}

	}

	public unsafe struct VkPhysicalDeviceProperties
	{
		public static VkPhysicalDeviceProperties* Create()
		{
			return (VkPhysicalDeviceProperties*)HeapUtil.AllocateAndClear<VkPhysicalDeviceProperties>();
		}

	}

	public unsafe struct VkExtensionProperties
	{
		public static VkExtensionProperties* Create()
		{
			return (VkExtensionProperties*)HeapUtil.AllocateAndClear<VkExtensionProperties>();
		}

	}

	public unsafe struct VkLayerProperties
	{
		public static VkLayerProperties* Create()
		{
			return (VkLayerProperties*)HeapUtil.AllocateAndClear<VkLayerProperties>();
		}

	}

	public unsafe struct VkApplicationInfo
	{
		public static VkApplicationInfo* Create()
		{
			return (VkApplicationInfo*)HeapUtil.AllocateAndClear<VkApplicationInfo>();
		}

	}

	public unsafe struct VkAllocationCallbacks
	{
		public static VkAllocationCallbacks* Create()
		{
			return (VkAllocationCallbacks*)HeapUtil.AllocateAndClear<VkAllocationCallbacks>();
		}

	}

	public unsafe struct VkDeviceQueueCreateInfo
	{
		public static VkDeviceQueueCreateInfo* Create()
		{
			return (VkDeviceQueueCreateInfo*)HeapUtil.AllocateAndClear<VkDeviceQueueCreateInfo>();
		}

	}

	public unsafe struct VkDeviceCreateInfo
	{
		public static VkDeviceCreateInfo* Create()
		{
			return (VkDeviceCreateInfo*)HeapUtil.AllocateAndClear<VkDeviceCreateInfo>();
		}

	}

	public unsafe struct VkInstanceCreateInfo
	{
		public static VkInstanceCreateInfo* Create()
		{
			return (VkInstanceCreateInfo*)HeapUtil.AllocateAndClear<VkInstanceCreateInfo>();
		}

	}

	public unsafe struct VkQueueFamilyProperties
	{
		public static VkQueueFamilyProperties* Create()
		{
			return (VkQueueFamilyProperties*)HeapUtil.AllocateAndClear<VkQueueFamilyProperties>();
		}

	}

	public unsafe struct VkPhysicalDeviceMemoryProperties
	{
		public static VkPhysicalDeviceMemoryProperties* Create()
		{
			return (VkPhysicalDeviceMemoryProperties*)HeapUtil.AllocateAndClear<VkPhysicalDeviceMemoryProperties>();
		}

	}

	public unsafe struct VkMemoryAllocateInfo
	{
		public static VkMemoryAllocateInfo* Create()
		{
			return (VkMemoryAllocateInfo*)HeapUtil.AllocateAndClear<VkMemoryAllocateInfo>();
		}

	}

	public unsafe struct VkMemoryRequirements
	{
		public static VkMemoryRequirements* Create()
		{
			return (VkMemoryRequirements*)HeapUtil.AllocateAndClear<VkMemoryRequirements>();
		}

	}

	public unsafe struct VkSparseImageFormatProperties
	{
		public static VkSparseImageFormatProperties* Create()
		{
			return (VkSparseImageFormatProperties*)HeapUtil.AllocateAndClear<VkSparseImageFormatProperties>();
		}

	}

	public unsafe struct VkSparseImageMemoryRequirements
	{
		public static VkSparseImageMemoryRequirements* Create()
		{
			return (VkSparseImageMemoryRequirements*)HeapUtil.AllocateAndClear<VkSparseImageMemoryRequirements>();
		}

	}

	public unsafe struct VkMemoryType
	{
		public static VkMemoryType* Create()
		{
			return (VkMemoryType*)HeapUtil.AllocateAndClear<VkMemoryType>();
		}

	}

	public unsafe struct VkMemoryHeap
	{
		public static VkMemoryHeap* Create()
		{
			return (VkMemoryHeap*)HeapUtil.AllocateAndClear<VkMemoryHeap>();
		}

	}

	public unsafe struct VkMappedMemoryRange
	{
		public static VkMappedMemoryRange* Create()
		{
			return (VkMappedMemoryRange*)HeapUtil.AllocateAndClear<VkMappedMemoryRange>();
		}

	}

	public unsafe struct VkFormatProperties
	{
		public static VkFormatProperties* Create()
		{
			return (VkFormatProperties*)HeapUtil.AllocateAndClear<VkFormatProperties>();
		}

	}

	public unsafe struct VkImageFormatProperties
	{
		public static VkImageFormatProperties* Create()
		{
			return (VkImageFormatProperties*)HeapUtil.AllocateAndClear<VkImageFormatProperties>();
		}

	}

	public unsafe struct VkDescriptorBufferInfo
	{
		public static VkDescriptorBufferInfo* Create()
		{
			return (VkDescriptorBufferInfo*)HeapUtil.AllocateAndClear<VkDescriptorBufferInfo>();
		}

	}

	public unsafe struct VkDescriptorImageInfo
	{
		public static VkDescriptorImageInfo* Create()
		{
			return (VkDescriptorImageInfo*)HeapUtil.AllocateAndClear<VkDescriptorImageInfo>();
		}

	}

	public unsafe struct VkWriteDescriptorSet
	{
		public static VkWriteDescriptorSet* Create()
		{
			return (VkWriteDescriptorSet*)HeapUtil.AllocateAndClear<VkWriteDescriptorSet>();
		}

	}

	public unsafe struct VkCopyDescriptorSet
	{
		public static VkCopyDescriptorSet* Create()
		{
			return (VkCopyDescriptorSet*)HeapUtil.AllocateAndClear<VkCopyDescriptorSet>();
		}

	}

	public unsafe struct VkBufferCreateInfo
	{
		public static VkBufferCreateInfo* Create()
		{
			return (VkBufferCreateInfo*)HeapUtil.AllocateAndClear<VkBufferCreateInfo>();
		}

	}

	public unsafe struct VkBufferViewCreateInfo
	{
		public static VkBufferViewCreateInfo* Create()
		{
			return (VkBufferViewCreateInfo*)HeapUtil.AllocateAndClear<VkBufferViewCreateInfo>();
		}

	}

	public unsafe struct VkImageSubresource
	{
		public static VkImageSubresource* Create()
		{
			return (VkImageSubresource*)HeapUtil.AllocateAndClear<VkImageSubresource>();
		}

	}

	public unsafe struct VkImageSubresourceLayers
	{
		public static VkImageSubresourceLayers* Create()
		{
			return (VkImageSubresourceLayers*)HeapUtil.AllocateAndClear<VkImageSubresourceLayers>();
		}

	}

	public unsafe struct VkImageSubresourceRange
	{
		public static VkImageSubresourceRange* Create()
		{
			return (VkImageSubresourceRange*)HeapUtil.AllocateAndClear<VkImageSubresourceRange>();
		}

	}

	public unsafe struct VkMemoryBarrier
	{
		public static VkMemoryBarrier* Create()
		{
			return (VkMemoryBarrier*)HeapUtil.AllocateAndClear<VkMemoryBarrier>();
		}

	}

	public unsafe struct VkBufferMemoryBarrier
	{
		public static VkBufferMemoryBarrier* Create()
		{
			return (VkBufferMemoryBarrier*)HeapUtil.AllocateAndClear<VkBufferMemoryBarrier>();
		}

	}

	public unsafe struct VkImageMemoryBarrier
	{
		public static VkImageMemoryBarrier* Create()
		{
			return (VkImageMemoryBarrier*)HeapUtil.AllocateAndClear<VkImageMemoryBarrier>();
		}

	}

	public unsafe struct VkImageCreateInfo
	{
		public static VkImageCreateInfo* Create()
		{
			return (VkImageCreateInfo*)HeapUtil.AllocateAndClear<VkImageCreateInfo>();
		}

	}

	public unsafe struct VkSubresourceLayout
	{
		public static VkSubresourceLayout* Create()
		{
			return (VkSubresourceLayout*)HeapUtil.AllocateAndClear<VkSubresourceLayout>();
		}

	}

	public unsafe struct VkImageViewCreateInfo
	{
		public static VkImageViewCreateInfo* Create()
		{
			return (VkImageViewCreateInfo*)HeapUtil.AllocateAndClear<VkImageViewCreateInfo>();
		}

	}

	public unsafe struct VkBufferCopy
	{
		public static VkBufferCopy* Create()
		{
			return (VkBufferCopy*)HeapUtil.AllocateAndClear<VkBufferCopy>();
		}

	}

	public unsafe struct VkSparseMemoryBind
	{
		public static VkSparseMemoryBind* Create()
		{
			return (VkSparseMemoryBind*)HeapUtil.AllocateAndClear<VkSparseMemoryBind>();
		}

	}

	public unsafe struct VkSparseImageMemoryBind
	{
		public static VkSparseImageMemoryBind* Create()
		{
			return (VkSparseImageMemoryBind*)HeapUtil.AllocateAndClear<VkSparseImageMemoryBind>();
		}

	}

	public unsafe struct VkSparseBufferMemoryBindInfo
	{
		public static VkSparseBufferMemoryBindInfo* Create()
		{
			return (VkSparseBufferMemoryBindInfo*)HeapUtil.AllocateAndClear<VkSparseBufferMemoryBindInfo>();
		}

	}

	public unsafe struct VkSparseImageOpaqueMemoryBindInfo
	{
		public static VkSparseImageOpaqueMemoryBindInfo* Create()
		{
			return (VkSparseImageOpaqueMemoryBindInfo*)HeapUtil.AllocateAndClear<VkSparseImageOpaqueMemoryBindInfo>();
		}

	}

	public unsafe struct VkSparseImageMemoryBindInfo
	{
		public static VkSparseImageMemoryBindInfo* Create()
		{
			return (VkSparseImageMemoryBindInfo*)HeapUtil.AllocateAndClear<VkSparseImageMemoryBindInfo>();
		}

	}

	public unsafe struct VkBindSparseInfo
	{
		public static VkBindSparseInfo* Create()
		{
			return (VkBindSparseInfo*)HeapUtil.AllocateAndClear<VkBindSparseInfo>();
		}

	}

	public unsafe struct VkImageCopy
	{
		public static VkImageCopy* Create()
		{
			return (VkImageCopy*)HeapUtil.AllocateAndClear<VkImageCopy>();
		}

	}

	public unsafe struct VkImageBlit
	{
		public static VkImageBlit* Create()
		{
			return (VkImageBlit*)HeapUtil.AllocateAndClear<VkImageBlit>();
		}

	}

	public unsafe struct VkBufferImageCopy
	{
		public static VkBufferImageCopy* Create()
		{
			return (VkBufferImageCopy*)HeapUtil.AllocateAndClear<VkBufferImageCopy>();
		}

	}

	public unsafe struct VkImageResolve
	{
		public static VkImageResolve* Create()
		{
			return (VkImageResolve*)HeapUtil.AllocateAndClear<VkImageResolve>();
		}

	}

	public unsafe struct VkShaderModuleCreateInfo
	{
		public static VkShaderModuleCreateInfo* Create()
		{
			return (VkShaderModuleCreateInfo*)HeapUtil.AllocateAndClear<VkShaderModuleCreateInfo>();
		}

	}

	public unsafe struct VkDescriptorSetLayoutBinding
	{
		public static VkDescriptorSetLayoutBinding* Create()
		{
			return (VkDescriptorSetLayoutBinding*)HeapUtil.AllocateAndClear<VkDescriptorSetLayoutBinding>();
		}

	}

	public unsafe struct VkDescriptorSetLayoutCreateInfo
	{
		public static VkDescriptorSetLayoutCreateInfo* Create()
		{
			return (VkDescriptorSetLayoutCreateInfo*)HeapUtil.AllocateAndClear<VkDescriptorSetLayoutCreateInfo>();
		}

	}

	public unsafe struct VkDescriptorPoolSize
	{
		public static VkDescriptorPoolSize* Create()
		{
			return (VkDescriptorPoolSize*)HeapUtil.AllocateAndClear<VkDescriptorPoolSize>();
		}

	}

	public unsafe struct VkDescriptorPoolCreateInfo
	{
		public static VkDescriptorPoolCreateInfo* Create()
		{
			return (VkDescriptorPoolCreateInfo*)HeapUtil.AllocateAndClear<VkDescriptorPoolCreateInfo>();
		}

	}

	public unsafe struct VkDescriptorSetAllocateInfo
	{
		public static VkDescriptorSetAllocateInfo* Create()
		{
			return (VkDescriptorSetAllocateInfo*)HeapUtil.AllocateAndClear<VkDescriptorSetAllocateInfo>();
		}

	}

	public unsafe struct VkSpecializationMapEntry
	{
		public static VkSpecializationMapEntry* Create()
		{
			return (VkSpecializationMapEntry*)HeapUtil.AllocateAndClear<VkSpecializationMapEntry>();
		}

	}

	public unsafe struct VkSpecializationInfo
	{
		public static VkSpecializationInfo* Create()
		{
			return (VkSpecializationInfo*)HeapUtil.AllocateAndClear<VkSpecializationInfo>();
		}

	}

	public unsafe struct VkPipelineShaderStageCreateInfo
	{
		public static VkPipelineShaderStageCreateInfo* Create()
		{
			return (VkPipelineShaderStageCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineShaderStageCreateInfo>();
		}

	}

	public unsafe struct VkComputePipelineCreateInfo
	{
		public static VkComputePipelineCreateInfo* Create()
		{
			return (VkComputePipelineCreateInfo*)HeapUtil.AllocateAndClear<VkComputePipelineCreateInfo>();
		}

	}

	public unsafe struct VkVertexInputBindingDescription
	{
		public static VkVertexInputBindingDescription* Create()
		{
			return (VkVertexInputBindingDescription*)HeapUtil.AllocateAndClear<VkVertexInputBindingDescription>();
		}

	}

	public unsafe struct VkVertexInputAttributeDescription
	{
		public static VkVertexInputAttributeDescription* Create()
		{
			return (VkVertexInputAttributeDescription*)HeapUtil.AllocateAndClear<VkVertexInputAttributeDescription>();
		}

	}

	public unsafe struct VkPipelineVertexInputStateCreateInfo
	{
		public static VkPipelineVertexInputStateCreateInfo* Create()
		{
			return (VkPipelineVertexInputStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineVertexInputStateCreateInfo>();
		}

	}

	public unsafe struct VkPipelineInputAssemblyStateCreateInfo
	{
		public static VkPipelineInputAssemblyStateCreateInfo* Create()
		{
			return (VkPipelineInputAssemblyStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineInputAssemblyStateCreateInfo>();
		}

	}

	public unsafe struct VkPipelineTessellationStateCreateInfo
	{
		public static VkPipelineTessellationStateCreateInfo* Create()
		{
			return (VkPipelineTessellationStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineTessellationStateCreateInfo>();
		}

	}

	public unsafe struct VkPipelineViewportStateCreateInfo
	{
		public static VkPipelineViewportStateCreateInfo* Create()
		{
			return (VkPipelineViewportStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineViewportStateCreateInfo>();
		}

	}

	public unsafe struct VkPipelineRasterizationStateCreateInfo
	{
		public static VkPipelineRasterizationStateCreateInfo* Create()
		{
			return (VkPipelineRasterizationStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineRasterizationStateCreateInfo>();
		}

	}

	public unsafe struct VkPipelineMultisampleStateCreateInfo
	{
		public static VkPipelineMultisampleStateCreateInfo* Create()
		{
			return (VkPipelineMultisampleStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineMultisampleStateCreateInfo>();
		}

	}

	public unsafe struct VkPipelineColorBlendAttachmentState
	{
		public static VkPipelineColorBlendAttachmentState* Create()
		{
			return (VkPipelineColorBlendAttachmentState*)HeapUtil.AllocateAndClear<VkPipelineColorBlendAttachmentState>();
		}

	}

	public unsafe struct VkPipelineColorBlendStateCreateInfo
	{
		public static VkPipelineColorBlendStateCreateInfo* Create()
		{
			return (VkPipelineColorBlendStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineColorBlendStateCreateInfo>();
		}

	}

	public unsafe struct VkPipelineDynamicStateCreateInfo
	{
		public static VkPipelineDynamicStateCreateInfo* Create()
		{
			return (VkPipelineDynamicStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineDynamicStateCreateInfo>();
		}

	}

	public unsafe struct VkStencilOpState
	{
		public static VkStencilOpState* Create()
		{
			return (VkStencilOpState*)HeapUtil.AllocateAndClear<VkStencilOpState>();
		}

	}

	public unsafe struct VkPipelineDepthStencilStateCreateInfo
	{
		public static VkPipelineDepthStencilStateCreateInfo* Create()
		{
			return (VkPipelineDepthStencilStateCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineDepthStencilStateCreateInfo>();
		}

	}

	public unsafe struct VkGraphicsPipelineCreateInfo
	{
		public static VkGraphicsPipelineCreateInfo* Create()
		{
			return (VkGraphicsPipelineCreateInfo*)HeapUtil.AllocateAndClear<VkGraphicsPipelineCreateInfo>();
		}

	}

	public unsafe struct VkPipelineCacheCreateInfo
	{
		public static VkPipelineCacheCreateInfo* Create()
		{
			return (VkPipelineCacheCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineCacheCreateInfo>();
		}

	}

	public unsafe struct VkPushConstantRange
	{
		public static VkPushConstantRange* Create()
		{
			return (VkPushConstantRange*)HeapUtil.AllocateAndClear<VkPushConstantRange>();
		}

	}

	public unsafe struct VkPipelineLayoutCreateInfo
	{
		public static VkPipelineLayoutCreateInfo* Create()
		{
			return (VkPipelineLayoutCreateInfo*)HeapUtil.AllocateAndClear<VkPipelineLayoutCreateInfo>();
		}

	}

	public unsafe struct VkSamplerCreateInfo
	{
		public static VkSamplerCreateInfo* Create()
		{
			return (VkSamplerCreateInfo*)HeapUtil.AllocateAndClear<VkSamplerCreateInfo>();
		}

	}

	public unsafe struct VkCommandPoolCreateInfo
	{
		public static VkCommandPoolCreateInfo* Create()
		{
			return (VkCommandPoolCreateInfo*)HeapUtil.AllocateAndClear<VkCommandPoolCreateInfo>();
		}

	}

	public unsafe struct VkCommandBufferAllocateInfo
	{
		public static VkCommandBufferAllocateInfo* Create()
		{
			return (VkCommandBufferAllocateInfo*)HeapUtil.AllocateAndClear<VkCommandBufferAllocateInfo>();
		}

	}

	public unsafe struct VkCommandBufferInheritanceInfo
	{
		public static VkCommandBufferInheritanceInfo* Create()
		{
			return (VkCommandBufferInheritanceInfo*)HeapUtil.AllocateAndClear<VkCommandBufferInheritanceInfo>();
		}

	}

	public unsafe struct VkCommandBufferBeginInfo
	{
		public static VkCommandBufferBeginInfo* Create()
		{
			return (VkCommandBufferBeginInfo*)HeapUtil.AllocateAndClear<VkCommandBufferBeginInfo>();
		}

	}

	public unsafe struct VkRenderPassBeginInfo
	{
		public static VkRenderPassBeginInfo* Create()
		{
			return (VkRenderPassBeginInfo*)HeapUtil.AllocateAndClear<VkRenderPassBeginInfo>();
		}

	}

	public unsafe struct VkClearDepthStencilValue
	{
		public static VkClearDepthStencilValue* Create()
		{
			return (VkClearDepthStencilValue*)HeapUtil.AllocateAndClear<VkClearDepthStencilValue>();
		}

	}

	public unsafe struct VkClearAttachment
	{
		public static VkClearAttachment* Create()
		{
			return (VkClearAttachment*)HeapUtil.AllocateAndClear<VkClearAttachment>();
		}

	}

	public unsafe struct VkAttachmentDescription
	{
		public static VkAttachmentDescription* Create()
		{
			return (VkAttachmentDescription*)HeapUtil.AllocateAndClear<VkAttachmentDescription>();
		}

	}

	public unsafe struct VkAttachmentReference
	{
		public static VkAttachmentReference* Create()
		{
			return (VkAttachmentReference*)HeapUtil.AllocateAndClear<VkAttachmentReference>();
		}

	}

	public unsafe struct VkSubpassDescription
	{
		public static VkSubpassDescription* Create()
		{
			return (VkSubpassDescription*)HeapUtil.AllocateAndClear<VkSubpassDescription>();
		}

	}

	public unsafe struct VkSubpassDependency
	{
		public static VkSubpassDependency* Create()
		{
			return (VkSubpassDependency*)HeapUtil.AllocateAndClear<VkSubpassDependency>();
		}

	}

	public unsafe struct VkRenderPassCreateInfo
	{
		public static VkRenderPassCreateInfo* Create()
		{
			return (VkRenderPassCreateInfo*)HeapUtil.AllocateAndClear<VkRenderPassCreateInfo>();
		}

	}

	public unsafe struct VkEventCreateInfo
	{
		public static VkEventCreateInfo* Create()
		{
			return (VkEventCreateInfo*)HeapUtil.AllocateAndClear<VkEventCreateInfo>();
		}

	}

	public unsafe struct VkFenceCreateInfo
	{
		public static VkFenceCreateInfo* Create()
		{
			return (VkFenceCreateInfo*)HeapUtil.AllocateAndClear<VkFenceCreateInfo>();
		}

	}

	public unsafe struct VkPhysicalDeviceFeatures
	{
		public static VkPhysicalDeviceFeatures* Create()
		{
			return (VkPhysicalDeviceFeatures*)HeapUtil.AllocateAndClear<VkPhysicalDeviceFeatures>();
		}

	}

	public unsafe struct VkPhysicalDeviceSparseProperties
	{
		public static VkPhysicalDeviceSparseProperties* Create()
		{
			return (VkPhysicalDeviceSparseProperties*)HeapUtil.AllocateAndClear<VkPhysicalDeviceSparseProperties>();
		}

	}

	public unsafe struct VkPhysicalDeviceLimits
	{
		public static VkPhysicalDeviceLimits* Create()
		{
			return (VkPhysicalDeviceLimits*)HeapUtil.AllocateAndClear<VkPhysicalDeviceLimits>();
		}

	}

	public unsafe struct VkSemaphoreCreateInfo
	{
		public static VkSemaphoreCreateInfo* Create()
		{
			return (VkSemaphoreCreateInfo*)HeapUtil.AllocateAndClear<VkSemaphoreCreateInfo>();
		}

	}

	public unsafe struct VkQueryPoolCreateInfo
	{
		public static VkQueryPoolCreateInfo* Create()
		{
			return (VkQueryPoolCreateInfo*)HeapUtil.AllocateAndClear<VkQueryPoolCreateInfo>();
		}

	}

	public unsafe struct VkFramebufferCreateInfo
	{
		public static VkFramebufferCreateInfo* Create()
		{
			return (VkFramebufferCreateInfo*)HeapUtil.AllocateAndClear<VkFramebufferCreateInfo>();
		}

	}

	public unsafe struct VkDrawIndirectCommand
	{
		public static VkDrawIndirectCommand* Create()
		{
			return (VkDrawIndirectCommand*)HeapUtil.AllocateAndClear<VkDrawIndirectCommand>();
		}

	}

	public unsafe struct VkDrawIndexedIndirectCommand
	{
		public static VkDrawIndexedIndirectCommand* Create()
		{
			return (VkDrawIndexedIndirectCommand*)HeapUtil.AllocateAndClear<VkDrawIndexedIndirectCommand>();
		}

	}

	public unsafe struct VkDispatchIndirectCommand
	{
		public static VkDispatchIndirectCommand* Create()
		{
			return (VkDispatchIndirectCommand*)HeapUtil.AllocateAndClear<VkDispatchIndirectCommand>();
		}

	}

	public unsafe struct VkSubmitInfo
	{
		public static VkSubmitInfo* Create()
		{
			return (VkSubmitInfo*)HeapUtil.AllocateAndClear<VkSubmitInfo>();
		}

	}

	public unsafe struct VkDisplayPropertiesKHR
	{
		public static VkDisplayPropertiesKHR* Create()
		{
			return (VkDisplayPropertiesKHR*)HeapUtil.AllocateAndClear<VkDisplayPropertiesKHR>();
		}

	}

	public unsafe struct VkDisplayPlanePropertiesKHR
	{
		public static VkDisplayPlanePropertiesKHR* Create()
		{
			return (VkDisplayPlanePropertiesKHR*)HeapUtil.AllocateAndClear<VkDisplayPlanePropertiesKHR>();
		}

	}

	public unsafe struct VkDisplayModeParametersKHR
	{
		public static VkDisplayModeParametersKHR* Create()
		{
			return (VkDisplayModeParametersKHR*)HeapUtil.AllocateAndClear<VkDisplayModeParametersKHR>();
		}

	}

	public unsafe struct VkDisplayModePropertiesKHR
	{
		public static VkDisplayModePropertiesKHR* Create()
		{
			return (VkDisplayModePropertiesKHR*)HeapUtil.AllocateAndClear<VkDisplayModePropertiesKHR>();
		}

	}

	public unsafe struct VkDisplayModeCreateInfoKHR
	{
		public static VkDisplayModeCreateInfoKHR* Create()
		{
			return (VkDisplayModeCreateInfoKHR*)HeapUtil.AllocateAndClear<VkDisplayModeCreateInfoKHR>();
		}

	}

	public unsafe struct VkDisplayPlaneCapabilitiesKHR
	{
		public static VkDisplayPlaneCapabilitiesKHR* Create()
		{
			return (VkDisplayPlaneCapabilitiesKHR*)HeapUtil.AllocateAndClear<VkDisplayPlaneCapabilitiesKHR>();
		}

	}

	public unsafe struct VkDisplaySurfaceCreateInfoKHR
	{
		public static VkDisplaySurfaceCreateInfoKHR* Create()
		{
			return (VkDisplaySurfaceCreateInfoKHR*)HeapUtil.AllocateAndClear<VkDisplaySurfaceCreateInfoKHR>();
		}

	}

	public unsafe struct VkDisplayPresentInfoKHR
	{
		public static VkDisplayPresentInfoKHR* Create()
		{
			return (VkDisplayPresentInfoKHR*)HeapUtil.AllocateAndClear<VkDisplayPresentInfoKHR>();
		}

	}

	public unsafe struct VkSurfaceCapabilitiesKHR
	{
		public static VkSurfaceCapabilitiesKHR* Create()
		{
			return (VkSurfaceCapabilitiesKHR*)HeapUtil.AllocateAndClear<VkSurfaceCapabilitiesKHR>();
		}

	}

	public unsafe struct VkAndroidSurfaceCreateInfoKHR
	{
		public static VkAndroidSurfaceCreateInfoKHR* Create()
		{
			return (VkAndroidSurfaceCreateInfoKHR*)HeapUtil.AllocateAndClear<VkAndroidSurfaceCreateInfoKHR>();
		}

	}

	public unsafe struct VkMirSurfaceCreateInfoKHR
	{
		public static VkMirSurfaceCreateInfoKHR* Create()
		{
			return (VkMirSurfaceCreateInfoKHR*)HeapUtil.AllocateAndClear<VkMirSurfaceCreateInfoKHR>();
		}

	}

	public unsafe struct VkWaylandSurfaceCreateInfoKHR
	{
		public static VkWaylandSurfaceCreateInfoKHR* Create()
		{
			return (VkWaylandSurfaceCreateInfoKHR*)HeapUtil.AllocateAndClear<VkWaylandSurfaceCreateInfoKHR>();
		}

	}

	public unsafe struct VkWin32SurfaceCreateInfoKHR
	{
		public static VkWin32SurfaceCreateInfoKHR* Create()
		{
			return (VkWin32SurfaceCreateInfoKHR*)HeapUtil.AllocateAndClear<VkWin32SurfaceCreateInfoKHR>();
		}

	}

	public unsafe struct VkXlibSurfaceCreateInfoKHR
	{
		public static VkXlibSurfaceCreateInfoKHR* Create()
		{
			return (VkXlibSurfaceCreateInfoKHR*)HeapUtil.AllocateAndClear<VkXlibSurfaceCreateInfoKHR>();
		}

	}

	public unsafe struct VkXcbSurfaceCreateInfoKHR
	{
		public static VkXcbSurfaceCreateInfoKHR* Create()
		{
			return (VkXcbSurfaceCreateInfoKHR*)HeapUtil.AllocateAndClear<VkXcbSurfaceCreateInfoKHR>();
		}

	}

	public unsafe struct VkSurfaceFormatKHR
	{
		public static VkSurfaceFormatKHR* Create()
		{
			return (VkSurfaceFormatKHR*)HeapUtil.AllocateAndClear<VkSurfaceFormatKHR>();
		}

	}

	public unsafe struct VkSwapchainCreateInfoKHR
	{
		public static VkSwapchainCreateInfoKHR* Create()
		{
			return (VkSwapchainCreateInfoKHR*)HeapUtil.AllocateAndClear<VkSwapchainCreateInfoKHR>();
		}

	}

	public unsafe struct VkPresentInfoKHR
	{
		public static VkPresentInfoKHR* Create()
		{
			return (VkPresentInfoKHR*)HeapUtil.AllocateAndClear<VkPresentInfoKHR>();
		}

	}

	public unsafe struct VkDebugReportCallbackCreateInfoEXT
	{
		public static VkDebugReportCallbackCreateInfoEXT* Create()
		{
			return (VkDebugReportCallbackCreateInfoEXT*)HeapUtil.AllocateAndClear<VkDebugReportCallbackCreateInfoEXT>();
		}

	}

}