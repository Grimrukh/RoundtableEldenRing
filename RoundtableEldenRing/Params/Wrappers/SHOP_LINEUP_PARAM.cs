using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class SHOP_LINEUP_PARAM
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int equipId
        {
            get => (int)row["equipId"].Value;
            set => row["equipId"].Value = value;
        }

        // Unknown.
        public int value
        {
            get => (int)row["value"].Value;
            set => row["value"].Value = value;
        }

        // Unknown.
        public int mtrlId
        {
            get => (int)row["mtrlId"].Value;
            set => row["mtrlId"].Value = value;
        }

        // Unknown.
        public uint eventFlag_forStock
        {
            get => (uint)row["eventFlag_forStock"].Value;
            set => row["eventFlag_forStock"].Value = value;
        }

        // Unknown.
        public uint eventFlag_forRelease
        {
            get => (uint)row["eventFlag_forRelease"].Value;
            set => row["eventFlag_forRelease"].Value = value;
        }

        // Unknown.
        public short sellQuantity
        {
            get => (short)row["sellQuantity"].Value;
            set => row["sellQuantity"].Value = value;
        }

        // Unknown.
        public byte equipType
        {
            get => (byte)row["equipType"].Value;
            set => row["equipType"].Value = value;
        }

        // Unknown.
        public byte costType
        {
            get => (byte)row["costType"].Value;
            set => row["costType"].Value = value;
        }

        // Unknown.
        public ushort setNum
        {
            get => (ushort)row["setNum"].Value;
            set => row["setNum"].Value = value;
        }

        // Unknown.
        public int value_Add
        {
            get => (int)row["value_Add"].Value;
            set => row["value_Add"].Value = value;
        }

        // Unknown.
        public float value_Magnification
        {
            get => (float)row["value_Magnification"].Value;
            set => row["value_Magnification"].Value = value;
        }

        // Unknown.
        public int iconId
        {
            get => (int)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public int nameMsgId
        {
            get => (int)row["nameMsgId"].Value;
            set => row["nameMsgId"].Value = value;
        }

        // Unknown.
        public int menuTitleMsgId
        {
            get => (int)row["menuTitleMsgId"].Value;
            set => row["menuTitleMsgId"].Value = value;
        }

        // Unknown.
        public short menuIconId
        {
            get => (short)row["menuIconId"].Value;
            set => row["menuIconId"].Value = value;
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
    public SHOP_LINEUP_PARAM(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SHOP_LINEUP_PARAM(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
