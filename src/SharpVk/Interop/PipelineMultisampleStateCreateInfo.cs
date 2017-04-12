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
