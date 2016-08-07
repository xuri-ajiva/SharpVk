//The MIT License (MIT)
//
//Copyright (c) 2016 Andrew Armstrong/FacticiusVir
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct AllocationCallbacks
	{
		public void* UserData;
		public IntPtr PfnAllocation;
		public IntPtr PfnReallocation;
		public IntPtr PfnFree;
		public IntPtr PfnInternalAllocation;
		public IntPtr PfnInternalFree;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ApplicationInfo
	{
		public StructureType SType;
		public void* Next;
		public char* ApplicationName;
		public uint ApplicationVersion;
		public char* EngineName;
		public uint EngineVersion;
		public uint ApiVersion;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BindSparseInfo
	{
		public StructureType SType;
		public void* Next;
		public uint WaitSemaphoreCount;
		public Semaphore* WaitSemaphores;
		public uint BufferBindCount;
		public SparseBufferMemoryBindInfo* BufferBinds;
		public uint ImageOpaqueBindCount;
		public SparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds;
		public uint ImageBindCount;
		public SparseImageMemoryBindInfo* ImageBinds;
		public uint SignalSemaphoreCount;
		public Semaphore* SignalSemaphores;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public BufferCreateFlags Flags;
		public DeviceSize Size;
		public BufferUsageFlags Usage;
		public SharingMode SharingMode;
		public uint QueueFamilyIndexCount;
		public uint* QueueFamilyIndices;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferMemoryBarrier
	{
		public StructureType SType;
		public void* Next;
		public AccessFlags SourceAccessMask;
		public AccessFlags DestinationAccessMask;
		public uint SourceQueueFamilyIndex;
		public uint DestinationQueueFamilyIndex;
		public Buffer Buffer;
		public DeviceSize Offset;
		public DeviceSize Size;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferViewCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public BufferViewCreateFlags Flags;
		public Buffer Buffer;
		public Format Format;
		public DeviceSize Offset;
		public DeviceSize Range;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DeviceCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public DeviceCreateFlags Flags;
		public uint QueueCreateInfoCount;
		public DeviceQueueCreateInfo* QueueCreateInfos;
		public uint EnabledLayerCount;
		public char** EnabledLayerNames;
		public uint EnabledExtensionCount;
		public char** EnabledExtensionNames;
		public PhysicalDeviceFeatures* EnabledFeatures;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DeviceQueueCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public DeviceQueueCreateFlags Flags;
		public uint QueueFamilyIndex;
		public uint QueueCount;
		public float* QueuePriorities;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct EventCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public EventCreateFlags Flags;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ExtensionProperties
	{
		public fixed byte ExtensionName[(int)Constants.MaxExtensionNameSize];
		public uint SpecVersion;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct FenceCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public FenceCreateFlags Flags;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImageCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public ImageCreateFlags Flags;
		public ImageType ImageType;
		public Format Format;
		public Extent3D Extent;
		public uint MipLevels;
		public uint ArrayLayers;
		public SampleCountFlags Samples;
		public ImageTiling Tiling;
		public ImageUsageFlags Usage;
		public SharingMode SharingMode;
		public uint QueueFamilyIndexCount;
		public uint* QueueFamilyIndices;
		public ImageLayout InitialLayout;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImageMemoryBarrier
	{
		public StructureType SType;
		public void* Next;
		public AccessFlags SourceAccessMask;
		public AccessFlags DestinationAccessMask;
		public ImageLayout OldLayout;
		public ImageLayout NewLayout;
		public uint SourceQueueFamilyIndex;
		public uint DestinationQueueFamilyIndex;
		public Image Image;
		public ImageSubresourceRange SubresourceRange;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImageViewCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public ImageViewCreateFlags Flags;
		public Image Image;
		public ImageViewType ViewType;
		public Format Format;
		public ComponentMapping Components;
		public ImageSubresourceRange SubresourceRange;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct InstanceCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public InstanceCreateFlags Flags;
		public ApplicationInfo* ApplicationInfo;
		public uint EnabledLayerCount;
		public char** EnabledLayerNames;
		public uint EnabledExtensionCount;
		public char** EnabledExtensionNames;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct LayerProperties
	{
		public fixed byte LayerName[(int)Constants.MaxExtensionNameSize];
		public uint SpecVersion;
		public uint ImplementationVersion;
		public fixed byte Description[(int)Constants.MaxDescriptionSize];
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct MappedMemoryRange
	{
		public StructureType SType;
		public void* Next;
		public DeviceMemory Memory;
		public DeviceSize Offset;
		public DeviceSize Size;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct MemoryAllocateInfo
	{
		public StructureType SType;
		public void* Next;
		public DeviceSize AllocationSize;
		public uint MemoryTypeIndex;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct MemoryBarrier
	{
		public StructureType SType;
		public void* Next;
		public AccessFlags SourceAccessMask;
		public AccessFlags DestinationAccessMask;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PhysicalDeviceLimits
	{
		public uint MaxImageDimension1D;
		public uint MaxImageDimension2D;
		public uint MaxImageDimension3D;
		public uint MaxImageDimensionCube;
		public uint MaxImageArrayLayers;
		public uint MaxTexelBufferElements;
		public uint MaxUniformBufferRange;
		public uint MaxStorageBufferRange;
		public uint MaxPushConstantsSize;
		public uint MaxMemoryAllocationCount;
		public uint MaxSamplerAllocationCount;
		public DeviceSize BufferImageGranularity;
		public DeviceSize SparseAddressSpaceSize;
		public uint MaxBoundDescriptorSets;
		public uint MaxPerStageDescriptorSamplers;
		public uint MaxPerStageDescriptorUniformBuffers;
		public uint MaxPerStageDescriptorStorageBuffers;
		public uint MaxPerStageDescriptorSampledImages;
		public uint MaxPerStageDescriptorStorageImages;
		public uint MaxPerStageDescriptorInputAttachments;
		public uint MaxPerStageResources;
		public uint MaxDescriptorSetSamplers;
		public uint MaxDescriptorSetUniformBuffers;
		public uint MaxDescriptorSetUniformBuffersDynamic;
		public uint MaxDescriptorSetStorageBuffers;
		public uint MaxDescriptorSetStorageBuffersDynamic;
		public uint MaxDescriptorSetSampledImages;
		public uint MaxDescriptorSetStorageImages;
		public uint MaxDescriptorSetInputAttachments;
		public uint MaxVertexInputAttributes;
		public uint MaxVertexInputBindings;
		public uint MaxVertexInputAttributeOffset;
		public uint MaxVertexInputBindingStride;
		public uint MaxVertexOutputComponents;
		public uint MaxTessellationGenerationLevel;
		public uint MaxTessellationPatchSize;
		public uint MaxTessellationControlPerVertexInputComponents;
		public uint MaxTessellationControlPerVertexOutputComponents;
		public uint MaxTessellationControlPerPatchOutputComponents;
		public uint MaxTessellationControlTotalOutputComponents;
		public uint MaxTessellationEvaluationInputComponents;
		public uint MaxTessellationEvaluationOutputComponents;
		public uint MaxGeometryShaderInvocations;
		public uint MaxGeometryInputComponents;
		public uint MaxGeometryOutputComponents;
		public uint MaxGeometryOutputVertices;
		public uint MaxGeometryTotalOutputComponents;
		public uint MaxFragmentInputComponents;
		public uint MaxFragmentOutputAttachments;
		public uint MaxFragmentDualSourceAttachments;
		public uint MaxFragmentCombinedOutputResources;
		public uint MaxComputeSharedMemorySize;
		public fixed uint MaxComputeWorkGroupCount[3];
		public uint MaxComputeWorkGroupInvocations;
		public fixed uint MaxComputeWorkGroupSize[3];
		public uint SubPixelPrecisionBits;
		public uint SubTexelPrecisionBits;
		public uint MipmapPrecisionBits;
		public uint MaxDrawIndexedIndexValue;
		public uint MaxDrawIndirectCount;
		public float MaxSamplerLodBias;
		public float MaxSamplerAnisotropy;
		public uint MaxViewports;
		public fixed uint MaxViewportDimensions[2];
		public fixed float ViewportBoundsRange[2];
		public uint ViewportSubPixelBits;
		public UIntPtr MinMemoryMapAlignment;
		public DeviceSize MinTexelBufferOffsetAlignment;
		public DeviceSize MinUniformBufferOffsetAlignment;
		public DeviceSize MinStorageBufferOffsetAlignment;
		public int MinTexelOffset;
		public uint MaxTexelOffset;
		public int MinTexelGatherOffset;
		public uint MaxTexelGatherOffset;
		public float MinInterpolationOffset;
		public float MaxInterpolationOffset;
		public uint SubPixelInterpolationOffsetBits;
		public uint MaxFramebufferWidth;
		public uint MaxFramebufferHeight;
		public uint MaxFramebufferLayers;
		public SampleCountFlags FramebufferColorSampleCounts;
		public SampleCountFlags FramebufferDepthSampleCounts;
		public SampleCountFlags FramebufferStencilSampleCounts;
		public SampleCountFlags FramebufferNoAttachmentsSampleCounts;
		public uint MaxColorAttachments;
		public SampleCountFlags SampledImageColorSampleCounts;
		public SampleCountFlags SampledImageIntegerSampleCounts;
		public SampleCountFlags SampledImageDepthSampleCounts;
		public SampleCountFlags SampledImageStencilSampleCounts;
		public SampleCountFlags StorageImageSampleCounts;
		public uint MaxSampleMaskWords;
		public Bool32 TimestampComputeAndGraphics;
		public float TimestampPeriod;
		public uint MaxClipDistances;
		public uint MaxCullDistances;
		public uint MaxCombinedClipAndCullDistances;
		public uint DiscreteQueuePriorities;
		public fixed float PointSizeRange[2];
		public fixed float LineWidthRange[2];
		public float PointSizeGranularity;
		public float LineWidthGranularity;
		public Bool32 StrictLines;
		public Bool32 StandardSampleLocations;
		public DeviceSize OptimalBufferCopyOffsetAlignment;
		public DeviceSize OptimalBufferCopyRowPitchAlignment;
		public DeviceSize NonCoherentAtomSize;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PhysicalDeviceMemoryProperties
	{
		public uint MemoryTypeCount;
		public MemoryType MemoryTypes;
		private MemoryType MemoryTypes_1;
		private MemoryType MemoryTypes_2;
		private MemoryType MemoryTypes_3;
		private MemoryType MemoryTypes_4;
		private MemoryType MemoryTypes_5;
		private MemoryType MemoryTypes_6;
		private MemoryType MemoryTypes_7;
		private MemoryType MemoryTypes_8;
		private MemoryType MemoryTypes_9;
		private MemoryType MemoryTypes_10;
		private MemoryType MemoryTypes_11;
		private MemoryType MemoryTypes_12;
		private MemoryType MemoryTypes_13;
		private MemoryType MemoryTypes_14;
		private MemoryType MemoryTypes_15;
		private MemoryType MemoryTypes_16;
		private MemoryType MemoryTypes_17;
		private MemoryType MemoryTypes_18;
		private MemoryType MemoryTypes_19;
		private MemoryType MemoryTypes_20;
		private MemoryType MemoryTypes_21;
		private MemoryType MemoryTypes_22;
		private MemoryType MemoryTypes_23;
		private MemoryType MemoryTypes_24;
		private MemoryType MemoryTypes_25;
		private MemoryType MemoryTypes_26;
		private MemoryType MemoryTypes_27;
		private MemoryType MemoryTypes_28;
		private MemoryType MemoryTypes_29;
		private MemoryType MemoryTypes_30;
		private MemoryType MemoryTypes_31;
		public uint MemoryHeapCount;
		public MemoryHeap MemoryHeaps;
		private MemoryHeap MemoryHeaps_1;
		private MemoryHeap MemoryHeaps_2;
		private MemoryHeap MemoryHeaps_3;
		private MemoryHeap MemoryHeaps_4;
		private MemoryHeap MemoryHeaps_5;
		private MemoryHeap MemoryHeaps_6;
		private MemoryHeap MemoryHeaps_7;
		private MemoryHeap MemoryHeaps_8;
		private MemoryHeap MemoryHeaps_9;
		private MemoryHeap MemoryHeaps_10;
		private MemoryHeap MemoryHeaps_11;
		private MemoryHeap MemoryHeaps_12;
		private MemoryHeap MemoryHeaps_13;
		private MemoryHeap MemoryHeaps_14;
		private MemoryHeap MemoryHeaps_15;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PhysicalDeviceProperties
	{
		public uint ApiVersion;
		public uint DriverVersion;
		public uint VendorID;
		public uint DeviceID;
		public PhysicalDeviceType DeviceType;
		public fixed byte DeviceName[(int)Constants.MaxPhysicalDeviceNameSize];
		public fixed byte PipelineCacheUUID[(int)Constants.UuidSize];
		public PhysicalDeviceLimits Limits;
		public PhysicalDeviceSparseProperties SparseProperties;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PresentInfo
	{
		public StructureType SType;
		public void* Next;
		public uint WaitSemaphoreCount;
		public Semaphore* WaitSemaphores;
		public uint SwapchainCount;
		public Swapchain* Swapchains;
		public uint* ImageIndices;
		public Result* Results;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct QueryPoolCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public QueryPoolCreateFlags Flags;
		public QueryType QueryType;
		public uint QueryCount;
		public QueryPipelineStatisticFlags PipelineStatistics;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SemaphoreCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public SemaphoreCreateFlags Flags;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ShaderModuleCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public ShaderModuleCreateFlags Flags;
		public UIntPtr CodeSize;
		public uint* Code;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseBufferMemoryBindInfo
	{
		public Buffer Buffer;
		public uint BindCount;
		public SparseMemoryBind* Binds;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseImageMemoryBind
	{
		public ImageSubresource Subresource;
		public Offset3D Offset;
		public Extent3D Extent;
		public DeviceMemory Memory;
		public DeviceSize MemoryOffset;
		public SparseMemoryBindFlags Flags;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseImageMemoryBindInfo
	{
		public Image Image;
		public uint BindCount;
		public SparseImageMemoryBind* Binds;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseImageOpaqueMemoryBindInfo
	{
		public Image Image;
		public uint BindCount;
		public SparseMemoryBind* Binds;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseMemoryBind
	{
		public DeviceSize ResourceOffset;
		public DeviceSize Size;
		public DeviceMemory Memory;
		public DeviceSize MemoryOffset;
		public SparseMemoryBindFlags Flags;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SubmitInfo
	{
		public StructureType SType;
		public void* Next;
		public uint WaitSemaphoreCount;
		public Semaphore* WaitSemaphores;
		public PipelineStageFlags* WaitDestinationStageMask;
		public uint CommandBufferCount;
		public CommandBuffer* CommandBuffers;
		public uint SignalSemaphoreCount;
		public Semaphore* SignalSemaphores;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SwapchainCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public SwapchainCreateFlags Flags;
		public Surface Surface;
		public uint MinImageCount;
		public Format ImageFormat;
		public ColorSpace ImageColorSpace;
		public Extent2D ImageExtent;
		public uint ImageArrayLayers;
		public ImageUsageFlags ImageUsage;
		public SharingMode ImageSharingMode;
		public uint QueueFamilyIndexCount;
		public uint* QueueFamilyIndices;
		public SurfaceTransformFlags PreTransform;
		public CompositeAlphaFlags CompositeAlpha;
		public PresentMode PresentMode;
		public Bool32 Clipped;
		public Swapchain OldSwapchain;
	}

    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct Win32SurfaceCreateInfo
	{
		public StructureType SType;
		public void* Next;
		public Win32SurfaceCreateFlags Flags;
		public IntPtr Hinstance;
		public IntPtr Hwnd;
	}
}