// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
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
    /// 
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a debug report callback object.
        /// </summary>
        /// <param name="flags">
        /// pname:flags indicate which event(s) will cause this callback to be
        /// called. Flags are interpreted as bitmasks and multiple may be set.
        /// Bits which can: be set include: + --
        /// </param>
        public static unsafe SharpVk.Multivendor.DebugReportCallback CreateDebugReportCallback(this SharpVk.Instance extendedHandle, SharpVk.Multivendor.DebugReportCallbackDelegate callback, SharpVk.Multivendor.DebugReportFlags? flags = default(SharpVk.Multivendor.DebugReportFlags?), IntPtr? userData = default(IntPtr?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.DebugReportCallback result = default(SharpVk.Multivendor.DebugReportCallback);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.DebugReportCallback marshalledCallback = default(SharpVk.Interop.Multivendor.DebugReportCallback);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DebugReportCallbackCreateInfoExt;
                marshalledCreateInfo->Next = null;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Multivendor.DebugReportFlags);
                }
                marshalledCreateInfo->Callback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(callback);
                if (userData != null)
                {
                    marshalledCreateInfo->UserData = userData.Value.ToPointer();
                }
                else
                {
                    marshalledCreateInfo->UserData = default(void*);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Multivendor.VkInstanceCreateDebugReportCallbackDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkInstanceCreateDebugReportCallbackDelegate>("vkCreateDebugReportCallbackEXT", "instance");
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledCallback);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.DebugReportCallback(extendedHandle, marshalledCallback);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public static unsafe void DebugReportMessage(this SharpVk.Instance extendedHandle, SharpVk.Multivendor.DebugReportFlags flags, SharpVk.Multivendor.DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, string layerPrefix, string message)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkInstanceDebugReportMessageDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkInstanceDebugReportMessageDelegate>("vkDebugReportMessageEXT", "instance");
                commandDelegate(extendedHandle.handle, flags, objectType, @object, location, messageCode, Interop.HeapUtil.MarshalTo(layerPrefix), Interop.HeapUtil.MarshalTo(message));
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
