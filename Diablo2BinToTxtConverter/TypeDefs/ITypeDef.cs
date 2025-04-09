namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal interface ITypeDef
    {
        string Column { get; }
        Type Type { get; }
        object? NullValue { get; }
    }
}