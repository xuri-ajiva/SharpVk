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
    /// Bitmask specifying queried pipeline statistics.
    /// </para>
    /// <para>
    /// These bits have the following meanings:
    /// </para>
    /// </summary>
    [Flags]
    public enum QueryPipelineStatisticFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Optional
        /// </summary>
        InputAssemblyVertices = 1 << 0, 
        
        /// <summary>
        /// Optional
        /// </summary>
        InputAssemblyPrimitives = 1 << 1, 
        
        /// <summary>
        /// Optional
        /// </summary>
        VertexShaderInvocations = 1 << 2, 
        
        /// <summary>
        /// Optional
        /// </summary>
        GeometryShaderInvocations = 1 << 3, 
        
        /// <summary>
        /// Optional
        /// </summary>
        GeometryShaderPrimitives = 1 << 4, 
        
        /// <summary>
        /// Optional
        /// </summary>
        ClippingInvocations = 1 << 5, 
        
        /// <summary>
        /// Optional
        /// </summary>
        ClippingPrimitives = 1 << 6, 
        
        /// <summary>
        /// Optional
        /// </summary>
        FragmentShaderInvocations = 1 << 7, 
        
        /// <summary>
        /// Optional
        /// </summary>
        TessellationControlShaderPatches = 1 << 8, 
        
        /// <summary>
        /// Optional
        /// </summary>
        TessellationEvaluationShaderInvocations = 1 << 9, 
        
        /// <summary>
        /// Optional
        /// </summary>
        ComputeShaderInvocations = 1 << 10, 
    }
}
