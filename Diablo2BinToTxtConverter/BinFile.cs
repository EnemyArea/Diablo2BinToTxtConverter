using Diablo2BinToTxtConverter.TypeDefs;

namespace Diablo2BinToTxtConverter
{
    internal sealed record BinFile
    {
        public BinFile(string rootPath, IBinFileDefinition binFileDefinition)
        {
            RootPath = rootPath;
            FilePath = Path.Combine(rootPath, "data\\global\\excel", binFileDefinition.GetBinFilePath());
            KeyFilePaths = binFileDefinition.GetKeyFilePaths();
            TypeDef = binFileDefinition.GetTypeDefinitions();
            Columns = binFileDefinition.GetColumnDefinitions();
        }

        public string RootPath { get; }

        public string FilePath { get; }
        public IDictionary<string, string> KeyFilePaths { get; }
        public IEnumerable<ITypeDef> TypeDef { get; }
        public IEnumerable<string> Columns { get; }
    }
}