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
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure describing the fine-grained features that can be supported by
    /// an implementation.
    /// </para>
    /// <para>
    /// The members of the sname:VkPhysicalDeviceFeatures structure describe
    /// the following features:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceFeatures(Bool32 robustBufferAccess, Bool32 fullDrawIndexUInt32, Bool32 imageCubeArray, Bool32 independentBlend, Bool32 geometryShader, Bool32 tessellationShader, Bool32 sampleRateShading, Bool32 dualSourceBlend, Bool32 logicOp, Bool32 multiDrawIndirect, Bool32 drawIndirectFirstInstance, Bool32 depthClamp, Bool32 depthBiasClamp, Bool32 fillModeNonSolid, Bool32 depthBounds, Bool32 wideLines, Bool32 largePoints, Bool32 alphaToOne, Bool32 multiViewport, Bool32 samplerAnisotropy, Bool32 textureCompressionETC2, Bool32 textureCompressionASTC_LDR, Bool32 textureCompressionBC, Bool32 occlusionQueryPrecise, Bool32 pipelineStatisticsQuery, Bool32 vertexPipelineStoresAndAtomics, Bool32 fragmentStoresAndAtomics, Bool32 shaderTessellationAndGeometryPointSize, Bool32 shaderImageGatherExtended, Bool32 shaderStorageImageExtendedFormats, Bool32 shaderStorageImageMultisample, Bool32 shaderStorageImageReadWithoutFormat, Bool32 shaderStorageImageWriteWithoutFormat, Bool32 shaderUniformBufferArrayDynamicIndexing, Bool32 shaderSampledImageArrayDynamicIndexing, Bool32 shaderStorageBufferArrayDynamicIndexing, Bool32 shaderStorageImageArrayDynamicIndexing, Bool32 shaderClipDistance, Bool32 shaderCullDistance, Bool32 shaderFloat64, Bool32 shaderInt64, Bool32 shaderInt16, Bool32 shaderResourceResidency, Bool32 shaderResourceMinLod, Bool32 sparseBinding, Bool32 sparseResidencyBuffer, Bool32 sparseResidencyImage2D, Bool32 sparseResidencyImage3D, Bool32 sparseResidency2Samples, Bool32 sparseResidency4Samples, Bool32 sparseResidency8Samples, Bool32 sparseResidency16Samples, Bool32 sparseResidencyAliased, Bool32 variableMultisampleRate, Bool32 inheritedQueries)
        {
            this.RobustBufferAccess = robustBufferAccess;
            this.FullDrawIndexUInt32 = fullDrawIndexUInt32;
            this.ImageCubeArray = imageCubeArray;
            this.IndependentBlend = independentBlend;
            this.GeometryShader = geometryShader;
            this.TessellationShader = tessellationShader;
            this.SampleRateShading = sampleRateShading;
            this.DualSourceBlend = dualSourceBlend;
            this.LogicOp = logicOp;
            this.MultiDrawIndirect = multiDrawIndirect;
            this.DrawIndirectFirstInstance = drawIndirectFirstInstance;
            this.DepthClamp = depthClamp;
            this.DepthBiasClamp = depthBiasClamp;
            this.FillModeNonSolid = fillModeNonSolid;
            this.DepthBounds = depthBounds;
            this.WideLines = wideLines;
            this.LargePoints = largePoints;
            this.AlphaToOne = alphaToOne;
            this.MultiViewport = multiViewport;
            this.SamplerAnisotropy = samplerAnisotropy;
            this.TextureCompressionETC2 = textureCompressionETC2;
            this.TextureCompressionASTC_LDR = textureCompressionASTC_LDR;
            this.TextureCompressionBC = textureCompressionBC;
            this.OcclusionQueryPrecise = occlusionQueryPrecise;
            this.PipelineStatisticsQuery = pipelineStatisticsQuery;
            this.VertexPipelineStoresAndAtomics = vertexPipelineStoresAndAtomics;
            this.FragmentStoresAndAtomics = fragmentStoresAndAtomics;
            this.ShaderTessellationAndGeometryPointSize = shaderTessellationAndGeometryPointSize;
            this.ShaderImageGatherExtended = shaderImageGatherExtended;
            this.ShaderStorageImageExtendedFormats = shaderStorageImageExtendedFormats;
            this.ShaderStorageImageMultisample = shaderStorageImageMultisample;
            this.ShaderStorageImageReadWithoutFormat = shaderStorageImageReadWithoutFormat;
            this.ShaderStorageImageWriteWithoutFormat = shaderStorageImageWriteWithoutFormat;
            this.ShaderUniformBufferArrayDynamicIndexing = shaderUniformBufferArrayDynamicIndexing;
            this.ShaderSampledImageArrayDynamicIndexing = shaderSampledImageArrayDynamicIndexing;
            this.ShaderStorageBufferArrayDynamicIndexing = shaderStorageBufferArrayDynamicIndexing;
            this.ShaderStorageImageArrayDynamicIndexing = shaderStorageImageArrayDynamicIndexing;
            this.ShaderClipDistance = shaderClipDistance;
            this.ShaderCullDistance = shaderCullDistance;
            this.ShaderFloat64 = shaderFloat64;
            this.ShaderInt64 = shaderInt64;
            this.ShaderInt16 = shaderInt16;
            this.ShaderResourceResidency = shaderResourceResidency;
            this.ShaderResourceMinLod = shaderResourceMinLod;
            this.SparseBinding = sparseBinding;
            this.SparseResidencyBuffer = sparseResidencyBuffer;
            this.SparseResidencyImage2D = sparseResidencyImage2D;
            this.SparseResidencyImage3D = sparseResidencyImage3D;
            this.SparseResidency2Samples = sparseResidency2Samples;
            this.SparseResidency4Samples = sparseResidency4Samples;
            this.SparseResidency8Samples = sparseResidency8Samples;
            this.SparseResidency16Samples = sparseResidency16Samples;
            this.SparseResidencyAliased = sparseResidencyAliased;
            this.VariableMultisampleRate = variableMultisampleRate;
            this.InheritedQueries = inheritedQueries;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 RobustBufferAccess; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 FullDrawIndexUInt32; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ImageCubeArray; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 IndependentBlend; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 GeometryShader; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 TessellationShader; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SampleRateShading; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 DualSourceBlend; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 LogicOp; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 MultiDrawIndirect; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 DrawIndirectFirstInstance; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 DepthClamp; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 DepthBiasClamp; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 FillModeNonSolid; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 DepthBounds; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 WideLines; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 LargePoints; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 AlphaToOne; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 MultiViewport; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SamplerAnisotropy; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 TextureCompressionETC2; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 TextureCompressionASTC_LDR; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 TextureCompressionBC; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 OcclusionQueryPrecise; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 PipelineStatisticsQuery; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 VertexPipelineStoresAndAtomics; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 FragmentStoresAndAtomics; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderTessellationAndGeometryPointSize; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderImageGatherExtended; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderStorageImageExtendedFormats; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderStorageImageMultisample; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderStorageImageReadWithoutFormat; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderStorageImageWriteWithoutFormat; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderUniformBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderSampledImageArrayDynamicIndexing; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderStorageBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderStorageImageArrayDynamicIndexing; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderClipDistance; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderCullDistance; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderFloat64; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderInt64; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderInt16; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderResourceResidency; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 ShaderResourceMinLod; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseBinding; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidencyBuffer; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidencyImage2D; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidencyImage3D; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidency2Samples; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidency4Samples; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidency8Samples; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidency16Samples; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 SparseResidencyAliased; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 VariableMultisampleRate; 
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 InheritedQueries; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("PhysicalDeviceFeatures");
            builder.AppendLine("{");
            builder.AppendLine($"RobustBufferAccess: {this.RobustBufferAccess}");
            builder.AppendLine($"FullDrawIndexUInt32: {this.FullDrawIndexUInt32}");
            builder.AppendLine($"ImageCubeArray: {this.ImageCubeArray}");
            builder.AppendLine($"IndependentBlend: {this.IndependentBlend}");
            builder.AppendLine($"GeometryShader: {this.GeometryShader}");
            builder.AppendLine($"TessellationShader: {this.TessellationShader}");
            builder.AppendLine($"SampleRateShading: {this.SampleRateShading}");
            builder.AppendLine($"DualSourceBlend: {this.DualSourceBlend}");
            builder.AppendLine($"LogicOp: {this.LogicOp}");
            builder.AppendLine($"MultiDrawIndirect: {this.MultiDrawIndirect}");
            builder.AppendLine($"DrawIndirectFirstInstance: {this.DrawIndirectFirstInstance}");
            builder.AppendLine($"DepthClamp: {this.DepthClamp}");
            builder.AppendLine($"DepthBiasClamp: {this.DepthBiasClamp}");
            builder.AppendLine($"FillModeNonSolid: {this.FillModeNonSolid}");
            builder.AppendLine($"DepthBounds: {this.DepthBounds}");
            builder.AppendLine($"WideLines: {this.WideLines}");
            builder.AppendLine($"LargePoints: {this.LargePoints}");
            builder.AppendLine($"AlphaToOne: {this.AlphaToOne}");
            builder.AppendLine($"MultiViewport: {this.MultiViewport}");
            builder.AppendLine($"SamplerAnisotropy: {this.SamplerAnisotropy}");
            builder.AppendLine($"TextureCompressionETC2: {this.TextureCompressionETC2}");
            builder.AppendLine($"TextureCompressionASTC_LDR: {this.TextureCompressionASTC_LDR}");
            builder.AppendLine($"TextureCompressionBC: {this.TextureCompressionBC}");
            builder.AppendLine($"OcclusionQueryPrecise: {this.OcclusionQueryPrecise}");
            builder.AppendLine($"PipelineStatisticsQuery: {this.PipelineStatisticsQuery}");
            builder.AppendLine($"VertexPipelineStoresAndAtomics: {this.VertexPipelineStoresAndAtomics}");
            builder.AppendLine($"FragmentStoresAndAtomics: {this.FragmentStoresAndAtomics}");
            builder.AppendLine($"ShaderTessellationAndGeometryPointSize: {this.ShaderTessellationAndGeometryPointSize}");
            builder.AppendLine($"ShaderImageGatherExtended: {this.ShaderImageGatherExtended}");
            builder.AppendLine($"ShaderStorageImageExtendedFormats: {this.ShaderStorageImageExtendedFormats}");
            builder.AppendLine($"ShaderStorageImageMultisample: {this.ShaderStorageImageMultisample}");
            builder.AppendLine($"ShaderStorageImageReadWithoutFormat: {this.ShaderStorageImageReadWithoutFormat}");
            builder.AppendLine($"ShaderStorageImageWriteWithoutFormat: {this.ShaderStorageImageWriteWithoutFormat}");
            builder.AppendLine($"ShaderUniformBufferArrayDynamicIndexing: {this.ShaderUniformBufferArrayDynamicIndexing}");
            builder.AppendLine($"ShaderSampledImageArrayDynamicIndexing: {this.ShaderSampledImageArrayDynamicIndexing}");
            builder.AppendLine($"ShaderStorageBufferArrayDynamicIndexing: {this.ShaderStorageBufferArrayDynamicIndexing}");
            builder.AppendLine($"ShaderStorageImageArrayDynamicIndexing: {this.ShaderStorageImageArrayDynamicIndexing}");
            builder.AppendLine($"ShaderClipDistance: {this.ShaderClipDistance}");
            builder.AppendLine($"ShaderCullDistance: {this.ShaderCullDistance}");
            builder.AppendLine($"ShaderFloat64: {this.ShaderFloat64}");
            builder.AppendLine($"ShaderInt64: {this.ShaderInt64}");
            builder.AppendLine($"ShaderInt16: {this.ShaderInt16}");
            builder.AppendLine($"ShaderResourceResidency: {this.ShaderResourceResidency}");
            builder.AppendLine($"ShaderResourceMinLod: {this.ShaderResourceMinLod}");
            builder.AppendLine($"SparseBinding: {this.SparseBinding}");
            builder.AppendLine($"SparseResidencyBuffer: {this.SparseResidencyBuffer}");
            builder.AppendLine($"SparseResidencyImage2D: {this.SparseResidencyImage2D}");
            builder.AppendLine($"SparseResidencyImage3D: {this.SparseResidencyImage3D}");
            builder.AppendLine($"SparseResidency2Samples: {this.SparseResidency2Samples}");
            builder.AppendLine($"SparseResidency4Samples: {this.SparseResidency4Samples}");
            builder.AppendLine($"SparseResidency8Samples: {this.SparseResidency8Samples}");
            builder.AppendLine($"SparseResidency16Samples: {this.SparseResidency16Samples}");
            builder.AppendLine($"SparseResidencyAliased: {this.SparseResidencyAliased}");
            builder.AppendLine($"VariableMultisampleRate: {this.VariableMultisampleRate}");
            builder.AppendLine($"InheritedQueries: {this.InheritedQueries}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
