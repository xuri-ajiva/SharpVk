using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct CommandProcessCommandsInfo
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
        public ObjectTable ObjectTable; 
        
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsLayout IndirectCommandsLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint IndirectCommandsTokenCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsToken* IndirectCommandsTokens; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSequencesCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public CommandBuffer TargetCommandBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer SequencesCountBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize SequencesCountOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer SequencesIndexBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize SequencesIndexOffset; 
    }
}
