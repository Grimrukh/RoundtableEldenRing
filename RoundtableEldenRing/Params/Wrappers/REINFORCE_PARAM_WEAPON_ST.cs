using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class REINFORCE_PARAM_WEAPON_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float physicsAtkRate
        {
            get => (float)row["physicsAtkRate"].Value;
            set => row["physicsAtkRate"].Value = value;
        }

        // Unknown.
        public float magicAtkRate
        {
            get => (float)row["magicAtkRate"].Value;
            set => row["magicAtkRate"].Value = value;
        }

        // Unknown.
        public float fireAtkRate
        {
            get => (float)row["fireAtkRate"].Value;
            set => row["fireAtkRate"].Value = value;
        }

        // Unknown.
        public float thunderAtkRate
        {
            get => (float)row["thunderAtkRate"].Value;
            set => row["thunderAtkRate"].Value = value;
        }

        // Unknown.
        public float staminaAtkRate
        {
            get => (float)row["staminaAtkRate"].Value;
            set => row["staminaAtkRate"].Value = value;
        }

        // Unknown.
        public float saWeaponAtkRate
        {
            get => (float)row["saWeaponAtkRate"].Value;
            set => row["saWeaponAtkRate"].Value = value;
        }

        // Unknown.
        public float saDurabilityRate
        {
            get => (float)row["saDurabilityRate"].Value;
            set => row["saDurabilityRate"].Value = value;
        }

        // Unknown.
        public float correctStrengthRate
        {
            get => (float)row["correctStrengthRate"].Value;
            set => row["correctStrengthRate"].Value = value;
        }

        // Unknown.
        public float correctAgilityRate
        {
            get => (float)row["correctAgilityRate"].Value;
            set => row["correctAgilityRate"].Value = value;
        }

        // Unknown.
        public float correctMagicRate
        {
            get => (float)row["correctMagicRate"].Value;
            set => row["correctMagicRate"].Value = value;
        }

        // Unknown.
        public float correctFaithRate
        {
            get => (float)row["correctFaithRate"].Value;
            set => row["correctFaithRate"].Value = value;
        }

        // Unknown.
        public float physicsGuardCutRate
        {
            get => (float)row["physicsGuardCutRate"].Value;
            set => row["physicsGuardCutRate"].Value = value;
        }

        // Unknown.
        public float magicGuardCutRate
        {
            get => (float)row["magicGuardCutRate"].Value;
            set => row["magicGuardCutRate"].Value = value;
        }

        // Unknown.
        public float fireGuardCutRate
        {
            get => (float)row["fireGuardCutRate"].Value;
            set => row["fireGuardCutRate"].Value = value;
        }

        // Unknown.
        public float thunderGuardCutRate
        {
            get => (float)row["thunderGuardCutRate"].Value;
            set => row["thunderGuardCutRate"].Value = value;
        }

        // Unknown.
        public float poisonGuardResistRate
        {
            get => (float)row["poisonGuardResistRate"].Value;
            set => row["poisonGuardResistRate"].Value = value;
        }

        // Unknown.
        public float diseaseGuardResistRate
        {
            get => (float)row["diseaseGuardResistRate"].Value;
            set => row["diseaseGuardResistRate"].Value = value;
        }

        // Unknown.
        public float bloodGuardResistRate
        {
            get => (float)row["bloodGuardResistRate"].Value;
            set => row["bloodGuardResistRate"].Value = value;
        }

        // Unknown.
        public float curseGuardResistRate
        {
            get => (float)row["curseGuardResistRate"].Value;
            set => row["curseGuardResistRate"].Value = value;
        }

        // Unknown.
        public float staminaGuardDefRate
        {
            get => (float)row["staminaGuardDefRate"].Value;
            set => row["staminaGuardDefRate"].Value = value;
        }

        // Unknown.
        public byte spEffectId1
        {
            get => (byte)row["spEffectId1"].Value;
            set => row["spEffectId1"].Value = value;
        }

        // Unknown.
        public byte spEffectId2
        {
            get => (byte)row["spEffectId2"].Value;
            set => row["spEffectId2"].Value = value;
        }

        // Unknown.
        public byte spEffectId3
        {
            get => (byte)row["spEffectId3"].Value;
            set => row["spEffectId3"].Value = value;
        }

        // Unknown.
        public byte residentSpEffectId1
        {
            get => (byte)row["residentSpEffectId1"].Value;
            set => row["residentSpEffectId1"].Value = value;
        }

        // Unknown.
        public byte residentSpEffectId2
        {
            get => (byte)row["residentSpEffectId2"].Value;
            set => row["residentSpEffectId2"].Value = value;
        }

        // Unknown.
        public byte residentSpEffectId3
        {
            get => (byte)row["residentSpEffectId3"].Value;
            set => row["residentSpEffectId3"].Value = value;
        }

        // Unknown.
        public byte materialSetId
        {
            get => (byte)row["materialSetId"].Value;
            set => row["materialSetId"].Value = value;
        }

        // Unknown.
        public byte maxReinforceLevel
        {
            get => (byte)row["maxReinforceLevel"].Value;
            set => row["maxReinforceLevel"].Value = value;
        }

        // Unknown.
        public float darkAtkRate
        {
            get => (float)row["darkAtkRate"].Value;
            set => row["darkAtkRate"].Value = value;
        }

        // Unknown.
        public float darkGuardCutRate
        {
            get => (float)row["darkGuardCutRate"].Value;
            set => row["darkGuardCutRate"].Value = value;
        }

        // Unknown.
        public float correctLuckRate
        {
            get => (float)row["correctLuckRate"].Value;
            set => row["correctLuckRate"].Value = value;
        }

        // Unknown.
        public float freezeGuardDefRate
        {
            get => (float)row["freezeGuardDefRate"].Value;
            set => row["freezeGuardDefRate"].Value = value;
        }

        // Unknown.
        public float reinforcePriceRate
        {
            get => (float)row["reinforcePriceRate"].Value;
            set => row["reinforcePriceRate"].Value = value;
        }

        // Unknown.
        public float baseChangePriceRate
        {
            get => (float)row["baseChangePriceRate"].Value;
            set => row["baseChangePriceRate"].Value = value;
        }

        // Unknown.
        public sbyte enableGemRank
        {
            get => (sbyte)row["enableGemRank"].Value;
            set => row["enableGemRank"].Value = value;
        }

        // Unknown.
        public float sleepGuardDefRate
        {
            get => (float)row["sleepGuardDefRate"].Value;
            set => row["sleepGuardDefRate"].Value = value;
        }

        // Unknown.
        public float madnessGuardDefRate
        {
            get => (float)row["madnessGuardDefRate"].Value;
            set => row["madnessGuardDefRate"].Value = value;
        }

        // Unknown.
        public float baseAtkRate
        {
            get => (float)row["baseAtkRate"].Value;
            set => row["baseAtkRate"].Value = value;
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
    public REINFORCE_PARAM_WEAPON_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public REINFORCE_PARAM_WEAPON_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
