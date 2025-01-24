using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class TALK_PARAM_ST
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
        public int msgId
        {
            get => (int)row["msgId"].Value;
            set => row["msgId"].Value = value;
        }

        // Unknown.
        public int voiceId
        {
            get => (int)row["voiceId"].Value;
            set => row["voiceId"].Value = value;
        }

        // Unknown.
        public int spEffectId0
        {
            get => (int)row["spEffectId0"].Value;
            set => row["spEffectId0"].Value = value;
        }

        // Unknown.
        public int motionId0
        {
            get => (int)row["motionId0"].Value;
            set => row["motionId0"].Value = value;
        }

        // Unknown.
        public int spEffectId1
        {
            get => (int)row["spEffectId1"].Value;
            set => row["spEffectId1"].Value = value;
        }

        // Unknown.
        public int motionId1
        {
            get => (int)row["motionId1"].Value;
            set => row["motionId1"].Value = value;
        }

        // Unknown.
        public int returnPos
        {
            get => (int)row["returnPos"].Value;
            set => row["returnPos"].Value = value;
        }

        // Unknown.
        public int reactionId
        {
            get => (int)row["reactionId"].Value;
            set => row["reactionId"].Value = value;
        }

        // Unknown.
        public int eventId
        {
            get => (int)row["eventId"].Value;
            set => row["eventId"].Value = value;
        }

        // Unknown.
        public int msgId_female
        {
            get => (int)row["msgId_female"].Value;
            set => row["msgId_female"].Value = value;
        }

        // Unknown.
        public int voiceId_female
        {
            get => (int)row["voiceId_female"].Value;
            set => row["voiceId_female"].Value = value;
        }

        // Unknown.
        public short lipSyncStart
        {
            get => (short)row["lipSyncStart"].Value;
            set => row["lipSyncStart"].Value = value;
        }

        // Unknown.
        public short lipSyncTime
        {
            get => (short)row["lipSyncTime"].Value;
            set => row["lipSyncTime"].Value = value;
        }

        // Unknown.
        public float timeout
        {
            get => (float)row["timeout"].Value;
            set => row["timeout"].Value = value;
        }

        // Unknown.
        public int talkAnimationId
        {
            get => (int)row["talkAnimationId"].Value;
            set => row["talkAnimationId"].Value = value;
        }

        // Unknown.
        public byte isForceDisp
        {
            get => (byte)row["isForceDisp"].Value;
            set => row["isForceDisp"].Value = value;
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
    public TALK_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public TALK_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
