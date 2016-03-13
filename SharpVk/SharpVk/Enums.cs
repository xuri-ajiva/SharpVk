
using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
	public enum ImageLayout
	{
		_Undefined,
		_General,
		_ColorAttachmentOptimal,
		_DepthStencilAttachmentOptimal,
		_DepthStencilReadOnlyOptimal,
		_ShaderReadOnlyOptimal,
		_TransferSrcOptimal,
		_TransferDstOptimal,
		_Preinitialized,
	}

	public enum AttachmentLoadOp
	{
		_Load,
		_Clear,
		_DontCare,
	}

	public enum AttachmentStoreOp
	{
		_Store,
		_DontCare,
	}

	public enum ImageType
	{
		_1d,
		_2d,
		_3d,
	}

	public enum ImageTiling
	{
		_Optimal,
		_Linear,
	}

	public enum ImageViewType
	{
		_1d,
		_2d,
		_3d,
		_Cube,
		_1dArray,
		_2dArray,
		_CubeArray,
	}

	public enum CommandBufferLevel
	{
		_Primary,
		_Secondary,
	}

	public enum ComponentSwizzle
	{
		_Identity,
		_Zero,
		_One,
		_R,
		_G,
		_B,
		_A,
	}

	public enum DescriptorType
	{
		_Sampler,
		_CombinedImageSampler,
		_SampledImage,
		_StorageImage,
		_UniformTexelBuffer,
		_StorageTexelBuffer,
		_UniformBuffer,
		_StorageBuffer,
		_UniformBufferDynamic,
		_StorageBufferDynamic,
		_InputAttachment,
	}

	public enum QueryType
	{
		_Occlusion,
		_PipelineStatistics,
		_Timestamp,
	}

	public enum BorderColor
	{
		_FloatTransparentBlack,
		_IntTransparentBlack,
		_FloatOpaqueBlack,
		_IntOpaqueBlack,
		_FloatOpaqueWhite,
		_IntOpaqueWhite,
	}

	public enum PipelineBindPoint
	{
		_Graphics,
		_Compute,
	}

	public enum PipelineCacheHeaderVersion
	{
		_One,
	}

	public enum PrimitiveTopology
	{
		_PointList,
		_LineList,
		_LineStrip,
		_TriangleList,
		_TriangleStrip,
		_TriangleFan,
		_LineListWithAdjacency,
		_LineStripWithAdjacency,
		_TriangleListWithAdjacency,
		_TriangleStripWithAdjacency,
		_PatchList,
	}

	public enum SharingMode
	{
		_Exclusive,
		_Concurrent,
	}

	public enum IndexType
	{
		_Uint16,
		_Uint32,
	}

	public enum Filter
	{
		_Nearest,
		_Linear,
	}

	public enum SamplerMipmapMode
	{
		_Nearest,
		_Linear,
	}

	public enum SamplerAddressMode
	{
		_Repeat,
		_MirroredRepeat,
		_ClampToEdge,
		_ClampToBorder,
	}

	public enum CompareOp
	{
		_Never,
		_Less,
		_Equal,
		_LessOrEqual,
		_Greater,
		_NotEqual,
		_GreaterOrEqual,
		_Always,
	}

	public enum PolygonMode
	{
		_Fill,
		_Line,
		_Point,
	}

	public enum CullModeFlagBits
	{
		_VkCullModeNone,
		_VkCullModeFrontBit,
		_VkCullModeBackBit,
		_VkCullModeFrontAndBack,
	}

	public enum FrontFace
	{
		_CounterClockwise,
		_Clockwise,
	}

	public enum BlendFactor
	{
		_Zero,
		_One,
		_SrcColor,
		_OneMinusSrcColor,
		_DstColor,
		_OneMinusDstColor,
		_SrcAlpha,
		_OneMinusSrcAlpha,
		_DstAlpha,
		_OneMinusDstAlpha,
		_ConstantColor,
		_OneMinusConstantColor,
		_ConstantAlpha,
		_OneMinusConstantAlpha,
		_SrcAlphaSaturate,
		_Src1Color,
		_OneMinusSrc1Color,
		_Src1Alpha,
		_OneMinusSrc1Alpha,
	}

	public enum BlendOp
	{
		_Add,
		_Subtract,
		_ReverseSubtract,
		_Min,
		_Max,
	}

	public enum StencilOp
	{
		_Keep,
		_Zero,
		_Replace,
		_IncrementAndClamp,
		_DecrementAndClamp,
		_Invert,
		_IncrementAndWrap,
		_DecrementAndWrap,
	}

	public enum LogicOp
	{
		_Clear,
		_And,
		_AndReverse,
		_Copy,
		_AndInverted,
		_NoOp,
		_Xor,
		_Or,
		_Nor,
		_Equivalent,
		_Invert,
		_OrReverse,
		_CopyInverted,
		_OrInverted,
		_Nand,
		_Set,
	}

	public enum InternalAllocationType
	{
		_Executable,
	}

	public enum SystemAllocationScope
	{
		_Command,
		_Object,
		_Cache,
		_Device,
		_Instance,
	}

	public enum PhysicalDeviceType
	{
		_Other,
		_IntegratedGpu,
		_DiscreteGpu,
		_VirtualGpu,
		_Cpu,
	}

	public enum VertexInputRate
	{
		_Vertex,
		_Instance,
	}

	public enum Format
	{
		_Undefined,
		_R4g4UnormPack8,
		_R4g4b4a4UnormPack16,
		_B4g4r4a4UnormPack16,
		_R5g6b5UnormPack16,
		_B5g6r5UnormPack16,
		_R5g5b5a1UnormPack16,
		_B5g5r5a1UnormPack16,
		_A1r5g5b5UnormPack16,
		_R8Unorm,
		_R8Snorm,
		_R8Uscaled,
		_R8Sscaled,
		_R8Uint,
		_R8Sint,
		_R8Srgb,
		_R8g8Unorm,
		_R8g8Snorm,
		_R8g8Uscaled,
		_R8g8Sscaled,
		_R8g8Uint,
		_R8g8Sint,
		_R8g8Srgb,
		_R8g8b8Unorm,
		_R8g8b8Snorm,
		_R8g8b8Uscaled,
		_R8g8b8Sscaled,
		_R8g8b8Uint,
		_R8g8b8Sint,
		_R8g8b8Srgb,
		_B8g8r8Unorm,
		_B8g8r8Snorm,
		_B8g8r8Uscaled,
		_B8g8r8Sscaled,
		_B8g8r8Uint,
		_B8g8r8Sint,
		_B8g8r8Srgb,
		_R8g8b8a8Unorm,
		_R8g8b8a8Snorm,
		_R8g8b8a8Uscaled,
		_R8g8b8a8Sscaled,
		_R8g8b8a8Uint,
		_R8g8b8a8Sint,
		_R8g8b8a8Srgb,
		_B8g8r8a8Unorm,
		_B8g8r8a8Snorm,
		_B8g8r8a8Uscaled,
		_B8g8r8a8Sscaled,
		_B8g8r8a8Uint,
		_B8g8r8a8Sint,
		_B8g8r8a8Srgb,
		_A8b8g8r8UnormPack32,
		_A8b8g8r8SnormPack32,
		_A8b8g8r8UscaledPack32,
		_A8b8g8r8SscaledPack32,
		_A8b8g8r8UintPack32,
		_A8b8g8r8SintPack32,
		_A8b8g8r8SrgbPack32,
		_A2r10g10b10UnormPack32,
		_A2r10g10b10SnormPack32,
		_A2r10g10b10UscaledPack32,
		_A2r10g10b10SscaledPack32,
		_A2r10g10b10UintPack32,
		_A2r10g10b10SintPack32,
		_A2b10g10r10UnormPack32,
		_A2b10g10r10SnormPack32,
		_A2b10g10r10UscaledPack32,
		_A2b10g10r10SscaledPack32,
		_A2b10g10r10UintPack32,
		_A2b10g10r10SintPack32,
		_R16Unorm,
		_R16Snorm,
		_R16Uscaled,
		_R16Sscaled,
		_R16Uint,
		_R16Sint,
		_R16Sfloat,
		_R16g16Unorm,
		_R16g16Snorm,
		_R16g16Uscaled,
		_R16g16Sscaled,
		_R16g16Uint,
		_R16g16Sint,
		_R16g16Sfloat,
		_R16g16b16Unorm,
		_R16g16b16Snorm,
		_R16g16b16Uscaled,
		_R16g16b16Sscaled,
		_R16g16b16Uint,
		_R16g16b16Sint,
		_R16g16b16Sfloat,
		_R16g16b16a16Unorm,
		_R16g16b16a16Snorm,
		_R16g16b16a16Uscaled,
		_R16g16b16a16Sscaled,
		_R16g16b16a16Uint,
		_R16g16b16a16Sint,
		_R16g16b16a16Sfloat,
		_R32Uint,
		_R32Sint,
		_R32Sfloat,
		_R32g32Uint,
		_R32g32Sint,
		_R32g32Sfloat,
		_R32g32b32Uint,
		_R32g32b32Sint,
		_R32g32b32Sfloat,
		_R32g32b32a32Uint,
		_R32g32b32a32Sint,
		_R32g32b32a32Sfloat,
		_R64Uint,
		_R64Sint,
		_R64Sfloat,
		_R64g64Uint,
		_R64g64Sint,
		_R64g64Sfloat,
		_R64g64b64Uint,
		_R64g64b64Sint,
		_R64g64b64Sfloat,
		_R64g64b64a64Uint,
		_R64g64b64a64Sint,
		_R64g64b64a64Sfloat,
		_B10g11r11UfloatPack32,
		_E5b9g9r9UfloatPack32,
		_D16Unorm,
		_X8D24UnormPack32,
		_D32Sfloat,
		_S8Uint,
		_D16UnormS8Uint,
		_D24UnormS8Uint,
		_D32SfloatS8Uint,
		_Bc1RgbUnormBlock,
		_Bc1RgbSrgbBlock,
		_Bc1RgbaUnormBlock,
		_Bc1RgbaSrgbBlock,
		_Bc2UnormBlock,
		_Bc2SrgbBlock,
		_Bc3UnormBlock,
		_Bc3SrgbBlock,
		_Bc4UnormBlock,
		_Bc4SnormBlock,
		_Bc5UnormBlock,
		_Bc5SnormBlock,
		_Bc6hUfloatBlock,
		_Bc6hSfloatBlock,
		_Bc7UnormBlock,
		_Bc7SrgbBlock,
		_Etc2R8g8b8UnormBlock,
		_Etc2R8g8b8SrgbBlock,
		_Etc2R8g8b8a1UnormBlock,
		_Etc2R8g8b8a1SrgbBlock,
		_Etc2R8g8b8a8UnormBlock,
		_Etc2R8g8b8a8SrgbBlock,
		_EacR11UnormBlock,
		_EacR11SnormBlock,
		_EacR11g11UnormBlock,
		_EacR11g11SnormBlock,
		_Astc4x4UnormBlock,
		_Astc4x4SrgbBlock,
		_Astc5x4UnormBlock,
		_Astc5x4SrgbBlock,
		_Astc5x5UnormBlock,
		_Astc5x5SrgbBlock,
		_Astc6x5UnormBlock,
		_Astc6x5SrgbBlock,
		_Astc6x6UnormBlock,
		_Astc6x6SrgbBlock,
		_Astc8x5UnormBlock,
		_Astc8x5SrgbBlock,
		_Astc8x6UnormBlock,
		_Astc8x6SrgbBlock,
		_Astc8x8UnormBlock,
		_Astc8x8SrgbBlock,
		_Astc10x5UnormBlock,
		_Astc10x5SrgbBlock,
		_Astc10x6UnormBlock,
		_Astc10x6SrgbBlock,
		_Astc10x8UnormBlock,
		_Astc10x8SrgbBlock,
		_Astc10x10UnormBlock,
		_Astc10x10SrgbBlock,
		_Astc12x10UnormBlock,
		_Astc12x10SrgbBlock,
		_Astc12x12UnormBlock,
		_Astc12x12SrgbBlock,
	}

	public enum StructureType
	{
		_ApplicationInfo,
		_InstanceCreateInfo,
		_DeviceQueueCreateInfo,
		_DeviceCreateInfo,
		_SubmitInfo,
		_MemoryAllocateInfo,
		_MappedMemoryRange,
		_BindSparseInfo,
		_FenceCreateInfo,
		_SemaphoreCreateInfo,
		_EventCreateInfo,
		_QueryPoolCreateInfo,
		_BufferCreateInfo,
		_BufferViewCreateInfo,
		_ImageCreateInfo,
		_ImageViewCreateInfo,
		_ShaderModuleCreateInfo,
		_PipelineCacheCreateInfo,
		_PipelineShaderStageCreateInfo,
		_PipelineVertexInputStateCreateInfo,
		_PipelineInputAssemblyStateCreateInfo,
		_PipelineTessellationStateCreateInfo,
		_PipelineViewportStateCreateInfo,
		_PipelineRasterizationStateCreateInfo,
		_PipelineMultisampleStateCreateInfo,
		_PipelineDepthStencilStateCreateInfo,
		_PipelineColorBlendStateCreateInfo,
		_PipelineDynamicStateCreateInfo,
		_GraphicsPipelineCreateInfo,
		_ComputePipelineCreateInfo,
		_PipelineLayoutCreateInfo,
		_SamplerCreateInfo,
		_DescriptorSetLayoutCreateInfo,
		_DescriptorPoolCreateInfo,
		_DescriptorSetAllocateInfo,
		_WriteDescriptorSet,
		_CopyDescriptorSet,
		_FramebufferCreateInfo,
		_RenderPassCreateInfo,
		_CommandPoolCreateInfo,
		_CommandBufferAllocateInfo,
		_CommandBufferInheritanceInfo,
		_CommandBufferBeginInfo,
		_RenderPassBeginInfo,
		_BufferMemoryBarrier,
		_ImageMemoryBarrier,
		_MemoryBarrier,
		_LoaderInstanceCreateInfo,
		_LoaderDeviceCreateInfo,
	}

	public enum SubpassContents
	{
		_Inline,
		_SecondaryCommandBuffers,
	}

	public enum Result
	{
		_VkSuccess,
		_VkNotReady,
		_VkTimeout,
		_VkEventSet,
		_VkEventReset,
		_VkIncomplete,
		_VkErrorOutOfHostMemory,
		_VkErrorOutOfDeviceMemory,
		_VkErrorInitializationFailed,
		_VkErrorDeviceLost,
		_VkErrorMemoryMapFailed,
		_VkErrorLayerNotPresent,
		_VkErrorExtensionNotPresent,
		_VkErrorFeatureNotPresent,
		_VkErrorIncompatibleDriver,
		_VkErrorTooManyObjects,
		_VkErrorFormatNotSupported,
	}

	public enum DynamicState
	{
		_Viewport,
		_Scissor,
		_LineWidth,
		_DepthBias,
		_BlendConstants,
		_DepthBounds,
		_StencilCompareMask,
		_StencilWriteMask,
		_StencilReference,
	}

	public enum QueueFlagBits
	{
		_VkQueueGraphicsBit,
		_VkQueueComputeBit,
		_VkQueueTransferBit,
		_VkQueueSparseBindingBit,
	}

	public enum MemoryPropertyFlagBits
	{
		_VkMemoryPropertyDeviceLocalBit,
		_VkMemoryPropertyHostVisibleBit,
		_VkMemoryPropertyHostCoherentBit,
		_VkMemoryPropertyHostCachedBit,
		_VkMemoryPropertyLazilyAllocatedBit,
	}

	public enum MemoryHeapFlagBits
	{
		_VkMemoryHeapDeviceLocalBit,
	}

	public enum AccessFlagBits
	{
		_VkAccessIndirectCommandReadBit,
		_VkAccessIndexReadBit,
		_VkAccessVertexAttributeReadBit,
		_VkAccessUniformReadBit,
		_VkAccessInputAttachmentReadBit,
		_VkAccessShaderReadBit,
		_VkAccessShaderWriteBit,
		_VkAccessColorAttachmentReadBit,
		_VkAccessColorAttachmentWriteBit,
		_VkAccessDepthStencilAttachmentReadBit,
		_VkAccessDepthStencilAttachmentWriteBit,
		_VkAccessTransferReadBit,
		_VkAccessTransferWriteBit,
		_VkAccessHostReadBit,
		_VkAccessHostWriteBit,
		_VkAccessMemoryReadBit,
		_VkAccessMemoryWriteBit,
	}

	public enum BufferUsageFlagBits
	{
		_VkBufferUsageTransferSrcBit,
		_VkBufferUsageTransferDstBit,
		_VkBufferUsageUniformTexelBufferBit,
		_VkBufferUsageStorageTexelBufferBit,
		_VkBufferUsageUniformBufferBit,
		_VkBufferUsageStorageBufferBit,
		_VkBufferUsageIndexBufferBit,
		_VkBufferUsageVertexBufferBit,
		_VkBufferUsageIndirectBufferBit,
	}

	public enum BufferCreateFlagBits
	{
		_VkBufferCreateSparseBindingBit,
		_VkBufferCreateSparseResidencyBit,
		_VkBufferCreateSparseAliasedBit,
	}

	public enum ShaderStageFlagBits
	{
		_VkShaderStageVertexBit,
		_VkShaderStageTessellationControlBit,
		_VkShaderStageTessellationEvaluationBit,
		_VkShaderStageGeometryBit,
		_VkShaderStageFragmentBit,
		_VkShaderStageComputeBit,
		_VkShaderStageAllGraphics,
		_VkShaderStageAll,
	}

	public enum ImageUsageFlagBits
	{
		_VkImageUsageTransferSrcBit,
		_VkImageUsageTransferDstBit,
		_VkImageUsageSampledBit,
		_VkImageUsageStorageBit,
		_VkImageUsageColorAttachmentBit,
		_VkImageUsageDepthStencilAttachmentBit,
		_VkImageUsageTransientAttachmentBit,
		_VkImageUsageInputAttachmentBit,
	}

	public enum ImageCreateFlagBits
	{
		_VkImageCreateSparseBindingBit,
		_VkImageCreateSparseResidencyBit,
		_VkImageCreateSparseAliasedBit,
		_VkImageCreateMutableFormatBit,
		_VkImageCreateCubeCompatibleBit,
	}

	public enum PipelineCreateFlagBits
	{
		_VkPipelineCreateDisableOptimizationBit,
		_VkPipelineCreateAllowDerivativesBit,
		_VkPipelineCreateDerivativeBit,
	}

	public enum ColorComponentFlagBits
	{
		_VkColorComponentRBit,
		_VkColorComponentGBit,
		_VkColorComponentBBit,
		_VkColorComponentABit,
	}

	public enum FenceCreateFlagBits
	{
		_VkFenceCreateSignaledBit,
	}

	public enum FormatFeatureFlagBits
	{
		_VkFormatFeatureSampledImageBit,
		_VkFormatFeatureStorageImageBit,
		_VkFormatFeatureStorageImageAtomicBit,
		_VkFormatFeatureUniformTexelBufferBit,
		_VkFormatFeatureStorageTexelBufferBit,
		_VkFormatFeatureStorageTexelBufferAtomicBit,
		_VkFormatFeatureVertexBufferBit,
		_VkFormatFeatureColorAttachmentBit,
		_VkFormatFeatureColorAttachmentBlendBit,
		_VkFormatFeatureDepthStencilAttachmentBit,
		_VkFormatFeatureBlitSrcBit,
		_VkFormatFeatureBlitDstBit,
		_VkFormatFeatureSampledImageFilterLinearBit,
	}

	public enum QueryControlFlagBits
	{
		_VkQueryControlPreciseBit,
	}

	public enum QueryResultFlagBits
	{
		_VkQueryResult64Bit,
		_VkQueryResultWaitBit,
		_VkQueryResultWithAvailabilityBit,
		_VkQueryResultPartialBit,
	}

	public enum CommandBufferUsageFlagBits
	{
		_VkCommandBufferUsageOneTimeSubmitBit,
		_VkCommandBufferUsageRenderPassContinueBit,
		_VkCommandBufferUsageSimultaneousUseBit,
	}

	public enum QueryPipelineStatisticFlagBits
	{
		_VkQueryPipelineStatisticInputAssemblyVerticesBit,
		_VkQueryPipelineStatisticInputAssemblyPrimitivesBit,
		_VkQueryPipelineStatisticVertexShaderInvocationsBit,
		_VkQueryPipelineStatisticGeometryShaderInvocationsBit,
		_VkQueryPipelineStatisticGeometryShaderPrimitivesBit,
		_VkQueryPipelineStatisticClippingInvocationsBit,
		_VkQueryPipelineStatisticClippingPrimitivesBit,
		_VkQueryPipelineStatisticFragmentShaderInvocationsBit,
		_VkQueryPipelineStatisticTessellationControlShaderPatchesBit,
		_VkQueryPipelineStatisticTessellationEvaluationShaderInvocationsBit,
		_VkQueryPipelineStatisticComputeShaderInvocationsBit,
	}

	public enum ImageAspectFlagBits
	{
		_VkImageAspectColorBit,
		_VkImageAspectDepthBit,
		_VkImageAspectStencilBit,
		_VkImageAspectMetadataBit,
	}

	public enum SparseImageFormatFlagBits
	{
		_VkSparseImageFormatSingleMiptailBit,
		_VkSparseImageFormatAlignedMipSizeBit,
		_VkSparseImageFormatNonstandardBlockSizeBit,
	}

	public enum SparseMemoryBindFlagBits
	{
		_VkSparseMemoryBindMetadataBit,
	}

	public enum PipelineStageFlagBits
	{
		_VkPipelineStageTopOfPipeBit,
		_VkPipelineStageDrawIndirectBit,
		_VkPipelineStageVertexInputBit,
		_VkPipelineStageVertexShaderBit,
		_VkPipelineStageTessellationControlShaderBit,
		_VkPipelineStageTessellationEvaluationShaderBit,
		_VkPipelineStageGeometryShaderBit,
		_VkPipelineStageFragmentShaderBit,
		_VkPipelineStageEarlyFragmentTestsBit,
		_VkPipelineStageLateFragmentTestsBit,
		_VkPipelineStageColorAttachmentOutputBit,
		_VkPipelineStageComputeShaderBit,
		_VkPipelineStageTransferBit,
		_VkPipelineStageBottomOfPipeBit,
		_VkPipelineStageHostBit,
		_VkPipelineStageAllGraphicsBit,
		_VkPipelineStageAllCommandsBit,
	}

	public enum CommandPoolCreateFlagBits
	{
		_VkCommandPoolCreateTransientBit,
		_VkCommandPoolCreateResetCommandBufferBit,
	}

	public enum CommandPoolResetFlagBits
	{
		_VkCommandPoolResetReleaseResourcesBit,
	}

	public enum CommandBufferResetFlagBits
	{
		_VkCommandBufferResetReleaseResourcesBit,
	}

	public enum SampleCountFlagBits
	{
		_VkSampleCount1Bit,
		_VkSampleCount2Bit,
		_VkSampleCount4Bit,
		_VkSampleCount8Bit,
		_VkSampleCount16Bit,
		_VkSampleCount32Bit,
		_VkSampleCount64Bit,
	}

	public enum AttachmentDescriptionFlagBits
	{
		_VkAttachmentDescriptionMayAliasBit,
	}

	public enum StencilFaceFlagBits
	{
		_VkStencilFaceFrontBit,
		_VkStencilFaceBackBit,
		_VkStencilFrontAndBack,
	}

	public enum DescriptorPoolCreateFlagBits
	{
		_VkDescriptorPoolCreateFreeDescriptorSetBit,
	}

	public enum DependencyFlagBits
	{
		_VkDependencyByRegionBit,
	}

	public enum PresentModeKHR
	{
		_ImmediateKhr,
		_MailboxKhr,
		_FifoKhr,
		_FifoRelaxedKhr,
	}

	public enum ColorSpaceKHR
	{
		_SrgbNonlinearKhr,
	}

	public enum DisplayPlaneAlphaFlagBitsKHR
	{
		_VkDisplayPlaneAlphaOpaqueBitKhr,
		_VkDisplayPlaneAlphaGlobalBitKhr,
		_VkDisplayPlaneAlphaPerPixelBitKhr,
		_VkDisplayPlaneAlphaPerPixelPremultipliedBitKhr,
	}

	public enum CompositeAlphaFlagBitsKHR
	{
		_VkCompositeAlphaOpaqueBitKhr,
		_VkCompositeAlphaPreMultipliedBitKhr,
		_VkCompositeAlphaPostMultipliedBitKhr,
		_VkCompositeAlphaInheritBitKhr,
	}

	public enum SurfaceTransformFlagBitsKHR
	{
		_VkSurfaceTransformIdentityBitKhr,
		_VkSurfaceTransformRotate90BitKhr,
		_VkSurfaceTransformRotate180BitKhr,
		_VkSurfaceTransformRotate270BitKhr,
		_VkSurfaceTransformHorizontalMirrorBitKhr,
		_VkSurfaceTransformHorizontalMirrorRotate90BitKhr,
		_VkSurfaceTransformHorizontalMirrorRotate180BitKhr,
		_VkSurfaceTransformHorizontalMirrorRotate270BitKhr,
		_VkSurfaceTransformInheritBitKhr,
	}

	public enum DebugReportFlagBitsEXT
	{
		_VkDebugReportInformationBitExt,
		_VkDebugReportWarningBitExt,
		_VkDebugReportPerformanceWarningBitExt,
		_VkDebugReportErrorBitExt,
		_VkDebugReportDebugBitExt,
	}

	public enum DebugReportObjectTypeEXT
	{
		_VkDebugReportObjectTypeUnknownExt,
		_VkDebugReportObjectTypeInstanceExt,
		_VkDebugReportObjectTypePhysicalDeviceExt,
		_VkDebugReportObjectTypeDeviceExt,
		_VkDebugReportObjectTypeQueueExt,
		_VkDebugReportObjectTypeSemaphoreExt,
		_VkDebugReportObjectTypeCommandBufferExt,
		_VkDebugReportObjectTypeFenceExt,
		_VkDebugReportObjectTypeDeviceMemoryExt,
		_VkDebugReportObjectTypeBufferExt,
		_VkDebugReportObjectTypeImageExt,
		_VkDebugReportObjectTypeEventExt,
		_VkDebugReportObjectTypeQueryPoolExt,
		_VkDebugReportObjectTypeBufferViewExt,
		_VkDebugReportObjectTypeImageViewExt,
		_VkDebugReportObjectTypeShaderModuleExt,
		_VkDebugReportObjectTypePipelineCacheExt,
		_VkDebugReportObjectTypePipelineLayoutExt,
		_VkDebugReportObjectTypeRenderPassExt,
		_VkDebugReportObjectTypePipelineExt,
		_VkDebugReportObjectTypeDescriptorSetLayoutExt,
		_VkDebugReportObjectTypeSamplerExt,
		_VkDebugReportObjectTypeDescriptorPoolExt,
		_VkDebugReportObjectTypeDescriptorSetExt,
		_VkDebugReportObjectTypeFramebufferExt,
		_VkDebugReportObjectTypeCommandPoolExt,
		_VkDebugReportObjectTypeSurfaceKhrExt,
		_VkDebugReportObjectTypeSwapchainKhrExt,
		_VkDebugReportObjectTypeDebugReportExt,
	}

	public enum DebugReportErrorEXT
	{
		_VkDebugReportErrorNoneExt,
		_VkDebugReportErrorCallbackRefExt,
	}

}