using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class BUDDY_STONE_PARAM_ST
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
        public uint talkChrEntityId
        {
            get => (uint)row["talkChrEntityId"].Value;
            set => row["talkChrEntityId"].Value = value;
        }

        // Unknown.
        public uint eliminateTargetEntityId
        {
            get => (uint)row["eliminateTargetEntityId"].Value;
            set => row["eliminateTargetEntityId"].Value = value;
        }

        // Unknown.
        public uint summonedEventFlagId
        {
            get => (uint)row["summonedEventFlagId"].Value;
            set => row["summonedEventFlagId"].Value = value;
        }

        // Unknown.
        public byte isSpecial
        {
            get => (byte)row["isSpecial"].Value;
            set => row["isSpecial"].Value = value;
        }

        // Unknown.
        public int buddyId
        {
            get => (int)row["buddyId"].Value;
            set => row["buddyId"].Value = value;
        }

        // Unknown.
        public int dopingSpEffectId
        {
            get => (int)row["dopingSpEffectId"].Value;
            set => row["dopingSpEffectId"].Value = value;
        }

        // Unknown.
        public ushort activateRange
        {
            get => (ushort)row["activateRange"].Value;
            set => row["activateRange"].Value = value;
        }

        // Unknown.
        public short overwriteReturnRange
        {
            get => (short)row["overwriteReturnRange"].Value;
            set => row["overwriteReturnRange"].Value = value;
        }

        // Unknown.
        public uint overwriteActivateRegionEntityId
        {
            get => (uint)row["overwriteActivateRegionEntityId"].Value;
            set => row["overwriteActivateRegionEntityId"].Value = value;
        }

        // Unknown.
        public uint warnRegionEntityId
        {
            get => (uint)row["warnRegionEntityId"].Value;
            set => row["warnRegionEntityId"].Value = value;
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
    public BUDDY_STONE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public BUDDY_STONE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
