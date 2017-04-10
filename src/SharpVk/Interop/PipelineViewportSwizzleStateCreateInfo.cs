using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineViewportSwizzleStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineViewportSwizzleStateCreateInfo(StructureType sType, void* next, PipelineViewportSwizzleStateCreateFlags flags, uint viewportCount, ViewportSwizzle* viewportSwizzles)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.ViewportCount = viewportCount;
            this.ViewportSwizzles = viewportSwizzles;
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
        public PipelineViewportSwizzleStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ViewportCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ViewportSwizzle* ViewportSwizzles; 
    }
}
