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
        public PipelineDynamicStateCreateInfo(StructureType sType, void* next, PipelineDynamicStateCreateFlags flags, uint dynamicStateCount, DynamicState* dynamicStates)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.DynamicStateCount = dynamicStateCount;
            this.DynamicStates = dynamicStates;
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
