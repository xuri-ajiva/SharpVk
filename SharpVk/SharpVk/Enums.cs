
using System;

namespace SharpVk
{
	public enum ImageLayout
	{
		Undefined = 0,
		General = 1,
		ColorAttachmentOptimal = 2,
		DepthStencilAttachmentOptimal = 3,
		DepthStencilReadOnlyOptimal = 4,
		ShaderReadOnlyOptimal = 5,
		TransferSrcOptimal = 6,
		TransferDstOptimal = 7,
		Preinitialized = 8,
	}

	public enum AttachmentLoadOp
	{
		Load = 0,
		Clear = 1,
		DontCare = 2,
	}

	public enum AttachmentStoreOp
	{
		Store = 0,
		DontCare = 1,
	}

	public enum ImageType
	{
		Image1d = 0,
		Image2d = 1,
		Image3d = 2,
	}

	public enum ImageTiling
	{
		Optimal = 0,
		Linear = 1,
	}

	public enum ImageViewType
	{
		ImageView1d = 0,
		ImageView2d = 1,
		ImageView3d = 2,
		Cube = 3,
		ImageView1dArray = 4,
		ImageView2dArray = 5,
		CubeArray = 6,
	}

	public enum CommandBufferLevel
	{
		Primary = 0,
		Secondary = 1,
	}

	public enum ComponentSwizzle
	{
		Identity = 0,
		Zero = 1,
		One = 2,
		R = 3,
		G = 4,
		B = 5,
		A = 6,
	}

	public enum DescriptorType
	{
		Sampler = 0,
		CombinedImageSampler = 1,
		SampledImage = 2,
		StorageImage = 3,
		UniformTexelBuffer = 4,
		StorageTexelBuffer = 5,
		UniformBuffer = 6,
		StorageBuffer = 7,
		UniformBufferDynamic = 8,
		StorageBufferDynamic = 9,
		InputAttachment = 10,
	}

	public enum QueryType
	{
		Occlusion = 0,
		PipelineStatistics = 1,
		Timestamp = 2,
	}

	public enum BorderColor
	{
		FloatTransparentBlack = 0,
		IntTransparentBlack = 1,
		FloatOpaqueBlack = 2,
		IntOpaqueBlack = 3,
		FloatOpaqueWhite = 4,
		IntOpaqueWhite = 5,
	}

	public enum PipelineBindPoint
	{
		Graphics = 0,
		Compute = 1,
	}

	public enum PipelineCacheHeaderVersion
	{
		One = 1,
	}

	public enum PrimitiveTopology
	{
		PointList = 0,
		LineList = 1,
		LineStrip = 2,
		TriangleList = 3,
		TriangleStrip = 4,
		TriangleFan = 5,
		LineListWithAdjacency = 6,
		LineStripWithAdjacency = 7,
		TriangleListWithAdjacency = 8,
		TriangleStripWithAdjacency = 9,
		PatchList = 10,
	}

	public enum SharingMode
	{
		Exclusive = 0,
		Concurrent = 1,
	}

	public enum IndexType
	{
		Uint16 = 0,
		Uint32 = 1,
	}

	public enum Filter
	{
		Nearest = 0,
		Linear = 1,
	}

	public enum SamplerMipmapMode
	{
		Nearest = 0,
		Linear = 1,
	}

	public enum SamplerAddressMode
	{
		Repeat = 0,
		MirroredRepeat = 1,
		ClampToEdge = 2,
		ClampToBorder = 3,
	}

	public enum CompareOp
	{
		Never = 0,
		Less = 1,
		Equal = 2,
		LessOrEqual = 3,
		Greater = 4,
		NotEqual = 5,
		GreaterOrEqual = 6,
		Always = 7,
	}

	public enum PolygonMode
	{
		Fill = 0,
		Line = 1,
		Point = 2,
	}

	[Flags]
	public enum CullModeFlags
	{
		None = 0,
		Front = 1 << 0,
		Back = 1 << 1,
		FrontAndBack = 0x00000003,
	}

	public enum FrontFace
	{
		CounterClockwise = 0,
		Clockwise = 1,
	}

