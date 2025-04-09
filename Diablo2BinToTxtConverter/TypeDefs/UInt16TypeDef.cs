namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal sealed record UInt16TypeDef(string Column, object? NullValue = null) : ITypeDef
    {
        public Type Type { get; } = typeof(ushort);
        public object? NullValue { get; } = NullValue;
    }
}