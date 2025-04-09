namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal sealed record KeyedTypeDef(
        string Column,
        IEnumerable<string> KeyFilePaths,
        Type Type,
        object? NullValue = null)
        : ITypeDef;
}