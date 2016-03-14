
using System;

namespace SharpVk
{

	public unsafe struct Offset2D
	{
		private readonly Interop.Offset2D* instance;

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
				var value0 = this.instance->X;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->X = value0;
			}
		}

		public int Y
		{
			get
			{
				var value0 = this.instance->Y;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Y = value0;
			}
		}
	}

	public unsafe struct Offset3D
	{
		private readonly Interop.Offset3D* instance;

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
				var value0 = this.instance->X;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->X = value0;
			}
		}

		public int Y
		{
			get
			{
				var value0 = this.instance->Y;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Y = value0;
			}
		}

		public int Z
		{
			get
			{
				var value0 = this.instance->Z;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Z = value0;
			}
		}
	}

	public unsafe struct Extent2D
	{
		private readonly Interop.Extent2D* instance;

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
				var value0 = this.instance->Width;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Width = value0;
			}
		}

		public uint Height
		{
			get
			{
				var value0 = this.instance->Height;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Height = value0;
			}
		}
	}

	public unsafe struct Extent3D
	{
		private readonly Interop.Extent3D* instance;

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
				var value0 = this.instance->Width;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Width = value0;
			}
		}

		public uint Height
		{
			get
			{
				var value0 = this.instance->Height;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Height = value0;
			}
		}

		public uint Depth
		{
			get
			{
				var value0 = this.instance->Depth;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Depth = value0;
			}
		}
	}

	public unsafe struct Viewport
	{
		private readonly Interop.Viewport* instance;

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
				var value0 = this.instance->X;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->X = value0;
			}
		}

		public float Y
		{
			get
			{
				var value0 = this.instance->Y;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Y = value0;
			}
		}

		public float Width
		{
			get
			{
				var value0 = this.instance->Width;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Width = value0;
			}
		}

		public float Height
		{
			get
			{
				var value0 = this.instance->Height;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Height = value0;
			}
		}

		public float MinDepth
		{
			get
			{
				var value0 = this.instance->MinDepth;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinDepth = value0;
			}
		}

		public float MaxDepth
		{
			get
			{
				var value0 = this.instance->MaxDepth;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDepth = value0;
			}
		}
	}

	public unsafe struct Rect2D
	{
		private readonly Interop.Rect2D* instance;

		internal Rect2D(Interop.Rect2D* instance)
		{
			this.instance = instance == null ? Interop.Rect2D.Create() : instance;
		}

		public static Rect2D Create()
		{
			var result = new Rect2D(null);

			return result;
		}
	}

	public unsafe struct Rect3D
	{
		private readonly Interop.Rect3D* instance;

		internal Rect3D(Interop.Rect3D* instance)
		{
			this.instance = instance == null ? Interop.Rect3D.Create() : instance;
		}

		public static Rect3D Create()
		{
			var result = new Rect3D(null);

			return result;
		}
	}

	public unsafe struct ClearRect
	{
		private readonly Interop.ClearRect* instance;

		internal ClearRect(Interop.ClearRect* instance)
		{
			this.instance = instance == null ? Interop.ClearRect.Create() : instance;
		}

		public static ClearRect Create()
		{
			var result = new ClearRect(null);

			return result;
		}

		public uint BaseArrayLayer
		{
			get
			{
				var value0 = this.instance->BaseArrayLayer;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BaseArrayLayer = value0;
			}
		}

		public uint LayerCount
		{
			get
			{
				var value0 = this.instance->LayerCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LayerCount = value0;
			}
		}
	}

	public unsafe struct ComponentMapping
	{
		private readonly Interop.ComponentMapping* instance;

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
				var value0 = this.instance->R;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->R = value0;
			}
		}

		public ComponentSwizzle G
		{
			get
			{
				var value0 = this.instance->G;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->G = value0;
			}
		}

		public ComponentSwizzle B
		{
			get
			{
				var value0 = this.instance->B;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->B = value0;
			}
		}

		public ComponentSwizzle A
		{
			get
			{
				var value0 = this.instance->A;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->A = value0;
			}
		}
	}

	public unsafe struct PhysicalDeviceProperties
	{
		private readonly Interop.PhysicalDeviceProperties* instance;

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
				var value0 = this.instance->ApiVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ApiVersion = value0;
			}
		}

		public uint DriverVersion
		{
			get
			{
				var value0 = this.instance->DriverVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DriverVersion = value0;
			}
		}

		public uint VendorID
		{
			get
			{
				var value0 = this.instance->VendorID;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->VendorID = value0;
			}
		}

		public uint DeviceID
		{
			get
			{
				var value0 = this.instance->DeviceID;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DeviceID = value0;
			}
		}

		public PhysicalDeviceType DeviceType
		{
			get
			{
				var value0 = this.instance->DeviceType;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DeviceType = value0;
			}
		}

		public char DeviceName
		{
			get
			{
				var value0 = this.instance->DeviceName;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DeviceName = value0;
			}
		}

		public byte PipelineCacheUUID
		{
			get
			{
				var value0 = this.instance->PipelineCacheUUID;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PipelineCacheUUID = value0;
			}
		}
	}

	public unsafe struct ExtensionProperties
	{
		private readonly Interop.ExtensionProperties* instance;

		internal ExtensionProperties(Interop.ExtensionProperties* instance)
		{
			this.instance = instance == null ? Interop.ExtensionProperties.Create() : instance;
		}

		public static ExtensionProperties Create()
		{
			var result = new ExtensionProperties(null);

			return result;
		}

		public char ExtensionName
		{
			get
			{
				var value0 = this.instance->ExtensionName;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ExtensionName = value0;
			}
		}

		public uint SpecVersion
		{
			get
			{
				var value0 = this.instance->SpecVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SpecVersion = value0;
			}
		}
	}

	public unsafe struct LayerProperties
	{
		private readonly Interop.LayerProperties* instance;

		internal LayerProperties(Interop.LayerProperties* instance)
		{
			this.instance = instance == null ? Interop.LayerProperties.Create() : instance;
		}

		public static LayerProperties Create()
		{
			var result = new LayerProperties(null);

			return result;
		}

		public char LayerName
		{
			get
			{
				var value0 = this.instance->LayerName;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LayerName = value0;
			}
		}

		public uint SpecVersion
		{
			get
			{
				var value0 = this.instance->SpecVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SpecVersion = value0;
			}
		}

		public uint ImplementationVersion
		{
			get
			{
				var value0 = this.instance->ImplementationVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImplementationVersion = value0;
			}
		}

		public char Description
		{
			get
			{
				var value0 = this.instance->Description;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Description = value0;
			}
		}
	}

	public unsafe struct ApplicationInfo
	{
		private readonly Interop.ApplicationInfo* instance;

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
				var value0 = this.instance->ApplicationName;

				var value1 = Interop.HeapUtil.MarshalPointerToString(value0);

				return value1;
			}
			set
			{
				var value0 = value;

				var value1 = Interop.HeapUtil.MarshalStringToPointer(value0);

				this.instance->ApplicationName = value1;
			}
		}

		public uint ApplicationVersion
		{
			get
			{
				var value0 = this.instance->ApplicationVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ApplicationVersion = value0;
			}
		}

		public string EngineName
		{
			get
			{
				var value0 = this.instance->EngineName;

				var value1 = Interop.HeapUtil.MarshalPointerToString(value0);

				return value1;
			}
			set
			{
				var value0 = value;

				var value1 = Interop.HeapUtil.MarshalStringToPointer(value0);

				this.instance->EngineName = value1;
			}
		}

		public uint EngineVersion
		{
			get
			{
				var value0 = this.instance->EngineVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->EngineVersion = value0;
			}
		}

		public uint ApiVersion
		{
			get
			{
				var value0 = this.instance->ApiVersion;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ApiVersion = value0;
			}
		}
	}

	public unsafe struct AllocationCallbacks
	{
		private readonly Interop.AllocationCallbacks* instance;

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
				var value0 = this.instance->PfnAllocation;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PfnAllocation = value0;
			}
		}

		public IntPtr PfnReallocation
		{
			get
			{
				var value0 = this.instance->PfnReallocation;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PfnReallocation = value0;
			}
		}

		public IntPtr PfnFree
		{
			get
			{
				var value0 = this.instance->PfnFree;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PfnFree = value0;
			}
		}

		public IntPtr PfnInternalAllocation
		{
			get
			{
				var value0 = this.instance->PfnInternalAllocation;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PfnInternalAllocation = value0;
			}
		}

		public IntPtr PfnInternalFree
		{
			get
			{
				var value0 = this.instance->PfnInternalFree;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PfnInternalFree = value0;
			}
		}
	}

	public unsafe struct DeviceQueueCreateInfo
	{
		private readonly Interop.DeviceQueueCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public uint QueueFamilyIndex
		{
			get
			{
				var value0 = this.instance->QueueFamilyIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->QueueFamilyIndex = value0;
			}
		}
	}

	public unsafe struct DeviceCreateInfo
	{
		private readonly Interop.DeviceCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct InstanceCreateInfo
	{
		private readonly Interop.InstanceCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct QueueFamilyProperties
	{
		private readonly Interop.QueueFamilyProperties* instance;

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
				var value0 = this.instance->QueueFlags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->QueueFlags = value0;
			}
		}

		public uint QueueCount
		{
			get
			{
				var value0 = this.instance->QueueCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->QueueCount = value0;
			}
		}

		public uint TimestampValidBits
		{
			get
			{
				var value0 = this.instance->TimestampValidBits;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->TimestampValidBits = value0;
			}
		}
	}

	public unsafe struct PhysicalDeviceMemoryProperties
	{
		private readonly Interop.PhysicalDeviceMemoryProperties* instance;

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
				var value0 = this.instance->MemoryTypeCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MemoryTypeCount = value0;
			}
		}

		public uint MemoryHeapCount
		{
			get
			{
				var value0 = this.instance->MemoryHeapCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MemoryHeapCount = value0;
			}
		}
	}

	public unsafe struct MemoryAllocateInfo
	{
		private readonly Interop.MemoryAllocateInfo* instance;

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
				var value0 = this.instance->AllocationSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AllocationSize = value0;
			}
		}

		public uint MemoryTypeIndex
		{
			get
			{
				var value0 = this.instance->MemoryTypeIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MemoryTypeIndex = value0;
			}
		}
	}

	public unsafe struct MemoryRequirements
	{
		private readonly Interop.MemoryRequirements* instance;

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
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}

		public ulong Alignment
		{
			get
			{
				var value0 = this.instance->Alignment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Alignment = value0;
			}
		}

		public uint MemoryTypeBits
		{
			get
			{
				var value0 = this.instance->MemoryTypeBits;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MemoryTypeBits = value0;
			}
		}
	}

	public unsafe struct SparseImageFormatProperties
	{
		private readonly Interop.SparseImageFormatProperties* instance;

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
				var value0 = this.instance->AspectMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AspectMask = value0;
			}
		}

		public SparseImageFormatFlags Flags
		{
			get
			{
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct SparseImageMemoryRequirements
	{
		private readonly Interop.SparseImageMemoryRequirements* instance;

		internal SparseImageMemoryRequirements(Interop.SparseImageMemoryRequirements* instance)
		{
			this.instance = instance == null ? Interop.SparseImageMemoryRequirements.Create() : instance;
		}

		public static SparseImageMemoryRequirements Create()
		{
			var result = new SparseImageMemoryRequirements(null);

			return result;
		}

		public uint ImageMipTailFirstLod
		{
			get
			{
				var value0 = this.instance->ImageMipTailFirstLod;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImageMipTailFirstLod = value0;
			}
		}

		public ulong ImageMipTailSize
		{
			get
			{
				var value0 = this.instance->ImageMipTailSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImageMipTailSize = value0;
			}
		}

		public ulong ImageMipTailOffset
		{
			get
			{
				var value0 = this.instance->ImageMipTailOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImageMipTailOffset = value0;
			}
		}

		public ulong ImageMipTailStride
		{
			get
			{
				var value0 = this.instance->ImageMipTailStride;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImageMipTailStride = value0;
			}
		}
	}

	public unsafe struct MemoryType
	{
		private readonly Interop.MemoryType* instance;

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
				var value0 = this.instance->PropertyFlags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PropertyFlags = value0;
			}
		}

		public uint HeapIndex
		{
			get
			{
				var value0 = this.instance->HeapIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->HeapIndex = value0;
			}
		}
	}

	public unsafe struct MemoryHeap
	{
		private readonly Interop.MemoryHeap* instance;

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
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}

		public MemoryHeapFlags Flags
		{
			get
			{
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct MappedMemoryRange
	{
		private readonly Interop.MappedMemoryRange* instance;

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
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}

		public ulong Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}
	}

	public unsafe struct FormatProperties
	{
		private readonly Interop.FormatProperties* instance;

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
				var value0 = this.instance->LinearTilingFeatures;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LinearTilingFeatures = value0;
			}
		}

		public FormatFeatureFlags OptimalTilingFeatures
		{
			get
			{
				var value0 = this.instance->OptimalTilingFeatures;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->OptimalTilingFeatures = value0;
			}
		}

		public FormatFeatureFlags BufferFeatures
		{
			get
			{
				var value0 = this.instance->BufferFeatures;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BufferFeatures = value0;
			}
		}
	}

	public unsafe struct ImageFormatProperties
	{
		private readonly Interop.ImageFormatProperties* instance;

		internal ImageFormatProperties(Interop.ImageFormatProperties* instance)
		{
			this.instance = instance == null ? Interop.ImageFormatProperties.Create() : instance;
		}

		public static ImageFormatProperties Create()
		{
			var result = new ImageFormatProperties(null);

			return result;
		}

		public uint MaxMipLevels
		{
			get
			{
				var value0 = this.instance->MaxMipLevels;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxMipLevels = value0;
			}
		}

		public uint MaxArrayLayers
		{
			get
			{
				var value0 = this.instance->MaxArrayLayers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxArrayLayers = value0;
			}
		}

		public SampleCountFlags SampleCounts
		{
			get
			{
				var value0 = this.instance->SampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SampleCounts = value0;
			}
		}

		public ulong MaxResourceSize
		{
			get
			{
				var value0 = this.instance->MaxResourceSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxResourceSize = value0;
			}
		}
	}

	public unsafe struct DescriptorBufferInfo
	{
		private readonly Interop.DescriptorBufferInfo* instance;

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
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}

		public ulong Range
		{
			get
			{
				var value0 = this.instance->Range;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Range = value0;
			}
		}
	}

	public unsafe struct DescriptorImageInfo
	{
		private readonly Interop.DescriptorImageInfo* instance;

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
				var value0 = this.instance->ImageLayout;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImageLayout = value0;
			}
		}
	}

	public unsafe struct WriteDescriptorSet
	{
		private readonly Interop.WriteDescriptorSet* instance;

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
				var value0 = this.instance->DstBinding;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstBinding = value0;
			}
		}

		public uint DstArrayElement
		{
			get
			{
				var value0 = this.instance->DstArrayElement;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstArrayElement = value0;
			}
		}

		public DescriptorType DescriptorType
		{
			get
			{
				var value0 = this.instance->DescriptorType;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DescriptorType = value0;
			}
		}
	}

	public unsafe struct CopyDescriptorSet
	{
		private readonly Interop.CopyDescriptorSet* instance;

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
				var value0 = this.instance->SrcBinding;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcBinding = value0;
			}
		}

		public uint SrcArrayElement
		{
			get
			{
				var value0 = this.instance->SrcArrayElement;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcArrayElement = value0;
			}
		}

		public uint DstBinding
		{
			get
			{
				var value0 = this.instance->DstBinding;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstBinding = value0;
			}
		}

		public uint DstArrayElement
		{
			get
			{
				var value0 = this.instance->DstArrayElement;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstArrayElement = value0;
			}
		}

		public uint DescriptorCount
		{
			get
			{
				var value0 = this.instance->DescriptorCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DescriptorCount = value0;
			}
		}
	}

	public unsafe struct BufferCreateInfo
	{
		private readonly Interop.BufferCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public ulong Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}

		public BufferUsageFlags Usage
		{
			get
			{
				var value0 = this.instance->Usage;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Usage = value0;
			}
		}

		public SharingMode SharingMode
		{
			get
			{
				var value0 = this.instance->SharingMode;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SharingMode = value0;
			}
		}
	}

	public unsafe struct BufferViewCreateInfo
	{
		private readonly Interop.BufferViewCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public Format Format
		{
			get
			{
				var value0 = this.instance->Format;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Format = value0;
			}
		}

		public ulong Offset
		{
			get
			{
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}

		public ulong Range
		{
			get
			{
				var value0 = this.instance->Range;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Range = value0;
			}
		}
	}

	public unsafe struct ImageSubresource
	{
		private readonly Interop.ImageSubresource* instance;

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
				var value0 = this.instance->AspectMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AspectMask = value0;
			}
		}

		public uint MipLevel
		{
			get
			{
				var value0 = this.instance->MipLevel;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MipLevel = value0;
			}
		}

		public uint ArrayLayer
		{
			get
			{
				var value0 = this.instance->ArrayLayer;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ArrayLayer = value0;
			}
		}
	}

	public unsafe struct ImageSubresourceLayers
	{
		private readonly Interop.ImageSubresourceLayers* instance;

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
				var value0 = this.instance->AspectMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AspectMask = value0;
			}
		}

		public uint MipLevel
		{
			get
			{
				var value0 = this.instance->MipLevel;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MipLevel = value0;
			}
		}

		public uint BaseArrayLayer
		{
			get
			{
				var value0 = this.instance->BaseArrayLayer;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BaseArrayLayer = value0;
			}
		}

		public uint LayerCount
		{
			get
			{
				var value0 = this.instance->LayerCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LayerCount = value0;
			}
		}
	}

	public unsafe struct ImageSubresourceRange
	{
		private readonly Interop.ImageSubresourceRange* instance;

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
				var value0 = this.instance->AspectMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AspectMask = value0;
			}
		}

		public uint BaseMipLevel
		{
			get
			{
				var value0 = this.instance->BaseMipLevel;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BaseMipLevel = value0;
			}
		}

		public uint LevelCount
		{
			get
			{
				var value0 = this.instance->LevelCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LevelCount = value0;
			}
		}

		public uint BaseArrayLayer
		{
			get
			{
				var value0 = this.instance->BaseArrayLayer;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BaseArrayLayer = value0;
			}
		}

		public uint LayerCount
		{
			get
			{
				var value0 = this.instance->LayerCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LayerCount = value0;
			}
		}
	}

	public unsafe struct MemoryBarrier
	{
		private readonly Interop.MemoryBarrier* instance;

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
				var value0 = this.instance->SrcAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcAccessMask = value0;
			}
		}

		public AccessFlags DstAccessMask
		{
			get
			{
				var value0 = this.instance->DstAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstAccessMask = value0;
			}
		}
	}

	public unsafe struct BufferMemoryBarrier
	{
		private readonly Interop.BufferMemoryBarrier* instance;

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
				var value0 = this.instance->SrcAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcAccessMask = value0;
			}
		}

		public AccessFlags DstAccessMask
		{
			get
			{
				var value0 = this.instance->DstAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstAccessMask = value0;
			}
		}

		public uint SrcQueueFamilyIndex
		{
			get
			{
				var value0 = this.instance->SrcQueueFamilyIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcQueueFamilyIndex = value0;
			}
		}

		public uint DstQueueFamilyIndex
		{
			get
			{
				var value0 = this.instance->DstQueueFamilyIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstQueueFamilyIndex = value0;
			}
		}

		public ulong Offset
		{
			get
			{
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}

		public ulong Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}
	}

	public unsafe struct ImageMemoryBarrier
	{
		private readonly Interop.ImageMemoryBarrier* instance;

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
				var value0 = this.instance->SrcAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcAccessMask = value0;
			}
		}

		public AccessFlags DstAccessMask
		{
			get
			{
				var value0 = this.instance->DstAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstAccessMask = value0;
			}
		}

		public ImageLayout OldLayout
		{
			get
			{
				var value0 = this.instance->OldLayout;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->OldLayout = value0;
			}
		}

		public ImageLayout NewLayout
		{
			get
			{
				var value0 = this.instance->NewLayout;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->NewLayout = value0;
			}
		}

		public uint SrcQueueFamilyIndex
		{
			get
			{
				var value0 = this.instance->SrcQueueFamilyIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcQueueFamilyIndex = value0;
			}
		}

		public uint DstQueueFamilyIndex
		{
			get
			{
				var value0 = this.instance->DstQueueFamilyIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstQueueFamilyIndex = value0;
			}
		}
	}

	public unsafe struct ImageCreateInfo
	{
		private readonly Interop.ImageCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public ImageType ImageType
		{
			get
			{
				var value0 = this.instance->ImageType;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImageType = value0;
			}
		}

		public Format Format
		{
			get
			{
				var value0 = this.instance->Format;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Format = value0;
			}
		}

		public uint MipLevels
		{
			get
			{
				var value0 = this.instance->MipLevels;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MipLevels = value0;
			}
		}

		public uint ArrayLayers
		{
			get
			{
				var value0 = this.instance->ArrayLayers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ArrayLayers = value0;
			}
		}

		public SampleCountFlags Samples
		{
			get
			{
				var value0 = this.instance->Samples;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Samples = value0;
			}
		}

		public ImageTiling Tiling
		{
			get
			{
				var value0 = this.instance->Tiling;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Tiling = value0;
			}
		}

		public ImageUsageFlags Usage
		{
			get
			{
				var value0 = this.instance->Usage;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Usage = value0;
			}
		}

		public SharingMode SharingMode
		{
			get
			{
				var value0 = this.instance->SharingMode;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SharingMode = value0;
			}
		}

		public ImageLayout InitialLayout
		{
			get
			{
				var value0 = this.instance->InitialLayout;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->InitialLayout = value0;
			}
		}
	}

	public unsafe struct SubresourceLayout
	{
		private readonly Interop.SubresourceLayout* instance;

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
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}

		public ulong Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}

		public ulong RowPitch
		{
			get
			{
				var value0 = this.instance->RowPitch;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->RowPitch = value0;
			}
		}

		public ulong ArrayPitch
		{
			get
			{
				var value0 = this.instance->ArrayPitch;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ArrayPitch = value0;
			}
		}

		public ulong DepthPitch
		{
			get
			{
				var value0 = this.instance->DepthPitch;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthPitch = value0;
			}
		}
	}

	public unsafe struct ImageViewCreateInfo
	{
		private readonly Interop.ImageViewCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public ImageViewType ViewType
		{
			get
			{
				var value0 = this.instance->ViewType;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ViewType = value0;
			}
		}

		public Format Format
		{
			get
			{
				var value0 = this.instance->Format;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Format = value0;
			}
		}
	}

	public unsafe struct BufferCopy
	{
		private readonly Interop.BufferCopy* instance;

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
				var value0 = this.instance->SrcOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcOffset = value0;
			}
		}

		public ulong DstOffset
		{
			get
			{
				var value0 = this.instance->DstOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstOffset = value0;
			}
		}

		public ulong Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}
	}

	public unsafe struct SparseMemoryBind
	{
		private readonly Interop.SparseMemoryBind* instance;

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
				var value0 = this.instance->ResourceOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ResourceOffset = value0;
			}
		}

		public ulong Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}

		public ulong MemoryOffset
		{
			get
			{
				var value0 = this.instance->MemoryOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MemoryOffset = value0;
			}
		}

		public SparseMemoryBindFlags Flags
		{
			get
			{
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct SparseImageMemoryBind
	{
		private readonly Interop.SparseImageMemoryBind* instance;

		internal SparseImageMemoryBind(Interop.SparseImageMemoryBind* instance)
		{
			this.instance = instance == null ? Interop.SparseImageMemoryBind.Create() : instance;
		}

		public static SparseImageMemoryBind Create()
		{
			var result = new SparseImageMemoryBind(null);

			return result;
		}

		public ulong MemoryOffset
		{
			get
			{
				var value0 = this.instance->MemoryOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MemoryOffset = value0;
			}
		}

		public SparseMemoryBindFlags Flags
		{
			get
			{
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct SparseBufferMemoryBindInfo
	{
		private readonly Interop.SparseBufferMemoryBindInfo* instance;

		internal SparseBufferMemoryBindInfo(Interop.SparseBufferMemoryBindInfo* instance)
		{
			this.instance = instance == null ? Interop.SparseBufferMemoryBindInfo.Create() : instance;
		}

		public static SparseBufferMemoryBindInfo Create()
		{
			var result = new SparseBufferMemoryBindInfo(null);

			return result;
		}
	}

	public unsafe struct SparseImageOpaqueMemoryBindInfo
	{
		private readonly Interop.SparseImageOpaqueMemoryBindInfo* instance;

		internal SparseImageOpaqueMemoryBindInfo(Interop.SparseImageOpaqueMemoryBindInfo* instance)
		{
			this.instance = instance == null ? Interop.SparseImageOpaqueMemoryBindInfo.Create() : instance;
		}

		public static SparseImageOpaqueMemoryBindInfo Create()
		{
			var result = new SparseImageOpaqueMemoryBindInfo(null);

			return result;
		}
	}

	public unsafe struct SparseImageMemoryBindInfo
	{
		private readonly Interop.SparseImageMemoryBindInfo* instance;

		internal SparseImageMemoryBindInfo(Interop.SparseImageMemoryBindInfo* instance)
		{
			this.instance = instance == null ? Interop.SparseImageMemoryBindInfo.Create() : instance;
		}

		public static SparseImageMemoryBindInfo Create()
		{
			var result = new SparseImageMemoryBindInfo(null);

			return result;
		}
	}

	public unsafe struct BindSparseInfo
	{
		private readonly Interop.BindSparseInfo* instance;

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
	}

	public unsafe struct ImageCopy
	{
		private readonly Interop.ImageCopy* instance;

		internal ImageCopy(Interop.ImageCopy* instance)
		{
			this.instance = instance == null ? Interop.ImageCopy.Create() : instance;
		}

		public static ImageCopy Create()
		{
			var result = new ImageCopy(null);

			return result;
		}
	}

	public unsafe struct ImageBlit
	{
		private readonly Interop.ImageBlit* instance;

		internal ImageBlit(Interop.ImageBlit* instance)
		{
			this.instance = instance == null ? Interop.ImageBlit.Create() : instance;
		}

		public static ImageBlit Create()
		{
			var result = new ImageBlit(null);

			return result;
		}
	}

	public unsafe struct BufferImageCopy
	{
		private readonly Interop.BufferImageCopy* instance;

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
				var value0 = this.instance->BufferOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BufferOffset = value0;
			}
		}

		public uint BufferRowLength
		{
			get
			{
				var value0 = this.instance->BufferRowLength;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BufferRowLength = value0;
			}
		}

		public uint BufferImageHeight
		{
			get
			{
				var value0 = this.instance->BufferImageHeight;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BufferImageHeight = value0;
			}
		}
	}

	public unsafe struct ImageResolve
	{
		private readonly Interop.ImageResolve* instance;

		internal ImageResolve(Interop.ImageResolve* instance)
		{
			this.instance = instance == null ? Interop.ImageResolve.Create() : instance;
		}

		public static ImageResolve Create()
		{
			var result = new ImageResolve(null);

			return result;
		}
	}

	public unsafe struct ShaderModuleCreateInfo
	{
		private readonly Interop.ShaderModuleCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public UIntPtr CodeSize
		{
			get
			{
				var value0 = this.instance->CodeSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->CodeSize = value0;
			}
		}
	}

	public unsafe struct DescriptorSetLayoutBinding
	{
		private readonly Interop.DescriptorSetLayoutBinding* instance;

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
				var value0 = this.instance->Binding;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Binding = value0;
			}
		}

		public DescriptorType DescriptorType
		{
			get
			{
				var value0 = this.instance->DescriptorType;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DescriptorType = value0;
			}
		}

		public ShaderStageFlags StageFlags
		{
			get
			{
				var value0 = this.instance->StageFlags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StageFlags = value0;
			}
		}
	}

	public unsafe struct DescriptorSetLayoutCreateInfo
	{
		private readonly Interop.DescriptorSetLayoutCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct DescriptorPoolSize
	{
		private readonly Interop.DescriptorPoolSize* instance;

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
				var value0 = this.instance->Type;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Type = value0;
			}
		}

		public uint DescriptorCount
		{
			get
			{
				var value0 = this.instance->DescriptorCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DescriptorCount = value0;
			}
		}
	}

	public unsafe struct DescriptorPoolCreateInfo
	{
		private readonly Interop.DescriptorPoolCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public uint MaxSets
		{
			get
			{
				var value0 = this.instance->MaxSets;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxSets = value0;
			}
		}
	}

	public unsafe struct DescriptorSetAllocateInfo
	{
		private readonly Interop.DescriptorSetAllocateInfo* instance;

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
	}

	public unsafe struct SpecializationMapEntry
	{
		private readonly Interop.SpecializationMapEntry* instance;

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
				var value0 = this.instance->ConstantID;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ConstantID = value0;
			}
		}

		public uint Offset
		{
			get
			{
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}

		public UIntPtr Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}
	}

	public unsafe struct SpecializationInfo
	{
		private readonly Interop.SpecializationInfo* instance;

		internal SpecializationInfo(Interop.SpecializationInfo* instance)
		{
			this.instance = instance == null ? Interop.SpecializationInfo.Create() : instance;
		}

		public static SpecializationInfo Create()
		{
			var result = new SpecializationInfo(null);

			return result;
		}
	}

	public unsafe struct PipelineShaderStageCreateInfo
	{
		private readonly Interop.PipelineShaderStageCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public ShaderStageFlags Stage
		{
			get
			{
				var value0 = this.instance->Stage;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Stage = value0;
			}
		}

		public string Name
		{
			get
			{
				var value0 = this.instance->Name;

				var value1 = Interop.HeapUtil.MarshalPointerToString(value0);

				return value1;
			}
			set
			{
				var value0 = value;

				var value1 = Interop.HeapUtil.MarshalStringToPointer(value0);

				this.instance->Name = value1;
			}
		}
	}

	public unsafe struct ComputePipelineCreateInfo
	{
		private readonly Interop.ComputePipelineCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public int BasePipelineIndex
		{
			get
			{
				var value0 = this.instance->BasePipelineIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BasePipelineIndex = value0;
			}
		}
	}

	public unsafe struct VertexInputBindingDescription
	{
		private readonly Interop.VertexInputBindingDescription* instance;

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
				var value0 = this.instance->Binding;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Binding = value0;
			}
		}

		public uint Stride
		{
			get
			{
				var value0 = this.instance->Stride;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Stride = value0;
			}
		}

		public VertexInputRate InputRate
		{
			get
			{
				var value0 = this.instance->InputRate;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->InputRate = value0;
			}
		}
	}

	public unsafe struct VertexInputAttributeDescription
	{
		private readonly Interop.VertexInputAttributeDescription* instance;

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
				var value0 = this.instance->Location;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Location = value0;
			}
		}

		public uint Binding
		{
			get
			{
				var value0 = this.instance->Binding;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Binding = value0;
			}
		}

		public Format Format
		{
			get
			{
				var value0 = this.instance->Format;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Format = value0;
			}
		}

		public uint Offset
		{
			get
			{
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}
	}

	public unsafe struct PipelineVertexInputStateCreateInfo
	{
		private readonly Interop.PipelineVertexInputStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct PipelineInputAssemblyStateCreateInfo
	{
		private readonly Interop.PipelineInputAssemblyStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public PrimitiveTopology Topology
		{
			get
			{
				var value0 = this.instance->Topology;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Topology = value0;
			}
		}

		public bool PrimitiveRestartEnable
		{
			get
			{
				var value0 = this.instance->PrimitiveRestartEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PrimitiveRestartEnable = value0;
			}
		}
	}

	public unsafe struct PipelineTessellationStateCreateInfo
	{
		private readonly Interop.PipelineTessellationStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public uint PatchControlPoints
		{
			get
			{
				var value0 = this.instance->PatchControlPoints;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PatchControlPoints = value0;
			}
		}
	}

	public unsafe struct PipelineViewportStateCreateInfo
	{
		private readonly Interop.PipelineViewportStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct PipelineRasterizationStateCreateInfo
	{
		private readonly Interop.PipelineRasterizationStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public bool DepthClampEnable
		{
			get
			{
				var value0 = this.instance->DepthClampEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthClampEnable = value0;
			}
		}

		public bool RasterizerDiscardEnable
		{
			get
			{
				var value0 = this.instance->RasterizerDiscardEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->RasterizerDiscardEnable = value0;
			}
		}

		public PolygonMode PolygonMode
		{
			get
			{
				var value0 = this.instance->PolygonMode;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PolygonMode = value0;
			}
		}

		public CullModeFlags CullMode
		{
			get
			{
				var value0 = this.instance->CullMode;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->CullMode = value0;
			}
		}

		public FrontFace FrontFace
		{
			get
			{
				var value0 = this.instance->FrontFace;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FrontFace = value0;
			}
		}

		public bool DepthBiasEnable
		{
			get
			{
				var value0 = this.instance->DepthBiasEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthBiasEnable = value0;
			}
		}

		public float DepthBiasConstantFactor
		{
			get
			{
				var value0 = this.instance->DepthBiasConstantFactor;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthBiasConstantFactor = value0;
			}
		}

		public float DepthBiasClamp
		{
			get
			{
				var value0 = this.instance->DepthBiasClamp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthBiasClamp = value0;
			}
		}

		public float DepthBiasSlopeFactor
		{
			get
			{
				var value0 = this.instance->DepthBiasSlopeFactor;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthBiasSlopeFactor = value0;
			}
		}

		public float LineWidth
		{
			get
			{
				var value0 = this.instance->LineWidth;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LineWidth = value0;
			}
		}
	}

	public unsafe struct PipelineMultisampleStateCreateInfo
	{
		private readonly Interop.PipelineMultisampleStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public SampleCountFlags RasterizationSamples
		{
			get
			{
				var value0 = this.instance->RasterizationSamples;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->RasterizationSamples = value0;
			}
		}

		public bool SampleShadingEnable
		{
			get
			{
				var value0 = this.instance->SampleShadingEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SampleShadingEnable = value0;
			}
		}

		public float MinSampleShading
		{
			get
			{
				var value0 = this.instance->MinSampleShading;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinSampleShading = value0;
			}
		}

		public bool AlphaToCoverageEnable
		{
			get
			{
				var value0 = this.instance->AlphaToCoverageEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AlphaToCoverageEnable = value0;
			}
		}

		public bool AlphaToOneEnable
		{
			get
			{
				var value0 = this.instance->AlphaToOneEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AlphaToOneEnable = value0;
			}
		}
	}

	public unsafe struct PipelineColorBlendAttachmentState
	{
		private readonly Interop.PipelineColorBlendAttachmentState* instance;

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
				var value0 = this.instance->BlendEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BlendEnable = value0;
			}
		}

		public BlendFactor SrcColorBlendFactor
		{
			get
			{
				var value0 = this.instance->SrcColorBlendFactor;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcColorBlendFactor = value0;
			}
		}

		public BlendFactor DstColorBlendFactor
		{
			get
			{
				var value0 = this.instance->DstColorBlendFactor;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstColorBlendFactor = value0;
			}
		}

		public BlendOp ColorBlendOp
		{
			get
			{
				var value0 = this.instance->ColorBlendOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ColorBlendOp = value0;
			}
		}

		public BlendFactor SrcAlphaBlendFactor
		{
			get
			{
				var value0 = this.instance->SrcAlphaBlendFactor;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcAlphaBlendFactor = value0;
			}
		}

		public BlendFactor DstAlphaBlendFactor
		{
			get
			{
				var value0 = this.instance->DstAlphaBlendFactor;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstAlphaBlendFactor = value0;
			}
		}

		public BlendOp AlphaBlendOp
		{
			get
			{
				var value0 = this.instance->AlphaBlendOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AlphaBlendOp = value0;
			}
		}

		public ColorComponentFlags ColorWriteMask
		{
			get
			{
				var value0 = this.instance->ColorWriteMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ColorWriteMask = value0;
			}
		}
	}

	public unsafe struct PipelineColorBlendStateCreateInfo
	{
		private readonly Interop.PipelineColorBlendStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public bool LogicOpEnable
		{
			get
			{
				var value0 = this.instance->LogicOpEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LogicOpEnable = value0;
			}
		}

		public LogicOp LogicOp
		{
			get
			{
				var value0 = this.instance->LogicOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LogicOp = value0;
			}
		}

		public float BlendConstants
		{
			get
			{
				var value0 = this.instance->BlendConstants;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BlendConstants = value0;
			}
		}
	}

	public unsafe struct PipelineDynamicStateCreateInfo
	{
		private readonly Interop.PipelineDynamicStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct StencilOpState
	{
		private readonly Interop.StencilOpState* instance;

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
				var value0 = this.instance->FailOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FailOp = value0;
			}
		}

		public StencilOp PassOp
		{
			get
			{
				var value0 = this.instance->PassOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PassOp = value0;
			}
		}

		public StencilOp DepthFailOp
		{
			get
			{
				var value0 = this.instance->DepthFailOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthFailOp = value0;
			}
		}

		public CompareOp CompareOp
		{
			get
			{
				var value0 = this.instance->CompareOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->CompareOp = value0;
			}
		}

		public uint CompareMask
		{
			get
			{
				var value0 = this.instance->CompareMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->CompareMask = value0;
			}
		}

		public uint WriteMask
		{
			get
			{
				var value0 = this.instance->WriteMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->WriteMask = value0;
			}
		}

		public uint Reference
		{
			get
			{
				var value0 = this.instance->Reference;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Reference = value0;
			}
		}
	}

	public unsafe struct PipelineDepthStencilStateCreateInfo
	{
		private readonly Interop.PipelineDepthStencilStateCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public bool DepthTestEnable
		{
			get
			{
				var value0 = this.instance->DepthTestEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthTestEnable = value0;
			}
		}

		public bool DepthWriteEnable
		{
			get
			{
				var value0 = this.instance->DepthWriteEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthWriteEnable = value0;
			}
		}

		public CompareOp DepthCompareOp
		{
			get
			{
				var value0 = this.instance->DepthCompareOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthCompareOp = value0;
			}
		}

		public bool DepthBoundsTestEnable
		{
			get
			{
				var value0 = this.instance->DepthBoundsTestEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthBoundsTestEnable = value0;
			}
		}

		public bool StencilTestEnable
		{
			get
			{
				var value0 = this.instance->StencilTestEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StencilTestEnable = value0;
			}
		}

		public float MinDepthBounds
		{
			get
			{
				var value0 = this.instance->MinDepthBounds;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinDepthBounds = value0;
			}
		}

		public float MaxDepthBounds
		{
			get
			{
				var value0 = this.instance->MaxDepthBounds;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDepthBounds = value0;
			}
		}
	}

	public unsafe struct GraphicsPipelineCreateInfo
	{
		private readonly Interop.GraphicsPipelineCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public uint Subpass
		{
			get
			{
				var value0 = this.instance->Subpass;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Subpass = value0;
			}
		}

		public int BasePipelineIndex
		{
			get
			{
				var value0 = this.instance->BasePipelineIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BasePipelineIndex = value0;
			}
		}
	}

	public unsafe struct PipelineCacheCreateInfo
	{
		private readonly Interop.PipelineCacheCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct PushConstantRange
	{
		private readonly Interop.PushConstantRange* instance;

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
				var value0 = this.instance->StageFlags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StageFlags = value0;
			}
		}

		public uint Offset
		{
			get
			{
				var value0 = this.instance->Offset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Offset = value0;
			}
		}

		public uint Size
		{
			get
			{
				var value0 = this.instance->Size;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Size = value0;
			}
		}
	}

	public unsafe struct PipelineLayoutCreateInfo
	{
		private readonly Interop.PipelineLayoutCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct SamplerCreateInfo
	{
		private readonly Interop.SamplerCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public Filter MagFilter
		{
			get
			{
				var value0 = this.instance->MagFilter;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MagFilter = value0;
			}
		}

		public Filter MinFilter
		{
			get
			{
				var value0 = this.instance->MinFilter;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinFilter = value0;
			}
		}

		public SamplerMipmapMode MipmapMode
		{
			get
			{
				var value0 = this.instance->MipmapMode;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MipmapMode = value0;
			}
		}

		public SamplerAddressMode AddressModeU
		{
			get
			{
				var value0 = this.instance->AddressModeU;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AddressModeU = value0;
			}
		}

		public SamplerAddressMode AddressModeV
		{
			get
			{
				var value0 = this.instance->AddressModeV;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AddressModeV = value0;
			}
		}

		public SamplerAddressMode AddressModeW
		{
			get
			{
				var value0 = this.instance->AddressModeW;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AddressModeW = value0;
			}
		}

		public float MipLodBias
		{
			get
			{
				var value0 = this.instance->MipLodBias;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MipLodBias = value0;
			}
		}

		public bool AnisotropyEnable
		{
			get
			{
				var value0 = this.instance->AnisotropyEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AnisotropyEnable = value0;
			}
		}

		public float MaxAnisotropy
		{
			get
			{
				var value0 = this.instance->MaxAnisotropy;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxAnisotropy = value0;
			}
		}

		public bool CompareEnable
		{
			get
			{
				var value0 = this.instance->CompareEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->CompareEnable = value0;
			}
		}

		public CompareOp CompareOp
		{
			get
			{
				var value0 = this.instance->CompareOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->CompareOp = value0;
			}
		}

		public float MinLod
		{
			get
			{
				var value0 = this.instance->MinLod;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinLod = value0;
			}
		}

		public float MaxLod
		{
			get
			{
				var value0 = this.instance->MaxLod;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxLod = value0;
			}
		}

		public BorderColor BorderColor
		{
			get
			{
				var value0 = this.instance->BorderColor;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BorderColor = value0;
			}
		}

		public bool UnnormalizedCoordinates
		{
			get
			{
				var value0 = this.instance->UnnormalizedCoordinates;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->UnnormalizedCoordinates = value0;
			}
		}
	}

	public unsafe struct CommandPoolCreateInfo
	{
		private readonly Interop.CommandPoolCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public uint QueueFamilyIndex
		{
			get
			{
				var value0 = this.instance->QueueFamilyIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->QueueFamilyIndex = value0;
			}
		}
	}

	public unsafe struct CommandBufferAllocateInfo
	{
		private readonly Interop.CommandBufferAllocateInfo* instance;

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
				var value0 = this.instance->Level;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Level = value0;
			}
		}

		public uint CommandBufferCount
		{
			get
			{
				var value0 = this.instance->CommandBufferCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->CommandBufferCount = value0;
			}
		}
	}

	public unsafe struct CommandBufferInheritanceInfo
	{
		private readonly Interop.CommandBufferInheritanceInfo* instance;

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
				var value0 = this.instance->Subpass;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Subpass = value0;
			}
		}

		public bool OcclusionQueryEnable
		{
			get
			{
				var value0 = this.instance->OcclusionQueryEnable;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->OcclusionQueryEnable = value0;
			}
		}

		public QueryControlFlags QueryFlags
		{
			get
			{
				var value0 = this.instance->QueryFlags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->QueryFlags = value0;
			}
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get
			{
				var value0 = this.instance->PipelineStatistics;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PipelineStatistics = value0;
			}
		}
	}

	public unsafe struct CommandBufferBeginInfo
	{
		private readonly Interop.CommandBufferBeginInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct RenderPassBeginInfo
	{
		private readonly Interop.RenderPassBeginInfo* instance;

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
	}

	public unsafe struct ClearDepthStencilValue
	{
		private readonly Interop.ClearDepthStencilValue* instance;

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
				var value0 = this.instance->Depth;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Depth = value0;
			}
		}

		public uint Stencil
		{
			get
			{
				var value0 = this.instance->Stencil;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Stencil = value0;
			}
		}
	}

	public unsafe struct ClearAttachment
	{
		private readonly Interop.ClearAttachment* instance;

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
				var value0 = this.instance->AspectMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AspectMask = value0;
			}
		}

		public uint ColorAttachment
		{
			get
			{
				var value0 = this.instance->ColorAttachment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ColorAttachment = value0;
			}
		}

		public ClearValue ClearValue
		{
			get
			{
				var value0 = this.instance->ClearValue;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ClearValue = value0;
			}
		}
	}

	public unsafe struct AttachmentDescription
	{
		private readonly Interop.AttachmentDescription* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public Format Format
		{
			get
			{
				var value0 = this.instance->Format;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Format = value0;
			}
		}

		public SampleCountFlags Samples
		{
			get
			{
				var value0 = this.instance->Samples;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Samples = value0;
			}
		}

		public AttachmentLoadOp LoadOp
		{
			get
			{
				var value0 = this.instance->LoadOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LoadOp = value0;
			}
		}

		public AttachmentStoreOp StoreOp
		{
			get
			{
				var value0 = this.instance->StoreOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StoreOp = value0;
			}
		}

		public AttachmentLoadOp StencilLoadOp
		{
			get
			{
				var value0 = this.instance->StencilLoadOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StencilLoadOp = value0;
			}
		}

		public AttachmentStoreOp StencilStoreOp
		{
			get
			{
				var value0 = this.instance->StencilStoreOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StencilStoreOp = value0;
			}
		}

		public ImageLayout InitialLayout
		{
			get
			{
				var value0 = this.instance->InitialLayout;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->InitialLayout = value0;
			}
		}

		public ImageLayout FinalLayout
		{
			get
			{
				var value0 = this.instance->FinalLayout;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FinalLayout = value0;
			}
		}
	}

	public unsafe struct AttachmentReference
	{
		private readonly Interop.AttachmentReference* instance;

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
				var value0 = this.instance->Attachment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Attachment = value0;
			}
		}

		public ImageLayout Layout
		{
			get
			{
				var value0 = this.instance->Layout;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Layout = value0;
			}
		}
	}

	public unsafe struct SubpassDescription
	{
		private readonly Interop.SubpassDescription* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public PipelineBindPoint PipelineBindPoint
		{
			get
			{
				var value0 = this.instance->PipelineBindPoint;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PipelineBindPoint = value0;
			}
		}
	}

	public unsafe struct SubpassDependency
	{
		private readonly Interop.SubpassDependency* instance;

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
				var value0 = this.instance->SrcSubpass;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcSubpass = value0;
			}
		}

		public uint DstSubpass
		{
			get
			{
				var value0 = this.instance->DstSubpass;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstSubpass = value0;
			}
		}

		public PipelineStageFlags SrcStageMask
		{
			get
			{
				var value0 = this.instance->SrcStageMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcStageMask = value0;
			}
		}

		public PipelineStageFlags DstStageMask
		{
			get
			{
				var value0 = this.instance->DstStageMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstStageMask = value0;
			}
		}

		public AccessFlags SrcAccessMask
		{
			get
			{
				var value0 = this.instance->SrcAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SrcAccessMask = value0;
			}
		}

		public AccessFlags DstAccessMask
		{
			get
			{
				var value0 = this.instance->DstAccessMask;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DstAccessMask = value0;
			}
		}

		public DependencyFlags DependencyFlags
		{
			get
			{
				var value0 = this.instance->DependencyFlags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DependencyFlags = value0;
			}
		}
	}

	public unsafe struct RenderPassCreateInfo
	{
		private readonly Interop.RenderPassCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct EventCreateInfo
	{
		private readonly Interop.EventCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct FenceCreateInfo
	{
		private readonly Interop.FenceCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct PhysicalDeviceFeatures
	{
		private readonly Interop.PhysicalDeviceFeatures* instance;

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
				var value0 = this.instance->RobustBufferAccess;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->RobustBufferAccess = value0;
			}
		}

		public bool FullDrawIndexUint32
		{
			get
			{
				var value0 = this.instance->FullDrawIndexUint32;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FullDrawIndexUint32 = value0;
			}
		}

		public bool ImageCubeArray
		{
			get
			{
				var value0 = this.instance->ImageCubeArray;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ImageCubeArray = value0;
			}
		}

		public bool IndependentBlend
		{
			get
			{
				var value0 = this.instance->IndependentBlend;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->IndependentBlend = value0;
			}
		}

		public bool GeometryShader
		{
			get
			{
				var value0 = this.instance->GeometryShader;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->GeometryShader = value0;
			}
		}

		public bool TessellationShader
		{
			get
			{
				var value0 = this.instance->TessellationShader;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->TessellationShader = value0;
			}
		}

		public bool SampleRateShading
		{
			get
			{
				var value0 = this.instance->SampleRateShading;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SampleRateShading = value0;
			}
		}

		public bool DualSrcBlend
		{
			get
			{
				var value0 = this.instance->DualSrcBlend;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DualSrcBlend = value0;
			}
		}

		public bool LogicOp
		{
			get
			{
				var value0 = this.instance->LogicOp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LogicOp = value0;
			}
		}

		public bool MultiDrawIndirect
		{
			get
			{
				var value0 = this.instance->MultiDrawIndirect;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MultiDrawIndirect = value0;
			}
		}

		public bool DrawIndirectFirstInstance
		{
			get
			{
				var value0 = this.instance->DrawIndirectFirstInstance;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DrawIndirectFirstInstance = value0;
			}
		}

		public bool DepthClamp
		{
			get
			{
				var value0 = this.instance->DepthClamp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthClamp = value0;
			}
		}

		public bool DepthBiasClamp
		{
			get
			{
				var value0 = this.instance->DepthBiasClamp;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthBiasClamp = value0;
			}
		}

		public bool FillModeNonSolid
		{
			get
			{
				var value0 = this.instance->FillModeNonSolid;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FillModeNonSolid = value0;
			}
		}

		public bool DepthBounds
		{
			get
			{
				var value0 = this.instance->DepthBounds;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DepthBounds = value0;
			}
		}

		public bool WideLines
		{
			get
			{
				var value0 = this.instance->WideLines;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->WideLines = value0;
			}
		}

		public bool LargePoints
		{
			get
			{
				var value0 = this.instance->LargePoints;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LargePoints = value0;
			}
		}

		public bool AlphaToOne
		{
			get
			{
				var value0 = this.instance->AlphaToOne;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->AlphaToOne = value0;
			}
		}

		public bool MultiViewport
		{
			get
			{
				var value0 = this.instance->MultiViewport;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MultiViewport = value0;
			}
		}

		public bool SamplerAnisotropy
		{
			get
			{
				var value0 = this.instance->SamplerAnisotropy;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SamplerAnisotropy = value0;
			}
		}

		public bool TextureCompressionETC2
		{
			get
			{
				var value0 = this.instance->TextureCompressionETC2;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->TextureCompressionETC2 = value0;
			}
		}

		public bool TextureCompressionASTC_LDR
		{
			get
			{
				var value0 = this.instance->TextureCompressionASTC_LDR;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->TextureCompressionASTC_LDR = value0;
			}
		}

		public bool TextureCompressionBC
		{
			get
			{
				var value0 = this.instance->TextureCompressionBC;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->TextureCompressionBC = value0;
			}
		}

		public bool OcclusionQueryPrecise
		{
			get
			{
				var value0 = this.instance->OcclusionQueryPrecise;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->OcclusionQueryPrecise = value0;
			}
		}

		public bool PipelineStatisticsQuery
		{
			get
			{
				var value0 = this.instance->PipelineStatisticsQuery;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PipelineStatisticsQuery = value0;
			}
		}

		public bool VertexPipelineStoresAndAtomics
		{
			get
			{
				var value0 = this.instance->VertexPipelineStoresAndAtomics;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->VertexPipelineStoresAndAtomics = value0;
			}
		}

		public bool FragmentStoresAndAtomics
		{
			get
			{
				var value0 = this.instance->FragmentStoresAndAtomics;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FragmentStoresAndAtomics = value0;
			}
		}

		public bool ShaderTessellationAndGeometryPointSize
		{
			get
			{
				var value0 = this.instance->ShaderTessellationAndGeometryPointSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderTessellationAndGeometryPointSize = value0;
			}
		}

		public bool ShaderImageGatherExtended
		{
			get
			{
				var value0 = this.instance->ShaderImageGatherExtended;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderImageGatherExtended = value0;
			}
		}

		public bool ShaderStorageImageExtendedFormats
		{
			get
			{
				var value0 = this.instance->ShaderStorageImageExtendedFormats;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderStorageImageExtendedFormats = value0;
			}
		}

		public bool ShaderStorageImageMultisample
		{
			get
			{
				var value0 = this.instance->ShaderStorageImageMultisample;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderStorageImageMultisample = value0;
			}
		}

		public bool ShaderStorageImageReadWithoutFormat
		{
			get
			{
				var value0 = this.instance->ShaderStorageImageReadWithoutFormat;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderStorageImageReadWithoutFormat = value0;
			}
		}

		public bool ShaderStorageImageWriteWithoutFormat
		{
			get
			{
				var value0 = this.instance->ShaderStorageImageWriteWithoutFormat;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderStorageImageWriteWithoutFormat = value0;
			}
		}

		public bool ShaderUniformBufferArrayDynamicIndexing
		{
			get
			{
				var value0 = this.instance->ShaderUniformBufferArrayDynamicIndexing;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderUniformBufferArrayDynamicIndexing = value0;
			}
		}

		public bool ShaderSampledImageArrayDynamicIndexing
		{
			get
			{
				var value0 = this.instance->ShaderSampledImageArrayDynamicIndexing;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderSampledImageArrayDynamicIndexing = value0;
			}
		}

		public bool ShaderStorageBufferArrayDynamicIndexing
		{
			get
			{
				var value0 = this.instance->ShaderStorageBufferArrayDynamicIndexing;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderStorageBufferArrayDynamicIndexing = value0;
			}
		}

		public bool ShaderStorageImageArrayDynamicIndexing
		{
			get
			{
				var value0 = this.instance->ShaderStorageImageArrayDynamicIndexing;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderStorageImageArrayDynamicIndexing = value0;
			}
		}

		public bool ShaderClipDistance
		{
			get
			{
				var value0 = this.instance->ShaderClipDistance;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderClipDistance = value0;
			}
		}

		public bool ShaderCullDistance
		{
			get
			{
				var value0 = this.instance->ShaderCullDistance;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderCullDistance = value0;
			}
		}

		public bool ShaderFloat64
		{
			get
			{
				var value0 = this.instance->ShaderFloat64;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderFloat64 = value0;
			}
		}

		public bool ShaderInt64
		{
			get
			{
				var value0 = this.instance->ShaderInt64;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderInt64 = value0;
			}
		}

		public bool ShaderInt16
		{
			get
			{
				var value0 = this.instance->ShaderInt16;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderInt16 = value0;
			}
		}

		public bool ShaderResourceResidency
		{
			get
			{
				var value0 = this.instance->ShaderResourceResidency;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderResourceResidency = value0;
			}
		}

		public bool ShaderResourceMinLod
		{
			get
			{
				var value0 = this.instance->ShaderResourceMinLod;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ShaderResourceMinLod = value0;
			}
		}

		public bool SparseBinding
		{
			get
			{
				var value0 = this.instance->SparseBinding;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseBinding = value0;
			}
		}

		public bool SparseResidencyBuffer
		{
			get
			{
				var value0 = this.instance->SparseResidencyBuffer;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidencyBuffer = value0;
			}
		}

		public bool SparseResidencyImage2D
		{
			get
			{
				var value0 = this.instance->SparseResidencyImage2D;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidencyImage2D = value0;
			}
		}

		public bool SparseResidencyImage3D
		{
			get
			{
				var value0 = this.instance->SparseResidencyImage3D;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidencyImage3D = value0;
			}
		}

		public bool SparseResidency2Samples
		{
			get
			{
				var value0 = this.instance->SparseResidency2Samples;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidency2Samples = value0;
			}
		}

		public bool SparseResidency4Samples
		{
			get
			{
				var value0 = this.instance->SparseResidency4Samples;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidency4Samples = value0;
			}
		}

		public bool SparseResidency8Samples
		{
			get
			{
				var value0 = this.instance->SparseResidency8Samples;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidency8Samples = value0;
			}
		}

		public bool SparseResidency16Samples
		{
			get
			{
				var value0 = this.instance->SparseResidency16Samples;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidency16Samples = value0;
			}
		}

		public bool SparseResidencyAliased
		{
			get
			{
				var value0 = this.instance->SparseResidencyAliased;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseResidencyAliased = value0;
			}
		}

		public bool VariableMultisampleRate
		{
			get
			{
				var value0 = this.instance->VariableMultisampleRate;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->VariableMultisampleRate = value0;
			}
		}

		public bool InheritedQueries
		{
			get
			{
				var value0 = this.instance->InheritedQueries;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->InheritedQueries = value0;
			}
		}
	}

	public unsafe struct PhysicalDeviceSparseProperties
	{
		private readonly Interop.PhysicalDeviceSparseProperties* instance;

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
				var value0 = this.instance->ResidencyStandard2DBlockShape;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ResidencyStandard2DBlockShape = value0;
			}
		}

		public bool ResidencyStandard2DMultisampleBlockShape
		{
			get
			{
				var value0 = this.instance->ResidencyStandard2DMultisampleBlockShape;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ResidencyStandard2DMultisampleBlockShape = value0;
			}
		}

		public bool ResidencyStandard3DBlockShape
		{
			get
			{
				var value0 = this.instance->ResidencyStandard3DBlockShape;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ResidencyStandard3DBlockShape = value0;
			}
		}

		public bool ResidencyAlignedMipSize
		{
			get
			{
				var value0 = this.instance->ResidencyAlignedMipSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ResidencyAlignedMipSize = value0;
			}
		}

		public bool ResidencyNonResidentStrict
		{
			get
			{
				var value0 = this.instance->ResidencyNonResidentStrict;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ResidencyNonResidentStrict = value0;
			}
		}
	}

	public unsafe struct PhysicalDeviceLimits
	{
		private readonly Interop.PhysicalDeviceLimits* instance;

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
				var value0 = this.instance->MaxImageDimension1D;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxImageDimension1D = value0;
			}
		}

		public uint MaxImageDimension2D
		{
			get
			{
				var value0 = this.instance->MaxImageDimension2D;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxImageDimension2D = value0;
			}
		}

		public uint MaxImageDimension3D
		{
			get
			{
				var value0 = this.instance->MaxImageDimension3D;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxImageDimension3D = value0;
			}
		}

		public uint MaxImageDimensionCube
		{
			get
			{
				var value0 = this.instance->MaxImageDimensionCube;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxImageDimensionCube = value0;
			}
		}

		public uint MaxImageArrayLayers
		{
			get
			{
				var value0 = this.instance->MaxImageArrayLayers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxImageArrayLayers = value0;
			}
		}

		public uint MaxTexelBufferElements
		{
			get
			{
				var value0 = this.instance->MaxTexelBufferElements;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTexelBufferElements = value0;
			}
		}

		public uint MaxUniformBufferRange
		{
			get
			{
				var value0 = this.instance->MaxUniformBufferRange;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxUniformBufferRange = value0;
			}
		}

		public uint MaxStorageBufferRange
		{
			get
			{
				var value0 = this.instance->MaxStorageBufferRange;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxStorageBufferRange = value0;
			}
		}

		public uint MaxPushConstantsSize
		{
			get
			{
				var value0 = this.instance->MaxPushConstantsSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPushConstantsSize = value0;
			}
		}

		public uint MaxMemoryAllocationCount
		{
			get
			{
				var value0 = this.instance->MaxMemoryAllocationCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxMemoryAllocationCount = value0;
			}
		}

		public uint MaxSamplerAllocationCount
		{
			get
			{
				var value0 = this.instance->MaxSamplerAllocationCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxSamplerAllocationCount = value0;
			}
		}

		public ulong BufferImageGranularity
		{
			get
			{
				var value0 = this.instance->BufferImageGranularity;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->BufferImageGranularity = value0;
			}
		}

		public ulong SparseAddressSpaceSize
		{
			get
			{
				var value0 = this.instance->SparseAddressSpaceSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SparseAddressSpaceSize = value0;
			}
		}

		public uint MaxBoundDescriptorSets
		{
			get
			{
				var value0 = this.instance->MaxBoundDescriptorSets;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxBoundDescriptorSets = value0;
			}
		}

		public uint MaxPerStageDescriptorSamplers
		{
			get
			{
				var value0 = this.instance->MaxPerStageDescriptorSamplers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPerStageDescriptorSamplers = value0;
			}
		}

		public uint MaxPerStageDescriptorUniformBuffers
		{
			get
			{
				var value0 = this.instance->MaxPerStageDescriptorUniformBuffers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPerStageDescriptorUniformBuffers = value0;
			}
		}

		public uint MaxPerStageDescriptorStorageBuffers
		{
			get
			{
				var value0 = this.instance->MaxPerStageDescriptorStorageBuffers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPerStageDescriptorStorageBuffers = value0;
			}
		}

		public uint MaxPerStageDescriptorSampledImages
		{
			get
			{
				var value0 = this.instance->MaxPerStageDescriptorSampledImages;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPerStageDescriptorSampledImages = value0;
			}
		}

		public uint MaxPerStageDescriptorStorageImages
		{
			get
			{
				var value0 = this.instance->MaxPerStageDescriptorStorageImages;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPerStageDescriptorStorageImages = value0;
			}
		}

		public uint MaxPerStageDescriptorInputAttachments
		{
			get
			{
				var value0 = this.instance->MaxPerStageDescriptorInputAttachments;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPerStageDescriptorInputAttachments = value0;
			}
		}

		public uint MaxPerStageResources
		{
			get
			{
				var value0 = this.instance->MaxPerStageResources;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxPerStageResources = value0;
			}
		}

		public uint MaxDescriptorSetSamplers
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetSamplers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetSamplers = value0;
			}
		}

		public uint MaxDescriptorSetUniformBuffers
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetUniformBuffers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetUniformBuffers = value0;
			}
		}

		public uint MaxDescriptorSetUniformBuffersDynamic
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetUniformBuffersDynamic;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetUniformBuffersDynamic = value0;
			}
		}

		public uint MaxDescriptorSetStorageBuffers
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetStorageBuffers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetStorageBuffers = value0;
			}
		}

		public uint MaxDescriptorSetStorageBuffersDynamic
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetStorageBuffersDynamic;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetStorageBuffersDynamic = value0;
			}
		}

		public uint MaxDescriptorSetSampledImages
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetSampledImages;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetSampledImages = value0;
			}
		}

		public uint MaxDescriptorSetStorageImages
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetStorageImages;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetStorageImages = value0;
			}
		}

		public uint MaxDescriptorSetInputAttachments
		{
			get
			{
				var value0 = this.instance->MaxDescriptorSetInputAttachments;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDescriptorSetInputAttachments = value0;
			}
		}

		public uint MaxVertexInputAttributes
		{
			get
			{
				var value0 = this.instance->MaxVertexInputAttributes;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxVertexInputAttributes = value0;
			}
		}

		public uint MaxVertexInputBindings
		{
			get
			{
				var value0 = this.instance->MaxVertexInputBindings;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxVertexInputBindings = value0;
			}
		}

		public uint MaxVertexInputAttributeOffset
		{
			get
			{
				var value0 = this.instance->MaxVertexInputAttributeOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxVertexInputAttributeOffset = value0;
			}
		}

		public uint MaxVertexInputBindingStride
		{
			get
			{
				var value0 = this.instance->MaxVertexInputBindingStride;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxVertexInputBindingStride = value0;
			}
		}

		public uint MaxVertexOutputComponents
		{
			get
			{
				var value0 = this.instance->MaxVertexOutputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxVertexOutputComponents = value0;
			}
		}

		public uint MaxTessellationGenerationLevel
		{
			get
			{
				var value0 = this.instance->MaxTessellationGenerationLevel;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationGenerationLevel = value0;
			}
		}

		public uint MaxTessellationPatchSize
		{
			get
			{
				var value0 = this.instance->MaxTessellationPatchSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationPatchSize = value0;
			}
		}

		public uint MaxTessellationControlPerVertexInputComponents
		{
			get
			{
				var value0 = this.instance->MaxTessellationControlPerVertexInputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationControlPerVertexInputComponents = value0;
			}
		}

		public uint MaxTessellationControlPerVertexOutputComponents
		{
			get
			{
				var value0 = this.instance->MaxTessellationControlPerVertexOutputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationControlPerVertexOutputComponents = value0;
			}
		}

		public uint MaxTessellationControlPerPatchOutputComponents
		{
			get
			{
				var value0 = this.instance->MaxTessellationControlPerPatchOutputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationControlPerPatchOutputComponents = value0;
			}
		}

		public uint MaxTessellationControlTotalOutputComponents
		{
			get
			{
				var value0 = this.instance->MaxTessellationControlTotalOutputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationControlTotalOutputComponents = value0;
			}
		}

		public uint MaxTessellationEvaluationInputComponents
		{
			get
			{
				var value0 = this.instance->MaxTessellationEvaluationInputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationEvaluationInputComponents = value0;
			}
		}

		public uint MaxTessellationEvaluationOutputComponents
		{
			get
			{
				var value0 = this.instance->MaxTessellationEvaluationOutputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTessellationEvaluationOutputComponents = value0;
			}
		}

		public uint MaxGeometryShaderInvocations
		{
			get
			{
				var value0 = this.instance->MaxGeometryShaderInvocations;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxGeometryShaderInvocations = value0;
			}
		}

		public uint MaxGeometryInputComponents
		{
			get
			{
				var value0 = this.instance->MaxGeometryInputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxGeometryInputComponents = value0;
			}
		}

		public uint MaxGeometryOutputComponents
		{
			get
			{
				var value0 = this.instance->MaxGeometryOutputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxGeometryOutputComponents = value0;
			}
		}

		public uint MaxGeometryOutputVertices
		{
			get
			{
				var value0 = this.instance->MaxGeometryOutputVertices;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxGeometryOutputVertices = value0;
			}
		}

		public uint MaxGeometryTotalOutputComponents
		{
			get
			{
				var value0 = this.instance->MaxGeometryTotalOutputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxGeometryTotalOutputComponents = value0;
			}
		}

		public uint MaxFragmentInputComponents
		{
			get
			{
				var value0 = this.instance->MaxFragmentInputComponents;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxFragmentInputComponents = value0;
			}
		}

		public uint MaxFragmentOutputAttachments
		{
			get
			{
				var value0 = this.instance->MaxFragmentOutputAttachments;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxFragmentOutputAttachments = value0;
			}
		}

		public uint MaxFragmentDualSrcAttachments
		{
			get
			{
				var value0 = this.instance->MaxFragmentDualSrcAttachments;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxFragmentDualSrcAttachments = value0;
			}
		}

		public uint MaxFragmentCombinedOutputResources
		{
			get
			{
				var value0 = this.instance->MaxFragmentCombinedOutputResources;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxFragmentCombinedOutputResources = value0;
			}
		}

		public uint MaxComputeSharedMemorySize
		{
			get
			{
				var value0 = this.instance->MaxComputeSharedMemorySize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxComputeSharedMemorySize = value0;
			}
		}

		public uint MaxComputeWorkGroupCount
		{
			get
			{
				var value0 = this.instance->MaxComputeWorkGroupCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxComputeWorkGroupCount = value0;
			}
		}

		public uint MaxComputeWorkGroupInvocations
		{
			get
			{
				var value0 = this.instance->MaxComputeWorkGroupInvocations;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxComputeWorkGroupInvocations = value0;
			}
		}

		public uint MaxComputeWorkGroupSize
		{
			get
			{
				var value0 = this.instance->MaxComputeWorkGroupSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxComputeWorkGroupSize = value0;
			}
		}

		public uint SubPixelPrecisionBits
		{
			get
			{
				var value0 = this.instance->SubPixelPrecisionBits;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SubPixelPrecisionBits = value0;
			}
		}

		public uint SubTexelPrecisionBits
		{
			get
			{
				var value0 = this.instance->SubTexelPrecisionBits;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SubTexelPrecisionBits = value0;
			}
		}

		public uint MipmapPrecisionBits
		{
			get
			{
				var value0 = this.instance->MipmapPrecisionBits;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MipmapPrecisionBits = value0;
			}
		}

		public uint MaxDrawIndexedIndexValue
		{
			get
			{
				var value0 = this.instance->MaxDrawIndexedIndexValue;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDrawIndexedIndexValue = value0;
			}
		}

		public uint MaxDrawIndirectCount
		{
			get
			{
				var value0 = this.instance->MaxDrawIndirectCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxDrawIndirectCount = value0;
			}
		}

		public float MaxSamplerLodBias
		{
			get
			{
				var value0 = this.instance->MaxSamplerLodBias;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxSamplerLodBias = value0;
			}
		}

		public float MaxSamplerAnisotropy
		{
			get
			{
				var value0 = this.instance->MaxSamplerAnisotropy;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxSamplerAnisotropy = value0;
			}
		}

		public uint MaxViewports
		{
			get
			{
				var value0 = this.instance->MaxViewports;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxViewports = value0;
			}
		}

		public uint MaxViewportDimensions
		{
			get
			{
				var value0 = this.instance->MaxViewportDimensions;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxViewportDimensions = value0;
			}
		}

		public float ViewportBoundsRange
		{
			get
			{
				var value0 = this.instance->ViewportBoundsRange;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ViewportBoundsRange = value0;
			}
		}

		public uint ViewportSubPixelBits
		{
			get
			{
				var value0 = this.instance->ViewportSubPixelBits;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->ViewportSubPixelBits = value0;
			}
		}

		public UIntPtr MinMemoryMapAlignment
		{
			get
			{
				var value0 = this.instance->MinMemoryMapAlignment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinMemoryMapAlignment = value0;
			}
		}

		public ulong MinTexelBufferOffsetAlignment
		{
			get
			{
				var value0 = this.instance->MinTexelBufferOffsetAlignment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinTexelBufferOffsetAlignment = value0;
			}
		}

		public ulong MinUniformBufferOffsetAlignment
		{
			get
			{
				var value0 = this.instance->MinUniformBufferOffsetAlignment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinUniformBufferOffsetAlignment = value0;
			}
		}

		public ulong MinStorageBufferOffsetAlignment
		{
			get
			{
				var value0 = this.instance->MinStorageBufferOffsetAlignment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinStorageBufferOffsetAlignment = value0;
			}
		}

		public int MinTexelOffset
		{
			get
			{
				var value0 = this.instance->MinTexelOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinTexelOffset = value0;
			}
		}

		public uint MaxTexelOffset
		{
			get
			{
				var value0 = this.instance->MaxTexelOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTexelOffset = value0;
			}
		}

		public int MinTexelGatherOffset
		{
			get
			{
				var value0 = this.instance->MinTexelGatherOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinTexelGatherOffset = value0;
			}
		}

		public uint MaxTexelGatherOffset
		{
			get
			{
				var value0 = this.instance->MaxTexelGatherOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxTexelGatherOffset = value0;
			}
		}

		public float MinInterpolationOffset
		{
			get
			{
				var value0 = this.instance->MinInterpolationOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MinInterpolationOffset = value0;
			}
		}

		public float MaxInterpolationOffset
		{
			get
			{
				var value0 = this.instance->MaxInterpolationOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxInterpolationOffset = value0;
			}
		}

		public uint SubPixelInterpolationOffsetBits
		{
			get
			{
				var value0 = this.instance->SubPixelInterpolationOffsetBits;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SubPixelInterpolationOffsetBits = value0;
			}
		}

		public uint MaxFramebufferWidth
		{
			get
			{
				var value0 = this.instance->MaxFramebufferWidth;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxFramebufferWidth = value0;
			}
		}

		public uint MaxFramebufferHeight
		{
			get
			{
				var value0 = this.instance->MaxFramebufferHeight;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxFramebufferHeight = value0;
			}
		}

		public uint MaxFramebufferLayers
		{
			get
			{
				var value0 = this.instance->MaxFramebufferLayers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxFramebufferLayers = value0;
			}
		}

		public SampleCountFlags FramebufferColorSampleCounts
		{
			get
			{
				var value0 = this.instance->FramebufferColorSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FramebufferColorSampleCounts = value0;
			}
		}

		public SampleCountFlags FramebufferDepthSampleCounts
		{
			get
			{
				var value0 = this.instance->FramebufferDepthSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FramebufferDepthSampleCounts = value0;
			}
		}

		public SampleCountFlags FramebufferStencilSampleCounts
		{
			get
			{
				var value0 = this.instance->FramebufferStencilSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FramebufferStencilSampleCounts = value0;
			}
		}

		public SampleCountFlags FramebufferNoAttachmentsSampleCounts
		{
			get
			{
				var value0 = this.instance->FramebufferNoAttachmentsSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FramebufferNoAttachmentsSampleCounts = value0;
			}
		}

		public uint MaxColorAttachments
		{
			get
			{
				var value0 = this.instance->MaxColorAttachments;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxColorAttachments = value0;
			}
		}

		public SampleCountFlags SampledImageColorSampleCounts
		{
			get
			{
				var value0 = this.instance->SampledImageColorSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SampledImageColorSampleCounts = value0;
			}
		}

		public SampleCountFlags SampledImageIntegerSampleCounts
		{
			get
			{
				var value0 = this.instance->SampledImageIntegerSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SampledImageIntegerSampleCounts = value0;
			}
		}

		public SampleCountFlags SampledImageDepthSampleCounts
		{
			get
			{
				var value0 = this.instance->SampledImageDepthSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SampledImageDepthSampleCounts = value0;
			}
		}

		public SampleCountFlags SampledImageStencilSampleCounts
		{
			get
			{
				var value0 = this.instance->SampledImageStencilSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->SampledImageStencilSampleCounts = value0;
			}
		}

		public SampleCountFlags StorageImageSampleCounts
		{
			get
			{
				var value0 = this.instance->StorageImageSampleCounts;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StorageImageSampleCounts = value0;
			}
		}

		public uint MaxSampleMaskWords
		{
			get
			{
				var value0 = this.instance->MaxSampleMaskWords;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxSampleMaskWords = value0;
			}
		}

		public bool TimestampComputeAndGraphics
		{
			get
			{
				var value0 = this.instance->TimestampComputeAndGraphics;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->TimestampComputeAndGraphics = value0;
			}
		}

		public float TimestampPeriod
		{
			get
			{
				var value0 = this.instance->TimestampPeriod;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->TimestampPeriod = value0;
			}
		}

		public uint MaxClipDistances
		{
			get
			{
				var value0 = this.instance->MaxClipDistances;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxClipDistances = value0;
			}
		}

		public uint MaxCullDistances
		{
			get
			{
				var value0 = this.instance->MaxCullDistances;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxCullDistances = value0;
			}
		}

		public uint MaxCombinedClipAndCullDistances
		{
			get
			{
				var value0 = this.instance->MaxCombinedClipAndCullDistances;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->MaxCombinedClipAndCullDistances = value0;
			}
		}

		public uint DiscreteQueuePriorities
		{
			get
			{
				var value0 = this.instance->DiscreteQueuePriorities;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->DiscreteQueuePriorities = value0;
			}
		}

		public float PointSizeRange
		{
			get
			{
				var value0 = this.instance->PointSizeRange;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PointSizeRange = value0;
			}
		}

		public float LineWidthRange
		{
			get
			{
				var value0 = this.instance->LineWidthRange;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LineWidthRange = value0;
			}
		}

		public float PointSizeGranularity
		{
			get
			{
				var value0 = this.instance->PointSizeGranularity;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PointSizeGranularity = value0;
			}
		}

		public float LineWidthGranularity
		{
			get
			{
				var value0 = this.instance->LineWidthGranularity;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->LineWidthGranularity = value0;
			}
		}

		public bool StrictLines
		{
			get
			{
				var value0 = this.instance->StrictLines;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StrictLines = value0;
			}
		}

		public bool StandardSampleLocations
		{
			get
			{
				var value0 = this.instance->StandardSampleLocations;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->StandardSampleLocations = value0;
			}
		}

		public ulong OptimalBufferCopyOffsetAlignment
		{
			get
			{
				var value0 = this.instance->OptimalBufferCopyOffsetAlignment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->OptimalBufferCopyOffsetAlignment = value0;
			}
		}

		public ulong OptimalBufferCopyRowPitchAlignment
		{
			get
			{
				var value0 = this.instance->OptimalBufferCopyRowPitchAlignment;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->OptimalBufferCopyRowPitchAlignment = value0;
			}
		}

		public ulong NonCoherentAtomSize
		{
			get
			{
				var value0 = this.instance->NonCoherentAtomSize;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->NonCoherentAtomSize = value0;
			}
		}
	}

	public unsafe struct SemaphoreCreateInfo
	{
		private readonly Interop.SemaphoreCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}
	}

	public unsafe struct QueryPoolCreateInfo
	{
		private readonly Interop.QueryPoolCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public QueryType QueryType
		{
			get
			{
				var value0 = this.instance->QueryType;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->QueryType = value0;
			}
		}

		public uint QueryCount
		{
			get
			{
				var value0 = this.instance->QueryCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->QueryCount = value0;
			}
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get
			{
				var value0 = this.instance->PipelineStatistics;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->PipelineStatistics = value0;
			}
		}
	}

	public unsafe struct FramebufferCreateInfo
	{
		private readonly Interop.FramebufferCreateInfo* instance;

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
				var value0 = this.instance->Flags;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Flags = value0;
			}
		}

		public uint Width
		{
			get
			{
				var value0 = this.instance->Width;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Width = value0;
			}
		}

		public uint Height
		{
			get
			{
				var value0 = this.instance->Height;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Height = value0;
			}
		}

		public uint Layers
		{
			get
			{
				var value0 = this.instance->Layers;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Layers = value0;
			}
		}
	}

	public unsafe struct DrawIndirectCommand
	{
		private readonly Interop.DrawIndirectCommand* instance;

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
				var value0 = this.instance->VertexCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->VertexCount = value0;
			}
		}

		public uint InstanceCount
		{
			get
			{
				var value0 = this.instance->InstanceCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->InstanceCount = value0;
			}
		}

		public uint FirstVertex
		{
			get
			{
				var value0 = this.instance->FirstVertex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FirstVertex = value0;
			}
		}

		public uint FirstInstance
		{
			get
			{
				var value0 = this.instance->FirstInstance;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FirstInstance = value0;
			}
		}
	}

	public unsafe struct DrawIndexedIndirectCommand
	{
		private readonly Interop.DrawIndexedIndirectCommand* instance;

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
				var value0 = this.instance->IndexCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->IndexCount = value0;
			}
		}

		public uint InstanceCount
		{
			get
			{
				var value0 = this.instance->InstanceCount;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->InstanceCount = value0;
			}
		}

		public uint FirstIndex
		{
			get
			{
				var value0 = this.instance->FirstIndex;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FirstIndex = value0;
			}
		}

		public int VertexOffset
		{
			get
			{
				var value0 = this.instance->VertexOffset;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->VertexOffset = value0;
			}
		}

		public uint FirstInstance
		{
			get
			{
				var value0 = this.instance->FirstInstance;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->FirstInstance = value0;
			}
		}
	}

	public unsafe struct DispatchIndirectCommand
	{
		private readonly Interop.DispatchIndirectCommand* instance;

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
				var value0 = this.instance->X;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->X = value0;
			}
		}

		public uint Y
		{
			get
			{
				var value0 = this.instance->Y;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Y = value0;
			}
		}

		public uint Z
		{
			get
			{
				var value0 = this.instance->Z;

				return value0;
			}
			set
			{
				var value0 = value;

				this.instance->Z = value0;
			}
		}
	}

	public unsafe struct SubmitInfo
	{
		private readonly Interop.SubmitInfo* instance;

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
	}
}
