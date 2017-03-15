using SharpVk.Generator.Specification.Elements;
using System;
using System.Linq;
using System.Text;

namespace SharpVk.Generator.Collation
{
    public class NameFormatter
    {
        public string FormatName(TypeElement type)
        {
            return JoinNameParts(type.NameParts);
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
