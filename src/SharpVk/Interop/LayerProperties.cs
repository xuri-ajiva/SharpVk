using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct LayerProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public LayerProperties(char layerName, uint specVersion, uint implementationVersion, char description)
        {
            this.LayerName = layerName;
            this.SpecVersion = specVersion;
            this.ImplementationVersion = implementationVersion;
            this.Description = description;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public char LayerName; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SpecVersion; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImplementationVersion; 
        
        /// <summary>
        /// 
        /// </summary>
        public char Description; 
    }
}
