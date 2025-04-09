using Diablo2BinToTxtConverter.TypeDefs;

namespace Diablo2BinToTxtConverter.BinFileDefinitions
{
    internal sealed class Hireling : IBinFileDefinition
    {
        public string GetBinFilePath()
        {
            return "hireling.bin";
        }

        public IDictionary<string, string> GetKeyFilePaths()
        {
            return new Dictionary<string, string>
            {
                { "ui", @"data\local\lng\strings\ui.json" }, { "skills", @"data\local\lng\strings\skills.json" }
            };
        }

        public IEnumerable<ITypeDef> GetTypeDefinitions()
        {
            // 00 00 00 00 00 00 00 00 0F 01 00 00 01 00 00 00 01 00 00 00 96 00 00 00 64 00 00 00 03 00 00 00 64 00 00 00 2D 00 00 00 08 00 00 00 0F 00 00 00 06 00 00 00 23 00 00 00 0A 00 00 00 2D 00 00 00 10 00 00 00 0A 00 00 00 0A 00 00 00 01 00 00 00 03 00 00 00 02 00 00 00 00 00 00 00 08 00 00 00 00 00 00 00 08 00 00 00 00 00 00 00 08 00 00 00 00 00 00 00 08 00 00 00 4B 00 00 00 05 00 00 00 0F 00 00 00 02 00 00 00 50 C3 00 00 00 00 00 00 08 00 00 00 07 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 0A 00 00 00 19 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 08 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 04 04 00 00 00 00 01 01 00 00 00 00 0A 0A 00 00 00 00 2B 0D 6D 65 72 63 30 31 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 6D 65 72 63 34 31 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00
            return
            [
                new UnusedTypeDef("Hireling"),
                new UnusedTypeDef("*SubType"),

                new UInt32TypeDef("Version"), // 00 00 00 00
                new UInt32TypeDef("Id"), // 00 00 00 00
                new UInt32TypeDef("Class"), // 0F 01 00 00
                new UInt32TypeDef("Act"), // 01 00 00 00
                new UInt32TypeDef("Difficulty"), // 01 00 00 00

                new UInt32TypeDef("Seller"), // 96 00 00 00
                new UInt32TypeDef("Gold"), // 64 00 00 00
                new UInt32TypeDef("Level"), // 03 00 00 00
                new UInt32TypeDef("Exp/Lvl"), // 64 00 00 00
                new UInt32TypeDef("HP"), // 2D 00 00 00
                new UInt32TypeDef("HP/Lvl"), // 08 00 00 00
                new UInt32TypeDef("Defense"), // 0F 00 00 00
                new UInt32TypeDef("Def/Lvl"), // 06 00 00 00
                new UInt32TypeDef("Str"), // 23 00 00 00
                new UInt32TypeDef("Str/Lvl"), // 0A 00 00 00
                new UInt32TypeDef("Dex"), // 2D 00 00 00
                new UInt32TypeDef("Dex/Lvl"), // 10 00 00 00
                new UInt32TypeDef("AR"), // 0A 00 00 00
                new UInt32TypeDef("AR/Lvl"), // 0A 00 00 00
                new UInt32TypeDef("Dmg-Min"), // 01 00 00 00
                new UInt32TypeDef("Dmg-Max"), // 03 00 00 00
                new UInt32TypeDef("Dmg/Lvl"), // 02 00 00 00
                new UInt32TypeDef("ResistFire"), // 00 00 00 00
                new UInt32TypeDef("ResistFire/Lvl"), // 08 00 00 00
                new UInt32TypeDef("ResistCold"), // 00 00 00 00
                new UInt32TypeDef("ResistCold/Lvl"), // 08 00 00 00
                new UInt32TypeDef("ResistLightning"), // 00 00 00 00
                new UInt32TypeDef("ResistLightning/Lvl"), // 08 00 00 00
                new UInt32TypeDef("ResistPoison"), // 00 00 00 00
                new UInt32TypeDef("ResistPoison/Lvl"), // 08 00 00 00

                new UInt32TypeDef("DefaultChance"), // 4B 00 00 00

                new UInt32TypeDef("HiringMaxLevelDifference"), // 05 00 00 00 = 5
                new UInt32TypeDef("resurrectcostmultiplier"), // 0F 00 00 00 = 15
                new UInt32TypeDef("resurrectcostdivisor"), // 02 00 00 00 = 2 
                new UInt32TypeDef("resurrectcostmax"), // 50 C3 00 00 = 50000
                new UInt32TypeDef("equivalentcharclass", 255), // 00 00 00 00 = 0 / playerclass.txt

                new UInt32TypeDef("Skill1", 4294967295), // 08 00 00 00 / skills.txt
                new UInt32TypeDef("Skill2", 4294967295), // 07 00 00 00 / skills.txt
                new UInt32TypeDef("Skill3", 4294967295), // FF FF FF FF / skills.txt
                new UInt32TypeDef("Skill4", 4294967295), // FF FF FF FF / skills.txt
                new UInt32TypeDef("Skill5", 4294967295), // FF FF FF FF / skills.txt
                new UInt32TypeDef("Skill6", 4294967295), // FF FF FF FF / skills.txt

                new UInt32TypeDef("Chance1", 0), // 0A 00 00 00
                new UInt32TypeDef("Chance2", 0), // 19 00 00 00
                new UInt32TypeDef("Chance3", 0), // 00 00 00 00
                new UInt32TypeDef("Chance4", 0), // 00 00 00 00
                new UInt32TypeDef("Chance5", 0), // 00 00 00 00
                new UInt32TypeDef("Chance6", 0), // 00 00 00 00

                new UInt32TypeDef("ChancePerLvl1", 0), // 00 00 00 00
                new UInt32TypeDef("ChancePerLvl2", 0), // 08 00 00 00
                new UInt32TypeDef("ChancePerLvl3", 0), // 00 00 00 00
                new UInt32TypeDef("ChancePerLvl4", 0), // 00 00 00 00
                new UInt32TypeDef("ChancePerLvl5", 0), // 00 00 00 00
                new UInt32TypeDef("ChancePerLvl6", 0), // 00 00 00 00

                new UInt8TypeDef("Mode1", 0), // 04
                new UInt8TypeDef("Mode2", 0), // 04
                new UInt8TypeDef("Mode3", 0), // 00
                new UInt8TypeDef("Mode4", 0), // 00
                new UInt8TypeDef("Mode5", 0), // 00
                new UInt8TypeDef("Mode6", 0), // 00

                new UInt8TypeDef("Level1", 0), // 01
                new UInt8TypeDef("Level2", 0), // 01
                new UInt8TypeDef("Level3", 0), // 00
                new UInt8TypeDef("Level4", 0), // 00
                new UInt8TypeDef("Level5", 0), // 00
                new UInt8TypeDef("Level6", 0), // 00

                new UInt8TypeDef("LvlPerLvl1", 0), // 0A
                new UInt8TypeDef("LvlPerLvl2", 0), // 0A
                new UInt8TypeDef("LvlPerLvl3", 0), // 00
                new UInt8TypeDef("LvlPerLvl4", 0), // 00
                new UInt8TypeDef("LvlPerLvl5", 0), // 00
                new UInt8TypeDef("LvlPerLvl6", 0), // 00

                new KeyedTypeDef("HireDesc", [
                    "skills",
                    "ui"
                ], typeof(ushort), "dummy"), // 00 00 00 00

                new StringTypeDef(
                    "NameFirst",
                    3 * 16), // 6D 65 72 63 30 31 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00
                new StringTypeDef(
                    "NameLast",
                    3 * 16), // 6D 65 72 63 34 31 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00

                new UInt32TypeDef("Unknown") // 00 00 00 00
            ];
        }

