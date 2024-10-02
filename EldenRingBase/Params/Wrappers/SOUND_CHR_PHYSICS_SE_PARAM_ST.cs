using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class SOUND_CHR_PHYSICS_SE_PARAM_ST
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
        public int ContactLandSeId
        {
            get => (int)row["ContactLandSeId"].Value;
            set => row["ContactLandSeId"].Value = value;
        }

        // Unknown.
        public int ContactLandAddSeId
        {
            get => (int)row["ContactLandAddSeId"].Value;
            set => row["ContactLandAddSeId"].Value = value;
        }

        // Unknown.
        public int ContactLandPlayNum
        {
            get => (int)row["ContactLandPlayNum"].Value;
            set => row["ContactLandPlayNum"].Value = value;
        }

        // Unknown.
        public byte IsEnablePlayCountPerRigid
        {
            get => (byte)row["IsEnablePlayCountPerRigid"].Value;
            set => row["IsEnablePlayCountPerRigid"].Value = value;
        }

        // Unknown.
        public float ContactLandMinImpuse
        {
            get => (float)row["ContactLandMinImpuse"].Value;
            set => row["ContactLandMinImpuse"].Value = value;
        }

        // Unknown.
        public float ContactLandMinSpeed
        {
            get => (float)row["ContactLandMinSpeed"].Value;
            set => row["ContactLandMinSpeed"].Value = value;
        }

        // Unknown.
        public int ContactPlayerSeId
        {
            get => (int)row["ContactPlayerSeId"].Value;
            set => row["ContactPlayerSeId"].Value = value;
        }

        // Unknown.
        public float ContactPlayerMinImpuse
        {
            get => (float)row["ContactPlayerMinImpuse"].Value;
            set => row["ContactPlayerMinImpuse"].Value = value;
        }

        // Unknown.
        public float ContactPlayerMinSpeed
        {
            get => (float)row["ContactPlayerMinSpeed"].Value;
            set => row["ContactPlayerMinSpeed"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx0
        {
            get => (sbyte)row["ContactCheckRigidIdx0"].Value;
            set => row["ContactCheckRigidIdx0"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx1
        {
            get => (sbyte)row["ContactCheckRigidIdx1"].Value;
            set => row["ContactCheckRigidIdx1"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx2
        {
            get => (sbyte)row["ContactCheckRigidIdx2"].Value;
            set => row["ContactCheckRigidIdx2"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx3
        {
            get => (sbyte)row["ContactCheckRigidIdx3"].Value;
            set => row["ContactCheckRigidIdx3"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx4
        {
            get => (sbyte)row["ContactCheckRigidIdx4"].Value;
            set => row["ContactCheckRigidIdx4"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx5
        {
            get => (sbyte)row["ContactCheckRigidIdx5"].Value;
            set => row["ContactCheckRigidIdx5"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx6
        {
            get => (sbyte)row["ContactCheckRigidIdx6"].Value;
            set => row["ContactCheckRigidIdx6"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx7
        {
            get => (sbyte)row["ContactCheckRigidIdx7"].Value;
            set => row["ContactCheckRigidIdx7"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx8
        {
            get => (sbyte)row["ContactCheckRigidIdx8"].Value;
            set => row["ContactCheckRigidIdx8"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx9
        {
            get => (sbyte)row["ContactCheckRigidIdx9"].Value;
            set => row["ContactCheckRigidIdx9"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx10
        {
            get => (sbyte)row["ContactCheckRigidIdx10"].Value;
            set => row["ContactCheckRigidIdx10"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx11
        {
            get => (sbyte)row["ContactCheckRigidIdx11"].Value;
            set => row["ContactCheckRigidIdx11"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx12
        {
            get => (sbyte)row["ContactCheckRigidIdx12"].Value;
            set => row["ContactCheckRigidIdx12"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx13
        {
            get => (sbyte)row["ContactCheckRigidIdx13"].Value;
            set => row["ContactCheckRigidIdx13"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx14
        {
            get => (sbyte)row["ContactCheckRigidIdx14"].Value;
            set => row["ContactCheckRigidIdx14"].Value = value;
        }

        // Unknown.
        public sbyte ContactCheckRigidIdx15
        {
            get => (sbyte)row["ContactCheckRigidIdx15"].Value;
            set => row["ContactCheckRigidIdx15"].Value = value;
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
    public SOUND_CHR_PHYSICS_SE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SOUND_CHR_PHYSICS_SE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
