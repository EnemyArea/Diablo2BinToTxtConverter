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
            // (Magic Arrow) 06 00 4D 61 67 69 63 20 41 72 72 6F 77 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 04 0B C0 80 02 00 00 00 00 00 00 07 0E 07 00 02 00 00 00 2F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF 00 00 1B 00 FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 00 00 FF FF 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 FF FF 1B 00 FF FF FF FF FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 FF FF 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF 00 00 FF FF FF FF 14 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 01 00 00 00 00 00 00 00 00 00 FF FF FF FF FF FF 00 00 00 00 05 00 0C 00 FF FF 00 00 00 00 00 00 FF FF FF FF FF FF FF FF 06 00 00 00 0A 00 00 00 09 00 00 00 FF FF FF FF 08 80 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 FF FF FF FF FF FF 00 00 00 00 00 01 00 00 E8 03 00 00 00 00 00 00 00 00 00 00 07 00
            return
            [
                new Int16TypeDef("*Id"), // 06 00
                new StringTypeDef("skill",
                    34), // 4D 61 67 69 63 20 41 72 72 6F 77 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00

                new Int8TypeDef("unknown-00"), // 00

                new Int8TypeDef("unknown-04"), // 04
                new Int8TypeDef("unknown-0B"), // 0B
                new Int8TypeDef("unknown-C0"), // C0
                new Int8TypeDef("unknown-80"), // 80
                new Int32TypeDef("unknown-02"), // 02 00 00 00
                new Int8TypeDef("unknown-00"), // 00
                new Int8TypeDef("unknown-00"), // 00
                new Int8TypeDef("unknown-00"), // 00
                new Int8TypeDef("unknown-07"), // 07
                new Int8TypeDef("unknown-0E"), // 0E
                new Int8TypeDef("unknown-07"), // 07
                new Int8TypeDef("unknown-00"), // 00

                new Int32TypeDef("unknown-02 00 00 00"), // 02 00 00 00
                new Int32TypeDef("unknown-2F 00 00 00"), // 2F 00 00 00
                new Int32TypeDef("unknown-00 00 00 00"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown0"), // 00 00 00 00
                new Int32TypeDef("unknown1"), // 00 00 00 00
                new Int32TypeDef("unknown2"), // 00 00 00 00
                new Int32TypeDef("unknown3"), // 00 00 00 00

                new Int32TypeDef("unknown4"), // 00 00 00 00
                new Int32TypeDef("unknown5"), // FF FF FF FF
                new Int32TypeDef("unknown6"), // FF FF FF FF
                new Int32TypeDef("unknown7"), // FF FF FF FF

                new Int16TypeDef("unknown8"), // 00 00
                new Int16TypeDef("cltmissile"), // 1B 00
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown-00 00 00 00"), // 00 00 00 00

                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int16TypeDef("unknown"), // FF FF
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown-FF FF"), // FF FF
                new Int16TypeDef("unknown-00 00"), // 00 00

                new Int16TypeDef("unknown-00 00"), // 00 00
                new Int16TypeDef("unknown-FF FF"), // FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF

                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int16TypeDef("unknown-FF FF"), // FF FF
                new Int16TypeDef("unknown-00 00"), // 00 00

                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF

                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF

                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF

                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF

                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int16TypeDef("unknown-FF FF"), // FF FF
                new Int16TypeDef("unknown-00 00"), // 00 00
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF

                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF
                new Int32TypeDef("unknown-FF FF FF FF"), // FF FF FF FF

                new Int16TypeDef("unknown-00 00"), // 00 00
                new Int16TypeDef("unknown-FF FF"), // FF FF
                new Int16TypeDef("unknown-1B 00"), // 1B 00
                new Int16TypeDef("unknown"), // FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int16TypeDef("unknown"), // FF FF
                new Int16TypeDef("unknown"), // 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // FF FF
                new Int16TypeDef("unknown"), // FF FF
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // FF FF
                new Int16TypeDef("unknown"), // 00 00
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int16TypeDef("unknown"), // FF FF
                new Int16TypeDef("unknown"), // 00 00
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("maxlvl"), // 14 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // 01 00 00 00 ???? = 1 
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int16TypeDef("manashift"), // 05 00 ???? = 5
                new Int16TypeDef("mana"), // 0C 00 ???? = 12

                new Int16TypeDef("unknown"), // FF FF
                new Int16TypeDef("unknown"), // 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int32TypeDef("unknown"), // 06 00 00 00 ???? = 6
                new Int32TypeDef("ToHit"), // 0A 00 00 00 ???? = 10 
                new Int32TypeDef("LevToHit"), // 09 00 00 00 ???? = 9
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int8TypeDef("HitShift"), // 08 ???? = 8
                new Int16TypeDef("SrcDam"), // 80 00 ???? = 128
                new Int8TypeDef("unknown"), // 00
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
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // FF FF FF FF

                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // FF FF
                new Int32TypeDef("unknown"), // FF FF FF FF
                new Int32TypeDef("unknown"), // 00 00 00 00

                new Int32TypeDef("cost mult"), // 00 00 00 00
                new Int32TypeDef("cost add"), // E8 03 00 00
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("unknown"), // 00 00
                new Int16TypeDef("*eol") // 00 00
                // new Int32TypeDef("*eol"), // 00 00 00 00
                // new Int32TypeDef("unknown") // 00 00 00 00

                // new UnusedTypeDef("charclass"),
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
                // new UnusedTypeDef("stsound"),
                // new UnusedTypeDef("stsoundclass"),
                // new UnusedTypeDef("stsounddelay"),
                // new UnusedTypeDef("weaponsnd"),
                // new UnusedTypeDef("dosound"),
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
                // new UnusedTypeDef("cltdofunc"),
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
                // new UnusedTypeDef("minmana"),
                // // new UnusedTypeDef("manashift"),
                // // new UnusedTypeDef("mana"),
                // new UnusedTypeDef("lvlmana"),
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
                // new UnusedTypeDef("EType"),
                // new UnusedTypeDef("EMin"),
                // new UnusedTypeDef("EMinLev1"),
                // new UnusedTypeDef("EMinLev2"),
                // new UnusedTypeDef("EMinLev3"),
                // new UnusedTypeDef("EMinLev4"),
                // new UnusedTypeDef("EMinLev5"),
                // new UnusedTypeDef("EMax"),
                // new UnusedTypeDef("EMaxLev1"),
                // new UnusedTypeDef("EMaxLev2"),
                // new UnusedTypeDef("EMaxLev3"),
                // new UnusedTypeDef("EMaxLev4"),
                // new UnusedTypeDef("EMaxLev5"),
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
                //// new UnusedTypeDef("*eol")
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