	public enum BlendFactor
	{
		Zero = 0,
		One = 1,
		SrcColor = 2,
		OneMinusSrcColor = 3,
		DstColor = 4,
		OneMinusDstColor = 5,
		SrcAlpha = 6,
		OneMinusSrcAlpha = 7,
		DstAlpha = 8,
		OneMinusDstAlpha = 9,
		ConstantColor = 10,
		OneMinusConstantColor = 11,
		ConstantAlpha = 12,
		OneMinusConstantAlpha = 13,
		SrcAlphaSaturate = 14,
		Src1Color = 15,
		OneMinusSrc1Color = 16,
		Src1Alpha = 17,
		OneMinusSrc1Alpha = 18,
	}

	public enum BlendOp
	{
		Add = 0,
		Subtract = 1,
		ReverseSubtract = 2,
		Min = 3,
		Max = 4,
	}

	public enum StencilOp
	{
		Keep = 0,
		Zero = 1,
		Replace = 2,
		IncrementAndClamp = 3,
		DecrementAndClamp = 4,
		Invert = 5,
		IncrementAndWrap = 6,
		DecrementAndWrap = 7,
	}

	public enum LogicOp
	{
		Clear = 0,
		And = 1,
		AndReverse = 2,
		Copy = 3,
		AndInverted = 4,
		NoOp = 5,
		Xor = 6,
		Or = 7,
		Nor = 8,
		Equivalent = 9,
		Invert = 10,
		OrReverse = 11,
		CopyInverted = 12,
		OrInverted = 13,
		Nand = 14,
		Set = 15,
	}

	public enum InternalAllocationType
	{
		Executable = 0,
	}

	public enum SystemAllocationScope
	{
		Command = 0,
		Object = 1,
		Cache = 2,
		Device = 3,
		Instance = 4,
	}

	public enum PhysicalDeviceType
	{
		Other = 0,
		IntegratedGpu = 1,
		DiscreteGpu = 2,
		VirtualGpu = 3,
		Cpu = 4,
	}

	public enum VertexInputRate
	{
		Vertex = 0,
		Instance = 1,
	}

