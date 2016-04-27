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

namespace SharpVk.Interop
{

	public unsafe struct AllocationCallbacks
	{
		public void* UserData;
		public IntPtr PfnAllocation;
		public IntPtr PfnReallocation;
		public IntPtr PfnFree;
		public IntPtr PfnInternalAllocation;
		public IntPtr PfnInternalFree;
	}

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

	public unsafe struct MemoryBarrier
	{
		public StructureType SType;
		public void* Next;
		public AccessFlags SourceAccessMask;
		public AccessFlags DestinationAccessMask;
	}
}