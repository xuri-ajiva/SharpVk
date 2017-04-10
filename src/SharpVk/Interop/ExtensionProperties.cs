using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ExtensionProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ExtensionProperties(char extensionName, uint specVersion)
        {
            this.ExtensionName = extensionName;
            this.SpecVersion = specVersion;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public char ExtensionName; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SpecVersion; 
    }
}