	public enum Format
	{
		Undefined = 0,
		R4g4UnormPack8 = 1,
		R4g4b4a4UnormPack16 = 2,
		B4g4r4a4UnormPack16 = 3,
		R5g6b5UnormPack16 = 4,
		B5g6r5UnormPack16 = 5,
		R5g5b5a1UnormPack16 = 6,
		B5g5r5a1UnormPack16 = 7,
		A1r5g5b5UnormPack16 = 8,
		R8Unorm = 9,
		R8Snorm = 10,
		R8Uscaled = 11,
		R8Sscaled = 12,
		R8Uint = 13,
		R8Sint = 14,
		R8Srgb = 15,
		R8g8Unorm = 16,
		R8g8Snorm = 17,
		R8g8Uscaled = 18,
		R8g8Sscaled = 19,
		R8g8Uint = 20,
		R8g8Sint = 21,
		R8g8Srgb = 22,
		R8g8b8Unorm = 23,
		R8g8b8Snorm = 24,
		R8g8b8Uscaled = 25,
		R8g8b8Sscaled = 26,
		R8g8b8Uint = 27,
		R8g8b8Sint = 28,
		R8g8b8Srgb = 29,
		B8g8r8Unorm = 30,
		B8g8r8Snorm = 31,
		B8g8r8Uscaled = 32,
		B8g8r8Sscaled = 33,
		B8g8r8Uint = 34,
		B8g8r8Sint = 35,
		B8g8r8Srgb = 36,
		R8g8b8a8Unorm = 37,
		R8g8b8a8Snorm = 38,
		R8g8b8a8Uscaled = 39,
		R8g8b8a8Sscaled = 40,
		R8g8b8a8Uint = 41,
		R8g8b8a8Sint = 42,
		R8g8b8a8Srgb = 43,
		B8g8r8a8Unorm = 44,
		B8g8r8a8Snorm = 45,
		B8g8r8a8Uscaled = 46,
		B8g8r8a8Sscaled = 47,
		B8g8r8a8Uint = 48,
		B8g8r8a8Sint = 49,
		B8g8r8a8Srgb = 50,
		A8b8g8r8UnormPack32 = 51,
		A8b8g8r8SnormPack32 = 52,
		A8b8g8r8UscaledPack32 = 53,
		A8b8g8r8SscaledPack32 = 54,
		A8b8g8r8UintPack32 = 55,
		A8b8g8r8SintPack32 = 56,
		A8b8g8r8SrgbPack32 = 57,
		A2r10g10b10UnormPack32 = 58,
		A2r10g10b10SnormPack32 = 59,
		A2r10g10b10UscaledPack32 = 60,
		A2r10g10b10SscaledPack32 = 61,
		A2r10g10b10UintPack32 = 62,
		A2r10g10b10SintPack32 = 63,
		A2b10g10r10UnormPack32 = 64,
		A2b10g10r10SnormPack32 = 65,
		A2b10g10r10UscaledPack32 = 66,
		A2b10g10r10SscaledPack32 = 67,
		A2b10g10r10UintPack32 = 68,
		A2b10g10r10SintPack32 = 69,
		R16Unorm = 70,
		R16Snorm = 71,
		R16Uscaled = 72,
		R16Sscaled = 73,
		R16Uint = 74,
		R16Sint = 75,
		R16Sfloat = 76,
		R16g16Unorm = 77,
		R16g16Snorm = 78,
		R16g16Uscaled = 79,
		R16g16Sscaled = 80,
		R16g16Uint = 81,
		R16g16Sint = 82,
		R16g16Sfloat = 83,
		R16g16b16Unorm = 84,
		R16g16b16Snorm = 85,
		R16g16b16Uscaled = 86,
		R16g16b16Sscaled = 87,
		R16g16b16Uint = 88,
		R16g16b16Sint = 89,
		R16g16b16Sfloat = 90,
		R16g16b16a16Unorm = 91,
		R16g16b16a16Snorm = 92,
		R16g16b16a16Uscaled = 93,
		R16g16b16a16Sscaled = 94,
		R16g16b16a16Uint = 95,
		R16g16b16a16Sint = 96,
		R16g16b16a16Sfloat = 97,
		R32Uint = 98,
		R32Sint = 99,
		R32Sfloat = 100,
		R32g32Uint = 101,
		R32g32Sint = 102,
		R32g32Sfloat = 103,
		R32g32b32Uint = 104,
		R32g32b32Sint = 105,
		R32g32b32Sfloat = 106,
		R32g32b32a32Uint = 107,
		R32g32b32a32Sint = 108,
		R32g32b32a32Sfloat = 109,
		R64Uint = 110,
		R64Sint = 111,
		R64Sfloat = 112,
		R64g64Uint = 113,
		R64g64Sint = 114,
		R64g64Sfloat = 115,
		R64g64b64Uint = 116,
		R64g64b64Sint = 117,
		R64g64b64Sfloat = 118,
		R64g64b64a64Uint = 119,
		R64g64b64a64Sint = 120,
		R64g64b64a64Sfloat = 121,
		B10g11r11UfloatPack32 = 122,
		E5b9g9r9UfloatPack32 = 123,
		D16Unorm = 124,
		X8D24UnormPack32 = 125,
		D32Sfloat = 126,
		S8Uint = 127,
		D16UnormS8Uint = 128,
		D24UnormS8Uint = 129,
		D32SfloatS8Uint = 130,
		Bc1RgbUnormBlock = 131,
		Bc1RgbSrgbBlock = 132,
		Bc1RgbaUnormBlock = 133,
		Bc1RgbaSrgbBlock = 134,
		Bc2UnormBlock = 135,
		Bc2SrgbBlock = 136,
		Bc3UnormBlock = 137,
		Bc3SrgbBlock = 138,
		Bc4UnormBlock = 139,
		Bc4SnormBlock = 140,
		Bc5UnormBlock = 141,
		Bc5SnormBlock = 142,
		Bc6hUfloatBlock = 143,
		Bc6hSfloatBlock = 144,
		Bc7UnormBlock = 145,
		Bc7SrgbBlock = 146,
		Etc2R8g8b8UnormBlock = 147,
		Etc2R8g8b8SrgbBlock = 148,
		Etc2R8g8b8a1UnormBlock = 149,
		Etc2R8g8b8a1SrgbBlock = 150,
		Etc2R8g8b8a8UnormBlock = 151,
		Etc2R8g8b8a8SrgbBlock = 152,
		EacR11UnormBlock = 153,
		EacR11SnormBlock = 154,
		EacR11g11UnormBlock = 155,
		EacR11g11SnormBlock = 156,
		Astc4x4UnormBlock = 157,
		Astc4x4SrgbBlock = 158,
		Astc5x4UnormBlock = 159,
		Astc5x4SrgbBlock = 160,
		Astc5x5UnormBlock = 161,
		Astc5x5SrgbBlock = 162,
		Astc6x5UnormBlock = 163,
		Astc6x5SrgbBlock = 164,
		Astc6x6UnormBlock = 165,
		Astc6x6SrgbBlock = 166,
		Astc8x5UnormBlock = 167,
		Astc8x5SrgbBlock = 168,
		Astc8x6UnormBlock = 169,
		Astc8x6SrgbBlock = 170,
		Astc8x8UnormBlock = 171,
		Astc8x8SrgbBlock = 172,
		Astc10x5UnormBlock = 173,
		Astc10x5SrgbBlock = 174,
		Astc10x6UnormBlock = 175,
		Astc10x6SrgbBlock = 176,
		Astc10x8UnormBlock = 177,
		Astc10x8SrgbBlock = 178,
		Astc10x10UnormBlock = 179,
		Astc10x10SrgbBlock = 180,
		Astc12x10UnormBlock = 181,
		Astc12x10SrgbBlock = 182,
		Astc12x12UnormBlock = 183,
		Astc12x12SrgbBlock = 184,
	}

