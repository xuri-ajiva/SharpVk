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

namespace SharpVk
{

	public class PhysicalDeviceProperties
	{

		public uint ApiVersion
		{
			get;
			private set;
		}

		public uint DriverVersion
		{
			get;
			private set;
		}

		public uint VendorID
		{
			get;
			private set;
		}

		public uint DeviceID
		{
			get;
			private set;
		}

		public PhysicalDeviceType DeviceType
		{
			get;
			private set;
		}

		public string DeviceName
		{
			get;
			private set;
		}

		public byte[] PipelineCacheUUID
		{
			get;
			private set;
		}

		public PhysicalDeviceLimits Limits
		{
			get;
			private set;
		}

		public PhysicalDeviceSparseProperties SparseProperties
		{
			get;
			private set;
		}
	}

	public class ExtensionProperties
	{

		public string ExtensionName
		{
			get;
			private set;
		}

		public uint SpecVersion
		{
			get;
			private set;
		}
	}

	public class LayerProperties
	{

		public string LayerName
		{
			get;
			private set;
		}

		public uint SpecVersion
		{
			get;
			private set;
		}

		public uint ImplementationVersion
		{
			get;
			private set;
		}

		public string Description
		{
			get;
			private set;
		}
	}

	public class ApplicationInfo
	{

		internal unsafe Interop.ApplicationInfo MarshalTo()
		{
			var result = new Interop.ApplicationInfo();

			result.SType = StructureType.ApplicationInfo;

			result.ApplicationName = Interop.HeapUtil.MarshalStringToPointer(this.ApplicationName);
			result.ApplicationVersion = this.ApplicationVersion;
			result.EngineName = Interop.HeapUtil.MarshalStringToPointer(this.EngineName);
			result.EngineVersion = this.EngineVersion;
			result.ApiVersion = this.ApiVersion;

			return result;
		}


		public string ApplicationName
		{
			get;
			set;
		}

		public uint ApplicationVersion
		{
			get;
			set;
		}

		public string EngineName
		{
			get;
			set;
		}

		public uint EngineVersion
		{
			get;
			set;
		}

		public uint ApiVersion
		{
			get;
			set;
		}
	}

	public class AllocationCallbacks
	{

		internal unsafe Interop.AllocationCallbacks MarshalTo()
		{
			var result = new Interop.AllocationCallbacks();
			result.PfnAllocation = this.PfnAllocation;
			result.PfnReallocation = this.PfnReallocation;
			result.PfnFree = this.PfnFree;
			result.PfnInternalAllocation = this.PfnInternalAllocation;
			result.PfnInternalFree = this.PfnInternalFree;

			return result;
		}


		public IntPtr PfnAllocation
		{
			get;
			set;
		}

		public IntPtr PfnReallocation
		{
			get;
			set;
		}

		public IntPtr PfnFree
		{
			get;
			set;
		}

		public IntPtr PfnInternalAllocation
		{
			get;
			set;
		}

		public IntPtr PfnInternalFree
		{
			get;
			set;
		}
	}

	public class DeviceQueueCreateInfo
	{

		internal unsafe Interop.DeviceQueueCreateInfo MarshalTo()
		{
			var result = new Interop.DeviceQueueCreateInfo();

			result.SType = StructureType.DeviceQueueCreateInfo;

			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;
			if(this.QueuePriorities != null)
			{
				result.QueuePriorities = (float*)Marshal.AllocHGlobal(Marshal.SizeOf<float>() * this.QueuePriorities.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.QueuePriorities, this.QueuePriorities.Length, result.QueuePriorities);
				result.QueueCount = (uint)(this.QueuePriorities.Length);
			}

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public uint QueueFamilyIndex
		{
			get;
			set;
		}

		public float[] QueuePriorities
		{
			get;
			set;
		}
	}

	public class DeviceCreateInfo
	{

		internal unsafe Interop.DeviceCreateInfo MarshalTo()
		{
			var result = new Interop.DeviceCreateInfo();

			result.SType = StructureType.DeviceCreateInfo;

			result.Flags = this.Flags;
			if(this.EnabledLayerNames != null)
			{
				result.EnabledLayerNames = (char**)Marshal.AllocHGlobal(Marshal.SizeOf<string>() * this.EnabledLayerNames.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.EnabledLayerNames, this.EnabledLayerNames.Length, result.EnabledLayerNames);
				result.EnabledLayerCount = (uint)(this.EnabledLayerNames.Length);
			}
			if(this.EnabledExtensionNames != null)
			{
				result.EnabledExtensionNames = (char**)Marshal.AllocHGlobal(Marshal.SizeOf<string>() * this.EnabledExtensionNames.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.EnabledExtensionNames, this.EnabledExtensionNames.Length, result.EnabledExtensionNames);
				result.EnabledExtensionCount = (uint)(this.EnabledExtensionNames.Length);
			}

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public DeviceQueueCreateInfo[] QueueCreateInfos
		{
			get;
			set;
		}

		public string[] EnabledLayerNames
		{
			get;
			set;
		}

		public string[] EnabledExtensionNames
		{
			get;
			set;
		}

		public PhysicalDeviceFeatures EnabledFeatures
		{
			get;
			set;
		}
	}

	public class InstanceCreateInfo
	{

		internal unsafe Interop.InstanceCreateInfo MarshalTo()
		{
			var result = new Interop.InstanceCreateInfo();

			result.SType = StructureType.InstanceCreateInfo;

			result.Flags = this.Flags;
			if(this.EnabledLayerNames != null)
			{
				result.EnabledLayerNames = (char**)Marshal.AllocHGlobal(Marshal.SizeOf<string>() * this.EnabledLayerNames.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.EnabledLayerNames, this.EnabledLayerNames.Length, result.EnabledLayerNames);
				result.EnabledLayerCount = (uint)(this.EnabledLayerNames.Length);
			}
			if(this.EnabledExtensionNames != null)
			{
				result.EnabledExtensionNames = (char**)Marshal.AllocHGlobal(Marshal.SizeOf<string>() * this.EnabledExtensionNames.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.EnabledExtensionNames, this.EnabledExtensionNames.Length, result.EnabledExtensionNames);
				result.EnabledExtensionCount = (uint)(this.EnabledExtensionNames.Length);
			}

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public ApplicationInfo ApplicationInfo
		{
			get;
			set;
		}

		public string[] EnabledLayerNames
		{
			get;
			set;
		}

		public string[] EnabledExtensionNames
		{
			get;
			set;
		}
	}

