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
