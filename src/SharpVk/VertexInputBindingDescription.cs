using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct VertexInputBindingDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public VertexInputBindingDescription(uint binding, uint stride, VertexInputRate inputRate)
        {
            this.Binding = binding;
            this.Stride = stride;
            this.InputRate = inputRate;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Binding; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Stride; 
        
        /// <summary>
        /// 
        /// </summary>
        public VertexInputRate InputRate; 
    }
}
