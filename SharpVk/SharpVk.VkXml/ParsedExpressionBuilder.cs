using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.VkXml
{
    internal class ParsedExpressionBuilder
        : SpecParser.IParsedExpressionVisitor<ParsedExpressionBuilder.ExpressionBuildState>
    {
        private Dictionary<string, string> nameLookup;
        private Dictionary<string, SpecParser.ParsedElement> elementLookup;
        private Dictionary<string, TypeGenerator.TypeDesc> typeData;
        private Dictionary<string, string> mapping;

        public ParsedExpressionBuilder(Dictionary<string, string> nameLookup, IEnumerable<SpecParser.ParsedElement> elements, Dictionary<string, string> mapping, Dictionary<string, TypeGenerator.TypeDesc> typeData)
        {
            this.elementLookup = elements.ToDictionary(x => x.VkName, x => x);
            this.nameLookup = nameLookup;
            this.mapping = mapping;
            this.typeData = typeData;
        }

        public void Visit(SpecParser.ParsedExpressionToken parsedExpressionToken, ExpressionBuildState state)
        {
            string name = nameLookup[parsedExpressionToken.Value];

            if (this.mapping != null && this.mapping.ContainsKey(name))
            {
                name = this.mapping[name] + ".Length";
            }

            state.Builder.Append(name);
            state.ExpressionType = elementLookup[parsedExpressionToken.Value].Type;
        }

        public void Visit(SpecParser.ParsedExpressionReference reference, ExpressionBuildState state)
        {
            reference.LeftOperand.Visit(this, state);
            state.Builder.Append(".");
            var targetType = typeData[state.ExpressionType];

            var memberMappings = targetType.Data.Members
                                                    .Where(x => x.Dimensions != null)
                                                    .ToDictionary(x => ((SpecParser.ParsedExpressionToken)x.Dimensions[0].Value).Value);

            var member = targetType.Data.Members.Single(x => x.VkName == reference.RightOperand.Value);

            string memberName;

            if (memberMappings.ContainsKey(member.VkName))
            {
                memberName = TypeGenerator.GetNameForElement(memberMappings[member.VkName]) + ".Length";
            }
            else
            {
                memberName = TypeGenerator.GetNameForElement(member);
            }

            state.Builder.Append(memberName);
            state.ExpressionType = member.Type;
        }

        public class ExpressionBuildState
        {
            public StringBuilder Builder;
            public string ExpressionType;
        }

        public string Build(SpecParser.ParsedExpression value)
        {
            var builder = new StringBuilder();

            value.Visit(this, new ExpressionBuildState
            {
                Builder = builder,
                ExpressionType = null
            });

            return builder.ToString();
        }

        public void Visit(SpecParser.ParsedExpressionLiteral literal, ExpressionBuildState state)
        {
            state.Builder.Append(literal.Value);
            state.ExpressionType = "int32";
        }

        public void Visit(SpecParser.ParsedExpressionOperator @operator, ExpressionBuildState state)
        {
            switch (@operator.Operator)
            {
                case SpecParser.ParsedOperatorType.Divide:
                    state.Builder.Append("(int)");
                    @operator.LeftOperand.Visit(this, state);
                    state.Builder.Append(" / (float)");
                    @operator.RightOperand.Visit(this, state);
                    break;
                case SpecParser.ParsedOperatorType.Ceiling:
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