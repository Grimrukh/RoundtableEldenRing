using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class GAME_AREA_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte disableParam_NT
        {
            get => (byte)row["disableParam_NT"].Value;
            set => row["disableParam_NT"].Value = value;
        }

        // Unknown.
        public uint bonusSoul_single
        {
            get => (uint)row["bonusSoul_single"].Value;
            set => row["bonusSoul_single"].Value = value;
        }

        // Unknown.
        public uint bonusSoul_multi
        {
            get => (uint)row["bonusSoul_multi"].Value;
            set => row["bonusSoul_multi"].Value = value;
        }

        // Unknown.
        public uint humanityPointCountFlagIdTop
        {
            get => (uint)row["humanityPointCountFlagIdTop"].Value;
            set => row["humanityPointCountFlagIdTop"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint1
        {
            get => (ushort)row["humanityDropPoint1"].Value;
            set => row["humanityDropPoint1"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint2
        {
            get => (ushort)row["humanityDropPoint2"].Value;
            set => row["humanityDropPoint2"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint3
        {
            get => (ushort)row["humanityDropPoint3"].Value;
            set => row["humanityDropPoint3"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint4
        {
            get => (ushort)row["humanityDropPoint4"].Value;
            set => row["humanityDropPoint4"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint5
        {
            get => (ushort)row["humanityDropPoint5"].Value;
            set => row["humanityDropPoint5"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint6
        {
            get => (ushort)row["humanityDropPoint6"].Value;
            set => row["humanityDropPoint6"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint7
        {
            get => (ushort)row["humanityDropPoint7"].Value;
            set => row["humanityDropPoint7"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint8
        {
            get => (ushort)row["humanityDropPoint8"].Value;
            set => row["humanityDropPoint8"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint9
        {
            get => (ushort)row["humanityDropPoint9"].Value;
            set => row["humanityDropPoint9"].Value = value;
        }

        // Unknown.
        public ushort humanityDropPoint10
        {
            get => (ushort)row["humanityDropPoint10"].Value;
            set => row["humanityDropPoint10"].Value = value;
        }

        // Unknown.
        public uint soloBreakInPoint_Min
        {
            get => (uint)row["soloBreakInPoint_Min"].Value;
            set => row["soloBreakInPoint_Min"].Value = value;
        }

        // Unknown.
        public uint soloBreakInPoint_Max
        {
            get => (uint)row["soloBreakInPoint_Max"].Value;
            set => row["soloBreakInPoint_Max"].Value = value;
        }

        // Unknown.
        public uint defeatBossFlagId_forSignAimList
        {
            get => (uint)row["defeatBossFlagId_forSignAimList"].Value;
            set => row["defeatBossFlagId_forSignAimList"].Value = value;
        }

        public uint displayAimFlagId
        {
            get => (uint)row["displayAimFlagId"].Value;
            set => row["displayAimFlagId"].Value = value;
        }

        public uint foundBossFlagId
        {
            get => (uint)row["foundBossFlagId"].Value;
            set => row["foundBossFlagId"].Value = value;
        }

        public int foundBossTextId
        {
            get => (int)row["foundBossTextId"].Value;
            set => row["foundBossTextId"].Value = value;
        }

        public int notFindBossTextId
        {
            get => (int)row["notFindBossTextId"].Value;
            set => row["notFindBossTextId"].Value = value;
        }

        // Unknown.
        public uint bossChallengeFlagId
        {
            get => (uint)row["bossChallengeFlagId"].Value;
            set => row["bossChallengeFlagId"].Value = value;
        }

        // Unknown.
        public uint defeatBossFlagId
        {
            get => (uint)row["defeatBossFlagId"].Value;
            set => row["defeatBossFlagId"].Value = value;
        }

        // Unknown.
        public float bossPosX
        {
            get => (float)row["bossPosX"].Value;
            set => row["bossPosX"].Value = value;
        }

        // Unknown.
        public float bossPosY
        {
            get => (float)row["bossPosY"].Value;
            set => row["bossPosY"].Value = value;
        }

        // Unknown.
        public float bossPosZ
        {
            get => (float)row["bossPosZ"].Value;
            set => row["bossPosZ"].Value = value;
        }

        // Unknown.
        public byte bossMapAreaNo
        {
            get => (byte)row["bossMapAreaNo"].Value;
            set => row["bossMapAreaNo"].Value = value;
        }

        // Unknown.
        public byte bossMapBlockNo
        {
            get => (byte)row["bossMapBlockNo"].Value;
            set => row["bossMapBlockNo"].Value = value;
        }

        // Unknown.
        public byte bossMapMapNo
        {
            get => (byte)row["bossMapMapNo"].Value;
            set => row["bossMapMapNo"].Value = value;
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
    public GAME_AREA_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public GAME_AREA_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
