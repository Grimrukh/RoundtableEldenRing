using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class HIT_MTRL_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float aiVolumeRate
        {
            get => (float)row["aiVolumeRate"].Value;
            set => row["aiVolumeRate"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0
        {
            get => (int)row["spEffectIdOnHit0"].Value;
            set => row["spEffectIdOnHit0"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1
        {
            get => (int)row["spEffectIdOnHit1"].Value;
            set => row["spEffectIdOnHit1"].Value = value;
        }

        // Unknown.
        public byte footEffectHeightType
        {
            get => (byte)row["footEffectHeightType"].Value;
            set => row["footEffectHeightType"].Value = value;
        }

        // Unknown.
        public byte footEffectDirType
        {
            get => (byte)row["footEffectDirType"].Value;
            set => row["footEffectDirType"].Value = value;
        }

        // Unknown.
        public byte floorHeightType
        {
            get => (byte)row["floorHeightType"].Value;
            set => row["floorHeightType"].Value = value;
        }

        // Unknown.
        public byte disableFallDamage
        {
            get => (byte)row["disableFallDamage"].Value;
            set => row["disableFallDamage"].Value = value;
        }

        // Unknown.
        public byte isHardnessForSoundReverb
        {
            get => (byte)row["isHardnessForSoundReverb"].Value;
            set => row["isHardnessForSoundReverb"].Value = value;
        }

        // Unknown.
        public byte hardnessType
        {
            get => (byte)row["hardnessType"].Value;
            set => row["hardnessType"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0_ClearCount_2
        {
            get => (int)row["spEffectIdOnHit0_ClearCount_2"].Value;
            set => row["spEffectIdOnHit0_ClearCount_2"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0_ClearCount_3
        {
            get => (int)row["spEffectIdOnHit0_ClearCount_3"].Value;
            set => row["spEffectIdOnHit0_ClearCount_3"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0_ClearCount_4
        {
            get => (int)row["spEffectIdOnHit0_ClearCount_4"].Value;
            set => row["spEffectIdOnHit0_ClearCount_4"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0_ClearCount_5
        {
            get => (int)row["spEffectIdOnHit0_ClearCount_5"].Value;
            set => row["spEffectIdOnHit0_ClearCount_5"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0_ClearCount_6
        {
            get => (int)row["spEffectIdOnHit0_ClearCount_6"].Value;
            set => row["spEffectIdOnHit0_ClearCount_6"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0_ClearCount_7
        {
            get => (int)row["spEffectIdOnHit0_ClearCount_7"].Value;
            set => row["spEffectIdOnHit0_ClearCount_7"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit0_ClearCount_8
        {
            get => (int)row["spEffectIdOnHit0_ClearCount_8"].Value;
            set => row["spEffectIdOnHit0_ClearCount_8"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1_ClearCount_2
        {
            get => (int)row["spEffectIdOnHit1_ClearCount_2"].Value;
            set => row["spEffectIdOnHit1_ClearCount_2"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1_ClearCount_3
        {
            get => (int)row["spEffectIdOnHit1_ClearCount_3"].Value;
            set => row["spEffectIdOnHit1_ClearCount_3"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1_ClearCount_4
        {
            get => (int)row["spEffectIdOnHit1_ClearCount_4"].Value;
            set => row["spEffectIdOnHit1_ClearCount_4"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1_ClearCount_5
        {
            get => (int)row["spEffectIdOnHit1_ClearCount_5"].Value;
            set => row["spEffectIdOnHit1_ClearCount_5"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1_ClearCount_6
        {
            get => (int)row["spEffectIdOnHit1_ClearCount_6"].Value;
            set => row["spEffectIdOnHit1_ClearCount_6"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1_ClearCount_7
        {
            get => (int)row["spEffectIdOnHit1_ClearCount_7"].Value;
            set => row["spEffectIdOnHit1_ClearCount_7"].Value = value;
        }

        // Unknown.
        public int spEffectIdOnHit1_ClearCount_8
        {
            get => (int)row["spEffectIdOnHit1_ClearCount_8"].Value;
            set => row["spEffectIdOnHit1_ClearCount_8"].Value = value;
        }

        // Unknown.
        public short replaceMateiralId_Rain
        {
            get => (short)row["replaceMateiralId_Rain"].Value;
            set => row["replaceMateiralId_Rain"].Value = value;
        }

        // Unknown.
        public int spEffectId_forWet00
        {
            get => (int)row["spEffectId_forWet00"].Value;
            set => row["spEffectId_forWet00"].Value = value;
        }

        // Unknown.
        public int spEffectId_forWet01
        {
            get => (int)row["spEffectId_forWet01"].Value;
            set => row["spEffectId_forWet01"].Value = value;
        }

        // Unknown.
        public int spEffectId_forWet02
        {
            get => (int)row["spEffectId_forWet02"].Value;
            set => row["spEffectId_forWet02"].Value = value;
        }

        // Unknown.
        public int spEffectId_forWet03
        {
            get => (int)row["spEffectId_forWet03"].Value;
            set => row["spEffectId_forWet03"].Value = value;
        }

        // Unknown.
        public int spEffectId_forWet04
        {
            get => (int)row["spEffectId_forWet04"].Value;
            set => row["spEffectId_forWet04"].Value = value;
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
    public HIT_MTRL_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public HIT_MTRL_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
