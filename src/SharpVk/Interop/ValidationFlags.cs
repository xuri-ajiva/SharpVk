using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ValidationFlags
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
        public uint DisabledValidationCheckCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ValidationCheck* DisabledValidationChecks; 
    }
}