	public class PhysicalDeviceMemoryProperties
	{

		public uint MemoryTypeCount
		{
			get;
			private set;
		}

		public MemoryType MemoryTypes
		{
			get;
			private set;
		}

		public uint MemoryHeapCount
		{
			get;
			private set;
		}

		public MemoryHeap MemoryHeaps
		{
			get;
			private set;
		}
	}

	public class MemoryAllocateInfo
	{

		internal unsafe Interop.MemoryAllocateInfo MarshalTo()
		{
			var result = new Interop.MemoryAllocateInfo();

			result.SType = StructureType.MemoryAllocateInfo;

			result.AllocationSize = this.AllocationSize;
			result.MemoryTypeIndex = this.MemoryTypeIndex;

			return result;
		}


		public ulong AllocationSize
		{
			get;
			set;
		}

		public uint MemoryTypeIndex
		{
			get;
			set;
		}
	}

	public class MappedMemoryRange
	{

		internal unsafe Interop.MappedMemoryRange MarshalTo()
		{
			var result = new Interop.MappedMemoryRange();

			result.SType = StructureType.MappedMemoryRange;

			result.Offset = this.Offset;
			result.Size = this.Size;

			return result;
		}


		public ulong Offset
		{
			get;
			set;
		}

		public ulong Size
		{
			get;
			set;
		}
	}

	public class DescriptorBufferInfo
	{

		internal unsafe Interop.DescriptorBufferInfo MarshalTo()
		{
			var result = new Interop.DescriptorBufferInfo();
			result.Offset = this.Offset;
			result.Range = this.Range;

			return result;
		}


		public ulong Offset
		{
			get;
			set;
		}

		public ulong Range
		{
			get;
			set;
		}
	}

	public class DescriptorImageInfo
	{

		internal unsafe Interop.DescriptorImageInfo MarshalTo()
		{
			var result = new Interop.DescriptorImageInfo();
			result.ImageLayout = this.ImageLayout;

			return result;
		}


		public ImageLayout ImageLayout
		{
			get;
			set;
		}
	}

	public class WriteDescriptorSet
	{

		internal unsafe Interop.WriteDescriptorSet MarshalTo()
		{
			var result = new Interop.WriteDescriptorSet();

			result.SType = StructureType.WriteDescriptorSet;

			result.DstBinding = this.DstBinding;
			result.DstArrayElement = this.DstArrayElement;
			result.DescriptorType = this.DescriptorType;

			return result;
		}


		public uint DstBinding
		{
			get;
			set;
		}

		public uint DstArrayElement
		{
			get;
			set;
		}

		public DescriptorType DescriptorType
		{
			get;
			set;
		}

		public DescriptorImageInfo[] ImageInfo
		{
			get;
			set;
		}

		public DescriptorBufferInfo[] BufferInfo
		{
			get;
			set;
		}
	}

	public class CopyDescriptorSet
	{

		internal unsafe Interop.CopyDescriptorSet MarshalTo()
		{
			var result = new Interop.CopyDescriptorSet();

			result.SType = StructureType.CopyDescriptorSet;

			result.SrcBinding = this.SrcBinding;
			result.SrcArrayElement = this.SrcArrayElement;
			result.DstBinding = this.DstBinding;
			result.DstArrayElement = this.DstArrayElement;
			result.DescriptorCount = this.DescriptorCount;

			return result;
		}


		public uint SrcBinding
		{
			get;
			set;
		}

		public uint SrcArrayElement
		{
			get;
			set;
		}

		public uint DstBinding
		{
			get;
			set;
		}

		public uint DstArrayElement
		{
			get;
			set;
		}

		public uint DescriptorCount
		{
			get;
			set;
		}
	}

	public class BufferCreateInfo
	{

		internal unsafe Interop.BufferCreateInfo MarshalTo()
		{
			var result = new Interop.BufferCreateInfo();

			result.SType = StructureType.BufferCreateInfo;

			result.Flags = this.Flags;
			result.Size = this.Size;
			result.Usage = this.Usage;
			result.SharingMode = this.SharingMode;
			if(this.QueueFamilyIndices != null)
			{
				result.QueueFamilyIndices = (uint*)Marshal.AllocHGlobal(Marshal.SizeOf<uint>() * this.QueueFamilyIndices.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.QueueFamilyIndices, this.QueueFamilyIndices.Length, result.QueueFamilyIndices);
				result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices.Length);
			}

			return result;
		}


		public BufferCreateFlags Flags
		{
			get;
			set;
		}

		public ulong Size
		{
			get;
			set;
		}

		public BufferUsageFlags Usage
		{
			get;
			set;
		}

		public SharingMode SharingMode
		{
			get;
			set;
		}

		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}
	}

	public class BufferViewCreateInfo
	{

		internal unsafe Interop.BufferViewCreateInfo MarshalTo()
		{
			var result = new Interop.BufferViewCreateInfo();

			result.SType = StructureType.BufferViewCreateInfo;

			result.Flags = this.Flags;
			result.Format = this.Format;
			result.Offset = this.Offset;
			result.Range = this.Range;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public ulong Offset
		{
			get;
			set;
		}

		public ulong Range
		{
			get;
			set;
		}
	}

	public class MemoryBarrier
	{

		internal unsafe Interop.MemoryBarrier MarshalTo()
		{
			var result = new Interop.MemoryBarrier();

			result.SType = StructureType.MemoryBarrier;

			result.SrcAccessMask = this.SrcAccessMask;
			result.DstAccessMask = this.DstAccessMask;

			return result;
		}


		public AccessFlags SrcAccessMask
		{
			get;
			set;
		}

		public AccessFlags DstAccessMask
		{
			get;
			set;
		}
	}

	public class BufferMemoryBarrier
	{

