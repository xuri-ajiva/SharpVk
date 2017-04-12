using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct RenderPassMultiviewCreateInfo
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
        public uint SubpassCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* ViewMasks; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DependencyCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public int* ViewOffsets; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CorrelationMaskCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* CorrelationMasks; 
    }
}
