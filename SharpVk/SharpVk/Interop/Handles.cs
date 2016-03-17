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
	public struct Instance
	{
		public IntPtr Handle;
	}

	public struct PhysicalDevice
	{
		public IntPtr Handle;
	}

	public struct Device
	{
		public IntPtr Handle;
	}

	public struct Queue
	{
		public IntPtr Handle;
	}

	public struct CommandBuffer
	{
		public IntPtr Handle;
	}

	public struct DeviceMemory
	{
		public IntPtr Handle;
	}

	public struct CommandPool
	{
		public IntPtr Handle;
	}

	public struct Buffer
	{
		public IntPtr Handle;
	}

	public struct BufferView
	{
		public IntPtr Handle;
	}

	public struct Image
	{
		public IntPtr Handle;
	}

	public struct ImageView
	{
		public IntPtr Handle;
	}

	public struct ShaderModule
	{
		public IntPtr Handle;
	}

	public struct Pipeline
	{
		public IntPtr Handle;
	}

	public struct PipelineLayout
	{
		public IntPtr Handle;
	}

	public struct Sampler
	{
		public IntPtr Handle;
	}

	public struct DescriptorSet
	{
		public IntPtr Handle;
	}

	public struct DescriptorSetLayout
	{
		public IntPtr Handle;
	}

	public struct DescriptorPool
	{
		public IntPtr Handle;
	}

	public struct Fence
	{
		public IntPtr Handle;
	}

	public struct Semaphore
	{
		public IntPtr Handle;
	}

	public struct Event
	{
		public IntPtr Handle;
	}

	public struct QueryPool
	{
		public IntPtr Handle;
	}

	public struct Framebuffer
	{
		public IntPtr Handle;
	}

	public struct RenderPass
	{
		public IntPtr Handle;
	}

	public struct PipelineCache
	{
		public IntPtr Handle;
	}

	public struct DisplayKHR
	{
		public IntPtr Handle;
	}

	public struct DisplayModeKHR
	{
		public IntPtr Handle;
	}

	public struct SurfaceKHR
	{
		public IntPtr Handle;
	}

	public struct SwapchainKHR
	{
		public IntPtr Handle;
	}

	public struct DebugReportCallbackEXT
	{
		public IntPtr Handle;
	}

}