using SharpVk.Generator.Collation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Generator.Generation.Marshalling
{
    internal class ParsedExpressionBuilder
       : ILenExpressionVisitor<ParsedExpressionBuilder.ExpressionBuildState>
    {
        private Dictionary<string, TypeDeclaration> typeData;

        public ParsedExpressionBuilder(Dictionary<string, TypeDeclaration> typeData)
        {
            this.typeData = typeData;
        }

        public void Visit(LenExpressionToken parsedExpressionToken, ExpressionBuildState state)
        {
            var member = state.Context.Members.Single(x => x.VkName == parsedExpressionToken.Value);

            string name = member.Name;

            //if (this.mapping != null && this.mapping.ContainsKey(name))
            //{
            //    name = this.mapping[name] + ".Length";
            //}

            state.Builder.Append(name);
            state.ExpressionType = member.Type.VkName;
        }

        public void Visit(LenExpressionReference reference, ExpressionBuildState state)
        {
            throw new NotImplementedException();
            //reference.LeftOperand.Visit(this, state);
            //state.Builder.Append(".");
            //var targetType = typeData[state.ExpressionType];

            //var memberMappings = targetType.Members
            //                                        .Where(x => x.Dimensions != null)
            //                                        .ToDictionary(x => ((LenExpressionToken)x.Dimensions[0].Value).Value);

            //var member = targetType.Members.Single(x => x.VkName == reference.RightOperand.Value);

            //string memberName;

            //if (memberMappings.ContainsKey(member.VkName))
            //{
            //    memberName = TypeGenerator.GetNameForElement(memberMappings[member.VkName]) + ".Length";
            //}
            //else
            //{
            //    memberName = TypeGenerator.GetNameForElement(member);
            //}

            //state.Builder.Append(memberName);
            //state.ExpressionType = member.Type;
        }

        public class ExpressionBuildState
        {
            public StringBuilder Builder;
            public string ExpressionType;
            public TypeDeclaration Context;
        }

        public string Build(LenExpression value, TypeDeclaration type)
        {
            var builder = new StringBuilder();

            value.Visit(this, new ExpressionBuildState
            {
                Builder = builder,
                ExpressionType = null,
                Context = type
            });

            return builder.ToString();
        }

        public void Visit(LenExpressionLiteral literal, ExpressionBuildState state)
        {
            state.Builder.Append(literal.Value);
            state.ExpressionType = "int32";
        }

        public void Visit(LenExpressionOperator @operator, ExpressionBuildState state)
        {
            switch (@operator.Operator)
            {
                case LenOperatorType.Divide:
                    state.Builder.Append("(int)");
                    @operator.LeftOperand.Visit(this, state);
                    state.Builder.Append(" / (float)");
                    @operator.RightOperand.Visit(this, state);
                    break;
                case LenOperatorType.Ceiling:
                    state.Builder.Append("Math.Ceiling(");
                    @operator.LeftOperand.Visit(this, state);
                    state.Builder.Append(")");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}