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
        public CommandProcessCommandsInfo(StructureType sType, void* next, ObjectTable objectTable, IndirectCommandsLayout indirectCommandsLayout, uint indirectCommandsTokenCount, IndirectCommandsToken* indirectCommandsTokens, uint maxSequencesCount, CommandBuffer targetCommandBuffer, Buffer sequencesCountBuffer, DeviceSize sequencesCountOffset, Buffer sequencesIndexBuffer, DeviceSize sequencesIndexOffset)
        {
            this.SType = sType;
            this.Next = next;
            this.ObjectTable = objectTable;
            this.IndirectCommandsLayout = indirectCommandsLayout;
            this.IndirectCommandsTokenCount = indirectCommandsTokenCount;
            this.IndirectCommandsTokens = indirectCommandsTokens;
            this.MaxSequencesCount = maxSequencesCount;
            this.TargetCommandBuffer = targetCommandBuffer;
            this.SequencesCountBuffer = sequencesCountBuffer;
            this.SequencesCountOffset = sequencesCountOffset;
            this.SequencesIndexBuffer = sequencesIndexBuffer;
            this.SequencesIndexOffset = sequencesIndexOffset;
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
