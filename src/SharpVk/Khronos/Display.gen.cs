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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public class Display
    {
        internal readonly SharpVk.Interop.Khronos.Display Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly PhysicalDevice parent; 
        
        internal Display(PhysicalDevice parent, SharpVk.Interop.Khronos.Display handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.Display RawHandle => Handle;
        
        /// <summary>
        /// Query the set of mode properties supported by the display.
        /// </summary>
        public unsafe DisplayModeProperties[] GetModeProperties()
        {
            try
            {
                DisplayModeProperties[] result = default;
                uint marshalledPropertyCount = default;
                SharpVk.Interop.Khronos.DisplayModeProperties* marshalledProperties = default;
                SharpVk.Interop.Khronos.VkDisplayKHRGetModePropertiesDelegate commandDelegate = commandCache.Cache.vkGetDisplayModePropertiesKHR;
                Result methodResult = commandDelegate(parent.Handle, Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayModeProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(parent.Handle, Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayModeProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = DisplayModeProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a display mode.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use, and must be zero.
        /// </param>
        /// <param name="parameters">
        /// A DisplayModeParametersKHR structure describing the display
        /// parameters to use in creating the new mode. If the parameters are
        /// not compatible with the specified display, the implementation must
        /// return Result.ErrorINITIALIZATION_FAILED.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe DisplayMode CreateMode(DisplayModeParameters parameters, DisplayModeCreateFlags? flags = default, AllocationCallbacks? allocator = default)
        {
            try
            {
                DisplayMode result = default;
                SharpVk.Interop.Khronos.DisplayModeCreateInfo* marshalledCreateInfo = default;
                void* vkDisplayModeCreateInfoKHRNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Khronos.DisplayMode marshalledMode = default;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DisplayModeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DisplayModeCreateInfo;
                marshalledCreateInfo->Next = vkDisplayModeCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->Parameters = parameters;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                SharpVk.Interop.Khronos.VkDisplayKHRCreateModeDelegate commandDelegate = commandCache.Cache.vkCreateDisplayModeKHR;
                Result methodResult = commandDelegate(parent.Handle, Handle, marshalledCreateInfo, marshalledAllocator, &marshalledMode);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new DisplayMode(this, marshalledMode);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe DisplayModeProperties2[] GetModeProperties2()
        {
            try
            {
                DisplayModeProperties2[] result = default;
                uint marshalledPropertyCount = default;
                SharpVk.Interop.Khronos.DisplayModeProperties2* marshalledProperties = default;
                SharpVk.Interop.Khronos.VkDisplayKHRGetModeProperties2Delegate commandDelegate = commandCache.Cache.vkGetDisplayModeProperties2KHR;
                Result methodResult = commandDelegate(parent.Handle, Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayModeProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeProperties2>((uint)(marshalledPropertyCount)));
                commandDelegate(parent.Handle, Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new DisplayModeProperties2[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = DisplayModeProperties2.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
