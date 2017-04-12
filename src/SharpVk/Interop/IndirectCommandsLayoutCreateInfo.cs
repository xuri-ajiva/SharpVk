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
