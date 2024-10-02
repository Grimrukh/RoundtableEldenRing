using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MULTI_ESTUS_FLASK_BONUS_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte host
        {
            get => (byte)row["host"].Value;
            set => row["host"].Value = value;
        }

        // Unknown.
        public byte WhiteGhost_None
        {
            get => (byte)row["WhiteGhost_None"].Value;
            set => row["WhiteGhost_None"].Value = value;
        }

        // Unknown.
        public byte WhiteGhost_Umbasa
        {
            get => (byte)row["WhiteGhost_Umbasa"].Value;
            set => row["WhiteGhost_Umbasa"].Value = value;
        }

        // Unknown.
        public byte WhiteGhost_Berserker
        {
            get => (byte)row["WhiteGhost_Berserker"].Value;
            set => row["WhiteGhost_Berserker"].Value = value;
        }

        // Unknown.
        public byte BlackGhost_None_Sign
        {
            get => (byte)row["BlackGhost_None_Sign"].Value;
            set => row["BlackGhost_None_Sign"].Value = value;
        }

        // Unknown.
        public byte BlackGhost_Umbasa_Sign
        {
            get => (byte)row["BlackGhost_Umbasa_Sign"].Value;
            set => row["BlackGhost_Umbasa_Sign"].Value = value;
        }

        // Unknown.
        public byte BlackGhost_Berserker_Sign
        {
            get => (byte)row["BlackGhost_Berserker_Sign"].Value;
            set => row["BlackGhost_Berserker_Sign"].Value = value;
        }

        // Unknown.
        public byte BlackGhost_None_Invade
        {
            get => (byte)row["BlackGhost_None_Invade"].Value;
            set => row["BlackGhost_None_Invade"].Value = value;
        }

        // Unknown.
        public byte BlackGhost_Umbasa_Invade
        {
            get => (byte)row["BlackGhost_Umbasa_Invade"].Value;
            set => row["BlackGhost_Umbasa_Invade"].Value = value;
        }

        // Unknown.
        public byte BlackGhost_Berserker_Invade
        {
            get => (byte)row["BlackGhost_Berserker_Invade"].Value;
            set => row["BlackGhost_Berserker_Invade"].Value = value;
        }

        // Unknown.
        public byte RedHunter1
        {
            get => (byte)row["RedHunter1"].Value;
            set => row["RedHunter1"].Value = value;
        }

        // Unknown.
        public byte RedHunter2
        {
            get => (byte)row["RedHunter2"].Value;
            set => row["RedHunter2"].Value = value;
        }

        // Unknown.
        public byte GuardianOfForest
        {
            get => (byte)row["GuardianOfForest"].Value;
            set => row["GuardianOfForest"].Value = value;
        }

        // Unknown.
        public byte GuardianOfAnor
        {
            get => (byte)row["GuardianOfAnor"].Value;
            set => row["GuardianOfAnor"].Value = value;
        }

        // Unknown.
        public byte BattleRoyal
        {
            get => (byte)row["BattleRoyal"].Value;
            set => row["BattleRoyal"].Value = value;
        }

        // Unknown.
        public byte YellowMonk
        {
            get => (byte)row["YellowMonk"].Value;
            set => row["YellowMonk"].Value = value;
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
    public MULTI_ESTUS_FLASK_BONUS_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MULTI_ESTUS_FLASK_BONUS_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
