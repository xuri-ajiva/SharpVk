using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification
{
    public class FunctionPointerTypeRule
        : ITypeExtensionRule
    {
        public void Apply(XElement typeXml, TypeElement type, IServiceCollection target)
        {
            string returnType = ((XText)typeXml.Nodes().First()).Value.Split(' ')[1];

            if (returnType.EndsWith("*"))
            {
                returnType = returnType.TrimEnd('*');

                type.IsTypePointer = true;
            }

            type.Type = returnType;


            var functionTail = typeXml.Element("name").NodesAfterSelf();

            foreach (var typeElement in functionTail.Where(x => x.NodeType == XmlNodeType.Element).Cast<XElement>())
            {
                string pre = ((XText)typeElement.PreviousNode).Value.Split(',').Last().Trim('(', ')', ';').TrimStart();
                string post = ((XText)typeElement.NextNode).Value.Split(',').First().Trim('(', ')', ';').TrimEnd();

                string paramName = new string(post.Reverse().TakeWhile(char.IsLetterOrDigit).Reverse().ToArray());
                string typeString = pre + "@" + (post.Substring(0, post.Length - paramName.Length).Trim());
                string paramType = typeElement.Value;
                PointerType pointerType = PointerTypeUtil.Map(typeString);

                //string paramExtension;

                //string[] paramNameParts = GetNameParts(paramName, out paramExtension, knownExtensions, false);

                type.Members.Add(new MemberElement
                {
                    VkName = paramName,
                    Type = paramType,
                    PointerType = pointerType,
                    //NameParts = paramNameParts,
                    //Extension = paramExtension
                });
            }
        }

        public bool CanApply(XElement typeXml, TypeElement type)
            => type.Category == TypeCategory.funcpointer;
    }
}
