using SharpVk.Generator.Collation;

namespace SharpVk.Generator.Generation
{
    public class TypeNameMapping
    {
        public string VkName;
        public string OutputName;

        public static TypeNameMapping FromTypeDeclaration(TypeDeclaration type)
        {
            return new TypeNameMapping
            {
                VkName = type.VkName,
                OutputName = type.Name
            };
        }

        public static TypeNameMapping FromEnumDeclaration(EnumDeclaration enumeration)
        {
            return new TypeNameMapping
            {
                VkName = enumeration.VkName,
                OutputName = enumeration.Name
            };
        }
    }
}
