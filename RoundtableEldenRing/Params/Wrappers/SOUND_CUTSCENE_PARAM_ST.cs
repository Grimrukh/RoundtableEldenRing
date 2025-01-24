using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class SOUND_CUTSCENE_PARAM_ST
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
        public byte ReverbType
        {
            get => (byte)row["ReverbType"].Value;
            set => row["ReverbType"].Value = value;
        }

        // Unknown.
        public short BgmBehaviorTypeOnStart
        {
            get => (short)row["BgmBehaviorTypeOnStart"].Value;
            set => row["BgmBehaviorTypeOnStart"].Value = value;
        }

        // Unknown.
        public short OneShotBgmBehaviorOnStart
        {
            get => (short)row["OneShotBgmBehaviorOnStart"].Value;
            set => row["OneShotBgmBehaviorOnStart"].Value = value;
        }

        // Unknown.
        public int PostPlaySeId
        {
            get => (int)row["PostPlaySeId"].Value;
            set => row["PostPlaySeId"].Value = value;
        }

        // Unknown.
        public int PostPlaySeIdForSkip
        {
            get => (int)row["PostPlaySeIdForSkip"].Value;
            set => row["PostPlaySeIdForSkip"].Value = value;
        }

        // Unknown.
        public float EnterMapMuteStopTimeOnDrawCutscene
        {
            get => (float)row["EnterMapMuteStopTimeOnDrawCutscene"].Value;
            set => row["EnterMapMuteStopTimeOnDrawCutscene"].Value = value;
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
    public SOUND_CUTSCENE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SOUND_CUTSCENE_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
