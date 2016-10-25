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
    /// Use Windows keyex mutex mechanism to synchronize work.
    /// </para>
    /// <para>
    /// When submitting work that operates on memory imported from a Direct3D
    /// 11 resource to a queue, the keyed mutex mechanism may: be used in
    /// addition to Vulkan semaphores to synchronize the work. Keyed mutexes
    /// are a property of a properly created shareable Direct3D 11 resource.
    /// They can: only be used if the imported resource was created with the
    /// etext:D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX flag.
    /// </para>
    /// <para>
    /// To acquire keyed mutexes before submitted work and/or release them
    /// after, add a slink:VkWin32KeyedMutexAcquireReleaseInfoNV structure to
    /// the pname:pNext chain of the slink:VkSubmitInfo structure.
    /// </para>
    /// <para>
    /// * pname:acquireCount is the number of entries in the
    /// pname:pAcquireSyncs, pname:pAcquireKeys, and
    /// pname:pAcquireTimeoutMilliseconds arrays. * pname:pAcquireSyncs is a
    /// pointer to an array of slink:VkDeviceMemory objects which were imported
    /// from Direct3D 11 resources. * pname:pAcquireKeys is a pointer to an
    /// array of mutex key values to wait for prior to beginning the submitted
    /// work. Entries refer to the keyed mutex associated with the
    /// corresponding entries in pname:pAcquireSyncs. *
    /// pname:pAcquireTimeoutMilliseconds is an array of timeout values, in
    /// millisecond units, for each acquire specified in pname:pAcquireKeys. *
    /// pname:releaseCount is the number of entries in the pname:pReleaseSyncs
    /// and pname:pReleaseKeys arrays. * pname:pReleaseSyncs is a pointer to an
    /// array of slink:VkDeviceMemory objects which were imported from Direct3D
    /// 11 resources. * pname:pReleaseKeys is a pointer to an array of mutex
    /// key values to set when the submitted work has completed. Entries refer
    /// to the keyed mutex associated with the corresponding entries in
    /// pname:pReleaseSyncs.
    /// </para>
    /// </summary>
    public struct Win32KeyedMutexAcquireReleaseInfo
    {
        /// <summary>
        /// -
        /// </summary>
        public DeviceMemory[] AcquireSyncs
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public ulong[] AcquireKeys
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint[] AcquireTimeoutMilliseconds
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public DeviceMemory[] ReleaseSyncs
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public ulong[] ReleaseKeys
        {
            get;
            set;
        }
        
        internal unsafe Interop.Win32KeyedMutexAcquireReleaseInfo Pack()
        {
            Interop.Win32KeyedMutexAcquireReleaseInfo result = default(Interop.Win32KeyedMutexAcquireReleaseInfo);
            result.SType = StructureType.Win32KeyedMutexAcquireReleaseInfo;
            
            //AcquireSyncs
            if (this.AcquireSyncs != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DeviceMemory>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DeviceMemory>(this.AcquireSyncs.Length);
                for (int index = 0; index < this.AcquireSyncs.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.AcquireSyncs[index].Pack(), pointer + (size * index), false);
                }
                result.AcquireSyncs = (Interop.DeviceMemory*)pointer.ToPointer();
            }
            else
            {
                result.AcquireSyncs = null;
            }
            result.AcquireKeys = this.AcquireKeys == null ? null : Interop.HeapUtil.MarshalTo(this.AcquireKeys);
            result.AcquireTimeoutMilliseconds = this.AcquireTimeoutMilliseconds == null ? null : Interop.HeapUtil.MarshalTo(this.AcquireTimeoutMilliseconds);
            
            //ReleaseSyncs
            if (this.ReleaseSyncs != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DeviceMemory>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DeviceMemory>(this.ReleaseSyncs.Length);
                for (int index = 0; index < this.ReleaseSyncs.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.ReleaseSyncs[index].Pack(), pointer + (size * index), false);
                }
                result.ReleaseSyncs = (Interop.DeviceMemory*)pointer.ToPointer();
            }
            else
            {
                result.ReleaseSyncs = null;
            }
            result.ReleaseKeys = this.ReleaseKeys == null ? null : Interop.HeapUtil.MarshalTo(this.ReleaseKeys);
            result.AcquireCount = (uint)(this.AcquireTimeoutMilliseconds?.Length ?? 0);
            result.ReleaseCount = (uint)(this.ReleaseKeys?.Length ?? 0);
            return result;
        }
        
        internal unsafe Interop.Win32KeyedMutexAcquireReleaseInfo* MarshalTo()
        {
            return (Interop.Win32KeyedMutexAcquireReleaseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
