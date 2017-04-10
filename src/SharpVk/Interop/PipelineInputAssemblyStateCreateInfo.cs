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
        public PipelineInputAssemblyStateCreateInfo(StructureType sType, void* next, PipelineInputAssemblyStateCreateFlags flags, PrimitiveTopology topology, Bool32 primitiveRestartEnable)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Topology = topology;
            this.PrimitiveRestartEnable = primitiveRestartEnable;
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
