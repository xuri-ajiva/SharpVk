using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Emit
{
    public class DocBuilder
    {
        private IndentedTextWriter writer;

        public DocBuilder(IndentedTextWriter writer, IEnumerable<string> summary)
        {
            this.writer = writer;

            this.writer.WriteLine("/// <summary>");
            if (summary == null || !summary.Any())
            {
                this.writer.WriteLine("/// ");
            }
            else if (summary.Count() == 1)
            {
                this.writer.WriteLine("/// " + summary.Single());
            }
            else
            {
                foreach (var paragraph in summary)
                {
                    this.writer.WriteLine("/// <para>");
                    this.writer.WriteLine("/// " + paragraph);
                    this.writer.WriteLine("/// </para>");
                }
            }
            this.writer.WriteLine("/// </summary>");
        }
    }
}