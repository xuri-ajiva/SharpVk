using SharpVk.Emit;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class SimpleMemberPattern
        : IMemberPatternRule
    {
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public SimpleMemberPattern(IEnumerable<IMarshalValueRule> marshallingRules, NameLookup nameLookup, Dictionary<string, TypeDeclaration> typeData)
        {
            this.marshallingRules = marshallingRules;
            this.nameLookup = nameLookup;
            this.typeData = typeData;
        }

        public bool Apply(IEnumerable<ITypedDeclaration> others, ITypedDeclaration source, Func<string, Action<ExpressionBuilder>> getHandle, MemberPatternInfo info)
        {
            var marshalling = this.marshallingRules.ApplyFirst(source.Type);

            bool isOptional = source.IsOptional && this.typeData[source.Type.VkName].Pattern != TypePattern.Delegate
                                                    && this.typeData[source.Type.VkName].Pattern != TypePattern.Handle
                                                    && this.typeData[source.Type.VkName].Pattern != TypePattern.Enum;

            info.Public = new TypedDefinition
            {
                Name = source.Name,
                Type = marshalling.MemberType + (isOptional ? "?" : ""),
                DefaultValue = isOptional ? Null : null
            };

            string typeName = this.nameLookup.Lookup(source.Type, true);

            info.Interop = new TypedDefinition
            {
                Name = source.Name,
                Type = typeName
            };

            info.InteropFullType = marshalling.InteropType;

            if (source.Type.PointerType.IsPointer())
            {
                info.InteropFullType += new string('*', source.Type.PointerType.GetPointerCount());
            }

            info.MarshalTo.Add((getTarget, getValue) =>
            {
                var valueExpression = isOptional
                                        ? marshalling.BuildMarshalToValueExpression(Member(getValue(source.Name), "Value"), getHandle)
                                        : marshalling.BuildMarshalToValueExpression(getValue(source.Name), getHandle);
                var assignment = new AssignAction
                {
                    ValueExpression = valueExpression,
                    TargetExpression = getTarget(source.Name),
                    MemberType = marshalling.InteropType,
                    Type = marshalling.MarshalToActionType
                };

                if(isOptional)
                {
                    var result = new OptionalAction
                    {
                        NullCheckExpression = IsNotEqual(getValue(source.Name), Null)
                    };

                    result.Actions.Add(assignment);
                    result.ElseActions.Add(new AssignAction
                    {
                        Type = AssignActionType.Assign,
                        TargetExpression = getTarget(source.Name),
                        ValueExpression = Default(info.InteropFullType)
                    });

                    return result;
                }
                else
                {
                    return assignment;
                }
            });

            info.MarshalFrom.Add((getTarget, getValue) => new AssignAction
            {
                ValueExpression = marshalling.BuildMarshalFromValueExpression(getValue(source.Name), getHandle),
                TargetExpression = getTarget(source.Name),
                MemberType = marshalling.MemberType,
                Type = marshalling.MarshalFromActionType
            });

            return true;
        }
    }
}
