using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Generator.Collation
{
    public class NameFormatter
    {
        private static readonly Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"void", "void"},
            {"char", "char"},
            {"float", "float"},
            {"uint8_t", "byte"},
            {"uint32_t", "uint"},
            {"int", "int"},
            {"DWORD", "uint"},
            {"uint64_t", "ulong"},
            {"int32_t", "int"},
            {"size_t", "HostSize"},
            {"HINSTANCE", "IntPtr" },
            {"HWND", "IntPtr" },
            {"HANDLE", "IntPtr" },
            {"SECURITY_ATTRIBUTES", "SECURITY_ATTRIBUTES" },
            {"ANativeWindow", "IntPtr" },
            {"Display", "IntPtr" },
            {"VisualID", "IntPtr" },
            {"Window", "IntPtr" },
            {"MirConnection", "IntPtr" },
            {"MirSurface", "IntPtr" },
            {"wl_display", "IntPtr" },
            {"wl_surface", "IntPtr" },
            {"xcb_connection_t", "IntPtr" },
            {"xcb_visualid_t", "IntPtr" },
            {"xcb_window_t", "IntPtr" },
            {"RROutput", "IntPtr" },
            {"LPCWSTR", "IntPtr" }
        };

        public string FormatName(EnumElement enumeration)
        {
            return JoinNameParts(enumeration.NameParts);
        }

        public string FormatName(TypeElement type)
        {
            if (type.Category == TypeCategory.None
                && primitiveTypes.ContainsKey(type.VkName))
            {
                return primitiveTypes[type.VkName];
            }

            string result = JoinNameParts(type.NameParts);

            if (type.Category == TypeCategory.funcpointer)
            {
                result += "Delegate";
            }

            return result;
        }

        public string FormatName(MemberElement member)
        {
            return JoinNameParts(member.NameParts);
        }

        public string FormatName(CommandElement command, TypeElement handleType)
        {
            var methodNameParts = command.NameParts;

            int verbPrefixLength = 1;

            if (methodNameParts.First() != command.Verb)
            {
                verbPrefixLength = 0;
            }

            if (handleType.NameParts
                        .Zip(methodNameParts.Skip(verbPrefixLength), (x, y) => x == y)
                        .All(x => x))
            {
                methodNameParts = methodNameParts.Take(verbPrefixLength).Concat(methodNameParts.Skip(handleType.NameParts.Count() + verbPrefixLength)).ToArray();
            }
            else if (handleType.VkName == "VkDeviceMemory" && methodNameParts.Skip(verbPrefixLength).First() == "memory")
            {
                methodNameParts = methodNameParts.Take(verbPrefixLength).Concat(methodNameParts.Skip(verbPrefixLength + 1)).ToArray();
            }
            else if (handleType.VkName == "VkCommandBuffer" && methodNameParts.First() == "cmd")
            {
                methodNameParts = methodNameParts.Skip(1).ToArray();
            }

            return JoinNameParts(methodNameParts);
        }

        private static string JoinNameParts(string[] nameParts)
        {
            return nameParts
                        .Select(ExpandAbbreviations)
                        .Select(x => x.FirstToUpper())
                        .Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                        .ToString();
        }

        private static string ExpandAbbreviations(string value)
        {
            switch (value)
            {
                case "src":
                    return "source";
                case "dst":
                    return "destination";
                case "cmd":
                    return "command";
                case "proc":
                    return "procedure";
                case "addr":
                    return "address";
                case "fd":
                    return "fileDescriptor";
                default:
                    return value;
            }
        }
    }
}