	public enum StructureType
	{
		ApplicationInfo = 0,
		InstanceCreateInfo = 1,
		DeviceQueueCreateInfo = 2,
		DeviceCreateInfo = 3,
		SubmitInfo = 4,
		MemoryAllocateInfo = 5,
		MappedMemoryRange = 6,
		BindSparseInfo = 7,
		FenceCreateInfo = 8,
		SemaphoreCreateInfo = 9,
		EventCreateInfo = 10,
		QueryPoolCreateInfo = 11,
		BufferCreateInfo = 12,
		BufferViewCreateInfo = 13,
		ImageCreateInfo = 14,
		ImageViewCreateInfo = 15,
		ShaderModuleCreateInfo = 16,
		PipelineCacheCreateInfo = 17,
		PipelineShaderStageCreateInfo = 18,
		PipelineVertexInputStateCreateInfo = 19,
		PipelineInputAssemblyStateCreateInfo = 20,
		PipelineTessellationStateCreateInfo = 21,
		PipelineViewportStateCreateInfo = 22,
		PipelineRasterizationStateCreateInfo = 23,
		PipelineMultisampleStateCreateInfo = 24,
		PipelineDepthStencilStateCreateInfo = 25,
		PipelineColorBlendStateCreateInfo = 26,
		PipelineDynamicStateCreateInfo = 27,
		GraphicsPipelineCreateInfo = 28,
		ComputePipelineCreateInfo = 29,
		PipelineLayoutCreateInfo = 30,
		SamplerCreateInfo = 31,
		DescriptorSetLayoutCreateInfo = 32,
		DescriptorPoolCreateInfo = 33,
		DescriptorSetAllocateInfo = 34,
		WriteDescriptorSet = 35,
		CopyDescriptorSet = 36,
		FramebufferCreateInfo = 37,
		RenderPassCreateInfo = 38,
		CommandPoolCreateInfo = 39,
		CommandBufferAllocateInfo = 40,
		CommandBufferInheritanceInfo = 41,
		CommandBufferBeginInfo = 42,
		RenderPassBeginInfo = 43,
		BufferMemoryBarrier = 44,
		ImageMemoryBarrier = 45,
		MemoryBarrier = 46,
		LoaderInstanceCreateInfo = 47,
		LoaderDeviceCreateInfo = 48,
	}

	public enum SubpassContents
	{
		Inline = 0,
		SecondaryCommandBuffers = 1,
	}

	public enum Result
	{
		Success = 0,
		NotReady = 1,
		Timeout = 2,
		EventSet = 3,
		EventReset = 4,
		Incomplete = 5,
		ErrorOutOfHostMemory = -1,
		ErrorOutOfDeviceMemory = -2,
		ErrorInitializationFailed = -3,
		ErrorDeviceLost = -4,
		ErrorMemoryMapFailed = -5,
		ErrorLayerNotPresent = -6,
		ErrorExtensionNotPresent = -7,
		ErrorFeatureNotPresent = -8,
		ErrorIncompatibleDriver = -9,
		ErrorTooManyObjects = -10,
		ErrorFormatNotSupported = -11,
	}

