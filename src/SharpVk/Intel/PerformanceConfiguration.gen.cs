// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2019
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

namespace SharpVk.Intel
{
    /// <summary>
    /// Device configuration for performance queries
    /// </summary>
    public partial class PerformanceConfiguration
    {
        internal readonly SharpVk.Interop.Intel.PerformanceConfiguration handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal PerformanceConfiguration(SharpVk.Device parent, SharpVk.Interop.Intel.PerformanceConfiguration handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Intel.PerformanceConfiguration RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Release()
        {
            try
            {
                SharpVk.Interop.Intel.VkPerformanceConfigurationINTELReleaseDelegate commandDelegate = commandCache.Cache.vkReleasePerformanceConfigurationINTEL;
                Result methodResult = commandDelegate(this.parent.handle, this.handle);
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
