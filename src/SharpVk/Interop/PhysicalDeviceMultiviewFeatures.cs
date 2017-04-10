using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceMultiviewFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceMultiviewFeatures(StructureType sType, void* next, Bool32 multiview, Bool32 multiviewGeometryShader, Bool32 multiviewTessellationShader)
        {
            this.SType = sType;
            this.Next = next;
            this.Multiview = multiview;
            this.MultiviewGeometryShader = multiviewGeometryShader;
            this.MultiviewTessellationShader = multiviewTessellationShader;
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
        public Bool32 Multiview; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 MultiviewGeometryShader; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 MultiviewTessellationShader; 
    }
}