	public enum DynamicState
	{
		Viewport = 0,
		Scissor = 1,
		LineWidth = 2,
		DepthBias = 3,
		BlendConstants = 4,
		DepthBounds = 5,
		StencilCompareMask = 6,
		StencilWriteMask = 7,
		StencilReference = 8,
	}

	[Flags]
	public enum QueueFlags
	{
		Graphics = 1 << 0,
		Compute = 1 << 1,
		Transfer = 1 << 2,
		SparseBinding = 1 << 3,
	}

	[Flags]
	public enum MemoryPropertyFlags
	{
		DeviceLocal = 1 << 0,
		HostVisible = 1 << 1,
		HostCoherent = 1 << 2,
		HostCached = 1 << 3,
		LazilyAllocated = 1 << 4,
	}

	[Flags]
	public enum MemoryHeapFlags
	{
		DeviceLocal = 1 << 0,
	}

	[Flags]
	public enum AccessFlags
	{
		IndirectCommandRead = 1 << 0,
		IndexRead = 1 << 1,
		VertexAttributeRead = 1 << 2,
		UniformRead = 1 << 3,
		InputAttachmentRead = 1 << 4,
		ShaderRead = 1 << 5,
		ShaderWrite = 1 << 6,
		ColorAttachmentRead = 1 << 7,
		ColorAttachmentWrite = 1 << 8,
		DepthStencilAttachmentRead = 1 << 9,
		DepthStencilAttachmentWrite = 1 << 10,
		TransferRead = 1 << 11,
		TransferWrite = 1 << 12,
		HostRead = 1 << 13,
		HostWrite = 1 << 14,
		MemoryRead = 1 << 15,
		MemoryWrite = 1 << 16,
	}

	[Flags]
	public enum BufferUsageFlags
	{
		TransferSrc = 1 << 0,
		TransferDst = 1 << 1,
		UniformTexelBuffer = 1 << 2,
		StorageTexelBuffer = 1 << 3,
		UniformBuffer = 1 << 4,
		StorageBuffer = 1 << 5,
		IndexBuffer = 1 << 6,
		VertexBuffer = 1 << 7,
		IndirectBuffer = 1 << 8,
	}

	[Flags]
	public enum BufferCreateFlags
	{
		SparseBinding = 1 << 0,
		SparseResidency = 1 << 1,
		SparseAliased = 1 << 2,
	}

	[Flags]
	public enum ShaderStageFlags
	{
		Vertex = 1 << 0,
		TessellationControl = 1 << 1,
		TessellationEvaluation = 1 << 2,
		Geometry = 1 << 3,
		Fragment = 1 << 4,
		Compute = 1 << 5,
		AllGraphics = 0x0000001F,
		All = 0x7FFFFFFF,
	}

	[Flags]
	public enum ImageUsageFlags
	{
		TransferSrc = 1 << 0,
		TransferDst = 1 << 1,
		Sampled = 1 << 2,
		Storage = 1 << 3,
		ColorAttachment = 1 << 4,
		DepthStencilAttachment = 1 << 5,
		TransientAttachment = 1 << 6,
		InputAttachment = 1 << 7,
	}

	[Flags]
	public enum ImageCreateFlags
	{
		SparseBinding = 1 << 0,
		SparseResidency = 1 << 1,
		SparseAliased = 1 << 2,
		MutableFormat = 1 << 3,
		CubeCompatible = 1 << 4,
	}

	[Flags]
	public enum PipelineCreateFlags
	{
		DisableOptimization = 1 << 0,
		AllowDerivatives = 1 << 1,
		Derivative = 1 << 2,
	}

	[Flags]
	public enum ColorComponentFlags
	{
		R = 1 << 0,
		G = 1 << 1,
		B = 1 << 2,
		A = 1 << 3,
	}

	[Flags]
	public enum FenceCreateFlags
	{
		Signaled = 1 << 0,
	}

