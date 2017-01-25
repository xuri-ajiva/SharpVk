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
    /// <para>
    /// Bitmask specifying allowed usage of a indirect commands layout.
    /// </para>
    /// <para>
    /// The following code illustrates some of the key flags:
    /// </para>
    /// <para>
    /// [source,c] --------------------------------------------------- void
    /// cmdProcessAllSequences(cmd, objectTable, indirectCommandsLayout,
    /// pIndirectCommandsTokens, sequencesCount, indexbuffer,
    /// indexbufferoffset) { for (s = 0; s &lt; sequencesCount; s++) { sequence
    /// = s;
    /// </para>
    /// <para>
    /// if (indirectCommandsLayout.flags &amp;
    /// VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NVX) {
    /// sequence = incoherent_implementation_dependent_permutation[ sequence ];
    /// } if (indirectCommandsLayout.flags &amp;
    /// VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVX) { sequence
    /// = indexbuffer.load_uint32( sequence * sizeof(uint32_t) +
    /// indexbufferoffset); }
    /// </para>
    /// <para>
    /// cmdProcessSequence( cmd, objectTable, indirectCommandsLayout,
    /// pIndirectCommandsTokens, sequence ); } }
    /// ---------------------------------------------------
    /// </para>
    /// </summary>
    [Flags]
    public enum IndirectCommandsLayoutUsageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NVX
        /// indicates that the processing of sequences can: happen at an
        /// implementation-dependent order, which is not guaranteed to be
        /// coherent across multiple invocations.
        /// </summary>
        UnorderedSequences = 1 << 0, 
        
        /// <summary>
        /// ename:VK_INDIRECT_COMMANDS_LAYOUT_USAGE_SPARSE_SEQUENCES_BIT_NVX
        /// indicates that there is likely a high difference between allocated
        /// number of sequences and actually used.
        /// </summary>
        SparseSequences = 1 << 1, 
        
        /// <summary>
        /// ename:VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EMPTY_EXECUTIONS_BIT_NVX
        /// indicates that there is likely many draw or dispatch calls that are
        /// zero-sized (zero grid dimension, no primitives to render).
        /// </summary>
        EmptyExecutions = 1 << 2, 
        
        /// <summary>
        /// ename:VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NVX
        /// indicates that the input data for the sequences is not implicitly
        /// indexed from 0..sequencesUsed but a user provided sname:VkBuffer
        /// encoding the index is provided.
        /// </summary>
        IndexedSequences = 1 << 3, 
    }
}
