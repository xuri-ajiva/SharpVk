using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SharpVk.VkXml
{
    public class TypeDefCache
    {
        private IVkXmlCache xmlCache;
        private Dictionary<string, TypeDef> typeCache;
        private Dictionary<string, CommandDef> commandCache;

        string[] extensionSuffixes = new[] { "KHR", "EXT" };

        private static readonly Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"void", "void"},
            {"char", "char"},
            {"float", "float"},
            {"uint8_t", "byte"},
            {"uint32_t", "uint"},
            {"uint64_t", "ulong"},
            {"int32_t", "int"},
            {"size_t", "UIntPtr"}
        };

        public TypeDefCache(IVkXmlCache xmlCache)
        {
            this.xmlCache = xmlCache;
        }

        public Dictionary<string, CommandDef> GetAllCommands()
        {
            if (this.commandCache == null)
            {
                var keywords = new[] { "object", "event" };
                var types = this.GetAllTypes();

                this.commandCache = new Dictionary<string, CommandDef>();

                foreach (var command in this.xmlCache.GetVkXml().Element("registry").Element("commands").Elements("command").Where(x => !extensionSuffixes.Any(y => x.Element("proto").Value.EndsWith(y))))
                {
                    bool isUnsupportedCommand = false;

                    var prototype = command.Element("proto");
                    var commandType = types[prototype.Element("type").Value];
                    string commandName = prototype.Element("name").Value;

                    var commandDef = new CommandDef
                    {
                        Name = commandName,
                        Type = commandType
                    };

                    foreach (var parameter in command.Elements("param"))
                    {
                        string paramName = parameter.Element("name").Value;

                        int pointerCount = 0;

                        while (paramName[0] == 'p' && (paramName[1] == 'p' || char.IsUpper(paramName[1])))
                        {
                            pointerCount++;

                            paramName = paramName.Substring(1);
                        }

                        bool isOutput = !parameter.Value.StartsWith("const") && pointerCount > 0;

                        if (pointerCount > 0)
                        {
                            paramName = paramName = char.ToLower(paramName[0]) + paramName.Substring(1);
                        }

                        string vkTypeName = parameter.Element("type").Value;

                        if (vkTypeName.Contains("SurfaceCreateInfo"))
                        {
                            // This method requires an unimplemented type, so skip it

                            isUnsupportedCommand = true;

                            break;
                        }

                        var paramType = types[vkTypeName];

                        if (paramType.Category == Category.other_platform)
                        {
                            // This method requires an unimplemented type, so skip it

                            isUnsupportedCommand = true;

                            break;
                        }

                        if (keywords.Contains(paramName))
                        {
                            paramName = "@" + paramName;
                        }

                        commandDef.Params.Add(new CommandDef.ParamDef
                        {
                            Name = paramName,
                            Type = paramType,
                            PointerCount = pointerCount
                        });
                    }

                    if (!isUnsupportedCommand)
                    {
                        this.commandCache.Add(commandName, commandDef);
                    }
                }
            }

            return this.commandCache;
        }

        public Dictionary<string, TypeDef> GetAllTypes()
        {
            if (this.typeCache == null)
            {
                var vkXml = this.xmlCache.GetVkXml();

                var stringType = new TypeDef
                {
                    Category = Category.basetype,
                    IsPrimitive = true,
                    Name = "string"
                };

                Category typeCategory = Category.None;

                var result = new Dictionary<string, TypeDef>();

                foreach (var vkType in vkXml.Element("registry").Element("types").Elements("type"))
                {
                    var additionalTypeNames = new List<string>();

                    string vkRequires = vkType.Attribute("requires")?.Value;
                    bool isPrimitive = false;
                    bool isReturnedOnly = vkType.Attribute("returnedonly")?.Value == "true";

                    if (vkType.Attribute("category") == null || !Enum.TryParse(vkType.Attribute("category").Value, out typeCategory))
                    {
                        if (vkRequires == "vk_platform")
                        {
                            typeCategory = Category.vk_platform;
                        }
                        else
                        {
                            typeCategory = Category.other_platform;
                        }
                    }

                    string vkTypeName = null;

                    if (vkType.Attribute("name") != null)
                    {
                        vkTypeName = vkType.Attribute("name").Value;
                    }
                    else
                    {
                        vkTypeName = vkType.Element("name").Value;
                    }

                    if (vkTypeName.Contains("SurfaceCreateInfo"))
                    {
                        // Skip these for now...

                        continue;
                    }

                    string typeName = vkTypeName;

                    if (primitiveTypes.ContainsKey(vkTypeName))
                    {
                        typeName = primitiveTypes[vkTypeName];
                        isPrimitive = true;
                    }
                    else if (typeCategory == Category.bitmask)
                    {
                        if (vkRequires == null)
                        {
                            typeName = "uint";
                        }
                        else
                        {
                            additionalTypeNames.Add(vkRequires);
                        }
                    }
                    else if (typeCategory == Category.funcpointer)
                    {
                        typeName = "IntPtr";
                    }

                    if (typeName.StartsWith("vk", true, null))
                    {
                        typeName = typeName.Substring(2);
                    }

                    additionalTypeNames.Add(vkTypeName);

                    //HACK
                    if (typeName.EndsWith("Bits"))
                    {
                        typeName = typeName.Substring(0, typeName.Length - 4) + "s";
                    }

                    var typeDef = new TypeDef
                    {
                        Category = typeCategory,
                        Name = typeName,
                        Xml = vkType,
                        Requires = vkRequires,
                        IsPrimitive = isPrimitive,
                        IsReturnedOnly = isReturnedOnly
                    };

                    foreach (var additionalTypeName in additionalTypeNames)
                    {
                        if (!result.ContainsKey(vkTypeName))
                        {
                            result.Add(vkTypeName, typeDef);
                        }
                    }
                }

                this.typeCache = result;

                var constantsEnum = vkXml.Element("registry").Elements("enums").First(x => x.Attribute("name")?.Value == "API Constants");

                var constants = new Dictionary<string, int>();

                foreach (var constant in constantsEnum.Elements("enum"))
                {
                    int value;
                    string name = constant.Attribute("name").Value;

                    if (int.TryParse(constant.Attribute("value").Value, out value))
                    {
                        constants.Add(name, value);
                    }
                }

                foreach (var type in this.typeCache.Values)
                {
                    if (type.Category == Category.@struct || type.Category == Category.union)
                    {
                        var members = type.Members;

                        foreach (var typeMember in type.Xml.Elements("member"))
                        {
                            var nameNodes = new XNode[] { typeMember.Element("name") }.Concat(typeMember.Element("name").NodesAfterSelf());

                            string memberName = nameNodes.Select(x =>
                            {
                                var xAsText = x as XText;
                                if (xAsText != null)
                                {
                                    return xAsText.Value;
                                }
                                else
                                {
                                    var xAsElement = x as XElement;
                                    if (xAsElement?.Name == "enum")
                                    {
                                        return constants[xAsElement.Value].ToString();
                                    }
                                    else if (xAsElement?.Name == "name")
                                    {
                                        return xAsElement.Value;
                                    }
                                    else
                                    {
                                        throw new NotSupportedException();
                                    }
                                }
                            }).Aggregate((x, y) => x + y);

                            int count = 0;

                            int arraySuffixIndex = memberName.IndexOf('[');
                            if (arraySuffixIndex >= 0)
                            {
                                count = int.Parse(new string(memberName.Skip(arraySuffixIndex + 1).TakeWhile(x => char.IsDigit(x)).ToArray()));

                                memberName = memberName.Substring(0, arraySuffixIndex);
                            }

                            string vkMemberName = memberName;

                            int pointerCount = 0;

                            while (memberName[0] == 'p' && (memberName[1] == 'p' || char.IsUpper(memberName[1])))
                            {
                                pointerCount++;

                                memberName = memberName.Substring(1);
                            }

                            memberName = char.ToUpper(memberName[0]) + memberName.Substring(1);

                            string[] memberLen = typeMember.Attribute("len")?.Value?.Split(',').Select(x => x.Trim()).ToArray();

                            if (memberLen != null)
                            {
                                for (int index = 0; index < memberLen.Length; index++)
                                {
                                    if (memberLen[index].StartsWith("latexmath:"))
                                    {
                                        memberLen[index] = memberLen[index].Substring(12, memberLen[index].Length - 14);
                                        memberLen[index] = memberLen[index].Replace("\\over", "/");
                                    }
                                }
                            }

                            var memberType = this.typeCache[typeMember.Element("type").Value];

                            members.Add(new TypeDef.MemberInfo
                            {
                                Type = memberType,
                                Name = memberName,
                                PointerCount = pointerCount,
                                Size = count,
                                Len = memberLen,
                                VkName = vkMemberName
                            });
                        }

                        if (type.Category == Category.@struct && !members.Any(x => x.Type.Category == Category.handle || x.Type.Category == Category.@struct || x.PointerCount > 0 || x.Size > 0 || x.Type.Category == Category.basetype))
                        {
                            type.IsSimpleStruct = true;
                        }
                    }
                }

                bool simpleStructsFound = true;

                while (simpleStructsFound)
                {
                    simpleStructsFound = false;

                    foreach (var type in this.typeCache.Values.Where(x => !x.IsSimpleStruct))
                    {
                        if (type.Category == Category.@struct && !type.Members.Any(x => x.Type.Category == Category.handle || (x.Type.Category == Category.@struct && !x.Type.IsSimpleStruct) || x.PointerCount > 0 || x.Size > 0 || x.Type.Category == Category.basetype))
                        {
                            type.IsSimpleStruct = true;
                        }
                    }
                }
            }

            return this.typeCache;
        }
    }
}