	[Flags]
	public enum FormatFeatureFlags
	{
		SampledImage = 1 << 0,
		StorageImage = 1 << 1,
		StorageImageAtomic = 1 << 2,
		UniformTexelBuffer = 1 << 3,
		StorageTexelBuffer = 1 << 4,
		StorageTexelBufferAtomic = 1 << 5,
		VertexBuffer = 1 << 6,
		ColorAttachment = 1 << 7,
		ColorAttachmentBlend = 1 << 8,
		DepthStencilAttachment = 1 << 9,
		BlitSrc = 1 << 10,
		BlitDst = 1 << 11,
		SampledImageFilterLinear = 1 << 12,
	}

	[Flags]
	public enum QueryControlFlags
	{
		Precise = 1 << 0,
	}

	[Flags]
	public enum QueryResultFlags
	{
		QueryResultFlags64 = 1 << 0,
		Wait = 1 << 1,
		WithAvailability = 1 << 2,
		Partial = 1 << 3,
	}

	[Flags]
	public enum CommandBufferUsageFlags
	{
		OneTimeSubmit = 1 << 0,
		RenderPassContinue = 1 << 1,
		SimultaneousUse = 1 << 2,
	}

	[Flags]
	public enum QueryPipelineStatisticFlags
	{
		InputAssemblyVertices = 1 << 0,
		InputAssemblyPrimitives = 1 << 1,
		VertexShaderInvocations = 1 << 2,
		GeometryShaderInvocations = 1 << 3,
		GeometryShaderPrimitives = 1 << 4,
		ClippingInvocations = 1 << 5,
		ClippingPrimitives = 1 << 6,
		FragmentShaderInvocations = 1 << 7,
		TessellationControlShaderPatches = 1 << 8,
		TessellationEvaluationShaderInvocations = 1 << 9,
		ComputeShaderInvocations = 1 << 10,
	}

	[Flags]
	public enum ImageAspectFlags
	{
		Color = 1 << 0,
		Depth = 1 << 1,
		Stencil = 1 << 2,
		Metadata = 1 << 3,
	}

	[Flags]
	public enum SparseImageFormatFlags
	{
		SingleMiptail = 1 << 0,
		AlignedMipSize = 1 << 1,
		NonstandardBlockSize = 1 << 2,
	}

	[Flags]
	public enum SparseMemoryBindFlags
	{
		Metadata = 1 << 0,
	}

	[Flags]
	public enum PipelineStageFlags
	{
		TopOfPipe = 1 << 0,
		DrawIndirect = 1 << 1,
		VertexInput = 1 << 2,
		VertexShader = 1 << 3,
		TessellationControlShader = 1 << 4,
		TessellationEvaluationShader = 1 << 5,
		GeometryShader = 1 << 6,
		FragmentShader = 1 << 7,
		EarlyFragmentTests = 1 << 8,
		LateFragmentTests = 1 << 9,
		ColorAttachmentOutput = 1 << 10,
		ComputeShader = 1 << 11,
		Transfer = 1 << 12,
		BottomOfPipe = 1 << 13,
		Host = 1 << 14,
		AllGraphics = 1 << 15,
		AllCommands = 1 << 16,
	}

	[Flags]
	public enum CommandPoolCreateFlags
	{
		Transient = 1 << 0,
		ResetCommandBuffer = 1 << 1,
	}

	[Flags]
	public enum CommandPoolResetFlags
	{
		ReleaseResources = 1 << 0,
	}

	[Flags]
	public enum CommandBufferResetFlags
	{
		ReleaseResources = 1 << 0,
	}

	[Flags]
	public enum SampleCountFlags
	{
		SampleCountFlags1 = 1 << 0,
		SampleCountFlags2 = 1 << 1,
		SampleCountFlags4 = 1 << 2,
		SampleCountFlags8 = 1 << 3,
		SampleCountFlags16 = 1 << 4,
		SampleCountFlags32 = 1 << 5,
		SampleCountFlags64 = 1 << 6,
	}

	[Flags]
	public enum AttachmentDescriptionFlags
	{
		MayAlias = 1 << 0,
	}

	[Flags]
	public enum StencilFaceFlags
	{
		Front = 1 << 0,
		Back = 1 << 1,
		tAndBack = 0x00000003,
	}

	[Flags]
	public enum DescriptorPoolCreateFlags
	{
		FreeDescriptorSet = 1 << 0,
	}

