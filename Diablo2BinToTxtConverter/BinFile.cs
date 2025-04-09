using Diablo2BinToTxtConverter.TypeDefs;

namespace Diablo2BinToTxtConverter
{
    internal sealed class BinFile(string rootPath, IBinFileDefinition binFileDefinition)
    {
        public string RootPath { get; } = rootPath;

        public string FilePath { get; } =
            Path.Combine(rootPath, @"data\global\excel", binFileDefinition.GetBinFilePath());

        public IDictionary<string, string> KeyFilePaths { get; } = binFileDefinition.GetKeyFilePaths();
        public IEnumerable<ITypeDef> TypeDef { get; } = binFileDefinition.GetTypeDefinitions();
        public IEnumerable<string> Columns { get; } = binFileDefinition.GetColumnDefinitions();
    }
}