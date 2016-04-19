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

        public List<VkEnumeration> Enumerations
        {
            get;
            private set;
        } = new List<VkEnumeration>();

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

        public class VkEnumeration
        {
            public string Name
            {
                get;
                set;
            }

            public bool IsFlags
            {
                get;
                set;
            }

            public List<VkEnumerationField> Fields
            {
                get;
                private set;
            } = new List<VkEnumerationField>();
        }

        public class VkEnumerationField
        {
            public string Name
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