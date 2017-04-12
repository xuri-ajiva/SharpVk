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
