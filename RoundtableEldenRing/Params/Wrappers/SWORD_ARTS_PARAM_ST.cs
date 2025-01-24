using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class SWORD_ARTS_PARAM_ST
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
        public byte swordArtsType
        {
            get => (byte)row["swordArtsType"].Value;
            set => row["swordArtsType"].Value = value;
        }

        // Unknown.
        public byte artsSpeedType
        {
            get => (byte)row["artsSpeedType"].Value;
            set => row["artsSpeedType"].Value = value;
        }

        // Unknown.
        public sbyte refStatus
        {
            get => (sbyte)row["refStatus"].Value;
            set => row["refStatus"].Value = value;
        }

        // Unknown.
        public byte isRefRightArts
        {
            get => (byte)row["isRefRightArts"].Value;
            set => row["isRefRightArts"].Value = value;
        }

        // Unknown.
        public byte isGrayoutLeftHand
        {
            get => (byte)row["isGrayoutLeftHand"].Value;
            set => row["isGrayoutLeftHand"].Value = value;
        }

        // Unknown.
        public byte isGrayoutRightHand
        {
            get => (byte)row["isGrayoutRightHand"].Value;
            set => row["isGrayoutRightHand"].Value = value;
        }

        // Unknown.
        public byte isGrayoutBothHand
        {
            get => (byte)row["isGrayoutBothHand"].Value;
            set => row["isGrayoutBothHand"].Value = value;
        }

        // Unknown.
        public sbyte usePoint_L1
        {
            get => (sbyte)row["usePoint_L1"].Value;
            set => row["usePoint_L1"].Value = value;
        }

        // Unknown.
        public sbyte usePoint_L2
        {
            get => (sbyte)row["usePoint_L2"].Value;
            set => row["usePoint_L2"].Value = value;
        }

        // Unknown.
        public sbyte usePoint_R1
        {
            get => (sbyte)row["usePoint_R1"].Value;
            set => row["usePoint_R1"].Value = value;
        }

        // Unknown.
        public sbyte usePoint_R2
        {
            get => (sbyte)row["usePoint_R2"].Value;
            set => row["usePoint_R2"].Value = value;
        }

        // Unknown.
        public int textId
        {
            get => (int)row["textId"].Value;
            set => row["textId"].Value = value;
        }

        // Unknown.
        public short useMagicPoint_L1
        {
            get => (short)row["useMagicPoint_L1"].Value;
            set => row["useMagicPoint_L1"].Value = value;
        }

        // Unknown.
        public short useMagicPoint_L2
        {
            get => (short)row["useMagicPoint_L2"].Value;
            set => row["useMagicPoint_L2"].Value = value;
        }

        // Unknown.
        public short useMagicPoint_R1
        {
            get => (short)row["useMagicPoint_R1"].Value;
            set => row["useMagicPoint_R1"].Value = value;
        }

        // Unknown.
        public short useMagicPoint_R2
        {
            get => (short)row["useMagicPoint_R2"].Value;
            set => row["useMagicPoint_R2"].Value = value;
        }

        // Unknown.
        public sbyte shieldIconType
        {
            get => (sbyte)row["shieldIconType"].Value;
            set => row["shieldIconType"].Value = value;
        }

        // Unknown.
        public ushort iconId
        {
            get => (ushort)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public int aiUsageId
        {
            get => (int)row["aiUsageId"].Value;
            set => row["aiUsageId"].Value = value;
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
    public SWORD_ARTS_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SWORD_ARTS_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
