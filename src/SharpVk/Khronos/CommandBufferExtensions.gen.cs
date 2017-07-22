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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Pushes descriptor updates into a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void PushDescriptorSet(this SharpVk.CommandBuffer extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.PipelineLayout layout, uint set, SharpVk.WriteDescriptorSet[] descriptorWrites)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.WriteDescriptorSet* marshalledDescriptorWrites = default(SharpVk.Interop.WriteDescriptorSet*);
                commandCache = extendedHandle.commandCache;
                if (descriptorWrites != null)
                {
                    var fieldPointer = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.WriteDescriptorSet>(descriptorWrites.Length).ToPointer());
                    for(int index = 0; index < (uint)(descriptorWrites.Length); index++)
                    {
                        descriptorWrites[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledDescriptorWrites = fieldPointer;
                }
                else
                {
                    marshalledDescriptorWrites = null;
                }
                SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetDelegate>("vkCmdPushDescriptorSetKHR", "instance");
                commandDelegate(extendedHandle.handle, pipelineBindPoint, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), set, (uint)(descriptorWrites?.Length ?? 0), marshalledDescriptorWrites);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Pushes descriptor updates into a command buffer using a descriptor
        /// update template.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void PushDescriptorSetWithTemplate(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.DescriptorUpdateTemplate descriptorUpdateTemplate, SharpVk.PipelineLayout layout, uint set, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetWithTemplateDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetWithTemplateDelegate>("vkCmdPushDescriptorSetWithTemplateKHR", "instance");
                commandDelegate(extendedHandle.handle, descriptorUpdateTemplate?.handle ?? default(SharpVk.Interop.Khronos.DescriptorUpdateTemplate), layout?.handle ?? default(SharpVk.Interop.PipelineLayout), set, data.ToPointer());
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
