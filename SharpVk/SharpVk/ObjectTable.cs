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
    /// Opaque handle to an object table.
    /// </summary>
    public partial class ObjectTable
        : IDisposable
    {
        internal readonly Interop.ObjectTable handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal ObjectTable(Interop.ObjectTable handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Destroy a object table.
        /// </summary>
        public void Destroy()
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkDestroyObjectTableNVX>("vkDestroyObjectTableNVX", "device");
                    Interop.AllocationCallbacks marshalledAllocator;
                    this.parent.Allocator?.MarshalTo(&marshalledAllocator);
                    commandDelegate(this.parent.handle, this.handle, this.parent.Allocator == null ? null : &marshalledAllocator);
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
        public void RegisterObjects(ArrayProxy<ObjectTableEntry> objectTableEntries, ArrayProxy<uint> objectIndices)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkRegisterObjectsNVX>("vkRegisterObjectsNVX", "device");
                    Result commandResult;
                    GCHandle objectTableEntriesHandle = default(GCHandle);
                    ObjectTableEntry* marshalledObjectTableEntries = null;
                    ObjectTableEntry** doubleMarshalledObjectTableEntries = null;
                    if (objectTableEntries.Contents != ProxyContents.Null)
                    {
                        if(objectTableEntries.Contents == ProxyContents.Single)
                        {
                            ObjectTableEntry* dataPointer = stackalloc ObjectTableEntry[1];
                            *dataPointer = objectTableEntries.GetSingleValue();
                            marshalledObjectTableEntries = dataPointer;
                            doubleMarshalledObjectTableEntries = &marshalledObjectTableEntries;
                        }
                        else
                        {
                            var arrayValue = objectTableEntries.GetArrayValue();
                            objectTableEntriesHandle = GCHandle.Alloc(arrayValue.Array);
                            marshalledObjectTableEntries = (ObjectTableEntry*)(objectTableEntriesHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ObjectTableEntry>() * arrayValue.Offset)).ToPointer();
                            ObjectTableEntry** dataPointer = stackalloc ObjectTableEntry*[objectTableEntries.Length];
                            doubleMarshalledObjectTableEntries = dataPointer;
                            for (int marshalIndex = 0; marshalIndex < objectTableEntries.Length; marshalIndex++)
                            {
                                doubleMarshalledObjectTableEntries[marshalIndex] = &marshalledObjectTableEntries[marshalIndex];
                            }
                        }
                    }
                    else
                    {
                        marshalledObjectTableEntries = null;
                    }
                    GCHandle objectIndicesHandle = default(GCHandle);
                    uint* marshalledObjectIndices = null;
                    if (objectIndices.Contents != ProxyContents.Null)
                    {
                        if(objectIndices.Contents == ProxyContents.Single)
                        {
                            uint* dataPointer = stackalloc uint[1];
                            *dataPointer = objectIndices.GetSingleValue();
                            marshalledObjectIndices = dataPointer;
                        }
                        else
                        {
                            var arrayValue = objectIndices.GetArrayValue();
                            objectIndicesHandle = GCHandle.Alloc(arrayValue.Array);
                            marshalledObjectIndices = (uint*)(objectIndicesHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<uint>() * arrayValue.Offset)).ToPointer();
                        }
                    }
                    else
                    {
                        marshalledObjectIndices = null;
                    }
                    commandResult = commandDelegate(this.parent.handle, this.handle, (uint)(objectIndices.Length), doubleMarshalledObjectTableEntries, marshalledObjectIndices);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    if (objectTableEntriesHandle.IsAllocated) objectTableEntriesHandle.Free();
                    if (objectIndicesHandle.IsAllocated) objectIndicesHandle.Free();
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
        public void UnregisterObjects(ArrayProxy<ObjectEntryType> objectEntryTypes, ArrayProxy<uint> objectIndices)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkUnregisterObjectsNVX>("vkUnregisterObjectsNVX", "device");
                    Result commandResult;
                    GCHandle objectEntryTypesHandle = default(GCHandle);
                    ObjectEntryType* marshalledObjectEntryTypes = null;
                    if (objectEntryTypes.Contents != ProxyContents.Null)
                    {
                        if(objectEntryTypes.Contents == ProxyContents.Single)
                        {
                            ObjectEntryType* dataPointer = stackalloc ObjectEntryType[1];
                            *dataPointer = objectEntryTypes.GetSingleValue();
                            marshalledObjectEntryTypes = dataPointer;
                        }
                        else
                        {
                            var arrayValue = objectEntryTypes.GetArrayValue();
                            objectEntryTypesHandle = GCHandle.Alloc(arrayValue.Array);
                            marshalledObjectEntryTypes = (ObjectEntryType*)(objectEntryTypesHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<ObjectEntryType>() * arrayValue.Offset)).ToPointer();
                        }
                    }
                    else
                    {
                        marshalledObjectEntryTypes = null;
                    }
                    GCHandle objectIndicesHandle = default(GCHandle);
                    uint* marshalledObjectIndices = null;
                    if (objectIndices.Contents != ProxyContents.Null)
                    {
                        if(objectIndices.Contents == ProxyContents.Single)
                        {
                            uint* dataPointer = stackalloc uint[1];
                            *dataPointer = objectIndices.GetSingleValue();
                            marshalledObjectIndices = dataPointer;
                        }
                        else
                        {
                            var arrayValue = objectIndices.GetArrayValue();
                            objectIndicesHandle = GCHandle.Alloc(arrayValue.Array);
                            marshalledObjectIndices = (uint*)(objectIndicesHandle.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<uint>() * arrayValue.Offset)).ToPointer();
                        }
                    }
                    else
                    {
                        marshalledObjectIndices = null;
                    }
                    commandResult = commandDelegate(this.parent.handle, this.handle, (uint)(objectIndices.Length), marshalledObjectEntryTypes, marshalledObjectIndices);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    if (objectEntryTypesHandle.IsAllocated) objectEntryTypesHandle.Free();
                    if (objectIndicesHandle.IsAllocated) objectIndicesHandle.Free();
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal unsafe void MarshalTo(Interop.ObjectTable* pointer)
        {
            *pointer = this.handle;
        }
        
        /// <summary>
        /// The interop handle for this ObjectTable.
        /// </summary>
        public Interop.ObjectTable RawHandle => this.handle;
        
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
