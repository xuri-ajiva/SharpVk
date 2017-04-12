using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineDiscardRectangleStateCreateInfo
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
        public PipelineDiscardRectangleStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public DiscardRectangleMode DiscardRectangleMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DiscardRectangleCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Rect2D* DiscardRectangles; 
    }
}
