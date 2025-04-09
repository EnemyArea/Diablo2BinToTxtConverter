namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal sealed record UnusedTypeDef(string Column, object? NullValue = null) : ITypeDef
    {
        public Type Type { get; } = typeof(object);
        public object? NullValue { get; } = NullValue;
    }
}