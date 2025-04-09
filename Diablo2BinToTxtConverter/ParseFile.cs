using System.Text;

namespace Diablo2BinToTxtConverter
{
    internal sealed class ParseFile(BinFile binFile, IEnumerable<ParsedLine> parsedLines)
    {
        private string ColumnsToString()
        {
            StringBuilder sb = new();
            foreach (string? column in binFile.Columns)
            {
                sb.Append($"{column}\t");
            }

            return sb.ToString();
        }

        private string ValuesToString(ParsedLine parsedLine)
        {
            StringBuilder sb = new();
            foreach (string? column in binFile.Columns)
            {
                ParsedLine.ValuePair value = parsedLine.Values.First(x => x.Key == column);
                sb.Append($"{value.Value}\t");
            }

            return sb.ToString();
        }

        private string LinesToString()
        {
            StringBuilder sb = new();

            foreach (ParsedLine? line in parsedLines)
            {
                sb.AppendLine(ValuesToString(line));
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(ColumnsToString());
            sb.AppendLine(LinesToString());

            return sb.ToString();
        }

        public void ExportFile()
        {
            File.WriteAllText($"{Path.GetFileNameWithoutExtension(binFile.FilePath)}.txt", ToString());
        }
    }
}