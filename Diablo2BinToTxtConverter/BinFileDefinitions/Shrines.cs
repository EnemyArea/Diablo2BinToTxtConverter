using Diablo2BinToTxtConverter.TypeDefs;

namespace Diablo2BinToTxtConverter.BinFileDefinitions
{
    internal sealed class Shrines : IBinFileDefinition
    {
        public string GetBinFilePath()
        {
            return "shrines.bin";
        }


        public IDictionary<string, string> GetKeyFilePaths()
        {
            return new Dictionary<string, string> { { "shrines", "data\\local\\lng\\strings\\shrines.json" } };
        }

        public IEnumerable<ITypeDef> GetTypeDefinitions()
        {
            return
            [
                new UnusedTypeDef("Name"),
                new UnusedTypeDef("*Shrine Type"),
                new UnusedTypeDef("*Effect"),
                new UInt32TypeDef("Code"),
                new UInt32TypeDef("Arg0"),
                new UInt32TypeDef("Arg1"),
                new UInt32TypeDef("Duration in frames"),
                new UInt16TypeDef("reset time in minutes"),
                new UnusedTypeDef("rarity"),
                new UInt16TypeDef("StringName"),
                new UInt16TypeDef("StringPhrase"),
                new UInt16TypeDef("effectclass"),
                new UInt32TypeDef("LevelMin")
            ];
        }

        public IEnumerable<string> GetColumnDefinitions()
        {
            return
            [
                "Name",
                "*Shrine Type",
                "*Effect",
                "Code",
                "Arg0",
                "Arg1",
                "Duration in frames",
                "reset time in minutes",
                "rarity",
                "StringName",
                "StringPhrase",
                "effectclass",
                "LevelMin"
            ];
        }
    }
}