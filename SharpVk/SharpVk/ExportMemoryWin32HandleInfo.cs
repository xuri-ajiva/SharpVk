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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Specify security attributes and access rights for Win32 memory handles.
    /// </para>
    /// <para>
    /// When slink:VkExportMemoryAllocateInfoNV::pname:handleTypes includes
    /// ename:VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV, add a
    /// sname:VkExportMemoryWin32HandleInfoNV to the pname:pNext chain of the
    /// slink:VkExportMemoryAllocateInfoNV structure to specify security
    /// attributes and access rights for the memory object's external handle.
    /// </para>
    /// <para>
    /// If this structure is not present, or if pname:pAttributes is set to
    /// `NULL`, default security descriptor values will be used, and child
    /// processes created by the application will not inherit the handle, as
    /// described in the MSDN documentation for ``Synchronization Object
    /// Security and Access Rights''[1]. Further, if the structure is not
    /// present, the access rights will be
    /// </para>
    /// <para>
    /// code:DXGI_SHARED_RESOURCE_READ | code:DXGI_SHARED_RESOURCE_WRITE
    /// </para>
    /// <para>
    /// [1]
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms686670.aspx
    /// </para>
    /// </summary>
    public struct ExportMemoryWin32HandleInfo
    {
        /// <summary>
        /// pname:pAttributes is a pointer to a Windows
        /// code:SECURITY_ATTRIBUTES structure specifying security attributes
        /// of the handle.
        /// </summary>
        public SECURITY_ATTRIBUTES Attributes
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dwAccess is a code:DWORD specifying access rights of the
        /// handle.
        /// </summary>
        public uint DwAccess
        {
            get;
            set;
        }
        
        internal unsafe Interop.ExportMemoryWin32HandleInfo* MarshalTo()
        {
            var result = (Interop.ExportMemoryWin32HandleInfo*)Interop.HeapUtil.AllocateAndClear<Interop.ExportMemoryWin32HandleInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.ExportMemoryWin32HandleInfo* pointer)
        {
            pointer->SType = StructureType.ExportMemoryWin32HandleInfo;
            pointer->Attributes = (SECURITY_ATTRIBUTES*)Interop.HeapUtil.Allocate<SECURITY_ATTRIBUTES>();
            *pointer->Attributes = this.Attributes;
            pointer->DwAccess = this.DwAccess;
        }
    }
}
