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
