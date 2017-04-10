using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineRasterizationStateRasterizationOrder
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineRasterizationStateRasterizationOrder(StructureType sType, void* next, RasterizationOrder rasterizationOrder)
        {
            this.SType = sType;
            this.Next = next;
            this.RasterizationOrder = rasterizationOrder;
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
        public RasterizationOrder RasterizationOrder; 
    }
}
