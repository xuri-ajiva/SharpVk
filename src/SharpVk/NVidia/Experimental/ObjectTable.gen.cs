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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// Opaque handle to an object table.
    /// </summary>
    public partial class ObjectTable
    {
        internal readonly SharpVk.Interop.NVidia.Experimental.ObjectTable handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal ObjectTable(SharpVk.Device parent, SharpVk.Interop.NVidia.Experimental.ObjectTable handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXDestroyDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXDestroyDelegate>("vkDestroyObjectTableNVX", "instance");
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void RegisterObjects(SharpVk.NVidia.Experimental.ObjectTableEntry[] objectTableEntries, uint[] objectIndices)
        {
            try
            {
                SharpVk.NVidia.Experimental.ObjectTableEntry** marshalledObjectTableEntries = default(SharpVk.NVidia.Experimental.ObjectTableEntry**);
                SharpVk.NVidia.Experimental.ObjectTableEntry* semiMarshalledObjectTableEntries = default(SharpVk.NVidia.Experimental.ObjectTableEntry*);
                uint* marshalledObjectIndices = default(uint*);
                if (objectTableEntries != null)
                {
                    var fieldPointer = (SharpVk.NVidia.Experimental.ObjectTableEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectTableEntry>(objectTableEntries.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectTableEntries.Length); index++)
                    {
                        fieldPointer[index] = objectTableEntries[index];
                    }
                    semiMarshalledObjectTableEntries = fieldPointer;
                }
                else
                {
                    semiMarshalledObjectTableEntries = null;
                }
                if (objectTableEntries != null)
                {
                    var fieldPointer = (SharpVk.NVidia.Experimental.ObjectTableEntry**)(Interop.HeapUtil.AllocateAndClear<IntPtr>(objectTableEntries.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectTableEntries.Length); index++)
                    {
                        fieldPointer[index] = &semiMarshalledObjectTableEntries[index];
                    }
                    marshalledObjectTableEntries = fieldPointer;
                }
                else
                {
                    marshalledObjectTableEntries = null;
                }
                if (objectIndices != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(objectIndices.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectIndices.Length); index++)
                    {
                        fieldPointer[index] = objectIndices[index];
                    }
                    marshalledObjectIndices = fieldPointer;
                }
                else
                {
                    marshalledObjectIndices = null;
                }
                SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXRegisterObjectsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXRegisterObjectsDelegate>("vkRegisterObjectsNVX", "instance");
                Result methodResult = commandDelegate(this.parent.handle, this.handle, (uint)(objectTableEntries?.Length ?? 0), marshalledObjectTableEntries, marshalledObjectIndices);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void UnregisterObjects(SharpVk.NVidia.Experimental.ObjectEntryType[] objectEntryTypes, uint[] objectIndices)
        {
            try
            {
                SharpVk.NVidia.Experimental.ObjectEntryType* marshalledObjectEntryTypes = default(SharpVk.NVidia.Experimental.ObjectEntryType*);
                uint* marshalledObjectIndices = default(uint*);
                if (objectEntryTypes != null)
                {
                    var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryType*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryType>(objectEntryTypes.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectEntryTypes.Length); index++)
                    {
                        fieldPointer[index] = objectEntryTypes[index];
                    }
                    marshalledObjectEntryTypes = fieldPointer;
                }
                else
                {
                    marshalledObjectEntryTypes = null;
                }
                if (objectIndices != null)
                {
                    var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(objectIndices.Length).ToPointer());
                    for(int index = 0; index < (uint)(objectIndices.Length); index++)
                    {
                        fieldPointer[index] = objectIndices[index];
                    }
                    marshalledObjectIndices = fieldPointer;
                }
                else
                {
                    marshalledObjectIndices = null;
                }
                SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXUnregisterObjectsDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXUnregisterObjectsDelegate>("vkUnregisterObjectsNVX", "instance");
                Result methodResult = commandDelegate(this.parent.handle, this.handle, (uint)(objectEntryTypes?.Length ?? 0), marshalledObjectEntryTypes, marshalledObjectIndices);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