        public IEnumerable<string> GetColumnDefinitions()
        {
            return
            [
                "Hireling",
                "*SubType",
                "Version",
                "Id",
                "Class",
                "Act",
                "Difficulty",
                "Level",
                "Seller",
                "NameFirst",
                "NameLast",
                "Gold",
                "Exp/Lvl",
                "HP",
                "HP/Lvl",
                "Defense",
                "Def/Lvl",
                "Str",
                "Str/Lvl",
                "Dex",
                "Dex/Lvl",
                "AR",
                "AR/Lvl",
                "Dmg-Min",
                "Dmg-Max",
                "Dmg/Lvl",
                "ResistFire",
                "ResistFire/Lvl",
                "ResistCold",
                "ResistCold/Lvl",
                "ResistLightning",
                "ResistLightning/Lvl",
                "ResistPoison",
                "ResistPoison/Lvl",
                "HireDesc",
                "DefaultChance",
                "Skill1",
                "Mode1",
                "Chance1",
                "ChancePerLvl1",
                "Level1",
                "LvlPerLvl1",
                "Skill2",
                "Mode2",
                "Chance2",
                "ChancePerLvl2",
                "Level2",
                "LvlPerLvl2",
                "Skill3",
                "Mode3",
                "Chance3",
                "ChancePerLvl3",
                "Level3",
                "LvlPerLvl3",
                "Skill4",
                "Mode4",
                "Chance4",
                "ChancePerLvl4",
                "Level4",
                "LvlPerLvl4",
                "Skill5",
                "Mode5",
                "Chance5",
                "ChancePerLvl5",
                "Level5",
                "LvlPerLvl5",
                "Skill6",
                "Mode6",
                "Chance6",
                "ChancePerLvl6",
                "Level6",
                "LvlPerLvl6",
                "HiringMaxLevelDifference",
                "resurrectcostmultiplier",
                "resurrectcostdivisor",
                "resurrectcostmax",
                "equivalentcharclass"
            ];
        }
    }
}