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
