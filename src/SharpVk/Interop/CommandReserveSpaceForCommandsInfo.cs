using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct CommandReserveSpaceForCommandsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public CommandReserveSpaceForCommandsInfo(StructureType sType, void* next, ObjectTable objectTable, IndirectCommandsLayout indirectCommandsLayout, uint maxSequencesCount)
        {
            this.SType = sType;
            this.Next = next;
            this.ObjectTable = objectTable;
            this.IndirectCommandsLayout = indirectCommandsLayout;
            this.MaxSequencesCount = maxSequencesCount;
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
        public uint MaxSequencesCount; 
    }
}
