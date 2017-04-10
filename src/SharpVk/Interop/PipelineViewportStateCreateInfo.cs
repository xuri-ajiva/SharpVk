using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineViewportStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineViewportStateCreateInfo(StructureType sType, void* next, PipelineViewportStateCreateFlags flags, uint viewportCount, Viewport* viewports, uint scissorCount, Rect2D* scissors)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.ViewportCount = viewportCount;
            this.Viewports = viewports;
            this.ScissorCount = scissorCount;
            this.Scissors = scissors;
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
        public PipelineViewportStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ViewportCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Viewport* Viewports; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ScissorCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Rect2D* Scissors; 
    }
}
