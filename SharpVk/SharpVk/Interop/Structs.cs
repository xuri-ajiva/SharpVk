//The MIT License (MIT)
//
//Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct AllocationCallbacks
	{
		/// <summary>
		/// -
		/// </summary>
		public void* UserData;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr PfnAllocation;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr PfnReallocation;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr PfnFree;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr PfnInternalAllocation;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr PfnInternalFree;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct AndroidSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public AndroidSurfaceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr* Window;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ApplicationInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public char* ApplicationName;
		/// <summary>
		/// -
		/// </summary>
		public uint ApplicationVersion;
		/// <summary>
		/// -
		/// </summary>
		public char* EngineName;
		/// <summary>
		/// -
		/// </summary>
		public uint EngineVersion;
		/// <summary>
		/// -
		/// </summary>
		public uint ApiVersion;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BindSparseInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public uint WaitSemaphoreCount;
		/// <summary>
		/// -
		/// </summary>
		public Semaphore* WaitSemaphores;
		/// <summary>
		/// -
		/// </summary>
		public uint BufferBindCount;
		/// <summary>
		/// -
		/// </summary>
		public SparseBufferMemoryBindInfo* BufferBinds;
		/// <summary>
		/// -
		/// </summary>
		public uint ImageOpaqueBindCount;
		/// <summary>
		/// -
		/// </summary>
		public SparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds;
		/// <summary>
		/// -
		/// </summary>
		public uint ImageBindCount;
		/// <summary>
		/// -
		/// </summary>
		public SparseImageMemoryBindInfo* ImageBinds;
		/// <summary>
		/// -
		/// </summary>
		public uint SignalSemaphoreCount;
		/// <summary>
		/// -
		/// </summary>
		public Semaphore* SignalSemaphores;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public BufferCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;
		/// <summary>
		/// -
		/// </summary>
		public BufferUsageFlags Usage;
		/// <summary>
		/// -
		/// </summary>
		public SharingMode SharingMode;
		/// <summary>
		/// -
		/// </summary>
		public uint QueueFamilyIndexCount;
		/// <summary>
		/// -
		/// </summary>
		public uint* QueueFamilyIndices;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferMemoryBarrier
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags SourceAccessMask;
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags DestinationAccessMask;
		/// <summary>
		/// -
		/// </summary>
		public uint SourceQueueFamilyIndex;
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationQueueFamilyIndex;
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Offset;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferViewCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public BufferViewCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer;
		/// <summary>
		/// -
		/// </summary>
		public Format Format;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Offset;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Range;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct CommandBufferAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public CommandPool CommandPool;
		/// <summary>
		/// -
		/// </summary>
		public CommandBufferLevel Level;
		/// <summary>
		/// -
		/// </summary>
		public uint CommandBufferCount;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct CommandBufferBeginInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public CommandBufferUsageFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public CommandBufferInheritanceInfo* InheritanceInfo;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct CommandBufferInheritanceInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass;
		/// <summary>
		/// -
		/// </summary>
		public uint Subpass;
		/// <summary>
		/// -
		/// </summary>
		public Framebuffer Framebuffer;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 OcclusionQueryEnable;
		/// <summary>
		/// -
		/// </summary>
		public QueryControlFlags QueryFlags;
		/// <summary>
		/// -
		/// </summary>
		public QueryPipelineStatisticFlags PipelineStatistics;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct CommandPoolCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public CommandPoolCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint QueueFamilyIndex;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ComputePipelineCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public PipelineShaderStageCreateInfo Stage;
		/// <summary>
		/// -
		/// </summary>
		public PipelineLayout Layout;
		/// <summary>
		/// -
		/// </summary>
		public Pipeline BasePipelineHandle;
		/// <summary>
		/// -
		/// </summary>
		public int BasePipelineIndex;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct CopyDescriptorSet
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSet SourceSet;
		/// <summary>
		/// -
		/// </summary>
		public uint SourceBinding;
		/// <summary>
		/// -
		/// </summary>
		public uint SourceArrayElement;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSet DestinationSet;
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationBinding;
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationArrayElement;
		/// <summary>
		/// -
		/// </summary>
		public uint DescriptorCount;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DebugMarkerMarkerInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public char* MarkerName;
		/// <summary>
		/// -
		/// </summary>
		public fixed float Color[4];
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DebugMarkerObjectNameInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DebugReportObjectType ObjectType;
		/// <summary>
		/// -
		/// </summary>
		public ulong Object;
		/// <summary>
		/// -
		/// </summary>
		public char* ObjectName;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DebugMarkerObjectTagInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DebugReportObjectType ObjectType;
		/// <summary>
		/// -
		/// </summary>
		public ulong Object;
		/// <summary>
		/// -
		/// </summary>
		public ulong TagName;
		/// <summary>
		/// -
		/// </summary>
		public UIntPtr TagSize;
		/// <summary>
		/// -
		/// </summary>
		public void* Tag;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DebugReportCallbackCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DebugReportFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr PfnCallback;
		/// <summary>
		/// -
		/// </summary>
		public void* UserData;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DebugReportLayerFlags
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public ulong EnabledValidationFlags;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DedicatedAllocationBufferCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DedicatedAllocation;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DedicatedAllocationImageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DedicatedAllocation;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DedicatedAllocationMemoryAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public Image Image;
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DescriptorBufferInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Offset;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Range;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DescriptorImageInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Sampler Sampler;
		/// <summary>
		/// -
		/// </summary>
		public ImageView ImageView;
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout ImageLayout;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DescriptorPoolCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorPoolCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxSets;
		/// <summary>
		/// -
		/// </summary>
		public uint PoolSizeCount;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorPoolSize* PoolSizes;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DescriptorSetAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorPool DescriptorPool;
		/// <summary>
		/// -
		/// </summary>
		public uint DescriptorSetCount;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayout* SetLayouts;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DescriptorSetLayoutBinding
	{
		/// <summary>
		/// -
		/// </summary>
		public uint Binding;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorType DescriptorType;
		/// <summary>
		/// -
		/// </summary>
		public uint DescriptorCount;
		/// <summary>
		/// -
		/// </summary>
		public ShaderStageFlags StageFlags;
		/// <summary>
		/// -
		/// </summary>
		public Sampler* ImmutableSamplers;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DescriptorSetLayoutCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayoutCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint BindingCount;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayoutBinding* Bindings;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DeviceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DeviceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint QueueCreateInfoCount;
		/// <summary>
		/// -
		/// </summary>
		public DeviceQueueCreateInfo* QueueCreateInfos;
		/// <summary>
		/// -
		/// </summary>
		public uint EnabledLayerCount;
		/// <summary>
		/// -
		/// </summary>
		public char** EnabledLayerNames;
		/// <summary>
		/// -
		/// </summary>
		public uint EnabledExtensionCount;
		/// <summary>
		/// -
		/// </summary>
		public char** EnabledExtensionNames;
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceFeatures* EnabledFeatures;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DeviceQueueCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DeviceQueueCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint QueueFamilyIndex;
		/// <summary>
		/// -
		/// </summary>
		public uint QueueCount;
		/// <summary>
		/// -
		/// </summary>
		public float* QueuePriorities;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DisplayModeCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DisplayModeCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public DisplayModeParameters Parameters;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DisplayModeProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public DisplayMode DisplayMode;
		/// <summary>
		/// -
		/// </summary>
		public DisplayModeParameters Parameters;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DisplayPlaneProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public Display CurrentDisplay;
		/// <summary>
		/// -
		/// </summary>
		public uint CurrentStackIndex;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DisplayPresentInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public Rect2D SourceRect;
		/// <summary>
		/// -
		/// </summary>
		public Rect2D DestinationRect;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 Persistent;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DisplayProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public Display Display;
		/// <summary>
		/// -
		/// </summary>
		public char* DisplayName;
		/// <summary>
		/// -
		/// </summary>
		public Extent2D PhysicalDimensions;
		/// <summary>
		/// -
		/// </summary>
		public Extent2D PhysicalResolution;
		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags SupportedTransforms;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 PlaneReorderPossible;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 PersistentContent;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct DisplaySurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DisplaySurfaceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public DisplayMode DisplayMode;
		/// <summary>
		/// -
		/// </summary>
		public uint PlaneIndex;
		/// <summary>
		/// -
		/// </summary>
		public uint PlaneStackIndex;
		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags Transform;
		/// <summary>
		/// -
		/// </summary>
		public float GlobalAlpha;
		/// <summary>
		/// -
		/// </summary>
		public DisplayPlaneAlphaFlags AlphaMode;
		/// <summary>
		/// -
		/// </summary>
		public Extent2D ImageExtent;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct EventCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public EventCreateFlags Flags;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ExportMemoryAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleTypes;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ExportMemoryWin32HandleInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public SECURITY_ATTRIBUTES* Attributes;
		/// <summary>
		/// -
		/// </summary>
		public uint DwAccess;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ExtensionProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public fixed byte ExtensionName[(int)Constants.MaxExtensionNameSize];
		/// <summary>
		/// -
		/// </summary>
		public uint SpecVersion;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ExternalMemoryImageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleTypes;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct FenceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public FenceCreateFlags Flags;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct FramebufferCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public FramebufferCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass;
		/// <summary>
		/// -
		/// </summary>
		public uint AttachmentCount;
		/// <summary>
		/// -
		/// </summary>
		public ImageView* Attachments;
		/// <summary>
		/// -
		/// </summary>
		public uint Width;
		/// <summary>
		/// -
		/// </summary>
		public uint Height;
		/// <summary>
		/// -
		/// </summary>
		public uint Layers;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct GraphicsPipelineCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint StageCount;
		/// <summary>
		/// -
		/// </summary>
		public PipelineShaderStageCreateInfo* Stages;
		/// <summary>
		/// -
		/// </summary>
		public PipelineVertexInputStateCreateInfo* VertexInputState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineInputAssemblyStateCreateInfo* InputAssemblyState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineTessellationStateCreateInfo* TessellationState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineViewportStateCreateInfo* ViewportState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineRasterizationStateCreateInfo* RasterizationState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineMultisampleStateCreateInfo* MultisampleState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineDepthStencilStateCreateInfo* DepthStencilState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineColorBlendStateCreateInfo* ColorBlendState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineDynamicStateCreateInfo* DynamicState;
		/// <summary>
		/// -
		/// </summary>
		public PipelineLayout Layout;
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass;
		/// <summary>
		/// -
		/// </summary>
		public uint Subpass;
		/// <summary>
		/// -
		/// </summary>
		public Pipeline BasePipelineHandle;
		/// <summary>
		/// -
		/// </summary>
		public int BasePipelineIndex;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImageBlit
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers SourceSubresource;
		/// <summary>
		/// -
		/// </summary>
		public Offset3D SourceOffsets;
		/// <summary>
		/// -
		/// </summary>
		private Offset3D SourceOffsets_1;
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers DestinationSubresource;
		/// <summary>
		/// -
		/// </summary>
		public Offset3D DestinationOffsets;
		/// <summary>
		/// -
		/// </summary>
		private Offset3D DestinationOffsets_1;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public ImageCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public ImageType ImageType;
		/// <summary>
		/// -
		/// </summary>
		public Format Format;
		/// <summary>
		/// -
		/// </summary>
		public Extent3D Extent;
		/// <summary>
		/// -
		/// </summary>
		public uint MipLevels;
		/// <summary>
		/// -
		/// </summary>
		public uint ArrayLayers;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags Samples;
		/// <summary>
		/// -
		/// </summary>
		public ImageTiling Tiling;
		/// <summary>
		/// -
		/// </summary>
		public ImageUsageFlags Usage;
		/// <summary>
		/// -
		/// </summary>
		public SharingMode SharingMode;
		/// <summary>
		/// -
		/// </summary>
		public uint QueueFamilyIndexCount;
		/// <summary>
		/// -
		/// </summary>
		public uint* QueueFamilyIndices;
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout InitialLayout;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImageMemoryBarrier
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags SourceAccessMask;
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags DestinationAccessMask;
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout OldLayout;
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout NewLayout;
		/// <summary>
		/// -
		/// </summary>
		public uint SourceQueueFamilyIndex;
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationQueueFamilyIndex;
		/// <summary>
		/// -
		/// </summary>
		public Image Image;
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceRange SubresourceRange;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImageViewCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public ImageViewCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public Image Image;
		/// <summary>
		/// -
		/// </summary>
		public ImageViewType ViewType;
		/// <summary>
		/// -
		/// </summary>
		public Format Format;
		/// <summary>
		/// -
		/// </summary>
		public ComponentMapping Components;
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceRange SubresourceRange;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ImportMemoryWin32HandleInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleType;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Handle;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct InstanceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public InstanceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public ApplicationInfo* ApplicationInfo;
		/// <summary>
		/// -
		/// </summary>
		public uint EnabledLayerCount;
		/// <summary>
		/// -
		/// </summary>
		public char** EnabledLayerNames;
		/// <summary>
		/// -
		/// </summary>
		public uint EnabledExtensionCount;
		/// <summary>
		/// -
		/// </summary>
		public char** EnabledExtensionNames;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct LayerProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public fixed byte LayerName[(int)Constants.MaxExtensionNameSize];
		/// <summary>
		/// -
		/// </summary>
		public uint SpecVersion;
		/// <summary>
		/// -
		/// </summary>
		public uint ImplementationVersion;
		/// <summary>
		/// -
		/// </summary>
		public fixed byte Description[(int)Constants.MaxDescriptionSize];
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct MappedMemoryRange
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory Memory;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Offset;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct MemoryAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize AllocationSize;
		/// <summary>
		/// -
		/// </summary>
		public uint MemoryTypeIndex;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct MemoryBarrier
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags SourceAccessMask;
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags DestinationAccessMask;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct MirSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public MirSurfaceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr* Connection;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr* MirSurface;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PhysicalDeviceLimits
	{
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimension1D;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimension2D;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimension3D;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimensionCube;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageArrayLayers;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTexelBufferElements;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxUniformBufferRange;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxStorageBufferRange;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPushConstantsSize;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxMemoryAllocationCount;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxSamplerAllocationCount;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize BufferImageGranularity;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize SparseAddressSpaceSize;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxBoundDescriptorSets;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorSamplers;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorUniformBuffers;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorStorageBuffers;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorSampledImages;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorStorageImages;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorInputAttachments;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageResources;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetSamplers;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetUniformBuffers;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetUniformBuffersDynamic;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetStorageBuffers;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetStorageBuffersDynamic;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetSampledImages;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetStorageImages;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetInputAttachments;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputAttributes;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputBindings;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputAttributeOffset;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputBindingStride;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexOutputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationGenerationLevel;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationPatchSize;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlPerVertexInputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlPerVertexOutputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlPerPatchOutputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlTotalOutputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationEvaluationInputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationEvaluationOutputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryShaderInvocations;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryInputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryOutputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryOutputVertices;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryTotalOutputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentInputComponents;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentOutputAttachments;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentDualSourceAttachments;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentCombinedOutputResources;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxComputeSharedMemorySize;
		/// <summary>
		/// -
		/// </summary>
		public fixed uint MaxComputeWorkGroupCount[3];
		/// <summary>
		/// -
		/// </summary>
		public uint MaxComputeWorkGroupInvocations;
		/// <summary>
		/// -
		/// </summary>
		public fixed uint MaxComputeWorkGroupSize[3];
		/// <summary>
		/// -
		/// </summary>
		public uint SubPixelPrecisionBits;
		/// <summary>
		/// -
		/// </summary>
		public uint SubTexelPrecisionBits;
		/// <summary>
		/// -
		/// </summary>
		public uint MipmapPrecisionBits;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDrawIndexedIndexValue;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDrawIndirectCount;
		/// <summary>
		/// -
		/// </summary>
		public float MaxSamplerLodBias;
		/// <summary>
		/// -
		/// </summary>
		public float MaxSamplerAnisotropy;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxViewports;
		/// <summary>
		/// -
		/// </summary>
		public fixed uint MaxViewportDimensions[2];
		/// <summary>
		/// -
		/// </summary>
		public fixed float ViewportBoundsRange[2];
		/// <summary>
		/// -
		/// </summary>
		public uint ViewportSubPixelBits;
		/// <summary>
		/// -
		/// </summary>
		public UIntPtr MinMemoryMapAlignment;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize MinTexelBufferOffsetAlignment;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize MinUniformBufferOffsetAlignment;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize MinStorageBufferOffsetAlignment;
		/// <summary>
		/// -
		/// </summary>
		public int MinTexelOffset;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTexelOffset;
		/// <summary>
		/// -
		/// </summary>
		public int MinTexelGatherOffset;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTexelGatherOffset;
		/// <summary>
		/// -
		/// </summary>
		public float MinInterpolationOffset;
		/// <summary>
		/// -
		/// </summary>
		public float MaxInterpolationOffset;
		/// <summary>
		/// -
		/// </summary>
		public uint SubPixelInterpolationOffsetBits;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFramebufferWidth;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFramebufferHeight;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFramebufferLayers;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferColorSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferDepthSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferStencilSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferNoAttachmentsSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxColorAttachments;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageColorSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageIntegerSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageDepthSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageStencilSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags StorageImageSampleCounts;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxSampleMaskWords;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 TimestampComputeAndGraphics;
		/// <summary>
		/// -
		/// </summary>
		public float TimestampPeriod;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxClipDistances;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxCullDistances;
		/// <summary>
		/// -
		/// </summary>
		public uint MaxCombinedClipAndCullDistances;
		/// <summary>
		/// -
		/// </summary>
		public uint DiscreteQueuePriorities;
		/// <summary>
		/// -
		/// </summary>
		public fixed float PointSizeRange[2];
		/// <summary>
		/// -
		/// </summary>
		public fixed float LineWidthRange[2];
		/// <summary>
		/// -
		/// </summary>
		public float PointSizeGranularity;
		/// <summary>
		/// -
		/// </summary>
		public float LineWidthGranularity;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 StrictLines;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 StandardSampleLocations;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize OptimalBufferCopyOffsetAlignment;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize OptimalBufferCopyRowPitchAlignment;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize NonCoherentAtomSize;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PhysicalDeviceMemoryProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public uint MemoryTypeCount;
		/// <summary>
		/// -
		/// </summary>
		public MemoryType MemoryTypes;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_1;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_2;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_3;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_4;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_5;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_6;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_7;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_8;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_9;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_10;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_11;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_12;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_13;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_14;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_15;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_16;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_17;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_18;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_19;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_20;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_21;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_22;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_23;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_24;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_25;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_26;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_27;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_28;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_29;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_30;
		/// <summary>
		/// -
		/// </summary>
		private MemoryType MemoryTypes_31;
		/// <summary>
		/// -
		/// </summary>
		public uint MemoryHeapCount;
		/// <summary>
		/// -
		/// </summary>
		public MemoryHeap MemoryHeaps;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_1;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_2;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_3;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_4;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_5;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_6;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_7;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_8;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_9;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_10;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_11;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_12;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_13;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_14;
		/// <summary>
		/// -
		/// </summary>
		private MemoryHeap MemoryHeaps_15;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PhysicalDeviceProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public uint ApiVersion;
		/// <summary>
		/// -
		/// </summary>
		public uint DriverVersion;
		/// <summary>
		/// -
		/// </summary>
		public uint VendorID;
		/// <summary>
		/// -
		/// </summary>
		public uint DeviceID;
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceType DeviceType;
		/// <summary>
		/// -
		/// </summary>
		public fixed byte DeviceName[(int)Constants.MaxPhysicalDeviceNameSize];
		/// <summary>
		/// -
		/// </summary>
		public fixed byte PipelineCacheUUID[(int)Constants.UuidSize];
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceLimits Limits;
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceSparseProperties SparseProperties;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineCacheCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineCacheCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public UIntPtr InitialDataSize;
		/// <summary>
		/// -
		/// </summary>
		public void* InitialData;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineColorBlendStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineColorBlendStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 LogicOpEnable;
		/// <summary>
		/// -
		/// </summary>
		public LogicOp LogicOp;
		/// <summary>
		/// -
		/// </summary>
		public uint AttachmentCount;
		/// <summary>
		/// -
		/// </summary>
		public PipelineColorBlendAttachmentState* Attachments;
		/// <summary>
		/// -
		/// </summary>
		public fixed float BlendConstants[4];
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineDepthStencilStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineDepthStencilStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthTestEnable;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthWriteEnable;
		/// <summary>
		/// -
		/// </summary>
		public CompareOp DepthCompareOp;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthBoundsTestEnable;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 StencilTestEnable;
		/// <summary>
		/// -
		/// </summary>
		public StencilOpState Front;
		/// <summary>
		/// -
		/// </summary>
		public StencilOpState Back;
		/// <summary>
		/// -
		/// </summary>
		public float MinDepthBounds;
		/// <summary>
		/// -
		/// </summary>
		public float MaxDepthBounds;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineDynamicStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineDynamicStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint DynamicStateCount;
		/// <summary>
		/// -
		/// </summary>
		public DynamicState* DynamicStates;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineInputAssemblyStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineInputAssemblyStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public PrimitiveTopology Topology;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 PrimitiveRestartEnable;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineLayoutCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineLayoutCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint SetLayoutCount;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayout* SetLayouts;
		/// <summary>
		/// -
		/// </summary>
		public uint PushConstantRangeCount;
		/// <summary>
		/// -
		/// </summary>
		public PushConstantRange* PushConstantRanges;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineMultisampleStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineMultisampleStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags RasterizationSamples;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 SampleShadingEnable;
		/// <summary>
		/// -
		/// </summary>
		public float MinSampleShading;
		/// <summary>
		/// -
		/// </summary>
		public SampleMask* SampleMask;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 AlphaToCoverageEnable;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 AlphaToOneEnable;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineRasterizationStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineRasterizationStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthClampEnable;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 RasterizerDiscardEnable;
		/// <summary>
		/// -
		/// </summary>
		public PolygonMode PolygonMode;
		/// <summary>
		/// -
		/// </summary>
		public CullModeFlags CullMode;
		/// <summary>
		/// -
		/// </summary>
		public FrontFace FrontFace;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthBiasEnable;
		/// <summary>
		/// -
		/// </summary>
		public float DepthBiasConstantFactor;
		/// <summary>
		/// -
		/// </summary>
		public float DepthBiasClamp;
		/// <summary>
		/// -
		/// </summary>
		public float DepthBiasSlopeFactor;
		/// <summary>
		/// -
		/// </summary>
		public float LineWidth;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineRasterizationStateRasterizationOrder
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public RasterizationOrder RasterizationOrder;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineShaderStageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineShaderStageCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public ShaderStageFlags Stage;
		/// <summary>
		/// -
		/// </summary>
		public ShaderModule Module;
		/// <summary>
		/// -
		/// </summary>
		public char* Name;
		/// <summary>
		/// -
		/// </summary>
		public SpecializationInfo* SpecializationInfo;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineTessellationStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineTessellationStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint PatchControlPoints;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineVertexInputStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineVertexInputStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint VertexBindingDescriptionCount;
		/// <summary>
		/// -
		/// </summary>
		public VertexInputBindingDescription* VertexBindingDescriptions;
		/// <summary>
		/// -
		/// </summary>
		public uint VertexAttributeDescriptionCount;
		/// <summary>
		/// -
		/// </summary>
		public VertexInputAttributeDescription* VertexAttributeDescriptions;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PipelineViewportStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public PipelineViewportStateCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint ViewportCount;
		/// <summary>
		/// -
		/// </summary>
		public Viewport* Viewports;
		/// <summary>
		/// -
		/// </summary>
		public uint ScissorCount;
		/// <summary>
		/// -
		/// </summary>
		public Rect2D* Scissors;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct PresentInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public uint WaitSemaphoreCount;
		/// <summary>
		/// -
		/// </summary>
		public Semaphore* WaitSemaphores;
		/// <summary>
		/// -
		/// </summary>
		public uint SwapchainCount;
		/// <summary>
		/// -
		/// </summary>
		public Swapchain* Swapchains;
		/// <summary>
		/// -
		/// </summary>
		public uint* ImageIndices;
		/// <summary>
		/// -
		/// </summary>
		public Result* Results;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct QueryPoolCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public QueryPoolCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public QueryType QueryType;
		/// <summary>
		/// -
		/// </summary>
		public uint QueryCount;
		/// <summary>
		/// -
		/// </summary>
		public QueryPipelineStatisticFlags PipelineStatistics;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct RenderPassBeginInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass;
		/// <summary>
		/// -
		/// </summary>
		public Framebuffer Framebuffer;
		/// <summary>
		/// -
		/// </summary>
		public Rect2D RenderArea;
		/// <summary>
		/// -
		/// </summary>
		public uint ClearValueCount;
		/// <summary>
		/// -
		/// </summary>
		public ClearValue* ClearValues;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct RenderPassCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public RenderPassCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public uint AttachmentCount;
		/// <summary>
		/// -
		/// </summary>
		public AttachmentDescription* Attachments;
		/// <summary>
		/// -
		/// </summary>
		public uint SubpassCount;
		/// <summary>
		/// -
		/// </summary>
		public SubpassDescription* Subpasses;
		/// <summary>
		/// -
		/// </summary>
		public uint DependencyCount;
		/// <summary>
		/// -
		/// </summary>
		public SubpassDependency* Dependencies;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SamplerCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public SamplerCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public Filter MagFilter;
		/// <summary>
		/// -
		/// </summary>
		public Filter MinFilter;
		/// <summary>
		/// -
		/// </summary>
		public SamplerMipmapMode MipmapMode;
		/// <summary>
		/// -
		/// </summary>
		public SamplerAddressMode AddressModeU;
		/// <summary>
		/// -
		/// </summary>
		public SamplerAddressMode AddressModeV;
		/// <summary>
		/// -
		/// </summary>
		public SamplerAddressMode AddressModeW;
		/// <summary>
		/// -
		/// </summary>
		public float MipLodBias;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 AnisotropyEnable;
		/// <summary>
		/// -
		/// </summary>
		public float MaxAnisotropy;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 CompareEnable;
		/// <summary>
		/// -
		/// </summary>
		public CompareOp CompareOp;
		/// <summary>
		/// -
		/// </summary>
		public float MinLod;
		/// <summary>
		/// -
		/// </summary>
		public float MaxLod;
		/// <summary>
		/// -
		/// </summary>
		public BorderColor BorderColor;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 UnnormalizedCoordinates;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SemaphoreCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public SemaphoreCreateFlags Flags;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct ShaderModuleCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public ShaderModuleCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public UIntPtr CodeSize;
		/// <summary>
		/// -
		/// </summary>
		public uint* Code;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseBufferMemoryBindInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer;
		/// <summary>
		/// -
		/// </summary>
		public uint BindCount;
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBind* Binds;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseImageMemoryBind
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresource Subresource;
		/// <summary>
		/// -
		/// </summary>
		public Offset3D Offset;
		/// <summary>
		/// -
		/// </summary>
		public Extent3D Extent;
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory Memory;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize MemoryOffset;
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBindFlags Flags;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseImageMemoryBindInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Image Image;
		/// <summary>
		/// -
		/// </summary>
		public uint BindCount;
		/// <summary>
		/// -
		/// </summary>
		public SparseImageMemoryBind* Binds;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseImageOpaqueMemoryBindInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Image Image;
		/// <summary>
		/// -
		/// </summary>
		public uint BindCount;
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBind* Binds;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SparseMemoryBind
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize ResourceOffset;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize Size;
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory Memory;
		/// <summary>
		/// -
		/// </summary>
		public DeviceSize MemoryOffset;
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBindFlags Flags;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SpecializationInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public uint MapEntryCount;
		/// <summary>
		/// -
		/// </summary>
		public SpecializationMapEntry* MapEntries;
		/// <summary>
		/// -
		/// </summary>
		public UIntPtr DataSize;
		/// <summary>
		/// -
		/// </summary>
		public void* Data;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SubmitInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public uint WaitSemaphoreCount;
		/// <summary>
		/// -
		/// </summary>
		public Semaphore* WaitSemaphores;
		/// <summary>
		/// -
		/// </summary>
		public PipelineStageFlags* WaitDestinationStageMask;
		/// <summary>
		/// -
		/// </summary>
		public uint CommandBufferCount;
		/// <summary>
		/// -
		/// </summary>
		public CommandBuffer* CommandBuffers;
		/// <summary>
		/// -
		/// </summary>
		public uint SignalSemaphoreCount;
		/// <summary>
		/// -
		/// </summary>
		public Semaphore* SignalSemaphores;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SubpassDescription
	{
		/// <summary>
		/// -
		/// </summary>
		public SubpassDescriptionFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public PipelineBindPoint PipelineBindPoint;
		/// <summary>
		/// -
		/// </summary>
		public uint InputAttachmentCount;
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference* InputAttachments;
		/// <summary>
		/// -
		/// </summary>
		public uint ColorAttachmentCount;
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference* ColorAttachments;
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference* ResolveAttachments;
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference* DepthStencilAttachment;
		/// <summary>
		/// -
		/// </summary>
		public uint PreserveAttachmentCount;
		/// <summary>
		/// -
		/// </summary>
		public uint* PreserveAttachments;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct SwapchainCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public SwapchainCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public Surface Surface;
		/// <summary>
		/// -
		/// </summary>
		public uint MinImageCount;
		/// <summary>
		/// -
		/// </summary>
		public Format ImageFormat;
		/// <summary>
		/// -
		/// </summary>
		public ColorSpace ImageColorSpace;
		/// <summary>
		/// -
		/// </summary>
		public Extent2D ImageExtent;
		/// <summary>
		/// -
		/// </summary>
		public uint ImageArrayLayers;
		/// <summary>
		/// -
		/// </summary>
		public ImageUsageFlags ImageUsage;
		/// <summary>
		/// -
		/// </summary>
		public SharingMode ImageSharingMode;
		/// <summary>
		/// -
		/// </summary>
		public uint QueueFamilyIndexCount;
		/// <summary>
		/// -
		/// </summary>
		public uint* QueueFamilyIndices;
		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags PreTransform;
		/// <summary>
		/// -
		/// </summary>
		public CompositeAlphaFlags CompositeAlpha;
		/// <summary>
		/// -
		/// </summary>
		public PresentMode PresentMode;
		/// <summary>
		/// -
		/// </summary>
		public Bool32 Clipped;
		/// <summary>
		/// -
		/// </summary>
		public Swapchain OldSwapchain;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct WaylandSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public WaylandSurfaceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Display;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Surface;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct Win32KeyedMutexAcquireReleaseInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public uint AcquireCount;
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory* AcquireSyncs;
		/// <summary>
		/// -
		/// </summary>
		public ulong* AcquireKeys;
		/// <summary>
		/// -
		/// </summary>
		public uint* AcquireTimeoutMilliseconds;
		/// <summary>
		/// -
		/// </summary>
		public uint ReleaseCount;
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory* ReleaseSyncs;
		/// <summary>
		/// -
		/// </summary>
		public ulong* ReleaseKeys;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct Win32SurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public Win32SurfaceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Hinstance;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Hwnd;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct WriteDescriptorSet
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSet DestinationSet;
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationBinding;
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationArrayElement;
		/// <summary>
		/// -
		/// </summary>
		public uint DescriptorCount;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorType DescriptorType;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorImageInfo* ImageInfo;
		/// <summary>
		/// -
		/// </summary>
		public DescriptorBufferInfo* BufferInfo;
		/// <summary>
		/// -
		/// </summary>
		public BufferView* TexelBufferView;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct XcbSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public XcbSurfaceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr* Connection;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Window;
	}

	/// <summary>
	/// -
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
	public unsafe struct XlibSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public StructureType SType;
		/// <summary>
		/// -
		/// </summary>
		public void* Next;
		/// <summary>
		/// -
		/// </summary>
		public XlibSurfaceCreateFlags Flags;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr* Dpy;
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Window;
	}
}