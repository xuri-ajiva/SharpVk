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
    /// Bitmask specifying constraints on a query.
    /// </para>
    /// <para>
    /// If the pname:queryType of the pool is ename:VK_QUERY_TYPE_OCCLUSION and
    /// pname:flags contains ename:VK_QUERY_CONTROL_PRECISE_BIT, an
    /// implementation must: return a result that matches the actual number of
    /// samples passed. This is described in more detail in
    /// &lt;&lt;queries-occlusion,Occlusion Queries&gt;&gt;.
    /// </para>
    /// <para>
    /// After beginning a query, that query is considered _active_ within the
    /// command buffer it was called in until that same query is ended. Queries
    /// active in a primary command buffer when secondary command buffers are
    /// executed are considered active for those secondary command buffers.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The query identified by pname:queryPool and
    /// pname:query must: currently not be
    /// &lt;&lt;queries-operation-active,active&gt;&gt; * The query identified
    /// by pname:queryPool and pname:query must: be unavailable * If the
    /// &lt;&lt;features-features-occlusionQueryPrecise,precise occlusion
    /// queries&gt;&gt; feature is not enabled, or the pname:queryType used to
    /// create pname:queryPool was not ename:VK_QUERY_TYPE_OCCLUSION,
    /// pname:flags must: not contain ename:VK_QUERY_CONTROL_PRECISE_BIT *
    /// pname:queryPool must: have been created with a pname:queryType that
    /// differs from that of any other queries that have been made
    /// &lt;&lt;queries-operation-active,active&gt;&gt;, and are currently
    /// still active within pname:commandBuffer * pname:query must: be less
    /// than the number of queries in pname:queryPool * If the pname:queryType
    /// used to create pname:queryPool was ename:VK_QUERY_TYPE_OCCLUSION, the
    /// sname:VkCommandPool that pname:commandBuffer was allocated from must:
    /// support graphics operations * If the pname:queryType used to create
    /// pname:queryPool was ename:VK_QUERY_TYPE_PIPELINE_STATISTICS and any of
    /// the pname:pipelineStatistics indicate graphics operations, the
    /// sname:VkCommandPool that pname:commandBuffer was allocated from must:
    /// support graphics operations * If the pname:queryType used to create
    /// pname:queryPool was ename:VK_QUERY_TYPE_PIPELINE_STATISTICS and any of
    /// the pname:pipelineStatistics indicate compute operations, the
    /// sname:VkCommandPool that pname:commandBuffer was allocated from must:
    /// support compute operations ****
    /// </para>
    /// </summary>
    [Flags]
    public enum QueryControlFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Require precise results to be collected by the query
        /// </summary>
        Precise = 1 << 0, 
    }
}
