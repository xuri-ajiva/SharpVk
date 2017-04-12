using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineInputAssemblyStateCreateInfo
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
        public PipelineInputAssemblyStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public PrimitiveTopology Topology; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 PrimitiveRestartEnable; 
    }
}
