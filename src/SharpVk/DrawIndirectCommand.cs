using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct DrawIndirectCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public DrawIndirectCommand(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            this.VertexCount = vertexCount;
            this.InstanceCount = instanceCount;
            this.FirstVertex = firstVertex;
            this.FirstInstance = firstInstance;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VertexCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint InstanceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FirstVertex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FirstInstance; 
    }
}
