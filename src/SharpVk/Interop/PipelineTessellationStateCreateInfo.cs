using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineTessellationStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineTessellationStateCreateInfo(StructureType sType, void* next, PipelineTessellationStateCreateFlags flags, uint patchControlPoints)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.PatchControlPoints = patchControlPoints;
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
        public PipelineTessellationStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PatchControlPoints; 
    }
}
