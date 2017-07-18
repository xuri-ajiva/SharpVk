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

namespace SharpVk
{
    /// <summary>
    /// Bitmask controlling how a pipeline is generated.
    /// </summary>
    [System.Flags]
    public enum PipelineCreateFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that
        /// the created pipeline will not be optimized. Using this flag may:
        /// reduce the time taken to create the pipeline.
        /// </summary>
        DisableOptimization = 1 << 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the
        /// pipeline to be created is allowed to be the parent of a pipeline
        /// that will be created in a subsequent call to
        /// flink:vkCreateGraphicsPipelines.
        /// </summary>
        AllowDerivatives = 1 << 1, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline
        /// to be created will be a child of a previously created parent
        /// pipeline.
        /// </summary>
        Derivative = 1 << 2, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHX
        /// specifies that any shader input variables decorated as
        /// code:DeviceIndex will be assigned values as if they were decorated
        /// as code:ViewIndex.
        /// </summary>
        ViewIndexFromDeviceIndexBitKhx = 1 << 3, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DISPATCH_BASE_KHX specifies that a compute
        /// pipeline can: be used with flink:vkCmdDispatchBaseKHX with a
        /// non-zero base workgroup.
        /// </summary>
        DispatchBaseKhx = 1 << 4, 
    }
}
