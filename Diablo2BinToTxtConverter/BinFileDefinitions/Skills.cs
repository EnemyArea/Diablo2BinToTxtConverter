using Diablo2BinToTxtConverter.TypeDefs;

namespace Diablo2BinToTxtConverter.BinFileDefinitions
{
    internal sealed class Skills : IBinFileDefinition
    {
        public string GetBinFilePath()
        {
            return "skills.bin";
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
            int intIndex = 0;
            // (Magic Arrow) 06 00 4D 61 67 69 63 20 41 72 72 6F 77 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 04 0B C0 80 02 00 00 00 00 00 00 07 0E 07 00 02 00 00 00 2F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF 00 00 1B 00 FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 00 00 FF FF 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF 1B 00 FF FF FF FF FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF 00 00 FF FF FF FF 14 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 01 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF 00 00 00 00 05 00 0C 00 FF FF 00 00 00 00 00 00 FF FF FF FF FF FF FF FF 06 00 00 00 0A 00 00 00 09 00 00 00 FF FF FF FF 08 80 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 FF FF FF FF FF FF 00 00 00 00 00 01 00 00 E8 03 00 00 00 00 00 00 00 00 00 00 07 00
            // (Whirlwind) 97 00 57 68 69 72 6C 77 69 6E 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 14 16 50 80 00 00 00 04 00 00 00 12 0E 07 0A 00 00 00 00 2E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 26 00 4C 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF AE 00 FF FF FF FF FF FF FF FF 00 00 00 00 00 00 FF FF 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF 1F 00 2D 00 00 00 00 00 00 00 E3 09 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF 00 00 FF FF FF FF 14 00 00 00 00 00 00 00 00 00 00 00 3C 0F 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 1E 00 00 00 05 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 FF FF FF FF 1E 00 00 00 00 00 00 00 00 00 8F 00 90 00 FF FF 00 00 01 00 07 00 19 00 01 00 00 00 03 00 00 00 FF FF FF FF FF FF FF FF 97 00 00 00 32 00 00 00 05 00 00 00 FF FF FF FF 08 80 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 FF FF FF FF FF FF 00 00 00 00 80 03 00 00 00 FA 00 00 00 00 01 00 01 00 00 00
            return
            [
                new Int16TypeDef("*Id"), // 06 00
                new StringTypeDef("skill",
                    34), // 4D 61 67 69 63 20 41 72 72 6F 77 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00

                new Int8TypeDef("unknown-1"), // 00

                new Int8TypeDef("unknown-2"), // 04 // anim, seqtrans, monanim, seqnum = reihenfolge verdreht
                new Int8TypeDef("unknown-3"), // 0B
                new Int8TypeDef("unknown-4"), // C0
                new Int8TypeDef("unknown-5"), // 80

                new Int8TypeDef("unknown-6"), // 02 00 00 00
                new Int8TypeDef("unknown-7"), //  00
                new Int8TypeDef("unknown-8"), //  00

                new Int8TypeDef("charclass"), //  00

                new Int8TypeDef("unknown-0"), // 00
                new Int8TypeDef("unknown-10"), // 00
                new Int8TypeDef("unknown-11"), // 00
                new Int8TypeDef("unknown-12"), // 07
                new Int8TypeDef("unknown-13"), // 0E
                new Int8TypeDef("unknown-14"), // 07
                new Int8TypeDef("unknown-15"), // 00

                new Int32TypeDef("unknown-16"), // 02 00 00 00
                new Int32TypeDef("unknown-17"), // 2F 00 00 00
                new Int32TypeDef("unknown-18"), // 00 00 00 00
                new Int32TypeDef("unknown-19"), // 00 00 00 00

                new Int32TypeDef("unknown-20"), // 00 00 00 00
                new Int32TypeDef("unknown-21"), // 00 00 00 00
                new Int32TypeDef("unknown-22"), // 00 00 00 00
                new Int32TypeDef("unknown-23"), // 00 00 00 00

                new Int32TypeDef("unknown-24"), // 00 00 00 00
                new Int32TypeDef("unknown-25"), // FF FF FF FF
                new Int32TypeDef("unknown-26"), // FF FF FF FF
                new Int32TypeDef("unknown-27"), // FF FF FF FF

                new Int16TypeDef("unknown-28"), // 00 00
                new Int16TypeDef("cltmissile"), // 1B 00
                new Int32TypeDef("unknown-29"), // FF FF FF FF
                new Int32TypeDef("unknown-30"), // FF FF FF FF
                new Int32TypeDef("unknown-31"), // 00 00 00 00

                new Int32TypeDef("unknown-32"), // FF FF FF FF
                new Int32TypeDef("unknown-33"), // FF FF FF FF
                new Int32TypeDef("unknown-34"), // FF FF FF FF
                new Int32TypeDef("unknown-35"), // FF FF FF FF

                new Int32TypeDef("unknown-36"), // FF FF FF FF
                new Int32TypeDef("unknown-37"), // FF FF FF FF
                new Int32TypeDef("unknown-38"), // FF FF FF FF
                new Int32TypeDef("unknown-39"), // FF FF FF FF

                new Int32TypeDef("unknown-40"), // FF FF FF FF
                new Int32TypeDef("unknown-41"), // FF FF FF FF
                new Int32TypeDef("unknown-42"), // FF FF FF FF
                new Int32TypeDef("unknown-43"), // FF FF FF FF

                new Int32TypeDef("unknown-44"), // FF FF FF FF
                new Int16TypeDef("unknown-45"), // FF FF
                new Int16TypeDef("auraeventfunc1", 0), // 00 00
                new Int16TypeDef("unknown-47"), // 00 00
                new Int16TypeDef("unknown-48"), // 00 00
                new Int16TypeDef("unknown-49"), // FF FF
                new Int16TypeDef("unknown-50"), // 00 00

                new Int16TypeDef("unknown-51"), // 00 00
                new Int16TypeDef("unknown-52"), // FF FF
                new Int32TypeDef("unknown-53"), // FF FF FF FF
                new Int32TypeDef("unknown-54"), // FF FF FF FF
                new Int32TypeDef("unknown-55"), // FF FF FF FF

                new Int32TypeDef("unknown-56"), // FF FF FF FF
                new Int32TypeDef("unknown-57"), // FF FF FF FF
                new Int32TypeDef("unknown-58"), // FF FF FF FF
                new Int16TypeDef("unknown-59"), // FF FF
                new Int16TypeDef("unknown-60"), // 00 00

                new Int32TypeDef("unknown-61"), // FF FF FF FF
                new Int32TypeDef("unknown-62"), // FF FF FF FF
                new Int32TypeDef("unknown-63"), // FF FF FF FF
                new Int32TypeDef("unknown-64"), // FF FF FF FF

                new Int32TypeDef("unknown-65"), // FF FF FF FF
                new Int32TypeDef("unknown-66"), // FF FF FF FF
                new Int32TypeDef("unknown-67"), // FF FF FF FF
                new Int32TypeDef("unknown-68"), // FF FF FF FF

                new Int32TypeDef("unknown-69"), // FF FF FF FF
                new Int32TypeDef("unknown-70"), // FF FF FF FF
                new Int32TypeDef("unknown-71"), // FF FF FF FF
                new Int32TypeDef("unknown-72"), // FF FF FF FF

                new Int32TypeDef("unknown-73"), // FF FF FF FF
                new Int32TypeDef("unknown-74"), // FF FF FF FF
                new Int32TypeDef("unknown-75"), // FF FF FF FF
                new Int32TypeDef("unknown-76"), // FF FF FF FF

                new Int32TypeDef("unknown-77"), // FF FF FF FF
                new Int32TypeDef("unknown-78"), // FF FF FF FF
                new Int16TypeDef("unknown-79"), // FF FF
                new Int16TypeDef("unknown-80"), // 00 00
                new Int32TypeDef("unknown-81"), // FF FF FF FF

                new Int32TypeDef("unknown-82"), // FF FF FF FF
                new Int32TypeDef("unknown-83"), // FF FF FF FF
                new Int32TypeDef("unknown-84"), // FF FF FF FF
                new Int32TypeDef("unknown-85"), // FF FF FF FF

                new Int16TypeDef("unknown-86"), // 00 00
                new Int16TypeDef("unknown-87"), // FF FF
                new Int16TypeDef("unknown-88"), // 1B 00
                new Int16TypeDef("unknown-89"), // FF FF
                new Int32TypeDef("unknown-90"), // FF FF FF FF
                new Int16TypeDef("unknown-91"), // FF FF
                new Int16TypeDef("unknown-92"), // 00 00

                new Int32TypeDef("cltdofunc"), // 00 00 00 00

                new Int32TypeDef("unknown-93"), // 00 00 00 00

                new Int32TypeDef("stsound"), // 00 00 00 00
                new Int32TypeDef("dosound"), // 00 00 00 00

                new Int16TypeDef("unknown-94"), // 00 00
                new Int16TypeDef("unknown-95"), // FF FF
                new Int16TypeDef("unknown-96"), // FF FF
                new Int16TypeDef("unknown-97"), // 00 00
                new Int16TypeDef("unknown-98"), // FF FF
                new Int16TypeDef("unknown-99"), // 00 00
                new Int32TypeDef("unknown-100"), // FF FF FF FF

                new Int32TypeDef("unknown-101"), // FF FF FF FF
                new Int32TypeDef("unknown-102"), // FF FF FF FF
                new Int32TypeDef("unknown-103"), // FF FF FF FF
                new Int32TypeDef("unknown-104"), // 00 00 00 00

                new Int16TypeDef("unknown-105"), // FF FF
                new Int16TypeDef("unknown-106"), // 00 00
                new Int32TypeDef("unknown-107"), // FF FF FF FF
                new Int32TypeDef("maxlvl"), // 14 00 00 00
                new Int32TypeDef("unknown-108"), // 00 00 00 00

                new Int32TypeDef("unknown-109"), // 00 00 00 00
                new Int32TypeDef("unknown-110"), // FF FF FF FF
                new Int32TypeDef("unknown-111"), // FF FF FF FF
                new Int32TypeDef("unknown-112"), // FF FF FF FF

                new Int32TypeDef("unknown-113"), // FF FF FF FF
                new Int32TypeDef("unknown-114"), // FF FF FF FF
                new Int32TypeDef("unknown-115"), // FF FF FF FF
                new Int32TypeDef("unknown-116"), // 00 00 00 00

                new Int32TypeDef("unknown-117"), // 00 00 00 00
                new Int32TypeDef("unknown-118"), // 00 00 00 00
                new Int32TypeDef("unknown-119"), // 00 00 00 00
                new Int32TypeDef("unknown-120"), // 00 00 00 00

                new Int32TypeDef("unknown-121"), // 00 00 00 00
                new Int32TypeDef("unknown-122"), // 00 00 00 00
                new Int32TypeDef("unknown-123"), // 00 00 00 00
                new Int32TypeDef("unknown-124"), // 00 00 00 00

                new Int32TypeDef("unknown-125"), // 00 00 00 00
                new Int32TypeDef("unknown-126"), // 00 00 00 00
                new Int32TypeDef("unknown-127"), // 00 00 00 00
                new Int32TypeDef("unknown-128"), // 00 00 00 00

                new Int32TypeDef("unknown-129"), // 00 00 00 00
                new Int32TypeDef("unknown-130"), // FF FF FF FF

                new Int32TypeDef("reqlevel"), // 01 00 00 00 ???? = 1

                new Int32TypeDef("unknown-131"), // 00 00 00 00

                new Int16TypeDef("unknown-132"), // 00 00

                new Int16TypeDef("reqskill1"), // FF FF
                new Int16TypeDef("reqskill2"), // FF FF
                new Int16TypeDef("reqskill3"), // FF FF

                new Int16TypeDef("unknown-133"), // 00 00
                new Int16TypeDef("minmana"), // 00 00

                new Int16TypeDef("manashift"), // 05 00 ???? = 5
                new Int16TypeDef("mana"), // 0C 00 ???? = 12
                new Int16TypeDef("lvlmana"), // FF FF

                new Int16TypeDef("unknown-134"), // 00 00
                new Int32TypeDef("unknown-135"), // 00 00 00 00
                new Int32TypeDef("unknown-136"), // FF FF FF FF
                new Int32TypeDef("unknown-137"), // FF FF FF FF

                new Int32TypeDef("unknown-138"), // 06 00 00 00 ???? = 6
                new Int32TypeDef("ToHit"), // 0A 00 00 00 ???? = 10 
                new Int32TypeDef("LevToHit"), // 09 00 00 00 ???? = 9
                new Int32TypeDef("unknown-139"), // FF FF FF FF

                new Int8TypeDef("HitShift"), // 08 ???? = 8
                new Int16TypeDef("SrcDam"), // 80 00 ???? = 128
                new Int8TypeDef("unknown-140"), // 00
                new Int32TypeDef("MinDam"), // 01 00 00 00
                new Int32TypeDef("MinLevDam1"), // 01 00 00 00
                new Int32TypeDef("MinLevDam2"), // 01 00 00 00

                new Int32TypeDef("MinLevDam3"), // 01 00 00 00
                new Int32TypeDef("MinLevDam4"), // 01 00 00 00
                new Int32TypeDef("MinLevDam5"), // 01 00 00 00
                new Int32TypeDef("MaxDam"), // 01 00 00 00

                new Int32TypeDef("MaxLevDam1"), // 01 00 00 00
                new Int32TypeDef("MaxLevDam2"), // 01 00 00 00
                new Int32TypeDef("MaxLevDam3"), // 01 00 00 00
                new Int32TypeDef("MaxLevDam4"), // 01 00 00 00

                new Int32TypeDef("MaxLevDam5"), // 01 00 00 00
                new Int32TypeDef("unknown-141"), // FF FF FF FF
                new Int32TypeDef("EType"), // 00 00 00 00 - elemtypes.txt indexed
                new Int32TypeDef("EMin"), // 00 00 00 00

                new Int32TypeDef("EMax"), // 00 00 00 00
                new Int32TypeDef("EMinLev1"), // 00 00 00 00
                new Int32TypeDef("EMinLev2"), // 00 00 00 00
                new Int32TypeDef("EMinLev3"), // 00 00 00 00

                new Int32TypeDef("EMinLev4"), // 00 00 00 00
                new Int32TypeDef("EMinLev5"), // 00 00 00 00
                new Int32TypeDef("EMaxLev1"), // 00 00 00 00
                new Int32TypeDef("EMaxLev2"), // 00 00 00 00

                new Int32TypeDef("EMaxLev3"), // 00 00 00 00
                new Int32TypeDef("EMaxLev4"), // 00 00 00 00
                new Int32TypeDef("EMaxLev5"), // 00 00 00 00
                new Int32TypeDef("EDmgSymPerCalc", -1), // FF FF FF FF ???? EDmgSymPerCalc

                new Int32TypeDef("ELen", 0), // 00 00 00 00
                new Int32TypeDef("ELevLen1", 0), // 00 00 00 00
                new Int32TypeDef("ELevLen2", 0), // 00 00 00 00
                new Int32TypeDef("ELevLen3", 0), // 00 00 00 00

                new Int32TypeDef("ELenSymPerCalc", -1), // FF FF FF FF
                new Int16TypeDef("unknown-148"), // 00 00
                new Int16TypeDef("unknown-149"), // FF FF
                new Int32TypeDef("unknown-150"), // FF FF FF FF
                new Int16TypeDef("aitype", 0), // 00 00
                new Int16TypeDef("aibonus", 0), // 00 00

                new Int32TypeDef("cost mult"), // 00 00 00 00
                new Int32TypeDef("cost add"), // E8 03 00 00
                new Int16TypeDef("unknown-152"), // 00 00
                new Int16TypeDef("unknown-153"), // 00 00
                new Int16TypeDef("unknown-154"), // 00 00
                new Int16TypeDef("*eol") // 00 00

                //// new UnusedTypeDef("charclass"),
                // new UnusedTypeDef("skilldesc"),
                // new UnusedTypeDef("srvstfunc"),
                // new UnusedTypeDef("srvdofunc"),
                // new UnusedTypeDef("srvstopfunc"),
                // new UnusedTypeDef("prgstack"),
                // new UnusedTypeDef("srvprgfunc1"),
                // new UnusedTypeDef("srvprgfunc2"),
                // new UnusedTypeDef("srvprgfunc3"),
                // new UnusedTypeDef("prgcalc1"),
                // new UnusedTypeDef("prgcalc2"),
                // new UnusedTypeDef("prgcalc3"),
                // new UnusedTypeDef("prgdam"),
                // new UnusedTypeDef("srvmissile"),
                // new UnusedTypeDef("decquant"),
                // new UnusedTypeDef("lob"),
                // new UnusedTypeDef("srvmissilea"),
                // new UnusedTypeDef("srvmissileb"),
                // new UnusedTypeDef("srvmissilec"),
                // new UnusedTypeDef("useServerMissilesOnRemoteClients"),
                // new UnusedTypeDef("srvoverlay"),
                // new UnusedTypeDef("aurafilter"),
                // new UnusedTypeDef("aurastate"),
                // new UnusedTypeDef("auratargetstate"),
                // new UnusedTypeDef("auralencalc"),
                // new UnusedTypeDef("aurarangecalc"),
                // new UnusedTypeDef("aurastat1"),
                // new UnusedTypeDef("aurastatcalc1"),
                // new UnusedTypeDef("aurastat2"),
                // new UnusedTypeDef("aurastatcalc2"),
                // new UnusedTypeDef("aurastat3"),
                // new UnusedTypeDef("aurastatcalc3"),
                // new UnusedTypeDef("aurastat4"),
                // new UnusedTypeDef("aurastatcalc4"),
                // new UnusedTypeDef("aurastat5"),
                // new UnusedTypeDef("aurastatcalc5"),
                // new UnusedTypeDef("aurastat6"),
                // new UnusedTypeDef("aurastatcalc6"),
                // new UnusedTypeDef("auraevent1"),
                // new UnusedTypeDef("auraeventfunc1"),
                // new UnusedTypeDef("auraevent2"),
                // new UnusedTypeDef("auraeventfunc2"),
                // new UnusedTypeDef("auraevent3"),
                // new UnusedTypeDef("auraeventfunc3"),
                // new UnusedTypeDef("passivestate"),
                // new UnusedTypeDef("passiveitype"),
                // new UnusedTypeDef("passivereqweaponcount"),
                // new UnusedTypeDef("passivestat1"),
                // new UnusedTypeDef("passivecalc1"),
                // new UnusedTypeDef("passivestat2"),
                // new UnusedTypeDef("passivecalc2"),
                // new UnusedTypeDef("passivestat3"),
                // new UnusedTypeDef("passivecalc3"),
                // new UnusedTypeDef("passivestat4"),
                // new UnusedTypeDef("passivecalc4"),
                // new UnusedTypeDef("passivestat5"),
                // new UnusedTypeDef("passivecalc5"),
                // new UnusedTypeDef("passivestat6"),
                // new UnusedTypeDef("passivecalc6"),
                // new UnusedTypeDef("passivestat7"),
                // new UnusedTypeDef("passivecalc7"),
                // new UnusedTypeDef("passivestat8"),
                // new UnusedTypeDef("passivecalc8"),
                // new UnusedTypeDef("passivestat9"),
                // new UnusedTypeDef("passivecalc9"),
                // new UnusedTypeDef("passivestat10"),
                // new UnusedTypeDef("passivecalc10"),
                // new UnusedTypeDef("passivestat11"),
                // new UnusedTypeDef("passivecalc11"),
                // new UnusedTypeDef("passivestat12"),
                // new UnusedTypeDef("passivecalc12"),
                // new UnusedTypeDef("passivestat13"),
                // new UnusedTypeDef("passivecalc13"),
                // new UnusedTypeDef("passivestat14"),
                // new UnusedTypeDef("passivecalc14"),
                // new UnusedTypeDef("summon"),
                // new UnusedTypeDef("pettype"),
                // new UnusedTypeDef("petmax"),
                // new UnusedTypeDef("summode"),
                // new UnusedTypeDef("sumskill1"),
                // new UnusedTypeDef("sumsk1calc"),
                // new UnusedTypeDef("sumskill2"),
                // new UnusedTypeDef("sumsk2calc"),
                // new UnusedTypeDef("sumskill3"),
                // new UnusedTypeDef("sumsk3calc"),
                // new UnusedTypeDef("sumskill4"),
                // new UnusedTypeDef("sumsk4calc"),
                // new UnusedTypeDef("sumskill5"),
                // new UnusedTypeDef("sumsk5calc"),
                // new UnusedTypeDef("sumumod"),
                // new UnusedTypeDef("sumoverlay"),
                // new UnusedTypeDef("stsuccessonly"),
                //// new UnusedTypeDef("stsound"),
                // new UnusedTypeDef("stsoundclass"),
                // new UnusedTypeDef("stsounddelay"),
                // new UnusedTypeDef("weaponsnd"),
                //// new UnusedTypeDef("dosound"),
                // new UnusedTypeDef("dosound a"),
                // new UnusedTypeDef("dosound b"),
                // new UnusedTypeDef("tgtoverlay"),
                // new UnusedTypeDef("tgtsound"),
                // new UnusedTypeDef("prgoverlay"),
                // new UnusedTypeDef("prgsound"),
                // new UnusedTypeDef("castoverlay"),
                // new UnusedTypeDef("cltoverlaya"),
                // new UnusedTypeDef("cltoverlayb"),
                // new UnusedTypeDef("cltstfunc"),
                //// new UnusedTypeDef("cltdofunc"),
                // new UnusedTypeDef("cltstopfunc"),
                // new UnusedTypeDef("cltprgfunc1"),
                // new UnusedTypeDef("cltprgfunc2"),
                // new UnusedTypeDef("cltprgfunc3"),
                // // new UnusedTypeDef("cltmissile"),
                // new UnusedTypeDef("cltmissilea"),
                // new UnusedTypeDef("cltmissileb"),
                // new UnusedTypeDef("cltmissilec"),
                // new UnusedTypeDef("cltmissiled"),
                // new UnusedTypeDef("cltcalc1"),
                // new UnusedTypeDef("*cltcalc1 desc"),
                // new UnusedTypeDef("cltcalc2"),
                // new UnusedTypeDef("*cltcalc2 desc"),
                // new UnusedTypeDef("cltcalc3"),
                // new UnusedTypeDef("*cltcalc3 desc"),
                // new UnusedTypeDef("warp"),
                // new UnusedTypeDef("immediate"),
                // new UnusedTypeDef("enhanceable"),
                // new UnusedTypeDef("attackrank"),
                // new UnusedTypeDef("noammo"),
                // new UnusedTypeDef("range"),
                // new UnusedTypeDef("weapsel"),
                // new UnusedTypeDef("itypea1"),
                // new UnusedTypeDef("itypea2"),
                // new UnusedTypeDef("itypea3"),
                // new UnusedTypeDef("etypea1"),
                // new UnusedTypeDef("etypea2"),
                // new UnusedTypeDef("itypeb1"),
                // new UnusedTypeDef("itypeb2"),
                // new UnusedTypeDef("itypeb3"),
                // new UnusedTypeDef("etypeb1"),
                // new UnusedTypeDef("etypeb2"),
                // new UnusedTypeDef("anim"),
                // new UnusedTypeDef("seqtrans"),
                // new UnusedTypeDef("monanim"),
                // new UnusedTypeDef("seqnum"),
                // new UnusedTypeDef("seqinput"),
                // new UnusedTypeDef("durability"),
                // new UnusedTypeDef("UseAttackRate"),
                // new UnusedTypeDef("LineOfSight"),
                // new UnusedTypeDef("TargetableOnly"),
                // new UnusedTypeDef("SearchEnemyXY"),
                // new UnusedTypeDef("SearchEnemyNear"),
                // new UnusedTypeDef("SearchOpenXY"),
                // new UnusedTypeDef("SelectProc"),
                // new UnusedTypeDef("TargetCorpse"),
                // new UnusedTypeDef("TargetPet"),
                // new UnusedTypeDef("TargetAlly"),
                // new UnusedTypeDef("TargetItem"),
                // new UnusedTypeDef("AttackNoMana"),
                // new UnusedTypeDef("TgtPlaceCheck"),
                // new UnusedTypeDef("KeepCursorStateOnKill"),
                // new UnusedTypeDef("ContinueCastUnselected"),
                // new UnusedTypeDef("ClearSelectedOnHold"),
                // new UnusedTypeDef("ItemEffect"),
                // new UnusedTypeDef("ItemCltEffect"),
                // new UnusedTypeDef("ItemTgtDo"),
                // new UnusedTypeDef("ItemTarget"),
                // new UnusedTypeDef("ItemUseRestrict"),
                // new UnusedTypeDef("ItemCheckStart"),
                // new UnusedTypeDef("ItemCltCheckStart"),
                // new UnusedTypeDef("ItemCastSound"),
                // new UnusedTypeDef("ItemCastOverlay"),
                // new UnusedTypeDef("skpoints"),
                // new UnusedTypeDef("reqlevel"),
                // // new UnusedTypeDef("maxlvl"),
                // new UnusedTypeDef("reqstr"),
                // new UnusedTypeDef("reqdex"),
                // new UnusedTypeDef("reqint"),
                // new UnusedTypeDef("reqvit"),
                // new UnusedTypeDef("reqskill1"),
                // new UnusedTypeDef("reqskill2"),
                // new UnusedTypeDef("reqskill3"),
                // new UnusedTypeDef("restrict"),
                // new UnusedTypeDef("State1"),
                // new UnusedTypeDef("State2"),
                // new UnusedTypeDef("State3"),
                // new UnusedTypeDef("localdelay"),
                // new UnusedTypeDef("globaldelay"),
                // new UnusedTypeDef("leftskill"),
                // new UnusedTypeDef("rightskill"),
                // new UnusedTypeDef("repeat"),
                // new UnusedTypeDef("alwayshit"),
                // new UnusedTypeDef("usemanaondo"),
                // new UnusedTypeDef("startmana"),
                //// new UnusedTypeDef("minmana"),
                // // new UnusedTypeDef("manashift"),
                // // new UnusedTypeDef("mana"),
                //// new UnusedTypeDef("lvlmana"),
                // new UnusedTypeDef("interrupt"),
                // new UnusedTypeDef("InTown"),
                // new UnusedTypeDef("aura"),
                // new UnusedTypeDef("periodic"),
                // new UnusedTypeDef("perdelay"),
                // new UnusedTypeDef("finishing"),
                // new UnusedTypeDef("prgchargestocast"),
                // new UnusedTypeDef("prgchargesconsumed"),
                // new UnusedTypeDef("passive"),
                // new UnusedTypeDef("progressive"),
                // new UnusedTypeDef("scroll"),
                // new UnusedTypeDef("calc1"),
                // new UnusedTypeDef("*calc1 desc"),
                // new UnusedTypeDef("calc2"),
                // new UnusedTypeDef("*calc2 desc"),
                // new UnusedTypeDef("calc3"),
                // new UnusedTypeDef("*calc3 desc"),
                // new UnusedTypeDef("calc4"),
                // new UnusedTypeDef("*calc4 desc"),
                // new UnusedTypeDef("calc5"),
                // new UnusedTypeDef("*calc5 desc"),
                // new UnusedTypeDef("calc6"),
                // new UnusedTypeDef("*calc6 desc"),
                // new UnusedTypeDef("Param1"),
                // new UnusedTypeDef("*Param1 Description"),
                // new UnusedTypeDef("Param2"),
                // new UnusedTypeDef("*Param2 Description"),
                // new UnusedTypeDef("Param3"),
                // new UnusedTypeDef("*Param3 Description"),
                // new UnusedTypeDef("Param4"),
                // new UnusedTypeDef("*Param4 Description"),
                // new UnusedTypeDef("Param5"),
                // new UnusedTypeDef("*Param5 Description"),
                // new UnusedTypeDef("Param6"),
                // new UnusedTypeDef("*Param6 Description"),
                // new UnusedTypeDef("Param7"),
                // new UnusedTypeDef("*Param7 Description"),
                // new UnusedTypeDef("Param8"),
                // new UnusedTypeDef("*Param8 Description"),
                // new UnusedTypeDef("Param9"),
                // new UnusedTypeDef("*Param9 Description"),
                // new UnusedTypeDef("Param10"),
                // new UnusedTypeDef("*Param10 Description2"),
                // new UnusedTypeDef("Param11"),
                // new UnusedTypeDef("*Param11 Description"),
                // new UnusedTypeDef("Param12"),
                // new UnusedTypeDef("*Param12 Description"),
                // new UnusedTypeDef("InGame"),
                // // new UnusedTypeDef("ToHit"),
                // // new UnusedTypeDef("LevToHit"),
                // new UnusedTypeDef("ToHitCalc"),
                // new UnusedTypeDef("ResultFlags"),
                // new UnusedTypeDef("HitFlags"),
                // new UnusedTypeDef("HitClass"),
                // new UnusedTypeDef("Kick"),
                // // new UnusedTypeDef("HitShift"),
                // // new UnusedTypeDef("SrcDam"),
                // new UnusedTypeDef("MinDam"),
                // new UnusedTypeDef("MinLevDam1"),
                // new UnusedTypeDef("MinLevDam2"),
                // new UnusedTypeDef("MinLevDam3"),
                // new UnusedTypeDef("MinLevDam4"),
                // new UnusedTypeDef("MinLevDam5"),
                // new UnusedTypeDef("MaxDam"),
                // new UnusedTypeDef("MaxLevDam1"),
                // new UnusedTypeDef("MaxLevDam2"),
                // new UnusedTypeDef("MaxLevDam3"),
                // new UnusedTypeDef("MaxLevDam4"),
                // new UnusedTypeDef("MaxLevDam5"),
                // new UnusedTypeDef("DmgSymPerCalc"),
                //// new UnusedTypeDef("EType"),
                //// new UnusedTypeDef("EMin"),
                //// new UnusedTypeDef("EMinLev1"),
                //// new UnusedTypeDef("EMinLev2"),
                //// new UnusedTypeDef("EMinLev3"),
                //// new UnusedTypeDef("EMinLev4"),
                //// new UnusedTypeDef("EMinLev5"),
                //// new UnusedTypeDef("EMax"),
                //// new UnusedTypeDef("EMaxLev1"),
                //// new UnusedTypeDef("EMaxLev2"),
                //// new UnusedTypeDef("EMaxLev3"),
                //// new UnusedTypeDef("EMaxLev4"),
                //// new UnusedTypeDef("EMaxLev5"),
                // new UnusedTypeDef("EDmgSymPerCalc"),
                // new UnusedTypeDef("ELen"),
                // new UnusedTypeDef("ELevLen1"),
                // new UnusedTypeDef("ELevLen2"),
                // new UnusedTypeDef("ELevLen3"),
                // new UnusedTypeDef("ELenSymPerCalc"),
                // new UnusedTypeDef("aitype"),
                // new UnusedTypeDef("aibonus"),
                // // new UnusedTypeDef("cost mult"),
                // // new UnusedTypeDef("cost add"),
                // // new UnusedTypeDef("*eol")
            ];
        }

