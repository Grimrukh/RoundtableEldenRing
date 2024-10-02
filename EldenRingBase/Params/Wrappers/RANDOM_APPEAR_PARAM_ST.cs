using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class RANDOM_APPEAR_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte slot0
        {
            get => (byte)row["slot0"].Value;
            set => row["slot0"].Value = value;
        }

        // Unknown.
        public byte slot1
        {
            get => (byte)row["slot1"].Value;
            set => row["slot1"].Value = value;
        }

        // Unknown.
        public byte slot2
        {
            get => (byte)row["slot2"].Value;
            set => row["slot2"].Value = value;
        }

        // Unknown.
        public byte slot3
        {
            get => (byte)row["slot3"].Value;
            set => row["slot3"].Value = value;
        }

        // Unknown.
        public byte slot4
        {
            get => (byte)row["slot4"].Value;
            set => row["slot4"].Value = value;
        }

        // Unknown.
        public byte slot5
        {
            get => (byte)row["slot5"].Value;
            set => row["slot5"].Value = value;
        }

        // Unknown.
        public byte slot6
        {
            get => (byte)row["slot6"].Value;
            set => row["slot6"].Value = value;
        }

        // Unknown.
        public byte slot7
        {
            get => (byte)row["slot7"].Value;
            set => row["slot7"].Value = value;
        }

        // Unknown.
        public byte slot8
        {
            get => (byte)row["slot8"].Value;
            set => row["slot8"].Value = value;
        }

        // Unknown.
        public byte slot9
        {
            get => (byte)row["slot9"].Value;
            set => row["slot9"].Value = value;
        }

        // Unknown.
        public byte slot10
        {
            get => (byte)row["slot10"].Value;
            set => row["slot10"].Value = value;
        }

        // Unknown.
        public byte slot11
        {
            get => (byte)row["slot11"].Value;
            set => row["slot11"].Value = value;
        }

        // Unknown.
        public byte slot12
        {
            get => (byte)row["slot12"].Value;
            set => row["slot12"].Value = value;
        }

        // Unknown.
        public byte slot13
        {
            get => (byte)row["slot13"].Value;
            set => row["slot13"].Value = value;
        }

        // Unknown.
        public byte slot14
        {
            get => (byte)row["slot14"].Value;
            set => row["slot14"].Value = value;
        }

        // Unknown.
        public byte slot15
        {
            get => (byte)row["slot15"].Value;
            set => row["slot15"].Value = value;
        }

        // Unknown.
        public byte slot16
        {
            get => (byte)row["slot16"].Value;
            set => row["slot16"].Value = value;
        }

        // Unknown.
        public byte slot17
        {
            get => (byte)row["slot17"].Value;
            set => row["slot17"].Value = value;
        }

        // Unknown.
        public byte slot18
        {
            get => (byte)row["slot18"].Value;
            set => row["slot18"].Value = value;
        }

        // Unknown.
        public byte slot19
        {
            get => (byte)row["slot19"].Value;
            set => row["slot19"].Value = value;
        }

        // Unknown.
        public byte slot20
        {
            get => (byte)row["slot20"].Value;
            set => row["slot20"].Value = value;
        }

        // Unknown.
        public byte slot21
        {
            get => (byte)row["slot21"].Value;
            set => row["slot21"].Value = value;
        }

        // Unknown.
        public byte slot22
        {
            get => (byte)row["slot22"].Value;
            set => row["slot22"].Value = value;
        }

        // Unknown.
        public byte slot23
        {
            get => (byte)row["slot23"].Value;
            set => row["slot23"].Value = value;
        }

        // Unknown.
        public byte slot24
        {
            get => (byte)row["slot24"].Value;
            set => row["slot24"].Value = value;
        }

        // Unknown.
        public byte slot25
        {
            get => (byte)row["slot25"].Value;
            set => row["slot25"].Value = value;
        }

        // Unknown.
        public byte slot26
        {
            get => (byte)row["slot26"].Value;
            set => row["slot26"].Value = value;
        }

        // Unknown.
        public byte slot27
        {
            get => (byte)row["slot27"].Value;
            set => row["slot27"].Value = value;
        }

        // Unknown.
        public byte slot28
        {
            get => (byte)row["slot28"].Value;
            set => row["slot28"].Value = value;
        }

        // Unknown.
        public byte slot29
        {
            get => (byte)row["slot29"].Value;
            set => row["slot29"].Value = value;
        }

        // Unknown.
        public byte slot30
        {
            get => (byte)row["slot30"].Value;
            set => row["slot30"].Value = value;
        }

        // Unknown.
        public byte slot31
        {
            get => (byte)row["slot31"].Value;
            set => row["slot31"].Value = value;
        }

        // Unknown.
        public byte slot32
        {
            get => (byte)row["slot32"].Value;
            set => row["slot32"].Value = value;
        }

        // Unknown.
        public byte slot33
        {
            get => (byte)row["slot33"].Value;
            set => row["slot33"].Value = value;
        }

        // Unknown.
        public byte slot34
        {
            get => (byte)row["slot34"].Value;
            set => row["slot34"].Value = value;
        }

        // Unknown.
        public byte slot35
        {
            get => (byte)row["slot35"].Value;
            set => row["slot35"].Value = value;
        }

        // Unknown.
        public byte slot36
        {
            get => (byte)row["slot36"].Value;
            set => row["slot36"].Value = value;
        }

        // Unknown.
        public byte slot37
        {
            get => (byte)row["slot37"].Value;
            set => row["slot37"].Value = value;
        }

        // Unknown.
        public byte slot38
        {
            get => (byte)row["slot38"].Value;
            set => row["slot38"].Value = value;
        }

        // Unknown.
        public byte slot39
        {
            get => (byte)row["slot39"].Value;
            set => row["slot39"].Value = value;
        }

        // Unknown.
        public byte slot40
        {
            get => (byte)row["slot40"].Value;
            set => row["slot40"].Value = value;
        }

        // Unknown.
        public byte slot41
        {
            get => (byte)row["slot41"].Value;
            set => row["slot41"].Value = value;
        }

        // Unknown.
        public byte slot42
        {
            get => (byte)row["slot42"].Value;
            set => row["slot42"].Value = value;
        }

        // Unknown.
        public byte slot43
        {
            get => (byte)row["slot43"].Value;
            set => row["slot43"].Value = value;
        }

        // Unknown.
        public byte slot44
        {
            get => (byte)row["slot44"].Value;
            set => row["slot44"].Value = value;
        }

        // Unknown.
        public byte slot45
        {
            get => (byte)row["slot45"].Value;
            set => row["slot45"].Value = value;
        }

        // Unknown.
        public byte slot46
        {
            get => (byte)row["slot46"].Value;
            set => row["slot46"].Value = value;
        }

        // Unknown.
        public byte slot47
        {
            get => (byte)row["slot47"].Value;
            set => row["slot47"].Value = value;
        }

        // Unknown.
        public byte slot48
        {
            get => (byte)row["slot48"].Value;
            set => row["slot48"].Value = value;
        }

        // Unknown.
        public byte slot49
        {
            get => (byte)row["slot49"].Value;
            set => row["slot49"].Value = value;
        }

        // Unknown.
        public byte slot50
        {
            get => (byte)row["slot50"].Value;
            set => row["slot50"].Value = value;
        }

        // Unknown.
        public byte slot51
        {
            get => (byte)row["slot51"].Value;
            set => row["slot51"].Value = value;
        }

        // Unknown.
        public byte slot52
        {
            get => (byte)row["slot52"].Value;
            set => row["slot52"].Value = value;
        }

        // Unknown.
        public byte slot53
        {
            get => (byte)row["slot53"].Value;
            set => row["slot53"].Value = value;
        }

        // Unknown.
        public byte slot54
        {
            get => (byte)row["slot54"].Value;
            set => row["slot54"].Value = value;
        }

        // Unknown.
        public byte slot55
        {
            get => (byte)row["slot55"].Value;
            set => row["slot55"].Value = value;
        }

        // Unknown.
        public byte slot56
        {
            get => (byte)row["slot56"].Value;
            set => row["slot56"].Value = value;
        }

        // Unknown.
        public byte slot57
        {
            get => (byte)row["slot57"].Value;
            set => row["slot57"].Value = value;
        }

        // Unknown.
        public byte slot58
        {
            get => (byte)row["slot58"].Value;
            set => row["slot58"].Value = value;
        }

        // Unknown.
        public byte slot59
        {
            get => (byte)row["slot59"].Value;
            set => row["slot59"].Value = value;
        }

        // Unknown.
        public byte slot60
        {
            get => (byte)row["slot60"].Value;
            set => row["slot60"].Value = value;
        }

        // Unknown.
        public byte slot61
        {
            get => (byte)row["slot61"].Value;
            set => row["slot61"].Value = value;
        }

        // Unknown.
        public byte slot62
        {
            get => (byte)row["slot62"].Value;
            set => row["slot62"].Value = value;
        }

        // Unknown.
        public byte slot63
        {
            get => (byte)row["slot63"].Value;
            set => row["slot63"].Value = value;
        }

        // Unknown.
        public byte slot64
        {
            get => (byte)row["slot64"].Value;
            set => row["slot64"].Value = value;
        }

        // Unknown.
        public byte slot65
        {
            get => (byte)row["slot65"].Value;
            set => row["slot65"].Value = value;
        }

        // Unknown.
        public byte slot66
        {
            get => (byte)row["slot66"].Value;
            set => row["slot66"].Value = value;
        }

        // Unknown.
        public byte slot67
        {
            get => (byte)row["slot67"].Value;
            set => row["slot67"].Value = value;
        }

        // Unknown.
        public byte slot68
        {
            get => (byte)row["slot68"].Value;
            set => row["slot68"].Value = value;
        }

        // Unknown.
        public byte slot69
        {
            get => (byte)row["slot69"].Value;
            set => row["slot69"].Value = value;
        }

        // Unknown.
        public byte slot70
        {
            get => (byte)row["slot70"].Value;
            set => row["slot70"].Value = value;
        }

        // Unknown.
        public byte slot71
        {
            get => (byte)row["slot71"].Value;
            set => row["slot71"].Value = value;
        }

        // Unknown.
        public byte slot72
        {
            get => (byte)row["slot72"].Value;
            set => row["slot72"].Value = value;
        }

        // Unknown.
        public byte slot73
        {
            get => (byte)row["slot73"].Value;
            set => row["slot73"].Value = value;
        }

        // Unknown.
        public byte slot74
        {
            get => (byte)row["slot74"].Value;
            set => row["slot74"].Value = value;
        }

        // Unknown.
        public byte slot75
        {
            get => (byte)row["slot75"].Value;
            set => row["slot75"].Value = value;
        }

        // Unknown.
        public byte slot76
        {
            get => (byte)row["slot76"].Value;
            set => row["slot76"].Value = value;
        }

        // Unknown.
        public byte slot77
        {
            get => (byte)row["slot77"].Value;
            set => row["slot77"].Value = value;
        }

        // Unknown.
        public byte slot78
        {
            get => (byte)row["slot78"].Value;
            set => row["slot78"].Value = value;
        }

        // Unknown.
        public byte slot79
        {
            get => (byte)row["slot79"].Value;
            set => row["slot79"].Value = value;
        }

        // Unknown.
        public byte slot80
        {
            get => (byte)row["slot80"].Value;
            set => row["slot80"].Value = value;
        }

        // Unknown.
        public byte slot81
        {
            get => (byte)row["slot81"].Value;
            set => row["slot81"].Value = value;
        }

        // Unknown.
        public byte slot82
        {
            get => (byte)row["slot82"].Value;
            set => row["slot82"].Value = value;
        }

        // Unknown.
        public byte slot83
        {
            get => (byte)row["slot83"].Value;
            set => row["slot83"].Value = value;
        }

        // Unknown.
        public byte slot84
        {
            get => (byte)row["slot84"].Value;
            set => row["slot84"].Value = value;
        }

        // Unknown.
        public byte slot85
        {
            get => (byte)row["slot85"].Value;
            set => row["slot85"].Value = value;
        }

        // Unknown.
        public byte slot86
        {
            get => (byte)row["slot86"].Value;
            set => row["slot86"].Value = value;
        }

        // Unknown.
        public byte slot87
        {
            get => (byte)row["slot87"].Value;
            set => row["slot87"].Value = value;
        }

        // Unknown.
        public byte slot88
        {
            get => (byte)row["slot88"].Value;
            set => row["slot88"].Value = value;
        }

        // Unknown.
        public byte slot89
        {
            get => (byte)row["slot89"].Value;
            set => row["slot89"].Value = value;
        }

        // Unknown.
        public byte slot90
        {
            get => (byte)row["slot90"].Value;
            set => row["slot90"].Value = value;
        }

        // Unknown.
        public byte slot91
        {
            get => (byte)row["slot91"].Value;
            set => row["slot91"].Value = value;
        }

        // Unknown.
        public byte slot92
        {
            get => (byte)row["slot92"].Value;
            set => row["slot92"].Value = value;
        }

        // Unknown.
        public byte slot93
        {
            get => (byte)row["slot93"].Value;
            set => row["slot93"].Value = value;
        }

        // Unknown.
        public byte slot94
        {
            get => (byte)row["slot94"].Value;
            set => row["slot94"].Value = value;
        }

        // Unknown.
        public byte slot95
        {
            get => (byte)row["slot95"].Value;
            set => row["slot95"].Value = value;
        }

        // Unknown.
        public byte slot96
        {
            get => (byte)row["slot96"].Value;
            set => row["slot96"].Value = value;
        }

        // Unknown.
        public byte slot97
        {
            get => (byte)row["slot97"].Value;
            set => row["slot97"].Value = value;
        }

        // Unknown.
        public byte slot98
        {
            get => (byte)row["slot98"].Value;
            set => row["slot98"].Value = value;
        }

        // Unknown.
        public byte slot99
        {
            get => (byte)row["slot99"].Value;
            set => row["slot99"].Value = value;
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
    public RANDOM_APPEAR_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public RANDOM_APPEAR_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
