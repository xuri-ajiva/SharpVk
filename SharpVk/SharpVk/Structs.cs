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

	public unsafe class Offset2D
		: IDisposable
	{
		internal Interop.Offset2D* instance;

		internal Offset2D(Interop.Offset2D* instance)
		{
			this.instance = instance == null ? Interop.Offset2D.Create() : instance;
		}

		public static Offset2D Create()
		{
			var result = new Offset2D(null);

			return result;
		}

		public int X
		{
			get
			{
				return this.instance->X;
			}
			set
			{
				this.instance->X = value;
			}
		}

		public int Y
		{
			get
			{
				return this.instance->Y;
			}
			set
			{
				this.instance->Y = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class Offset3D
		: IDisposable
	{
		internal Interop.Offset3D* instance;

		internal Offset3D(Interop.Offset3D* instance)
		{
			this.instance = instance == null ? Interop.Offset3D.Create() : instance;
		}

		public static Offset3D Create()
		{
			var result = new Offset3D(null);

			return result;
		}

		public int X
		{
			get
			{
				return this.instance->X;
			}
			set
			{
				this.instance->X = value;
			}
		}

		public int Y
		{
			get
			{
				return this.instance->Y;
			}
			set
			{
				this.instance->Y = value;
			}
		}

		public int Z
		{
			get
			{
				return this.instance->Z;
			}
			set
			{
				this.instance->Z = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class Extent2D
		: IDisposable
	{
		internal Interop.Extent2D* instance;

		internal Extent2D(Interop.Extent2D* instance)
		{
			this.instance = instance == null ? Interop.Extent2D.Create() : instance;
		}

		public static Extent2D Create()
		{
			var result = new Extent2D(null);

			return result;
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

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class Extent3D
		: IDisposable
	{
		internal Interop.Extent3D* instance;

		internal Extent3D(Interop.Extent3D* instance)
		{
			this.instance = instance == null ? Interop.Extent3D.Create() : instance;
		}

		public static Extent3D Create()
		{
			var result = new Extent3D(null);

			return result;
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

		public uint Depth
		{
			get
			{
				return this.instance->Depth;
			}
			set
			{
				this.instance->Depth = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class Viewport
		: IDisposable
	{
		internal Interop.Viewport* instance;

		internal Viewport(Interop.Viewport* instance)
		{
			this.instance = instance == null ? Interop.Viewport.Create() : instance;
		}

		public static Viewport Create()
		{
			var result = new Viewport(null);

			return result;
		}

		public float X
		{
			get
			{
				return this.instance->X;
			}
			set
			{
				this.instance->X = value;
			}
		}

		public float Y
		{
			get
			{
				return this.instance->Y;
			}
			set
			{
				this.instance->Y = value;
			}
		}

		public float Width
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

		public float Height
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

		public float MinDepth
		{
			get
			{
				return this.instance->MinDepth;
			}
			set
			{
				this.instance->MinDepth = value;
			}
		}

		public float MaxDepth
		{
			get
			{
				return this.instance->MaxDepth;
			}
			set
			{
				this.instance->MaxDepth = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class Rect2D
		: IDisposable
	{
		internal Interop.Rect2D* instance;

		internal Rect2D(Interop.Rect2D* instance)
		{
			this.instance = instance == null ? Interop.Rect2D.Create() : instance;
		}

		public static Rect2D Create()
		{
			var result = new Rect2D(null);

			return result;
		}

		public Offset2D Offset
		{
			get
			{
				return new Offset2D(&(this.instance->Offset));
			}
			set
			{
				this.instance->Offset = *(value.instance);
			}
		}

		public Extent2D Extent
		{
			get
			{
				return new Extent2D(&(this.instance->Extent));
			}
			set
			{
				this.instance->Extent = *(value.instance);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class Rect3D
		: IDisposable
	{
		internal Interop.Rect3D* instance;

		internal Rect3D(Interop.Rect3D* instance)
		{
			this.instance = instance == null ? Interop.Rect3D.Create() : instance;
		}

		public static Rect3D Create()
		{
			var result = new Rect3D(null);

			return result;
		}

		public Offset3D Offset
		{
			get
			{
				return new Offset3D(&(this.instance->Offset));
			}
			set
			{
				this.instance->Offset = *(value.instance);
			}
		}

		public Extent3D Extent
		{
			get
			{
				return new Extent3D(&(this.instance->Extent));
			}
			set
			{
				this.instance->Extent = *(value.instance);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ClearRect
		: IDisposable
	{
		internal Interop.ClearRect* instance;

		internal ClearRect(Interop.ClearRect* instance)
		{
			this.instance = instance == null ? Interop.ClearRect.Create() : instance;
		}

		public static ClearRect Create()
		{
			var result = new ClearRect(null);

			return result;
		}

		public Rect2D Rect
		{
			get
			{
				return new Rect2D(&(this.instance->Rect));
			}
			set
			{
				this.instance->Rect = *(value.instance);
			}
		}

		public uint BaseArrayLayer
		{
			get
			{
				return this.instance->BaseArrayLayer;
			}
			set
			{
				this.instance->BaseArrayLayer = value;
			}
		}

		public uint LayerCount
		{
			get
			{
				return this.instance->LayerCount;
			}
			set
			{
				this.instance->LayerCount = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ComponentMapping
		: IDisposable
	{
		internal Interop.ComponentMapping* instance;

		internal ComponentMapping(Interop.ComponentMapping* instance)
		{
			this.instance = instance == null ? Interop.ComponentMapping.Create() : instance;
		}

		public static ComponentMapping Create()
		{
			var result = new ComponentMapping(null);

			return result;
		}

		public ComponentSwizzle R
		{
			get
			{
				return this.instance->R;
			}
			set
			{
				this.instance->R = value;
			}
		}

		public ComponentSwizzle G
		{
			get
			{
				return this.instance->G;
			}
			set
			{
				this.instance->G = value;
			}
		}

		public ComponentSwizzle B
		{
			get
			{
				return this.instance->B;
			}
			set
			{
				this.instance->B = value;
			}
		}

		public ComponentSwizzle A
		{
			get
			{
				return this.instance->A;
			}
			set
			{
				this.instance->A = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

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
				return Interop.HeapUtil.MarshalPointerToArray(this.instance->PipelineCacheUUID, 32);
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
				return new PhysicalDeviceSparseProperties(&(this.instance->SparseProperties));
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

	public unsafe class QueueFamilyProperties
		: IDisposable
	{
		internal Interop.QueueFamilyProperties* instance;

		internal QueueFamilyProperties(Interop.QueueFamilyProperties* instance)
		{
			this.instance = instance == null ? Interop.QueueFamilyProperties.Create() : instance;
		}

		public static QueueFamilyProperties Create()
		{
			var result = new QueueFamilyProperties(null);

			return result;
		}

		public QueueFlags QueueFlags
		{
			get
			{
				return this.instance->QueueFlags;
			}
		}

		public uint QueueCount
		{
			get
			{
				return this.instance->QueueCount;
			}
		}

		public uint TimestampValidBits
		{
			get
			{
				return this.instance->TimestampValidBits;
			}
		}

		public Extent3D MinImageTransferGranularity
		{
			get
			{
				return new Extent3D(&(this.instance->MinImageTransferGranularity));
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
				return new MemoryType(&(this.instance->MemoryTypes_0));
			}
		}

		public MemoryType MemoryTypes_1
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_1));
			}
		}

		public MemoryType MemoryTypes_2
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_2));
			}
		}

		public MemoryType MemoryTypes_3
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_3));
			}
		}

		public MemoryType MemoryTypes_4
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_4));
			}
		}

		public MemoryType MemoryTypes_5
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_5));
			}
		}

		public MemoryType MemoryTypes_6
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_6));
			}
		}

		public MemoryType MemoryTypes_7
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_7));
			}
		}

		public MemoryType MemoryTypes_8
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_8));
			}
		}

		public MemoryType MemoryTypes_9
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_9));
			}
		}

		public MemoryType MemoryTypes_10
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_10));
			}
		}

		public MemoryType MemoryTypes_11
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_11));
			}
		}

		public MemoryType MemoryTypes_12
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_12));
			}
		}

		public MemoryType MemoryTypes_13
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_13));
			}
		}

		public MemoryType MemoryTypes_14
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_14));
			}
		}

		public MemoryType MemoryTypes_15
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_15));
			}
		}

		public MemoryType MemoryTypes_16
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_16));
			}
		}

		public MemoryType MemoryTypes_17
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_17));
			}
		}

		public MemoryType MemoryTypes_18
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_18));
			}
		}

		public MemoryType MemoryTypes_19
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_19));
			}
		}

		public MemoryType MemoryTypes_20
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_20));
			}
		}

		public MemoryType MemoryTypes_21
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_21));
			}
		}

		public MemoryType MemoryTypes_22
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_22));
			}
		}

		public MemoryType MemoryTypes_23
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_23));
			}
		}

		public MemoryType MemoryTypes_24
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_24));
			}
		}

		public MemoryType MemoryTypes_25
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_25));
			}
		}

		public MemoryType MemoryTypes_26
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_26));
			}
		}

		public MemoryType MemoryTypes_27
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_27));
			}
		}

		public MemoryType MemoryTypes_28
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_28));
			}
		}

		public MemoryType MemoryTypes_29
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_29));
			}
		}

		public MemoryType MemoryTypes_30
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_30));
			}
		}

		public MemoryType MemoryTypes_31
		{
			get
			{
				return new MemoryType(&(this.instance->MemoryTypes_31));
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
				return new MemoryHeap(&(this.instance->MemoryHeaps_0));
			}
		}

		public MemoryHeap MemoryHeaps_1
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_1));
			}
		}

		public MemoryHeap MemoryHeaps_2
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_2));
			}
		}

		public MemoryHeap MemoryHeaps_3
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_3));
			}
		}

		public MemoryHeap MemoryHeaps_4
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_4));
			}
		}

		public MemoryHeap MemoryHeaps_5
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_5));
			}
		}

		public MemoryHeap MemoryHeaps_6
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_6));
			}
		}

		public MemoryHeap MemoryHeaps_7
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_7));
			}
		}

		public MemoryHeap MemoryHeaps_8
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_8));
			}
		}

		public MemoryHeap MemoryHeaps_9
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_9));
			}
		}

		public MemoryHeap MemoryHeaps_10
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_10));
			}
		}

		public MemoryHeap MemoryHeaps_11
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_11));
			}
		}

		public MemoryHeap MemoryHeaps_12
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_12));
			}
		}

		public MemoryHeap MemoryHeaps_13
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_13));
			}
		}

		public MemoryHeap MemoryHeaps_14
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_14));
			}
		}

		public MemoryHeap MemoryHeaps_15
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_15));
			}
		}

		public MemoryHeap MemoryHeaps_16
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_16));
			}
		}

		public MemoryHeap MemoryHeaps_17
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_17));
			}
		}

		public MemoryHeap MemoryHeaps_18
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_18));
			}
		}

		public MemoryHeap MemoryHeaps_19
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_19));
			}
		}

		public MemoryHeap MemoryHeaps_20
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_20));
			}
		}

		public MemoryHeap MemoryHeaps_21
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_21));
			}
		}

		public MemoryHeap MemoryHeaps_22
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_22));
			}
		}

		public MemoryHeap MemoryHeaps_23
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_23));
			}
		}

		public MemoryHeap MemoryHeaps_24
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_24));
			}
		}

		public MemoryHeap MemoryHeaps_25
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_25));
			}
		}

		public MemoryHeap MemoryHeaps_26
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_26));
			}
		}

		public MemoryHeap MemoryHeaps_27
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_27));
			}
		}

		public MemoryHeap MemoryHeaps_28
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_28));
			}
		}

		public MemoryHeap MemoryHeaps_29
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_29));
			}
		}

		public MemoryHeap MemoryHeaps_30
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_30));
			}
		}

		public MemoryHeap MemoryHeaps_31
		{
			get
			{
				return new MemoryHeap(&(this.instance->MemoryHeaps_31));
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

	public unsafe class MemoryRequirements
		: IDisposable
	{
		internal Interop.MemoryRequirements* instance;

		internal MemoryRequirements(Interop.MemoryRequirements* instance)
		{
			this.instance = instance == null ? Interop.MemoryRequirements.Create() : instance;
		}

		public static MemoryRequirements Create()
		{
			var result = new MemoryRequirements(null);

			return result;
		}

		public ulong Size
		{
			get
			{
				return this.instance->Size;
			}
		}

		public ulong Alignment
		{
			get
			{
				return this.instance->Alignment;
			}
		}

		public uint MemoryTypeBits
		{
			get
			{
				return this.instance->MemoryTypeBits;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SparseImageFormatProperties
		: IDisposable
	{
		internal Interop.SparseImageFormatProperties* instance;

		internal SparseImageFormatProperties(Interop.SparseImageFormatProperties* instance)
		{
			this.instance = instance == null ? Interop.SparseImageFormatProperties.Create() : instance;
		}

		public static SparseImageFormatProperties Create()
		{
			var result = new SparseImageFormatProperties(null);

			return result;
		}

		public ImageAspectFlags AspectMask
		{
			get
			{
				return this.instance->AspectMask;
			}
		}

		public Extent3D ImageGranularity
		{
			get
			{
				return new Extent3D(&(this.instance->ImageGranularity));
			}
		}

		public SparseImageFormatFlags Flags
		{
			get
			{
				return this.instance->Flags;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class SparseImageMemoryRequirements
		: IDisposable
	{
		internal Interop.SparseImageMemoryRequirements* instance;

		internal SparseImageMemoryRequirements(Interop.SparseImageMemoryRequirements* instance)
		{
			this.instance = instance == null ? Interop.SparseImageMemoryRequirements.Create() : instance;
		}

		public static SparseImageMemoryRequirements Create()
		{
			var result = new SparseImageMemoryRequirements(null);

			return result;
		}

		public SparseImageFormatProperties FormatProperties
		{
			get
			{
				return new SparseImageFormatProperties(&(this.instance->FormatProperties));
			}
		}

		public uint ImageMipTailFirstLod
		{
			get
			{
				return this.instance->ImageMipTailFirstLod;
			}
		}

		public ulong ImageMipTailSize
		{
			get
			{
				return this.instance->ImageMipTailSize;
			}
		}

		public ulong ImageMipTailOffset
		{
			get
			{
				return this.instance->ImageMipTailOffset;
			}
		}

		public ulong ImageMipTailStride
		{
			get
			{
				return this.instance->ImageMipTailStride;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class MemoryType
		: IDisposable
	{
		internal Interop.MemoryType* instance;

		internal MemoryType(Interop.MemoryType* instance)
		{
			this.instance = instance == null ? Interop.MemoryType.Create() : instance;
		}

		public static MemoryType Create()
		{
			var result = new MemoryType(null);

			return result;
		}

		public MemoryPropertyFlags PropertyFlags
		{
			get
			{
				return this.instance->PropertyFlags;
			}
		}

		public uint HeapIndex
		{
			get
			{
				return this.instance->HeapIndex;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class MemoryHeap
		: IDisposable
	{
		internal Interop.MemoryHeap* instance;

		internal MemoryHeap(Interop.MemoryHeap* instance)
		{
			this.instance = instance == null ? Interop.MemoryHeap.Create() : instance;
		}

		public static MemoryHeap Create()
		{
			var result = new MemoryHeap(null);

			return result;
		}

		public ulong Size
		{
			get
			{
				return this.instance->Size;
			}
		}

		public MemoryHeapFlags Flags
		{
			get
			{
				return this.instance->Flags;
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

	public unsafe class FormatProperties
		: IDisposable
	{
		internal Interop.FormatProperties* instance;

		internal FormatProperties(Interop.FormatProperties* instance)
		{
			this.instance = instance == null ? Interop.FormatProperties.Create() : instance;
		}

		public static FormatProperties Create()
		{
			var result = new FormatProperties(null);

			return result;
		}

		public FormatFeatureFlags LinearTilingFeatures
		{
			get
			{
				return this.instance->LinearTilingFeatures;
			}
		}

		public FormatFeatureFlags OptimalTilingFeatures
		{
			get
			{
				return this.instance->OptimalTilingFeatures;
			}
		}

		public FormatFeatureFlags BufferFeatures
		{
			get
			{
				return this.instance->BufferFeatures;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageFormatProperties
		: IDisposable
	{
		internal Interop.ImageFormatProperties* instance;

		internal ImageFormatProperties(Interop.ImageFormatProperties* instance)
		{
			this.instance = instance == null ? Interop.ImageFormatProperties.Create() : instance;
		}

		public static ImageFormatProperties Create()
		{
			var result = new ImageFormatProperties(null);

			return result;
		}

		public Extent3D MaxExtent
		{
			get
			{
				return new Extent3D(&(this.instance->MaxExtent));
			}
		}

		public uint MaxMipLevels
		{
			get
			{
				return this.instance->MaxMipLevels;
			}
		}

		public uint MaxArrayLayers
		{
			get
			{
				return this.instance->MaxArrayLayers;
			}
		}

		public SampleCountFlags SampleCounts
		{
			get
			{
				return this.instance->SampleCounts;
			}
		}

		public ulong MaxResourceSize
		{
			get
			{
				return this.instance->MaxResourceSize;
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

	public unsafe class ImageSubresource
		: IDisposable
	{
		internal Interop.ImageSubresource* instance;

		internal ImageSubresource(Interop.ImageSubresource* instance)
		{
			this.instance = instance == null ? Interop.ImageSubresource.Create() : instance;
		}

		public static ImageSubresource Create()
		{
			var result = new ImageSubresource(null);

			return result;
		}

		public ImageAspectFlags AspectMask
		{
			get
			{
				return this.instance->AspectMask;
			}
			set
			{
				this.instance->AspectMask = value;
			}
		}

		public uint MipLevel
		{
			get
			{
				return this.instance->MipLevel;
			}
			set
			{
				this.instance->MipLevel = value;
			}
		}

		public uint ArrayLayer
		{
			get
			{
				return this.instance->ArrayLayer;
			}
			set
			{
				this.instance->ArrayLayer = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageSubresourceLayers
		: IDisposable
	{
		internal Interop.ImageSubresourceLayers* instance;

		internal ImageSubresourceLayers(Interop.ImageSubresourceLayers* instance)
		{
			this.instance = instance == null ? Interop.ImageSubresourceLayers.Create() : instance;
		}

		public static ImageSubresourceLayers Create()
		{
			var result = new ImageSubresourceLayers(null);

			return result;
		}

		public ImageAspectFlags AspectMask
		{
			get
			{
				return this.instance->AspectMask;
			}
			set
			{
				this.instance->AspectMask = value;
			}
		}

		public uint MipLevel
		{
			get
			{
				return this.instance->MipLevel;
			}
			set
			{
				this.instance->MipLevel = value;
			}
		}

		public uint BaseArrayLayer
		{
			get
			{
				return this.instance->BaseArrayLayer;
			}
			set
			{
				this.instance->BaseArrayLayer = value;
			}
		}

		public uint LayerCount
		{
			get
			{
				return this.instance->LayerCount;
			}
			set
			{
				this.instance->LayerCount = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageSubresourceRange
		: IDisposable
	{
		internal Interop.ImageSubresourceRange* instance;

		internal ImageSubresourceRange(Interop.ImageSubresourceRange* instance)
		{
			this.instance = instance == null ? Interop.ImageSubresourceRange.Create() : instance;
		}

		public static ImageSubresourceRange Create()
		{
			var result = new ImageSubresourceRange(null);

			return result;
		}

		public ImageAspectFlags AspectMask
		{
			get
			{
				return this.instance->AspectMask;
			}
			set
			{
				this.instance->AspectMask = value;
			}
		}

		public uint BaseMipLevel
		{
			get
			{
				return this.instance->BaseMipLevel;
			}
			set
			{
				this.instance->BaseMipLevel = value;
			}
		}

		public uint LevelCount
		{
			get
			{
				return this.instance->LevelCount;
			}
			set
			{
				this.instance->LevelCount = value;
			}
		}

		public uint BaseArrayLayer
		{
			get
			{
				return this.instance->BaseArrayLayer;
			}
			set
			{
				this.instance->BaseArrayLayer = value;
			}
		}

		public uint LayerCount
		{
			get
			{
				return this.instance->LayerCount;
			}
			set
			{
				this.instance->LayerCount = value;
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
				return new ImageSubresourceRange(&(this.instance->SubresourceRange));
			}
			set
			{
				this.instance->SubresourceRange = *(value.instance);
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
				return new Extent3D(&(this.instance->Extent));
			}
			set
			{
				this.instance->Extent = *(value.instance);
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

	public unsafe class SubresourceLayout
		: IDisposable
	{
		internal Interop.SubresourceLayout* instance;

		internal SubresourceLayout(Interop.SubresourceLayout* instance)
		{
			this.instance = instance == null ? Interop.SubresourceLayout.Create() : instance;
		}

		public static SubresourceLayout Create()
		{
			var result = new SubresourceLayout(null);

			return result;
		}

		public ulong Offset
		{
			get
			{
				return this.instance->Offset;
			}
		}

		public ulong Size
		{
			get
			{
				return this.instance->Size;
			}
		}

		public ulong RowPitch
		{
			get
			{
				return this.instance->RowPitch;
			}
		}

		public ulong ArrayPitch
		{
			get
			{
				return this.instance->ArrayPitch;
			}
		}

		public ulong DepthPitch
		{
			get
			{
				return this.instance->DepthPitch;
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
				return new ComponentMapping(&(this.instance->Components));
			}
			set
			{
				this.instance->Components = *(value.instance);
			}
		}

		public ImageSubresourceRange SubresourceRange
		{
			get
			{
				return new ImageSubresourceRange(&(this.instance->SubresourceRange));
			}
			set
			{
				this.instance->SubresourceRange = *(value.instance);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class BufferCopy
		: IDisposable
	{
		internal Interop.BufferCopy* instance;

		internal BufferCopy(Interop.BufferCopy* instance)
		{
			this.instance = instance == null ? Interop.BufferCopy.Create() : instance;
		}

		public static BufferCopy Create()
		{
			var result = new BufferCopy(null);

			return result;
		}

		public ulong SrcOffset
		{
			get
			{
				return this.instance->SrcOffset;
			}
			set
			{
				this.instance->SrcOffset = value;
			}
		}

		public ulong DstOffset
		{
			get
			{
				return this.instance->DstOffset;
			}
			set
			{
				this.instance->DstOffset = value;
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
				return new ImageSubresource(&(this.instance->Subresource));
			}
			set
			{
				this.instance->Subresource = *(value.instance);
			}
		}

		public Offset3D Offset
		{
			get
			{
				return new Offset3D(&(this.instance->Offset));
			}
			set
			{
				this.instance->Offset = *(value.instance);
			}
		}

		public Extent3D Extent
		{
			get
			{
				return new Extent3D(&(this.instance->Extent));
			}
			set
			{
				this.instance->Extent = *(value.instance);
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

	public unsafe class ImageCopy
		: IDisposable
	{
		internal Interop.ImageCopy* instance;

		internal ImageCopy(Interop.ImageCopy* instance)
		{
			this.instance = instance == null ? Interop.ImageCopy.Create() : instance;
		}

		public static ImageCopy Create()
		{
			var result = new ImageCopy(null);

			return result;
		}

		public ImageSubresourceLayers SrcSubresource
		{
			get
			{
				return new ImageSubresourceLayers(&(this.instance->SrcSubresource));
			}
			set
			{
				this.instance->SrcSubresource = *(value.instance);
			}
		}

		public Offset3D SrcOffset
		{
			get
			{
				return new Offset3D(&(this.instance->SrcOffset));
			}
			set
			{
				this.instance->SrcOffset = *(value.instance);
			}
		}

		public ImageSubresourceLayers DstSubresource
		{
			get
			{
				return new ImageSubresourceLayers(&(this.instance->DstSubresource));
			}
			set
			{
				this.instance->DstSubresource = *(value.instance);
			}
		}

		public Offset3D DstOffset
		{
			get
			{
				return new Offset3D(&(this.instance->DstOffset));
			}
			set
			{
				this.instance->DstOffset = *(value.instance);
			}
		}

		public Extent3D Extent
		{
			get
			{
				return new Extent3D(&(this.instance->Extent));
			}
			set
			{
				this.instance->Extent = *(value.instance);
			}
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
				return new ImageSubresourceLayers(&(this.instance->SrcSubresource));
			}
			set
			{
				this.instance->SrcSubresource = *(value.instance);
			}
		}

		public Offset3D SrcOffsets_0
		{
			get
			{
				return new Offset3D(&(this.instance->SrcOffsets_0));
			}
			set
			{
				this.instance->SrcOffsets_0 = *(value.instance);
			}
		}

		public Offset3D SrcOffsets_1
		{
			get
			{
				return new Offset3D(&(this.instance->SrcOffsets_1));
			}
			set
			{
				this.instance->SrcOffsets_1 = *(value.instance);
			}
		}

		public ImageSubresourceLayers DstSubresource
		{
			get
			{
				return new ImageSubresourceLayers(&(this.instance->DstSubresource));
			}
			set
			{
				this.instance->DstSubresource = *(value.instance);
			}
		}

		public Offset3D DstOffsets_0
		{
			get
			{
				return new Offset3D(&(this.instance->DstOffsets_0));
			}
			set
			{
				this.instance->DstOffsets_0 = *(value.instance);
			}
		}

		public Offset3D DstOffsets_1
		{
			get
			{
				return new Offset3D(&(this.instance->DstOffsets_1));
			}
			set
			{
				this.instance->DstOffsets_1 = *(value.instance);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class BufferImageCopy
		: IDisposable
	{
		internal Interop.BufferImageCopy* instance;

		internal BufferImageCopy(Interop.BufferImageCopy* instance)
		{
			this.instance = instance == null ? Interop.BufferImageCopy.Create() : instance;
		}

		public static BufferImageCopy Create()
		{
			var result = new BufferImageCopy(null);

			return result;
		}

		public ulong BufferOffset
		{
			get
			{
				return this.instance->BufferOffset;
			}
			set
			{
				this.instance->BufferOffset = value;
			}
		}

		public uint BufferRowLength
		{
			get
			{
				return this.instance->BufferRowLength;
			}
			set
			{
				this.instance->BufferRowLength = value;
			}
		}

		public uint BufferImageHeight
		{
			get
			{
				return this.instance->BufferImageHeight;
			}
			set
			{
				this.instance->BufferImageHeight = value;
			}
		}

		public ImageSubresourceLayers ImageSubresource
		{
			get
			{
				return new ImageSubresourceLayers(&(this.instance->ImageSubresource));
			}
			set
			{
				this.instance->ImageSubresource = *(value.instance);
			}
		}

		public Offset3D ImageOffset
		{
			get
			{
				return new Offset3D(&(this.instance->ImageOffset));
			}
			set
			{
				this.instance->ImageOffset = *(value.instance);
			}
		}

		public Extent3D ImageExtent
		{
			get
			{
				return new Extent3D(&(this.instance->ImageExtent));
			}
			set
			{
				this.instance->ImageExtent = *(value.instance);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ImageResolve
		: IDisposable
	{
		internal Interop.ImageResolve* instance;

		internal ImageResolve(Interop.ImageResolve* instance)
		{
			this.instance = instance == null ? Interop.ImageResolve.Create() : instance;
		}

		public static ImageResolve Create()
		{
			var result = new ImageResolve(null);

			return result;
		}

		public ImageSubresourceLayers SrcSubresource
		{
			get
			{
				return new ImageSubresourceLayers(&(this.instance->SrcSubresource));
			}
			set
			{
				this.instance->SrcSubresource = *(value.instance);
			}
		}

		public Offset3D SrcOffset
		{
			get
			{
				return new Offset3D(&(this.instance->SrcOffset));
			}
			set
			{
				this.instance->SrcOffset = *(value.instance);
			}
		}

		public ImageSubresourceLayers DstSubresource
		{
			get
			{
				return new ImageSubresourceLayers(&(this.instance->DstSubresource));
			}
			set
			{
				this.instance->DstSubresource = *(value.instance);
			}
		}

		public Offset3D DstOffset
		{
			get
			{
				return new Offset3D(&(this.instance->DstOffset));
			}
			set
			{
				this.instance->DstOffset = *(value.instance);
			}
		}

		public Extent3D Extent
		{
			get
			{
				return new Extent3D(&(this.instance->Extent));
			}
			set
			{
				this.instance->Extent = *(value.instance);
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

	public unsafe class DescriptorPoolSize
		: IDisposable
	{
		internal Interop.DescriptorPoolSize* instance;

		internal DescriptorPoolSize(Interop.DescriptorPoolSize* instance)
		{
			this.instance = instance == null ? Interop.DescriptorPoolSize.Create() : instance;
		}

		public static DescriptorPoolSize Create()
		{
			var result = new DescriptorPoolSize(null);

			return result;
		}

		public DescriptorType Type
		{
			get
			{
				return this.instance->Type;
			}
			set
			{
				this.instance->Type = value;
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

	public unsafe class SpecializationMapEntry
		: IDisposable
	{
		internal Interop.SpecializationMapEntry* instance;

		internal SpecializationMapEntry(Interop.SpecializationMapEntry* instance)
		{
			this.instance = instance == null ? Interop.SpecializationMapEntry.Create() : instance;
		}

		public static SpecializationMapEntry Create()
		{
			var result = new SpecializationMapEntry(null);

			return result;
		}

		public uint ConstantID
		{
			get
			{
				return this.instance->ConstantID;
			}
			set
			{
				this.instance->ConstantID = value;
			}
		}

		public uint Offset
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

		public UIntPtr Size
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

	public unsafe class VertexInputBindingDescription
		: IDisposable
	{
		internal Interop.VertexInputBindingDescription* instance;

		internal VertexInputBindingDescription(Interop.VertexInputBindingDescription* instance)
		{
			this.instance = instance == null ? Interop.VertexInputBindingDescription.Create() : instance;
		}

		public static VertexInputBindingDescription Create()
		{
			var result = new VertexInputBindingDescription(null);

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

		public uint Stride
		{
			get
			{
				return this.instance->Stride;
			}
			set
			{
				this.instance->Stride = value;
			}
		}

		public VertexInputRate InputRate
		{
			get
			{
				return this.instance->InputRate;
			}
			set
			{
				this.instance->InputRate = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class VertexInputAttributeDescription
		: IDisposable
	{
		internal Interop.VertexInputAttributeDescription* instance;

		internal VertexInputAttributeDescription(Interop.VertexInputAttributeDescription* instance)
		{
			this.instance = instance == null ? Interop.VertexInputAttributeDescription.Create() : instance;
		}

		public static VertexInputAttributeDescription Create()
		{
			var result = new VertexInputAttributeDescription(null);

			return result;
		}

		public uint Location
		{
			get
			{
				return this.instance->Location;
			}
			set
			{
				this.instance->Location = value;
			}
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

		public uint Offset
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

	public unsafe class PipelineColorBlendAttachmentState
		: IDisposable
	{
		internal Interop.PipelineColorBlendAttachmentState* instance;

		internal PipelineColorBlendAttachmentState(Interop.PipelineColorBlendAttachmentState* instance)
		{
			this.instance = instance == null ? Interop.PipelineColorBlendAttachmentState.Create() : instance;
		}

		public static PipelineColorBlendAttachmentState Create()
		{
			var result = new PipelineColorBlendAttachmentState(null);

			return result;
		}

		public bool BlendEnable
		{
			get
			{
				return this.instance->BlendEnable;
			}
			set
			{
				this.instance->BlendEnable = value;
			}
		}

		public BlendFactor SrcColorBlendFactor
		{
			get
			{
				return this.instance->SrcColorBlendFactor;
			}
			set
			{
				this.instance->SrcColorBlendFactor = value;
			}
		}

		public BlendFactor DstColorBlendFactor
		{
			get
			{
				return this.instance->DstColorBlendFactor;
			}
			set
			{
				this.instance->DstColorBlendFactor = value;
			}
		}

		public BlendOp ColorBlendOp
		{
			get
			{
				return this.instance->ColorBlendOp;
			}
			set
			{
				this.instance->ColorBlendOp = value;
			}
		}

		public BlendFactor SrcAlphaBlendFactor
		{
			get
			{
				return this.instance->SrcAlphaBlendFactor;
			}
			set
			{
				this.instance->SrcAlphaBlendFactor = value;
			}
		}

		public BlendFactor DstAlphaBlendFactor
		{
			get
			{
				return this.instance->DstAlphaBlendFactor;
			}
			set
			{
				this.instance->DstAlphaBlendFactor = value;
			}
		}

		public BlendOp AlphaBlendOp
		{
			get
			{
				return this.instance->AlphaBlendOp;
			}
			set
			{
				this.instance->AlphaBlendOp = value;
			}
		}

		public ColorComponentFlags ColorWriteMask
		{
			get
			{
				return this.instance->ColorWriteMask;
			}
			set
			{
				this.instance->ColorWriteMask = value;
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

	public unsafe class StencilOpState
		: IDisposable
	{
		internal Interop.StencilOpState* instance;

		internal StencilOpState(Interop.StencilOpState* instance)
		{
			this.instance = instance == null ? Interop.StencilOpState.Create() : instance;
		}

		public static StencilOpState Create()
		{
			var result = new StencilOpState(null);

			return result;
		}

		public StencilOp FailOp
		{
			get
			{
				return this.instance->FailOp;
			}
			set
			{
				this.instance->FailOp = value;
			}
		}

		public StencilOp PassOp
		{
			get
			{
				return this.instance->PassOp;
			}
			set
			{
				this.instance->PassOp = value;
			}
		}

		public StencilOp DepthFailOp
		{
			get
			{
				return this.instance->DepthFailOp;
			}
			set
			{
				this.instance->DepthFailOp = value;
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

		public uint CompareMask
		{
			get
			{
				return this.instance->CompareMask;
			}
			set
			{
				this.instance->CompareMask = value;
			}
		}

		public uint WriteMask
		{
			get
			{
				return this.instance->WriteMask;
			}
			set
			{
				this.instance->WriteMask = value;
			}
		}

		public uint Reference
		{
			get
			{
				return this.instance->Reference;
			}
			set
			{
				this.instance->Reference = value;
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
				return new StencilOpState(&(this.instance->Front));
			}
			set
			{
				this.instance->Front = *(value.instance);
			}
		}

		public StencilOpState Back
		{
			get
			{
				return new StencilOpState(&(this.instance->Back));
			}
			set
			{
				this.instance->Back = *(value.instance);
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

	public unsafe class PushConstantRange
		: IDisposable
	{
		internal Interop.PushConstantRange* instance;

		internal PushConstantRange(Interop.PushConstantRange* instance)
		{
			this.instance = instance == null ? Interop.PushConstantRange.Create() : instance;
		}

		public static PushConstantRange Create()
		{
			var result = new PushConstantRange(null);

			return result;
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

		public uint Offset
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

		public uint Size
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
				return new Rect2D(&(this.instance->RenderArea));
			}
			set
			{
				this.instance->RenderArea = *(value.instance);
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ClearDepthStencilValue
		: IDisposable
	{
		internal Interop.ClearDepthStencilValue* instance;

		internal ClearDepthStencilValue(Interop.ClearDepthStencilValue* instance)
		{
			this.instance = instance == null ? Interop.ClearDepthStencilValue.Create() : instance;
		}

		public static ClearDepthStencilValue Create()
		{
			var result = new ClearDepthStencilValue(null);

			return result;
		}

		public float Depth
		{
			get
			{
				return this.instance->Depth;
			}
			set
			{
				this.instance->Depth = value;
			}
		}

		public uint Stencil
		{
			get
			{
				return this.instance->Stencil;
			}
			set
			{
				this.instance->Stencil = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class ClearAttachment
		: IDisposable
	{
		internal Interop.ClearAttachment* instance;

		internal ClearAttachment(Interop.ClearAttachment* instance)
		{
			this.instance = instance == null ? Interop.ClearAttachment.Create() : instance;
		}

		public static ClearAttachment Create()
		{
			var result = new ClearAttachment(null);

			return result;
		}

		public ImageAspectFlags AspectMask
		{
			get
			{
				return this.instance->AspectMask;
			}
			set
			{
				this.instance->AspectMask = value;
			}
		}

		public uint ColorAttachment
		{
			get
			{
				return this.instance->ColorAttachment;
			}
			set
			{
				this.instance->ColorAttachment = value;
			}
		}

		public ClearValue ClearValue
		{
			get
			{
				return this.instance->ClearValue;
			}
			set
			{
				this.instance->ClearValue = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class AttachmentDescription
		: IDisposable
	{
		internal Interop.AttachmentDescription* instance;

		internal AttachmentDescription(Interop.AttachmentDescription* instance)
		{
			this.instance = instance == null ? Interop.AttachmentDescription.Create() : instance;
		}

		public static AttachmentDescription Create()
		{
			var result = new AttachmentDescription(null);

			return result;
		}

		public AttachmentDescriptionFlags Flags
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

		public AttachmentLoadOp LoadOp
		{
			get
			{
				return this.instance->LoadOp;
			}
			set
			{
				this.instance->LoadOp = value;
			}
		}

		public AttachmentStoreOp StoreOp
		{
			get
			{
				return this.instance->StoreOp;
			}
			set
			{
				this.instance->StoreOp = value;
			}
		}

		public AttachmentLoadOp StencilLoadOp
		{
			get
			{
				return this.instance->StencilLoadOp;
			}
			set
			{
				this.instance->StencilLoadOp = value;
			}
		}

		public AttachmentStoreOp StencilStoreOp
		{
			get
			{
				return this.instance->StencilStoreOp;
			}
			set
			{
				this.instance->StencilStoreOp = value;
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

		public ImageLayout FinalLayout
		{
			get
			{
				return this.instance->FinalLayout;
			}
			set
			{
				this.instance->FinalLayout = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class AttachmentReference
		: IDisposable
	{
		internal Interop.AttachmentReference* instance;

		internal AttachmentReference(Interop.AttachmentReference* instance)
		{
			this.instance = instance == null ? Interop.AttachmentReference.Create() : instance;
		}

		public static AttachmentReference Create()
		{
			var result = new AttachmentReference(null);

			return result;
		}

		public uint Attachment
		{
			get
			{
				return this.instance->Attachment;
			}
			set
			{
				this.instance->Attachment = value;
			}
		}

		public ImageLayout Layout
		{
			get
			{
				return this.instance->Layout;
			}
			set
			{
				this.instance->Layout = value;
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

	public unsafe class SubpassDependency
		: IDisposable
	{
		internal Interop.SubpassDependency* instance;

		internal SubpassDependency(Interop.SubpassDependency* instance)
		{
			this.instance = instance == null ? Interop.SubpassDependency.Create() : instance;
		}

		public static SubpassDependency Create()
		{
			var result = new SubpassDependency(null);

			return result;
		}

		public uint SrcSubpass
		{
			get
			{
				return this.instance->SrcSubpass;
			}
			set
			{
				this.instance->SrcSubpass = value;
			}
		}

		public uint DstSubpass
		{
			get
			{
				return this.instance->DstSubpass;
			}
			set
			{
				this.instance->DstSubpass = value;
			}
		}

		public PipelineStageFlags SrcStageMask
		{
			get
			{
				return this.instance->SrcStageMask;
			}
			set
			{
				this.instance->SrcStageMask = value;
			}
		}

		public PipelineStageFlags DstStageMask
		{
			get
			{
				return this.instance->DstStageMask;
			}
			set
			{
				this.instance->DstStageMask = value;
			}
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

		public DependencyFlags DependencyFlags
		{
			get
			{
				return this.instance->DependencyFlags;
			}
			set
			{
				this.instance->DependencyFlags = value;
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

	public unsafe class PhysicalDeviceFeatures
		: IDisposable
	{
		internal Interop.PhysicalDeviceFeatures* instance;

		internal PhysicalDeviceFeatures(Interop.PhysicalDeviceFeatures* instance)
		{
			this.instance = instance == null ? Interop.PhysicalDeviceFeatures.Create() : instance;
		}

		public static PhysicalDeviceFeatures Create()
		{
			var result = new PhysicalDeviceFeatures(null);

			return result;
		}

		public bool RobustBufferAccess
		{
			get
			{
				return this.instance->RobustBufferAccess;
			}
			set
			{
				this.instance->RobustBufferAccess = value;
			}
		}

		public bool FullDrawIndexUint32
		{
			get
			{
				return this.instance->FullDrawIndexUint32;
			}
			set
			{
				this.instance->FullDrawIndexUint32 = value;
			}
		}

		public bool ImageCubeArray
		{
			get
			{
				return this.instance->ImageCubeArray;
			}
			set
			{
				this.instance->ImageCubeArray = value;
			}
		}

		public bool IndependentBlend
		{
			get
			{
				return this.instance->IndependentBlend;
			}
			set
			{
				this.instance->IndependentBlend = value;
			}
		}

		public bool GeometryShader
		{
			get
			{
				return this.instance->GeometryShader;
			}
			set
			{
				this.instance->GeometryShader = value;
			}
		}

		public bool TessellationShader
		{
			get
			{
				return this.instance->TessellationShader;
			}
			set
			{
				this.instance->TessellationShader = value;
			}
		}

		public bool SampleRateShading
		{
			get
			{
				return this.instance->SampleRateShading;
			}
			set
			{
				this.instance->SampleRateShading = value;
			}
		}

		public bool DualSrcBlend
		{
			get
			{
				return this.instance->DualSrcBlend;
			}
			set
			{
				this.instance->DualSrcBlend = value;
			}
		}

		public bool LogicOp
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

		public bool MultiDrawIndirect
		{
			get
			{
				return this.instance->MultiDrawIndirect;
			}
			set
			{
				this.instance->MultiDrawIndirect = value;
			}
		}

		public bool DrawIndirectFirstInstance
		{
			get
			{
				return this.instance->DrawIndirectFirstInstance;
			}
			set
			{
				this.instance->DrawIndirectFirstInstance = value;
			}
		}

		public bool DepthClamp
		{
			get
			{
				return this.instance->DepthClamp;
			}
			set
			{
				this.instance->DepthClamp = value;
			}
		}

		public bool DepthBiasClamp
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

		public bool FillModeNonSolid
		{
			get
			{
				return this.instance->FillModeNonSolid;
			}
			set
			{
				this.instance->FillModeNonSolid = value;
			}
		}

		public bool DepthBounds
		{
			get
			{
				return this.instance->DepthBounds;
			}
			set
			{
				this.instance->DepthBounds = value;
			}
		}

		public bool WideLines
		{
			get
			{
				return this.instance->WideLines;
			}
			set
			{
				this.instance->WideLines = value;
			}
		}

		public bool LargePoints
		{
			get
			{
				return this.instance->LargePoints;
			}
			set
			{
				this.instance->LargePoints = value;
			}
		}

		public bool AlphaToOne
		{
			get
			{
				return this.instance->AlphaToOne;
			}
			set
			{
				this.instance->AlphaToOne = value;
			}
		}

		public bool MultiViewport
		{
			get
			{
				return this.instance->MultiViewport;
			}
			set
			{
				this.instance->MultiViewport = value;
			}
		}

		public bool SamplerAnisotropy
		{
			get
			{
				return this.instance->SamplerAnisotropy;
			}
			set
			{
				this.instance->SamplerAnisotropy = value;
			}
		}

		public bool TextureCompressionETC2
		{
			get
			{
				return this.instance->TextureCompressionETC2;
			}
			set
			{
				this.instance->TextureCompressionETC2 = value;
			}
		}

		public bool TextureCompressionASTC_LDR
		{
			get
			{
				return this.instance->TextureCompressionASTC_LDR;
			}
			set
			{
				this.instance->TextureCompressionASTC_LDR = value;
			}
		}

		public bool TextureCompressionBC
		{
			get
			{
				return this.instance->TextureCompressionBC;
			}
			set
			{
				this.instance->TextureCompressionBC = value;
			}
		}

		public bool OcclusionQueryPrecise
		{
			get
			{
				return this.instance->OcclusionQueryPrecise;
			}
			set
			{
				this.instance->OcclusionQueryPrecise = value;
			}
		}

		public bool PipelineStatisticsQuery
		{
			get
			{
				return this.instance->PipelineStatisticsQuery;
			}
			set
			{
				this.instance->PipelineStatisticsQuery = value;
			}
		}

		public bool VertexPipelineStoresAndAtomics
		{
			get
			{
				return this.instance->VertexPipelineStoresAndAtomics;
			}
			set
			{
				this.instance->VertexPipelineStoresAndAtomics = value;
			}
		}

		public bool FragmentStoresAndAtomics
		{
			get
			{
				return this.instance->FragmentStoresAndAtomics;
			}
			set
			{
				this.instance->FragmentStoresAndAtomics = value;
			}
		}

		public bool ShaderTessellationAndGeometryPointSize
		{
			get
			{
				return this.instance->ShaderTessellationAndGeometryPointSize;
			}
			set
			{
				this.instance->ShaderTessellationAndGeometryPointSize = value;
			}
		}

		public bool ShaderImageGatherExtended
		{
			get
			{
				return this.instance->ShaderImageGatherExtended;
			}
			set
			{
				this.instance->ShaderImageGatherExtended = value;
			}
		}

		public bool ShaderStorageImageExtendedFormats
		{
			get
			{
				return this.instance->ShaderStorageImageExtendedFormats;
			}
			set
			{
				this.instance->ShaderStorageImageExtendedFormats = value;
			}
		}

		public bool ShaderStorageImageMultisample
		{
			get
			{
				return this.instance->ShaderStorageImageMultisample;
			}
			set
			{
				this.instance->ShaderStorageImageMultisample = value;
			}
		}

		public bool ShaderStorageImageReadWithoutFormat
		{
			get
			{
				return this.instance->ShaderStorageImageReadWithoutFormat;
			}
			set
			{
				this.instance->ShaderStorageImageReadWithoutFormat = value;
			}
		}

		public bool ShaderStorageImageWriteWithoutFormat
		{
			get
			{
				return this.instance->ShaderStorageImageWriteWithoutFormat;
			}
			set
			{
				this.instance->ShaderStorageImageWriteWithoutFormat = value;
			}
		}

		public bool ShaderUniformBufferArrayDynamicIndexing
		{
			get
			{
				return this.instance->ShaderUniformBufferArrayDynamicIndexing;
			}
			set
			{
				this.instance->ShaderUniformBufferArrayDynamicIndexing = value;
			}
		}

		public bool ShaderSampledImageArrayDynamicIndexing
		{
			get
			{
				return this.instance->ShaderSampledImageArrayDynamicIndexing;
			}
			set
			{
				this.instance->ShaderSampledImageArrayDynamicIndexing = value;
			}
		}

		public bool ShaderStorageBufferArrayDynamicIndexing
		{
			get
			{
				return this.instance->ShaderStorageBufferArrayDynamicIndexing;
			}
			set
			{
				this.instance->ShaderStorageBufferArrayDynamicIndexing = value;
			}
		}

		public bool ShaderStorageImageArrayDynamicIndexing
		{
			get
			{
				return this.instance->ShaderStorageImageArrayDynamicIndexing;
			}
			set
			{
				this.instance->ShaderStorageImageArrayDynamicIndexing = value;
			}
		}

		public bool ShaderClipDistance
		{
			get
			{
				return this.instance->ShaderClipDistance;
			}
			set
			{
				this.instance->ShaderClipDistance = value;
			}
		}

		public bool ShaderCullDistance
		{
			get
			{
				return this.instance->ShaderCullDistance;
			}
			set
			{
				this.instance->ShaderCullDistance = value;
			}
		}

		public bool ShaderFloat64
		{
			get
			{
				return this.instance->ShaderFloat64;
			}
			set
			{
				this.instance->ShaderFloat64 = value;
			}
		}

		public bool ShaderInt64
		{
			get
			{
				return this.instance->ShaderInt64;
			}
			set
			{
				this.instance->ShaderInt64 = value;
			}
		}

		public bool ShaderInt16
		{
			get
			{
				return this.instance->ShaderInt16;
			}
			set
			{
				this.instance->ShaderInt16 = value;
			}
		}

		public bool ShaderResourceResidency
		{
			get
			{
				return this.instance->ShaderResourceResidency;
			}
			set
			{
				this.instance->ShaderResourceResidency = value;
			}
		}

		public bool ShaderResourceMinLod
		{
			get
			{
				return this.instance->ShaderResourceMinLod;
			}
			set
			{
				this.instance->ShaderResourceMinLod = value;
			}
		}

		public bool SparseBinding
		{
			get
			{
				return this.instance->SparseBinding;
			}
			set
			{
				this.instance->SparseBinding = value;
			}
		}

		public bool SparseResidencyBuffer
		{
			get
			{
				return this.instance->SparseResidencyBuffer;
			}
			set
			{
				this.instance->SparseResidencyBuffer = value;
			}
		}

		public bool SparseResidencyImage2D
		{
			get
			{
				return this.instance->SparseResidencyImage2D;
			}
			set
			{
				this.instance->SparseResidencyImage2D = value;
			}
		}

		public bool SparseResidencyImage3D
		{
			get
			{
				return this.instance->SparseResidencyImage3D;
			}
			set
			{
				this.instance->SparseResidencyImage3D = value;
			}
		}

		public bool SparseResidency2Samples
		{
			get
			{
				return this.instance->SparseResidency2Samples;
			}
			set
			{
				this.instance->SparseResidency2Samples = value;
			}
		}

		public bool SparseResidency4Samples
		{
			get
			{
				return this.instance->SparseResidency4Samples;
			}
			set
			{
				this.instance->SparseResidency4Samples = value;
			}
		}

		public bool SparseResidency8Samples
		{
			get
			{
				return this.instance->SparseResidency8Samples;
			}
			set
			{
				this.instance->SparseResidency8Samples = value;
			}
		}

		public bool SparseResidency16Samples
		{
			get
			{
				return this.instance->SparseResidency16Samples;
			}
			set
			{
				this.instance->SparseResidency16Samples = value;
			}
		}

		public bool SparseResidencyAliased
		{
			get
			{
				return this.instance->SparseResidencyAliased;
			}
			set
			{
				this.instance->SparseResidencyAliased = value;
			}
		}

		public bool VariableMultisampleRate
		{
			get
			{
				return this.instance->VariableMultisampleRate;
			}
			set
			{
				this.instance->VariableMultisampleRate = value;
			}
		}

		public bool InheritedQueries
		{
			get
			{
				return this.instance->InheritedQueries;
			}
			set
			{
				this.instance->InheritedQueries = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class PhysicalDeviceSparseProperties
		: IDisposable
	{
		internal Interop.PhysicalDeviceSparseProperties* instance;

		internal PhysicalDeviceSparseProperties(Interop.PhysicalDeviceSparseProperties* instance)
		{
			this.instance = instance == null ? Interop.PhysicalDeviceSparseProperties.Create() : instance;
		}

		public static PhysicalDeviceSparseProperties Create()
		{
			var result = new PhysicalDeviceSparseProperties(null);

			return result;
		}

		public bool ResidencyStandard2DBlockShape
		{
			get
			{
				return this.instance->ResidencyStandard2DBlockShape;
			}
		}

		public bool ResidencyStandard2DMultisampleBlockShape
		{
			get
			{
				return this.instance->ResidencyStandard2DMultisampleBlockShape;
			}
		}

		public bool ResidencyStandard3DBlockShape
		{
			get
			{
				return this.instance->ResidencyStandard3DBlockShape;
			}
		}

		public bool ResidencyAlignedMipSize
		{
			get
			{
				return this.instance->ResidencyAlignedMipSize;
			}
		}

		public bool ResidencyNonResidentStrict
		{
			get
			{
				return this.instance->ResidencyNonResidentStrict;
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

	public unsafe class DrawIndirectCommand
		: IDisposable
	{
		internal Interop.DrawIndirectCommand* instance;

		internal DrawIndirectCommand(Interop.DrawIndirectCommand* instance)
		{
			this.instance = instance == null ? Interop.DrawIndirectCommand.Create() : instance;
		}

		public static DrawIndirectCommand Create()
		{
			var result = new DrawIndirectCommand(null);

			return result;
		}

		public uint VertexCount
		{
			get
			{
				return this.instance->VertexCount;
			}
			set
			{
				this.instance->VertexCount = value;
			}
		}

		public uint InstanceCount
		{
			get
			{
				return this.instance->InstanceCount;
			}
			set
			{
				this.instance->InstanceCount = value;
			}
		}

		public uint FirstVertex
		{
			get
			{
				return this.instance->FirstVertex;
			}
			set
			{
				this.instance->FirstVertex = value;
			}
		}

		public uint FirstInstance
		{
			get
			{
				return this.instance->FirstInstance;
			}
			set
			{
				this.instance->FirstInstance = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DrawIndexedIndirectCommand
		: IDisposable
	{
		internal Interop.DrawIndexedIndirectCommand* instance;

		internal DrawIndexedIndirectCommand(Interop.DrawIndexedIndirectCommand* instance)
		{
			this.instance = instance == null ? Interop.DrawIndexedIndirectCommand.Create() : instance;
		}

		public static DrawIndexedIndirectCommand Create()
		{
			var result = new DrawIndexedIndirectCommand(null);

			return result;
		}

		public uint IndexCount
		{
			get
			{
				return this.instance->IndexCount;
			}
			set
			{
				this.instance->IndexCount = value;
			}
		}

		public uint InstanceCount
		{
			get
			{
				return this.instance->InstanceCount;
			}
			set
			{
				this.instance->InstanceCount = value;
			}
		}

		public uint FirstIndex
		{
			get
			{
				return this.instance->FirstIndex;
			}
			set
			{
				this.instance->FirstIndex = value;
			}
		}

		public int VertexOffset
		{
			get
			{
				return this.instance->VertexOffset;
			}
			set
			{
				this.instance->VertexOffset = value;
			}
		}

		public uint FirstInstance
		{
			get
			{
				return this.instance->FirstInstance;
			}
			set
			{
				this.instance->FirstInstance = value;
			}
		}

		public void Dispose()
		{
			Interop.HeapUtil.Free(this.instance);
			this.instance = null;
		}
	}

	public unsafe class DispatchIndirectCommand
		: IDisposable
	{
		internal Interop.DispatchIndirectCommand* instance;

		internal DispatchIndirectCommand(Interop.DispatchIndirectCommand* instance)
		{
			this.instance = instance == null ? Interop.DispatchIndirectCommand.Create() : instance;
		}

		public static DispatchIndirectCommand Create()
		{
			var result = new DispatchIndirectCommand(null);

			return result;
		}

		public uint X
		{
			get
			{
				return this.instance->X;
			}
			set
			{
				this.instance->X = value;
			}
		}

		public uint Y
		{
			get
			{
				return this.instance->Y;
			}
			set
			{
				this.instance->Y = value;
			}
		}

		public uint Z
		{
			get
			{
				return this.instance->Z;
			}
			set
			{
				this.instance->Z = value;
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
