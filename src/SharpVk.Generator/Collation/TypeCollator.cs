using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public TypeCollator(IEnumerable<TypeElement> types)
        {
            this.types = types;
        }

        public void CollateTo(IServiceCollection services)
        {
            var handleTypes = this.types.Where(x => x.Category == TypeCategory.handle)
                                        .Select(x => x.VkName)
                                        .ToArray();

            var typeData = this.types
                                    .Where(x => x.Category != TypeCategory.define && x.Category != TypeCategory.include)
                                    .ToDictionary(x => x.VkName, x => new TypeDeclaration
                                    {
                                        Data = x,
                                        Name = GetTypeName(x),
                                        RequiresMarshalling = RequiresInterop(x, handleTypes),
                                        IsPrimitive = x.Category == TypeCategory.basetype || x.Category == TypeCategory.None
                                    });

            bool newInteropTypes = true;

            while (newInteropTypes)
            {
                newInteropTypes = false;

                foreach (var type in typeData.Values)
                {
                    if (!type.RequiresMarshalling
                            && type.Data.Members.Any(x => typeData[x.Type].RequiresMarshalling))
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

        private static string GetTypeName(TypeElement type)
        {
            return type.NameParts//.Select(ExpandAbbreviations)
                        .Select(x => x.FirstToUpper())
                        .Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                        .ToString();
        }


        private static bool RequiresInterop(TypeElement type, IEnumerable<string> handleTypes)
        {
            return type.Category == TypeCategory.@struct
                && type.Members.Any(y =>
                    y.FixedLength.Type != FixedLengthType.None
                        || (y.PointerType != PointerType.Value
                            && y.PointerType != PointerType.ConstValue
                            || handleTypes.Contains(y.Type)));
        }
    }
}
