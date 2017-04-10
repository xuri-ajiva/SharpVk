using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplayPresentInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayPresentInfo(StructureType sType, void* next, Rect2D sourceRect, Rect2D destinationRect, Bool32 persistent)
        {
            this.SType = sType;
            this.Next = next;
            this.SourceRect = sourceRect;
            this.DestinationRect = destinationRect;
            this.Persistent = persistent;
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
        public Rect2D SourceRect; 
        
        /// <summary>
        /// 
        /// </summary>
        public Rect2D DestinationRect; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 Persistent; 
    }
}
