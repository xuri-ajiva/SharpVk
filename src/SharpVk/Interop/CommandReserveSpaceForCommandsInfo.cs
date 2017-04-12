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
