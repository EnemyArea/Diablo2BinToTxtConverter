﻿namespace Diablo2BinToTxtConverter.TypeDefs
{
    internal sealed record Int8TypeDef(string Column, object? NullValue = null) : ITypeDef
    {
        public Type Type { get; } = typeof(byte);
    }
}