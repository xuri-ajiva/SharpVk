// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// <para>
    /// Opaque handle to a buffer object.
    /// </para>
    /// <para>
    /// Buffers represent linear arrays of data which are used for various
    /// purposes by binding them to a graphics or compute pipeline via
    /// descriptor sets or via certain commands, or by directly specifying them
    /// as parameters to certain commands.
    /// </para>
    /// </summary>
    public struct Buffer
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Buffer handle.
        /// </summary>
        public static Buffer Null
        {
            get
            {
                return new Buffer
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a buffer view object.
    /// </para>
    /// <para>
    /// A _buffer view_ represents a contiguous range of a buffer and a
    /// specific format to be used to interpret the data. Buffer views are used
    /// to enable shaders to access buffer contents interpreted as formatted
    /// data. In order to create a valid buffer view, the buffer must: have
    /// been created with at least one of the following usage flags:
    /// </para>
    /// <para>
    /// * ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT *
    /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT
    /// </para>
    /// </summary>
    public struct BufferView
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null BufferView handle.
        /// </summary>
        public static BufferView Null
        {
            get
            {
                return new BufferView
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a command buffer object.
    /// </para>
    /// <para>
    /// Command buffers are objects used to record commands which can: be
    /// subsequently submitted to a device queue for execution. There are two
    /// levels of command buffers - _primary command buffers_, which can:
    /// execute secondary command buffers, and which are submitted to queues,
    /// and _secondary command buffers_, which can: be executed by primary
    /// command buffers, and which are not directly submitted to queues.
    /// </para>
    /// </summary>
    public struct CommandBuffer
    {
        internal UIntPtr handle; 
        
        /// <summary>
        /// A read-only property that returns a null CommandBuffer handle.
        /// </summary>
        public static CommandBuffer Null
        {
            get
            {
                return new CommandBuffer
                {
                    handle = default(UIntPtr)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle.ToUInt64();
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a command pool object.
    /// </para>
    /// <para>
    /// Command pools are opaque objects that command buffer memory is
    /// allocated from, and which allow the implementation to amortize the cost
    /// of resource creation across multiple command buffers. Command pools are
    /// application-synchronized, meaning that a command pool must: not be used
    /// concurrently in multiple threads. That includes use via recording
    /// commands on any command buffers allocated from the pool, as well as
    /// operations that allocate, free, and reset command buffers or the pool
    /// itself.
    /// </para>
    /// </summary>
    public struct CommandPool
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null CommandPool handle.
        /// </summary>
        public static CommandPool Null
        {
            get
            {
                return new CommandPool
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// -
    /// </summary>
    public struct DebugReportCallback
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null DebugReportCallback
        /// handle.
        /// </summary>
        public static DebugReportCallback Null
        {
            get
            {
                return new DebugReportCallback
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a descriptor pool object.
    /// </para>
    /// <para>
    /// A _descriptor pool_ maintains a pool of descriptors, from which
    /// descriptor sets are allocated. Descriptor pools are externally
    /// synchronized, meaning that the application must: not allocate and/or
    /// free descriptor sets from the same pool in multiple threads
    /// simultaneously.
    /// </para>
    /// </summary>
    public struct DescriptorPool
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null DescriptorPool handle.
        /// </summary>
        public static DescriptorPool Null
        {
            get
            {
                return new DescriptorPool
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// Opaque handle to a descriptor set object.
    /// </summary>
    public struct DescriptorSet
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null DescriptorSet handle.
        /// </summary>
        public static DescriptorSet Null
        {
            get
            {
                return new DescriptorSet
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a descriptor set layout object.
    /// </para>
    /// <para>
    /// A descriptor set layout object is defined by an array of zero or more
    /// descriptor bindings. Each individual descriptor binding is specified by
    /// a descriptor type, a count (array size) of the number of descriptors in
    /// the binding, a set of shader stages that can: access the binding, and
    /// (if using immutable samplers) an array of sampler descriptors.
    /// </para>
    /// </summary>
    public struct DescriptorSetLayout
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null DescriptorSetLayout
        /// handle.
        /// </summary>
        public static DescriptorSetLayout Null
        {
            get
            {
                return new DescriptorSetLayout
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// Opaque handle to a device object.
    /// </summary>
    public struct Device
    {
        internal UIntPtr handle; 
        
        /// <summary>
        /// A read-only property that returns a null Device handle.
        /// </summary>
        public static Device Null
        {
            get
            {
                return new Device
                {
                    handle = default(UIntPtr)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle.ToUInt64();
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a device memory object.
    /// </para>
    /// <para>
    /// A Vulkan device operates on data in device memory via memory objects
    /// that are represented in the API by a sname:VkDeviceMemory handle.
    /// </para>
    /// </summary>
    public struct DeviceMemory
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null DeviceMemory handle.
        /// </summary>
        public static DeviceMemory Null
        {
            get
            {
                return new DeviceMemory
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// -
    /// </summary>
    public struct Display
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Display handle.
        /// </summary>
        public static Display Null
        {
            get
            {
                return new Display
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// -
    /// </summary>
    public struct DisplayMode
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null DisplayMode handle.
        /// </summary>
        public static DisplayMode Null
        {
            get
            {
                return new DisplayMode
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a event object.
    /// </para>
    /// <para>
    /// Events represent a fine-grained synchronization primitive that can: be
    /// used to gauge progress through a sequence of commands executed on a
    /// queue by Vulkan. An event is initially in the unsignaled state. It can:
    /// be signaled by a device, using commands inserted into the command
    /// buffer, or by the host. It can: also be reset to the unsignaled state
    /// by a device or the host. The host can: query the state of an event. A
    /// device can: wait for one or more events to become signaled.
    /// </para>
    /// </summary>
    public struct Event
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Event handle.
        /// </summary>
        public static Event Null
        {
            get
            {
                return new Event
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a fence object.
    /// </para>
    /// <para>
    /// Fences can: be used by the host to determine completion of execution of
    /// _queue operations_.
    /// </para>
    /// <para>
    /// A fence's status is always either _signaled_ or _unsignaled_. The host
    /// can: poll the status of a single fence, or wait for any or all of a
    /// group of fences to become signaled.
    /// </para>
    /// </summary>
    public struct Fence
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Fence handle.
        /// </summary>
        public static Fence Null
        {
            get
            {
                return new Fence
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a framebuffer object.
    /// </para>
    /// <para>
    /// Render passes operate in conjunction with _framebuffers_. Framebuffers
    /// represent a collection of specific memory attachments that a render
    /// pass instance uses.
    /// </para>
    /// </summary>
    public struct Framebuffer
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Framebuffer handle.
        /// </summary>
        public static Framebuffer Null
        {
            get
            {
                return new Framebuffer
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a image object.
    /// </para>
    /// <para>
    /// Images represent multidimensional - up to 3 - arrays of data which can:
    /// be used for various purposes (e.g. attachments, textures), by binding
    /// them to a graphics or compute pipeline via descriptor sets, or by
    /// directly specifying them as parameters to certain commands.
    /// </para>
    /// </summary>
    public struct Image
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Image handle.
        /// </summary>
        public static Image Null
        {
            get
            {
                return new Image
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a image view object.
    /// </para>
    /// <para>
    /// Image objects are not directly accessed by pipeline shaders for reading
    /// or writing image data. Instead, _image views_ representing contiguous
    /// ranges of the image subresources and containing additional metadata are
    /// used for that purpose. Views must: be created on images of compatible
    /// types, and must: represent a valid subset of image subresources.
    /// </para>
    /// </summary>
    public struct ImageView
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null ImageView handle.
        /// </summary>
        public static ImageView Null
        {
            get
            {
                return new ImageView
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a instance object.
    /// </para>
    /// <para>
    /// There is no global state in Vulkan and all per-application state is
    /// stored in a sname:VkInstance object. Creating a sname:VkInstance object
    /// initializes the Vulkan library and allows the application to pass
    /// information about itself to the implementation.
    /// </para>
    /// </summary>
    public struct Instance
    {
        internal UIntPtr handle; 
        
        /// <summary>
        /// A read-only property that returns a null Instance handle.
        /// </summary>
        public static Instance Null
        {
            get
            {
                return new Instance
                {
                    handle = default(UIntPtr)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle.ToUInt64();
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a physical device object.
    /// </para>
    /// <para>
    /// Vulkan separates the concept of _physical_ and _logical_ devices. A
    /// physical device usually represents a single device in a system (perhaps
    /// made up of several individual hardware devices working together), of
    /// which there are a finite number. A logical device represents an
    /// application's view of the device.
    /// </para>
    /// </summary>
    public struct PhysicalDevice
    {
        internal UIntPtr handle; 
        
        /// <summary>
        /// A read-only property that returns a null PhysicalDevice handle.
        /// </summary>
        public static PhysicalDevice Null
        {
            get
            {
                return new PhysicalDevice
                {
                    handle = default(UIntPtr)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle.ToUInt64();
        }
    }
    
    /// <summary>
    /// Opaque handle to a pipeline object.
    /// </summary>
    public struct Pipeline
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Pipeline handle.
        /// </summary>
        public static Pipeline Null
        {
            get
            {
                return new Pipeline
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a pipeline cache object.
    /// </para>
    /// <para>
    /// Pipeline cache objects allow the result of pipeline construction to be
    /// reused between pipelines and between runs of an application. Reuse
    /// between pipelines is achieved by passing the same pipeline cache object
    /// when creating multiple related pipelines. Reuse across runs of an
    /// application is achieved by retrieving pipeline cache contents in one
    /// run of an application, saving the contents, and using them to
    /// preinitialize a pipeline cache on a subsequent run. The contents of the
    /// pipeline cache objects are managed by the implementation. Applications
    /// can: manage the host memory consumed by a pipeline cache object and
    /// control the amount of data retrieved from a pipeline cache object.
    /// </para>
    /// </summary>
    public struct PipelineCache
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null PipelineCache handle.
        /// </summary>
        public static PipelineCache Null
        {
            get
            {
                return new PipelineCache
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a pipeline layout object.
    /// </para>
    /// <para>
    /// Access to descriptor sets from a pipeline is accomplished through a
    /// _pipeline layout_. Zero or more descriptor set layouts and zero or more
    /// push constant ranges are combined to form a pipeline layout object
    /// which describes the complete set of resources that can: be accessed by
    /// a pipeline. The pipeline layout represents a sequence of descriptor
    /// sets with each having a specific layout. This sequence of layouts is
    /// used to determine the interface between shader stages and shader
    /// resources. Each pipeline is created using a pipeline layout.
    /// </para>
    /// </summary>
    public struct PipelineLayout
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null PipelineLayout handle.
        /// </summary>
        public static PipelineLayout Null
        {
            get
            {
                return new PipelineLayout
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a query pool object.
    /// </para>
    /// <para>
    /// Queries are managed using _query pool_ objects. Each query pool is a
    /// collection of a specific number of queries of a particular type.
    /// </para>
    /// </summary>
    public struct QueryPool
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null QueryPool handle.
        /// </summary>
        public static QueryPool Null
        {
            get
            {
                return new QueryPool
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a queue object.
    /// </para>
    /// <para>
    /// Creating a logical device also creates the queues associated with that
    /// device. The queues to create are described by a set of
    /// slink:VkDeviceQueueCreateInfo structures that are passed to
    /// flink:vkCreateDevice in pname:pQueueCreateInfos.
    /// </para>
    /// </summary>
    public struct Queue
    {
        internal UIntPtr handle; 
        
        /// <summary>
        /// A read-only property that returns a null Queue handle.
        /// </summary>
        public static Queue Null
        {
            get
            {
                return new Queue
                {
                    handle = default(UIntPtr)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle.ToUInt64();
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a render pass object.
    /// </para>
    /// <para>
    /// A _render pass_ represents a collection of attachments, subpasses, and
    /// dependencies between the subpasses, and describes how the attachments
    /// are used over the course of the subpasses. The use of a render pass in
    /// a command buffer is a _render pass instance_.
    /// </para>
    /// </summary>
    public struct RenderPass
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null RenderPass handle.
        /// </summary>
        public static RenderPass Null
        {
            get
            {
                return new RenderPass
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a sampler object.
    /// </para>
    /// <para>
    /// sname:VkSampler objects represent the state of an image sampler which
    /// is used by the implementation to read image data and apply filtering
    /// and other transformations for the shader.
    /// </para>
    /// </summary>
    public struct Sampler
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Sampler handle.
        /// </summary>
        public static Sampler Null
        {
            get
            {
                return new Sampler
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a semaphore object.
    /// </para>
    /// <para>
    /// Semaphores are used to coordinate queue operations both within a queue
    /// and between different queues. A semaphore's status is always either
    /// _signaled_ or _unsignaled_.
    /// </para>
    /// </summary>
    public struct Semaphore
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Semaphore handle.
        /// </summary>
        public static Semaphore Null
        {
            get
            {
                return new Semaphore
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// <para>
    /// Opaque handle to a shader module object.
    /// </para>
    /// <para>
    /// _Shader modules_ contain _shader code_ and one or more entry points.
    /// Shaders are selected from a shader module by specifying an entry point
    /// as part of &lt;&lt;pipelines,pipeline&gt;&gt; creation. The stages of a
    /// pipeline can: use shaders that come from different modules. The shader
    /// code defining a shader module must: be in the SPIR-V format, as
    /// described by the &lt;&lt;spirvenv,Vulkan Environment for SPIR-V&gt;&gt;
    /// appendix.
    /// </para>
    /// </summary>
    public struct ShaderModule
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null ShaderModule handle.
        /// </summary>
        public static ShaderModule Null
        {
            get
            {
                return new ShaderModule
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// -
    /// </summary>
    public struct Surface
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Surface handle.
        /// </summary>
        public static Surface Null
        {
            get
            {
                return new Surface
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
    
    /// <summary>
    /// -
    /// </summary>
    public struct Swapchain
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null Swapchain handle.
        /// </summary>
        public static Swapchain Null
        {
            get
            {
                return new Swapchain
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
}
