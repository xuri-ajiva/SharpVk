using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ComponentMapping
    {
        /// <summary>
        /// 
        /// </summary>
        public ComponentMapping(ComponentSwizzle r, ComponentSwizzle g, ComponentSwizzle b, ComponentSwizzle a)
        {
            this.R = r;
            this.G = g;
            this.B = b;
            this.A = a;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ComponentSwizzle R; 
        
        /// <summary>
        /// 
        /// </summary>
        public ComponentSwizzle G; 
        
        /// <summary>
        /// 
        /// </summary>
        public ComponentSwizzle B; 
        
        /// <summary>
        /// 
        /// </summary>
        public ComponentSwizzle A; 
    }
}
