using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class CommandElementReader
    {
        private readonly IVkXmlCache xmlCache;
        private readonly NameParser nameParser;

        public CommandElementReader(IVkXmlCache xmlCache, NameParser nameParser)
        {
            this.xmlCache = xmlCache;
            this.nameParser = nameParser;
        }

        public void ReadTo(IServiceCollection services)
        {
            foreach (var vkCommand in this.xmlCache.GetVkXml().Element("registry").Element("commands").Elements("command"))
            {
                string name = vkCommand.Element("proto").Element("name").Value;
                string type = vkCommand.Element("proto").Element("type").Value;
                
                string[] nameParts = this.nameParser.GetNameParts(name, out string extension);

                string[] verbExceptions = new[] { "cmd", "queue", "device" };

                string verb = verbExceptions.Contains(nameParts[0]) ? nameParts[1] : nameParts[0];

                string[] successCodes = vkCommand.Attribute("successcodes")?.Value?.Split(',');

                var newCommand = new CommandElement
                {
                    VkName = name,
                    Type = type,
                    NameParts = nameParts,
                    Extension = extension,
                    Verb = verb,
                    SuccessCodes = successCodes
                };

                services.AddSingleton(newCommand);

                foreach (var vkParam in vkCommand.Elements("param"))
                {
                    var nameElement = vkParam.Element("name");

                    string paramName = nameElement.Value;
                    string paramType = vkParam.Element("type").Value;
                    bool.TryParse(vkParam.Attribute("optional")?.Value, out bool isOptional);

                    var typeNodes = nameElement.NodesBeforeSelf();
                    PointerType pointerType = PointerTypeUtil.GetFrom(typeNodes);
                    
                    var lenField = vkParam.Attribute("len");
                    var dimensions = lenField != null
                                        ? SimpleParser.ParsedLenField(lenField.Value)
                                        : null;
                    
                    string[] paramNameParts = this.nameParser.ParseParamName(paramName, pointerType, out string paramExtension);

                    newCommand.Params.Add(new ParamElement
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
        }
    }
}