	[Flags]
	public enum DependencyFlags
	{
		ByRegion = 1 << 0,
	}

	public enum PresentModeKHR
	{
		ImmediateKhr = 0,
		MailboxKhr = 1,
		FifoKhr = 2,
		FifoRelaxedKhr = 3,
	}

	public enum ColorSpaceKHR
	{
		SrgbNonlinearKhr = 0,
	}

	[Flags]
	public enum DisplayPlaneAlphaFlagsKHR
	{
		DisplayPlaneAlphaOpaqueBitKhr = 1 << 0,
		DisplayPlaneAlphaGlobalBitKhr = 1 << 1,
		DisplayPlaneAlphaPerPixelBitKhr = 1 << 2,
		DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 1 << 3,
	}

	[Flags]
	public enum CompositeAlphaFlagsKHR
	{
		CompositeAlphaOpaqueBitKhr = 1 << 0,
		CompositeAlphaPreMultipliedBitKhr = 1 << 1,
		CompositeAlphaPostMultipliedBitKhr = 1 << 2,
		CompositeAlphaInheritBitKhr = 1 << 3,
	}

	[Flags]
	public enum SurfaceTransformFlagsKHR
	{
		SurfaceTransformIdentityBitKhr = 1 << 0,
		SurfaceTransformRotate90BitKhr = 1 << 1,
		SurfaceTransformRotate180BitKhr = 1 << 2,
		SurfaceTransformRotate270BitKhr = 1 << 3,
		SurfaceTransformHorizontalMirrorBitKhr = 1 << 4,
		SurfaceTransformHorizontalMirrorRotate90BitKhr = 1 << 5,
		SurfaceTransformHorizontalMirrorRotate180BitKhr = 1 << 6,
		SurfaceTransformHorizontalMirrorRotate270BitKhr = 1 << 7,
		SurfaceTransformInheritBitKhr = 1 << 8,
	}

	[Flags]
	public enum DebugReportFlagsEXT
	{
		DebugReportInformationBitExt = 1 << 0,
		DebugReportWarningBitExt = 1 << 1,
		DebugReportPerformanceWarningBitExt = 1 << 2,
		DebugReportErrorBitExt = 1 << 3,
		DebugReportDebugBitExt = 1 << 4,
	}

	public enum DebugReportObjectTypeEXT
	{
		DebugReportObjectTypeUnknownExt = 0,
		DebugReportObjectTypeInstanceExt = 1,
		DebugReportObjectTypePhysicalDeviceExt = 2,
		DebugReportObjectTypeDeviceExt = 3,
		DebugReportObjectTypeQueueExt = 4,
		DebugReportObjectTypeSemaphoreExt = 5,
		DebugReportObjectTypeCommandBufferExt = 6,
		DebugReportObjectTypeFenceExt = 7,
		DebugReportObjectTypeDeviceMemoryExt = 8,
		DebugReportObjectTypeBufferExt = 9,
		DebugReportObjectTypeImageExt = 10,
		DebugReportObjectTypeEventExt = 11,
		DebugReportObjectTypeQueryPoolExt = 12,
		DebugReportObjectTypeBufferViewExt = 13,
		DebugReportObjectTypeImageViewExt = 14,
		DebugReportObjectTypeShaderModuleExt = 15,
		DebugReportObjectTypePipelineCacheExt = 16,
		DebugReportObjectTypePipelineLayoutExt = 17,
		DebugReportObjectTypeRenderPassExt = 18,
		DebugReportObjectTypePipelineExt = 19,
		DebugReportObjectTypeDescriptorSetLayoutExt = 20,
		DebugReportObjectTypeSamplerExt = 21,
		DebugReportObjectTypeDescriptorPoolExt = 22,
		DebugReportObjectTypeDescriptorSetExt = 23,
		DebugReportObjectTypeFramebufferExt = 24,
		DebugReportObjectTypeCommandPoolExt = 25,
		DebugReportObjectTypeSurfaceKhrExt = 26,
		DebugReportObjectTypeSwapchainKhrExt = 27,
		DebugReportObjectTypeDebugReportExt = 28,
	}

	public enum DebugReportErrorEXT
	{
		DebugReportErrorNoneExt = 0,
		DebugReportErrorCallbackRefExt = 1,
	}

}