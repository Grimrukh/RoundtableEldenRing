using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class EQUIP_MTRL_SET_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int materialId01
        {
            get => (int)row["materialId01"].Value;
            set => row["materialId01"].Value = value;
        }

        // Unknown.
        public int materialId02
        {
            get => (int)row["materialId02"].Value;
            set => row["materialId02"].Value = value;
        }

        // Unknown.
        public int materialId03
        {
            get => (int)row["materialId03"].Value;
            set => row["materialId03"].Value = value;
        }

        // Unknown.
        public int materialId04
        {
            get => (int)row["materialId04"].Value;
            set => row["materialId04"].Value = value;
        }

        // Unknown.
        public int materialId05
        {
            get => (int)row["materialId05"].Value;
            set => row["materialId05"].Value = value;
        }

        // Unknown.
        public int materialId06
        {
            get => (int)row["materialId06"].Value;
            set => row["materialId06"].Value = value;
        }

        // Unknown.
        public sbyte itemNum01
        {
            get => (sbyte)row["itemNum01"].Value;
            set => row["itemNum01"].Value = value;
        }

        // Unknown.
        public sbyte itemNum02
        {
            get => (sbyte)row["itemNum02"].Value;
            set => row["itemNum02"].Value = value;
        }

        // Unknown.
        public sbyte itemNum03
        {
            get => (sbyte)row["itemNum03"].Value;
            set => row["itemNum03"].Value = value;
        }

        // Unknown.
        public sbyte itemNum04
        {
            get => (sbyte)row["itemNum04"].Value;
            set => row["itemNum04"].Value = value;
        }

        // Unknown.
        public sbyte itemNum05
        {
            get => (sbyte)row["itemNum05"].Value;
            set => row["itemNum05"].Value = value;
        }

        // Unknown.
        public sbyte itemNum06
        {
            get => (sbyte)row["itemNum06"].Value;
            set => row["itemNum06"].Value = value;
        }

        // Unknown.
        public byte materialCate01
        {
            get => (byte)row["materialCate01"].Value;
            set => row["materialCate01"].Value = value;
        }

        // Unknown.
        public byte materialCate02
        {
            get => (byte)row["materialCate02"].Value;
            set => row["materialCate02"].Value = value;
        }

        // Unknown.
        public byte materialCate03
        {
            get => (byte)row["materialCate03"].Value;
            set => row["materialCate03"].Value = value;
        }

        // Unknown.
        public byte materialCate04
        {
            get => (byte)row["materialCate04"].Value;
            set => row["materialCate04"].Value = value;
        }

        // Unknown.
        public byte materialCate05
        {
            get => (byte)row["materialCate05"].Value;
            set => row["materialCate05"].Value = value;
        }

        // Unknown.
        public byte materialCate06
        {
            get => (byte)row["materialCate06"].Value;
            set => row["materialCate06"].Value = value;
        }

        // Unknown.
        public byte isDisableDispNum01
        {
            get => (byte)row["isDisableDispNum01"].Value;
            set => row["isDisableDispNum01"].Value = value;
        }

        // Unknown.
        public byte isDisableDispNum02
        {
            get => (byte)row["isDisableDispNum02"].Value;
            set => row["isDisableDispNum02"].Value = value;
        }

        // Unknown.
        public byte isDisableDispNum03
        {
            get => (byte)row["isDisableDispNum03"].Value;
            set => row["isDisableDispNum03"].Value = value;
        }

        // Unknown.
        public byte isDisableDispNum04
        {
            get => (byte)row["isDisableDispNum04"].Value;
            set => row["isDisableDispNum04"].Value = value;
        }

        // Unknown.
        public byte isDisableDispNum05
        {
            get => (byte)row["isDisableDispNum05"].Value;
            set => row["isDisableDispNum05"].Value = value;
        }

        // Unknown.
        public byte isDisableDispNum06
        {
            get => (byte)row["isDisableDispNum06"].Value;
            set => row["isDisableDispNum06"].Value = value;
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
    public EQUIP_MTRL_SET_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public EQUIP_MTRL_SET_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
