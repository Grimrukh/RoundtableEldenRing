using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class WEATHER_LOT_PARAM_ST
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
        public short weatherType0
        {
            get => (short)row["weatherType0"].Value;
            set => row["weatherType0"].Value = value;
        }

        // Unknown.
        public short weatherType1
        {
            get => (short)row["weatherType1"].Value;
            set => row["weatherType1"].Value = value;
        }

        // Unknown.
        public short weatherType2
        {
            get => (short)row["weatherType2"].Value;
            set => row["weatherType2"].Value = value;
        }

        // Unknown.
        public short weatherType3
        {
            get => (short)row["weatherType3"].Value;
            set => row["weatherType3"].Value = value;
        }

        // Unknown.
        public short weatherType4
        {
            get => (short)row["weatherType4"].Value;
            set => row["weatherType4"].Value = value;
        }

        // Unknown.
        public short weatherType5
        {
            get => (short)row["weatherType5"].Value;
            set => row["weatherType5"].Value = value;
        }

        // Unknown.
        public short weatherType6
        {
            get => (short)row["weatherType6"].Value;
            set => row["weatherType6"].Value = value;
        }

        // Unknown.
        public short weatherType7
        {
            get => (short)row["weatherType7"].Value;
            set => row["weatherType7"].Value = value;
        }

        // Unknown.
        public short weatherType8
        {
            get => (short)row["weatherType8"].Value;
            set => row["weatherType8"].Value = value;
        }

        // Unknown.
        public short weatherType9
        {
            get => (short)row["weatherType9"].Value;
            set => row["weatherType9"].Value = value;
        }

        // Unknown.
        public short weatherType10
        {
            get => (short)row["weatherType10"].Value;
            set => row["weatherType10"].Value = value;
        }

        // Unknown.
        public short weatherType11
        {
            get => (short)row["weatherType11"].Value;
            set => row["weatherType11"].Value = value;
        }

        // Unknown.
        public short weatherType12
        {
            get => (short)row["weatherType12"].Value;
            set => row["weatherType12"].Value = value;
        }

        // Unknown.
        public short weatherType13
        {
            get => (short)row["weatherType13"].Value;
            set => row["weatherType13"].Value = value;
        }

        // Unknown.
        public short weatherType14
        {
            get => (short)row["weatherType14"].Value;
            set => row["weatherType14"].Value = value;
        }

        // Unknown.
        public short weatherType15
        {
            get => (short)row["weatherType15"].Value;
            set => row["weatherType15"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight0
        {
            get => (ushort)row["lotteryWeight0"].Value;
            set => row["lotteryWeight0"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight1
        {
            get => (ushort)row["lotteryWeight1"].Value;
            set => row["lotteryWeight1"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight2
        {
            get => (ushort)row["lotteryWeight2"].Value;
            set => row["lotteryWeight2"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight3
        {
            get => (ushort)row["lotteryWeight3"].Value;
            set => row["lotteryWeight3"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight4
        {
            get => (ushort)row["lotteryWeight4"].Value;
            set => row["lotteryWeight4"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight5
        {
            get => (ushort)row["lotteryWeight5"].Value;
            set => row["lotteryWeight5"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight6
        {
            get => (ushort)row["lotteryWeight6"].Value;
            set => row["lotteryWeight6"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight7
        {
            get => (ushort)row["lotteryWeight7"].Value;
            set => row["lotteryWeight7"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight8
        {
            get => (ushort)row["lotteryWeight8"].Value;
            set => row["lotteryWeight8"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight9
        {
            get => (ushort)row["lotteryWeight9"].Value;
            set => row["lotteryWeight9"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight10
        {
            get => (ushort)row["lotteryWeight10"].Value;
            set => row["lotteryWeight10"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight11
        {
            get => (ushort)row["lotteryWeight11"].Value;
            set => row["lotteryWeight11"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight12
        {
            get => (ushort)row["lotteryWeight12"].Value;
            set => row["lotteryWeight12"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight13
        {
            get => (ushort)row["lotteryWeight13"].Value;
            set => row["lotteryWeight13"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight14
        {
            get => (ushort)row["lotteryWeight14"].Value;
            set => row["lotteryWeight14"].Value = value;
        }

        // Unknown.
        public ushort lotteryWeight15
        {
            get => (ushort)row["lotteryWeight15"].Value;
            set => row["lotteryWeight15"].Value = value;
        }

        // Unknown.
        public byte timezoneLimit
        {
            get => (byte)row["timezoneLimit"].Value;
            set => row["timezoneLimit"].Value = value;
        }

        // Unknown.
        public byte timezoneStartHour
        {
            get => (byte)row["timezoneStartHour"].Value;
            set => row["timezoneStartHour"].Value = value;
        }

        // Unknown.
        public byte timezoneStartMinute
        {
            get => (byte)row["timezoneStartMinute"].Value;
            set => row["timezoneStartMinute"].Value = value;
        }

        // Unknown.
        public byte timezoneEndHour
        {
            get => (byte)row["timezoneEndHour"].Value;
            set => row["timezoneEndHour"].Value = value;
        }

        // Unknown.
        public byte timezoneEndMinute
        {
            get => (byte)row["timezoneEndMinute"].Value;
            set => row["timezoneEndMinute"].Value = value;
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
    public WEATHER_LOT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WEATHER_LOT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
