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
	public class Buffer
	{
		internal readonly Interop.Buffer handle;

		private readonly Device parent;


		internal Buffer(Interop.Buffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void BindMemory(DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe
			{
				Result commandResult;

				Interop.DeviceMemory marshalledMemory = memory?.Pack() ?? Interop.DeviceMemory.Null;
				commandResult = Interop.Commands.vkBindBufferMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public MemoryRequirements GetMemoryRequirements()
		{
			unsafe
			{
				MemoryRequirements result = default(MemoryRequirements);

				Interop.Commands.vkGetBufferMemoryRequirements(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyBuffer(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Buffer Pack()
		{
			return this.handle;
		}
	}

	public class BufferView
	{
		internal readonly Interop.BufferView handle;

		private readonly Device parent;


		internal BufferView(Interop.BufferView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyBufferView(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.BufferView Pack()
		{
			return this.handle;
		}
	}

	public class CommandBuffer
	{
		internal readonly Interop.CommandBuffer handle;

		private readonly CommandPool parent;


		internal CommandBuffer(Interop.CommandBuffer handle, CommandPool parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.CommandBuffer Pack()
		{
			return this.handle;
		}
	}

	public class CommandPool
	{
		internal readonly Interop.CommandPool handle;

		private readonly Device parent;


		internal CommandPool(Interop.CommandPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.CommandPool Pack()
		{
			return this.handle;
		}
	}

	public class DescriptorSetLayout
	{
		internal readonly Interop.DescriptorSetLayout handle;

		private readonly Device parent;


		internal DescriptorSetLayout(Interop.DescriptorSetLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.DescriptorSetLayout Pack()
		{
			return this.handle;
		}
	}

	public class Device
	{
		internal readonly Interop.Device handle;

		private readonly PhysicalDevice parent;


		internal Device(Interop.Device handle, PhysicalDevice parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public IntPtr GetProcAddr(string name)
		{
			unsafe
			{
				IntPtr result = default(IntPtr);

				char* marshalledName = Interop.HeapUtil.MarshalTo(name);
				result = Interop.Commands.vkGetDeviceProcAddr(this.handle, marshalledName);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyDevice(this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
		{
			unsafe
			{
				Queue result = default(Queue);

				Interop.Queue marshalledQueue;
				Interop.Commands.vkGetDeviceQueue(this.handle, queueFamilyIndex, queueIndex, &marshalledQueue);

				result = new Queue(marshalledQueue, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void WaitIdle()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkDeviceWaitIdle(this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public DeviceMemory AllocateMemory(MemoryAllocateInfo allocateInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				DeviceMemory result = default(DeviceMemory);

				Result commandResult;

				Interop.MemoryAllocateInfo marshalledAllocateInfo;
				if(allocateInfo != null) marshalledAllocateInfo = allocateInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.DeviceMemory marshalledMemory;
				commandResult = Interop.Commands.vkAllocateMemory(this.handle, allocateInfo == null ? null : &marshalledAllocateInfo, allocator == null ? null : &marshalledAllocator, &marshalledMemory);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new DeviceMemory(marshalledMemory, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void FlushMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
		{
			unsafe
			{
				Result commandResult;

				Interop.MappedMemoryRange* marshalledMemoryRanges;
				if (memoryRanges != null)
				{
				    marshalledMemoryRanges = (Interop.MappedMemoryRange*)Interop.HeapUtil.Allocate<Interop.MappedMemoryRange>(memoryRanges.Length);
				    for (int index = 0; index < memoryRanges.Length; index++)
				    {
				        marshalledMemoryRanges[index] = memoryRanges[index].Pack();
				    }
				}
				else
				{
				    marshalledMemoryRanges = null;
				}
				commandResult = Interop.Commands.vkFlushMappedMemoryRanges(this.handle, (uint)memoryRanges.Length, marshalledMemoryRanges);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void InvalidateMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
		{
			unsafe
			{
				Result commandResult;

				Interop.MappedMemoryRange* marshalledMemoryRanges;
				if (memoryRanges != null)
				{
				    marshalledMemoryRanges = (Interop.MappedMemoryRange*)Interop.HeapUtil.Allocate<Interop.MappedMemoryRange>(memoryRanges.Length);
				    for (int index = 0; index < memoryRanges.Length; index++)
				    {
				        marshalledMemoryRanges[index] = memoryRanges[index].Pack();
				    }
				}
				else
				{
				    marshalledMemoryRanges = null;
				}
				commandResult = Interop.Commands.vkInvalidateMappedMemoryRanges(this.handle, (uint)memoryRanges.Length, marshalledMemoryRanges);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public Fence CreateFence(FenceCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Fence result = default(Fence);

				Result commandResult;

				Interop.FenceCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Fence marshalledFence;
				commandResult = Interop.Commands.vkCreateFence(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledFence);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Fence(marshalledFence, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void ResetFences(Fence[] fences)
		{
			unsafe
			{
				Result commandResult;

				Interop.Fence* marshalledFences;
				if (fences != null)
				{
				    marshalledFences = (Interop.Fence*)Interop.HeapUtil.Allocate<Interop.Fence>(fences.Length);
				    for (int index = 0; index < fences.Length; index++)
				    {
				        marshalledFences[index] = fences[index].Pack();
				    }
				}
				else
				{
				    marshalledFences = null;
				}
				commandResult = Interop.Commands.vkResetFences(this.handle, (uint)fences.Length, marshalledFences);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void WaitForFences(Fence[] fences, Bool32 waitAll, ulong timeout)
		{
			unsafe
			{
				Result commandResult;

				Interop.Fence* marshalledFences;
				if (fences != null)
				{
				    marshalledFences = (Interop.Fence*)Interop.HeapUtil.Allocate<Interop.Fence>(fences.Length);
				    for (int index = 0; index < fences.Length; index++)
				    {
				        marshalledFences[index] = fences[index].Pack();
				    }
				}
				else
				{
				    marshalledFences = null;
				}
				commandResult = Interop.Commands.vkWaitForFences(this.handle, (uint)fences.Length, marshalledFences, waitAll, timeout);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public Semaphore CreateSemaphore(SemaphoreCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Semaphore result = default(Semaphore);

				Result commandResult;

				Interop.SemaphoreCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Semaphore marshalledSemaphore;
				commandResult = Interop.Commands.vkCreateSemaphore(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledSemaphore);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Semaphore(marshalledSemaphore, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Event CreateEvent(EventCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Event result = default(Event);

				Result commandResult;

				Interop.EventCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Event marshalledEvent;
				commandResult = Interop.Commands.vkCreateEvent(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledEvent);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Event(marshalledEvent, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public QueryPool CreateQueryPool(QueryPoolCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				QueryPool result = default(QueryPool);

				Result commandResult;

				Interop.QueryPoolCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.QueryPool marshalledQueryPool;
				commandResult = Interop.Commands.vkCreateQueryPool(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledQueryPool);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new QueryPool(marshalledQueryPool, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Buffer CreateBuffer(BufferCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Buffer result = default(Buffer);

				Result commandResult;

				Interop.BufferCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Buffer marshalledBuffer;
				commandResult = Interop.Commands.vkCreateBuffer(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledBuffer);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Buffer(marshalledBuffer, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public BufferView CreateBufferView(BufferViewCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				BufferView result = default(BufferView);

				Result commandResult;

				Interop.BufferViewCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.BufferView marshalledView;
				commandResult = Interop.Commands.vkCreateBufferView(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledView);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new BufferView(marshalledView, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Image CreateImage(ImageCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Image result = default(Image);

				Result commandResult;

				Interop.ImageCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Image marshalledImage;
				commandResult = Interop.Commands.vkCreateImage(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledImage);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Image(marshalledImage, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ImageView CreateImageView(ImageViewCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				ImageView result = default(ImageView);

				Result commandResult;

				Interop.ImageViewCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.ImageView marshalledView;
				commandResult = Interop.Commands.vkCreateImageView(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledView);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ImageView(marshalledView, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ShaderModule CreateShaderModule(ShaderModuleCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				ShaderModule result = default(ShaderModule);

				Result commandResult;

				Interop.ShaderModuleCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.ShaderModule marshalledShaderModule;
				commandResult = Interop.Commands.vkCreateShaderModule(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledShaderModule);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ShaderModule(marshalledShaderModule, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PipelineCache CreatePipelineCache(PipelineCacheCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				PipelineCache result = default(PipelineCache);

				Result commandResult;

				Interop.PipelineCacheCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.PipelineCache marshalledPipelineCache;
				commandResult = Interop.Commands.vkCreatePipelineCache(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledPipelineCache);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PipelineCache(marshalledPipelineCache, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PipelineLayout CreatePipelineLayout(PipelineLayoutCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				PipelineLayout result = default(PipelineLayout);

				Result commandResult;

				Interop.PipelineLayoutCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.PipelineLayout marshalledPipelineLayout;
				commandResult = Interop.Commands.vkCreatePipelineLayout(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledPipelineLayout);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PipelineLayout(marshalledPipelineLayout, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Swapchain CreateSwapchain(SwapchainCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Swapchain result = default(Swapchain);

				Result commandResult;

				Interop.SwapchainCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Swapchain marshalledSwapchain;
				commandResult = Interop.Commands.vkCreateSwapchainKHR(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledSwapchain);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Swapchain(marshalledSwapchain, createInfo.Surface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.Device Pack()
		{
			return this.handle;
		}
	}

	public class DeviceMemory
	{
		internal readonly Interop.DeviceMemory handle;

		private readonly Device parent;


		internal DeviceMemory(Interop.DeviceMemory handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void FreeMemory(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkFreeMemory(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void MapMemory(DeviceSize offset, DeviceSize size, MemoryMapFlags flags, ref IntPtr data)
		{
			unsafe
			{
				Result commandResult;

				void* marshalledData;
				commandResult = Interop.Commands.vkMapMemory(this.parent.handle, this.handle, offset, size, flags, &marshalledData);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				data = new IntPtr(marshalledData);

				Interop.HeapUtil.FreeLog();

			}
		}

		public void UnmapMemory()
		{
			unsafe
			{
				Interop.Commands.vkUnmapMemory(this.parent.handle, this.handle);


				Interop.HeapUtil.FreeLog();

			}
		}

		public DeviceSize GetCommitment()
		{
			unsafe
			{
				DeviceSize result = default(DeviceSize);

				Interop.Commands.vkGetDeviceMemoryCommitment(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.DeviceMemory Pack()
		{
			return this.handle;
		}
	}

	public class Event
	{
		internal readonly Interop.Event handle;

		private readonly Device parent;


		internal Event(Interop.Event handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyEvent(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void GetStatus()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkGetEventStatus(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void Set()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkSetEvent(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void Reset()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkResetEvent(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Event Pack()
		{
			return this.handle;
		}
	}

	public class Fence
	{
		internal readonly Interop.Fence handle;

		private readonly Device parent;


		internal Fence(Interop.Fence handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyFence(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void GetStatus()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkGetFenceStatus(this.parent.handle, this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Fence Pack()
		{
			return this.handle;
		}
	}

	public class Image
	{
		internal readonly Interop.Image handle;

		private readonly Device parent;


		internal Image(Interop.Image handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void BindMemory(DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe
			{
				Result commandResult;

				Interop.DeviceMemory marshalledMemory = memory?.Pack() ?? Interop.DeviceMemory.Null;
				commandResult = Interop.Commands.vkBindImageMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public MemoryRequirements GetMemoryRequirements()
		{
			unsafe
			{
				MemoryRequirements result = default(MemoryRequirements);

				Interop.Commands.vkGetImageMemoryRequirements(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SparseImageMemoryRequirements[] GetSparseMemoryRequirements()
		{
			unsafe
			{
				SparseImageMemoryRequirements[] result = default(SparseImageMemoryRequirements[]);

				uint sparseMemoryRequirementCount;
				SparseImageMemoryRequirements* marshalledSparseMemoryRequirements = null;
				Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, null);

				marshalledSparseMemoryRequirements = (SparseImageMemoryRequirements*)Interop.HeapUtil.Allocate<SparseImageMemoryRequirements>((uint)sparseMemoryRequirementCount);
				Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);

				result = new SparseImageMemoryRequirements[(uint)sparseMemoryRequirementCount];
				for(int index = 0; index < (uint)sparseMemoryRequirementCount; index++)
				{
					result[index] = marshalledSparseMemoryRequirements[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyImage(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public SubresourceLayout GetSubresourceLayout(ImageSubresource subresource)
		{
			unsafe
			{
				SubresourceLayout result = default(SubresourceLayout);

				Interop.Commands.vkGetImageSubresourceLayout(this.parent.handle, this.handle, &subresource, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.Image Pack()
		{
			return this.handle;
		}
	}

	public class ImageView
	{
		internal readonly Interop.ImageView handle;

		private readonly Device parent;


		internal ImageView(Interop.ImageView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyImageView(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.ImageView Pack()
		{
			return this.handle;
		}
	}

	public class Instance
	{
		internal readonly Interop.Instance handle;

		internal Instance(Interop.Instance handle)
		{
			this.handle = handle;
		}

		public static Instance Create(InstanceCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Instance result = default(Instance);

				Result commandResult;

				Interop.InstanceCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Instance marshalledInstance;
				commandResult = Interop.Commands.vkCreateInstance(createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledInstance);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Instance(marshalledInstance);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyInstance(this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public PhysicalDevice[] EnumeratePhysicalDevices()
		{
			unsafe
			{
				PhysicalDevice[] result = default(PhysicalDevice[]);

				Result commandResult;

				uint physicalDeviceCount;
				Interop.PhysicalDevice* marshalledPhysicalDevices = null;
				commandResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledPhysicalDevices = (Interop.PhysicalDevice*)Interop.HeapUtil.Allocate<Interop.PhysicalDevice>((uint)physicalDeviceCount);
				commandResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PhysicalDevice[(uint)physicalDeviceCount];
				for(int index = 0; index < (uint)physicalDeviceCount; index++)
				{
					result[index] = new PhysicalDevice(marshalledPhysicalDevices[index], this);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public IntPtr GetProcAddr(string name)
		{
			unsafe
			{
				IntPtr result = default(IntPtr);

				char* marshalledName = Interop.HeapUtil.MarshalTo(name);
				result = Interop.Commands.vkGetInstanceProcAddr(this.handle, marshalledName);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public static ExtensionProperties[] EnumerateExtensionProperties(string layerName)
		{
			unsafe
			{
				ExtensionProperties[] result = default(ExtensionProperties[]);

				Result commandResult;

				char* marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
				uint propertyCount;
				Interop.ExtensionProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateInstanceExtensionProperties(marshalledLayerName, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.ExtensionProperties*)Interop.HeapUtil.Allocate<Interop.ExtensionProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateInstanceExtensionProperties(marshalledLayerName, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ExtensionProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public static LayerProperties[] EnumerateLayerProperties()
		{
			unsafe
			{
				LayerProperties[] result = default(LayerProperties[]);

				Result commandResult;

				uint propertyCount;
				Interop.LayerProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.LayerProperties*)Interop.HeapUtil.Allocate<Interop.LayerProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new LayerProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Surface CreateWin32Surface(Win32SurfaceCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Surface result = default(Surface);

				Result commandResult;

				Interop.Win32SurfaceCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Surface marshalledSurface;
				commandResult = Interop.Commands.vkCreateWin32SurfaceKHR(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledSurface);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Surface(marshalledSurface, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.Instance Pack()
		{
			return this.handle;
		}
	}

	public class PhysicalDevice
	{
		internal readonly Interop.PhysicalDevice handle;

		private readonly Instance parent;


		internal PhysicalDevice(Interop.PhysicalDevice handle, Instance parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public PhysicalDeviceFeatures GetFeatures()
		{
			unsafe
			{
				PhysicalDeviceFeatures result = default(PhysicalDeviceFeatures);

				Interop.Commands.vkGetPhysicalDeviceFeatures(this.handle, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public FormatProperties GetFormatProperties(Format format)
		{
			unsafe
			{
				FormatProperties result = default(FormatProperties);

				Interop.Commands.vkGetPhysicalDeviceFormatProperties(this.handle, format, &result);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ImageFormatProperties GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags)
		{
			unsafe
			{
				ImageFormatProperties result = default(ImageFormatProperties);

				Result commandResult;

				commandResult = Interop.Commands.vkGetPhysicalDeviceImageFormatProperties(this.handle, format, type, tiling, usage, flags, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PhysicalDeviceProperties GetProperties()
		{
			unsafe
			{
				PhysicalDeviceProperties result = default(PhysicalDeviceProperties);

				Interop.PhysicalDeviceProperties marshalledProperties;
				Interop.Commands.vkGetPhysicalDeviceProperties(this.handle, &marshalledProperties);

				result = PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public QueueFamilyProperties[] GetQueueFamilyProperties()
		{
			unsafe
			{
				QueueFamilyProperties[] result = default(QueueFamilyProperties[]);

				uint queueFamilyPropertyCount;
				QueueFamilyProperties* marshalledQueueFamilyProperties = null;
				Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, null);

				marshalledQueueFamilyProperties = (QueueFamilyProperties*)Interop.HeapUtil.Allocate<QueueFamilyProperties>((uint)queueFamilyPropertyCount);
				Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);

				result = new QueueFamilyProperties[(uint)queueFamilyPropertyCount];
				for(int index = 0; index < (uint)queueFamilyPropertyCount; index++)
				{
					result[index] = marshalledQueueFamilyProperties[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PhysicalDeviceMemoryProperties GetMemoryProperties()
		{
			unsafe
			{
				PhysicalDeviceMemoryProperties result = default(PhysicalDeviceMemoryProperties);

				Interop.PhysicalDeviceMemoryProperties marshalledMemoryProperties;
				Interop.Commands.vkGetPhysicalDeviceMemoryProperties(this.handle, &marshalledMemoryProperties);

				result = PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Device CreateDevice(DeviceCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Device result = default(Device);

				Result commandResult;

				Interop.DeviceCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Device marshalledDevice;
				commandResult = Interop.Commands.vkCreateDevice(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledDevice);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Device(marshalledDevice, this);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
		{
			unsafe
			{
				ExtensionProperties[] result = default(ExtensionProperties[]);

				Result commandResult;

				char* marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
				uint propertyCount;
				Interop.ExtensionProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, marshalledLayerName, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.ExtensionProperties*)Interop.HeapUtil.Allocate<Interop.ExtensionProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, marshalledLayerName, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new ExtensionProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public LayerProperties[] EnumerateDeviceLayerProperties()
		{
			unsafe
			{
				LayerProperties[] result = default(LayerProperties[]);

				Result commandResult;

				uint propertyCount;
				Interop.LayerProperties* marshalledProperties = null;
				commandResult = Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledProperties = (Interop.LayerProperties*)Interop.HeapUtil.Allocate<Interop.LayerProperties>((uint)propertyCount);
				commandResult = Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, marshalledProperties);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new LayerProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SparseImageFormatProperties[] GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
		{
			unsafe
			{
				SparseImageFormatProperties[] result = default(SparseImageFormatProperties[]);

				uint propertyCount;
				SparseImageFormatProperties* marshalledProperties = null;
				Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, null);

				marshalledProperties = (SparseImageFormatProperties*)Interop.HeapUtil.Allocate<SparseImageFormatProperties>((uint)propertyCount);
				Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, marshalledProperties);

				result = new SparseImageFormatProperties[(uint)propertyCount];
				for(int index = 0; index < (uint)propertyCount; index++)
				{
					result[index] = marshalledProperties[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Bool32 GetSurfaceSupport(uint queueFamilyIndex, Surface surface)
		{
			unsafe
			{
				Bool32 result = default(Bool32);

				Result commandResult;

				Interop.Surface marshalledSurface = surface?.Pack() ?? Interop.Surface.Null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceSupportKHR(this.handle, queueFamilyIndex, marshalledSurface, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SurfaceCapabilities GetSurfaceCapabilities(Surface surface)
		{
			unsafe
			{
				SurfaceCapabilities result = default(SurfaceCapabilities);

				Result commandResult;

				Interop.Surface marshalledSurface = surface?.Pack() ?? Interop.Surface.Null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this.handle, marshalledSurface, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public SurfaceFormat[] GetSurfaceFormats(Surface surface)
		{
			unsafe
			{
				SurfaceFormat[] result = default(SurfaceFormat[]);

				Result commandResult;

				Interop.Surface marshalledSurface = surface?.Pack() ?? Interop.Surface.Null;
				uint surfaceFormatCount;
				SurfaceFormat* marshalledSurfaceFormats = null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceFormatsKHR(this.handle, marshalledSurface, &surfaceFormatCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledSurfaceFormats = (SurfaceFormat*)Interop.HeapUtil.Allocate<SurfaceFormat>((uint)surfaceFormatCount);
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfaceFormatsKHR(this.handle, marshalledSurface, &surfaceFormatCount, marshalledSurfaceFormats);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new SurfaceFormat[(uint)surfaceFormatCount];
				for(int index = 0; index < (uint)surfaceFormatCount; index++)
				{
					result[index] = marshalledSurfaceFormats[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public PresentMode[] GetSurfacePresentModes(Surface surface)
		{
			unsafe
			{
				PresentMode[] result = default(PresentMode[]);

				Result commandResult;

				Interop.Surface marshalledSurface = surface?.Pack() ?? Interop.Surface.Null;
				uint presentModeCount;
				PresentMode* marshalledPresentModes = null;
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfacePresentModesKHR(this.handle, marshalledSurface, &presentModeCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledPresentModes = (PresentMode*)Interop.HeapUtil.Allocate<PresentMode>((uint)presentModeCount);
				commandResult = Interop.Commands.vkGetPhysicalDeviceSurfacePresentModesKHR(this.handle, marshalledSurface, &presentModeCount, marshalledPresentModes);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new PresentMode[(uint)presentModeCount];
				for(int index = 0; index < (uint)presentModeCount; index++)
				{
					result[index] = marshalledPresentModes[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public bool GetWin32PresentationSupport(uint queueFamilyIndex)
		{
			unsafe
			{
				bool result = default(bool);

				result = Interop.Commands.vkGetPhysicalDeviceWin32PresentationSupportKHR(this.handle, queueFamilyIndex);


				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.PhysicalDevice Pack()
		{
			return this.handle;
		}
	}

	public class Pipeline
	{
		internal readonly Interop.Pipeline handle;

		private readonly Device parent;


		internal Pipeline(Interop.Pipeline handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyPipeline(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Pipeline Pack()
		{
			return this.handle;
		}
	}

	public class PipelineCache
	{
		internal readonly Interop.PipelineCache handle;

		private readonly Device parent;


		internal PipelineCache(Interop.PipelineCache handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyPipelineCache(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public byte[] GetData()
		{
			unsafe
			{
				byte[] result = default(byte[]);

				Result commandResult;

				UIntPtr dataSize;
				byte* marshalledData = null;
				commandResult = Interop.Commands.vkGetPipelineCacheData(this.parent.handle, this.handle, &dataSize, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledData = (byte*)Interop.HeapUtil.Allocate<byte>((uint)dataSize);
				commandResult = Interop.Commands.vkGetPipelineCacheData(this.parent.handle, this.handle, &dataSize, marshalledData);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new byte[(uint)dataSize];
				for(int index = 0; index < (uint)dataSize; index++)
				{
					result[index] = marshalledData[index];
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public void MergePipelineCaches(PipelineCache[] sourceCaches)
		{
			unsafe
			{
				Result commandResult;

				Interop.PipelineCache* marshalledSourceCaches;
				if (sourceCaches != null)
				{
				    marshalledSourceCaches = (Interop.PipelineCache*)Interop.HeapUtil.Allocate<Interop.PipelineCache>(sourceCaches.Length);
				    for (int index = 0; index < sourceCaches.Length; index++)
				    {
				        marshalledSourceCaches[index] = sourceCaches[index].Pack();
				    }
				}
				else
				{
				    marshalledSourceCaches = null;
				}
				commandResult = Interop.Commands.vkMergePipelineCaches(this.parent.handle, this.handle, (uint)sourceCaches.Length, marshalledSourceCaches);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public Pipeline CreateGraphicsPipelines(GraphicsPipelineCreateInfo[] createInfos, AllocationCallbacks allocator)
		{
			unsafe
			{
				Pipeline result = default(Pipeline);

				Result commandResult;

				Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos;
				if (createInfos != null)
				{
				    marshalledCreateInfos = (Interop.GraphicsPipelineCreateInfo*)Interop.HeapUtil.Allocate<Interop.GraphicsPipelineCreateInfo>(createInfos.Length);
				    for (int index = 0; index < createInfos.Length; index++)
				    {
				        marshalledCreateInfos[index] = createInfos[index].Pack();
				    }
				}
				else
				{
				    marshalledCreateInfos = null;
				}
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Pipeline marshalledPipelines;
				commandResult = Interop.Commands.vkCreateGraphicsPipelines(this.parent.handle, this.handle, (uint)createInfos.Length, marshalledCreateInfos, allocator == null ? null : &marshalledAllocator, &marshalledPipelines);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Pipeline(marshalledPipelines, this.parent);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public Pipeline CreateComputePipelines(ComputePipelineCreateInfo[] createInfos, AllocationCallbacks allocator)
		{
			unsafe
			{
				Pipeline result = default(Pipeline);

				Result commandResult;

				Interop.ComputePipelineCreateInfo* marshalledCreateInfos;
				if (createInfos != null)
				{
				    marshalledCreateInfos = (Interop.ComputePipelineCreateInfo*)Interop.HeapUtil.Allocate<Interop.ComputePipelineCreateInfo>(createInfos.Length);
				    for (int index = 0; index < createInfos.Length; index++)
				    {
				        marshalledCreateInfos[index] = createInfos[index].Pack();
				    }
				}
				else
				{
				    marshalledCreateInfos = null;
				}
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Pipeline marshalledPipelines;
				commandResult = Interop.Commands.vkCreateComputePipelines(this.parent.handle, this.handle, (uint)createInfos.Length, marshalledCreateInfos, allocator == null ? null : &marshalledAllocator, &marshalledPipelines);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Pipeline(marshalledPipelines, this.parent);

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.PipelineCache Pack()
		{
			return this.handle;
		}
	}

	public class PipelineLayout
	{
		internal readonly Interop.PipelineLayout handle;

		private readonly Device parent;


		internal PipelineLayout(Interop.PipelineLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyPipelineLayout(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.PipelineLayout Pack()
		{
			return this.handle;
		}
	}

	public class QueryPool
	{
		internal readonly Interop.QueryPool handle;

		private readonly Device parent;


		internal QueryPool(Interop.QueryPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyQueryPool(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public void GetResults(uint firstQuery, uint queryCount, byte[] data, DeviceSize stride, QueryResultFlags flags)
		{
			unsafe
			{
				Result commandResult;

				fixed(byte* marshalledData = data)
				commandResult = Interop.Commands.vkGetQueryPoolResults(this.parent.handle, this.handle, firstQuery, queryCount, (UIntPtr)data.Length, marshalledData, stride, flags);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.QueryPool Pack()
		{
			return this.handle;
		}
	}

	public class Queue
	{
		internal readonly Interop.Queue handle;

		private readonly Device parent;


		internal Queue(Interop.Queue handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Submit(SubmitInfo[] submits, Fence fence)
		{
			unsafe
			{
				Result commandResult;

				Interop.SubmitInfo* marshalledSubmits;
				if (submits != null)
				{
				    marshalledSubmits = (Interop.SubmitInfo*)Interop.HeapUtil.Allocate<Interop.SubmitInfo>(submits.Length);
				    for (int index = 0; index < submits.Length; index++)
				    {
				        marshalledSubmits[index] = submits[index].Pack();
				    }
				}
				else
				{
				    marshalledSubmits = null;
				}
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
				commandResult = Interop.Commands.vkQueueSubmit(this.handle, (uint)submits.Length, marshalledSubmits, marshalledFence);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void WaitIdle()
		{
			unsafe
			{
				Result commandResult;

				commandResult = Interop.Commands.vkQueueWaitIdle(this.handle);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void BindSparse(BindSparseInfo[] bindInfo, Fence fence)
		{
			unsafe
			{
				Result commandResult;

				Interop.BindSparseInfo* marshalledBindInfo;
				if (bindInfo != null)
				{
				    marshalledBindInfo = (Interop.BindSparseInfo*)Interop.HeapUtil.Allocate<Interop.BindSparseInfo>(bindInfo.Length);
				    for (int index = 0; index < bindInfo.Length; index++)
				    {
				        marshalledBindInfo[index] = bindInfo[index].Pack();
				    }
				}
				else
				{
				    marshalledBindInfo = null;
				}
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
				commandResult = Interop.Commands.vkQueueBindSparse(this.handle, (uint)bindInfo.Length, marshalledBindInfo, marshalledFence);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		public void Present(PresentInfo presentInfo)
		{
			unsafe
			{
				Result commandResult;

				Interop.PresentInfo marshalledPresentInfo;
				if(presentInfo != null) marshalledPresentInfo = presentInfo.Pack();
				commandResult = Interop.Commands.vkQueuePresentKHR(this.handle, presentInfo == null ? null : &marshalledPresentInfo);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Queue Pack()
		{
			return this.handle;
		}
	}

	public class RenderPass
	{
		internal readonly Interop.RenderPass handle;

		private readonly Device parent;


		internal RenderPass(Interop.RenderPass handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.RenderPass Pack()
		{
			return this.handle;
		}
	}

	public class Semaphore
	{
		internal readonly Interop.Semaphore handle;

		private readonly Device parent;


		internal Semaphore(Interop.Semaphore handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroySemaphore(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Semaphore Pack()
		{
			return this.handle;
		}
	}

	public class ShaderModule
	{
		internal readonly Interop.ShaderModule handle;

		private readonly Device parent;


		internal ShaderModule(Interop.ShaderModule handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroyShaderModule(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.ShaderModule Pack()
		{
			return this.handle;
		}
	}

	public class Surface
	{
		internal readonly Interop.Surface handle;

		private readonly Instance parent;


		internal Surface(Interop.Surface handle, Instance parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroySurfaceKHR(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		internal Interop.Surface Pack()
		{
			return this.handle;
		}
	}

	public class Swapchain
	{
		internal readonly Interop.Swapchain handle;

		private readonly Surface parent;

		private readonly Device associated;

		internal Swapchain(Interop.Swapchain handle, Surface parent, Device associated)
		{
			this.handle = handle;
			this.parent = parent;
			this.associated = associated;
		}

		public void Destroy(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Commands.vkDestroySwapchainKHR(this.associated.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();

			}
		}

		public Image[] GetImages()
		{
			unsafe
			{
				Image[] result = default(Image[]);

				Result commandResult;

				uint swapchainImageCount;
				Interop.Image* marshalledSwapchainImages = null;
				commandResult = Interop.Commands.vkGetSwapchainImagesKHR(this.associated.handle, this.handle, &swapchainImageCount, null);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				marshalledSwapchainImages = (Interop.Image*)Interop.HeapUtil.Allocate<Interop.Image>((uint)swapchainImageCount);
				commandResult = Interop.Commands.vkGetSwapchainImagesKHR(this.associated.handle, this.handle, &swapchainImageCount, marshalledSwapchainImages);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}
				result = new Image[(uint)swapchainImageCount];
				for(int index = 0; index < (uint)swapchainImageCount; index++)
				{
					result[index] = new Image(marshalledSwapchainImages[index], this.associated);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		public uint AcquireNextImage(ulong timeout, Semaphore semaphore, Fence fence)
		{
			unsafe
			{
				uint result = default(uint);

				Result commandResult;

				Interop.Semaphore marshalledSemaphore = semaphore?.Pack() ?? Interop.Semaphore.Null;
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
				commandResult = Interop.Commands.vkAcquireNextImageKHR(this.associated.handle, this.handle, timeout, marshalledSemaphore, marshalledFence, &result);

				if (SharpVkException.IsError(commandResult))
				{
					throw SharpVkException.Create(commandResult);
				}

				Interop.HeapUtil.FreeLog();


				return result;
			}
		}

		internal Interop.Swapchain Pack()
		{
			return this.handle;
		}
	}

}