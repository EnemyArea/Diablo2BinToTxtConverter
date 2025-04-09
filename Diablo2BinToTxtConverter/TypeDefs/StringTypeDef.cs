namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal sealed record StringTypeDef(string Column, int Length, object? NullValue = null) : ITypeDef
    {
        public Type Type { get; } = typeof(string);
    }
}