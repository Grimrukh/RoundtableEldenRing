using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MULTI_SOUL_BONUS_RATE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float host
        {
            get => (float)row["host"].Value;
            set => row["host"].Value = value;
        }

        // Unknown.
        public float WhiteGhost_None
        {
            get => (float)row["WhiteGhost_None"].Value;
            set => row["WhiteGhost_None"].Value = value;
        }

        // Unknown.
        public float WhiteGhost_Umbasa
        {
            get => (float)row["WhiteGhost_Umbasa"].Value;
            set => row["WhiteGhost_Umbasa"].Value = value;
        }

        // Unknown.
        public float WhiteGhost_Berserker
        {
            get => (float)row["WhiteGhost_Berserker"].Value;
            set => row["WhiteGhost_Berserker"].Value = value;
        }

        // Unknown.
        public float BlackGhost_None_Sign
        {
            get => (float)row["BlackGhost_None_Sign"].Value;
            set => row["BlackGhost_None_Sign"].Value = value;
        }

        // Unknown.
        public float BlackGhost_Umbasa_Sign
        {
            get => (float)row["BlackGhost_Umbasa_Sign"].Value;
            set => row["BlackGhost_Umbasa_Sign"].Value = value;
        }

        // Unknown.
        public float BlackGhost_Berserker_Sign
        {
            get => (float)row["BlackGhost_Berserker_Sign"].Value;
            set => row["BlackGhost_Berserker_Sign"].Value = value;
        }

        // Unknown.
        public float BlackGhost_None_Invade
        {
            get => (float)row["BlackGhost_None_Invade"].Value;
            set => row["BlackGhost_None_Invade"].Value = value;
        }

        // Unknown.
        public float BlackGhost_Umbasa_Invade
        {
            get => (float)row["BlackGhost_Umbasa_Invade"].Value;
            set => row["BlackGhost_Umbasa_Invade"].Value = value;
        }

        // Unknown.
        public float BlackGhost_Berserker_Invade
        {
            get => (float)row["BlackGhost_Berserker_Invade"].Value;
            set => row["BlackGhost_Berserker_Invade"].Value = value;
        }

        // Unknown.
        public float RedHunter1
        {
            get => (float)row["RedHunter1"].Value;
            set => row["RedHunter1"].Value = value;
        }

        // Unknown.
        public float RedHunter2
        {
            get => (float)row["RedHunter2"].Value;
            set => row["RedHunter2"].Value = value;
        }

        // Unknown.
        public float GuardianOfForest
        {
            get => (float)row["GuardianOfForest"].Value;
            set => row["GuardianOfForest"].Value = value;
        }

        // Unknown.
        public float GuardianOfAnor
        {
            get => (float)row["GuardianOfAnor"].Value;
            set => row["GuardianOfAnor"].Value = value;
        }

        // Unknown.
        public float BattleRoyal
        {
            get => (float)row["BattleRoyal"].Value;
            set => row["BattleRoyal"].Value = value;
        }

        // Unknown.
        public float YellowMonk
        {
            get => (float)row["YellowMonk"].Value;
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
    public MULTI_SOUL_BONUS_RATE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MULTI_SOUL_BONUS_RATE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
