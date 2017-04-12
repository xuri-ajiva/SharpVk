using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineDynamicStateCreateInfo
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
        public PipelineDynamicStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DynamicStateCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DynamicState* DynamicStates; 
    }
}
