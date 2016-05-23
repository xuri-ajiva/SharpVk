using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace SharpVk.VkXml
{
    public class SpecParser
    {
        private static readonly Parser<string> firstPart = from head in Parse.Letter
                                                           from tail in Parse.Lower.Many()
                                                           select new string(new[] { head }.Concat(tail).ToArray()).ToLower();

        private static readonly Parser<string> namePart = from head in Parse.Upper
                                                          from tail in Parse.Lower.AtLeastOnce()
                                                          select new string(new[] { head }.Concat(tail).ToArray()).ToLower();

        private static readonly Parser<string> numberPart = Parse.Digit
                                                        .AtLeastOnce()
                                                        .Text();

        private static readonly Parser<string> keywordPart = Parse.String("2D")
                                                        .Or(Parse.String("3D"))
                                                        .Or(Parse.String("ETC2"))
                                                        .Or(Parse.String("ASTC_LDR"))
                                                        .Or(Parse.String("BC"))
                                                        .Or(Parse.String("ID"))
                                                        .Or(Parse.String("UUID"))
                                                        .Text();

        private static readonly Parser<NameParts> namePartsParser = from first in firstPart
                                                                    from parts in keywordPart
                                                                                    .Or(numberPart)
                                                                                    .Or(namePart)
                                                                                    .Many()
                                                                    from extension in Parse.Upper.Many().Text().End()
                                                                    select new NameParts
                                                                    {
                                                                        Parts = new[] { first }.Concat(parts).ToArray(),
                                                                        Extension = string.IsNullOrEmpty(extension)
                                                                                     ? null
                                                                                     : extension.ToLower()
                                                                    };

        private static readonly Parser<string> fixedLengthParser = from open in Parse.Char('[')
                                                                   from digits in Parse.Digit.AtLeastOnce().Text()
                                                                   from close in Parse.Char(']')
                                                                   select digits;

        private static readonly Parser<ParsedLen> lenPartParser = Parse.String("null-terminated").Select(x => new ParsedLen { Type = LenType.NullTerminated })
                                                                        .Or(Parse.Letter.AtLeastOnce().Text().Select(x => new ParsedLen { Value = x, Type = LenType.Expression }));

        private static readonly Parser<IEnumerable<ParsedLen>> lenParser = lenPartParser.DelimitedBy(Parse.Char(',').Token()).End();

        private readonly IVkXmlCache xmlCache;

        public SpecParser(IVkXmlCache xmlCache)
        {
            this.xmlCache = xmlCache;
        }

        private string GetTextValue(XNode node)
        {
            var nodeAsText = node as XText;

            if (nodeAsText != null)
            {
                return nodeAsText.Value;
            }
            else
            {
                var nodeAsElement = node as XElement;

                if (nodeAsElement != null)
                {
                    return nodeAsElement.Value;
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
        }

        public ParsedSpec Run()
        {
            var vkXml = this.xmlCache.GetVkXml();

            var typeXml = new Dictionary<string, ParsedType>();

            foreach (var vkType in vkXml.Element("registry").Element("types").Elements("type"))
            {
                string name = vkType.Attribute("name")?.Value ?? vkType.Element("name").Value;
                var categoryAttribute = vkType.Attribute("category");
                TypeCategory category = categoryAttribute == null
                                                            ? TypeCategory.None
                                                            : (TypeCategory)Enum.Parse(typeof(TypeCategory), categoryAttribute.Value);
                string requires = vkType.Attribute("requires")?.Value;
                string parent = vkType.Attribute("parent")?.Value;
                string returnedOnly = vkType.Attribute("returnedonly")?.Value;
                bool isReturnedOnly = returnedOnly != null
                                        ? bool.Parse(returnedOnly)
                                        : false;

                string extension;

                string[] nameParts = GetNameParts(name, out extension);

                var newType = new ParsedType
                {
                    VkName = name,
                    Category = category,
                    Requires = requires,
                    Parent = parent,
                    IsReturnedOnly = isReturnedOnly,
                    NameParts = nameParts,
                    Extension = extension
                };

                foreach (var vkMember in vkType.Elements("member"))
                {
                    var nameElement = vkMember.Element("name");
                    string memberName = nameElement.Value;
                    string memberType = vkMember.Element("type").Value;
                    string optional = vkMember.Element("optional")?.Value;
                    bool isOptional = optional != null
                                        ? bool.Parse(optional)
                                        : false;
                    ParsedFixedLength fixedLength = new ParsedFixedLength();

                    var typeNodes = nameElement.NodesBeforeSelf();
                    PointerType pointerType = GetPointerType(typeNodes);

                    if (nameElement.NodesAfterSelf().Any())
                    {
                        string enumName = vkMember.Element("enum")?.Value;

                        if (enumName != null)
                        {
                            fixedLength.Value = enumName;
                            fixedLength.Type = FixedLengthType.EnumReference;
                        }
                        else
                        {
                            fixedLength.Value = fixedLengthParser.Parse(nameElement.NextNode.ToString());
                            fixedLength.Type = FixedLengthType.IntegerLiteral;
                        }
                    }
                    else
                    {
                        int fixedLengthIndex = memberName.IndexOf('[');

                        if (fixedLengthIndex >= 0)
                        {
                            string fixedLengthString = memberName.Substring(fixedLengthIndex);
                            memberName = memberName.Substring(0, fixedLengthIndex);

                            fixedLength.Value = fixedLengthParser.Parse(fixedLengthString);
                            fixedLength.Type = FixedLengthType.IntegerLiteral;
                        }
                    }

                    // Capture member name without array suffix
                    string vkName = memberName;

                    int pointerCount = pointerType.GetPointerCount();

                    while (pointerCount > 0 && memberName.StartsWith("p"))
                    {
                        memberName = memberName.Substring(1);

                        pointerCount--;
                    }

                    ParsedLen[] dimensions = GetDimensions(name, vkMember, memberName);

                    string memberExtension;

                    string[] memberNameParts = GetNameParts(memberName, out memberExtension, false);

                    newType.Members.Add(new ParsedMember
                    {
                        VkName = vkName,
                        Type = memberType,
                        IsOptional = isOptional,
                        FixedLength = fixedLength,
                        PointerType = pointerType,
                        NameParts = memberNameParts,
                        Extension = extension,
                        Dimensions = dimensions
                    });
                }

                typeXml.Add(name, newType);
            }

            var enumXml = new Dictionary<string, ParsedEnum>();

            foreach (var vkEnum in vkXml.Element("registry").Elements("enums"))
            {
                string name = vkEnum.Attribute("name").Value;
                string type = vkEnum.Attribute("type")?.Value;

                string extension;

                string[] nameParts = GetNameParts(name, out extension);

                var newEnum = new ParsedEnum
                {
                    VkName = name,
                    Type = type,
                    NameParts = nameParts,
                    Extension = extension
                };

                foreach (var vkField in vkEnum.Elements("enum"))
                {
                    string fieldName = vkField.Attribute("name").Value;
                    bool isBitmask = true;
                    string value = vkField.Attribute("bitpos")?.Value;

                    if (value == null)
                    {
                        isBitmask = false;
                        value = vkField.Attribute("value").Value;

                        // Special case for mapping C "unsigned long long"
                        // (64-bit unsigned integer) to C# UInt64
                        if (value == "(~0ULL)")
                        {
                            value = "(~0UL)";
                        }

                        value = value.Trim('(', ')');
                    }

                    var fieldNameParts = fieldName.Split('_')
                                                    .Select(x => x.ToLower())
                                                    .ToArray()
                                                    .AsEnumerable();

                    if (fieldNameParts.First() == "vk")
                    {
                        fieldNameParts = fieldNameParts.Skip(1);
                    }

                    int prefixSkipCount = 0;

                    while (nameParts != null
                        && prefixSkipCount < nameParts.Length
                        && nameParts[prefixSkipCount] == fieldNameParts.ElementAt(prefixSkipCount))
                    {
                        prefixSkipCount++;
                    }

                    fieldNameParts = fieldNameParts.Skip(prefixSkipCount);

                    newEnum.Fields.Add(fieldName, new ParsedEnumField
                    {
                        VkName = fieldName,
                        NameParts = fieldNameParts.ToArray(),
                        IsBitmask = isBitmask,
                        Value = value
                    });
                }

                enumXml.Add(name, newEnum);
            }

            var commandXml = new Dictionary<string, ParsedCommand>();

            foreach (var vkCommand in vkXml.Element("registry").Element("commands").Elements("command"))
            {
                string name = vkCommand.Element("proto").Element("name").Value;
                string type = vkCommand.Element("proto").Element("type").Value;

                string extension;

                string[] nameParts = GetNameParts(name, out extension);

                string[] verbExceptions = new[] { "cmd", "queue", "device" };

                string verb = verbExceptions.Contains(nameParts[0]) ? nameParts[1] : nameParts[0];

                var newCommand = new ParsedCommand
                {
                    VkName = name,
                    Type = type,
                    NameParts = nameParts,
                    Extension = extension,
                    Verb = verb
                };

                commandXml.Add(name, newCommand);

                foreach (var vkParam in vkCommand.Elements("param"))
                {
                    var nameElement = vkParam.Element("name");

                    string paramName = nameElement.Value;
                    string paramType = vkParam.Element("type").Value;
                    string optional = vkParam.Element("optional")?.Value;
                    bool isOptional = optional != null
                                        ? bool.Parse(optional)
                                        : false;

                    var typeNodes = nameElement.NodesBeforeSelf();
                    PointerType pointerType = GetPointerType(typeNodes);

                    ParsedLen[] dimensions = GetDimensions(name, vkParam, paramName);

                    string paramExtension;

                    string[] paramNameParts = GetNameParts(paramName, out paramExtension, false);

                    newCommand.Params.Add(new ParsedParam
                    {
                        VkName = paramName,
                        Type = paramType,
                        PointerType = pointerType,
                        NameParts = paramNameParts,
                        Extension = paramExtension,
                        IsOptional = isOptional,
                        Dimensions = dimensions
                    });
                }
            }

            var vkFeature = vkXml.Element("registry").Elements("feature").Single(x => x.Attribute("api").Value == "vulkan");

            return FilterRequiredElement(typeXml, enumXml, commandXml, vkFeature);
        }

        private static ParsedLen[] GetDimensions(string name, XElement vkMember, string memberName)
        {
            ParsedLen[] dimensions = null;

            if (vkMember.Attribute("len") != null)
            {
                var lenResult = lenParser.TryParse(vkMember.Attribute("len").Value);

                if (lenResult.WasSuccessful)
                {
                    dimensions = lenResult.Value.ToArray();
                }
                else
                {
                    dimensions = new[] { new ParsedLen { Type = LenType.Expression } };
                    //HACK Placeholder warning till I get round to
                    //parsing LaTeX Maths statements
                    Console.WriteLine("Could not parse len {0} for {2}.{1}", vkMember.Attribute("len").Value, memberName, name);
                }
            }

            return dimensions;
        }

        private static ParsedSpec FilterRequiredElement(Dictionary<string, ParsedType> typeXml, Dictionary<string, ParsedEnum> enumXml, Dictionary<string, ParsedCommand> commandXml, XElement vkFeature)
        {
            var requiredTypes = new List<string>();
            var requiredCommand = new List<string>();
            var requiredConstant = new List<string>();

            var constants = enumXml["API Constants"];

            foreach (var requirement in vkFeature.Elements("require").SelectMany(x => x.Elements()))
            {
                switch (requirement.Name.LocalName)
                {
                    case "command":
                        requiredCommand.Add(requirement.Attribute("name").Value);
                        break;
                    case "enum":
                        requiredConstant.Add(requirement.Attribute("name").Value);
                        break;
                    case "type":
                        requiredTypes.Add(requirement.Attribute("name").Value);
                        break;
                    default:
                        throw new Exception("Unexpected requirement type: " + requirement.Name.LocalName);
                }
            }

            var result = new ParsedSpec();

            //HACK Artificially limit the set of required commands to simplify
            // the API while working on marshalling and the public handles
            foreach (var commandName in requiredCommand.Distinct().Take(54))
            {
                var command = commandXml[commandName];

                result.Commands.Add(commandName, command);

                requiredTypes.Add(command.Type);

                foreach (var param in command.Params)
                {
                    requiredTypes.Add(param.Type);
                }
            }

            requiredTypes = requiredTypes.Distinct().ToList();

            var newTypes = requiredTypes.ToList();

            while (newTypes.Any())
            {
                var typesToCheck = newTypes.ToArray();

                newTypes.Clear();

                foreach (var typeName in typesToCheck)
                {
                    var type = typeXml[typeName];

                    if (type.Requires != null && !requiredTypes.Contains(type.Requires) && !newTypes.Contains(type.Requires))
                    {
                        newTypes.Add(type.Requires);
                    }

                    if (type.Parent != null && !requiredTypes.Contains(type.Parent) && !newTypes.Contains(type.Parent))
                    {
                        newTypes.Add(type.Parent);
                    }

                    foreach (var member in type.Members)
                    {
                        if (!requiredTypes.Contains(member.Type) && !newTypes.Contains(member.Type))
                        {
                            newTypes.Add(member.Type);
                        }
                    }
                }

                requiredTypes.AddRange(newTypes);
            }

            foreach (var typeName in requiredTypes.Distinct().OrderBy(x => x))
            {
                var type = typeXml[typeName];

                result.Types.Add(typeName, type);

                foreach (var member in type.Members)
                {
                    if (member.FixedLength.Type == FixedLengthType.EnumReference
                            && constants.Fields.ContainsKey(member.FixedLength.Value)
                            && !requiredConstant.Contains(member.FixedLength.Value))
                    {
                        requiredConstant.Add(member.FixedLength.Value);
                    }
                }
            }

            foreach (var type in result.Types.Values)
            {
                if (type.Category == TypeCategory.@enum)
                {
                    result.Enumerations.Add(type.VkName, enumXml[type.VkName]);
                }
            }

            foreach (var constant in requiredConstant)
            {
                result.Constants[constant] = constants.Fields[constant];
            }

            return result;
        }

        private static PointerType GetPointerType(IEnumerable<XNode> typeNodes)
        {
            string typeString = typeNodes.Select(x =>
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    var element = (XElement)x;

                    if (element.Name == "type")
                    {
                        return "@";
                    }
                    else
                    {
                        return ((XElement)x).Value;
                    }
                }
                else
                {
                    return x.ToString();
                }
            }).Aggregate((y, z) => y + z).Trim();

            switch (typeString)
            {
                case "@":
                    return PointerType.Value;
                case "const @":
                    return PointerType.ConstValue;
                case "@*":
                case "struct @*":
                    // struct {type}* is a syntactic quirk of C structs with no
                    // typedef; treat them like regular pointers.
                    return PointerType.Pointer;
                case "@**":
                    return PointerType.DoublePointer;
                case "const @*":
                    return PointerType.ConstPointer;
                case "const @* const*":
                    return PointerType.DoubleConstPointer;
                default:
                    throw new NotSupportedException(string.Format("Unknown pointer type string '{0}'.", typeString));
            }
        }

        private struct NameParts
        {
            public string[] Parts;
            public string Extension;
        }

        public static string[] GetNameParts(string vkName, out string extension, bool hasVkPrefix = true)
        {
            var result = namePartsParser.TryParse(vkName);

            if (result.WasSuccessful && (!hasVkPrefix || result.Value.Parts[0] == "vk"))
            {
                extension = result.Value.Extension;

                var parts = result.Value.Parts.AsEnumerable();

                if (extension != null && extension.Length == 1)
                {
                    parts = parts.Concat(new[] { extension });

                    extension = null;
                }

                if (hasVkPrefix)
                {
                    return parts.Skip(1).ToArray();
                }
                else
                {
                    return parts.ToArray();
                }
            }
            else
            {
                extension = null;

                return null;
            }
        }

        public class ParsedSpec
        {
            public Dictionary<string, ParsedType> Types
            {
                get;
                private set;
            } = new Dictionary<string, ParsedType>();

            public Dictionary<string, ParsedCommand> Commands
            {
                get;
                private set;
            } = new Dictionary<string, ParsedCommand>();

            public Dictionary<string, ParsedEnum> Enumerations
            {
                get;
                private set;
            } = new Dictionary<string, ParsedEnum>();

            public Dictionary<string, ParsedEnumField> Constants
            {
                get;
                private set;
            } = new Dictionary<string, ParsedEnumField>();
        }

        public class ParsedElement
        {
            public string VkName;
            public string Type;
            public string[] NameParts;
            public string Extension;
            public string Comment;
        }

        public class ParsedType
            : ParsedElement
        {
            public TypeCategory Category;
            public string Requires;
            public string Parent;
            public bool IsReturnedOnly;
            public readonly List<ParsedMember> Members = new List<ParsedMember>();
        }

        public struct ParsedFixedLength
        {
            public string Value;
            public FixedLengthType Type;
        }

        public enum FixedLengthType
        {
            None,
            IntegerLiteral,
            EnumReference
        }

        public class ParsedMember
            : ParsedPointerElement
        {
        }

        public class ParsedCommand
            : ParsedElement
        {
            public string Verb;
            public readonly List<ParsedParam> Params = new List<ParsedParam>();
        }

        public class ParsedPointerElement
            : ParsedElement
        {
            public bool IsOptional;
            public ParsedFixedLength FixedLength;
            public ParsedLen[] Dimensions;
            public PointerType PointerType;
        }

        public class ParsedParam
            : ParsedPointerElement
        {
        }

        public class ParsedEnum
            : ParsedElement
        {
            public readonly Dictionary<string, ParsedEnumField> Fields = new Dictionary<string, ParsedEnumField>();
        }

        public class ParsedEnumField
            : ParsedElement
        {
            public string Value;
            public bool IsBitmask;
        }

        public class ParsedLen
        {
            public string Value;
            public LenType Type;
        }

        public enum LenType
        {
            Expression,
            NullTerminated
        }
    }
}