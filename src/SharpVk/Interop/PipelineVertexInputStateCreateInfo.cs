using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineVertexInputStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineVertexInputStateCreateInfo(StructureType sType, void* next, PipelineVertexInputStateCreateFlags flags, uint vertexBindingDescriptionCount, VertexInputBindingDescription* vertexBindingDescriptions, uint vertexAttributeDescriptionCount, VertexInputAttributeDescription* vertexAttributeDescriptions)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.VertexBindingDescriptionCount = vertexBindingDescriptionCount;
            this.VertexBindingDescriptions = vertexBindingDescriptions;
            this.VertexAttributeDescriptionCount = vertexAttributeDescriptionCount;
            this.VertexAttributeDescriptions = vertexAttributeDescriptions;
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
        public PipelineVertexInputStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint VertexBindingDescriptionCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public VertexInputBindingDescription* VertexBindingDescriptions; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint VertexAttributeDescriptionCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public VertexInputAttributeDescription* VertexAttributeDescriptions; 
    }
}
