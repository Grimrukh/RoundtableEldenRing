using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class KNOCKBACK_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float damage_Min_ContTime
        {
            get => (float)row["damage_Min_ContTime"].Value;
            set => row["damage_Min_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_S_ContTime
        {
            get => (float)row["damage_S_ContTime"].Value;
            set => row["damage_S_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_M_ContTime
        {
            get => (float)row["damage_M_ContTime"].Value;
            set => row["damage_M_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_L_ContTime
        {
            get => (float)row["damage_L_ContTime"].Value;
            set => row["damage_L_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_BlowS_ContTime
        {
            get => (float)row["damage_BlowS_ContTime"].Value;
            set => row["damage_BlowS_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_BlowM_ContTime
        {
            get => (float)row["damage_BlowM_ContTime"].Value;
            set => row["damage_BlowM_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_Strike_ContTime
        {
            get => (float)row["damage_Strike_ContTime"].Value;
            set => row["damage_Strike_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_Uppercut_ContTime
        {
            get => (float)row["damage_Uppercut_ContTime"].Value;
            set => row["damage_Uppercut_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_Push_ContTime
        {
            get => (float)row["damage_Push_ContTime"].Value;
            set => row["damage_Push_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_Breath_ContTime
        {
            get => (float)row["damage_Breath_ContTime"].Value;
            set => row["damage_Breath_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_HeadShot_ContTime
        {
            get => (float)row["damage_HeadShot_ContTime"].Value;
            set => row["damage_HeadShot_ContTime"].Value = value;
        }

        // Unknown.
        public float guard_S_ContTime
        {
            get => (float)row["guard_S_ContTime"].Value;
            set => row["guard_S_ContTime"].Value = value;
        }

        // Unknown.
        public float guard_L_ContTime
        {
            get => (float)row["guard_L_ContTime"].Value;
            set => row["guard_L_ContTime"].Value = value;
        }

        // Unknown.
        public float guard_LL_ContTime
        {
            get => (float)row["guard_LL_ContTime"].Value;
            set => row["guard_LL_ContTime"].Value = value;
        }

        // Unknown.
        public float guardBrake_ContTime
        {
            get => (float)row["guardBrake_ContTime"].Value;
            set => row["guardBrake_ContTime"].Value = value;
        }

        // Unknown.
        public float damage_Min_DecTime
        {
            get => (float)row["damage_Min_DecTime"].Value;
            set => row["damage_Min_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_S_DecTime
        {
            get => (float)row["damage_S_DecTime"].Value;
            set => row["damage_S_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_M_DecTime
        {
            get => (float)row["damage_M_DecTime"].Value;
            set => row["damage_M_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_L_DecTime
        {
            get => (float)row["damage_L_DecTime"].Value;
            set => row["damage_L_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_BlowS_DecTime
        {
            get => (float)row["damage_BlowS_DecTime"].Value;
            set => row["damage_BlowS_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_BlowM_DecTime
        {
            get => (float)row["damage_BlowM_DecTime"].Value;
            set => row["damage_BlowM_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_Strike_DecTime
        {
            get => (float)row["damage_Strike_DecTime"].Value;
            set => row["damage_Strike_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_Uppercut_DecTime
        {
            get => (float)row["damage_Uppercut_DecTime"].Value;
            set => row["damage_Uppercut_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_Push_DecTime
        {
            get => (float)row["damage_Push_DecTime"].Value;
            set => row["damage_Push_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_Breath_DecTime
        {
            get => (float)row["damage_Breath_DecTime"].Value;
            set => row["damage_Breath_DecTime"].Value = value;
        }

        // Unknown.
        public float damage_HeadShot_DecTime
        {
            get => (float)row["damage_HeadShot_DecTime"].Value;
            set => row["damage_HeadShot_DecTime"].Value = value;
        }

        // Unknown.
        public float guard_S_DecTime
        {
            get => (float)row["guard_S_DecTime"].Value;
            set => row["guard_S_DecTime"].Value = value;
        }

        // Unknown.
        public float guard_L_DecTime
        {
            get => (float)row["guard_L_DecTime"].Value;
            set => row["guard_L_DecTime"].Value = value;
        }

        // Unknown.
        public float guard_LL_DecTime
        {
            get => (float)row["guard_LL_DecTime"].Value;
            set => row["guard_LL_DecTime"].Value = value;
        }

        // Unknown.
        public float guardBrake_DecTime
        {
            get => (float)row["guardBrake_DecTime"].Value;
            set => row["guardBrake_DecTime"].Value = value;
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
    public KNOCKBACK_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public KNOCKBACK_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
