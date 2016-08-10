using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.VkXml
{
    internal class ParsedExpressionBuilder
        : SpecParser.IParsedExpressionVisitor<ParsedExpressionBuilder.ExpressionBuildState>
    {
        private Dictionary<string, string> paramNameLookup;
        private Dictionary<string, SpecParser.ParsedElement> elementLookup;
        private Dictionary<string, TypeGenerator.TypeDesc> typeData;

        public ParsedExpressionBuilder(Dictionary<string, string> paramNameLookup, IEnumerable<SpecParser.ParsedElement> elements, Dictionary<string, TypeGenerator.TypeDesc> typeData)
        {
            this.elementLookup = elements.ToDictionary(x => x.VkName, x => x);
            this.paramNameLookup = paramNameLookup;
            this.typeData = typeData;
        }

        public void Visit(SpecParser.ParsedExpressionToken parsedExpressionToken, ExpressionBuildState state)
        {
            state.Builder.Append(paramNameLookup[parsedExpressionToken.Value]);
            state.ExpressionType = elementLookup[parsedExpressionToken.Value].Type;
        }

        public void Visit(SpecParser.ParsedExpressionReference reference, ExpressionBuildState state)
        {
            reference.LeftOperand.Visit(this, state);
            state.Builder.Append(".");
            var targetType = typeData[state.ExpressionType];
            var member = targetType.Data.Members.Single(x => x.VkName == reference.RightOperand.Value);
            state.Builder.Append(TypeGenerator.GetNameForElement(member));
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
            state.Builder.Append(literal.Value + "f");
            state.ExpressionType = "float";
        }

        public void Visit(SpecParser.ParsedExpressionOperator @operator, ExpressionBuildState state)
        {
            switch (@operator.Operator)
            {
                case SpecParser.ParsedOperatorType.Divide:
                    state.Builder.Append("(int)");
                    @operator.LeftOperand.Visit(this, state);
                    state.Builder.Append(" / ");
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