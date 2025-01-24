using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class ATTACK_ELEMENT_CORRECT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        public byte isStrengthCorrect_byPhysics
        {
            get => (byte)row["isStrengthCorrect_byPhysics"].Value;
            set => row["isStrengthCorrect_byPhysics"].Value = value;
        }

        public byte isDexterityCorrect_byPhysics
        {
            get => (byte)row["isDexterityCorrect_byPhysics"].Value;
            set => row["isDexterityCorrect_byPhysics"].Value = value;
        }

        public byte isMagicCorrect_byPhysics
        {
            get => (byte)row["isMagicCorrect_byPhysics"].Value;
            set => row["isMagicCorrect_byPhysics"].Value = value;
        }

        public byte isFaithCorrect_byPhysics
        {
            get => (byte)row["isFaithCorrect_byPhysics"].Value;
            set => row["isFaithCorrect_byPhysics"].Value = value;
        }

        public byte isLuckCorrect_byPhysics
        {
            get => (byte)row["isLuckCorrect_byPhysics"].Value;
            set => row["isLuckCorrect_byPhysics"].Value = value;
        }

        public byte isStrengthCorrect_byMagic
        {
            get => (byte)row["isStrengthCorrect_byMagic"].Value;
            set => row["isStrengthCorrect_byMagic"].Value = value;
        }

        public byte isDexterityCorrect_byMagic
        {
            get => (byte)row["isDexterityCorrect_byMagic"].Value;
            set => row["isDexterityCorrect_byMagic"].Value = value;
        }

        public byte isMagicCorrect_byMagic
        {
            get => (byte)row["isMagicCorrect_byMagic"].Value;
            set => row["isMagicCorrect_byMagic"].Value = value;
        }

        public byte isFaithCorrect_byMagic
        {
            get => (byte)row["isFaithCorrect_byMagic"].Value;
            set => row["isFaithCorrect_byMagic"].Value = value;
        }

        public byte isLuckCorrect_byMagic
        {
            get => (byte)row["isLuckCorrect_byMagic"].Value;
            set => row["isLuckCorrect_byMagic"].Value = value;
        }

        public byte isStrengthCorrect_byFire
        {
            get => (byte)row["isStrengthCorrect_byFire"].Value;
            set => row["isStrengthCorrect_byFire"].Value = value;
        }

        public byte isDexterityCorrect_byFire
        {
            get => (byte)row["isDexterityCorrect_byFire"].Value;
            set => row["isDexterityCorrect_byFire"].Value = value;
        }

        public byte isMagicCorrect_byFire
        {
            get => (byte)row["isMagicCorrect_byFire"].Value;
            set => row["isMagicCorrect_byFire"].Value = value;
        }

        public byte isFaithCorrect_byFire
        {
            get => (byte)row["isFaithCorrect_byFire"].Value;
            set => row["isFaithCorrect_byFire"].Value = value;
        }

        public byte isLuckCorrect_byFire
        {
            get => (byte)row["isLuckCorrect_byFire"].Value;
            set => row["isLuckCorrect_byFire"].Value = value;
        }

        public byte isStrengthCorrect_byThunder
        {
            get => (byte)row["isStrengthCorrect_byThunder"].Value;
            set => row["isStrengthCorrect_byThunder"].Value = value;
        }

        public byte isDexterityCorrect_byThunder
        {
            get => (byte)row["isDexterityCorrect_byThunder"].Value;
            set => row["isDexterityCorrect_byThunder"].Value = value;
        }

        public byte isMagicCorrect_byThunder
        {
            get => (byte)row["isMagicCorrect_byThunder"].Value;
            set => row["isMagicCorrect_byThunder"].Value = value;
        }

        public byte isFaithCorrect_byThunder
        {
            get => (byte)row["isFaithCorrect_byThunder"].Value;
            set => row["isFaithCorrect_byThunder"].Value = value;
        }

        public byte isLuckCorrect_byThunder
        {
            get => (byte)row["isLuckCorrect_byThunder"].Value;
            set => row["isLuckCorrect_byThunder"].Value = value;
        }

        public byte isStrengthCorrect_byDark
        {
            get => (byte)row["isStrengthCorrect_byDark"].Value;
            set => row["isStrengthCorrect_byDark"].Value = value;
        }

        public byte isDexterityCorrect_byDark
        {
            get => (byte)row["isDexterityCorrect_byDark"].Value;
            set => row["isDexterityCorrect_byDark"].Value = value;
        }

        public byte isMagicCorrect_byDark
        {
            get => (byte)row["isMagicCorrect_byDark"].Value;
            set => row["isMagicCorrect_byDark"].Value = value;
        }

        public byte isFaithCorrect_byDark
        {
            get => (byte)row["isFaithCorrect_byDark"].Value;
            set => row["isFaithCorrect_byDark"].Value = value;
        }

        public byte isLuckCorrect_byDark
        {
            get => (byte)row["isLuckCorrect_byDark"].Value;
            set => row["isLuckCorrect_byDark"].Value = value;
        }

        public short overwriteStrengthCorrectRate_byPhysics
        {
            get => (short)row["overwriteStrengthCorrectRate_byPhysics"].Value;
            set => row["overwriteStrengthCorrectRate_byPhysics"].Value = value;
        }

        public short overwriteDexterityCorrectRate_byPhysics
        {
            get => (short)row["overwriteDexterityCorrectRate_byPhysics"].Value;
            set => row["overwriteDexterityCorrectRate_byPhysics"].Value = value;
        }

        public short overwriteMagicCorrectRate_byPhysics
        {
            get => (short)row["overwriteMagicCorrectRate_byPhysics"].Value;
            set => row["overwriteMagicCorrectRate_byPhysics"].Value = value;
        }

        public short overwriteFaithCorrectRate_byPhysics
        {
            get => (short)row["overwriteFaithCorrectRate_byPhysics"].Value;
            set => row["overwriteFaithCorrectRate_byPhysics"].Value = value;
        }

        public short overwriteLuckCorrectRate_byPhysics
        {
            get => (short)row["overwriteLuckCorrectRate_byPhysics"].Value;
            set => row["overwriteLuckCorrectRate_byPhysics"].Value = value;
        }

        public short overwriteStrengthCorrectRate_byMagic
        {
            get => (short)row["overwriteStrengthCorrectRate_byMagic"].Value;
            set => row["overwriteStrengthCorrectRate_byMagic"].Value = value;
        }

        public short overwriteDexterityCorrectRate_byMagic
        {
            get => (short)row["overwriteDexterityCorrectRate_byMagic"].Value;
            set => row["overwriteDexterityCorrectRate_byMagic"].Value = value;
        }

        public short overwriteMagicCorrectRate_byMagic
        {
            get => (short)row["overwriteMagicCorrectRate_byMagic"].Value;
            set => row["overwriteMagicCorrectRate_byMagic"].Value = value;
        }

        public short overwriteFaithCorrectRate_byMagic
        {
            get => (short)row["overwriteFaithCorrectRate_byMagic"].Value;
            set => row["overwriteFaithCorrectRate_byMagic"].Value = value;
        }

        public short overwriteLuckCorrectRate_byMagic
        {
            get => (short)row["overwriteLuckCorrectRate_byMagic"].Value;
            set => row["overwriteLuckCorrectRate_byMagic"].Value = value;
        }

        public short overwriteStrengthCorrectRate_byFire
        {
            get => (short)row["overwriteStrengthCorrectRate_byFire"].Value;
            set => row["overwriteStrengthCorrectRate_byFire"].Value = value;
        }

        public short overwriteDexterityCorrectRate_byFire
        {
            get => (short)row["overwriteDexterityCorrectRate_byFire"].Value;
            set => row["overwriteDexterityCorrectRate_byFire"].Value = value;
        }

        public short overwriteMagicCorrectRate_byFire
        {
            get => (short)row["overwriteMagicCorrectRate_byFire"].Value;
            set => row["overwriteMagicCorrectRate_byFire"].Value = value;
        }

        public short overwriteFaithCorrectRate_byFire
        {
            get => (short)row["overwriteFaithCorrectRate_byFire"].Value;
            set => row["overwriteFaithCorrectRate_byFire"].Value = value;
        }

        public short overwriteLuckCorrectRate_byFire
        {
            get => (short)row["overwriteLuckCorrectRate_byFire"].Value;
            set => row["overwriteLuckCorrectRate_byFire"].Value = value;
        }

        public short overwriteStrengthCorrectRate_byThunder
        {
            get => (short)row["overwriteStrengthCorrectRate_byThunder"].Value;
            set => row["overwriteStrengthCorrectRate_byThunder"].Value = value;
        }

        public short overwriteDexterityCorrectRate_byThunder
        {
            get => (short)row["overwriteDexterityCorrectRate_byThunder"].Value;
            set => row["overwriteDexterityCorrectRate_byThunder"].Value = value;
        }

        public short overwriteMagicCorrectRate_byThunder
        {
            get => (short)row["overwriteMagicCorrectRate_byThunder"].Value;
            set => row["overwriteMagicCorrectRate_byThunder"].Value = value;
        }

        public short overwriteFaithCorrectRate_byThunder
        {
            get => (short)row["overwriteFaithCorrectRate_byThunder"].Value;
            set => row["overwriteFaithCorrectRate_byThunder"].Value = value;
        }

        public short overwriteLuckCorrectRate_byThunder
        {
            get => (short)row["overwriteLuckCorrectRate_byThunder"].Value;
            set => row["overwriteLuckCorrectRate_byThunder"].Value = value;
        }

        public short overwriteStrengthCorrectRate_byDark
        {
            get => (short)row["overwriteStrengthCorrectRate_byDark"].Value;
            set => row["overwriteStrengthCorrectRate_byDark"].Value = value;
        }

        public short overwriteDexterityCorrectRate_byDark
        {
            get => (short)row["overwriteDexterityCorrectRate_byDark"].Value;
            set => row["overwriteDexterityCorrectRate_byDark"].Value = value;
        }

        public short overwriteMagicCorrectRate_byDark
        {
            get => (short)row["overwriteMagicCorrectRate_byDark"].Value;
            set => row["overwriteMagicCorrectRate_byDark"].Value = value;
        }

        public short overwriteFaithCorrectRate_byDark
        {
            get => (short)row["overwriteFaithCorrectRate_byDark"].Value;
            set => row["overwriteFaithCorrectRate_byDark"].Value = value;
        }

        public short overwriteLuckCorrectRate_byDark
        {
            get => (short)row["overwriteLuckCorrectRate_byDark"].Value;
            set => row["overwriteLuckCorrectRate_byDark"].Value = value;
        }

        // Unknown.
        public short InfluenceStrengthCorrectRate_byPhysics
        {
            get => (short)row["InfluenceStrengthCorrectRate_byPhysics"].Value;
            set => row["InfluenceStrengthCorrectRate_byPhysics"].Value = value;
        }

        // Unknown.
        public short InfluenceDexterityCorrectRate_byPhysics
        {
            get => (short)row["InfluenceDexterityCorrectRate_byPhysics"].Value;
            set => row["InfluenceDexterityCorrectRate_byPhysics"].Value = value;
        }

        // Unknown.
        public short InfluenceMagicCorrectRate_byPhysics
        {
            get => (short)row["InfluenceMagicCorrectRate_byPhysics"].Value;
            set => row["InfluenceMagicCorrectRate_byPhysics"].Value = value;
        }

        // Unknown.
        public short InfluenceFaithCorrectRate_byPhysics
        {
            get => (short)row["InfluenceFaithCorrectRate_byPhysics"].Value;
            set => row["InfluenceFaithCorrectRate_byPhysics"].Value = value;
        }

        // Unknown.
        public short InfluenceLuckCorrectRate_byPhysics
        {
            get => (short)row["InfluenceLuckCorrectRate_byPhysics"].Value;
            set => row["InfluenceLuckCorrectRate_byPhysics"].Value = value;
        }

        // Unknown.
        public short InfluenceStrengthCorrectRate_byMagic
        {
            get => (short)row["InfluenceStrengthCorrectRate_byMagic"].Value;
            set => row["InfluenceStrengthCorrectRate_byMagic"].Value = value;
        }

        // Unknown.
        public short InfluenceDexterityCorrectRate_byMagic
        {
            get => (short)row["InfluenceDexterityCorrectRate_byMagic"].Value;
            set => row["InfluenceDexterityCorrectRate_byMagic"].Value = value;
        }

        // Unknown.
        public short InfluenceMagicCorrectRate_byMagic
        {
            get => (short)row["InfluenceMagicCorrectRate_byMagic"].Value;
            set => row["InfluenceMagicCorrectRate_byMagic"].Value = value;
        }

        // Unknown.
        public short InfluenceFaithCorrectRate_byMagic
        {
            get => (short)row["InfluenceFaithCorrectRate_byMagic"].Value;
            set => row["InfluenceFaithCorrectRate_byMagic"].Value = value;
        }

        // Unknown.
        public short InfluenceLuckCorrectRate_byMagic
        {
            get => (short)row["InfluenceLuckCorrectRate_byMagic"].Value;
            set => row["InfluenceLuckCorrectRate_byMagic"].Value = value;
        }

        // Unknown.
        public short InfluenceStrengthCorrectRate_byFire
        {
            get => (short)row["InfluenceStrengthCorrectRate_byFire"].Value;
            set => row["InfluenceStrengthCorrectRate_byFire"].Value = value;
        }

        // Unknown.
        public short InfluenceDexterityCorrectRate_byFire
        {
            get => (short)row["InfluenceDexterityCorrectRate_byFire"].Value;
            set => row["InfluenceDexterityCorrectRate_byFire"].Value = value;
        }

        // Unknown.
        public short InfluenceMagicCorrectRate_byFire
        {
            get => (short)row["InfluenceMagicCorrectRate_byFire"].Value;
            set => row["InfluenceMagicCorrectRate_byFire"].Value = value;
        }

        // Unknown.
        public short InfluenceFaithCorrectRate_byFire
        {
            get => (short)row["InfluenceFaithCorrectRate_byFire"].Value;
            set => row["InfluenceFaithCorrectRate_byFire"].Value = value;
        }

        // Unknown.
        public short InfluenceLuckCorrectRate_byFire
        {
            get => (short)row["InfluenceLuckCorrectRate_byFire"].Value;
            set => row["InfluenceLuckCorrectRate_byFire"].Value = value;
        }

        // Unknown.
        public short InfluenceStrengthCorrectRate_byThunder
        {
            get => (short)row["InfluenceStrengthCorrectRate_byThunder"].Value;
            set => row["InfluenceStrengthCorrectRate_byThunder"].Value = value;
        }

        // Unknown.
        public short InfluenceDexterityCorrectRate_byThunder
        {
            get => (short)row["InfluenceDexterityCorrectRate_byThunder"].Value;
            set => row["InfluenceDexterityCorrectRate_byThunder"].Value = value;
        }

        // Unknown.
        public short InfluenceMagicCorrectRate_byThunder
        {
            get => (short)row["InfluenceMagicCorrectRate_byThunder"].Value;
            set => row["InfluenceMagicCorrectRate_byThunder"].Value = value;
        }

        // Unknown.
        public short InfluenceFaithCorrectRate_byThunder
        {
            get => (short)row["InfluenceFaithCorrectRate_byThunder"].Value;
            set => row["InfluenceFaithCorrectRate_byThunder"].Value = value;
        }

        // Unknown.
        public short InfluenceLuckCorrectRate_byThunder
        {
            get => (short)row["InfluenceLuckCorrectRate_byThunder"].Value;
            set => row["InfluenceLuckCorrectRate_byThunder"].Value = value;
        }

        // Unknown.
        public short InfluenceStrengthCorrectRate_byDark
        {
            get => (short)row["InfluenceStrengthCorrectRate_byDark"].Value;
            set => row["InfluenceStrengthCorrectRate_byDark"].Value = value;
        }

        // Unknown.
        public short InfluenceDexterityCorrectRate_byDark
        {
            get => (short)row["InfluenceDexterityCorrectRate_byDark"].Value;
            set => row["InfluenceDexterityCorrectRate_byDark"].Value = value;
        }

        // Unknown.
        public short InfluenceMagicCorrectRate_byDark
        {
            get => (short)row["InfluenceMagicCorrectRate_byDark"].Value;
            set => row["InfluenceMagicCorrectRate_byDark"].Value = value;
        }

        // Unknown.
        public short InfluenceFaithCorrectRate_byDark
        {
            get => (short)row["InfluenceFaithCorrectRate_byDark"].Value;
            set => row["InfluenceFaithCorrectRate_byDark"].Value = value;
        }

        // Unknown.
        public short InfluenceLuckCorrectRate_byDark
        {
            get => (short)row["InfluenceLuckCorrectRate_byDark"].Value;
            set => row["InfluenceLuckCorrectRate_byDark"].Value = value;
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
    public ATTACK_ELEMENT_CORRECT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ATTACK_ELEMENT_CORRECT_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
