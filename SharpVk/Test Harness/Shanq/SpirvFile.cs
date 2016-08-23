using SharpVk.Spirv;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SharpVk.Shanq
{
    public class SpirvFile
    {
        private int nextResultId = 1;

        private Dictionary<int, List<StatementEntry>> entries = new Dictionary<int, List<StatementEntry>>();

        public ResultId GetNextResultId()
        {
            return nextResultId++;
        }

        public void AddHeaderStatement(Op op, params object[] operands)
        {
            this.AddHeaderStatement(null, op, operands);
        }

        public void AddHeaderStatement(ResultId? resultId, Op op, params object[] operands)
        {
            this.AddHeaderStatement(resultId, new SpirvStatement(op, operands));
        }

        public void AddHeaderStatement(ResultId? resultId, SpirvStatement statement)
        {
            this.GetEntryList(0).Add(new StatementEntry
            {
                ResultId = resultId,
                Statement = statement
            });
        }

        public void AddGlobalStatement(Op op, params object[] operands)
        {
            this.AddGlobalStatement(null, op, operands);
        }

        public void AddGlobalStatement(ResultId? resultId, Op op, params object[] operands)
        {
            this.AddGlobalStatement(resultId, new SpirvStatement(op, operands));
        }

        public void AddGlobalStatement(ResultId? resultId, SpirvStatement statement)
        {
            this.GetEntryList(1).Add(new StatementEntry
            {
                ResultId = resultId,
                Statement = statement
            });
        }

        public void AddFunctionStatement(Op op, params object[] operands)
        {
            this.AddFunctionStatement(null, op, operands);
        }

        public void AddFunctionStatement(ResultId? resultId, Op op, params object[] operands)
        {
            this.AddFunctionStatement(resultId, new SpirvStatement(op, operands));
        }

        public void AddFunctionStatement(ResultId? resultId, SpirvStatement statement)
        {
            this.GetEntryList(2).Add(new StatementEntry
            {
                ResultId = resultId,
                Statement = statement
            });
        }

        private List<StatementEntry> GetEntryList(int priority)
        {
            List<StatementEntry> result;

            if (!this.entries.TryGetValue(priority, out result))
            {
                result = new List<StatementEntry>();

                this.entries.Add(priority, result);
            }

            return result;
        }

        public IEnumerable<StatementEntry> Entries
        {
            get
            {
                return this.entries.OrderBy(x => x.Key).SelectMany(x => x.Value);
            }
        }

        public struct StatementEntry
        {
            public ResultId? ResultId;
            public SpirvStatement Statement;
        }
    }
}
