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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceRayTracingFeatures
    {
        /// <summary>
        /// </summary>
        public bool RayTracing
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayTracingShaderGroupHandleCaptureReplay
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayTracingShaderGroupHandleCaptureReplayMixed
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayTracingAccelerationStructureCaptureReplay
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayTracingIndirectTraceRays
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayTracingIndirectAccelerationStructureBuild
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayTracingHostAccelerationStructureCommands
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayQuery
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool RayTracingPrimitiveCulling
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PhysicalDeviceRayTracingFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceRayTracingFeatures;
            pointer->Next = null;
            pointer->RayTracing = RayTracing;
            pointer->RayTracingShaderGroupHandleCaptureReplay = RayTracingShaderGroupHandleCaptureReplay;
            pointer->RayTracingShaderGroupHandleCaptureReplayMixed = RayTracingShaderGroupHandleCaptureReplayMixed;
            pointer->RayTracingAccelerationStructureCaptureReplay = RayTracingAccelerationStructureCaptureReplay;
            pointer->RayTracingIndirectTraceRays = RayTracingIndirectTraceRays;
            pointer->RayTracingIndirectAccelerationStructureBuild = RayTracingIndirectAccelerationStructureBuild;
            pointer->RayTracingHostAccelerationStructureCommands = RayTracingHostAccelerationStructureCommands;
            pointer->RayQuery = RayQuery;
            pointer->RayTracingPrimitiveCulling = RayTracingPrimitiveCulling;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceRayTracingFeatures MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceRayTracingFeatures* pointer)
        {
            PhysicalDeviceRayTracingFeatures result = default;
            result.RayTracing = pointer->RayTracing;
            result.RayTracingShaderGroupHandleCaptureReplay = pointer->RayTracingShaderGroupHandleCaptureReplay;
            result.RayTracingShaderGroupHandleCaptureReplayMixed = pointer->RayTracingShaderGroupHandleCaptureReplayMixed;
            result.RayTracingAccelerationStructureCaptureReplay = pointer->RayTracingAccelerationStructureCaptureReplay;
            result.RayTracingIndirectTraceRays = pointer->RayTracingIndirectTraceRays;
            result.RayTracingIndirectAccelerationStructureBuild = pointer->RayTracingIndirectAccelerationStructureBuild;
            result.RayTracingHostAccelerationStructureCommands = pointer->RayTracingHostAccelerationStructureCommands;
            result.RayQuery = pointer->RayQuery;
            result.RayTracingPrimitiveCulling = pointer->RayTracingPrimitiveCulling;
            return result;
        }
    }
}
