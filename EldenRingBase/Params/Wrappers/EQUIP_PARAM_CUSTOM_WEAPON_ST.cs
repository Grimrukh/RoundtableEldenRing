using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class EQUIP_PARAM_CUSTOM_WEAPON_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int baseWepId
        {
            get => (int)row["baseWepId"].Value;
            set => row["baseWepId"].Value = value;
        }

        // Unknown.
        public int gemId
        {
            get => (int)row["gemId"].Value;
            set => row["gemId"].Value = value;
        }

        // Unknown.
        public byte reinforceLv
        {
            get => (byte)row["reinforceLv"].Value;
            set => row["reinforceLv"].Value = value;
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
    public EQUIP_PARAM_CUSTOM_WEAPON_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public EQUIP_PARAM_CUSTOM_WEAPON_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
