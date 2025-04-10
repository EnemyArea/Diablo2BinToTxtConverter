using Diablo2BinToTxtConverter.BinFileDefinitions;

namespace Diablo2BinToTxtConverter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            BinFileParser binFileParser = new();

            string rootPath = @"C:\Users\ies_c\Downloads\cascview_en\Work\data";

            // {
            //     ParsedBinFile parsedBinFile = binFileParser.ParseFile(new BinFile(rootPath, new Shrines()));
            //     parsedBinFile.ExportFile();
            //
            //     Console.WriteLine(parsedBinFile.ToString());
            // }

            // {
            //     ParsedBinFile parsedBinFile = binFileParser.ParseFile(new BinFile(rootPath, new Hireling()));
            //     parsedBinFile.ExportFile();
            //
            //     Console.WriteLine(parsedBinFile.ToString());
            // }

            {
                ParsedBinFile parsedBinFile = binFileParser.ParseFile(new BinFile(rootPath, new Skills()));
                parsedBinFile.ExportFile();

                Console.WriteLine(parsedBinFile.ToString());
            }
        }
    }
}