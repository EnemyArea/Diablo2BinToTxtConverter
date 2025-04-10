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
            return new Dictionary<string, string> { { "shrines", @"data\local\lng\strings\shrines.json" } };
        }

        public IEnumerable<ITypeDef> GetTypeDefinitions()
        {
            return
            [
                new UnusedTypeDef("Name"),
                new UnusedTypeDef("*Shrine Type"),
                new UnusedTypeDef("*Effect"),
                new Int32TypeDef("Code"),
                new Int32TypeDef("Arg0"),
                new Int32TypeDef("Arg1"),
                new Int32TypeDef("Duration in frames"),
                new Int16TypeDef("reset time in minutes"),
                new UnusedTypeDef("rarity"),
                new KeyedTypeDef("StringName", [
                    "shrines"
                ], typeof(ushort), "dummy"),
                new KeyedTypeDef("StringPhrase", [
                    "shrines"
                ], typeof(ushort), "dummy"),
                new Int16TypeDef("effectclass"),
                new Int32TypeDef("LevelMin")
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