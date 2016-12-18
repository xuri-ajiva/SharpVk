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
    /// how the stencil data is handled. pname:loadOp and pname:stencilLoadOp
    /// define the _load operations_ that execute as part of the first subpass
    /// that uses the attachment. pname:storeOp and pname:stencilStoreOp define
    /// the _store operations_ that execute as part of the last subpass that
    /// uses the attachment.
    /// </para>
    /// <para>
    /// The load operation for each value in an attachment used by a subpass
    /// happens-before any command recorded into that subpass reads from that
    /// value. Load operations for attachments with a depth/stencil format
    /// execute in the ename:VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT
    /// pipeline stage. Load operations for attachments with a color format
    /// execute in the ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT
    /// pipeline stage.
    /// </para>
    /// <para>
    /// Store operations for each value in an attachment used by a subpass
    /// happen-after any command recorded into that subpass writes to that
    /// value. Store operations for attachments with a depth/stencil format
    /// execute in the ename:VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT pipeline
    /// stage. Store operations for attachments with a color format execute in
    /// the ename:VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT pipeline stage.
    /// </para>
    /// <para>
    /// If an attachment is not used by any subpass, then pname:loadOp,
    /// pname:storeOp, pname:stencilStoreOp, and pname:stencilLoadOp are
    /// ignored, and the attachment's memory contents will not be modified by
    /// execution of a render pass instance.
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
