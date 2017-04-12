using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineColorBlendStateCreateInfo
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
        public PipelineColorBlendStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 LogicOpEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public LogicOp LogicOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint AttachmentCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineColorBlendAttachmentState* Attachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public float BlendConstants; 
    }
}
