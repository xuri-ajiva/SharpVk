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
    /// Specify how contents of an attachment are treated at the end of a
    /// subpass.
    /// </para>
    /// <para>
    /// If the attachment uses a color format, then pname:loadOp and
    /// pname:storeOp are used, and pname:stencilLoadOp and
    /// pname:stencilStoreOp are ignored. If the format has depth and/or
    /// stencil components, pname:loadOp and pname:storeOp apply only to the
    /// depth data, while pname:stencilLoadOp and pname:stencilStoreOp define
    /// how the stencil data is handled.
    /// </para>
    /// <para>
    /// During a render pass instance, input/color attachments with color
    /// formats that have a component size of 8, 16, or 32 bits must: be
    /// represented in the attachment's format throughout the instance.
    /// Attachments with other floating- or fixed-point color formats, or with
    /// depth components may: be represented in a format with a precision
    /// higher than the attachment format, but must: be represented with the
    /// same range. When such a component is loaded via the pname:loadOp, it
    /// will be converted into an implementation-dependent format used by the
    /// render pass. Such components must: be converted from the render pass
    /// format, to the format of the attachment, before they are stored or
    /// resolved at the end of a render pass instance via pname:storeOp.
    /// Conversions occur as described in &lt;&lt;fundamentals-numerics,Numeric
    /// Representation and Computation&gt;&gt; and
    /// &lt;&lt;fundamentals-fixedconv, Fixed-Point Data Conversions&gt;&gt;.
    /// </para>
    /// <para>
    /// If pname:flags includes ename:VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT,
    /// then the attachment is treated as if it shares physical memory with
    /// another attachment in the same render pass. This information limits the
    /// ability of the implementation to reorder certain operations (like
    /// layout transitions and the pname:loadOp) such that it is not improperly
    /// reordered against other uses of the same physical memory via a
    /// different attachment. This is described in more detail below.
    /// </para>
    /// </summary>
    public enum AttachmentStoreOp
    {
        /// <summary>
        /// -
        /// </summary>
        Store = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        DontCare = 1, 
    }
}
