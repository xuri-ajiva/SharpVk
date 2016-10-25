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
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying a dispatch indirect command.
    /// </para>
    /// <para>
    /// The members of sname:VkDispatchIndirectCommand structure have the same
    /// meaning as the similarly named parameters of flink:vkCmdDispatch.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:x must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxComputeWorkGroupCount[0] *
    /// pname:y must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxComputeWorkGroupCount[1] *
    /// pname:z must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxComputeWorkGroupCount[2] ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DispatchIndirectCommand
    {
        /// <summary>
        /// pname:x is the number of local workgroups to dispatch in the X
        /// dimension.
        /// </summary>
        public uint X; 
        
        /// <summary>
        /// pname:y is the number of local workgroups to dispatch in the Y
        /// dimension.
        /// </summary>
        public uint Y; 
        
        /// <summary>
        /// pname:z is the number of local workgroups to dispatch in the Z
        /// dimension.
        /// </summary>
        public uint Z; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("DispatchIndirectCommand");
            builder.AppendLine("{");
            builder.AppendLine($"X: {this.X}");
            builder.AppendLine($"Y: {this.Y}");
            builder.AppendLine($"Z: {this.Z}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
