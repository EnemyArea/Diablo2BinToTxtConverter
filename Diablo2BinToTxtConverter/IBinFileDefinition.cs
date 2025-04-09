using Diablo2BinToTxtConverter.TypeDefs;

namespace Diablo2BinToTxtConverter
{
    internal interface IBinFileDefinition
    {
        string GetBinFilePath();
        IDictionary<string, string> GetKeyFilePaths();
        IEnumerable<ITypeDef> GetTypeDefinitions();
        IEnumerable<string> GetColumnDefinitions();
    }
}