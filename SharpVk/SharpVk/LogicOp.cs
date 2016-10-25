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
    /// Framebuffer logical operations.
    /// </para>
    /// <para>
    /// &lt;&lt;&lt;
    /// </para>
    /// <para>
    /// The logical operations supported by Vulkan are summarized in the
    /// following table in which
    /// </para>
    /// <para>
    /// * [eq]#{lnot}# is bitwise invert, * [eq]#{land}# is bitwise and, *
    /// [eq]#{lor}# is bitwise or, * [eq]#{oplus}# is bitwise exclusive or, *
    /// [eq]#s# is the fragment's [eq]#R~s0~, G~s0~, B~s0~# or [eq]#A~s0~#
    /// component value for the fragment output corresponding to the color
    /// attachment being updated, and * [eq]#d# is the color attachment's
    /// [eq]#R, G, B# or [eq]#A# component value:
    /// </para>
    /// <para>
    /// .Logical Operations [width="75%",options="header",align="center"] |====
    /// |Mode | Operation |ename:VK_LOGIC_OP_CLEAR | [eq]#0#
    /// |ename:VK_LOGIC_OP_AND | [eq]#s {land} d#
    /// |ename:VK_LOGIC_OP_AND_REVERSE | [eq]#s {land} {lnot} d#
    /// |ename:VK_LOGIC_OP_COPY | [eq]#s# |ename:VK_LOGIC_OP_AND_INVERTED |
    /// [eq]#{lnot} s {land} d# |ename:VK_LOGIC_OP_NO_OP | [eq]#d#
    /// |ename:VK_LOGIC_OP_XOR | [eq]#s {oplus} d# |ename:VK_LOGIC_OP_OR |
    /// [eq]#s {lor} d# |ename:VK_LOGIC_OP_NOR | [eq]#{lnot} (s {lor} d)#
    /// |ename:VK_LOGIC_OP_EQUIVALENT | [eq]#{lnot} (s {oplus} d)#
    /// |ename:VK_LOGIC_OP_INVERT | [eq]#{lnot} d#
    /// |ename:VK_LOGIC_OP_OR_REVERSE | [eq]#s {lor} {lnot} d#
    /// |ename:VK_LOGIC_OP_COPY_INVERTED | [eq]#{lnot} s#
    /// |ename:VK_LOGIC_OP_OR_INVERTED | [eq]#{lnot} s {lor} d#
    /// |ename:VK_LOGIC_OP_NAND | [eq]#{lnot} (s {land} d)#
    /// |ename:VK_LOGIC_OP_SET | all 1s |====
    /// </para>
    /// <para>
    /// The result of the logical operation is then written to the color
    /// attachment as controlled by the component write mask, described in
    /// &lt;&lt;framebuffer-blendoperations,Blend Operations&gt;&gt;.
    /// </para>
    /// </summary>
    public enum LogicOp
    {
        /// <summary>
        /// -
        /// </summary>
        Clear = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        And = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        AndReverse = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Copy = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        AndInverted = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        NoOp = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        Xor = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        Or = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        Nor = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        Equivalent = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        Invert = 10, 
        
        /// <summary>
        /// -
        /// </summary>
        OrReverse = 11, 
        
        /// <summary>
        /// -
        /// </summary>
        CopyInverted = 12, 
        
        /// <summary>
        /// -
        /// </summary>
        OrInverted = 13, 
        
        /// <summary>
        /// -
        /// </summary>
        Nand = 14, 
        
        /// <summary>
        /// -
        /// </summary>
        Set = 15, 
    }
}
