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
    /// 
    /// </summary>
    public partial class CommandBuffer
    {
        internal readonly SharpVk.Interop.CommandBuffer handle; 
        
        internal CommandBuffer(SharpVk.Interop.CommandBuffer handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Result Begin()
        {
            Result result = default(Result);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Result End()
        {
            Result result = default(Result);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Result Reset()
        {
            Result result = default(Result);
            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindPipeline()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetViewport()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetScissor()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetLineWidth()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetDepthBias()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetBlendConstants()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetDepthBounds()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetStencilCompareMask()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetStencilWriteMask()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetStencilReference()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindDescriptorSets()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindIndexBuffer()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BindVertexBuffers()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Draw()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DrawIndexed()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DrawIndirect()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DrawIndexedIndirect()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Dispatch()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void DispatchIndirect()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyBuffer()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyImage()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BlitImage()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyBufferToImage()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyImageToBuffer()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void UpdateBuffer()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void FillBuffer()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ClearColorImage()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ClearDepthStencilImage()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ClearAttachments()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ResolveImage()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetEvent()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ResetEvent()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void WaitEvents()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void PipelineBarrier()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BeginQuery()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void EndQuery()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ResetQueryPool()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void WriteTimestamp()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CopyQueryPoolResults()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void PushConstants()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void BeginRenderPass()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void NextSubpass()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void EndRenderPass()
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ExecuteCommands()
        {
        }
    }
}
