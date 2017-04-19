using System;

namespace SharpVk.Emit
{
    public class CodeBlockBuilder
        : BlockBuilder
    {
        private readonly bool writeSemicolons;

        public CodeBlockBuilder(IndentedTextWriter writer, bool hasBraces = true, bool writeSemicolons = true)
            : base(writer, hasBraces)
        {
            this.writeSemicolons = writeSemicolons;
        }

        public void EmitVariableDeclaration(string type, string name, Action<ExpressionBuilder> assignment = null)
        {
            this.writer.Write($"{type} {name}");
            if (assignment != null)
            {
                this.writer.Write(" = ");
                assignment(this.GetExpressionBuilder());
            }

            this.WriteSemicolon();
        }

        public void EmitAssignment(Action<ExpressionBuilder> target, Action<ExpressionBuilder> assignment)
        {
            target(this.GetExpressionBuilder());
            this.writer.Write(" = ");
            assignment(this.GetExpressionBuilder());

            this.WriteSemicolon();
        }

        public void EmitThrow(Action<ExpressionBuilder> expression)
        {
            this.writer.Write($"throw ");
            expression(this.GetExpressionBuilder());

            this.WriteSemicolon();
        }

        public void EmitReturn(Action<ExpressionBuilder> expression)
        {
            this.writer.Write($"return ");
            expression(this.GetExpressionBuilder());

            this.WriteSemicolon();
        }

        public void EmitStatement(string statement)
        {
            this.writer.Write(statement);

            if (this.writeSemicolons)
            {
                this.writer.WriteLine();
            }
        }

        public void EmitCallExpression(Action<ExpressionBuilder> expression)
        {
            expression(this.GetExpressionBuilder());

            this.WriteSemicolon();
        }

        public void EmitStaticCall(string type, string method, params Action<ExpressionBuilder>[] arguments)
        {
            this.EmitCallExpression(ExpressionBuilder.StaticCall(type, method, arguments));
        }

        public void EmitDelegateCall(Action<ExpressionBuilder> @delegate, params Action<ExpressionBuilder>[] arguments)
        {
            this.GetExpressionBuilder().EmitDelegateCall(@delegate, arguments);

            this.WriteSemicolon();
        }

        public void EmitCall(Action<ExpressionBuilder> target, string method, params Action<ExpressionBuilder>[] arguments)
        {
            this.GetExpressionBuilder().EmitCall(target, method, arguments);

            this.WriteSemicolon();
        }

        public void EmitForLoop(Action<CodeBlockBuilder> initialiser, Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> afterthought, Action<CodeBlockBuilder> loopBlock)
        {
            this.writer.Write("for(");
            this.writer.WriteCodeBlock(initialiser, false, true);
            this.writer.Write("; ");
            condition(this.GetExpressionBuilder());
            this.writer.Write("; ");
            this.writer.WriteCodeBlock(afterthought, false, true);
            this.writer.WriteLine(")");
            this.writer.WriteCodeBlock(loopBlock);
        }

        public void EmitIfBlock(Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> ifBlock)
        {
            this.writer.Write("if (");
            condition(this.GetExpressionBuilder());
            this.writer.WriteLine(")");
            using (var ifBlockBuilder = new CodeBlockBuilder(this.writer.GetSubWriter()))
            {
                ifBlock(ifBlockBuilder);
            }
        }

        public void EmitIfBlock(Action<ExpressionBuilder> condition, Action<CodeBlockBuilder> ifBlock, Action<CodeBlockBuilder> elseBlock)
        {
            this.EmitIfBlock(condition, ifBlock);

            this.writer.WriteLine("else");
            using (var elseBlockBuilder = new CodeBlockBuilder(this.writer.GetSubWriter()))
            {
                elseBlock(elseBlockBuilder);
            }
        }

        public void EmitUnsafeBlock(Action<CodeBlockBuilder> unsafeBlock)
        {
            this.writer.WriteLine("unsafe");
            using (var unsafeBlockBuilder = new CodeBlockBuilder(this.writer.GetSubWriter()))
            {
                unsafeBlock(unsafeBlockBuilder);
            }
        }

        public void EmitTry(Action<CodeBlockBuilder> tryBlock, Action<CodeBlockBuilder> finallyBlock)
        {
            this.writer.WriteLine("try");
            using (var blockBuilder = new CodeBlockBuilder(this.writer.GetSubWriter()))
            {
                tryBlock(blockBuilder);
            }
            this.writer.WriteLine("finally");
            using (var blockBuilder = new CodeBlockBuilder(this.writer.GetSubWriter()))
            {
                finallyBlock(blockBuilder);
            }
        }

        public void EmitSwitchBlock(Action<ExpressionBuilder> target, Action<SwitchCaseBuilder> caseBuilder)
        {
            this.writer.Write("switch (");
            target(this.GetExpressionBuilder());
            this.writer.WriteLine(")");
            using (var switchBlockBuilder = new SwitchCaseBuilder(this.writer.GetSubWriter()))
            {
                caseBuilder(switchBlockBuilder);
            }
        }

        private void WriteSemicolon()
        {
            if (this.writeSemicolons)
            {
                this.writer.WriteLine(";");
            }
        }

        private ExpressionBuilder GetExpressionBuilder()
        {
            return new ExpressionBuilder(this.writer.GetSubWriter());
        }
    }
}