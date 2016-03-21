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

namespace SharpVk
{

	public unsafe class PhysicalDeviceProperties
		: IDisposable
	{
		internal Interop.PhysicalDeviceProperties* instance;

		internal PhysicalDeviceProperties(Interop.PhysicalDeviceProperties* instance)
		{
			this.instance = instance == null ? Interop.PhysicalDeviceProperties.Create() : instance;
		}

		public static PhysicalDeviceProperties Create()
		{
			var result = new PhysicalDeviceProperties(null);

			return result;
		}

		public uint ApiVersion
		{
			get
			{
				return this.instance->ApiVersion;
			}
		}

		public uint DriverVersion
		{
			get
			{
				return this.instance->DriverVersion;
			}
		}

		public uint VendorID
		{
			get
			{
				return this.instance->VendorID;
			}
		}

		public uint DeviceID
		{
			get
			{
				return this.instance->DeviceID;
			}
		}

		public PhysicalDeviceType DeviceType
		{
			get
			{
				return this.instance->DeviceType;
			}
		}

		public string DeviceName
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToString(this.instance->DeviceName);
			}
		}

		public byte[] PipelineCacheUUID
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->PipelineCacheUUID, 16);
			}
		}

		public PhysicalDeviceLimits Limits
		{
			get
			{
				return new PhysicalDeviceLimits(&(this.instance->Limits));
			}
		}

		public PhysicalDeviceSparseProperties SparseProperties
		{
			get
			{
				return this.instance->SparseProperties;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ExtensionProperties
		: IDisposable
	{
		internal Interop.ExtensionProperties* instance;

		internal ExtensionProperties(Interop.ExtensionProperties* instance)
		{
			this.instance = instance == null ? Interop.ExtensionProperties.Create() : instance;
		}

		public static ExtensionProperties Create()
		{
			var result = new ExtensionProperties(null);

			return result;
		}

		public string ExtensionName
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToString(this.instance->ExtensionName);
			}
		}

		public uint SpecVersion
		{
			get
			{
				return this.instance->SpecVersion;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class LayerProperties
		: IDisposable
	{
		internal Interop.LayerProperties* instance;

		internal LayerProperties(Interop.LayerProperties* instance)
		{
			this.instance = instance == null ? Interop.LayerProperties.Create() : instance;
		}

		public static LayerProperties Create()
		{
			var result = new LayerProperties(null);

			return result;
		}

		public string LayerName
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToString(this.instance->LayerName);
			}
		}

		public uint SpecVersion
		{
			get
			{
				return this.instance->SpecVersion;
			}
		}

		public uint ImplementationVersion
		{
			get
			{
				return this.instance->ImplementationVersion;
			}
		}

		public string Description
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToString(this.instance->Description);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ApplicationInfo
		: IDisposable
	{
		internal Interop.ApplicationInfo* instance;

		internal ApplicationInfo(Interop.ApplicationInfo* instance)
		{
			this.instance = instance == null ? Interop.ApplicationInfo.Create() : instance;
		}

		public static ApplicationInfo Create()
		{
			var result = new ApplicationInfo(null);

			result.instance->SType = StructureType.ApplicationInfo;

			return result;
		}

		public string ApplicationName
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToString(this.instance->ApplicationName);
			}
			set
			{
				this.instance->ApplicationName = Interop.HeapUtil.MarshalStringToPointer(value);
			}
		}

		public uint ApplicationVersion
		{
			get
			{
				return this.instance->ApplicationVersion;
			}
			set
			{
				this.instance->ApplicationVersion = value;
			}
		}

		public string EngineName
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToString(this.instance->EngineName);
			}
			set
			{
				this.instance->EngineName = Interop.HeapUtil.MarshalStringToPointer(value);
			}
		}

		public uint EngineVersion
		{
			get
			{
				return this.instance->EngineVersion;
			}
			set
			{
				this.instance->EngineVersion = value;
			}
		}

		public uint ApiVersion
		{
			get
			{
				return this.instance->ApiVersion;
			}
			set
			{
				this.instance->ApiVersion = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class AllocationCallbacks
		: IDisposable
	{
		internal Interop.AllocationCallbacks* instance;

		internal AllocationCallbacks(Interop.AllocationCallbacks* instance)
		{
			this.instance = instance == null ? Interop.AllocationCallbacks.Create() : instance;
		}

		public static AllocationCallbacks Create()
		{
			var result = new AllocationCallbacks(null);

			return result;
		}

		public IntPtr PfnAllocation
		{
			get
			{
				return this.instance->PfnAllocation;
			}
			set
			{
				this.instance->PfnAllocation = value;
			}
		}

		public IntPtr PfnReallocation
		{
			get
			{
				return this.instance->PfnReallocation;
			}
			set
			{
				this.instance->PfnReallocation = value;
			}
		}

		public IntPtr PfnFree
		{
			get
			{
				return this.instance->PfnFree;
			}
			set
			{
				this.instance->PfnFree = value;
			}
		}

		public IntPtr PfnInternalAllocation
		{
			get
			{
				return this.instance->PfnInternalAllocation;
			}
			set
			{
				this.instance->PfnInternalAllocation = value;
			}
		}

		public IntPtr PfnInternalFree
		{
			get
			{
				return this.instance->PfnInternalFree;
			}
			set
			{
				this.instance->PfnInternalFree = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DeviceQueueCreateInfo
		: IDisposable
	{
		internal Interop.DeviceQueueCreateInfo* instance;

		internal DeviceQueueCreateInfo(Interop.DeviceQueueCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.DeviceQueueCreateInfo.Create() : instance;
		}

		public static DeviceQueueCreateInfo Create()
		{
			var result = new DeviceQueueCreateInfo(null);

			result.instance->SType = StructureType.DeviceQueueCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public uint QueueFamilyIndex
		{
			get
			{
				return this.instance->QueueFamilyIndex;
			}
			set
			{
				this.instance->QueueFamilyIndex = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DeviceCreateInfo
		: IDisposable
	{
		internal Interop.DeviceCreateInfo* instance;

		internal DeviceCreateInfo(Interop.DeviceCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.DeviceCreateInfo.Create() : instance;
		}

		public static DeviceCreateInfo Create()
		{
			var result = new DeviceCreateInfo(null);

			result.instance->SType = StructureType.DeviceCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class InstanceCreateInfo
		: IDisposable
	{
		internal Interop.InstanceCreateInfo* instance;

		internal InstanceCreateInfo(Interop.InstanceCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.InstanceCreateInfo.Create() : instance;
		}

		public static InstanceCreateInfo Create()
		{
			var result = new InstanceCreateInfo(null);

			result.instance->SType = StructureType.InstanceCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PhysicalDeviceMemoryProperties
		: IDisposable
	{
		internal Interop.PhysicalDeviceMemoryProperties* instance;

		internal PhysicalDeviceMemoryProperties(Interop.PhysicalDeviceMemoryProperties* instance)
		{
			this.instance = instance == null ? Interop.PhysicalDeviceMemoryProperties.Create() : instance;
		}

		public static PhysicalDeviceMemoryProperties Create()
		{
			var result = new PhysicalDeviceMemoryProperties(null);

			return result;
		}

		public uint MemoryTypeCount
		{
			get
			{
				return this.instance->MemoryTypeCount;
			}
		}

		public MemoryType MemoryTypes_0
		{
			get
			{
				return this.instance->MemoryTypes_0;
			}
		}

		public MemoryType MemoryTypes_1
		{
			get
			{
				return this.instance->MemoryTypes_1;
			}
		}

		public MemoryType MemoryTypes_2
		{
			get
			{
				return this.instance->MemoryTypes_2;
			}
		}

		public MemoryType MemoryTypes_3
		{
			get
			{
				return this.instance->MemoryTypes_3;
			}
		}

		public MemoryType MemoryTypes_4
		{
			get
			{
				return this.instance->MemoryTypes_4;
			}
		}

		public MemoryType MemoryTypes_5
		{
			get
			{
				return this.instance->MemoryTypes_5;
			}
		}

		public MemoryType MemoryTypes_6
		{
			get
			{
				return this.instance->MemoryTypes_6;
			}
		}

		public MemoryType MemoryTypes_7
		{
			get
			{
				return this.instance->MemoryTypes_7;
			}
		}

		public MemoryType MemoryTypes_8
		{
			get
			{
				return this.instance->MemoryTypes_8;
			}
		}

		public MemoryType MemoryTypes_9
		{
			get
			{
				return this.instance->MemoryTypes_9;
			}
		}

		public MemoryType MemoryTypes_10
		{
			get
			{
				return this.instance->MemoryTypes_10;
			}
		}

		public MemoryType MemoryTypes_11
		{
			get
			{
				return this.instance->MemoryTypes_11;
			}
		}

		public MemoryType MemoryTypes_12
		{
			get
			{
				return this.instance->MemoryTypes_12;
			}
		}

		public MemoryType MemoryTypes_13
		{
			get
			{
				return this.instance->MemoryTypes_13;
			}
		}

		public MemoryType MemoryTypes_14
		{
			get
			{
				return this.instance->MemoryTypes_14;
			}
		}

		public MemoryType MemoryTypes_15
		{
			get
			{
				return this.instance->MemoryTypes_15;
			}
		}

		public MemoryType MemoryTypes_16
		{
			get
			{
				return this.instance->MemoryTypes_16;
			}
		}

		public MemoryType MemoryTypes_17
		{
			get
			{
				return this.instance->MemoryTypes_17;
			}
		}

		public MemoryType MemoryTypes_18
		{
			get
			{
				return this.instance->MemoryTypes_18;
			}
		}

		public MemoryType MemoryTypes_19
		{
			get
			{
				return this.instance->MemoryTypes_19;
			}
		}

		public MemoryType MemoryTypes_20
		{
			get
			{
				return this.instance->MemoryTypes_20;
			}
		}

		public MemoryType MemoryTypes_21
		{
			get
			{
				return this.instance->MemoryTypes_21;
			}
		}

		public MemoryType MemoryTypes_22
		{
			get
			{
				return this.instance->MemoryTypes_22;
			}
		}

		public MemoryType MemoryTypes_23
		{
			get
			{
				return this.instance->MemoryTypes_23;
			}
		}

		public MemoryType MemoryTypes_24
		{
			get
			{
				return this.instance->MemoryTypes_24;
			}
		}

		public MemoryType MemoryTypes_25
		{
			get
			{
				return this.instance->MemoryTypes_25;
			}
		}

		public MemoryType MemoryTypes_26
		{
			get
			{
				return this.instance->MemoryTypes_26;
			}
		}

		public MemoryType MemoryTypes_27
		{
			get
			{
				return this.instance->MemoryTypes_27;
			}
		}

		public MemoryType MemoryTypes_28
		{
			get
			{
				return this.instance->MemoryTypes_28;
			}
		}

		public MemoryType MemoryTypes_29
		{
			get
			{
				return this.instance->MemoryTypes_29;
			}
		}

		public MemoryType MemoryTypes_30
		{
			get
			{
				return this.instance->MemoryTypes_30;
			}
		}

		public MemoryType MemoryTypes_31
		{
			get
			{
				return this.instance->MemoryTypes_31;
			}
		}

		public uint MemoryHeapCount
		{
			get
			{
				return this.instance->MemoryHeapCount;
			}
		}

		public MemoryHeap MemoryHeaps_0
		{
			get
			{
				return this.instance->MemoryHeaps_0;
			}
		}

		public MemoryHeap MemoryHeaps_1
		{
			get
			{
				return this.instance->MemoryHeaps_1;
			}
		}

		public MemoryHeap MemoryHeaps_2
		{
			get
			{
				return this.instance->MemoryHeaps_2;
			}
		}

		public MemoryHeap MemoryHeaps_3
		{
			get
			{
				return this.instance->MemoryHeaps_3;
			}
		}

		public MemoryHeap MemoryHeaps_4
		{
			get
			{
				return this.instance->MemoryHeaps_4;
			}
		}

		public MemoryHeap MemoryHeaps_5
		{
			get
			{
				return this.instance->MemoryHeaps_5;
			}
		}

		public MemoryHeap MemoryHeaps_6
		{
			get
			{
				return this.instance->MemoryHeaps_6;
			}
		}

		public MemoryHeap MemoryHeaps_7
		{
			get
			{
				return this.instance->MemoryHeaps_7;
			}
		}

		public MemoryHeap MemoryHeaps_8
		{
			get
			{
				return this.instance->MemoryHeaps_8;
			}
		}

		public MemoryHeap MemoryHeaps_9
		{
			get
			{
				return this.instance->MemoryHeaps_9;
			}
		}

		public MemoryHeap MemoryHeaps_10
		{
			get
			{
				return this.instance->MemoryHeaps_10;
			}
		}

		public MemoryHeap MemoryHeaps_11
		{
			get
			{
				return this.instance->MemoryHeaps_11;
			}
		}

		public MemoryHeap MemoryHeaps_12
		{
			get
			{
				return this.instance->MemoryHeaps_12;
			}
		}

		public MemoryHeap MemoryHeaps_13
		{
			get
			{
				return this.instance->MemoryHeaps_13;
			}
		}

		public MemoryHeap MemoryHeaps_14
		{
			get
			{
				return this.instance->MemoryHeaps_14;
			}
		}

		public MemoryHeap MemoryHeaps_15
		{
			get
			{
				return this.instance->MemoryHeaps_15;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class MemoryAllocateInfo
		: IDisposable
	{
		internal Interop.MemoryAllocateInfo* instance;

		internal MemoryAllocateInfo(Interop.MemoryAllocateInfo* instance)
		{
			this.instance = instance == null ? Interop.MemoryAllocateInfo.Create() : instance;
		}

		public static MemoryAllocateInfo Create()
		{
			var result = new MemoryAllocateInfo(null);

			result.instance->SType = StructureType.MemoryAllocateInfo;

			return result;
		}

		public ulong AllocationSize
		{
			get
			{
				return this.instance->AllocationSize;
			}
			set
			{
				this.instance->AllocationSize = value;
			}
		}

		public uint MemoryTypeIndex
		{
			get
			{
				return this.instance->MemoryTypeIndex;
			}
			set
			{
				this.instance->MemoryTypeIndex = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class MappedMemoryRange
		: IDisposable
	{
		internal Interop.MappedMemoryRange* instance;

		internal MappedMemoryRange(Interop.MappedMemoryRange* instance)
		{
			this.instance = instance == null ? Interop.MappedMemoryRange.Create() : instance;
		}

		public static MappedMemoryRange Create()
		{
			var result = new MappedMemoryRange(null);

			result.instance->SType = StructureType.MappedMemoryRange;

			return result;
		}

		public ulong Offset
		{
			get
			{
				return this.instance->Offset;
			}
			set
			{
				this.instance->Offset = value;
			}
		}

		public ulong Size
		{
			get
			{
				return this.instance->Size;
			}
			set
			{
				this.instance->Size = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DescriptorBufferInfo
		: IDisposable
	{
		internal Interop.DescriptorBufferInfo* instance;

		internal DescriptorBufferInfo(Interop.DescriptorBufferInfo* instance)
		{
			this.instance = instance == null ? Interop.DescriptorBufferInfo.Create() : instance;
		}

		public static DescriptorBufferInfo Create()
		{
			var result = new DescriptorBufferInfo(null);

			return result;
		}

		public ulong Offset
		{
			get
			{
				return this.instance->Offset;
			}
			set
			{
				this.instance->Offset = value;
			}
		}

		public ulong Range
		{
			get
			{
				return this.instance->Range;
			}
			set
			{
				this.instance->Range = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DescriptorImageInfo
		: IDisposable
	{
		internal Interop.DescriptorImageInfo* instance;

		internal DescriptorImageInfo(Interop.DescriptorImageInfo* instance)
		{
			this.instance = instance == null ? Interop.DescriptorImageInfo.Create() : instance;
		}

		public static DescriptorImageInfo Create()
		{
			var result = new DescriptorImageInfo(null);

			return result;
		}

		public ImageLayout ImageLayout
		{
			get
			{
				return this.instance->ImageLayout;
			}
			set
			{
				this.instance->ImageLayout = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class WriteDescriptorSet
		: IDisposable
	{
		internal Interop.WriteDescriptorSet* instance;

		internal WriteDescriptorSet(Interop.WriteDescriptorSet* instance)
		{
			this.instance = instance == null ? Interop.WriteDescriptorSet.Create() : instance;
		}

		public static WriteDescriptorSet Create()
		{
			var result = new WriteDescriptorSet(null);

			result.instance->SType = StructureType.WriteDescriptorSet;

			return result;
		}

		public uint DstBinding
		{
			get
			{
				return this.instance->DstBinding;
			}
			set
			{
				this.instance->DstBinding = value;
			}
		}

		public uint DstArrayElement
		{
			get
			{
				return this.instance->DstArrayElement;
			}
			set
			{
				this.instance->DstArrayElement = value;
			}
		}

		public DescriptorType DescriptorType
		{
			get
			{
				return this.instance->DescriptorType;
			}
			set
			{
				this.instance->DescriptorType = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class CopyDescriptorSet
		: IDisposable
	{
		internal Interop.CopyDescriptorSet* instance;

		internal CopyDescriptorSet(Interop.CopyDescriptorSet* instance)
		{
			this.instance = instance == null ? Interop.CopyDescriptorSet.Create() : instance;
		}

		public static CopyDescriptorSet Create()
		{
			var result = new CopyDescriptorSet(null);

			result.instance->SType = StructureType.CopyDescriptorSet;

			return result;
		}

		public uint SrcBinding
		{
			get
			{
				return this.instance->SrcBinding;
			}
			set
			{
				this.instance->SrcBinding = value;
			}
		}

		public uint SrcArrayElement
		{
			get
			{
				return this.instance->SrcArrayElement;
			}
			set
			{
				this.instance->SrcArrayElement = value;
			}
		}

		public uint DstBinding
		{
			get
			{
				return this.instance->DstBinding;
			}
			set
			{
				this.instance->DstBinding = value;
			}
		}

		public uint DstArrayElement
		{
			get
			{
				return this.instance->DstArrayElement;
			}
			set
			{
				this.instance->DstArrayElement = value;
			}
		}

		public uint DescriptorCount
		{
			get
			{
				return this.instance->DescriptorCount;
			}
			set
			{
				this.instance->DescriptorCount = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class BufferCreateInfo
		: IDisposable
	{
		internal Interop.BufferCreateInfo* instance;

		internal BufferCreateInfo(Interop.BufferCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.BufferCreateInfo.Create() : instance;
		}

		public static BufferCreateInfo Create()
		{
			var result = new BufferCreateInfo(null);

			result.instance->SType = StructureType.BufferCreateInfo;

			return result;
		}

		public BufferCreateFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public ulong Size
		{
			get
			{
				return this.instance->Size;
			}
			set
			{
				this.instance->Size = value;
			}
		}

		public BufferUsageFlags Usage
		{
			get
			{
				return this.instance->Usage;
			}
			set
			{
				this.instance->Usage = value;
			}
		}

		public SharingMode SharingMode
		{
			get
			{
				return this.instance->SharingMode;
			}
			set
			{
				this.instance->SharingMode = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class BufferViewCreateInfo
		: IDisposable
	{
		internal Interop.BufferViewCreateInfo* instance;

		internal BufferViewCreateInfo(Interop.BufferViewCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.BufferViewCreateInfo.Create() : instance;
		}

		public static BufferViewCreateInfo Create()
		{
			var result = new BufferViewCreateInfo(null);

			result.instance->SType = StructureType.BufferViewCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public Format Format
		{
			get
			{
				return this.instance->Format;
			}
			set
			{
				this.instance->Format = value;
			}
		}

		public ulong Offset
		{
			get
			{
				return this.instance->Offset;
			}
			set
			{
				this.instance->Offset = value;
			}
		}

		public ulong Range
		{
			get
			{
				return this.instance->Range;
			}
			set
			{
				this.instance->Range = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class MemoryBarrier
		: IDisposable
	{
		internal Interop.MemoryBarrier* instance;

		internal MemoryBarrier(Interop.MemoryBarrier* instance)
		{
			this.instance = instance == null ? Interop.MemoryBarrier.Create() : instance;
		}

		public static MemoryBarrier Create()
		{
			var result = new MemoryBarrier(null);

			result.instance->SType = StructureType.MemoryBarrier;

			return result;
		}

		public AccessFlags SrcAccessMask
		{
			get
			{
				return this.instance->SrcAccessMask;
			}
			set
			{
				this.instance->SrcAccessMask = value;
			}
		}

		public AccessFlags DstAccessMask
		{
			get
			{
				return this.instance->DstAccessMask;
			}
			set
			{
				this.instance->DstAccessMask = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class BufferMemoryBarrier
		: IDisposable
	{
		internal Interop.BufferMemoryBarrier* instance;

		internal BufferMemoryBarrier(Interop.BufferMemoryBarrier* instance)
		{
			this.instance = instance == null ? Interop.BufferMemoryBarrier.Create() : instance;
		}

		public static BufferMemoryBarrier Create()
		{
			var result = new BufferMemoryBarrier(null);

			result.instance->SType = StructureType.BufferMemoryBarrier;

			return result;
		}

		public AccessFlags SrcAccessMask
		{
			get
			{
				return this.instance->SrcAccessMask;
			}
			set
			{
				this.instance->SrcAccessMask = value;
			}
		}

		public AccessFlags DstAccessMask
		{
			get
			{
				return this.instance->DstAccessMask;
			}
			set
			{
				this.instance->DstAccessMask = value;
			}
		}

		public uint SrcQueueFamilyIndex
		{
			get
			{
				return this.instance->SrcQueueFamilyIndex;
			}
			set
			{
				this.instance->SrcQueueFamilyIndex = value;
			}
		}

		public uint DstQueueFamilyIndex
		{
			get
			{
				return this.instance->DstQueueFamilyIndex;
			}
			set
			{
				this.instance->DstQueueFamilyIndex = value;
			}
		}

		public ulong Offset
		{
			get
			{
				return this.instance->Offset;
			}
			set
			{
				this.instance->Offset = value;
			}
		}

		public ulong Size
		{
			get
			{
				return this.instance->Size;
			}
			set
			{
				this.instance->Size = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageMemoryBarrier
		: IDisposable
	{
		internal Interop.ImageMemoryBarrier* instance;

		internal ImageMemoryBarrier(Interop.ImageMemoryBarrier* instance)
		{
			this.instance = instance == null ? Interop.ImageMemoryBarrier.Create() : instance;
		}

		public static ImageMemoryBarrier Create()
		{
			var result = new ImageMemoryBarrier(null);

			result.instance->SType = StructureType.ImageMemoryBarrier;

			return result;
		}

		public AccessFlags SrcAccessMask
		{
			get
			{
				return this.instance->SrcAccessMask;
			}
			set
			{
				this.instance->SrcAccessMask = value;
			}
		}

		public AccessFlags DstAccessMask
		{
			get
			{
				return this.instance->DstAccessMask;
			}
			set
			{
				this.instance->DstAccessMask = value;
			}
		}

		public ImageLayout OldLayout
		{
			get
			{
				return this.instance->OldLayout;
			}
			set
			{
				this.instance->OldLayout = value;
			}
		}

		public ImageLayout NewLayout
		{
			get
			{
				return this.instance->NewLayout;
			}
			set
			{
				this.instance->NewLayout = value;
			}
		}

		public uint SrcQueueFamilyIndex
		{
			get
			{
				return this.instance->SrcQueueFamilyIndex;
			}
			set
			{
				this.instance->SrcQueueFamilyIndex = value;
			}
		}

		public uint DstQueueFamilyIndex
		{
			get
			{
				return this.instance->DstQueueFamilyIndex;
			}
			set
			{
				this.instance->DstQueueFamilyIndex = value;
			}
		}

		public ImageSubresourceRange SubresourceRange
		{
			get
			{
				return this.instance->SubresourceRange;
			}
			set
			{
				this.instance->SubresourceRange = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageCreateInfo
		: IDisposable
	{
		internal Interop.ImageCreateInfo* instance;

		internal ImageCreateInfo(Interop.ImageCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.ImageCreateInfo.Create() : instance;
		}

		public static ImageCreateInfo Create()
		{
			var result = new ImageCreateInfo(null);

			result.instance->SType = StructureType.ImageCreateInfo;

			return result;
		}

		public ImageCreateFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public ImageType ImageType
		{
			get
			{
				return this.instance->ImageType;
			}
			set
			{
				this.instance->ImageType = value;
			}
		}

		public Format Format
		{
			get
			{
				return this.instance->Format;
			}
			set
			{
				this.instance->Format = value;
			}
		}

		public Extent3D Extent
		{
			get
			{
				return this.instance->Extent;
			}
			set
			{
				this.instance->Extent = value;
			}
		}

		public uint MipLevels
		{
			get
			{
				return this.instance->MipLevels;
			}
			set
			{
				this.instance->MipLevels = value;
			}
		}

		public uint ArrayLayers
		{
			get
			{
				return this.instance->ArrayLayers;
			}
			set
			{
				this.instance->ArrayLayers = value;
			}
		}

		public SampleCountFlags Samples
		{
			get
			{
				return this.instance->Samples;
			}
			set
			{
				this.instance->Samples = value;
			}
		}

		public ImageTiling Tiling
		{
			get
			{
				return this.instance->Tiling;
			}
			set
			{
				this.instance->Tiling = value;
			}
		}

		public ImageUsageFlags Usage
		{
			get
			{
				return this.instance->Usage;
			}
			set
			{
				this.instance->Usage = value;
			}
		}

		public SharingMode SharingMode
		{
			get
			{
				return this.instance->SharingMode;
			}
			set
			{
				this.instance->SharingMode = value;
			}
		}

		public ImageLayout InitialLayout
		{
			get
			{
				return this.instance->InitialLayout;
			}
			set
			{
				this.instance->InitialLayout = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageViewCreateInfo
		: IDisposable
	{
		internal Interop.ImageViewCreateInfo* instance;

		internal ImageViewCreateInfo(Interop.ImageViewCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.ImageViewCreateInfo.Create() : instance;
		}

		public static ImageViewCreateInfo Create()
		{
			var result = new ImageViewCreateInfo(null);

			result.instance->SType = StructureType.ImageViewCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public ImageViewType ViewType
		{
			get
			{
				return this.instance->ViewType;
			}
			set
			{
				this.instance->ViewType = value;
			}
		}

		public Format Format
		{
			get
			{
				return this.instance->Format;
			}
			set
			{
				this.instance->Format = value;
			}
		}

		public ComponentMapping Components
		{
			get
			{
				return this.instance->Components;
			}
			set
			{
				this.instance->Components = value;
			}
		}

		public ImageSubresourceRange SubresourceRange
		{
			get
			{
				return this.instance->SubresourceRange;
			}
			set
			{
				this.instance->SubresourceRange = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SparseMemoryBind
		: IDisposable
	{
		internal Interop.SparseMemoryBind* instance;

		internal SparseMemoryBind(Interop.SparseMemoryBind* instance)
		{
			this.instance = instance == null ? Interop.SparseMemoryBind.Create() : instance;
		}

		public static SparseMemoryBind Create()
		{
			var result = new SparseMemoryBind(null);

			return result;
		}

		public ulong ResourceOffset
		{
			get
			{
				return this.instance->ResourceOffset;
			}
			set
			{
				this.instance->ResourceOffset = value;
			}
		}

		public ulong Size
		{
			get
			{
				return this.instance->Size;
			}
			set
			{
				this.instance->Size = value;
			}
		}

		public ulong MemoryOffset
		{
			get
			{
				return this.instance->MemoryOffset;
			}
			set
			{
				this.instance->MemoryOffset = value;
			}
		}

		public SparseMemoryBindFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SparseImageMemoryBind
		: IDisposable
	{
		internal Interop.SparseImageMemoryBind* instance;

		internal SparseImageMemoryBind(Interop.SparseImageMemoryBind* instance)
		{
			this.instance = instance == null ? Interop.SparseImageMemoryBind.Create() : instance;
		}

		public static SparseImageMemoryBind Create()
		{
			var result = new SparseImageMemoryBind(null);

			return result;
		}

		public ImageSubresource Subresource
		{
			get
			{
				return this.instance->Subresource;
			}
			set
			{
				this.instance->Subresource = value;
			}
		}

		public Offset3D Offset
		{
			get
			{
				return this.instance->Offset;
			}
			set
			{
				this.instance->Offset = value;
			}
		}

		public Extent3D Extent
		{
			get
			{
				return this.instance->Extent;
			}
			set
			{
				this.instance->Extent = value;
			}
		}

		public ulong MemoryOffset
		{
			get
			{
				return this.instance->MemoryOffset;
			}
			set
			{
				this.instance->MemoryOffset = value;
			}
		}

		public SparseMemoryBindFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SparseBufferMemoryBindInfo
		: IDisposable
	{
		internal Interop.SparseBufferMemoryBindInfo* instance;

		internal SparseBufferMemoryBindInfo(Interop.SparseBufferMemoryBindInfo* instance)
		{
			this.instance = instance == null ? Interop.SparseBufferMemoryBindInfo.Create() : instance;
		}

		public static SparseBufferMemoryBindInfo Create()
		{
			var result = new SparseBufferMemoryBindInfo(null);

			return result;
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SparseImageOpaqueMemoryBindInfo
		: IDisposable
	{
		internal Interop.SparseImageOpaqueMemoryBindInfo* instance;

		internal SparseImageOpaqueMemoryBindInfo(Interop.SparseImageOpaqueMemoryBindInfo* instance)
		{
			this.instance = instance == null ? Interop.SparseImageOpaqueMemoryBindInfo.Create() : instance;
		}

		public static SparseImageOpaqueMemoryBindInfo Create()
		{
			var result = new SparseImageOpaqueMemoryBindInfo(null);

			return result;
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SparseImageMemoryBindInfo
		: IDisposable
	{
		internal Interop.SparseImageMemoryBindInfo* instance;

		internal SparseImageMemoryBindInfo(Interop.SparseImageMemoryBindInfo* instance)
		{
			this.instance = instance == null ? Interop.SparseImageMemoryBindInfo.Create() : instance;
		}

		public static SparseImageMemoryBindInfo Create()
		{
			var result = new SparseImageMemoryBindInfo(null);

			return result;
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class BindSparseInfo
		: IDisposable
	{
		internal Interop.BindSparseInfo* instance;

		internal BindSparseInfo(Interop.BindSparseInfo* instance)
		{
			this.instance = instance == null ? Interop.BindSparseInfo.Create() : instance;
		}

		public static BindSparseInfo Create()
		{
			var result = new BindSparseInfo(null);

			result.instance->SType = StructureType.BindSparseInfo;

			return result;
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageBlit
		: IDisposable
	{
		internal Interop.ImageBlit* instance;

		internal ImageBlit(Interop.ImageBlit* instance)
		{
			this.instance = instance == null ? Interop.ImageBlit.Create() : instance;
		}

		public static ImageBlit Create()
		{
			var result = new ImageBlit(null);

			return result;
		}

		public ImageSubresourceLayers SrcSubresource
		{
			get
			{
				return this.instance->SrcSubresource;
			}
			set
			{
				this.instance->SrcSubresource = value;
			}
		}

		public Offset3D SrcOffsets_0
		{
			get
			{
				return this.instance->SrcOffsets_0;
			}
			set
			{
				this.instance->SrcOffsets_0 = value;
			}
		}

		public Offset3D SrcOffsets_1
		{
			get
			{
				return this.instance->SrcOffsets_1;
			}
			set
			{
				this.instance->SrcOffsets_1 = value;
			}
		}

		public ImageSubresourceLayers DstSubresource
		{
			get
			{
				return this.instance->DstSubresource;
			}
			set
			{
				this.instance->DstSubresource = value;
			}
		}

		public Offset3D DstOffsets_0
		{
			get
			{
				return this.instance->DstOffsets_0;
			}
			set
			{
				this.instance->DstOffsets_0 = value;
			}
		}

		public Offset3D DstOffsets_1
		{
			get
			{
				return this.instance->DstOffsets_1;
			}
			set
			{
				this.instance->DstOffsets_1 = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ShaderModuleCreateInfo
		: IDisposable
	{
		internal Interop.ShaderModuleCreateInfo* instance;

		internal ShaderModuleCreateInfo(Interop.ShaderModuleCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.ShaderModuleCreateInfo.Create() : instance;
		}

		public static ShaderModuleCreateInfo Create()
		{
			var result = new ShaderModuleCreateInfo(null);

			result.instance->SType = StructureType.ShaderModuleCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public UIntPtr CodeSize
		{
			get
			{
				return this.instance->CodeSize;
			}
			set
			{
				this.instance->CodeSize = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DescriptorSetLayoutBinding
		: IDisposable
	{
		internal Interop.DescriptorSetLayoutBinding* instance;

		internal DescriptorSetLayoutBinding(Interop.DescriptorSetLayoutBinding* instance)
		{
			this.instance = instance == null ? Interop.DescriptorSetLayoutBinding.Create() : instance;
		}

		public static DescriptorSetLayoutBinding Create()
		{
			var result = new DescriptorSetLayoutBinding(null);

			return result;
		}

		public uint Binding
		{
			get
			{
				return this.instance->Binding;
			}
			set
			{
				this.instance->Binding = value;
			}
		}

		public DescriptorType DescriptorType
		{
			get
			{
				return this.instance->DescriptorType;
			}
			set
			{
				this.instance->DescriptorType = value;
			}
		}

		public ShaderStageFlags StageFlags
		{
			get
			{
				return this.instance->StageFlags;
			}
			set
			{
				this.instance->StageFlags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DescriptorSetLayoutCreateInfo
		: IDisposable
	{
		internal Interop.DescriptorSetLayoutCreateInfo* instance;

		internal DescriptorSetLayoutCreateInfo(Interop.DescriptorSetLayoutCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.DescriptorSetLayoutCreateInfo.Create() : instance;
		}

		public static DescriptorSetLayoutCreateInfo Create()
		{
			var result = new DescriptorSetLayoutCreateInfo(null);

			result.instance->SType = StructureType.DescriptorSetLayoutCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DescriptorPoolCreateInfo
		: IDisposable
	{
		internal Interop.DescriptorPoolCreateInfo* instance;

		internal DescriptorPoolCreateInfo(Interop.DescriptorPoolCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.DescriptorPoolCreateInfo.Create() : instance;
		}

		public static DescriptorPoolCreateInfo Create()
		{
			var result = new DescriptorPoolCreateInfo(null);

			result.instance->SType = StructureType.DescriptorPoolCreateInfo;

			return result;
		}

		public DescriptorPoolCreateFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public uint MaxSets
		{
			get
			{
				return this.instance->MaxSets;
			}
			set
			{
				this.instance->MaxSets = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DescriptorSetAllocateInfo
		: IDisposable
	{
		internal Interop.DescriptorSetAllocateInfo* instance;

		internal DescriptorSetAllocateInfo(Interop.DescriptorSetAllocateInfo* instance)
		{
			this.instance = instance == null ? Interop.DescriptorSetAllocateInfo.Create() : instance;
		}

		public static DescriptorSetAllocateInfo Create()
		{
			var result = new DescriptorSetAllocateInfo(null);

			result.instance->SType = StructureType.DescriptorSetAllocateInfo;

			return result;
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SpecializationInfo
		: IDisposable
	{
		internal Interop.SpecializationInfo* instance;

		internal SpecializationInfo(Interop.SpecializationInfo* instance)
		{
			this.instance = instance == null ? Interop.SpecializationInfo.Create() : instance;
		}

		public static SpecializationInfo Create()
		{
			var result = new SpecializationInfo(null);

			return result;
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineShaderStageCreateInfo
		: IDisposable
	{
		internal Interop.PipelineShaderStageCreateInfo* instance;

		internal PipelineShaderStageCreateInfo(Interop.PipelineShaderStageCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineShaderStageCreateInfo.Create() : instance;
		}

		public static PipelineShaderStageCreateInfo Create()
		{
			var result = new PipelineShaderStageCreateInfo(null);

			result.instance->SType = StructureType.PipelineShaderStageCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public ShaderStageFlags Stage
		{
			get
			{
				return this.instance->Stage;
			}
			set
			{
				this.instance->Stage = value;
			}
		}

		public string Name
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToString(this.instance->Name);
			}
			set
			{
				this.instance->Name = Interop.HeapUtil.MarshalStringToPointer(value);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ComputePipelineCreateInfo
		: IDisposable
	{
		internal Interop.ComputePipelineCreateInfo* instance;

		internal ComputePipelineCreateInfo(Interop.ComputePipelineCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.ComputePipelineCreateInfo.Create() : instance;
		}

		public static ComputePipelineCreateInfo Create()
		{
			var result = new ComputePipelineCreateInfo(null);

			result.instance->SType = StructureType.ComputePipelineCreateInfo;

			return result;
		}

		public PipelineCreateFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public PipelineShaderStageCreateInfo Stage
		{
			get
			{
				return new PipelineShaderStageCreateInfo(&(this.instance->Stage));
			}
			set
			{
				this.instance->Stage = *(value.instance);
			}
		}

		public int BasePipelineIndex
		{
			get
			{
				return this.instance->BasePipelineIndex;
			}
			set
			{
				this.instance->BasePipelineIndex = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineVertexInputStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineVertexInputStateCreateInfo* instance;

		internal PipelineVertexInputStateCreateInfo(Interop.PipelineVertexInputStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineVertexInputStateCreateInfo.Create() : instance;
		}

		public static PipelineVertexInputStateCreateInfo Create()
		{
			var result = new PipelineVertexInputStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineVertexInputStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineInputAssemblyStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineInputAssemblyStateCreateInfo* instance;

		internal PipelineInputAssemblyStateCreateInfo(Interop.PipelineInputAssemblyStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineInputAssemblyStateCreateInfo.Create() : instance;
		}

		public static PipelineInputAssemblyStateCreateInfo Create()
		{
			var result = new PipelineInputAssemblyStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineInputAssemblyStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public PrimitiveTopology Topology
		{
			get
			{
				return this.instance->Topology;
			}
			set
			{
				this.instance->Topology = value;
			}
		}

		public bool PrimitiveRestartEnable
		{
			get
			{
				return this.instance->PrimitiveRestartEnable;
			}
			set
			{
				this.instance->PrimitiveRestartEnable = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineTessellationStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineTessellationStateCreateInfo* instance;

		internal PipelineTessellationStateCreateInfo(Interop.PipelineTessellationStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineTessellationStateCreateInfo.Create() : instance;
		}

		public static PipelineTessellationStateCreateInfo Create()
		{
			var result = new PipelineTessellationStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineTessellationStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public uint PatchControlPoints
		{
			get
			{
				return this.instance->PatchControlPoints;
			}
			set
			{
				this.instance->PatchControlPoints = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineViewportStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineViewportStateCreateInfo* instance;

		internal PipelineViewportStateCreateInfo(Interop.PipelineViewportStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineViewportStateCreateInfo.Create() : instance;
		}

		public static PipelineViewportStateCreateInfo Create()
		{
			var result = new PipelineViewportStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineViewportStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineRasterizationStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineRasterizationStateCreateInfo* instance;

		internal PipelineRasterizationStateCreateInfo(Interop.PipelineRasterizationStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineRasterizationStateCreateInfo.Create() : instance;
		}

		public static PipelineRasterizationStateCreateInfo Create()
		{
			var result = new PipelineRasterizationStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineRasterizationStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public bool DepthClampEnable
		{
			get
			{
				return this.instance->DepthClampEnable;
			}
			set
			{
				this.instance->DepthClampEnable = value;
			}
		}

		public bool RasterizerDiscardEnable
		{
			get
			{
				return this.instance->RasterizerDiscardEnable;
			}
			set
			{
				this.instance->RasterizerDiscardEnable = value;
			}
		}

		public PolygonMode PolygonMode
		{
			get
			{
				return this.instance->PolygonMode;
			}
			set
			{
				this.instance->PolygonMode = value;
			}
		}

		public CullModeFlags CullMode
		{
			get
			{
				return this.instance->CullMode;
			}
			set
			{
				this.instance->CullMode = value;
			}
		}

		public FrontFace FrontFace
		{
			get
			{
				return this.instance->FrontFace;
			}
			set
			{
				this.instance->FrontFace = value;
			}
		}

		public bool DepthBiasEnable
		{
			get
			{
				return this.instance->DepthBiasEnable;
			}
			set
			{
				this.instance->DepthBiasEnable = value;
			}
		}

		public float DepthBiasConstantFactor
		{
			get
			{
				return this.instance->DepthBiasConstantFactor;
			}
			set
			{
				this.instance->DepthBiasConstantFactor = value;
			}
		}

		public float DepthBiasClamp
		{
			get
			{
				return this.instance->DepthBiasClamp;
			}
			set
			{
				this.instance->DepthBiasClamp = value;
			}
		}

		public float DepthBiasSlopeFactor
		{
			get
			{
				return this.instance->DepthBiasSlopeFactor;
			}
			set
			{
				this.instance->DepthBiasSlopeFactor = value;
			}
		}

		public float LineWidth
		{
			get
			{
				return this.instance->LineWidth;
			}
			set
			{
				this.instance->LineWidth = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineMultisampleStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineMultisampleStateCreateInfo* instance;

		internal PipelineMultisampleStateCreateInfo(Interop.PipelineMultisampleStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineMultisampleStateCreateInfo.Create() : instance;
		}

		public static PipelineMultisampleStateCreateInfo Create()
		{
			var result = new PipelineMultisampleStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineMultisampleStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public SampleCountFlags RasterizationSamples
		{
			get
			{
				return this.instance->RasterizationSamples;
			}
			set
			{
				this.instance->RasterizationSamples = value;
			}
		}

		public bool SampleShadingEnable
		{
			get
			{
				return this.instance->SampleShadingEnable;
			}
			set
			{
				this.instance->SampleShadingEnable = value;
			}
		}

		public float MinSampleShading
		{
			get
			{
				return this.instance->MinSampleShading;
			}
			set
			{
				this.instance->MinSampleShading = value;
			}
		}

		public bool AlphaToCoverageEnable
		{
			get
			{
				return this.instance->AlphaToCoverageEnable;
			}
			set
			{
				this.instance->AlphaToCoverageEnable = value;
			}
		}

		public bool AlphaToOneEnable
		{
			get
			{
				return this.instance->AlphaToOneEnable;
			}
			set
			{
				this.instance->AlphaToOneEnable = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineColorBlendStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineColorBlendStateCreateInfo* instance;

		internal PipelineColorBlendStateCreateInfo(Interop.PipelineColorBlendStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineColorBlendStateCreateInfo.Create() : instance;
		}

		public static PipelineColorBlendStateCreateInfo Create()
		{
			var result = new PipelineColorBlendStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineColorBlendStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public bool LogicOpEnable
		{
			get
			{
				return this.instance->LogicOpEnable;
			}
			set
			{
				this.instance->LogicOpEnable = value;
			}
		}

		public LogicOp LogicOp
		{
			get
			{
				return this.instance->LogicOp;
			}
			set
			{
				this.instance->LogicOp = value;
			}
		}

		public float[] BlendConstants
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->BlendConstants, 4);
			}
			set
			{
				Interop.HeapUtil.MarshalArrayToPointer(value, 4, this.instance->BlendConstants);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineDynamicStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineDynamicStateCreateInfo* instance;

		internal PipelineDynamicStateCreateInfo(Interop.PipelineDynamicStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineDynamicStateCreateInfo.Create() : instance;
		}

		public static PipelineDynamicStateCreateInfo Create()
		{
			var result = new PipelineDynamicStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineDynamicStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineDepthStencilStateCreateInfo
		: IDisposable
	{
		internal Interop.PipelineDepthStencilStateCreateInfo* instance;

		internal PipelineDepthStencilStateCreateInfo(Interop.PipelineDepthStencilStateCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineDepthStencilStateCreateInfo.Create() : instance;
		}

		public static PipelineDepthStencilStateCreateInfo Create()
		{
			var result = new PipelineDepthStencilStateCreateInfo(null);

			result.instance->SType = StructureType.PipelineDepthStencilStateCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public bool DepthTestEnable
		{
			get
			{
				return this.instance->DepthTestEnable;
			}
			set
			{
				this.instance->DepthTestEnable = value;
			}
		}

		public bool DepthWriteEnable
		{
			get
			{
				return this.instance->DepthWriteEnable;
			}
			set
			{
				this.instance->DepthWriteEnable = value;
			}
		}

		public CompareOp DepthCompareOp
		{
			get
			{
				return this.instance->DepthCompareOp;
			}
			set
			{
				this.instance->DepthCompareOp = value;
			}
		}

		public bool DepthBoundsTestEnable
		{
			get
			{
				return this.instance->DepthBoundsTestEnable;
			}
			set
			{
				this.instance->DepthBoundsTestEnable = value;
			}
		}

		public bool StencilTestEnable
		{
			get
			{
				return this.instance->StencilTestEnable;
			}
			set
			{
				this.instance->StencilTestEnable = value;
			}
		}

		public StencilOpState Front
		{
			get
			{
				return this.instance->Front;
			}
			set
			{
				this.instance->Front = value;
			}
		}

		public StencilOpState Back
		{
			get
			{
				return this.instance->Back;
			}
			set
			{
				this.instance->Back = value;
			}
		}

		public float MinDepthBounds
		{
			get
			{
				return this.instance->MinDepthBounds;
			}
			set
			{
				this.instance->MinDepthBounds = value;
			}
		}

		public float MaxDepthBounds
		{
			get
			{
				return this.instance->MaxDepthBounds;
			}
			set
			{
				this.instance->MaxDepthBounds = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class GraphicsPipelineCreateInfo
		: IDisposable
	{
		internal Interop.GraphicsPipelineCreateInfo* instance;

		internal GraphicsPipelineCreateInfo(Interop.GraphicsPipelineCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.GraphicsPipelineCreateInfo.Create() : instance;
		}

		public static GraphicsPipelineCreateInfo Create()
		{
			var result = new GraphicsPipelineCreateInfo(null);

			result.instance->SType = StructureType.GraphicsPipelineCreateInfo;

			return result;
		}

		public PipelineCreateFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public uint Subpass
		{
			get
			{
				return this.instance->Subpass;
			}
			set
			{
				this.instance->Subpass = value;
			}
		}

		public int BasePipelineIndex
		{
			get
			{
				return this.instance->BasePipelineIndex;
			}
			set
			{
				this.instance->BasePipelineIndex = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineCacheCreateInfo
		: IDisposable
	{
		internal Interop.PipelineCacheCreateInfo* instance;

		internal PipelineCacheCreateInfo(Interop.PipelineCacheCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineCacheCreateInfo.Create() : instance;
		}

		public static PipelineCacheCreateInfo Create()
		{
			var result = new PipelineCacheCreateInfo(null);

			result.instance->SType = StructureType.PipelineCacheCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PipelineLayoutCreateInfo
		: IDisposable
	{
		internal Interop.PipelineLayoutCreateInfo* instance;

		internal PipelineLayoutCreateInfo(Interop.PipelineLayoutCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.PipelineLayoutCreateInfo.Create() : instance;
		}

		public static PipelineLayoutCreateInfo Create()
		{
			var result = new PipelineLayoutCreateInfo(null);

			result.instance->SType = StructureType.PipelineLayoutCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SamplerCreateInfo
		: IDisposable
	{
		internal Interop.SamplerCreateInfo* instance;

		internal SamplerCreateInfo(Interop.SamplerCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.SamplerCreateInfo.Create() : instance;
		}

		public static SamplerCreateInfo Create()
		{
			var result = new SamplerCreateInfo(null);

			result.instance->SType = StructureType.SamplerCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public Filter MagFilter
		{
			get
			{
				return this.instance->MagFilter;
			}
			set
			{
				this.instance->MagFilter = value;
			}
		}

		public Filter MinFilter
		{
			get
			{
				return this.instance->MinFilter;
			}
			set
			{
				this.instance->MinFilter = value;
			}
		}

		public SamplerMipmapMode MipmapMode
		{
			get
			{
				return this.instance->MipmapMode;
			}
			set
			{
				this.instance->MipmapMode = value;
			}
		}

		public SamplerAddressMode AddressModeU
		{
			get
			{
				return this.instance->AddressModeU;
			}
			set
			{
				this.instance->AddressModeU = value;
			}
		}

		public SamplerAddressMode AddressModeV
		{
			get
			{
				return this.instance->AddressModeV;
			}
			set
			{
				this.instance->AddressModeV = value;
			}
		}

		public SamplerAddressMode AddressModeW
		{
			get
			{
				return this.instance->AddressModeW;
			}
			set
			{
				this.instance->AddressModeW = value;
			}
		}

		public float MipLodBias
		{
			get
			{
				return this.instance->MipLodBias;
			}
			set
			{
				this.instance->MipLodBias = value;
			}
		}

		public bool AnisotropyEnable
		{
			get
			{
				return this.instance->AnisotropyEnable;
			}
			set
			{
				this.instance->AnisotropyEnable = value;
			}
		}

		public float MaxAnisotropy
		{
			get
			{
				return this.instance->MaxAnisotropy;
			}
			set
			{
				this.instance->MaxAnisotropy = value;
			}
		}

		public bool CompareEnable
		{
			get
			{
				return this.instance->CompareEnable;
			}
			set
			{
				this.instance->CompareEnable = value;
			}
		}

		public CompareOp CompareOp
		{
			get
			{
				return this.instance->CompareOp;
			}
			set
			{
				this.instance->CompareOp = value;
			}
		}

		public float MinLod
		{
			get
			{
				return this.instance->MinLod;
			}
			set
			{
				this.instance->MinLod = value;
			}
		}

		public float MaxLod
		{
			get
			{
				return this.instance->MaxLod;
			}
			set
			{
				this.instance->MaxLod = value;
			}
		}

		public BorderColor BorderColor
		{
			get
			{
				return this.instance->BorderColor;
			}
			set
			{
				this.instance->BorderColor = value;
			}
		}

		public bool UnnormalizedCoordinates
		{
			get
			{
				return this.instance->UnnormalizedCoordinates;
			}
			set
			{
				this.instance->UnnormalizedCoordinates = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class CommandPoolCreateInfo
		: IDisposable
	{
		internal Interop.CommandPoolCreateInfo* instance;

		internal CommandPoolCreateInfo(Interop.CommandPoolCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.CommandPoolCreateInfo.Create() : instance;
		}

		public static CommandPoolCreateInfo Create()
		{
			var result = new CommandPoolCreateInfo(null);

			result.instance->SType = StructureType.CommandPoolCreateInfo;

			return result;
		}

		public CommandPoolCreateFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public uint QueueFamilyIndex
		{
			get
			{
				return this.instance->QueueFamilyIndex;
			}
			set
			{
				this.instance->QueueFamilyIndex = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class CommandBufferAllocateInfo
		: IDisposable
	{
		internal Interop.CommandBufferAllocateInfo* instance;

		internal CommandBufferAllocateInfo(Interop.CommandBufferAllocateInfo* instance)
		{
			this.instance = instance == null ? Interop.CommandBufferAllocateInfo.Create() : instance;
		}

		public static CommandBufferAllocateInfo Create()
		{
			var result = new CommandBufferAllocateInfo(null);

			result.instance->SType = StructureType.CommandBufferAllocateInfo;

			return result;
		}

		public CommandBufferLevel Level
		{
			get
			{
				return this.instance->Level;
			}
			set
			{
				this.instance->Level = value;
			}
		}

		public uint CommandBufferCount
		{
			get
			{
				return this.instance->CommandBufferCount;
			}
			set
			{
				this.instance->CommandBufferCount = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class CommandBufferInheritanceInfo
		: IDisposable
	{
		internal Interop.CommandBufferInheritanceInfo* instance;

		internal CommandBufferInheritanceInfo(Interop.CommandBufferInheritanceInfo* instance)
		{
			this.instance = instance == null ? Interop.CommandBufferInheritanceInfo.Create() : instance;
		}

		public static CommandBufferInheritanceInfo Create()
		{
			var result = new CommandBufferInheritanceInfo(null);

			result.instance->SType = StructureType.CommandBufferInheritanceInfo;

			return result;
		}

		public uint Subpass
		{
			get
			{
				return this.instance->Subpass;
			}
			set
			{
				this.instance->Subpass = value;
			}
		}

		public bool OcclusionQueryEnable
		{
			get
			{
				return this.instance->OcclusionQueryEnable;
			}
			set
			{
				this.instance->OcclusionQueryEnable = value;
			}
		}

		public QueryControlFlags QueryFlags
		{
			get
			{
				return this.instance->QueryFlags;
			}
			set
			{
				this.instance->QueryFlags = value;
			}
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get
			{
				return this.instance->PipelineStatistics;
			}
			set
			{
				this.instance->PipelineStatistics = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class CommandBufferBeginInfo
		: IDisposable
	{
		internal Interop.CommandBufferBeginInfo* instance;

		internal CommandBufferBeginInfo(Interop.CommandBufferBeginInfo* instance)
		{
			this.instance = instance == null ? Interop.CommandBufferBeginInfo.Create() : instance;
		}

		public static CommandBufferBeginInfo Create()
		{
			var result = new CommandBufferBeginInfo(null);

			result.instance->SType = StructureType.CommandBufferBeginInfo;

			return result;
		}

		public CommandBufferUsageFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class RenderPassBeginInfo
		: IDisposable
	{
		internal Interop.RenderPassBeginInfo* instance;

		internal RenderPassBeginInfo(Interop.RenderPassBeginInfo* instance)
		{
			this.instance = instance == null ? Interop.RenderPassBeginInfo.Create() : instance;
		}

		public static RenderPassBeginInfo Create()
		{
			var result = new RenderPassBeginInfo(null);

			result.instance->SType = StructureType.RenderPassBeginInfo;

			return result;
		}

		public Rect2D RenderArea
		{
			get
			{
				return this.instance->RenderArea;
			}
			set
			{
				this.instance->RenderArea = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SubpassDescription
		: IDisposable
	{
		internal Interop.SubpassDescription* instance;

		internal SubpassDescription(Interop.SubpassDescription* instance)
		{
			this.instance = instance == null ? Interop.SubpassDescription.Create() : instance;
		}

		public static SubpassDescription Create()
		{
			var result = new SubpassDescription(null);

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public PipelineBindPoint PipelineBindPoint
		{
			get
			{
				return this.instance->PipelineBindPoint;
			}
			set
			{
				this.instance->PipelineBindPoint = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class RenderPassCreateInfo
		: IDisposable
	{
		internal Interop.RenderPassCreateInfo* instance;

		internal RenderPassCreateInfo(Interop.RenderPassCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.RenderPassCreateInfo.Create() : instance;
		}

		public static RenderPassCreateInfo Create()
		{
			var result = new RenderPassCreateInfo(null);

			result.instance->SType = StructureType.RenderPassCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class EventCreateInfo
		: IDisposable
	{
		internal Interop.EventCreateInfo* instance;

		internal EventCreateInfo(Interop.EventCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.EventCreateInfo.Create() : instance;
		}

		public static EventCreateInfo Create()
		{
			var result = new EventCreateInfo(null);

			result.instance->SType = StructureType.EventCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class FenceCreateInfo
		: IDisposable
	{
		internal Interop.FenceCreateInfo* instance;

		internal FenceCreateInfo(Interop.FenceCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.FenceCreateInfo.Create() : instance;
		}

		public static FenceCreateInfo Create()
		{
			var result = new FenceCreateInfo(null);

			result.instance->SType = StructureType.FenceCreateInfo;

			return result;
		}

		public FenceCreateFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PhysicalDeviceLimits
		: IDisposable
	{
		internal Interop.PhysicalDeviceLimits* instance;

		internal PhysicalDeviceLimits(Interop.PhysicalDeviceLimits* instance)
		{
			this.instance = instance == null ? Interop.PhysicalDeviceLimits.Create() : instance;
		}

		public static PhysicalDeviceLimits Create()
		{
			var result = new PhysicalDeviceLimits(null);

			return result;
		}

		public uint MaxImageDimension1D
		{
			get
			{
				return this.instance->MaxImageDimension1D;
			}
		}

		public uint MaxImageDimension2D
		{
			get
			{
				return this.instance->MaxImageDimension2D;
			}
		}

		public uint MaxImageDimension3D
		{
			get
			{
				return this.instance->MaxImageDimension3D;
			}
		}

		public uint MaxImageDimensionCube
		{
			get
			{
				return this.instance->MaxImageDimensionCube;
			}
		}

		public uint MaxImageArrayLayers
		{
			get
			{
				return this.instance->MaxImageArrayLayers;
			}
		}

		public uint MaxTexelBufferElements
		{
			get
			{
				return this.instance->MaxTexelBufferElements;
			}
		}

		public uint MaxUniformBufferRange
		{
			get
			{
				return this.instance->MaxUniformBufferRange;
			}
		}

		public uint MaxStorageBufferRange
		{
			get
			{
				return this.instance->MaxStorageBufferRange;
			}
		}

		public uint MaxPushConstantsSize
		{
			get
			{
				return this.instance->MaxPushConstantsSize;
			}
		}

		public uint MaxMemoryAllocationCount
		{
			get
			{
				return this.instance->MaxMemoryAllocationCount;
			}
		}

		public uint MaxSamplerAllocationCount
		{
			get
			{
				return this.instance->MaxSamplerAllocationCount;
			}
		}

		public ulong BufferImageGranularity
		{
			get
			{
				return this.instance->BufferImageGranularity;
			}
		}

		public ulong SparseAddressSpaceSize
		{
			get
			{
				return this.instance->SparseAddressSpaceSize;
			}
		}

		public uint MaxBoundDescriptorSets
		{
			get
			{
				return this.instance->MaxBoundDescriptorSets;
			}
		}

		public uint MaxPerStageDescriptorSamplers
		{
			get
			{
				return this.instance->MaxPerStageDescriptorSamplers;
			}
		}

		public uint MaxPerStageDescriptorUniformBuffers
		{
			get
			{
				return this.instance->MaxPerStageDescriptorUniformBuffers;
			}
		}

		public uint MaxPerStageDescriptorStorageBuffers
		{
			get
			{
				return this.instance->MaxPerStageDescriptorStorageBuffers;
			}
		}

		public uint MaxPerStageDescriptorSampledImages
		{
			get
			{
				return this.instance->MaxPerStageDescriptorSampledImages;
			}
		}

		public uint MaxPerStageDescriptorStorageImages
		{
			get
			{
				return this.instance->MaxPerStageDescriptorStorageImages;
			}
		}

		public uint MaxPerStageDescriptorInputAttachments
		{
			get
			{
				return this.instance->MaxPerStageDescriptorInputAttachments;
			}
		}

		public uint MaxPerStageResources
		{
			get
			{
				return this.instance->MaxPerStageResources;
			}
		}

		public uint MaxDescriptorSetSamplers
		{
			get
			{
				return this.instance->MaxDescriptorSetSamplers;
			}
		}

		public uint MaxDescriptorSetUniformBuffers
		{
			get
			{
				return this.instance->MaxDescriptorSetUniformBuffers;
			}
		}

		public uint MaxDescriptorSetUniformBuffersDynamic
		{
			get
			{
				return this.instance->MaxDescriptorSetUniformBuffersDynamic;
			}
		}

		public uint MaxDescriptorSetStorageBuffers
		{
			get
			{
				return this.instance->MaxDescriptorSetStorageBuffers;
			}
		}

		public uint MaxDescriptorSetStorageBuffersDynamic
		{
			get
			{
				return this.instance->MaxDescriptorSetStorageBuffersDynamic;
			}
		}

		public uint MaxDescriptorSetSampledImages
		{
			get
			{
				return this.instance->MaxDescriptorSetSampledImages;
			}
		}

		public uint MaxDescriptorSetStorageImages
		{
			get
			{
				return this.instance->MaxDescriptorSetStorageImages;
			}
		}

		public uint MaxDescriptorSetInputAttachments
		{
			get
			{
				return this.instance->MaxDescriptorSetInputAttachments;
			}
		}

		public uint MaxVertexInputAttributes
		{
			get
			{
				return this.instance->MaxVertexInputAttributes;
			}
		}

		public uint MaxVertexInputBindings
		{
			get
			{
				return this.instance->MaxVertexInputBindings;
			}
		}

		public uint MaxVertexInputAttributeOffset
		{
			get
			{
				return this.instance->MaxVertexInputAttributeOffset;
			}
		}

		public uint MaxVertexInputBindingStride
		{
			get
			{
				return this.instance->MaxVertexInputBindingStride;
			}
		}

		public uint MaxVertexOutputComponents
		{
			get
			{
				return this.instance->MaxVertexOutputComponents;
			}
		}

		public uint MaxTessellationGenerationLevel
		{
			get
			{
				return this.instance->MaxTessellationGenerationLevel;
			}
		}

		public uint MaxTessellationPatchSize
		{
			get
			{
				return this.instance->MaxTessellationPatchSize;
			}
		}

		public uint MaxTessellationControlPerVertexInputComponents
		{
			get
			{
				return this.instance->MaxTessellationControlPerVertexInputComponents;
			}
		}

		public uint MaxTessellationControlPerVertexOutputComponents
		{
			get
			{
				return this.instance->MaxTessellationControlPerVertexOutputComponents;
			}
		}

		public uint MaxTessellationControlPerPatchOutputComponents
		{
			get
			{
				return this.instance->MaxTessellationControlPerPatchOutputComponents;
			}
		}

		public uint MaxTessellationControlTotalOutputComponents
		{
			get
			{
				return this.instance->MaxTessellationControlTotalOutputComponents;
			}
		}

		public uint MaxTessellationEvaluationInputComponents
		{
			get
			{
				return this.instance->MaxTessellationEvaluationInputComponents;
			}
		}

		public uint MaxTessellationEvaluationOutputComponents
		{
			get
			{
				return this.instance->MaxTessellationEvaluationOutputComponents;
			}
		}

		public uint MaxGeometryShaderInvocations
		{
			get
			{
				return this.instance->MaxGeometryShaderInvocations;
			}
		}

		public uint MaxGeometryInputComponents
		{
			get
			{
				return this.instance->MaxGeometryInputComponents;
			}
		}

		public uint MaxGeometryOutputComponents
		{
			get
			{
				return this.instance->MaxGeometryOutputComponents;
			}
		}

		public uint MaxGeometryOutputVertices
		{
			get
			{
				return this.instance->MaxGeometryOutputVertices;
			}
		}

		public uint MaxGeometryTotalOutputComponents
		{
			get
			{
				return this.instance->MaxGeometryTotalOutputComponents;
			}
		}

		public uint MaxFragmentInputComponents
		{
			get
			{
				return this.instance->MaxFragmentInputComponents;
			}
		}

		public uint MaxFragmentOutputAttachments
		{
			get
			{
				return this.instance->MaxFragmentOutputAttachments;
			}
		}

		public uint MaxFragmentDualSrcAttachments
		{
			get
			{
				return this.instance->MaxFragmentDualSrcAttachments;
			}
		}

		public uint MaxFragmentCombinedOutputResources
		{
			get
			{
				return this.instance->MaxFragmentCombinedOutputResources;
			}
		}

		public uint MaxComputeSharedMemorySize
		{
			get
			{
				return this.instance->MaxComputeSharedMemorySize;
			}
		}

		public uint[] MaxComputeWorkGroupCount
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->MaxComputeWorkGroupCount, 3);
			}
		}

		public uint MaxComputeWorkGroupInvocations
		{
			get
			{
				return this.instance->MaxComputeWorkGroupInvocations;
			}
		}

		public uint[] MaxComputeWorkGroupSize
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->MaxComputeWorkGroupSize, 3);
			}
		}

		public uint SubPixelPrecisionBits
		{
			get
			{
				return this.instance->SubPixelPrecisionBits;
			}
		}

		public uint SubTexelPrecisionBits
		{
			get
			{
				return this.instance->SubTexelPrecisionBits;
			}
		}

		public uint MipmapPrecisionBits
		{
			get
			{
				return this.instance->MipmapPrecisionBits;
			}
		}

		public uint MaxDrawIndexedIndexValue
		{
			get
			{
				return this.instance->MaxDrawIndexedIndexValue;
			}
		}

		public uint MaxDrawIndirectCount
		{
			get
			{
				return this.instance->MaxDrawIndirectCount;
			}
		}

		public float MaxSamplerLodBias
		{
			get
			{
				return this.instance->MaxSamplerLodBias;
			}
		}

		public float MaxSamplerAnisotropy
		{
			get
			{
				return this.instance->MaxSamplerAnisotropy;
			}
		}

		public uint MaxViewports
		{
			get
			{
				return this.instance->MaxViewports;
			}
		}

		public uint[] MaxViewportDimensions
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->MaxViewportDimensions, 2);
			}
		}

		public float[] ViewportBoundsRange
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->ViewportBoundsRange, 2);
			}
		}

		public uint ViewportSubPixelBits
		{
			get
			{
				return this.instance->ViewportSubPixelBits;
			}
		}

		public UIntPtr MinMemoryMapAlignment
		{
			get
			{
				return this.instance->MinMemoryMapAlignment;
			}
		}

		public ulong MinTexelBufferOffsetAlignment
		{
			get
			{
				return this.instance->MinTexelBufferOffsetAlignment;
			}
		}

		public ulong MinUniformBufferOffsetAlignment
		{
			get
			{
				return this.instance->MinUniformBufferOffsetAlignment;
			}
		}

		public ulong MinStorageBufferOffsetAlignment
		{
			get
			{
				return this.instance->MinStorageBufferOffsetAlignment;
			}
		}

		public int MinTexelOffset
		{
			get
			{
				return this.instance->MinTexelOffset;
			}
		}

		public uint MaxTexelOffset
		{
			get
			{
				return this.instance->MaxTexelOffset;
			}
		}

		public int MinTexelGatherOffset
		{
			get
			{
				return this.instance->MinTexelGatherOffset;
			}
		}

		public uint MaxTexelGatherOffset
		{
			get
			{
				return this.instance->MaxTexelGatherOffset;
			}
		}

		public float MinInterpolationOffset
		{
			get
			{
				return this.instance->MinInterpolationOffset;
			}
		}

		public float MaxInterpolationOffset
		{
			get
			{
				return this.instance->MaxInterpolationOffset;
			}
		}

		public uint SubPixelInterpolationOffsetBits
		{
			get
			{
				return this.instance->SubPixelInterpolationOffsetBits;
			}
		}

		public uint MaxFramebufferWidth
		{
			get
			{
				return this.instance->MaxFramebufferWidth;
			}
		}

		public uint MaxFramebufferHeight
		{
			get
			{
				return this.instance->MaxFramebufferHeight;
			}
		}

		public uint MaxFramebufferLayers
		{
			get
			{
				return this.instance->MaxFramebufferLayers;
			}
		}

		public SampleCountFlags FramebufferColorSampleCounts
		{
			get
			{
				return this.instance->FramebufferColorSampleCounts;
			}
		}

		public SampleCountFlags FramebufferDepthSampleCounts
		{
			get
			{
				return this.instance->FramebufferDepthSampleCounts;
			}
		}

		public SampleCountFlags FramebufferStencilSampleCounts
		{
			get
			{
				return this.instance->FramebufferStencilSampleCounts;
			}
		}

		public SampleCountFlags FramebufferNoAttachmentsSampleCounts
		{
			get
			{
				return this.instance->FramebufferNoAttachmentsSampleCounts;
			}
		}

		public uint MaxColorAttachments
		{
			get
			{
				return this.instance->MaxColorAttachments;
			}
		}

		public SampleCountFlags SampledImageColorSampleCounts
		{
			get
			{
				return this.instance->SampledImageColorSampleCounts;
			}
		}

		public SampleCountFlags SampledImageIntegerSampleCounts
		{
			get
			{
				return this.instance->SampledImageIntegerSampleCounts;
			}
		}

		public SampleCountFlags SampledImageDepthSampleCounts
		{
			get
			{
				return this.instance->SampledImageDepthSampleCounts;
			}
		}

		public SampleCountFlags SampledImageStencilSampleCounts
		{
			get
			{
				return this.instance->SampledImageStencilSampleCounts;
			}
		}

		public SampleCountFlags StorageImageSampleCounts
		{
			get
			{
				return this.instance->StorageImageSampleCounts;
			}
		}

		public uint MaxSampleMaskWords
		{
			get
			{
				return this.instance->MaxSampleMaskWords;
			}
		}

		public bool TimestampComputeAndGraphics
		{
			get
			{
				return this.instance->TimestampComputeAndGraphics;
			}
		}

		public float TimestampPeriod
		{
			get
			{
				return this.instance->TimestampPeriod;
			}
		}

		public uint MaxClipDistances
		{
			get
			{
				return this.instance->MaxClipDistances;
			}
		}

		public uint MaxCullDistances
		{
			get
			{
				return this.instance->MaxCullDistances;
			}
		}

		public uint MaxCombinedClipAndCullDistances
		{
			get
			{
				return this.instance->MaxCombinedClipAndCullDistances;
			}
		}

		public uint DiscreteQueuePriorities
		{
			get
			{
				return this.instance->DiscreteQueuePriorities;
			}
		}

		public float[] PointSizeRange
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->PointSizeRange, 2);
			}
		}

		public float[] LineWidthRange
		{
			get
			{
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->LineWidthRange, 2);
			}
		}

		public float PointSizeGranularity
		{
			get
			{
				return this.instance->PointSizeGranularity;
			}
		}

		public float LineWidthGranularity
		{
			get
			{
				return this.instance->LineWidthGranularity;
			}
		}

		public bool StrictLines
		{
			get
			{
				return this.instance->StrictLines;
			}
		}

		public bool StandardSampleLocations
		{
			get
			{
				return this.instance->StandardSampleLocations;
			}
		}

		public ulong OptimalBufferCopyOffsetAlignment
		{
			get
			{
				return this.instance->OptimalBufferCopyOffsetAlignment;
			}
		}

		public ulong OptimalBufferCopyRowPitchAlignment
		{
			get
			{
				return this.instance->OptimalBufferCopyRowPitchAlignment;
			}
		}

		public ulong NonCoherentAtomSize
		{
			get
			{
				return this.instance->NonCoherentAtomSize;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SemaphoreCreateInfo
		: IDisposable
	{
		internal Interop.SemaphoreCreateInfo* instance;

		internal SemaphoreCreateInfo(Interop.SemaphoreCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.SemaphoreCreateInfo.Create() : instance;
		}

		public static SemaphoreCreateInfo Create()
		{
			var result = new SemaphoreCreateInfo(null);

			result.instance->SType = StructureType.SemaphoreCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class QueryPoolCreateInfo
		: IDisposable
	{
		internal Interop.QueryPoolCreateInfo* instance;

		internal QueryPoolCreateInfo(Interop.QueryPoolCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.QueryPoolCreateInfo.Create() : instance;
		}

		public static QueryPoolCreateInfo Create()
		{
			var result = new QueryPoolCreateInfo(null);

			result.instance->SType = StructureType.QueryPoolCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public QueryType QueryType
		{
			get
			{
				return this.instance->QueryType;
			}
			set
			{
				this.instance->QueryType = value;
			}
		}

		public uint QueryCount
		{
			get
			{
				return this.instance->QueryCount;
			}
			set
			{
				this.instance->QueryCount = value;
			}
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get
			{
				return this.instance->PipelineStatistics;
			}
			set
			{
				this.instance->PipelineStatistics = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class FramebufferCreateInfo
		: IDisposable
	{
		internal Interop.FramebufferCreateInfo* instance;

		internal FramebufferCreateInfo(Interop.FramebufferCreateInfo* instance)
		{
			this.instance = instance == null ? Interop.FramebufferCreateInfo.Create() : instance;
		}

		public static FramebufferCreateInfo Create()
		{
			var result = new FramebufferCreateInfo(null);

			result.instance->SType = StructureType.FramebufferCreateInfo;

			return result;
		}

		public uint Flags
		{
			get
			{
				return this.instance->Flags;
			}
			set
			{
				this.instance->Flags = value;
			}
		}

		public uint Width
		{
			get
			{
				return this.instance->Width;
			}
			set
			{
				this.instance->Width = value;
			}
		}

		public uint Height
		{
			get
			{
				return this.instance->Height;
			}
			set
			{
				this.instance->Height = value;
			}
		}

		public uint Layers
		{
			get
			{
				return this.instance->Layers;
			}
			set
			{
				this.instance->Layers = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SubmitInfo
		: IDisposable
	{
		internal Interop.SubmitInfo* instance;

		internal SubmitInfo(Interop.SubmitInfo* instance)
		{
			this.instance = instance == null ? Interop.SubmitInfo.Create() : instance;
		}

		public static SubmitInfo Create()
		{
			var result = new SubmitInfo(null);

			result.instance->SType = StructureType.SubmitInfo;

			return result;
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}
}
