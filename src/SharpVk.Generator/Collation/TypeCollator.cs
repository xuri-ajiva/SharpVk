using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace SharpVk.Generator.Collation
{
    public class TypeCollator
    {
        private static readonly Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"void", "void"},
            {"char", "char"},
            {"float", "float"},
            {"uint8_t", "byte"},
            {"uint32_t", "uint"},
            {"DWORD", "uint"},
            {"uint64_t", "ulong"},
            {"int32_t", "int"},
            {"size_t", "Size"},
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
            {"RROutput", "IntPtr" }
        };

        private readonly IEnumerable<TypeElement> types;
        private readonly NameFormatter nameFormatter;
        private readonly IEnumerable<string> handleTypes;

        public TypeCollator(IEnumerable<TypeElement> types, NameFormatter nameFormatter)
        {
            this.types = types;
            this.nameFormatter = nameFormatter;

            this.handleTypes = this.types.Where(x => x.Category == TypeCategory.handle)
                                        .Select(x => x.VkName)
                                        .ToArray();
        }

        public void CollateTo(IServiceCollection services)
        {
            var typeData = this.types
                                    .Where(x => x.Category != TypeCategory.define && x.Category != TypeCategory.include)
                                    .ToDictionary(x => x.VkName, x => new TypeDeclaration
                                    {
                                        Data = x,
                                        Name = this.nameFormatter.FormatName(x),
                                        RequiresMarshalling = RequiresMarshalling(x),
                                        IsPrimitive = x.Category == TypeCategory.basetype || x.Category == TypeCategory.None,
                                        Members = GetMembers(x).ToList()
                                    });

            bool newInteropTypes = true;

            while (newInteropTypes)
            {
                newInteropTypes = false;

                foreach (var type in typeData.Values)
                {
                    if (!type.RequiresMarshalling
                            && type.Members.Any(x => typeData[x.Type.VkName].RequiresMarshalling))
                    {
                        type.RequiresMarshalling = true;

                        newInteropTypes = true;
                    }
                }
            }

            foreach (var type in typeData.Values)
            {
                switch (type.Data.Category)
                {
                    case TypeCategory.None:
                        if (primitiveTypes.ContainsKey(type.Data.VkName))
                        {
                            type.Name = primitiveTypes[type.Data.VkName];
                        }
                        break;
                    case TypeCategory.funcpointer:
                        type.Name += "Delegate";
                        break;
                }
            }

            services.AddSingleton(typeData);
        }

        private IEnumerable<MemberDeclaration> GetMembers(TypeElement type)
        {
            foreach(var member in type.Members)
            {
                yield return new MemberDeclaration
                {
                    Name = this.nameFormatter.FormatName(member),
                    Type = new TypeReference
                    {
                        VkName = member.Type,
                        PointerType = member.PointerType
                    }
                };
            }
        }

        private bool RequiresMarshalling(TypeElement type)
        {
            return type.Category == TypeCategory.@struct
                && type.Members.Any(y =>
                    y.FixedLength.Type != FixedLengthType.None
                        || (y.PointerType != PointerType.Value
                            && y.PointerType != PointerType.ConstValue
                            || this.handleTypes.Contains(y.Type)));
        }
    }
}
