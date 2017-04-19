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

namespace SharpVk.Khx
{
    /// <summary>
    /// 
    /// </summary>
    public struct Win32KeyedMutexAcquireReleaseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceMemory[] AcquireSyncs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong[] AcquireKeys
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] AcquireTimeouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceMemory[] ReleaseSyncs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong[] ReleaseKeys
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.Khx.Win32KeyedMutexAcquireReleaseInfo* pointer)
        {
            pointer->SType = StructureType.Win32KeyedMutexAcquireReleaseInfoKhx;
            pointer->Next = null;
            pointer->AcquireCount = (uint)this.AcquireSyncs.Length;
            if (this.AcquireSyncs != null)
            {
                var fieldPointer = (Interop.DeviceMemory*)Interop.HeapUtil.AllocateAndClear<Interop.DeviceMemory>(this.AcquireSyncs.Length).ToPointer();
                for(int index = 0; index < this.AcquireSyncs.Length; index++)
                {
                    fieldPointer[index] = this.AcquireSyncs[index].handle;
                }
                pointer->AcquireSyncs = fieldPointer;
            }
            else
            {
                pointer->AcquireSyncs = null;
            }
            if (this.AcquireKeys != null)
            {
                var fieldPointer = (ulong*)Interop.HeapUtil.AllocateAndClear<ulong>(this.AcquireKeys.Length).ToPointer();
                for(int index = 0; index < this.AcquireKeys.Length; index++)
                {
                    fieldPointer[index] = this.AcquireKeys[index];
                }
                pointer->AcquireKeys = fieldPointer;
            }
            else
            {
                pointer->AcquireKeys = null;
            }
            if (this.AcquireTimeouts != null)
            {
                var fieldPointer = (uint*)Interop.HeapUtil.AllocateAndClear<uint>(this.AcquireTimeouts.Length).ToPointer();
                for(int index = 0; index < this.AcquireTimeouts.Length; index++)
                {
                    fieldPointer[index] = this.AcquireTimeouts[index];
                }
                pointer->AcquireTimeouts = fieldPointer;
            }
            else
            {
                pointer->AcquireTimeouts = null;
            }
            pointer->ReleaseCount = (uint)this.ReleaseSyncs.Length;
            if (this.ReleaseSyncs != null)
            {
                var fieldPointer = (Interop.DeviceMemory*)Interop.HeapUtil.AllocateAndClear<Interop.DeviceMemory>(this.ReleaseSyncs.Length).ToPointer();
                for(int index = 0; index < this.ReleaseSyncs.Length; index++)
                {
                    fieldPointer[index] = this.ReleaseSyncs[index].handle;
                }
                pointer->ReleaseSyncs = fieldPointer;
            }
            else
            {
                pointer->ReleaseSyncs = null;
            }
            if (this.ReleaseKeys != null)
            {
                var fieldPointer = (ulong*)Interop.HeapUtil.AllocateAndClear<ulong>(this.ReleaseKeys.Length).ToPointer();
                for(int index = 0; index < this.ReleaseKeys.Length; index++)
                {
                    fieldPointer[index] = this.ReleaseKeys[index];
                }
                pointer->ReleaseKeys = fieldPointer;
            }
            else
            {
                pointer->ReleaseKeys = null;
            }
        }
    }
}