		internal unsafe Interop.BufferMemoryBarrier MarshalTo()
		{
			var result = new Interop.BufferMemoryBarrier();

			result.SType = StructureType.BufferMemoryBarrier;

			result.SrcAccessMask = this.SrcAccessMask;
			result.DstAccessMask = this.DstAccessMask;
			result.SrcQueueFamilyIndex = this.SrcQueueFamilyIndex;
			result.DstQueueFamilyIndex = this.DstQueueFamilyIndex;
			result.Offset = this.Offset;
			result.Size = this.Size;

			return result;
		}


		public AccessFlags SrcAccessMask
		{
			get;
			set;
		}

		public AccessFlags DstAccessMask
		{
			get;
			set;
		}

		public uint SrcQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DstQueueFamilyIndex
		{
			get;
			set;
		}

		public ulong Offset
		{
			get;
			set;
		}

		public ulong Size
		{
			get;
			set;
		}
	}

	public class ImageMemoryBarrier
	{

		internal unsafe Interop.ImageMemoryBarrier MarshalTo()
		{
			var result = new Interop.ImageMemoryBarrier();

			result.SType = StructureType.ImageMemoryBarrier;

			result.SrcAccessMask = this.SrcAccessMask;
			result.DstAccessMask = this.DstAccessMask;
			result.OldLayout = this.OldLayout;
			result.NewLayout = this.NewLayout;
			result.SrcQueueFamilyIndex = this.SrcQueueFamilyIndex;
			result.DstQueueFamilyIndex = this.DstQueueFamilyIndex;
			result.SubresourceRange = this.SubresourceRange;

			return result;
		}


		public AccessFlags SrcAccessMask
		{
			get;
			set;
		}

		public AccessFlags DstAccessMask
		{
			get;
			set;
		}

		public ImageLayout OldLayout
		{
			get;
			set;
		}

		public ImageLayout NewLayout
		{
			get;
			set;
		}

		public uint SrcQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DstQueueFamilyIndex
		{
			get;
			set;
		}

		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}
	}

	public class ImageCreateInfo
	{

		internal unsafe Interop.ImageCreateInfo MarshalTo()
		{
			var result = new Interop.ImageCreateInfo();

			result.SType = StructureType.ImageCreateInfo;

			result.Flags = this.Flags;
			result.ImageType = this.ImageType;
			result.Format = this.Format;
			result.Extent = this.Extent;
			result.MipLevels = this.MipLevels;
			result.ArrayLayers = this.ArrayLayers;
			result.Samples = this.Samples;
			result.Tiling = this.Tiling;
			result.Usage = this.Usage;
			result.SharingMode = this.SharingMode;
			if(this.QueueFamilyIndices != null)
			{
				result.QueueFamilyIndices = (uint*)Marshal.AllocHGlobal(Marshal.SizeOf<uint>() * this.QueueFamilyIndices.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.QueueFamilyIndices, this.QueueFamilyIndices.Length, result.QueueFamilyIndices);
				result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices.Length);
			}
			result.InitialLayout = this.InitialLayout;

			return result;
		}


		public ImageCreateFlags Flags
		{
			get;
			set;
		}

		public ImageType ImageType
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public Extent3D Extent
		{
			get;
			set;
		}

		public uint MipLevels
		{
			get;
			set;
		}

		public uint ArrayLayers
		{
			get;
			set;
		}

		public SampleCountFlags Samples
		{
			get;
			set;
		}

		public ImageTiling Tiling
		{
			get;
			set;
		}

		public ImageUsageFlags Usage
		{
			get;
			set;
		}

		public SharingMode SharingMode
		{
			get;
			set;
		}

		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}

