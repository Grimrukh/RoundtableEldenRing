using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class SOUND_AUTO_REVERB_SELECT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public uint reverbType
        {
            get => (uint)row["reverbType"].Value;
            set => row["reverbType"].Value = value;
        }

        // Unknown.
        public int AreaNo
        {
            get => (int)row["AreaNo"].Value;
            set => row["AreaNo"].Value = value;
        }

        // Unknown.
        public sbyte IndoorOutdoor
        {
            get => (sbyte)row["IndoorOutdoor"].Value;
            set => row["IndoorOutdoor"].Value = value;
        }

        // Unknown.
        public sbyte useDistNoA
        {
            get => (sbyte)row["useDistNoA"].Value;
            set => row["useDistNoA"].Value = value;
        }

        // Unknown.
        public sbyte useDistNoB
        {
            get => (sbyte)row["useDistNoB"].Value;
            set => row["useDistNoB"].Value = value;
        }

        // Unknown.
        public float DistMinA
        {
            get => (float)row["DistMinA"].Value;
            set => row["DistMinA"].Value = value;
        }

        // Unknown.
        public float DistMaxA
        {
            get => (float)row["DistMaxA"].Value;
            set => row["DistMaxA"].Value = value;
        }

        // Unknown.
        public float DistMinB
        {
            get => (float)row["DistMinB"].Value;
            set => row["DistMinB"].Value = value;
        }

        // Unknown.
        public float DistMaxB
        {
            get => (float)row["DistMaxB"].Value;
            set => row["DistMaxB"].Value = value;
        }

        // Unknown.
        public int NoHitNumMin
        {
            get => (int)row["NoHitNumMin"].Value;
            set => row["NoHitNumMin"].Value = value;
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
    public SOUND_AUTO_REVERB_SELECT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SOUND_AUTO_REVERB_SELECT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
