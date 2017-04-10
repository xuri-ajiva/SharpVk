using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct IndirectCommandsLayoutCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsLayoutCreateInfo(StructureType sType, void* next, PipelineBindPoint pipelineBindPoint, IndirectCommandsLayoutUsageFlags flags, uint tokenCount, IndirectCommandsLayoutToken* tokens)
        {
            this.SType = sType;
            this.Next = next;
            this.PipelineBindPoint = pipelineBindPoint;
            this.Flags = flags;
            this.TokenCount = tokenCount;
            this.Tokens = tokens;
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
        public PipelineBindPoint PipelineBindPoint; 
        
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsLayoutUsageFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint TokenCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsLayoutToken* Tokens; 
    }
}
