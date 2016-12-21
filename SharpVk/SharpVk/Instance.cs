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
using System.Runtime.InteropServices;

namespace SharpVk
{
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
    public partial class Instance
        : IDisposable, IProcLookup
    {
        internal readonly Interop.Instance handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly AllocationCallbacks? allocator; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.allocator;
            }
        }
        
        internal Instance(Interop.Instance handle, AllocationCallbacks? allocator)
        {
            this.handle = handle;
            this.allocator = allocator;
            this.commandCache = new CommandCache(this, "instance", null);
        }
        
        /// <summary>
        /// Create a new Vulkan instance.
        /// </summary>
        public static Instance Create(InstanceCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            unsafe
            {
                try
                {
                    Instance result = default(Instance);
                    Result commandResult;
                    Interop.InstanceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Instance marshalledInstance;
                    commandResult = Interop.Commands.vkCreateInstance(&marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledInstance);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Instance(marshalledInstance, allocator);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Destroy an instance of Vulkan.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Commands.vkDestroyInstance(this.handle, this.allocator == null ? null : &marshalledAllocator);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Enumerates the physical devices accessible to a Vulkan instance.
        /// </summary>
        public PhysicalDevice[] EnumeratePhysicalDevices()
        {
            unsafe
            {
                try
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
                    	result[index] = new PhysicalDevice(marshalledPhysicalDevices[index], this, this.commandCache);
                    }
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Return a function pointer for a command.
        /// </summary>
        public IntPtr GetProcedureAddress(string name)
        {
            unsafe
            {
                try
                {
                    IntPtr result = default(IntPtr);
                    char* marshalledName = Interop.HeapUtil.MarshalTo(name);
                    result = Interop.Commands.vkGetInstanceProcAddr(this.handle, marshalledName);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Returns up to requested number of global extension properties.
        /// </summary>
        public static ExtensionProperties[] EnumerateExtensionProperties(string layerName)
        {
            unsafe
            {
                try
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
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Returns up to requested number of global layer properties.
        /// </summary>
        public static LayerProperties[] EnumerateLayerProperties()
        {
            unsafe
            {
                try
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
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a slink:VkSurfaceKHR structure representing a display plane
        /// and mode.
        /// </summary>
        public Surface CreateDisplayPlaneSurface(DisplaySurfaceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateDisplayPlaneSurfaceKHR>("vkCreateDisplayPlaneSurfaceKHR", "instance");
                    Surface result = default(Surface);
                    Result commandResult;
                    Interop.DisplaySurfaceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Surface marshalledSurface;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Surface(marshalledSurface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a slink:VkSurfaceKHR object for an X11 window, using the
        /// Xlib client-side library.
        /// </summary>
        public Surface CreateXlibSurface(XlibSurfaceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateXlibSurfaceKHR>("vkCreateXlibSurfaceKHR", "instance");
                    Surface result = default(Surface);
                    Result commandResult;
                    Interop.XlibSurfaceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Surface marshalledSurface;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Surface(marshalledSurface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a slink:VkSurfaceKHR object for a X11 window, using the XCB
        /// client-side library.
        /// </summary>
        public Surface CreateXcbSurface(XcbSurfaceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateXcbSurfaceKHR>("vkCreateXcbSurfaceKHR", "instance");
                    Surface result = default(Surface);
                    Result commandResult;
                    Interop.XcbSurfaceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Surface marshalledSurface;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Surface(marshalledSurface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a slink:VkSurfaceKHR object for a Wayland window.
        /// </summary>
        public Surface CreateWaylandSurface(WaylandSurfaceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateWaylandSurfaceKHR>("vkCreateWaylandSurfaceKHR", "instance");
                    Surface result = default(Surface);
                    Result commandResult;
                    Interop.WaylandSurfaceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Surface marshalledSurface;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Surface(marshalledSurface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a slink:VkSurfaceKHR object for a Mir window.
        /// </summary>
        public Surface CreateMirSurface(MirSurfaceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateMirSurfaceKHR>("vkCreateMirSurfaceKHR", "instance");
                    Surface result = default(Surface);
                    Result commandResult;
                    Interop.MirSurfaceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Surface marshalledSurface;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Surface(marshalledSurface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a slink:VkSurfaceKHR object for an Android native window.
        /// </summary>
        public Surface CreateAndroidSurface(AndroidSurfaceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateAndroidSurfaceKHR>("vkCreateAndroidSurfaceKHR", "instance");
                    Surface result = default(Surface);
                    Result commandResult;
                    Interop.AndroidSurfaceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Surface marshalledSurface;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Surface(marshalledSurface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a slink:VkSurfaceKHR object for an Win32 native window.
        /// </summary>
        public Surface CreateWin32Surface(Win32SurfaceCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateWin32SurfaceKHR>("vkCreateWin32SurfaceKHR", "instance");
                    Surface result = default(Surface);
                    Result commandResult;
                    Interop.Win32SurfaceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Surface marshalledSurface;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledSurface);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new Surface(marshalledSurface, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Create a debug report callback object.
        /// </summary>
        public DebugReportCallback CreateDebugReportCallback(DebugReportCallbackCreateInfo createInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkCreateDebugReportCallbackEXT>("vkCreateDebugReportCallbackEXT", "instance");
                    DebugReportCallback result = default(DebugReportCallback);
                    Result commandResult;
                    Interop.DebugReportCallbackCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.allocator?.MarshalTo(&marshalledAllocator);
                    Interop.DebugReportCallback marshalledCallback;
                    commandResult = commandDelegate(this.handle, &marshalledCreateInfo, this.allocator == null ? null : &marshalledAllocator, &marshalledCallback);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    result = new DebugReportCallback(marshalledCallback, this, this.commandCache);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// -
        /// </summary>
        public void DebugReportMessage(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, Size location, int messageCode, string layerPrefix, string message)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkDebugReportMessageEXT>("vkDebugReportMessageEXT", "instance");
                    char* marshalledLayerPrefix = Interop.HeapUtil.MarshalTo(layerPrefix);
                    char* marshalledMessage = Interop.HeapUtil.MarshalTo(message);
                    commandDelegate(this.handle, flags, objectType, @object, location, messageCode, marshalledLayerPrefix, marshalledMessage);
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal unsafe void MarshalTo(Interop.Instance* pointer)
        {
            *pointer = this.handle;
        }
        
        /// <summary>
        /// The interop handle for this Instance.
        /// </summary>
        public Interop.Instance RawHandle => this.handle;
        
        /// <summary>
        /// Releases the unmanaged resources associated with this instance and
        /// destroys the underlying Vulkan handle.
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