		public ImageLayout InitialLayout
		{
			get;
			set;
		}
	}

	public class ImageViewCreateInfo
	{

		internal unsafe Interop.ImageViewCreateInfo MarshalTo()
		{
			var result = new Interop.ImageViewCreateInfo();

			result.SType = StructureType.ImageViewCreateInfo;

			result.Flags = this.Flags;
			result.ViewType = this.ViewType;
			result.Format = this.Format;
			result.Components = this.Components;
			result.SubresourceRange = this.SubresourceRange;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public ImageViewType ViewType
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public ComponentMapping Components
		{
			get;
			set;
		}

		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}
	}

	public class SparseMemoryBind
	{

		internal unsafe Interop.SparseMemoryBind MarshalTo()
		{
			var result = new Interop.SparseMemoryBind();
			result.ResourceOffset = this.ResourceOffset;
			result.Size = this.Size;
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;

			return result;
		}


		public ulong ResourceOffset
		{
			get;
			set;
		}

		public ulong Size
		{
			get;
			set;
		}

		public ulong MemoryOffset
		{
			get;
			set;
		}

		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}
	}

	public class SparseImageMemoryBind
	{

		internal unsafe Interop.SparseImageMemoryBind MarshalTo()
		{
			var result = new Interop.SparseImageMemoryBind();
			result.Subresource = this.Subresource;
			result.Offset = this.Offset;
			result.Extent = this.Extent;
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;

			return result;
		}


		public ImageSubresource Subresource
		{
			get;
			set;
		}

		public Offset3D Offset
		{
			get;
			set;
		}

		public Extent3D Extent
		{
			get;
			set;
		}

		public ulong MemoryOffset
		{
			get;
			set;
		}

		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}
	}

	public class SparseBufferMemoryBindInfo
	{

		internal unsafe Interop.SparseBufferMemoryBindInfo MarshalTo()
		{
			var result = new Interop.SparseBufferMemoryBindInfo();

			return result;
		}


		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}
	}

	public class SparseImageOpaqueMemoryBindInfo
	{

		internal unsafe Interop.SparseImageOpaqueMemoryBindInfo MarshalTo()
		{
			var result = new Interop.SparseImageOpaqueMemoryBindInfo();

			return result;
		}


		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}
	}

	public class SparseImageMemoryBindInfo
	{

		internal unsafe Interop.SparseImageMemoryBindInfo MarshalTo()
		{
			var result = new Interop.SparseImageMemoryBindInfo();

			return result;
		}


		public SparseImageMemoryBind[] Binds
		{
			get;
			set;
		}
	}

	public class BindSparseInfo
	{

		internal unsafe Interop.BindSparseInfo MarshalTo()
		{
			var result = new Interop.BindSparseInfo();

			result.SType = StructureType.BindSparseInfo;


			return result;
		}


		public SparseBufferMemoryBindInfo[] BufferBinds
		{
			get;
			set;
		}

		public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
		{
			get;
			set;
		}

		public SparseImageMemoryBindInfo[] ImageBinds
		{
			get;
			set;
		}
	}

	public class ImageBlit
	{

		internal unsafe Interop.ImageBlit MarshalTo()
		{
			var result = new Interop.ImageBlit();
			result.SrcSubresource = this.SrcSubresource;
			result.SrcOffsets = this.SrcOffsets;
			result.DstSubresource = this.DstSubresource;
			result.DstOffsets = this.DstOffsets;

			return result;
		}


		public ImageSubresourceLayers SrcSubresource
		{
			get;
			set;
		}

		public Offset3D SrcOffsets
		{
			get;
			set;
		}

		public ImageSubresourceLayers DstSubresource
		{
			get;
			set;
		}

		public Offset3D DstOffsets
		{
			get;
			set;
		}
	}

	public class ShaderModuleCreateInfo
	{

		internal unsafe Interop.ShaderModuleCreateInfo MarshalTo()
		{
			var result = new Interop.ShaderModuleCreateInfo();

			result.SType = StructureType.ShaderModuleCreateInfo;

			result.Flags = this.Flags;
			if(this.Code != null)
			{
				result.Code = (uint*)Marshal.AllocHGlobal(Marshal.SizeOf<uint>() * this.Code.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.Code, this.Code.Length, result.Code);
				result.CodeSize = (UIntPtr)(this.Code.Length * 4);
			}

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public uint[] Code
		{
			get;
			set;
		}
	}

	public class DescriptorSetLayoutBinding
	{

		internal unsafe Interop.DescriptorSetLayoutBinding MarshalTo()
		{
			var result = new Interop.DescriptorSetLayoutBinding();
			result.Binding = this.Binding;
			result.DescriptorType = this.DescriptorType;
			result.StageFlags = this.StageFlags;

			return result;
		}


		public uint Binding
		{
			get;
			set;
		}

		public DescriptorType DescriptorType
		{
			get;
			set;
		}

		public ShaderStageFlags StageFlags
		{
			get;
			set;
		}
	}

	public class DescriptorSetLayoutCreateInfo
	{

		internal unsafe Interop.DescriptorSetLayoutCreateInfo MarshalTo()
		{
			var result = new Interop.DescriptorSetLayoutCreateInfo();

			result.SType = StructureType.DescriptorSetLayoutCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public DescriptorSetLayoutBinding[] Bindings
		{
			get;
			set;
		}
	}

	public class DescriptorPoolCreateInfo
	{

		internal unsafe Interop.DescriptorPoolCreateInfo MarshalTo()
		{
			var result = new Interop.DescriptorPoolCreateInfo();

			result.SType = StructureType.DescriptorPoolCreateInfo;

			result.Flags = this.Flags;
			result.MaxSets = this.MaxSets;

			return result;
		}


		public DescriptorPoolCreateFlags Flags
		{
			get;
			set;
		}

		public uint MaxSets
		{
			get;
			set;
		}

		public DescriptorPoolSize[] PoolSizes
		{
			get;
			set;
		}
	}

	public class DescriptorSetAllocateInfo
	{

		internal unsafe Interop.DescriptorSetAllocateInfo MarshalTo()
		{
			var result = new Interop.DescriptorSetAllocateInfo();

			result.SType = StructureType.DescriptorSetAllocateInfo;


			return result;
		}

	}

	public class SpecializationInfo
	{

		internal unsafe Interop.SpecializationInfo MarshalTo()
		{
			var result = new Interop.SpecializationInfo();

			return result;
		}


		public SpecializationMapEntry[] MapEntries
		{
			get;
			set;
		}
	}

	public class PipelineShaderStageCreateInfo
	{

		internal unsafe Interop.PipelineShaderStageCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineShaderStageCreateInfo();

			result.SType = StructureType.PipelineShaderStageCreateInfo;

			result.Flags = this.Flags;
			result.Stage = this.Stage;
			result.Name = Interop.HeapUtil.MarshalStringToPointer(this.Name);

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public ShaderStageFlags Stage
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public SpecializationInfo SpecializationInfo
		{
			get;
			set;
		}
	}

	public class ComputePipelineCreateInfo
	{

		internal unsafe Interop.ComputePipelineCreateInfo MarshalTo()
		{
			var result = new Interop.ComputePipelineCreateInfo();

			result.SType = StructureType.ComputePipelineCreateInfo;

			result.Flags = this.Flags;
			result.Stage = this.Stage.MarshalTo();
			result.BasePipelineIndex = this.BasePipelineIndex;

			return result;
		}


		public PipelineCreateFlags Flags
		{
			get;
			set;
		}

		public PipelineShaderStageCreateInfo Stage
		{
			get;
			set;
		}

		public int BasePipelineIndex
		{
			get;
			set;
		}
	}

	public class PipelineVertexInputStateCreateInfo
	{

		internal unsafe Interop.PipelineVertexInputStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineVertexInputStateCreateInfo();

			result.SType = StructureType.PipelineVertexInputStateCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public VertexInputBindingDescription[] VertexBindingDescriptions
		{
			get;
			set;
		}

		public VertexInputAttributeDescription[] VertexAttributeDescriptions
		{
			get;
			set;
		}
	}

	public class PipelineInputAssemblyStateCreateInfo
	{

		internal unsafe Interop.PipelineInputAssemblyStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineInputAssemblyStateCreateInfo();

			result.SType = StructureType.PipelineInputAssemblyStateCreateInfo;

			result.Flags = this.Flags;
			result.Topology = this.Topology;
			result.PrimitiveRestartEnable = this.PrimitiveRestartEnable;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public PrimitiveTopology Topology
		{
			get;
			set;
		}

		public bool PrimitiveRestartEnable
		{
			get;
			set;
		}
	}

	public class PipelineTessellationStateCreateInfo
	{

		internal unsafe Interop.PipelineTessellationStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineTessellationStateCreateInfo();

			result.SType = StructureType.PipelineTessellationStateCreateInfo;

			result.Flags = this.Flags;
			result.PatchControlPoints = this.PatchControlPoints;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public uint PatchControlPoints
		{
			get;
			set;
		}
	}

	public class PipelineViewportStateCreateInfo
	{

		internal unsafe Interop.PipelineViewportStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineViewportStateCreateInfo();

			result.SType = StructureType.PipelineViewportStateCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public Viewport[] Viewports
		{
			get;
			set;
		}

		public Rect2D[] Scissors
		{
			get;
			set;
		}
	}

	public class PipelineRasterizationStateCreateInfo
	{

		internal unsafe Interop.PipelineRasterizationStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineRasterizationStateCreateInfo();

			result.SType = StructureType.PipelineRasterizationStateCreateInfo;

			result.Flags = this.Flags;
			result.DepthClampEnable = this.DepthClampEnable;
			result.RasterizerDiscardEnable = this.RasterizerDiscardEnable;
			result.PolygonMode = this.PolygonMode;
			result.CullMode = this.CullMode;
			result.FrontFace = this.FrontFace;
			result.DepthBiasEnable = this.DepthBiasEnable;
			result.DepthBiasConstantFactor = this.DepthBiasConstantFactor;
			result.DepthBiasClamp = this.DepthBiasClamp;
			result.DepthBiasSlopeFactor = this.DepthBiasSlopeFactor;
			result.LineWidth = this.LineWidth;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public bool DepthClampEnable
		{
			get;
			set;
		}

		public bool RasterizerDiscardEnable
		{
			get;
			set;
		}

		public PolygonMode PolygonMode
		{
			get;
			set;
		}

		public CullModeFlags CullMode
		{
			get;
			set;
		}

		public FrontFace FrontFace
		{
			get;
			set;
		}

		public bool DepthBiasEnable
		{
			get;
			set;
		}

		public float DepthBiasConstantFactor
		{
			get;
			set;
		}

		public float DepthBiasClamp
		{
			get;
			set;
		}

		public float DepthBiasSlopeFactor
		{
			get;
			set;
		}

		public float LineWidth
		{
			get;
			set;
		}
	}

	public class PipelineMultisampleStateCreateInfo
	{

		internal unsafe Interop.PipelineMultisampleStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineMultisampleStateCreateInfo();

			result.SType = StructureType.PipelineMultisampleStateCreateInfo;

			result.Flags = this.Flags;
			result.RasterizationSamples = this.RasterizationSamples;
			result.SampleShadingEnable = this.SampleShadingEnable;
			result.MinSampleShading = this.MinSampleShading;
			result.AlphaToCoverageEnable = this.AlphaToCoverageEnable;
			result.AlphaToOneEnable = this.AlphaToOneEnable;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public SampleCountFlags RasterizationSamples
		{
			get;
			set;
		}

		public bool SampleShadingEnable
		{
			get;
			set;
		}

		public float MinSampleShading
		{
			get;
			set;
		}

		public uint[] SampleMask
		{
			get;
			set;
		}

		public bool AlphaToCoverageEnable
		{
			get;
			set;
		}

		public bool AlphaToOneEnable
		{
			get;
			set;
		}
	}

	public class PipelineColorBlendStateCreateInfo
	{

		internal unsafe Interop.PipelineColorBlendStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineColorBlendStateCreateInfo();

			result.SType = StructureType.PipelineColorBlendStateCreateInfo;

			result.Flags = this.Flags;
			result.LogicOpEnable = this.LogicOpEnable;
			result.LogicOp = this.LogicOp;
			Interop.HeapUtil.MarshalArrayToPointer(this.BlendConstants, 4, result.BlendConstants);

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public bool LogicOpEnable
		{
			get;
			set;
		}

		public LogicOp LogicOp
		{
			get;
			set;
		}

		public PipelineColorBlendAttachmentState[] Attachments
		{
			get;
			set;
		}

		public float[] BlendConstants
		{
			get;
			set;
		}
	}

	public class PipelineDynamicStateCreateInfo
	{

		internal unsafe Interop.PipelineDynamicStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineDynamicStateCreateInfo();

			result.SType = StructureType.PipelineDynamicStateCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public DynamicState[] DynamicStates
		{
			get;
			set;
		}
	}

	public class PipelineDepthStencilStateCreateInfo
	{

		internal unsafe Interop.PipelineDepthStencilStateCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineDepthStencilStateCreateInfo();

			result.SType = StructureType.PipelineDepthStencilStateCreateInfo;

			result.Flags = this.Flags;
			result.DepthTestEnable = this.DepthTestEnable;
			result.DepthWriteEnable = this.DepthWriteEnable;
			result.DepthCompareOp = this.DepthCompareOp;
			result.DepthBoundsTestEnable = this.DepthBoundsTestEnable;
			result.StencilTestEnable = this.StencilTestEnable;
			result.Front = this.Front;
			result.Back = this.Back;
			result.MinDepthBounds = this.MinDepthBounds;
			result.MaxDepthBounds = this.MaxDepthBounds;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public bool DepthTestEnable
		{
			get;
			set;
		}

		public bool DepthWriteEnable
		{
			get;
			set;
		}

		public CompareOp DepthCompareOp
		{
			get;
			set;
		}

		public bool DepthBoundsTestEnable
		{
			get;
			set;
		}

		public bool StencilTestEnable
		{
			get;
			set;
		}

		public StencilOpState Front
		{
			get;
			set;
		}

		public StencilOpState Back
		{
			get;
			set;
		}

		public float MinDepthBounds
		{
			get;
			set;
		}

		public float MaxDepthBounds
		{
			get;
			set;
		}
	}

	public class GraphicsPipelineCreateInfo
	{

		internal unsafe Interop.GraphicsPipelineCreateInfo MarshalTo()
		{
			var result = new Interop.GraphicsPipelineCreateInfo();

			result.SType = StructureType.GraphicsPipelineCreateInfo;

			result.Flags = this.Flags;
			result.Subpass = this.Subpass;
			result.BasePipelineIndex = this.BasePipelineIndex;

			return result;
		}


		public PipelineCreateFlags Flags
		{
			get;
			set;
		}

		public PipelineShaderStageCreateInfo[] Stages
		{
			get;
			set;
		}

		public PipelineVertexInputStateCreateInfo VertexInputState
		{
			get;
			set;
		}

		public PipelineInputAssemblyStateCreateInfo InputAssemblyState
		{
			get;
			set;
		}

		public PipelineTessellationStateCreateInfo TessellationState
		{
			get;
			set;
		}

		public PipelineViewportStateCreateInfo ViewportState
		{
			get;
			set;
		}

		public PipelineRasterizationStateCreateInfo RasterizationState
		{
			get;
			set;
		}

		public PipelineMultisampleStateCreateInfo MultisampleState
		{
			get;
			set;
		}

		public PipelineDepthStencilStateCreateInfo DepthStencilState
		{
			get;
			set;
		}

		public PipelineColorBlendStateCreateInfo ColorBlendState
		{
			get;
			set;
		}

		public PipelineDynamicStateCreateInfo DynamicState
		{
			get;
			set;
		}

		public uint Subpass
		{
			get;
			set;
		}

		public int BasePipelineIndex
		{
			get;
			set;
		}
	}

	public class PipelineCacheCreateInfo
	{

		internal unsafe Interop.PipelineCacheCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineCacheCreateInfo();

			result.SType = StructureType.PipelineCacheCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}
	}

	public class PipelineLayoutCreateInfo
	{

		internal unsafe Interop.PipelineLayoutCreateInfo MarshalTo()
		{
			var result = new Interop.PipelineLayoutCreateInfo();

			result.SType = StructureType.PipelineLayoutCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public PushConstantRange[] PushConstantRanges
		{
			get;
			set;
		}
	}

	public class SamplerCreateInfo
	{

		internal unsafe Interop.SamplerCreateInfo MarshalTo()
		{
			var result = new Interop.SamplerCreateInfo();

			result.SType = StructureType.SamplerCreateInfo;

			result.Flags = this.Flags;
			result.MagFilter = this.MagFilter;
			result.MinFilter = this.MinFilter;
			result.MipmapMode = this.MipmapMode;
			result.AddressModeU = this.AddressModeU;
			result.AddressModeV = this.AddressModeV;
			result.AddressModeW = this.AddressModeW;
			result.MipLodBias = this.MipLodBias;
			result.AnisotropyEnable = this.AnisotropyEnable;
			result.MaxAnisotropy = this.MaxAnisotropy;
			result.CompareEnable = this.CompareEnable;
			result.CompareOp = this.CompareOp;
			result.MinLod = this.MinLod;
			result.MaxLod = this.MaxLod;
			result.BorderColor = this.BorderColor;
			result.UnnormalizedCoordinates = this.UnnormalizedCoordinates;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public Filter MagFilter
		{
			get;
			set;
		}

		public Filter MinFilter
		{
			get;
			set;
		}

		public SamplerMipmapMode MipmapMode
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeU
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeV
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeW
		{
			get;
			set;
		}

		public float MipLodBias
		{
			get;
			set;
		}

		public bool AnisotropyEnable
		{
			get;
			set;
		}

		public float MaxAnisotropy
		{
			get;
			set;
		}

		public bool CompareEnable
		{
			get;
			set;
		}

		public CompareOp CompareOp
		{
			get;
			set;
		}

		public float MinLod
		{
			get;
			set;
		}

		public float MaxLod
		{
			get;
			set;
		}

		public BorderColor BorderColor
		{
			get;
			set;
		}

		public bool UnnormalizedCoordinates
		{
			get;
			set;
		}
	}

	public class CommandPoolCreateInfo
	{

		internal unsafe Interop.CommandPoolCreateInfo MarshalTo()
		{
			var result = new Interop.CommandPoolCreateInfo();

			result.SType = StructureType.CommandPoolCreateInfo;

			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;

			return result;
		}


		public CommandPoolCreateFlags Flags
		{
			get;
			set;
		}

		public uint QueueFamilyIndex
		{
			get;
			set;
		}
	}

	public class CommandBufferAllocateInfo
	{

		internal unsafe Interop.CommandBufferAllocateInfo MarshalTo()
		{
			var result = new Interop.CommandBufferAllocateInfo();

			result.SType = StructureType.CommandBufferAllocateInfo;

			result.Level = this.Level;
			result.CommandBufferCount = this.CommandBufferCount;

			return result;
		}


		public CommandBufferLevel Level
		{
			get;
			set;
		}

		public uint CommandBufferCount
		{
			get;
			set;
		}
	}

	public class CommandBufferInheritanceInfo
	{

		internal unsafe Interop.CommandBufferInheritanceInfo MarshalTo()
		{
			var result = new Interop.CommandBufferInheritanceInfo();

			result.SType = StructureType.CommandBufferInheritanceInfo;

			result.Subpass = this.Subpass;
			result.OcclusionQueryEnable = this.OcclusionQueryEnable;
			result.QueryFlags = this.QueryFlags;
			result.PipelineStatistics = this.PipelineStatistics;

			return result;
		}


		public uint Subpass
		{
			get;
			set;
		}

		public bool OcclusionQueryEnable
		{
			get;
			set;
		}

		public QueryControlFlags QueryFlags
		{
			get;
			set;
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}
	}

	public class CommandBufferBeginInfo
	{

		internal unsafe Interop.CommandBufferBeginInfo MarshalTo()
		{
			var result = new Interop.CommandBufferBeginInfo();

			result.SType = StructureType.CommandBufferBeginInfo;

			result.Flags = this.Flags;

			return result;
		}


		public CommandBufferUsageFlags Flags
		{
			get;
			set;
		}

		public CommandBufferInheritanceInfo InheritanceInfo
		{
			get;
			set;
		}
	}

	public class RenderPassBeginInfo
	{

		internal unsafe Interop.RenderPassBeginInfo MarshalTo()
		{
			var result = new Interop.RenderPassBeginInfo();

			result.SType = StructureType.RenderPassBeginInfo;

			result.RenderArea = this.RenderArea;

			return result;
		}


		public Rect2D RenderArea
		{
			get;
			set;
		}

		public ClearValue[] ClearValues
		{
			get;
			set;
		}
	}

	public class SubpassDescription
	{

		internal unsafe Interop.SubpassDescription MarshalTo()
		{
			var result = new Interop.SubpassDescription();
			result.Flags = this.Flags;
			result.PipelineBindPoint = this.PipelineBindPoint;
			if(this.PreserveAttachments != null)
			{
				result.PreserveAttachments = (uint*)Marshal.AllocHGlobal(Marshal.SizeOf<uint>() * this.PreserveAttachments.Length).ToPointer();
				Interop.HeapUtil.MarshalArrayToPointer(this.PreserveAttachments, this.PreserveAttachments.Length, result.PreserveAttachments);
				result.PreserveAttachmentCount = (uint)(this.PreserveAttachments.Length);
			}

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public PipelineBindPoint PipelineBindPoint
		{
			get;
			set;
		}

		public AttachmentReference[] InputAttachments
		{
			get;
			set;
		}

		public AttachmentReference[] ColorAttachments
		{
			get;
			set;
		}

		public AttachmentReference[] ResolveAttachments
		{
			get;
			set;
		}

		public AttachmentReference DepthStencilAttachment
		{
			get;
			set;
		}

		public uint[] PreserveAttachments
		{
			get;
			set;
		}
	}

	public class RenderPassCreateInfo
	{

		internal unsafe Interop.RenderPassCreateInfo MarshalTo()
		{
			var result = new Interop.RenderPassCreateInfo();

			result.SType = StructureType.RenderPassCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public AttachmentDescription[] Attachments
		{
			get;
			set;
		}

		public SubpassDescription[] Subpasses
		{
			get;
			set;
		}

		public SubpassDependency[] Dependencies
		{
			get;
			set;
		}
	}

	public class EventCreateInfo
	{

		internal unsafe Interop.EventCreateInfo MarshalTo()
		{
			var result = new Interop.EventCreateInfo();

			result.SType = StructureType.EventCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}
	}

	public class FenceCreateInfo
	{

		internal unsafe Interop.FenceCreateInfo MarshalTo()
		{
			var result = new Interop.FenceCreateInfo();

			result.SType = StructureType.FenceCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public FenceCreateFlags Flags
		{
			get;
			set;
		}
	}

	public class PhysicalDeviceLimits
	{

		public uint MaxImageDimension1D
		{
			get;
			private set;
		}

		public uint MaxImageDimension2D
		{
			get;
			private set;
		}

		public uint MaxImageDimension3D
		{
			get;
			private set;
		}

		public uint MaxImageDimensionCube
		{
			get;
			private set;
		}

		public uint MaxImageArrayLayers
		{
			get;
			private set;
		}

		public uint MaxTexelBufferElements
		{
			get;
			private set;
		}

		public uint MaxUniformBufferRange
		{
			get;
			private set;
		}

		public uint MaxStorageBufferRange
		{
			get;
			private set;
		}

		public uint MaxPushConstantsSize
		{
			get;
			private set;
		}

		public uint MaxMemoryAllocationCount
		{
			get;
			private set;
		}

		public uint MaxSamplerAllocationCount
		{
			get;
			private set;
		}

		public ulong BufferImageGranularity
		{
			get;
			private set;
		}

		public ulong SparseAddressSpaceSize
		{
			get;
			private set;
		}

		public uint MaxBoundDescriptorSets
		{
			get;
			private set;
		}

		public uint MaxPerStageDescriptorSamplers
		{
			get;
			private set;
		}

		public uint MaxPerStageDescriptorUniformBuffers
		{
			get;
			private set;
		}

		public uint MaxPerStageDescriptorStorageBuffers
		{
			get;
			private set;
		}

		public uint MaxPerStageDescriptorSampledImages
		{
			get;
			private set;
		}

		public uint MaxPerStageDescriptorStorageImages
		{
			get;
			private set;
		}

		public uint MaxPerStageDescriptorInputAttachments
		{
			get;
			private set;
		}

		public uint MaxPerStageResources
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetSamplers
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetUniformBuffers
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetUniformBuffersDynamic
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetStorageBuffers
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetStorageBuffersDynamic
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetSampledImages
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetStorageImages
		{
			get;
			private set;
		}

		public uint MaxDescriptorSetInputAttachments
		{
			get;
			private set;
		}

		public uint MaxVertexInputAttributes
		{
			get;
			private set;
		}

		public uint MaxVertexInputBindings
		{
			get;
			private set;
		}

		public uint MaxVertexInputAttributeOffset
		{
			get;
			private set;
		}

		public uint MaxVertexInputBindingStride
		{
			get;
			private set;
		}

		public uint MaxVertexOutputComponents
		{
			get;
			private set;
		}

		public uint MaxTessellationGenerationLevel
		{
			get;
			private set;
		}

		public uint MaxTessellationPatchSize
		{
			get;
			private set;
		}

		public uint MaxTessellationControlPerVertexInputComponents
		{
			get;
			private set;
		}

		public uint MaxTessellationControlPerVertexOutputComponents
		{
			get;
			private set;
		}

		public uint MaxTessellationControlPerPatchOutputComponents
		{
			get;
			private set;
		}

		public uint MaxTessellationControlTotalOutputComponents
		{
			get;
			private set;
		}

		public uint MaxTessellationEvaluationInputComponents
		{
			get;
			private set;
		}

		public uint MaxTessellationEvaluationOutputComponents
		{
			get;
			private set;
		}

		public uint MaxGeometryShaderInvocations
		{
			get;
			private set;
		}

		public uint MaxGeometryInputComponents
		{
			get;
			private set;
		}

		public uint MaxGeometryOutputComponents
		{
			get;
			private set;
		}

		public uint MaxGeometryOutputVertices
		{
			get;
			private set;
		}

		public uint MaxGeometryTotalOutputComponents
		{
			get;
			private set;
		}

		public uint MaxFragmentInputComponents
		{
			get;
			private set;
		}

		public uint MaxFragmentOutputAttachments
		{
			get;
			private set;
		}

		public uint MaxFragmentDualSrcAttachments
		{
			get;
			private set;
		}

		public uint MaxFragmentCombinedOutputResources
		{
			get;
			private set;
		}

		public uint MaxComputeSharedMemorySize
		{
			get;
			private set;
		}

		public uint[] MaxComputeWorkGroupCount
		{
			get;
			private set;
		}

		public uint MaxComputeWorkGroupInvocations
		{
			get;
			private set;
		}

		public uint[] MaxComputeWorkGroupSize
		{
			get;
			private set;
		}

		public uint SubPixelPrecisionBits
		{
			get;
			private set;
		}

		public uint SubTexelPrecisionBits
		{
			get;
			private set;
		}

		public uint MipmapPrecisionBits
		{
			get;
			private set;
		}

		public uint MaxDrawIndexedIndexValue
		{
			get;
			private set;
		}

		public uint MaxDrawIndirectCount
		{
			get;
			private set;
		}

		public float MaxSamplerLodBias
		{
			get;
			private set;
		}

		public float MaxSamplerAnisotropy
		{
			get;
			private set;
		}

		public uint MaxViewports
		{
			get;
			private set;
		}

		public uint[] MaxViewportDimensions
		{
			get;
			private set;
		}

		public float[] ViewportBoundsRange
		{
			get;
			private set;
		}

		public uint ViewportSubPixelBits
		{
			get;
			private set;
		}

		public UIntPtr MinMemoryMapAlignment
		{
			get;
			private set;
		}

		public ulong MinTexelBufferOffsetAlignment
		{
			get;
			private set;
		}

		public ulong MinUniformBufferOffsetAlignment
		{
			get;
			private set;
		}

		public ulong MinStorageBufferOffsetAlignment
		{
			get;
			private set;
		}

		public int MinTexelOffset
		{
			get;
			private set;
		}

		public uint MaxTexelOffset
		{
			get;
			private set;
		}

		public int MinTexelGatherOffset
		{
			get;
			private set;
		}

		public uint MaxTexelGatherOffset
		{
			get;
			private set;
		}

		public float MinInterpolationOffset
		{
			get;
			private set;
		}

		public float MaxInterpolationOffset
		{
			get;
			private set;
		}

		public uint SubPixelInterpolationOffsetBits
		{
			get;
			private set;
		}

		public uint MaxFramebufferWidth
		{
			get;
			private set;
		}

		public uint MaxFramebufferHeight
		{
			get;
			private set;
		}

		public uint MaxFramebufferLayers
		{
			get;
			private set;
		}

		public SampleCountFlags FramebufferColorSampleCounts
		{
			get;
			private set;
		}

		public SampleCountFlags FramebufferDepthSampleCounts
		{
			get;
			private set;
		}

		public SampleCountFlags FramebufferStencilSampleCounts
		{
			get;
			private set;
		}

		public SampleCountFlags FramebufferNoAttachmentsSampleCounts
		{
			get;
			private set;
		}

		public uint MaxColorAttachments
		{
			get;
			private set;
		}

		public SampleCountFlags SampledImageColorSampleCounts
		{
			get;
			private set;
		}

		public SampleCountFlags SampledImageIntegerSampleCounts
		{
			get;
			private set;
		}

		public SampleCountFlags SampledImageDepthSampleCounts
		{
			get;
			private set;
		}

		public SampleCountFlags SampledImageStencilSampleCounts
		{
			get;
			private set;
		}

		public SampleCountFlags StorageImageSampleCounts
		{
			get;
			private set;
		}

		public uint MaxSampleMaskWords
		{
			get;
			private set;
		}

		public bool TimestampComputeAndGraphics
		{
			get;
			private set;
		}

		public float TimestampPeriod
		{
			get;
			private set;
		}

		public uint MaxClipDistances
		{
			get;
			private set;
		}

		public uint MaxCullDistances
		{
			get;
			private set;
		}

		public uint MaxCombinedClipAndCullDistances
		{
			get;
			private set;
		}

		public uint DiscreteQueuePriorities
		{
			get;
			private set;
		}

		public float[] PointSizeRange
		{
			get;
			private set;
		}

		public float[] LineWidthRange
		{
			get;
			private set;
		}

		public float PointSizeGranularity
		{
			get;
			private set;
		}

		public float LineWidthGranularity
		{
			get;
			private set;
		}

		public bool StrictLines
		{
			get;
			private set;
		}

		public bool StandardSampleLocations
		{
			get;
			private set;
		}

		public ulong OptimalBufferCopyOffsetAlignment
		{
			get;
			private set;
		}

		public ulong OptimalBufferCopyRowPitchAlignment
		{
			get;
			private set;
		}

		public ulong NonCoherentAtomSize
		{
			get;
			private set;
		}
	}

	public class SemaphoreCreateInfo
	{

		internal unsafe Interop.SemaphoreCreateInfo MarshalTo()
		{
			var result = new Interop.SemaphoreCreateInfo();

			result.SType = StructureType.SemaphoreCreateInfo;

			result.Flags = this.Flags;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}
	}

	public class QueryPoolCreateInfo
	{

		internal unsafe Interop.QueryPoolCreateInfo MarshalTo()
		{
			var result = new Interop.QueryPoolCreateInfo();

			result.SType = StructureType.QueryPoolCreateInfo;

			result.Flags = this.Flags;
			result.QueryType = this.QueryType;
			result.QueryCount = this.QueryCount;
			result.PipelineStatistics = this.PipelineStatistics;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public QueryType QueryType
		{
			get;
			set;
		}

		public uint QueryCount
		{
			get;
			set;
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}
	}

	public class FramebufferCreateInfo
	{

		internal unsafe Interop.FramebufferCreateInfo MarshalTo()
		{
			var result = new Interop.FramebufferCreateInfo();

			result.SType = StructureType.FramebufferCreateInfo;

			result.Flags = this.Flags;
			result.Width = this.Width;
			result.Height = this.Height;
			result.Layers = this.Layers;

			return result;
		}


		public uint Flags
		{
			get;
			set;
		}

		public uint Width
		{
			get;
			set;
		}

		public uint Height
		{
			get;
			set;
		}

		public uint Layers
		{
			get;
			set;
		}
	}

	public class SubmitInfo
	{

		internal unsafe Interop.SubmitInfo MarshalTo()
		{
			var result = new Interop.SubmitInfo();

			result.SType = StructureType.SubmitInfo;


			return result;
		}


		public PipelineStageFlags[] WaitDstStageMask
		{
			get;
			set;
		}
	}
}
