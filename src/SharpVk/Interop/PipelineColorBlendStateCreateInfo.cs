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
        public PipelineColorBlendStateCreateInfo(StructureType sType, void* next, PipelineColorBlendStateCreateFlags flags, Bool32 logicOpEnable, LogicOp logicOp, uint attachmentCount, PipelineColorBlendAttachmentState* attachments, float blendConstants)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.LogicOpEnable = logicOpEnable;
            this.LogicOp = logicOp;
            this.AttachmentCount = attachmentCount;
            this.Attachments = attachments;
            this.BlendConstants = blendConstants;
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
