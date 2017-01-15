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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Import Win32 memory created on the same physical device.
    /// </para>
    /// <para>
    /// To import memory created on the same physical device but outside of the
    /// current Vulkan instance, add a slink:VkImportMemoryWin32HandleInfoNV
    /// structure to the pname:pNext chain of the slink:VkMemoryAllocateInfo
    /// structure, specifying a handle to and the type of the memory.
    /// </para>
    /// </summary>
    public struct ImportMemoryWin32HandleInfo
    {
        /// <summary>
        /// pname:handleType is 0 or a flag specifying the type of memory
        /// handle in pname:handle. Flags which may: be specified are: + --
        /// </summary>
        public ExternalMemoryHandleTypeFlags HandleType
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public IntPtr Handle
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImportMemoryWin32HandleInfo* MarshalTo()
        {
            var result = (Interop.ImportMemoryWin32HandleInfo*)Interop.HeapUtil.AllocateAndClear<Interop.ImportMemoryWin32HandleInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.ImportMemoryWin32HandleInfo* pointer)
        {
            pointer->SType = StructureType.ImportMemoryWin32HandleInfo;
            pointer->Next = null;
            pointer->HandleType = this.HandleType;
            pointer->Handle = this.Handle;
        }
    }
}
