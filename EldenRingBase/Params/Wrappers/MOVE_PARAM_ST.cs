using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MOVE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int stayId
        {
            get => (int)row["stayId"].Value;
            set => row["stayId"].Value = value;
        }

        // Unknown.
        public int walkF
        {
            get => (int)row["walkF"].Value;
            set => row["walkF"].Value = value;
        }

        // Unknown.
        public int walkB
        {
            get => (int)row["walkB"].Value;
            set => row["walkB"].Value = value;
        }

        // Unknown.
        public int walkL
        {
            get => (int)row["walkL"].Value;
            set => row["walkL"].Value = value;
        }

        // Unknown.
        public int walkR
        {
            get => (int)row["walkR"].Value;
            set => row["walkR"].Value = value;
        }

        // Unknown.
        public int dashF
        {
            get => (int)row["dashF"].Value;
            set => row["dashF"].Value = value;
        }

        // Unknown.
        public int dashB
        {
            get => (int)row["dashB"].Value;
            set => row["dashB"].Value = value;
        }

        // Unknown.
        public int dashL
        {
            get => (int)row["dashL"].Value;
            set => row["dashL"].Value = value;
        }

        // Unknown.
        public int dashR
        {
            get => (int)row["dashR"].Value;
            set => row["dashR"].Value = value;
        }

        // Unknown.
        public int superDash
        {
            get => (int)row["superDash"].Value;
            set => row["superDash"].Value = value;
        }

        // Unknown.
        public int escapeF
        {
            get => (int)row["escapeF"].Value;
            set => row["escapeF"].Value = value;
        }

        // Unknown.
        public int escapeB
        {
            get => (int)row["escapeB"].Value;
            set => row["escapeB"].Value = value;
        }

        // Unknown.
        public int escapeL
        {
            get => (int)row["escapeL"].Value;
            set => row["escapeL"].Value = value;
        }

        // Unknown.
        public int escapeR
        {
            get => (int)row["escapeR"].Value;
            set => row["escapeR"].Value = value;
        }

        // Unknown.
        public int turnL
        {
            get => (int)row["turnL"].Value;
            set => row["turnL"].Value = value;
        }

        // Unknown.
        public int trunR
        {
            get => (int)row["trunR"].Value;
            set => row["trunR"].Value = value;
        }

        // Unknown.
        public int largeTurnL
        {
            get => (int)row["largeTurnL"].Value;
            set => row["largeTurnL"].Value = value;
        }

        // Unknown.
        public int largeTurnR
        {
            get => (int)row["largeTurnR"].Value;
            set => row["largeTurnR"].Value = value;
        }

        // Unknown.
        public int stepMove
        {
            get => (int)row["stepMove"].Value;
            set => row["stepMove"].Value = value;
        }

        // Unknown.
        public int flyStay
        {
            get => (int)row["flyStay"].Value;
            set => row["flyStay"].Value = value;
        }

        // Unknown.
        public int flyWalkF
        {
            get => (int)row["flyWalkF"].Value;
            set => row["flyWalkF"].Value = value;
        }

        // Unknown.
        public int flyWalkFL
        {
            get => (int)row["flyWalkFL"].Value;
            set => row["flyWalkFL"].Value = value;
        }

        // Unknown.
        public int flyWalkFR
        {
            get => (int)row["flyWalkFR"].Value;
            set => row["flyWalkFR"].Value = value;
        }

        // Unknown.
        public int flyWalkFL2
        {
            get => (int)row["flyWalkFL2"].Value;
            set => row["flyWalkFL2"].Value = value;
        }

        // Unknown.
        public int flyWalkFR2
        {
            get => (int)row["flyWalkFR2"].Value;
            set => row["flyWalkFR2"].Value = value;
        }

        // Unknown.
        public int flyDashF
        {
            get => (int)row["flyDashF"].Value;
            set => row["flyDashF"].Value = value;
        }

        // Unknown.
        public int flyDashFL
        {
            get => (int)row["flyDashFL"].Value;
            set => row["flyDashFL"].Value = value;
        }

        // Unknown.
        public int flyDashFR
        {
            get => (int)row["flyDashFR"].Value;
            set => row["flyDashFR"].Value = value;
        }

        // Unknown.
        public int flyDashFL2
        {
            get => (int)row["flyDashFL2"].Value;
            set => row["flyDashFL2"].Value = value;
        }

        // Unknown.
        public int flyDashFR2
        {
            get => (int)row["flyDashFR2"].Value;
            set => row["flyDashFR2"].Value = value;
        }

        // Unknown.
        public int dashEscapeF
        {
            get => (int)row["dashEscapeF"].Value;
            set => row["dashEscapeF"].Value = value;
        }

        // Unknown.
        public int dashEscapeB
        {
            get => (int)row["dashEscapeB"].Value;
            set => row["dashEscapeB"].Value = value;
        }

        // Unknown.
        public int dashEscapeL
        {
            get => (int)row["dashEscapeL"].Value;
            set => row["dashEscapeL"].Value = value;
        }

        // Unknown.
        public int dashEscapeR
        {
            get => (int)row["dashEscapeR"].Value;
            set => row["dashEscapeR"].Value = value;
        }

        // Unknown.
        public int analogMoveParamId
        {
            get => (int)row["analogMoveParamId"].Value;
            set => row["analogMoveParamId"].Value = value;
        }

        // Unknown.
        public byte turnNoAnimAngle
        {
            get => (byte)row["turnNoAnimAngle"].Value;
            set => row["turnNoAnimAngle"].Value = value;
        }

        // Unknown.
        public byte turn45Angle
        {
            get => (byte)row["turn45Angle"].Value;
            set => row["turn45Angle"].Value = value;
        }

        // Unknown.
        public byte turn90Angle
        {
            get => (byte)row["turn90Angle"].Value;
            set => row["turn90Angle"].Value = value;
        }

        // Unknown.
        public byte turnWaitNoAnimAngle
        {
            get => (byte)row["turnWaitNoAnimAngle"].Value;
            set => row["turnWaitNoAnimAngle"].Value = value;
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
    public MOVE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MOVE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
