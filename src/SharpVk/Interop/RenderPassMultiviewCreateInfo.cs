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
        public RenderPassMultiviewCreateInfo(StructureType sType, void* next, uint subpassCount, uint* viewMasks, uint dependencyCount, int* viewOffsets, uint correlationMaskCount, uint* correlationMasks)
        {
            this.SType = sType;
            this.Next = next;
            this.SubpassCount = subpassCount;
            this.ViewMasks = viewMasks;
            this.DependencyCount = dependencyCount;
            this.ViewOffsets = viewOffsets;
            this.CorrelationMaskCount = correlationMaskCount;
            this.CorrelationMasks = correlationMasks;
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
