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
