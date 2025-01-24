using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class EQUIP_PARAM_ACCESSORY_ST
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
        public int refId
        {
            get => (int)row["refId"].Value;
            set => row["refId"].Value = value;
        }

        // Unknown.
        public int sfxVariationId
        {
            get => (int)row["sfxVariationId"].Value;
            set => row["sfxVariationId"].Value = value;
        }

        // Unknown.
        public float weight
        {
            get => (float)row["weight"].Value;
            set => row["weight"].Value = value;
        }

        // Unknown.
        public int behaviorId
        {
            get => (int)row["behaviorId"].Value;
            set => row["behaviorId"].Value = value;
        }

        // Unknown.
        public int basicPrice
        {
            get => (int)row["basicPrice"].Value;
            set => row["basicPrice"].Value = value;
        }

        // Unknown.
        public int sellValue
        {
            get => (int)row["sellValue"].Value;
            set => row["sellValue"].Value = value;
        }

        public int sortId
        {
            get => (int)row["sortId"].Value;
            set => row["sortId"].Value = value;
        }

        public int qwcId
        {
            get => (int)row["qwcId"].Value;
            set => row["qwcId"].Value = value;
        }

        // Unknown.
        public ushort equipModelId
        {
            get => (ushort)row["equipModelId"].Value;
            set => row["equipModelId"].Value = value;
        }

        // Unknown.
        public ushort iconId
        {
            get => (ushort)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public short shopLv
        {
            get => (short)row["shopLv"].Value;
            set => row["shopLv"].Value = value;
        }

        public short trophySGradeId
        {
            get => (short)row["trophySGradeId"].Value;
            set => row["trophySGradeId"].Value = value;
        }

        // Unknown.
        public short trophySeqId
        {
            get => (short)row["trophySeqId"].Value;
            set => row["trophySeqId"].Value = value;
        }

        // Unknown.
        public byte equipModelCategory
        {
            get => (byte)row["equipModelCategory"].Value;
            set => row["equipModelCategory"].Value = value;
        }

        // Unknown.
        public byte equipModelGender
        {
            get => (byte)row["equipModelGender"].Value;
            set => row["equipModelGender"].Value = value;
        }

        // Unknown.
        public byte accessoryCategory
        {
            get => (byte)row["accessoryCategory"].Value;
            set => row["accessoryCategory"].Value = value;
        }

        // Unknown.
        public byte refCategory
        {
            get => (byte)row["refCategory"].Value;
            set => row["refCategory"].Value = value;
        }

        // Unknown.
        public byte spEffectCategory
        {
            get => (byte)row["spEffectCategory"].Value;
            set => row["spEffectCategory"].Value = value;
        }

        // Unknown.
        public byte sortGroupId
        {
            get => (byte)row["sortGroupId"].Value;
            set => row["sortGroupId"].Value = value;
        }

        // Unknown.
        public int vagrantItemLotId
        {
            get => (int)row["vagrantItemLotId"].Value;
            set => row["vagrantItemLotId"].Value = value;
        }

        // Unknown.
        public int vagrantBonusEneDropItemLotId
        {
            get => (int)row["vagrantBonusEneDropItemLotId"].Value;
            set => row["vagrantBonusEneDropItemLotId"].Value = value;
        }

        // Unknown.
        public int vagrantItemEneDropItemLotId
        {
            get => (int)row["vagrantItemEneDropItemLotId"].Value;
            set => row["vagrantItemEneDropItemLotId"].Value = value;
        }

        // Unknown.
        public byte isDeposit
        {
            get => (byte)row["isDeposit"].Value;
            set => row["isDeposit"].Value = value;
        }

        // Unknown.
        public byte isEquipOutBrake
        {
            get => (byte)row["isEquipOutBrake"].Value;
            set => row["isEquipOutBrake"].Value = value;
        }

        // Unknown.
        public byte disableMultiDropShare
        {
            get => (byte)row["disableMultiDropShare"].Value;
            set => row["disableMultiDropShare"].Value = value;
        }

        // Unknown.
        public byte isDiscard
        {
            get => (byte)row["isDiscard"].Value;
            set => row["isDiscard"].Value = value;
        }

        // Unknown.
        public byte isDrop
        {
            get => (byte)row["isDrop"].Value;
            set => row["isDrop"].Value = value;
        }

        // Unknown.
        public byte showLogCondType
        {
            get => (byte)row["showLogCondType"].Value;
            set => row["showLogCondType"].Value = value;
        }

        // Unknown.
        public byte showDialogCondType
        {
            get => (byte)row["showDialogCondType"].Value;
            set => row["showDialogCondType"].Value = value;
        }

        // Unknown.
        public byte rarity
        {
            get => (byte)row["rarity"].Value;
            set => row["rarity"].Value = value;
        }

        // Unknown.
        public int saleValue
        {
            get => (int)row["saleValue"].Value;
            set => row["saleValue"].Value = value;
        }

        // Unknown.
        public short accessoryGroup
        {
            get => (short)row["accessoryGroup"].Value;
            set => row["accessoryGroup"].Value = value;
        }

        // Unknown.
        public sbyte compTrophySedId
        {
            get => (sbyte)row["compTrophySedId"].Value;
            set => row["compTrophySedId"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId1
        {
            get => (int)row["residentSpEffectId1"].Value;
            set => row["residentSpEffectId1"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId2
        {
            get => (int)row["residentSpEffectId2"].Value;
            set => row["residentSpEffectId2"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId3
        {
            get => (int)row["residentSpEffectId3"].Value;
            set => row["residentSpEffectId3"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId4
        {
            get => (int)row["residentSpEffectId4"].Value;
            set => row["residentSpEffectId4"].Value = value;
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
    public EQUIP_PARAM_ACCESSORY_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public EQUIP_PARAM_ACCESSORY_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
