using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class EQUIP_PARAM_GEM_ST
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
        public ushort iconId
        {
            get => (ushort)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public sbyte rank
        {
            get => (sbyte)row["rank"].Value;
            set => row["rank"].Value = value;
        }

        // Unknown.
        public byte sortGroupId
        {
            get => (byte)row["sortGroupId"].Value;
            set => row["sortGroupId"].Value = value;
        }

        // Unknown.
        public int spEffectId0
        {
            get => (int)row["spEffectId0"].Value;
            set => row["spEffectId0"].Value = value;
        }

        // Unknown.
        public int spEffectId1
        {
            get => (int)row["spEffectId1"].Value;
            set => row["spEffectId1"].Value = value;
        }

        // Unknown.
        public int spEffectId2
        {
            get => (int)row["spEffectId2"].Value;
            set => row["spEffectId2"].Value = value;
        }

        // Unknown.
        public uint itemGetTutorialFlagId
        {
            get => (uint)row["itemGetTutorialFlagId"].Value;
            set => row["itemGetTutorialFlagId"].Value = value;
        }

        // Unknown.
        public int swordArtsParamId
        {
            get => (int)row["swordArtsParamId"].Value;
            set => row["swordArtsParamId"].Value = value;
        }

        // Unknown.
        public int mountValue
        {
            get => (int)row["mountValue"].Value;
            set => row["mountValue"].Value = value;
        }

        // Unknown.
        public int sellValue
        {
            get => (int)row["sellValue"].Value;
            set => row["sellValue"].Value = value;
        }

        // Unknown.
        public int saleValue
        {
            get => (int)row["saleValue"].Value;
            set => row["saleValue"].Value = value;
        }

        // Unknown.
        public int sortId
        {
            get => (int)row["sortId"].Value;
            set => row["sortId"].Value = value;
        }

        // Unknown.
        public short compTrophySedId
        {
            get => (short)row["compTrophySedId"].Value;
            set => row["compTrophySedId"].Value = value;
        }

        // Unknown.
        public short trophySeqId
        {
            get => (short)row["trophySeqId"].Value;
            set => row["trophySeqId"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr00
        {
            get => (byte)row["configurableWepAttr00"].Value;
            set => row["configurableWepAttr00"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr01
        {
            get => (byte)row["configurableWepAttr01"].Value;
            set => row["configurableWepAttr01"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr02
        {
            get => (byte)row["configurableWepAttr02"].Value;
            set => row["configurableWepAttr02"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr03
        {
            get => (byte)row["configurableWepAttr03"].Value;
            set => row["configurableWepAttr03"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr04
        {
            get => (byte)row["configurableWepAttr04"].Value;
            set => row["configurableWepAttr04"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr05
        {
            get => (byte)row["configurableWepAttr05"].Value;
            set => row["configurableWepAttr05"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr06
        {
            get => (byte)row["configurableWepAttr06"].Value;
            set => row["configurableWepAttr06"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr07
        {
            get => (byte)row["configurableWepAttr07"].Value;
            set => row["configurableWepAttr07"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr08
        {
            get => (byte)row["configurableWepAttr08"].Value;
            set => row["configurableWepAttr08"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr09
        {
            get => (byte)row["configurableWepAttr09"].Value;
            set => row["configurableWepAttr09"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr10
        {
            get => (byte)row["configurableWepAttr10"].Value;
            set => row["configurableWepAttr10"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr11
        {
            get => (byte)row["configurableWepAttr11"].Value;
            set => row["configurableWepAttr11"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr12
        {
            get => (byte)row["configurableWepAttr12"].Value;
            set => row["configurableWepAttr12"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr13
        {
            get => (byte)row["configurableWepAttr13"].Value;
            set => row["configurableWepAttr13"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr14
        {
            get => (byte)row["configurableWepAttr14"].Value;
            set => row["configurableWepAttr14"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr15
        {
            get => (byte)row["configurableWepAttr15"].Value;
            set => row["configurableWepAttr15"].Value = value;
        }

        // Unknown.
        public byte rarity
        {
            get => (byte)row["rarity"].Value;
            set => row["rarity"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr16
        {
            get => (byte)row["configurableWepAttr16"].Value;
            set => row["configurableWepAttr16"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr17
        {
            get => (byte)row["configurableWepAttr17"].Value;
            set => row["configurableWepAttr17"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr18
        {
            get => (byte)row["configurableWepAttr18"].Value;
            set => row["configurableWepAttr18"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr19
        {
            get => (byte)row["configurableWepAttr19"].Value;
            set => row["configurableWepAttr19"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr20
        {
            get => (byte)row["configurableWepAttr20"].Value;
            set => row["configurableWepAttr20"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr21
        {
            get => (byte)row["configurableWepAttr21"].Value;
            set => row["configurableWepAttr21"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr22
        {
            get => (byte)row["configurableWepAttr22"].Value;
            set => row["configurableWepAttr22"].Value = value;
        }

        // Unknown.
        public byte configurableWepAttr23
        {
            get => (byte)row["configurableWepAttr23"].Value;
            set => row["configurableWepAttr23"].Value = value;
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
        public byte isDeposit
        {
            get => (byte)row["isDeposit"].Value;
            set => row["isDeposit"].Value = value;
        }

        // Unknown.
        public byte disableMultiDropShare
        {
            get => (byte)row["disableMultiDropShare"].Value;
            set => row["disableMultiDropShare"].Value = value;
        }

        // Unknown.
        public byte showDialogCondType
        {
            get => (byte)row["showDialogCondType"].Value;
            set => row["showDialogCondType"].Value = value;
        }

        // Unknown.
        public byte showLogCondType
        {
            get => (byte)row["showLogCondType"].Value;
            set => row["showLogCondType"].Value = value;
        }

        // Unknown.
        public byte defaultWepAttr
        {
            get => (byte)row["defaultWepAttr"].Value;
            set => row["defaultWepAttr"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Dagger
        {
            get => (byte)row["canMountWep_Dagger"].Value;
            set => row["canMountWep_Dagger"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SwordNormal
        {
            get => (byte)row["canMountWep_SwordNormal"].Value;
            set => row["canMountWep_SwordNormal"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SwordLarge
        {
            get => (byte)row["canMountWep_SwordLarge"].Value;
            set => row["canMountWep_SwordLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SwordGigantic
        {
            get => (byte)row["canMountWep_SwordGigantic"].Value;
            set => row["canMountWep_SwordGigantic"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SaberNormal
        {
            get => (byte)row["canMountWep_SaberNormal"].Value;
            set => row["canMountWep_SaberNormal"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SaberLarge
        {
            get => (byte)row["canMountWep_SaberLarge"].Value;
            set => row["canMountWep_SaberLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_katana
        {
            get => (byte)row["canMountWep_katana"].Value;
            set => row["canMountWep_katana"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SwordDoubleEdge
        {
            get => (byte)row["canMountWep_SwordDoubleEdge"].Value;
            set => row["canMountWep_SwordDoubleEdge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SwordPierce
        {
            get => (byte)row["canMountWep_SwordPierce"].Value;
            set => row["canMountWep_SwordPierce"].Value = value;
        }

        // Unknown.
        public byte canMountWep_RapierHeavy
        {
            get => (byte)row["canMountWep_RapierHeavy"].Value;
            set => row["canMountWep_RapierHeavy"].Value = value;
        }

        // Unknown.
        public byte canMountWep_AxeNormal
        {
            get => (byte)row["canMountWep_AxeNormal"].Value;
            set => row["canMountWep_AxeNormal"].Value = value;
        }

        // Unknown.
        public byte canMountWep_AxeLarge
        {
            get => (byte)row["canMountWep_AxeLarge"].Value;
            set => row["canMountWep_AxeLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_HammerNormal
        {
            get => (byte)row["canMountWep_HammerNormal"].Value;
            set => row["canMountWep_HammerNormal"].Value = value;
        }

        // Unknown.
        public byte canMountWep_HammerLarge
        {
            get => (byte)row["canMountWep_HammerLarge"].Value;
            set => row["canMountWep_HammerLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Flail
        {
            get => (byte)row["canMountWep_Flail"].Value;
            set => row["canMountWep_Flail"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SpearNormal
        {
            get => (byte)row["canMountWep_SpearNormal"].Value;
            set => row["canMountWep_SpearNormal"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SpearLarge
        {
            get => (byte)row["canMountWep_SpearLarge"].Value;
            set => row["canMountWep_SpearLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SpearHeavy
        {
            get => (byte)row["canMountWep_SpearHeavy"].Value;
            set => row["canMountWep_SpearHeavy"].Value = value;
        }

        // Unknown.
        public byte canMountWep_SpearAxe
        {
            get => (byte)row["canMountWep_SpearAxe"].Value;
            set => row["canMountWep_SpearAxe"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Sickle
        {
            get => (byte)row["canMountWep_Sickle"].Value;
            set => row["canMountWep_Sickle"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Knuckle
        {
            get => (byte)row["canMountWep_Knuckle"].Value;
            set => row["canMountWep_Knuckle"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Claw
        {
            get => (byte)row["canMountWep_Claw"].Value;
            set => row["canMountWep_Claw"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Whip
        {
            get => (byte)row["canMountWep_Whip"].Value;
            set => row["canMountWep_Whip"].Value = value;
        }

        // Unknown.
        public byte canMountWep_AxhammerLarge
        {
            get => (byte)row["canMountWep_AxhammerLarge"].Value;
            set => row["canMountWep_AxhammerLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_BowSmall
        {
            get => (byte)row["canMountWep_BowSmall"].Value;
            set => row["canMountWep_BowSmall"].Value = value;
        }

        // Unknown.
        public byte canMountWep_BowNormal
        {
            get => (byte)row["canMountWep_BowNormal"].Value;
            set => row["canMountWep_BowNormal"].Value = value;
        }

        // Unknown.
        public byte canMountWep_BowLarge
        {
            get => (byte)row["canMountWep_BowLarge"].Value;
            set => row["canMountWep_BowLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_ClossBow
        {
            get => (byte)row["canMountWep_ClossBow"].Value;
            set => row["canMountWep_ClossBow"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Ballista
        {
            get => (byte)row["canMountWep_Ballista"].Value;
            set => row["canMountWep_Ballista"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Staff
        {
            get => (byte)row["canMountWep_Staff"].Value;
            set => row["canMountWep_Staff"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Sorcery
        {
            get => (byte)row["canMountWep_Sorcery"].Value;
            set => row["canMountWep_Sorcery"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Talisman
        {
            get => (byte)row["canMountWep_Talisman"].Value;
            set => row["canMountWep_Talisman"].Value = value;
        }

        // Unknown.
        public byte canMountWep_ShieldSmall
        {
            get => (byte)row["canMountWep_ShieldSmall"].Value;
            set => row["canMountWep_ShieldSmall"].Value = value;
        }

        // Unknown.
        public byte canMountWep_ShieldNormal
        {
            get => (byte)row["canMountWep_ShieldNormal"].Value;
            set => row["canMountWep_ShieldNormal"].Value = value;
        }

        // Unknown.
        public byte canMountWep_ShieldLarge
        {
            get => (byte)row["canMountWep_ShieldLarge"].Value;
            set => row["canMountWep_ShieldLarge"].Value = value;
        }

        // Unknown.
        public byte canMountWep_Torch
        {
            get => (byte)row["canMountWep_Torch"].Value;
            set => row["canMountWep_Torch"].Value = value;
        }

        // Unknown.
        public int spEffectMsgId0
        {
            get => (int)row["spEffectMsgId0"].Value;
            set => row["spEffectMsgId0"].Value = value;
        }

        // Unknown.
        public int spEffectMsgId1
        {
            get => (int)row["spEffectMsgId1"].Value;
            set => row["spEffectMsgId1"].Value = value;
        }

        // Unknown.
        public int spEffectId_forAtk0
        {
            get => (int)row["spEffectId_forAtk0"].Value;
            set => row["spEffectId_forAtk0"].Value = value;
        }

        // Unknown.
        public int spEffectId_forAtk1
        {
            get => (int)row["spEffectId_forAtk1"].Value;
            set => row["spEffectId_forAtk1"].Value = value;
        }

        // Unknown.
        public int spEffectId_forAtk2
        {
            get => (int)row["spEffectId_forAtk2"].Value;
            set => row["spEffectId_forAtk2"].Value = value;
        }

        // Unknown.
        public int mountWepTextId
        {
            get => (int)row["mountWepTextId"].Value;
            set => row["mountWepTextId"].Value = value;
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
    public EQUIP_PARAM_GEM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public EQUIP_PARAM_GEM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
