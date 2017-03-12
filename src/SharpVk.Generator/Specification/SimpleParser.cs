using Sprache;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public static class SimpleParser
    {

        private static readonly Parser<ParsedExpression> lenExpressionParserRef = Parse.Ref(() => lenExpressionParser);

        private static readonly Parser<ParsedExpressionToken> lenTokenParser = Parse.Letter.AtLeastOnce().Text().Select(x => new ParsedExpressionToken { Value = x });

        private static readonly Parser<ParsedExpressionReference> lenDereferenceParser = from left in lenTokenParser
                                                                                         from op in Parse.String("::")
                                                                                         from right in lenTokenParser
                                                                                         select new ParsedExpressionReference
                                                                                         {
                                                                                             LeftOperand = left,
                                                                                             RightOperand = right
                                                                                         };

        private static readonly Parser<string> Sign = Parse.Char('-').Optional().Select(x => x.IsDefined ? "-" : "");

        private static readonly Parser<ParsedExpressionLiteral> integerLiteral = from sign in Sign
                                                                                 from digits in Parse.Digit.AtLeastOnce().Text().Token()
                                                                                 select new ParsedExpressionLiteral { Value = sign + digits };

        private static readonly Parser<ParsedExpressionToken> latexToken = Parse.LetterOrDigit.AtLeastOnce()
                                                                                                 .Where(x => char.IsLetter(x.First()))
                                                                                                 .Text()
                                                                                                 .Token()
                                                                                                 .Select(x => new ParsedExpressionToken { Value = x });

        private static readonly Parser<ParsedExpression> latexSubexpressionRef = Parse.Ref(() => latexSubexpression);

        private static readonly Parser<ParsedExpression> latexUnaryOperatorExpression = latexSubexpressionRef.Contained(Parse.String("\\lceil{"), Parse.String("}\\rceil")).Token().Select(x => new ParsedExpressionOperator { LeftOperand = x, Operator = ParsedOperatorType.Ceiling });

        private static readonly Parser<ParsedExpression> latexPrimaryExpression = ((Parser<ParsedExpression>)latexToken)
                                                                                                                                    .Or(latexToken.Contained(Parse.String("\\mathit{"), Parse.String("}")))
                                                                                                                                    .Or(integerLiteral)
                                                                                                                                    .Or(latexUnaryOperatorExpression);

        private static readonly Parser<ParsedExpression> latexMultiplicativeExpression = Parse.ChainOperator(Parse.String("\\over").Token(),
                                                                                                                            latexPrimaryExpression,
                                                                                                                            (op, left, right) => new ParsedExpressionOperator { LeftOperand = left, RightOperand = right, Operator = ParsedOperatorType.Divide });

        private static readonly Parser<ParsedExpression> latexSubexpression = latexMultiplicativeExpression;

        private static readonly Parser<string> latexExpressionStart = from start in Parse.String("latexmath:[").Text()
                                                                      from dollar in Parse.Char('$').Optional()
                                                                      select start;

        private static readonly Parser<char> latexExpressionEnd = from dollar in Parse.Char('$').Optional()
                                                                  from end in Parse.Char(']')
                                                                  select end;

        private static readonly Parser<ParsedExpression> latexExpression = latexSubexpression.Contained(latexExpressionStart, latexExpressionEnd);

        private static readonly Parser<ParsedExpression> lenExpressionParser = latexExpression
                                                                                    .Or(lenDereferenceParser)
                                                                                    .Or(lenTokenParser);

        private static readonly Parser<ParsedLen> lenPartParser = Parse.String("null-terminated").Select(x => new ParsedLen { Type = LenType.NullTerminated })
                                                                        .Or(lenExpressionParser.Select(x => new ParsedLen { Value = x, Type = LenType.Expression }));

        private static readonly Parser<IEnumerable<ParsedLen>> lenParser = lenPartParser.DelimitedBy(Parse.Char(',').Token()).End();

        private static readonly Parser<string> fixedLengthParser = from open in Parse.Char('[')
                                                                   from digits in Parse.Digit.AtLeastOnce().Text()
                                                                   from close in Parse.Char(']')
                                                                   select digits;

        public static string ParseFixedLength(string value)
        {
            return fixedLengthParser.Parse(value);
        }

        public static ParsedLen[] ParsedLenField(string field)
        {
            return lenParser.Parse(field).ToArray();
        }

        public static string NormaliseComment(string comment)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                return "-";
            }

            comment = comment.Replace("&", "&amp;");
            comment = comment.Replace("<", "&lt;");
            comment = comment.Replace(">", "&gt;");

            return comment;
        }
    }

    public class ParsedLen
    {
        public ParsedExpression Value;
        public LenType Type;
    }

    public abstract class ParsedExpression
    {
        public abstract void Visit<T>(IParsedExpressionVisitor<T> visitor, T state);
    }

    public class ParsedExpressionLiteral
        : ParsedExpression
    {
        public string Value;

        public override void Visit<T>(IParsedExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }

        public override string ToString()
        {
            return $"Literal: {Value}";
        }
    }

    public class ParsedExpressionToken
        : ParsedExpression
    {
        public string Value;

        public override void Visit<T>(IParsedExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }

        public override string ToString()
        {
            return $"Token: '{this.Value}'";
        }
    }

    public class ParsedExpressionReference
        : ParsedExpression
    {
        public ParsedExpression LeftOperand;
        public ParsedExpressionToken RightOperand;

        public override void Visit<T>(IParsedExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }
    }

    public class ParsedExpressionOperator
        : ParsedExpression
    {
        public ParsedOperatorType Operator;
        public ParsedExpression LeftOperand;
        public ParsedExpression RightOperand;

        public override void Visit<T>(IParsedExpressionVisitor<T> visitor, T state)
        {
            visitor.Visit(this, state);
        }

        public override string ToString()
        {
            return $"Operator: {LeftOperand} {Operator} {RightOperand}";
        }
    }

    public enum ParsedOperatorType
    {
        Divide,
        Ceiling
    }

    public interface IParsedExpressionVisitor<T>
    {
        void Visit(ParsedExpressionReference reference, T state);

        void Visit(ParsedExpressionToken token, T state);

        void Visit(ParsedExpressionLiteral literal, T state);

        void Visit(ParsedExpressionOperator @operator, T state);
    }

    public enum LenType
    {
        Expression,
        NullTerminated
    }
}
