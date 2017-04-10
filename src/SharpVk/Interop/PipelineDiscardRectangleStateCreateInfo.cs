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
        public PipelineDiscardRectangleStateCreateInfo(StructureType sType, void* next, PipelineDiscardRectangleStateCreateFlags flags, DiscardRectangleMode discardRectangleMode, uint discardRectangleCount, Rect2D* discardRectangles)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.DiscardRectangleMode = discardRectangleMode;
            this.DiscardRectangleCount = discardRectangleCount;
            this.DiscardRectangles = discardRectangles;
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
