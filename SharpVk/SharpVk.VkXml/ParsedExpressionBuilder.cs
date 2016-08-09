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
        private Dictionary<string, SpecParser.ParsedParam> paramLookup;
        private Dictionary<string, TypeGenerator.TypeDesc> typeData;

        public ParsedExpressionBuilder(Dictionary<string, string> paramNameLookup, List<SpecParser.ParsedParam> commandParams, Dictionary<string, TypeGenerator.TypeDesc> typeData)
        {
            this.paramLookup = commandParams.ToDictionary(x => x.VkName, x => x);
            this.paramNameLookup = paramNameLookup;
            this.typeData = typeData;
        }

        public void Visit(SpecParser.ParsedExpressionToken parsedExpressionToken, ExpressionBuildState state)
        {
            state.Builder.Append(paramNameLookup[parsedExpressionToken.Value]);
            state.ExpressionType = paramLookup[parsedExpressionToken.Value].Type;
        }

        public void Visit(SpecParser.ParsedExpressionOperator parsedExpressionOperator, ExpressionBuildState state)
        {
            switch (parsedExpressionOperator.Operator)
            {
                case SpecParser.ParsedOperatorType.Dereference:
                    parsedExpressionOperator.LeftOperand.Visit(this, state);
                    state.Builder.Append(".");
                    var targetType = typeData[state.ExpressionType];
                    var member = targetType.Data.Members.Single(x => x.VkName == parsedExpressionOperator.RightOperand.Value);
                    state.Builder.Append(TypeGenerator.GetNameForElement(member));
                    state.ExpressionType = member.Type;
                    break;
                default:
                    throw new NotImplementedException();
            }
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
    }
}