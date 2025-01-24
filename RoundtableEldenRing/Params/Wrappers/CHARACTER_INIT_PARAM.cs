using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class CHARACTER_INIT_PARAM
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float baseRec_mp
        {
            get => (float)row["baseRec_mp"].Value;
            set => row["baseRec_mp"].Value = value;
        }

        // Unknown.
        public float baseRec_sp
        {
            get => (float)row["baseRec_sp"].Value;
            set => row["baseRec_sp"].Value = value;
        }

        // Unknown.
        public float red_Falldam
        {
            get => (float)row["red_Falldam"].Value;
            set => row["red_Falldam"].Value = value;
        }

        // Unknown.
        public int soul
        {
            get => (int)row["soul"].Value;
            set => row["soul"].Value = value;
        }

        // Unknown.
        public int equip_Wep_Right
        {
            get => (int)row["equip_Wep_Right"].Value;
            set => row["equip_Wep_Right"].Value = value;
        }

        // Unknown.
        public int equip_Subwep_Right
        {
            get => (int)row["equip_Subwep_Right"].Value;
            set => row["equip_Subwep_Right"].Value = value;
        }

        // Unknown.
        public int equip_Wep_Left
        {
            get => (int)row["equip_Wep_Left"].Value;
            set => row["equip_Wep_Left"].Value = value;
        }

        // Unknown.
        public int equip_Subwep_Left
        {
            get => (int)row["equip_Subwep_Left"].Value;
            set => row["equip_Subwep_Left"].Value = value;
        }

        // Unknown.
        public int equip_Helm
        {
            get => (int)row["equip_Helm"].Value;
            set => row["equip_Helm"].Value = value;
        }

        // Unknown.
        public int equip_Armer
        {
            get => (int)row["equip_Armer"].Value;
            set => row["equip_Armer"].Value = value;
        }

        // Unknown.
        public int equip_Gaunt
        {
            get => (int)row["equip_Gaunt"].Value;
            set => row["equip_Gaunt"].Value = value;
        }

        // Unknown.
        public int equip_Leg
        {
            get => (int)row["equip_Leg"].Value;
            set => row["equip_Leg"].Value = value;
        }

        // Unknown.
        public int equip_Arrow
        {
            get => (int)row["equip_Arrow"].Value;
            set => row["equip_Arrow"].Value = value;
        }

        // Unknown.
        public int equip_Bolt
        {
            get => (int)row["equip_Bolt"].Value;
            set => row["equip_Bolt"].Value = value;
        }

        // Unknown.
        public int equip_SubArrow
        {
            get => (int)row["equip_SubArrow"].Value;
            set => row["equip_SubArrow"].Value = value;
        }

        // Unknown.
        public int equip_SubBolt
        {
            get => (int)row["equip_SubBolt"].Value;
            set => row["equip_SubBolt"].Value = value;
        }

        // Unknown.
        public int equip_Accessory01
        {
            get => (int)row["equip_Accessory01"].Value;
            set => row["equip_Accessory01"].Value = value;
        }

        // Unknown.
        public int equip_Accessory02
        {
            get => (int)row["equip_Accessory02"].Value;
            set => row["equip_Accessory02"].Value = value;
        }

        // Unknown.
        public int equip_Accessory03
        {
            get => (int)row["equip_Accessory03"].Value;
            set => row["equip_Accessory03"].Value = value;
        }

        // Unknown.
        public int equip_Accessory04
        {
            get => (int)row["equip_Accessory04"].Value;
            set => row["equip_Accessory04"].Value = value;
        }

        // Unknown.
        public int elixir_material00
        {
            get => (int)row["elixir_material00"].Value;
            set => row["elixir_material00"].Value = value;
        }

        // Unknown.
        public int elixir_material01
        {
            get => (int)row["elixir_material01"].Value;
            set => row["elixir_material01"].Value = value;
        }

        // Unknown.
        public int elixir_material02
        {
            get => (int)row["elixir_material02"].Value;
            set => row["elixir_material02"].Value = value;
        }

        // Unknown.
        public int equip_Spell_01
        {
            get => (int)row["equip_Spell_01"].Value;
            set => row["equip_Spell_01"].Value = value;
        }

        // Unknown.
        public int equip_Spell_02
        {
            get => (int)row["equip_Spell_02"].Value;
            set => row["equip_Spell_02"].Value = value;
        }

        // Unknown.
        public int equip_Spell_03
        {
            get => (int)row["equip_Spell_03"].Value;
            set => row["equip_Spell_03"].Value = value;
        }

        // Unknown.
        public int equip_Spell_04
        {
            get => (int)row["equip_Spell_04"].Value;
            set => row["equip_Spell_04"].Value = value;
        }

        // Unknown.
        public int equip_Spell_05
        {
            get => (int)row["equip_Spell_05"].Value;
            set => row["equip_Spell_05"].Value = value;
        }

        // Unknown.
        public int equip_Spell_06
        {
            get => (int)row["equip_Spell_06"].Value;
            set => row["equip_Spell_06"].Value = value;
        }

        // Unknown.
        public int equip_Spell_07
        {
            get => (int)row["equip_Spell_07"].Value;
            set => row["equip_Spell_07"].Value = value;
        }

        // Unknown.
        public int item_01
        {
            get => (int)row["item_01"].Value;
            set => row["item_01"].Value = value;
        }

        // Unknown.
        public int item_02
        {
            get => (int)row["item_02"].Value;
            set => row["item_02"].Value = value;
        }

        // Unknown.
        public int item_03
        {
            get => (int)row["item_03"].Value;
            set => row["item_03"].Value = value;
        }

        // Unknown.
        public int item_04
        {
            get => (int)row["item_04"].Value;
            set => row["item_04"].Value = value;
        }

        // Unknown.
        public int item_05
        {
            get => (int)row["item_05"].Value;
            set => row["item_05"].Value = value;
        }

        // Unknown.
        public int item_06
        {
            get => (int)row["item_06"].Value;
            set => row["item_06"].Value = value;
        }

        // Unknown.
        public int item_07
        {
            get => (int)row["item_07"].Value;
            set => row["item_07"].Value = value;
        }

        // Unknown.
        public int item_08
        {
            get => (int)row["item_08"].Value;
            set => row["item_08"].Value = value;
        }

        // Unknown.
        public int item_09
        {
            get => (int)row["item_09"].Value;
            set => row["item_09"].Value = value;
        }

        // Unknown.
        public int item_10
        {
            get => (int)row["item_10"].Value;
            set => row["item_10"].Value = value;
        }

        // Unknown.
        public int npcPlayerFaceGenId
        {
            get => (int)row["npcPlayerFaceGenId"].Value;
            set => row["npcPlayerFaceGenId"].Value = value;
        }

        // Unknown.
        public int npcPlayerThinkId
        {
            get => (int)row["npcPlayerThinkId"].Value;
            set => row["npcPlayerThinkId"].Value = value;
        }

        // Unknown.
        public ushort baseHp
        {
            get => (ushort)row["baseHp"].Value;
            set => row["baseHp"].Value = value;
        }

        // Unknown.
        public ushort baseMp
        {
            get => (ushort)row["baseMp"].Value;
            set => row["baseMp"].Value = value;
        }

        // Unknown.
        public ushort baseSp
        {
            get => (ushort)row["baseSp"].Value;
            set => row["baseSp"].Value = value;
        }

        // Unknown.
        public ushort arrowNum
        {
            get => (ushort)row["arrowNum"].Value;
            set => row["arrowNum"].Value = value;
        }

        // Unknown.
        public ushort boltNum
        {
            get => (ushort)row["boltNum"].Value;
            set => row["boltNum"].Value = value;
        }

        // Unknown.
        public ushort subArrowNum
        {
            get => (ushort)row["subArrowNum"].Value;
            set => row["subArrowNum"].Value = value;
        }

        // Unknown.
        public ushort subBoltNum
        {
            get => (ushort)row["subBoltNum"].Value;
            set => row["subBoltNum"].Value = value;
        }

        // Unknown.
        public short soulLv
        {
            get => (short)row["soulLv"].Value;
            set => row["soulLv"].Value = value;
        }

        // Unknown.
        public byte baseVit
        {
            get => (byte)row["baseVit"].Value;
            set => row["baseVit"].Value = value;
        }

        // Unknown.
        public byte baseWil
        {
            get => (byte)row["baseWil"].Value;
            set => row["baseWil"].Value = value;
        }

        // Unknown.
        public byte baseEnd
        {
            get => (byte)row["baseEnd"].Value;
            set => row["baseEnd"].Value = value;
        }

        // Unknown.
        public byte baseStr
        {
            get => (byte)row["baseStr"].Value;
            set => row["baseStr"].Value = value;
        }

        // Unknown.
        public byte baseDex
        {
            get => (byte)row["baseDex"].Value;
            set => row["baseDex"].Value = value;
        }

        // Unknown.
        public byte baseMag
        {
            get => (byte)row["baseMag"].Value;
            set => row["baseMag"].Value = value;
        }

        // Unknown.
        public byte baseFai
        {
            get => (byte)row["baseFai"].Value;
            set => row["baseFai"].Value = value;
        }

        // Unknown.
        public byte baseLuc
        {
            get => (byte)row["baseLuc"].Value;
            set => row["baseLuc"].Value = value;
        }

        // Unknown.
        public byte baseHeroPoint
        {
            get => (byte)row["baseHeroPoint"].Value;
            set => row["baseHeroPoint"].Value = value;
        }

        // Unknown.
        public byte baseDurability
        {
            get => (byte)row["baseDurability"].Value;
            set => row["baseDurability"].Value = value;
        }

        // Unknown.
        public byte itemNum_01
        {
            get => (byte)row["itemNum_01"].Value;
            set => row["itemNum_01"].Value = value;
        }

        // Unknown.
        public byte itemNum_02
        {
            get => (byte)row["itemNum_02"].Value;
            set => row["itemNum_02"].Value = value;
        }

        // Unknown.
        public byte itemNum_03
        {
            get => (byte)row["itemNum_03"].Value;
            set => row["itemNum_03"].Value = value;
        }

        // Unknown.
        public byte itemNum_04
        {
            get => (byte)row["itemNum_04"].Value;
            set => row["itemNum_04"].Value = value;
        }

        // Unknown.
        public byte itemNum_05
        {
            get => (byte)row["itemNum_05"].Value;
            set => row["itemNum_05"].Value = value;
        }

        // Unknown.
        public byte itemNum_06
        {
            get => (byte)row["itemNum_06"].Value;
            set => row["itemNum_06"].Value = value;
        }

        // Unknown.
        public byte itemNum_07
        {
            get => (byte)row["itemNum_07"].Value;
            set => row["itemNum_07"].Value = value;
        }

        // Unknown.
        public byte itemNum_08
        {
            get => (byte)row["itemNum_08"].Value;
            set => row["itemNum_08"].Value = value;
        }

        // Unknown.
        public byte itemNum_09
        {
            get => (byte)row["itemNum_09"].Value;
            set => row["itemNum_09"].Value = value;
        }

        // Unknown.
        public byte itemNum_10
        {
            get => (byte)row["itemNum_10"].Value;
            set => row["itemNum_10"].Value = value;
        }

        // Unknown.
        public sbyte gestureId0
        {
            get => (sbyte)row["gestureId0"].Value;
            set => row["gestureId0"].Value = value;
        }

        // Unknown.
        public sbyte gestureId1
        {
            get => (sbyte)row["gestureId1"].Value;
            set => row["gestureId1"].Value = value;
        }

        // Unknown.
        public sbyte gestureId2
        {
            get => (sbyte)row["gestureId2"].Value;
            set => row["gestureId2"].Value = value;
        }

        // Unknown.
        public sbyte gestureId3
        {
            get => (sbyte)row["gestureId3"].Value;
            set => row["gestureId3"].Value = value;
        }

        // Unknown.
        public sbyte gestureId4
        {
            get => (sbyte)row["gestureId4"].Value;
            set => row["gestureId4"].Value = value;
        }

        // Unknown.
        public sbyte gestureId5
        {
            get => (sbyte)row["gestureId5"].Value;
            set => row["gestureId5"].Value = value;
        }

        // Unknown.
        public sbyte gestureId6
        {
            get => (sbyte)row["gestureId6"].Value;
            set => row["gestureId6"].Value = value;
        }

        // Unknown.
        public byte npcPlayerType
        {
            get => (byte)row["npcPlayerType"].Value;
            set => row["npcPlayerType"].Value = value;
        }

        // Unknown.
        public sbyte npcPlayerDrawType
        {
            get => (sbyte)row["npcPlayerDrawType"].Value;
            set => row["npcPlayerDrawType"].Value = value;
        }

        // Unknown.
        public byte npcPlayerSex
        {
            get => (byte)row["npcPlayerSex"].Value;
            set => row["npcPlayerSex"].Value = value;
        }

        // Unknown.
        public byte vowType
        {
            get => (byte)row["vowType"].Value;
            set => row["vowType"].Value = value;
        }

        // Unknown.
        public byte isSyncTarget
        {
            get => (byte)row["isSyncTarget"].Value;
            set => row["isSyncTarget"].Value = value;
        }

        // Unknown.
        public byte wepParamType_Right1
        {
            get => (byte)row["wepParamType_Right1"].Value;
            set => row["wepParamType_Right1"].Value = value;
        }

        // Unknown.
        public byte wepParamType_Right2
        {
            get => (byte)row["wepParamType_Right2"].Value;
            set => row["wepParamType_Right2"].Value = value;
        }

        // Unknown.
        public byte wepParamType_Right3
        {
            get => (byte)row["wepParamType_Right3"].Value;
            set => row["wepParamType_Right3"].Value = value;
        }

        // Unknown.
        public byte wepParamType_Left1
        {
            get => (byte)row["wepParamType_Left1"].Value;
            set => row["wepParamType_Left1"].Value = value;
        }

        // Unknown.
        public byte wepParamType_Left2
        {
            get => (byte)row["wepParamType_Left2"].Value;
            set => row["wepParamType_Left2"].Value = value;
        }

        // Unknown.
        public byte wepParamType_Left3
        {
            get => (byte)row["wepParamType_Left3"].Value;
            set => row["wepParamType_Left3"].Value = value;
        }

        // Unknown.
        public int equip_Subwep_Right3
        {
            get => (int)row["equip_Subwep_Right3"].Value;
            set => row["equip_Subwep_Right3"].Value = value;
        }

        // Unknown.
        public int equip_Subwep_Left3
        {
            get => (int)row["equip_Subwep_Left3"].Value;
            set => row["equip_Subwep_Left3"].Value = value;
        }

        // Unknown.
        public int secondaryItem_01
        {
            get => (int)row["secondaryItem_01"].Value;
            set => row["secondaryItem_01"].Value = value;
        }

        // Unknown.
        public int secondaryItem_02
        {
            get => (int)row["secondaryItem_02"].Value;
            set => row["secondaryItem_02"].Value = value;
        }

        // Unknown.
        public int secondaryItem_03
        {
            get => (int)row["secondaryItem_03"].Value;
            set => row["secondaryItem_03"].Value = value;
        }

        // Unknown.
        public int secondaryItem_04
        {
            get => (int)row["secondaryItem_04"].Value;
            set => row["secondaryItem_04"].Value = value;
        }

        // Unknown.
        public int secondaryItem_05
        {
            get => (int)row["secondaryItem_05"].Value;
            set => row["secondaryItem_05"].Value = value;
        }

        // Unknown.
        public int secondaryItem_06
        {
            get => (int)row["secondaryItem_06"].Value;
            set => row["secondaryItem_06"].Value = value;
        }

        // Unknown.
        public byte secondaryItemNum_01
        {
            get => (byte)row["secondaryItemNum_01"].Value;
            set => row["secondaryItemNum_01"].Value = value;
        }

        // Unknown.
        public byte secondaryItemNum_02
        {
            get => (byte)row["secondaryItemNum_02"].Value;
            set => row["secondaryItemNum_02"].Value = value;
        }

        // Unknown.
        public byte secondaryItemNum_03
        {
            get => (byte)row["secondaryItemNum_03"].Value;
            set => row["secondaryItemNum_03"].Value = value;
        }

        // Unknown.
        public byte secondaryItemNum_04
        {
            get => (byte)row["secondaryItemNum_04"].Value;
            set => row["secondaryItemNum_04"].Value = value;
        }

        // Unknown.
        public byte secondaryItemNum_05
        {
            get => (byte)row["secondaryItemNum_05"].Value;
            set => row["secondaryItemNum_05"].Value = value;
        }

        // Unknown.
        public byte secondaryItemNum_06
        {
            get => (byte)row["secondaryItemNum_06"].Value;
            set => row["secondaryItemNum_06"].Value = value;
        }

        // Unknown.
        public sbyte HpEstMax
        {
            get => (sbyte)row["HpEstMax"].Value;
            set => row["HpEstMax"].Value = value;
        }

        // Unknown.
        public sbyte MpEstMax
        {
            get => (sbyte)row["MpEstMax"].Value;
            set => row["MpEstMax"].Value = value;
        }

        // Unknown.
        public byte voiceType
        {
            get => (byte)row["voiceType"].Value;
            set => row["voiceType"].Value = value;
        }

        public object this[string fieldName]
        {
            get => row[fieldName].Value;
            set => row[fieldName].Value = value;
        }
    }
    
    /// <summary>
    /// Construct from a standard `PARAM` read from disk.
    /// </summary>
    public CHARACTER_INIT_PARAM(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CHARACTER_INIT_PARAM(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
