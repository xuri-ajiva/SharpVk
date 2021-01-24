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

using System.Runtime.InteropServices;

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceShaderAtomicFloatFeatures
    {
        /// <summary>
        /// </summary>
        public bool ShaderBufferFloat32Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderBufferFloat32AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderBufferFloat64Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderBufferFloat64AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderSharedFloat32Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderSharedFloat32AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderSharedFloat64Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderSharedFloat64AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderImageFloat32Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool ShaderImageFloat32AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool SparseImageFloat32Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool SparseImageFloat32AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceShaderAtomicFloatFeatures;
            pointer->Next = null;
            pointer->ShaderBufferFloat32Atomics = ShaderBufferFloat32Atomics;
            pointer->ShaderBufferFloat32AtomicAdd = ShaderBufferFloat32AtomicAdd;
            pointer->ShaderBufferFloat64Atomics = ShaderBufferFloat64Atomics;
            pointer->ShaderBufferFloat64AtomicAdd = ShaderBufferFloat64AtomicAdd;
            pointer->ShaderSharedFloat32Atomics = ShaderSharedFloat32Atomics;
            pointer->ShaderSharedFloat32AtomicAdd = ShaderSharedFloat32AtomicAdd;
            pointer->ShaderSharedFloat64Atomics = ShaderSharedFloat64Atomics;
            pointer->ShaderSharedFloat64AtomicAdd = ShaderSharedFloat64AtomicAdd;
            pointer->ShaderImageFloat32Atomics = ShaderImageFloat32Atomics;
            pointer->ShaderImageFloat32AtomicAdd = ShaderImageFloat32AtomicAdd;
            pointer->SparseImageFloat32Atomics = SparseImageFloat32Atomics;
            pointer->SparseImageFloat32AtomicAdd = SparseImageFloat32AtomicAdd;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceShaderAtomicFloatFeatures MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures* pointer)
        {
            PhysicalDeviceShaderAtomicFloatFeatures result = default;
            result.ShaderBufferFloat32Atomics = pointer->ShaderBufferFloat32Atomics;
            result.ShaderBufferFloat32AtomicAdd = pointer->ShaderBufferFloat32AtomicAdd;
            result.ShaderBufferFloat64Atomics = pointer->ShaderBufferFloat64Atomics;
            result.ShaderBufferFloat64AtomicAdd = pointer->ShaderBufferFloat64AtomicAdd;
            result.ShaderSharedFloat32Atomics = pointer->ShaderSharedFloat32Atomics;
            result.ShaderSharedFloat32AtomicAdd = pointer->ShaderSharedFloat32AtomicAdd;
            result.ShaderSharedFloat64Atomics = pointer->ShaderSharedFloat64Atomics;
            result.ShaderSharedFloat64AtomicAdd = pointer->ShaderSharedFloat64AtomicAdd;
            result.ShaderImageFloat32Atomics = pointer->ShaderImageFloat32Atomics;
            result.ShaderImageFloat32AtomicAdd = pointer->ShaderImageFloat32AtomicAdd;
            result.SparseImageFloat32Atomics = pointer->SparseImageFloat32Atomics;
            result.SparseImageFloat32AtomicAdd = pointer->SparseImageFloat32AtomicAdd;
            return result;
        }
    }
}
