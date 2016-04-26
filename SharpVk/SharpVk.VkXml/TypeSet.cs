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

        public List<VkStruct> Structs
        {
            get;
            private set;
        } = new List<VkStruct>();

        public List<VkStruct> InteropStructs
        {
            get;
            private set;
        } = new List<VkStruct>();

        public List<VkStruct> Unions
        {
            get;
            private set;
        } = new List<VkStruct>();

        public List<VkHandle> Handles
        {
            get;
            private set;
        } = new List<VkHandle>();

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

        public class VkStruct
        {
            public string Name
            {
                get;
                set;
            }

            public List<VkStructMember> Members
            {
                get;
                private set;
            } = new List<VkStructMember>();
        }

        public class VkStructMember
        {
            public string Name
            {
                get;
                set;
            }

            public string TypeName
            {
                get;
                set;
            }

            public string FieldOffset
            {
                get;
                set;
            }
        }

        public class VkHandle
        {
            public string Name
            {
                get;
                set;
            }

            public string ParentHandle
            {
                get;
                set;
            }
        }
    }
}