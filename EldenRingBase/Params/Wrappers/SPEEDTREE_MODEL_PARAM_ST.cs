using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class SPEEDTREE_MODEL_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        public float MinFadeLeaf
        {
            get => (float)row["MinFadeLeaf"].Value;
            set => row["MinFadeLeaf"].Value = value;
        }

        public float MinFadeFrond
        {
            get => (float)row["MinFadeFrond"].Value;
            set => row["MinFadeFrond"].Value = value;
        }

        public float MinFadeBranch
        {
            get => (float)row["MinFadeBranch"].Value;
            set => row["MinFadeBranch"].Value = value;
        }

        public float MinTranslucencyLeaf
        {
            get => (float)row["MinTranslucencyLeaf"].Value;
            set => row["MinTranslucencyLeaf"].Value = value;
        }

        public float MaxTranslucencyLeaf
        {
            get => (float)row["MaxTranslucencyLeaf"].Value;
            set => row["MaxTranslucencyLeaf"].Value = value;
        }

        public float MinTranslucencyFrond
        {
            get => (float)row["MinTranslucencyFrond"].Value;
            set => row["MinTranslucencyFrond"].Value = value;
        }

        public float MaxTranslucencyFrond
        {
            get => (float)row["MaxTranslucencyFrond"].Value;
            set => row["MaxTranslucencyFrond"].Value = value;
        }

        public float MinTranslucencyBranch
        {
            get => (float)row["MinTranslucencyBranch"].Value;
            set => row["MinTranslucencyBranch"].Value = value;
        }

        public float MaxTranslucencyBranch
        {
            get => (float)row["MaxTranslucencyBranch"].Value;
            set => row["MaxTranslucencyBranch"].Value = value;
        }

        public float BillboardBackSpecularWeakenParam
        {
            get => (float)row["BillboardBackSpecularWeakenParam"].Value;
            set => row["BillboardBackSpecularWeakenParam"].Value = value;
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
    public SPEEDTREE_MODEL_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SPEEDTREE_MODEL_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
