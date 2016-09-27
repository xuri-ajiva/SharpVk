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
                this.EmitParagraph(summary.Single());
            }
            else
            {
                foreach (var paragraph in summary)
                {
                    this.writer.WriteLine("/// <para>");
                    this.EmitParagraph(paragraph);
                    this.writer.WriteLine("/// </para>");
                }
            }
            this.writer.WriteLine("/// </summary>");
        }

        private void EmitParagraph(string paragraph)
        {
            char previousChar = ' ';
            var charList = new List<char>();

            foreach(char character in paragraph)
            {
                if(!char.IsWhiteSpace(character) || !char.IsWhiteSpace(previousChar))
                {
                    charList.Add(character);
                }

                previousChar = character;
            }

            var charArray = charList.ToArray();

            int offset = 0;
            int count = 0;
            int lastSafeCount = 0;

            int availableCharacters = 80 - (4 + this.writer.IndentCharacters);

            while (offset + count < charArray.Length)
            {
                while (offset + count < charArray.Length && !char.IsWhiteSpace(charArray[offset + count]))
                {
                    count++;
                }

                if (count < availableCharacters)
                {
                    lastSafeCount = count;

                    count++;
                }
                else
                {
                    int displayCount = count;

                    if (lastSafeCount > 0)
                    {
                        displayCount = lastSafeCount;
                    }

                    this.writer.Write("/// ");
                    this.writer.WriteLine(charArray, offset, displayCount);

                    offset += displayCount + 1;
                    count -= displayCount;
                    lastSafeCount = 0;
                }

                if (offset + count >= charArray.Length && offset < charArray.Length)
                {
                    this.writer.Write("/// ");
                    this.writer.WriteLine(charArray, offset, charArray.Length - offset);
                }
            }
        }
    }
}