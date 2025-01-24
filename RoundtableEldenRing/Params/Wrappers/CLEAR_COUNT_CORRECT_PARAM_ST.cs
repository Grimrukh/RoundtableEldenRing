using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class CLEAR_COUNT_CORRECT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float MaxHpRate
        {
            get => (float)row["MaxHpRate"].Value;
            set => row["MaxHpRate"].Value = value;
        }

        // Unknown.
        public float MaxMpRate
        {
            get => (float)row["MaxMpRate"].Value;
            set => row["MaxMpRate"].Value = value;
        }

        // Unknown.
        public float MaxStaminaRate
        {
            get => (float)row["MaxStaminaRate"].Value;
            set => row["MaxStaminaRate"].Value = value;
        }

        // Unknown.
        public float PhysicsAttackRate
        {
            get => (float)row["PhysicsAttackRate"].Value;
            set => row["PhysicsAttackRate"].Value = value;
        }

        // Unknown.
        public float SlashAttackRate
        {
            get => (float)row["SlashAttackRate"].Value;
            set => row["SlashAttackRate"].Value = value;
        }

        // Unknown.
        public float BlowAttackRate
        {
            get => (float)row["BlowAttackRate"].Value;
            set => row["BlowAttackRate"].Value = value;
        }

        // Unknown.
        public float ThrustAttackRate
        {
            get => (float)row["ThrustAttackRate"].Value;
            set => row["ThrustAttackRate"].Value = value;
        }

        // Unknown.
        public float NeturalAttackRate
        {
            get => (float)row["NeturalAttackRate"].Value;
            set => row["NeturalAttackRate"].Value = value;
        }

        // Unknown.
        public float MagicAttackRate
        {
            get => (float)row["MagicAttackRate"].Value;
            set => row["MagicAttackRate"].Value = value;
        }

        // Unknown.
        public float FireAttackRate
        {
            get => (float)row["FireAttackRate"].Value;
            set => row["FireAttackRate"].Value = value;
        }

        // Unknown.
        public float ThunderAttackRate
        {
            get => (float)row["ThunderAttackRate"].Value;
            set => row["ThunderAttackRate"].Value = value;
        }

        // Unknown.
        public float DarkAttackRate
        {
            get => (float)row["DarkAttackRate"].Value;
            set => row["DarkAttackRate"].Value = value;
        }

        // Unknown.
        public float PhysicsDefenseRate
        {
            get => (float)row["PhysicsDefenseRate"].Value;
            set => row["PhysicsDefenseRate"].Value = value;
        }

        // Unknown.
        public float MagicDefenseRate
        {
            get => (float)row["MagicDefenseRate"].Value;
            set => row["MagicDefenseRate"].Value = value;
        }

        // Unknown.
        public float FireDefenseRate
        {
            get => (float)row["FireDefenseRate"].Value;
            set => row["FireDefenseRate"].Value = value;
        }

        // Unknown.
        public float ThunderDefenseRate
        {
            get => (float)row["ThunderDefenseRate"].Value;
            set => row["ThunderDefenseRate"].Value = value;
        }

        // Unknown.
        public float DarkDefenseRate
        {
            get => (float)row["DarkDefenseRate"].Value;
            set => row["DarkDefenseRate"].Value = value;
        }

        // Unknown.
        public float StaminaAttackRate
        {
            get => (float)row["StaminaAttackRate"].Value;
            set => row["StaminaAttackRate"].Value = value;
        }

        // Unknown.
        public float SoulRate
        {
            get => (float)row["SoulRate"].Value;
            set => row["SoulRate"].Value = value;
        }

        // Unknown.
        public float PoisionResistRate
        {
            get => (float)row["PoisionResistRate"].Value;
            set => row["PoisionResistRate"].Value = value;
        }

        // Unknown.
        public float DiseaseResistRate
        {
            get => (float)row["DiseaseResistRate"].Value;
            set => row["DiseaseResistRate"].Value = value;
        }

        // Unknown.
        public float BloodResistRate
        {
            get => (float)row["BloodResistRate"].Value;
            set => row["BloodResistRate"].Value = value;
        }

        // Unknown.
        public float CurseResistRate
        {
            get => (float)row["CurseResistRate"].Value;
            set => row["CurseResistRate"].Value = value;
        }

        // Unknown.
        public float FreezeResistRate
        {
            get => (float)row["FreezeResistRate"].Value;
            set => row["FreezeResistRate"].Value = value;
        }

        // Unknown.
        public float BloodDamageRate
        {
            get => (float)row["BloodDamageRate"].Value;
            set => row["BloodDamageRate"].Value = value;
        }

        // Unknown.
        public float SuperArmorDamageRate
        {
            get => (float)row["SuperArmorDamageRate"].Value;
            set => row["SuperArmorDamageRate"].Value = value;
        }

        // Unknown.
        public float FreezeDamageRate
        {
            get => (float)row["FreezeDamageRate"].Value;
            set => row["FreezeDamageRate"].Value = value;
        }

        // Unknown.
        public float SleepResistRate
        {
            get => (float)row["SleepResistRate"].Value;
            set => row["SleepResistRate"].Value = value;
        }

        // Unknown.
        public float MadnessResistRate
        {
            get => (float)row["MadnessResistRate"].Value;
            set => row["MadnessResistRate"].Value = value;
        }

        // Unknown.
        public float SleepDamageRate
        {
            get => (float)row["SleepDamageRate"].Value;
            set => row["SleepDamageRate"].Value = value;
        }

        // Unknown.
        public float MadnessDamageRate
        {
            get => (float)row["MadnessDamageRate"].Value;
            set => row["MadnessDamageRate"].Value = value;
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
    public CLEAR_COUNT_CORRECT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CLEAR_COUNT_CORRECT_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
