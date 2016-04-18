using System;
using System.Collections.Generic;

namespace SharpVk.VkXml
{
    public class TypeSet
    {
        public List<VkConstant> Constants
        {
            get;
            private set;
        } = new List<VkConstant>();

        public class VkConstant
        {
            public string Name
            {
                get;
                set;
            }

            public Type Type
            {
                get;
                set;
            }

            public string Value
            {
                get;
                set;
            }
        }
    }
}