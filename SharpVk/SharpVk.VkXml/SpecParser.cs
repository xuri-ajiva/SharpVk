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

                typeXml.Add(name, new ParsedType
                {
                    VkName = name,
                    Category = category,
                    Requires = requires,
                    Parent = parent,
                    ReturnedOnly = returnedOnly
                });
            }

            var commandXml = new Dictionary<string, ParsedCommand>();

            var paramTypes = new List<string>();

            foreach (var vkCommand in vkXml.Element("registry").Element("commands").Elements("command"))
            {
                string name = vkCommand.Element("proto").Element("name").Value;
                string type = vkCommand.Element("proto").Element("type").Value;

                var newCommand = new ParsedCommand
                {
                    VkName = name,
                    Type = type
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

                    newCommand.Params.Add(new ParsedParam
                    {
                        VkName = name,
                        Type = type,
                        TypeString = typeString
                    });
                }
            }

            foreach (var typeString in paramTypes.Distinct().OrderBy(x => x))
            {
                Console.WriteLine(typeString);
            }

            var vkFeature = vkXml.Element("registry").Elements("feature").Single(x => x.Attribute("api").Value == "vulkan");

            var requiredTypes = new List<string>();

            foreach (var requirement in vkFeature.Elements("require").SelectMany(x => x.Elements()))
            {
                switch (requirement.Name.LocalName)
                {
                    case "command":
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
        }

        private class ParsedElement
        {
            public string VkName;
            public string Type;
            public string[] NameParts;
            public string Extension;
        }

        private class ParsedType
            : ParsedElement
        {
            public TypeCategory Category;
            public string Requires;
            public string Parent;
            public string ReturnedOnly;
            public readonly List<ParsedMember> Members = new List<ParsedMember>();
        }

        private class ParsedMember
            : ParsedElement
        {
            //public string Type;
            //public string Name;
        }

        private class ParsedCommand
            : ParsedElement
        {
            public readonly List<ParsedParam> Params = new List<ParsedParam>();
        }

        private class ParsedParam
            : ParsedElement
        {
            public string TypeString;
        }
    }
}