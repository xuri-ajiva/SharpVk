using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct RenderPassCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public RenderPassCreateInfo(StructureType sType, void* next, RenderPassCreateFlags flags, uint attachmentCount, AttachmentDescription* attachments, uint subpassCount, SubpassDescription* subpasses, uint dependencyCount, SubpassDependency* dependencies)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.AttachmentCount = attachmentCount;
            this.Attachments = attachments;
            this.SubpassCount = subpassCount;
            this.Subpasses = subpasses;
            this.DependencyCount = dependencyCount;
            this.Dependencies = dependencies;
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
        public RenderPassCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint AttachmentCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentDescription* Attachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubpassCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SubpassDescription* Subpasses; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DependencyCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SubpassDependency* Dependencies; 
    }
}
