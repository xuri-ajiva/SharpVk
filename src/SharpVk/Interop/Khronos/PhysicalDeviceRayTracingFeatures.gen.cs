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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceRayTracingFeatures
    {
        /// <summary>
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracing; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracingShaderGroupHandleCaptureReplay; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracingShaderGroupHandleCaptureReplayMixed; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracingAccelerationStructureCaptureReplay; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracingIndirectTraceRays; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracingIndirectAccelerationStructureBuild; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracingHostAccelerationStructureCommands; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayQuery; 
        
        /// <summary>
        /// </summary>
        public Bool32 RayTracingPrimitiveCulling; 
    }
}
