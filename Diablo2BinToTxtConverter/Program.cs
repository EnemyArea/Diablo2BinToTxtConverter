using Diablo2BinToTxtConverter.BinFileDefinitions;

namespace Diablo2BinToTxtConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BinFileParser binFileParser = new();

            string rootPath = "C:\\Users\\ies_c\\Downloads\\cascview_en\\Work\\data";

            // {
            //     ParseFile parseFile = binFileParser.ParseFile(new BinFile("TestFiles", new Shrines()));
            //     Console.WriteLine(parseFile.ToString());
            //     File.WriteAllText("shrines.txt", parseFile.ToString());
            // }

            {
                ParseFile parseFile = binFileParser.ParseFile(new BinFile(rootPath, new Hireling()));
                parseFile.ExportFile();

                Console.WriteLine(parseFile.ToString());
            }
        }
    }
}