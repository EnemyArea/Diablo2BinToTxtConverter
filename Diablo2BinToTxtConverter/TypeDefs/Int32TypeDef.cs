namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal sealed record Int32TypeDef(string Column, object? NullValue = null) : ITypeDef
    {
        public Type Type { get; } = typeof(int);
    }
}