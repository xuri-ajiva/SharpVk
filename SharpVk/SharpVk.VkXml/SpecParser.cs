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
        private readonly IVkXmlCache xmlCache;

        public SpecParser(IVkXmlCache xmlCache)
        {
            this.xmlCache = xmlCache;
        }

        public void Run()
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

                        Console.WriteLine(fixedLength.Value);
                    }

                    newType.Members.Add(new ParsedMember
                    {
                        VkName = memberName,
                        Type = memberType,
                        IsOptional = isOptional,
                        FixedLength = fixedLength
                    });
                }

                typeXml.Add(name, newType);
            }

            var commandXml = new Dictionary<string, ParsedCommand>();

            foreach (var vkCommand in vkXml.Element("registry").Element("commands").Elements("command"))
            {
                string name = vkCommand.Element("proto").Element("name").Value;
                string type = vkCommand.Element("proto").Element("type").Value;

                string extension;

                string[] nameParts = GetNameParts(name, out extension);

                var newCommand = new ParsedCommand
                {
                    VkName = name,
                    Type = type,
                    NameParts = nameParts,
                    Extension = extension
                };

                commandXml.Add(name, newCommand);

                foreach (var vkParam in vkCommand.Elements("param"))
                {
                    string paramName = vkParam.Element("name").Value;
                    string paramType = vkParam.Element("type").Value;

                    var typeNodes = vkParam.Nodes().TakeWhile(x => x.NodeType != XmlNodeType.Element || ((XElement)x).Name != "name");
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

                    string paramExtension;

                    string[] paramNameParts = GetNameParts(paramName, out paramExtension);

                    newCommand.Params.Add(new ParsedParam
                    {
                        VkName = paramName,
                        Type = paramType,
                        TypeString = typeString,
                        NameParts = paramNameParts,
                        Extension = paramExtension
                    });
                }
            }

            var vkFeature = vkXml.Element("registry").Elements("feature").Single(x => x.Attribute("api").Value == "vulkan");

            var requiredTypes = new List<string>();
            var requiredCommand = new List<string>();

            foreach (var requirement in vkFeature.Elements("require").SelectMany(x => x.Elements()))
            {
                switch (requirement.Name.LocalName)
                {
                    case "command":
                        requiredCommand.Add(requirement.Attribute("name").Value);
                        break;
                    case "enum":
                        break;
                    case "type":
                        requiredTypes.Add(requirement.Attribute("name").Value);
                        break;
                    default:
                        throw new Exception("Unexpected requirement type: " + requirement.Name.LocalName);
                }
            }

            foreach (var commandName in requiredCommand.Distinct())
            {
                var command = commandXml[commandName];

                Console.WriteLine(string.Join(" ", command.NameParts));

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

                foreach (var member in typesToCheck.SelectMany(x => typeXml[x].Members))
                {
                    if (!requiredTypes.Contains(member.Type) && !newTypes.Contains(member.Type))
                    {
                        newTypes.Add(member.Type);
                    }
                }

                requiredTypes.AddRange(newTypes);
            }

            foreach (var typeName in requiredTypes.Distinct().OrderBy(x => x))
            {
                var type = typeXml[typeName];

                if (type.NameParts != null)
                {
                    Console.WriteLine(string.Join(" ", type.NameParts));
                }
                else
                {
                    Console.WriteLine(type.VkName);
                }
            }
        }

        private static Parser<string> namePart = from head in Parse.Upper
                                                 from tail in Parse.Lower.AtLeastOnce()
                                                 select new string(new[] { head }.Concat(tail).ToArray()).ToLower();

        private static Parser<string> keywordPart = Parse.String("2D")
                                                        .Or(Parse.String("3D"))
                                                        .Or(Parse.String("32"))
                                                        .Or(Parse.String("64"))
                                                        .Text();

        private static Parser<NameParts> namePartsParser = from prefix in Parse.IgnoreCase("vk")
                                                           from parts in keywordPart.Or(namePart).Many()
                                                           from extension in Parse.Upper.Many().Text().End()
                                                           select new NameParts
                                                           {
                                                               Parts = parts.ToArray(),
                                                               Extension = string.IsNullOrEmpty(extension)
                                                                            ? null
                                                                            : extension.ToLower()
                                                           };

        private static Parser<string> fixedLengthParser = from open in Parse.Char('[')
                                                          from digits in Parse.Digit.AtLeastOnce().Text()
                                                          from close in Parse.Char(']')
                                                          select digits;

        private struct NameParts
        {
            public string[] Parts;
            public string Extension;
        }

        public static string[] GetNameParts(string vkName, out string extension)
        {
            var result = namePartsParser.TryParse(vkName);

            if (result.WasSuccessful)
            {
                extension = result.Value.Extension;

                return result.Value.Parts;
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
        }

        public class ParsedElement
        {
            public string VkName;
            public string Type;
            public string[] NameParts;
            public string Extension;
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
            IntegerLiteral,
            EnumReference
        }

        public class ParsedMember
            : ParsedElement
        {
            public bool IsOptional;
            public ParsedFixedLength FixedLength;
        }

        public class ParsedCommand
            : ParsedElement
        {
            public readonly List<ParsedParam> Params = new List<ParsedParam>();
        }

        public class ParsedParam
            : ParsedElement
        {
            public string TypeString;
        }
    }
}