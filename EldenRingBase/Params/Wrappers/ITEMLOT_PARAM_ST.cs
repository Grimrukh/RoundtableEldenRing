using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class ITEMLOT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int lotItemId01
        {
            get => (int)row["lotItemId01"].Value;
            set => row["lotItemId01"].Value = value;
        }

        // Unknown.
        public int lotItemId02
        {
            get => (int)row["lotItemId02"].Value;
            set => row["lotItemId02"].Value = value;
        }

        // Unknown.
        public int lotItemId03
        {
            get => (int)row["lotItemId03"].Value;
            set => row["lotItemId03"].Value = value;
        }

        // Unknown.
        public int lotItemId04
        {
            get => (int)row["lotItemId04"].Value;
            set => row["lotItemId04"].Value = value;
        }

        // Unknown.
        public int lotItemId05
        {
            get => (int)row["lotItemId05"].Value;
            set => row["lotItemId05"].Value = value;
        }

        // Unknown.
        public int lotItemId06
        {
            get => (int)row["lotItemId06"].Value;
            set => row["lotItemId06"].Value = value;
        }

        // Unknown.
        public int lotItemId07
        {
            get => (int)row["lotItemId07"].Value;
            set => row["lotItemId07"].Value = value;
        }

        // Unknown.
        public int lotItemId08
        {
            get => (int)row["lotItemId08"].Value;
            set => row["lotItemId08"].Value = value;
        }

        // Unknown.
        public int lotItemCategory01
        {
            get => (int)row["lotItemCategory01"].Value;
            set => row["lotItemCategory01"].Value = value;
        }

        // Unknown.
        public int lotItemCategory02
        {
            get => (int)row["lotItemCategory02"].Value;
            set => row["lotItemCategory02"].Value = value;
        }

        // Unknown.
        public int lotItemCategory03
        {
            get => (int)row["lotItemCategory03"].Value;
            set => row["lotItemCategory03"].Value = value;
        }

        // Unknown.
        public int lotItemCategory04
        {
            get => (int)row["lotItemCategory04"].Value;
            set => row["lotItemCategory04"].Value = value;
        }

        // Unknown.
        public int lotItemCategory05
        {
            get => (int)row["lotItemCategory05"].Value;
            set => row["lotItemCategory05"].Value = value;
        }

        // Unknown.
        public int lotItemCategory06
        {
            get => (int)row["lotItemCategory06"].Value;
            set => row["lotItemCategory06"].Value = value;
        }

        // Unknown.
        public int lotItemCategory07
        {
            get => (int)row["lotItemCategory07"].Value;
            set => row["lotItemCategory07"].Value = value;
        }

        // Unknown.
        public int lotItemCategory08
        {
            get => (int)row["lotItemCategory08"].Value;
            set => row["lotItemCategory08"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint01
        {
            get => (ushort)row["lotItemBasePoint01"].Value;
            set => row["lotItemBasePoint01"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint02
        {
            get => (ushort)row["lotItemBasePoint02"].Value;
            set => row["lotItemBasePoint02"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint03
        {
            get => (ushort)row["lotItemBasePoint03"].Value;
            set => row["lotItemBasePoint03"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint04
        {
            get => (ushort)row["lotItemBasePoint04"].Value;
            set => row["lotItemBasePoint04"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint05
        {
            get => (ushort)row["lotItemBasePoint05"].Value;
            set => row["lotItemBasePoint05"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint06
        {
            get => (ushort)row["lotItemBasePoint06"].Value;
            set => row["lotItemBasePoint06"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint07
        {
            get => (ushort)row["lotItemBasePoint07"].Value;
            set => row["lotItemBasePoint07"].Value = value;
        }

        // Unknown.
        public ushort lotItemBasePoint08
        {
            get => (ushort)row["lotItemBasePoint08"].Value;
            set => row["lotItemBasePoint08"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint01
        {
            get => (ushort)row["cumulateLotPoint01"].Value;
            set => row["cumulateLotPoint01"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint02
        {
            get => (ushort)row["cumulateLotPoint02"].Value;
            set => row["cumulateLotPoint02"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint03
        {
            get => (ushort)row["cumulateLotPoint03"].Value;
            set => row["cumulateLotPoint03"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint04
        {
            get => (ushort)row["cumulateLotPoint04"].Value;
            set => row["cumulateLotPoint04"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint05
        {
            get => (ushort)row["cumulateLotPoint05"].Value;
            set => row["cumulateLotPoint05"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint06
        {
            get => (ushort)row["cumulateLotPoint06"].Value;
            set => row["cumulateLotPoint06"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint07
        {
            get => (ushort)row["cumulateLotPoint07"].Value;
            set => row["cumulateLotPoint07"].Value = value;
        }

        // Unknown.
        public ushort cumulateLotPoint08
        {
            get => (ushort)row["cumulateLotPoint08"].Value;
            set => row["cumulateLotPoint08"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId01
        {
            get => (uint)row["getItemFlagId01"].Value;
            set => row["getItemFlagId01"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId02
        {
            get => (uint)row["getItemFlagId02"].Value;
            set => row["getItemFlagId02"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId03
        {
            get => (uint)row["getItemFlagId03"].Value;
            set => row["getItemFlagId03"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId04
        {
            get => (uint)row["getItemFlagId04"].Value;
            set => row["getItemFlagId04"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId05
        {
            get => (uint)row["getItemFlagId05"].Value;
            set => row["getItemFlagId05"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId06
        {
            get => (uint)row["getItemFlagId06"].Value;
            set => row["getItemFlagId06"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId07
        {
            get => (uint)row["getItemFlagId07"].Value;
            set => row["getItemFlagId07"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId08
        {
            get => (uint)row["getItemFlagId08"].Value;
            set => row["getItemFlagId08"].Value = value;
        }

        // Unknown.
        public uint getItemFlagId
        {
            get => (uint)row["getItemFlagId"].Value;
            set => row["getItemFlagId"].Value = value;
        }

        // Unknown.
        public uint cumulateNumFlagId
        {
            get => (uint)row["cumulateNumFlagId"].Value;
            set => row["cumulateNumFlagId"].Value = value;
        }

        // Unknown.
        public byte cumulateNumMax
        {
            get => (byte)row["cumulateNumMax"].Value;
            set => row["cumulateNumMax"].Value = value;
        }

        // Unknown.
        public sbyte lotItem_Rarity
        {
            get => (sbyte)row["lotItem_Rarity"].Value;
            set => row["lotItem_Rarity"].Value = value;
        }

        // Unknown.
        public byte lotItemNum01
        {
            get => (byte)row["lotItemNum01"].Value;
            set => row["lotItemNum01"].Value = value;
        }

        // Unknown.
        public byte lotItemNum02
        {
            get => (byte)row["lotItemNum02"].Value;
            set => row["lotItemNum02"].Value = value;
        }

        // Unknown.
        public byte lotItemNum03
        {
            get => (byte)row["lotItemNum03"].Value;
            set => row["lotItemNum03"].Value = value;
        }

        // Unknown.
        public byte lotItemNum04
        {
            get => (byte)row["lotItemNum04"].Value;
            set => row["lotItemNum04"].Value = value;
        }

        // Unknown.
        public byte lotItemNum05
        {
            get => (byte)row["lotItemNum05"].Value;
            set => row["lotItemNum05"].Value = value;
        }

        // Unknown.
        public byte lotItemNum06
        {
            get => (byte)row["lotItemNum06"].Value;
            set => row["lotItemNum06"].Value = value;
        }

        // Unknown.
        public byte lotItemNum07
        {
            get => (byte)row["lotItemNum07"].Value;
            set => row["lotItemNum07"].Value = value;
        }

        // Unknown.
        public byte lotItemNum08
        {
            get => (byte)row["lotItemNum08"].Value;
            set => row["lotItemNum08"].Value = value;
        }

        // Unknown.
        public ushort enableLuck01
        {
            get => (ushort)row["enableLuck01"].Value;
            set => row["enableLuck01"].Value = value;
        }

        // Unknown.
        public ushort enableLuck02
        {
            get => (ushort)row["enableLuck02"].Value;
            set => row["enableLuck02"].Value = value;
        }

        // Unknown.
        public ushort enableLuck03
        {
            get => (ushort)row["enableLuck03"].Value;
            set => row["enableLuck03"].Value = value;
        }

        // Unknown.
        public ushort enableLuck04
        {
            get => (ushort)row["enableLuck04"].Value;
            set => row["enableLuck04"].Value = value;
        }

        // Unknown.
        public ushort enableLuck05
        {
            get => (ushort)row["enableLuck05"].Value;
            set => row["enableLuck05"].Value = value;
        }

        // Unknown.
        public ushort enableLuck06
        {
            get => (ushort)row["enableLuck06"].Value;
            set => row["enableLuck06"].Value = value;
        }

        // Unknown.
        public ushort enableLuck07
        {
            get => (ushort)row["enableLuck07"].Value;
            set => row["enableLuck07"].Value = value;
        }

        // Unknown.
        public ushort enableLuck08
        {
            get => (ushort)row["enableLuck08"].Value;
            set => row["enableLuck08"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset01
        {
            get => (ushort)row["cumulateReset01"].Value;
            set => row["cumulateReset01"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset02
        {
            get => (ushort)row["cumulateReset02"].Value;
            set => row["cumulateReset02"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset03
        {
            get => (ushort)row["cumulateReset03"].Value;
            set => row["cumulateReset03"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset04
        {
            get => (ushort)row["cumulateReset04"].Value;
            set => row["cumulateReset04"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset05
        {
            get => (ushort)row["cumulateReset05"].Value;
            set => row["cumulateReset05"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset06
        {
            get => (ushort)row["cumulateReset06"].Value;
            set => row["cumulateReset06"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset07
        {
            get => (ushort)row["cumulateReset07"].Value;
            set => row["cumulateReset07"].Value = value;
        }

        // Unknown.
        public ushort cumulateReset08
        {
            get => (ushort)row["cumulateReset08"].Value;
            set => row["cumulateReset08"].Value = value;
        }

        // Unknown.
        public sbyte GameClearOffset
        {
            get => (sbyte)row["GameClearOffset"].Value;
            set => row["GameClearOffset"].Value = value;
        }

        // Unknown.
        public byte canExecByFriendlyGhost
        {
            get => (byte)row["canExecByFriendlyGhost"].Value;
            set => row["canExecByFriendlyGhost"].Value = value;
        }

        // Unknown.
        public byte canExecByHostileGhost
        {
            get => (byte)row["canExecByHostileGhost"].Value;
            set => row["canExecByHostileGhost"].Value = value;
        }

        // Unknown.
        public byte PAD1
        {
            get => (byte)row["PAD1"].Value;
            set => row["PAD1"].Value = value;
        }

        // Unknown.
        public ushort PAD2
        {
            get => (ushort)row["PAD2"].Value;
            set => row["PAD2"].Value = value;
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
    public ITEMLOT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ITEMLOT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
