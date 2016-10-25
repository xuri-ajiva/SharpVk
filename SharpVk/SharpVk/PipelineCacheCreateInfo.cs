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
    /// Structure specifying parameters of a newly created pipeline cache.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:initialDataSize is not `0`, it must: be
    /// equal to the size of pname:pInitialData, as returned by
    /// fname:vkGetPipelineCacheData when pname:pInitialData was originally
    /// retrieved * If pname:initialDataSize is not `0`, pname:pInitialData
    /// must: have been retrieved from a previous call to
    /// fname:vkGetPipelineCacheData ****
    /// </para>
    /// </summary>
    public struct PipelineCacheCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineCacheCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pInitialData is a pointer to previously retrieved pipeline
        /// cache data. If the pipeline cache data is incompatible (as defined
        /// below) with the device, the pipeline cache will be initially empty.
        /// If pname:initialDataSize is zero, pname:pInitialData is ignored.
        /// </summary>
        public byte[] InitialData
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineCacheCreateInfo Pack()
        {
            Interop.PipelineCacheCreateInfo result = default(Interop.PipelineCacheCreateInfo);
            result.SType = StructureType.PipelineCacheCreateInfo;
            result.InitialData = this.InitialData == null ? null : Interop.HeapUtil.MarshalTo(this.InitialData);
            result.InitialDataSize = (Size)(this.InitialData?.Length ?? 0);
            result.Flags = this.Flags;
            return result;
        }
        
        internal unsafe Interop.PipelineCacheCreateInfo* MarshalTo()
        {
            return (Interop.PipelineCacheCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
