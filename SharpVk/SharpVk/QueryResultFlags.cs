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
    /// Bitmask specifying how and when query results are returned.
    /// </para>
    /// <para>
    /// If no bits are set in pname:flags, and all requested queries are in the
    /// available state, results are written as an array of 32-bit unsigned
    /// integer values. The behavior when not all queries are available, is
    /// described &lt;&lt;queries-wait-bit-not-set, below&gt;&gt;.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_64_BIT is not set and the result overflows a
    /// 32-bit value, the value may: either wrap or saturate. Similarly, if
    /// ename:VK_QUERY_RESULT_64_BIT is set and the result overflows a 64-bit
    /// value, the value may: either wrap or saturate.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_WAIT_BIT is set, Vulkan will wait for each
    /// query to be in the available state before retrieving the numerical
    /// results for that query. In this case, fname:vkGetQueryPoolResults is
    /// guaranteed to succeed and return ename:VK_SUCCESS if the queries become
    /// available in a finite time (i.e. if they have been issued and not
    /// reset). If queries will never finish (e.g. due to being reset but not
    /// issued), then fname:vkGetQueryPoolResults may: not return in finite
    /// time.
    /// </para>
    /// <para>
    /// If ename:VK_QUERY_RESULT_WAIT_BIT and ename:VK_QUERY_RESULT_PARTIAL_BIT
    /// are both not set then no result values are written to pname:pData for
    /// queries that are in the unavailable state at the time of the call, and
    /// fname:vkGetQueryPoolResults returns ename:VK_NOT_READY. However,
    /// availability state is still written to pname:pData for those queries if
    /// ename:VK_QUERY_RESULT_WITH_AVAILABILITY_BIT is set.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Applications must: take care to ensure that use of
    /// the ename:VK_QUERY_RESULT_WAIT_BIT bit has the desired effect.
    /// </para>
    /// </summary>
    [Flags]
    public enum QueryResultFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Results of the queries are written to the destination buffer as
        /// 64-bit values
        /// </summary>
        QueryResult64 = 1 << 0, 
        
        /// <summary>
        /// Results of the queries are waited on before proceeding with the
        /// result copy
        /// </summary>
        Wait = 1 << 1, 
        
        /// <summary>
        /// Besides the results of the query, the availability of the results
        /// is also written
        /// </summary>
        WithAvailability = 1 << 2, 
        
        /// <summary>
        /// Copy the partial results of the query even if the final results are
        /// not available
        /// </summary>
        Partial = 1 << 3, 
    }
}
