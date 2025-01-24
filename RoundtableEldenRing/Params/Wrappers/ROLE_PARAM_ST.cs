using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class ROLE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte teamType
        {
            get => (byte)row["teamType"].Value;
            set => row["teamType"].Value = value;
        }

        // Unknown.
        public int phantomParamId
        {
            get => (int)row["phantomParamId"].Value;
            set => row["phantomParamId"].Value = value;
        }

        // Unknown.
        public int spEffectID0
        {
            get => (int)row["spEffectID0"].Value;
            set => row["spEffectID0"].Value = value;
        }

        // Unknown.
        public int spEffectID1
        {
            get => (int)row["spEffectID1"].Value;
            set => row["spEffectID1"].Value = value;
        }

        // Unknown.
        public int spEffectID2
        {
            get => (int)row["spEffectID2"].Value;
            set => row["spEffectID2"].Value = value;
        }

        // Unknown.
        public int spEffectID3
        {
            get => (int)row["spEffectID3"].Value;
            set => row["spEffectID3"].Value = value;
        }

        // Unknown.
        public int spEffectID4
        {
            get => (int)row["spEffectID4"].Value;
            set => row["spEffectID4"].Value = value;
        }

        // Unknown.
        public int spEffectID5
        {
            get => (int)row["spEffectID5"].Value;
            set => row["spEffectID5"].Value = value;
        }

        // Unknown.
        public int spEffectID6
        {
            get => (int)row["spEffectID6"].Value;
            set => row["spEffectID6"].Value = value;
        }

        // Unknown.
        public int spEffectID7
        {
            get => (int)row["spEffectID7"].Value;
            set => row["spEffectID7"].Value = value;
        }

        // Unknown.
        public int spEffectID8
        {
            get => (int)row["spEffectID8"].Value;
            set => row["spEffectID8"].Value = value;
        }

        // Unknown.
        public int spEffectID9
        {
            get => (int)row["spEffectID9"].Value;
            set => row["spEffectID9"].Value = value;
        }

        // Unknown.
        public int sosSignSfxId
        {
            get => (int)row["sosSignSfxId"].Value;
            set => row["sosSignSfxId"].Value = value;
        }

        // Unknown.
        public int mySosSignSfxId
        {
            get => (int)row["mySosSignSfxId"].Value;
            set => row["mySosSignSfxId"].Value = value;
        }

        // Unknown.
        public int summonStartAnimId
        {
            get => (int)row["summonStartAnimId"].Value;
            set => row["summonStartAnimId"].Value = value;
        }

        // Unknown.
        public int itemlotParamId
        {
            get => (int)row["itemlotParamId"].Value;
            set => row["itemlotParamId"].Value = value;
        }

        // Unknown.
        public byte voiceChatGroup
        {
            get => (byte)row["voiceChatGroup"].Value;
            set => row["voiceChatGroup"].Value = value;
        }

        // Unknown.
        public byte roleNameColor
        {
            get => (byte)row["roleNameColor"].Value;
            set => row["roleNameColor"].Value = value;
        }

        // Unknown.
        public int roleNameId
        {
            get => (int)row["roleNameId"].Value;
            set => row["roleNameId"].Value = value;
        }

        // Unknown.
        public uint threatLv
        {
            get => (uint)row["threatLv"].Value;
            set => row["threatLv"].Value = value;
        }

        // Unknown.
        public int phantomParamId_vowRank1
        {
            get => (int)row["phantomParamId_vowRank1"].Value;
            set => row["phantomParamId_vowRank1"].Value = value;
        }

        // Unknown.
        public int phantomParamId_vowRank2
        {
            get => (int)row["phantomParamId_vowRank2"].Value;
            set => row["phantomParamId_vowRank2"].Value = value;
        }

        // Unknown.
        public int phantomParamId_vowRank3
        {
            get => (int)row["phantomParamId_vowRank3"].Value;
            set => row["phantomParamId_vowRank3"].Value = value;
        }

        // Unknown.
        public int spEffectID_vowRank0
        {
            get => (int)row["spEffectID_vowRank0"].Value;
            set => row["spEffectID_vowRank0"].Value = value;
        }

        // Unknown.
        public int spEffectID_vowRank1
        {
            get => (int)row["spEffectID_vowRank1"].Value;
            set => row["spEffectID_vowRank1"].Value = value;
        }

        // Unknown.
        public int spEffectID_vowRank2
        {
            get => (int)row["spEffectID_vowRank2"].Value;
            set => row["spEffectID_vowRank2"].Value = value;
        }

        // Unknown.
        public int spEffectID_vowRank3
        {
            get => (int)row["spEffectID_vowRank3"].Value;
            set => row["spEffectID_vowRank3"].Value = value;
        }

        // Unknown.
        public int signPhantomId
        {
            get => (int)row["signPhantomId"].Value;
            set => row["signPhantomId"].Value = value;
        }

        // Unknown.
        public int nonPlayerSummonStartAnimId
        {
            get => (int)row["nonPlayerSummonStartAnimId"].Value;
            set => row["nonPlayerSummonStartAnimId"].Value = value;
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
    public ROLE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ROLE_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
