using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineMultisampleStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineMultisampleStateCreateInfo(StructureType sType, void* next, PipelineMultisampleStateCreateFlags flags, SampleCountFlags rasterizationSamples, Bool32 sampleShadingEnable, float minSampleShading, SampleMask* sampleMask, Bool32 alphaToCoverageEnable, Bool32 alphaToOneEnable)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.RasterizationSamples = rasterizationSamples;
            this.SampleShadingEnable = sampleShadingEnable;
            this.MinSampleShading = minSampleShading;
            this.SampleMask = sampleMask;
            this.AlphaToCoverageEnable = alphaToCoverageEnable;
            this.AlphaToOneEnable = alphaToOneEnable;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineMultisampleStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags RasterizationSamples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SampleShadingEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinSampleShading; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleMask* SampleMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 AlphaToCoverageEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 AlphaToOneEnable; 
    }
}
