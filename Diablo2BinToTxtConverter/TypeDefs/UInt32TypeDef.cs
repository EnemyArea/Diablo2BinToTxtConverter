namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal sealed record UInt32TypeDef(string Column, object? NullValue = null) : ITypeDef
    {
        public Type Type { get; } = typeof(uint);
    }
}