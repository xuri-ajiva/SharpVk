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

	public class AllocationCallbacks
	{
		public IntPtr UserData
		{
			get;
			set;
		}

        internal unsafe Interop.AllocationCallbacks Pack()
        {
            var result = new Interop.AllocationCallbacks();
			result.UserData = this.UserData.ToPointer();

            return result;
        }

		internal unsafe Interop.AllocationCallbacks* MarshalTo()
        {
            return (Interop.AllocationCallbacks*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

	public class ApplicationInfo
	{
		public string ApplicationName
		{
			get;
			set;
		}

		public Version ApplicationVersion
		{
			get;
			set;
		}

		public string EngineName
		{
			get;
			set;
		}

		public Version EngineVersion
		{
			get;
			set;
		}

		public Version ApiVersion
		{
			get;
			set;
		}

        internal unsafe Interop.ApplicationInfo Pack()
        {
            var result = new Interop.ApplicationInfo();
			result.SType = StructureType.ApplicationInfo;
			result.ApplicationName = Interop.HeapUtil.MarshalTo(this.ApplicationName);
			result.EngineName = Interop.HeapUtil.MarshalTo(this.EngineName);
			result.ApplicationVersion = this.ApplicationVersion;
			result.EngineVersion = this.EngineVersion;
			result.ApiVersion = this.ApiVersion;

            return result;
        }

		internal unsafe Interop.ApplicationInfo* MarshalTo()
        {
            return (Interop.ApplicationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

	public class BufferMemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}

		public Buffer Buffer
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

        internal unsafe Interop.BufferMemoryBarrier Pack()
        {
            var result = new Interop.BufferMemoryBarrier();
			result.SType = StructureType.BufferMemoryBarrier;
			result.Buffer = this.Buffer == null ? Interop.Buffer.Null : this.Buffer.MarshalTo();
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;
			result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
			result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
			result.Offset = this.Offset;
			result.Size = this.Size;

            return result;
        }

		internal unsafe Interop.BufferMemoryBarrier* MarshalTo()
        {
            return (Interop.BufferMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

	public class ImageMemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
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

		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}

		public Image Image
		{
			get;
			set;
		}

		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}

        internal unsafe Interop.ImageMemoryBarrier Pack()
        {
            var result = new Interop.ImageMemoryBarrier();
			result.SType = StructureType.ImageMemoryBarrier;
			result.Image = this.Image == null ? Interop.Image.Null : this.Image.MarshalTo();
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;
			result.OldLayout = this.OldLayout;
			result.NewLayout = this.NewLayout;
			result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
			result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
			result.SubresourceRange = this.SubresourceRange;

            return result;
        }

		internal unsafe Interop.ImageMemoryBarrier* MarshalTo()
        {
            return (Interop.ImageMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

	public class InstanceCreateInfo
	{
		public InstanceCreateFlags Flags
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

        internal unsafe Interop.InstanceCreateInfo Pack()
        {
            var result = new Interop.InstanceCreateInfo();
			result.SType = StructureType.InstanceCreateInfo;
			result.ApplicationInfo = this.ApplicationInfo == null ? null : this.ApplicationInfo.MarshalTo();
			result.EnabledLayerCount = this.EnabledLayerNames == null ? 0 : (uint)this.EnabledLayerNames.Length;
			result.EnabledLayerNames = this.EnabledLayerNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
			result.EnabledExtensionCount = this.EnabledExtensionNames == null ? 0 : (uint)this.EnabledExtensionNames.Length;
			result.EnabledExtensionNames = this.EnabledExtensionNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.InstanceCreateInfo* MarshalTo()
        {
            return (Interop.InstanceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

	public class MemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

        internal unsafe Interop.MemoryBarrier Pack()
        {
            var result = new Interop.MemoryBarrier();
			result.SType = StructureType.MemoryBarrier;
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;

            return result;
        }

		internal unsafe Interop.MemoryBarrier* MarshalTo()
        {
            return (Interop.MemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
}