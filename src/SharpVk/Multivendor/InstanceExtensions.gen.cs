// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a debug report callback object.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// flags indicate which event(s) will cause this callback to be
        /// called. Flags are interpreted as bitmasks and multiple may be set.
        /// Bits which can be set include: + --
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="userData">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe DebugReportCallback CreateDebugReportCallback(this Instance extendedHandle, DebugReportCallbackDelegate callback, DebugReportFlags? flags = default, IntPtr? userData = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                DebugReportCallback result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo* marshalledCreateInfo = default;
                void* vkDebugReportCallbackCreateInfoEXTNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Multivendor.DebugReportCallback marshalledCallback = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DebugReportCallbackCreateInfo;
                marshalledCreateInfo->Next = vkDebugReportCallbackCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Callback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(callback);
                if (userData != null)
                {
                    marshalledCreateInfo->UserData = userData.Value.ToPointer();
                }
                else
                {
                    marshalledCreateInfo->UserData = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkInstanceCreateDebugReportCallbackDelegate commandDelegate = commandCache.Cache.vkCreateDebugReportCallbackEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledCallback);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DebugReportCallback(extendedHandle, marshalledCallback);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="objectType">
        /// </param>
        /// <param name="object">
        /// </param>
        /// <param name="location">
        /// </param>
        /// <param name="messageCode">
        /// </param>
        /// <param name="layerPrefix">
        /// </param>
        /// <param name="message">
        /// </param>
        public static unsafe void DebugReportMessage(this Instance extendedHandle, DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, string layerPrefix, string message)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkInstanceDebugReportMessageDelegate commandDelegate = commandCache.Cache.vkDebugReportMessageEXT;
                commandDelegate(extendedHandle.Handle, flags, objectType, @object, location, messageCode, Interop.HeapUtil.MarshalTo(layerPrefix), Interop.HeapUtil.MarshalTo(message));
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="messageSeverity">
        /// </param>
        /// <param name="messageType">
        /// </param>
        /// <param name="userCallback">
        /// </param>
        /// <param name="userData">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe DebugUtilsMessenger CreateDebugUtilsMessenger(this Instance extendedHandle, DebugUtilsMessageSeverityFlags messageSeverity, DebugUtilsMessageTypeFlags messageType, DebugUtilsMessengerCallbackDelegate userCallback, DebugUtilsMessengerCreateFlags? flags = default, IntPtr? userData = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                DebugUtilsMessenger result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo* marshalledCreateInfo = default;
                void* vkDebugUtilsMessengerCreateInfoEXTNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Multivendor.DebugUtilsMessenger marshalledMessenger = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DebugUtilsMessengerCreateInfo;
                marshalledCreateInfo->Next = vkDebugUtilsMessengerCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->MessageSeverity = messageSeverity;
                marshalledCreateInfo->MessageType = messageType;
                marshalledCreateInfo->UserCallback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(userCallback);
                if (userData != null)
                {
                    marshalledCreateInfo->UserData = userData.Value.ToPointer();
                }
                else
                {
                    marshalledCreateInfo->UserData = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkInstanceCreateDebugUtilsMessengerDelegate commandDelegate = commandCache.Cache.vkCreateDebugUtilsMessengerEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledMessenger);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DebugUtilsMessenger(extendedHandle, marshalledMessenger);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="messageSeverity">
        /// </param>
        /// <param name="messageTypes">
        /// </param>
        /// <param name="callbackData">
        /// </param>
        public static unsafe void SubmitDebugUtilsMessage(this Instance extendedHandle, DebugUtilsMessageSeverityFlags messageSeverity, DebugUtilsMessageTypeFlags messageTypes, DebugUtilsMessengerCallbackData callbackData)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData* marshalledCallbackData = default;
                commandCache = extendedHandle.commandCache;
                marshalledCallbackData = (SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData>());
                callbackData.MarshalTo(marshalledCallbackData);
                SharpVk.Interop.Multivendor.VkInstanceSubmitDebugUtilsMessageDelegate commandDelegate = commandCache.Cache.vkSubmitDebugUtilsMessageEXT;
                commandDelegate(extendedHandle.Handle, messageSeverity, messageTypes, marshalledCallbackData);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a VkSurfaceKHR object for CAMetalLayer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="layer">
        /// A CAMetalLayer object that represents a renderable surface.
        /// </param>
        /// <param name="allocator">
        /// The allocator used for host memory allocated for the surface object
        /// when there is no more specific allocator available.
        /// </param>
        public static unsafe Khronos.Surface CreateMetalSurface(this Instance extendedHandle, IntPtr layer, MetalSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Khronos.Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.MetalSurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkMetalSurfaceCreateInfoEXTNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.MetalSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.MetalSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.MetalSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkMetalSurfaceCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Layer = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Layer = layer;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkInstanceCreateMetalSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateMetalSurfaceEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a headless Surface object
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use
        /// </param>
        /// <param name="allocator">
        /// The allocator used for host memory allocated for the surface object
        /// when there is no more specific allocator available.
        /// </param>
        public static unsafe Khronos.Surface CreateHeadlessSurface(this Instance extendedHandle, HeadlessSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Khronos.Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.HeadlessSurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkHeadlessSurfaceCreateInfoEXTNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.HeadlessSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.HeadlessSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.HeadlessSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkHeadlessSurfaceCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkInstanceCreateHeadlessSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateHeadlessSurfaceEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="dfb">
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe Khronos.Surface CreateDirectFBSurface(this Instance extendedHandle, IDirectFB dfb, IDirectFBSurface surface, DirectFBSurfaceCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                Khronos.Surface result = default;
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DirectFBSurfaceCreateInfo* marshalledCreateInfo = default;
                void* vkDirectFBSurfaceCreateInfoEXTNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.Surface marshalledSurface = default;
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.DirectFBSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DirectFBSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DirectfbSurfaceCreateInfo;
                marshalledCreateInfo->Next = vkDirectFBSurfaceCreateInfoEXTNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Dfb = (IDirectFB*)(Interop.HeapUtil.Allocate<IDirectFB>());
                *marshalledCreateInfo->Dfb = dfb;
                marshalledCreateInfo->Surface = (IDirectFBSurface*)(Interop.HeapUtil.Allocate<IDirectFBSurface>());
                *marshalledCreateInfo->Surface = surface;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Multivendor.VkInstanceCreateDirectFBSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateDirectFBSurfaceEXT;
                Result methodResult = commandDelegate(extendedHandle.Handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
