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
    /// Specify the type of queries managed by a query pool.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-pipelineStatisticsQuery,pipeline statistics
    /// queries&gt;&gt; feature is not enabled, pname:queryType must: not be
    /// ename:VK_QUERY_TYPE_PIPELINE_STATISTICS * If pname:queryType is
    /// ename:VK_QUERY_TYPE_PIPELINE_STATISTICS, pname:pipelineStatistics must:
    /// be a valid combination of elink:VkQueryPipelineStatisticFlagBits values
    /// ****
    /// </para>
    /// </summary>
    public enum QueryType
    {
        /// <summary>
        /// -
        /// </summary>
        Occlusion = 0, 
        
        /// <summary>
        /// Optional
        /// </summary>
        PipelineStatistics = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        Timestamp = 2, 
    }
}
