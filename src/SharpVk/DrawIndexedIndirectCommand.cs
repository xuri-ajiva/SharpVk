using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct DrawIndexedIndirectCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public DrawIndexedIndirectCommand(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            this.IndexCount = indexCount;
            this.InstanceCount = instanceCount;
            this.FirstIndex = firstIndex;
            this.VertexOffset = vertexOffset;
            this.FirstInstance = firstInstance;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint IndexCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint InstanceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FirstIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public int VertexOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FirstInstance; 
    }
}