        public IEnumerable<string> GetColumnDefinitions()
        {
            return
            [
                "skill",
                "*Id",
                "charclass",
                "skilldesc",
                "srvstfunc",
                "srvdofunc",
                "srvstopfunc",
                "prgstack",
                "srvprgfunc1",
                "srvprgfunc2",
                "srvprgfunc3",
                "prgcalc1",
                "prgcalc2",
                "prgcalc3",
                "prgdam",
                "srvmissile",
                "decquant",
                "lob",
                "srvmissilea",
                "srvmissileb",
                "srvmissilec",
                "useServerMissilesOnRemoteClients",
                "srvoverlay",
                "aurafilter",
                "aurastate",
                "auratargetstate",
                "auralencalc",
                "aurarangecalc",
                "aurastat1",
                "aurastatcalc1",
                "aurastat2",
                "aurastatcalc2",
                "aurastat3",
                "aurastatcalc3",
                "aurastat4",
                "aurastatcalc4",
                "aurastat5",
                "aurastatcalc5",
                "aurastat6",
                "aurastatcalc6",
                "auraevent1",
                "auraeventfunc1",
                "auraevent2",
                "auraeventfunc2",
                "auraevent3",
                "auraeventfunc3",
                "passivestate",
                "passiveitype",
                "passivereqweaponcount",
                "passivestat1",
                "passivecalc1",
                "passivestat2",
                "passivecalc2",
                "passivestat3",
                "passivecalc3",
                "passivestat4",
                "passivecalc4",
                "passivestat5",
                "passivecalc5",
                "passivestat6",
                "passivecalc6",
                "passivestat7",
                "passivecalc7",
                "passivestat8",
                "passivecalc8",
                "passivestat9",
                "passivecalc9",
                "passivestat10",
                "passivecalc10",
                "passivestat11",
                "passivecalc11",
                "passivestat12",
                "passivecalc12",
                "passivestat13",
                "passivecalc13",
                "passivestat14",
                "passivecalc14",
                "summon",
                "pettype",
                "petmax",
                "summode",
                "sumskill1",
                "sumsk1calc",
                "sumskill2",
                "sumsk2calc",
                "sumskill3",
                "sumsk3calc",
                "sumskill4",
                "sumsk4calc",
                "sumskill5",
                "sumsk5calc",
                "sumumod",
                "sumoverlay",
                "stsuccessonly",
                "stsound",
                "stsoundclass",
                "stsounddelay",
                "weaponsnd",
                "dosound",
                "dosound a",
                "dosound b",
                "tgtoverlay",
                "tgtsound",
                "prgoverlay",
                "prgsound",
                "castoverlay",
                "cltoverlaya",
                "cltoverlayb",
                "cltstfunc",
                "cltdofunc",
                "cltstopfunc",
                "cltprgfunc1",
                "cltprgfunc2",
                "cltprgfunc3",
                "cltmissile",
                "cltmissilea",
                "cltmissileb",
                "cltmissilec",
                "cltmissiled",
                "cltcalc1",
                "*cltcalc1 desc",
                "cltcalc2",
                "*cltcalc2 desc",
                "cltcalc3",
                "*cltcalc3 desc",
                "warp",
                "immediate",
                "enhanceable",
                "attackrank",
                "noammo",
                "range",
                "weapsel",
                "itypea1",
                "itypea2",
                "itypea3",
                "etypea1",
                "etypea2",
                "itypeb1",
                "itypeb2",
                "itypeb3",
                "etypeb1",
                "etypeb2",
                "anim",
                "seqtrans",
                "monanim",
                "seqnum",
                "seqinput",
                "durability",
                "UseAttackRate",
                "LineOfSight",
                "TargetableOnly",
                "SearchEnemyXY",
                "SearchEnemyNear",
                "SearchOpenXY",
                "SelectProc",
                "TargetCorpse",
                "TargetPet",
                "TargetAlly",
                "TargetItem",
                "AttackNoMana",
                "TgtPlaceCheck",
                "KeepCursorStateOnKill",
                "ContinueCastUnselected",
                "ClearSelectedOnHold",
                "ItemEffect",
                "ItemCltEffect",
                "ItemTgtDo",
                "ItemTarget",
                "ItemUseRestrict",
                "ItemCheckStart",
                "ItemCltCheckStart",
                "ItemCastSound",
                "ItemCastOverlay",
                "skpoints",
                "reqlevel",
                "maxlvl",
                "reqstr",
                "reqdex",
                "reqint",
                "reqvit",
                "reqskill1",
                "reqskill2",
                "reqskill3",
                "restrict",
                "State1",
                "State2",
                "State3",
                "localdelay",
                "globaldelay",
                "leftskill",
                "rightskill",
                "repeat",
                "alwayshit",
                "usemanaondo",
                "startmana",
                "minmana",
                "manashift",
                "mana",
                "lvlmana",
                "interrupt",
                "InTown",
                "aura",
                "periodic",
                "perdelay",
                "finishing",
                "prgchargestocast",
                "prgchargesconsumed",
                "passive",
                "progressive",
                "scroll",
                "calc1",
                "*calc1 desc",
                "calc2",
                "*calc2 desc",
                "calc3",
                "*calc3 desc",
                "calc4",
                "*calc4 desc",
                "calc5",
                "*calc5 desc",
                "calc6",
                "*calc6 desc",
                "Param1",
                "*Param1 Description",
                "Param2",
                "*Param2 Description",
                "Param3",
                "*Param3 Description",
                "Param4",
                "*Param4 Description",
                "Param5",
                "*Param5 Description",
                "Param6",
                "*Param6 Description",
                "Param7",
                "*Param7 Description",
                "Param8",
                "*Param8 Description",
                "Param9",
                "*Param9 Description",
                "Param10",
                "*Param10 Description2",
                "Param11",
                "*Param11 Description",
                "Param12",
                "*Param12 Description",
                "InGame",
                "ToHit",
                "LevToHit",
                "ToHitCalc",
                "ResultFlags",
                "HitFlags",
                "HitClass",
                "Kick",
                "HitShift",
                "SrcDam",
                "MinDam",
                "MinLevDam1",
                "MinLevDam2",
                "MinLevDam3",
                "MinLevDam4",
                "MinLevDam5",
                "MaxDam",
                "MaxLevDam1",
                "MaxLevDam2",
                "MaxLevDam3",
                "MaxLevDam4",
                "MaxLevDam5",
                "DmgSymPerCalc",
                "EType",
                "EMin",
                "EMinLev1",
                "EMinLev2",
                "EMinLev3",
                "EMinLev4",
                "EMinLev5",
                "EMax",
                "EMaxLev1",
                "EMaxLev2",
                "EMaxLev3",
                "EMaxLev4",
                "EMaxLev5",
                "EDmgSymPerCalc",
                "ELen",
                "ELevLen1",
                "ELevLen2",
                "ELevLen3",
                "ELenSymPerCalc",
                "aitype",
                "aibonus",
                "cost mult",
                "cost add",
                "*eol"
            ];
        }
    }
}