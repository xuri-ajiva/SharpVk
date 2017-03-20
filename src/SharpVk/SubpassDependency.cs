using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct SubpassDependency
    {
        /// <summary>
        /// 
        /// </summary>
        public SubpassDependency(uint sourceSubpass, uint destinationSubpass, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, AccessFlags sourceAccessMask, AccessFlags destinationAccessMask, DependencyFlags dependencyFlags)
        {
            this.SourceSubpass = sourceSubpass;
            this.DestinationSubpass = destinationSubpass;
            this.SourceStageMask = sourceStageMask;
            this.DestinationStageMask = destinationStageMask;
            this.SourceAccessMask = sourceAccessMask;
            this.DestinationAccessMask = destinationAccessMask;
            this.DependencyFlags = dependencyFlags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceSubpass; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationSubpass; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineStageFlags SourceStageMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineStageFlags DestinationStageMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags DestinationAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public DependencyFlags DependencyFlags; 
    }
}
