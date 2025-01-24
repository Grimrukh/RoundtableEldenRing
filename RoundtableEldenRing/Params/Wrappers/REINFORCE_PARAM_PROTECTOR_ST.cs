using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class REINFORCE_PARAM_PROTECTOR_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float physicsDefRate
        {
            get => (float)row["physicsDefRate"].Value;
            set => row["physicsDefRate"].Value = value;
        }

        // Unknown.
        public float magicDefRate
        {
            get => (float)row["magicDefRate"].Value;
            set => row["magicDefRate"].Value = value;
        }

        // Unknown.
        public float fireDefRate
        {
            get => (float)row["fireDefRate"].Value;
            set => row["fireDefRate"].Value = value;
        }

        // Unknown.
        public float thunderDefRate
        {
            get => (float)row["thunderDefRate"].Value;
            set => row["thunderDefRate"].Value = value;
        }

        // Unknown.
        public float slashDefRate
        {
            get => (float)row["slashDefRate"].Value;
            set => row["slashDefRate"].Value = value;
        }

        // Unknown.
        public float blowDefRate
        {
            get => (float)row["blowDefRate"].Value;
            set => row["blowDefRate"].Value = value;
        }

        // Unknown.
        public float thrustDefRate
        {
            get => (float)row["thrustDefRate"].Value;
            set => row["thrustDefRate"].Value = value;
        }

        // Unknown.
        public float resistPoisonRate
        {
            get => (float)row["resistPoisonRate"].Value;
            set => row["resistPoisonRate"].Value = value;
        }

        // Unknown.
        public float resistDiseaseRate
        {
            get => (float)row["resistDiseaseRate"].Value;
            set => row["resistDiseaseRate"].Value = value;
        }

        // Unknown.
        public float resistBloodRate
        {
            get => (float)row["resistBloodRate"].Value;
            set => row["resistBloodRate"].Value = value;
        }

        // Unknown.
        public float resistCurseRate
        {
            get => (float)row["resistCurseRate"].Value;
            set => row["resistCurseRate"].Value = value;
        }

        // Unknown.
        public byte residentSpEffectId1
        {
            get => (byte)row["residentSpEffectId1"].Value;
            set => row["residentSpEffectId1"].Value = value;
        }

        // Unknown.
        public byte residentSpEffectId2
        {
            get => (byte)row["residentSpEffectId2"].Value;
            set => row["residentSpEffectId2"].Value = value;
        }

        // Unknown.
        public byte residentSpEffectId3
        {
            get => (byte)row["residentSpEffectId3"].Value;
            set => row["residentSpEffectId3"].Value = value;
        }

        // Unknown.
        public byte materialSetId
        {
            get => (byte)row["materialSetId"].Value;
            set => row["materialSetId"].Value = value;
        }

        // Unknown.
        public float darkDefRate
        {
            get => (float)row["darkDefRate"].Value;
            set => row["darkDefRate"].Value = value;
        }

        // Unknown.
        public float resistFreezeRate
        {
            get => (float)row["resistFreezeRate"].Value;
            set => row["resistFreezeRate"].Value = value;
        }

        // Unknown.
        public float resistSleepRate
        {
            get => (float)row["resistSleepRate"].Value;
            set => row["resistSleepRate"].Value = value;
        }

        // Unknown.
        public float resistMadnessRate
        {
            get => (float)row["resistMadnessRate"].Value;
            set => row["resistMadnessRate"].Value = value;
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
    public REINFORCE_PARAM_PROTECTOR_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public REINFORCE_PARAM_PROTECTOR_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
