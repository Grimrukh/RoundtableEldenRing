using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class NETWORK_MSG_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public ushort priority
        {
            get => (ushort)row["priority"].Value;
            set => row["priority"].Value = value;
        }

        // Unknown.
        public byte forcePlay
        {
            get => (byte)row["forcePlay"].Value;
            set => row["forcePlay"].Value = value;
        }

        // Unknown.
        public int normalWhite
        {
            get => (int)row["normalWhite"].Value;
            set => row["normalWhite"].Value = value;
        }

        // Unknown.
        public int umbasaWhite
        {
            get => (int)row["umbasaWhite"].Value;
            set => row["umbasaWhite"].Value = value;
        }

        // Unknown.
        public int berserkerWhite
        {
            get => (int)row["berserkerWhite"].Value;
            set => row["berserkerWhite"].Value = value;
        }

        // Unknown.
        public int sinnerHeroWhite
        {
            get => (int)row["sinnerHeroWhite"].Value;
            set => row["sinnerHeroWhite"].Value = value;
        }

        // Unknown.
        public int normalBlack
        {
            get => (int)row["normalBlack"].Value;
            set => row["normalBlack"].Value = value;
        }

        // Unknown.
        public int umbasaBlack
        {
            get => (int)row["umbasaBlack"].Value;
            set => row["umbasaBlack"].Value = value;
        }

        // Unknown.
        public int berserkerBlack
        {
            get => (int)row["berserkerBlack"].Value;
            set => row["berserkerBlack"].Value = value;
        }

        // Unknown.
        public int forceJoinBlack
        {
            get => (int)row["forceJoinBlack"].Value;
            set => row["forceJoinBlack"].Value = value;
        }

        // Unknown.
        public int forceJoinUmbasaBlack
        {
            get => (int)row["forceJoinUmbasaBlack"].Value;
            set => row["forceJoinUmbasaBlack"].Value = value;
        }

        // Unknown.
        public int forceJoinBerserkerBlack
        {
            get => (int)row["forceJoinBerserkerBlack"].Value;
            set => row["forceJoinBerserkerBlack"].Value = value;
        }

        // Unknown.
        public int sinnerHunterVisitor
        {
            get => (int)row["sinnerHunterVisitor"].Value;
            set => row["sinnerHunterVisitor"].Value = value;
        }

        // Unknown.
        public int redHunterVisitor
        {
            get => (int)row["redHunterVisitor"].Value;
            set => row["redHunterVisitor"].Value = value;
        }

        // Unknown.
        public int guardianOfBossVisitor
        {
            get => (int)row["guardianOfBossVisitor"].Value;
            set => row["guardianOfBossVisitor"].Value = value;
        }

        // Unknown.
        public int guardianOfForestMapVisitor
        {
            get => (int)row["guardianOfForestMapVisitor"].Value;
            set => row["guardianOfForestMapVisitor"].Value = value;
        }

        // Unknown.
        public int guardianOfAnolisVisitor
        {
            get => (int)row["guardianOfAnolisVisitor"].Value;
            set => row["guardianOfAnolisVisitor"].Value = value;
        }

        // Unknown.
        public int rosaliaBlack
        {
            get => (int)row["rosaliaBlack"].Value;
            set => row["rosaliaBlack"].Value = value;
        }

        // Unknown.
        public int forceJoinRosaliaBlack
        {
            get => (int)row["forceJoinRosaliaBlack"].Value;
            set => row["forceJoinRosaliaBlack"].Value = value;
        }

        // Unknown.
        public int redHunterVisitor2
        {
            get => (int)row["redHunterVisitor2"].Value;
            set => row["redHunterVisitor2"].Value = value;
        }

        // Unknown.
        public int npc1
        {
            get => (int)row["npc1"].Value;
            set => row["npc1"].Value = value;
        }

        // Unknown.
        public int npc2
        {
            get => (int)row["npc2"].Value;
            set => row["npc2"].Value = value;
        }

        // Unknown.
        public int npc3
        {
            get => (int)row["npc3"].Value;
            set => row["npc3"].Value = value;
        }

        // Unknown.
        public int npc4
        {
            get => (int)row["npc4"].Value;
            set => row["npc4"].Value = value;
        }

        // Unknown.
        public int battleRoyal
        {
            get => (int)row["battleRoyal"].Value;
            set => row["battleRoyal"].Value = value;
        }

        // Unknown.
        public int npc5
        {
            get => (int)row["npc5"].Value;
            set => row["npc5"].Value = value;
        }

        // Unknown.
        public int npc6
        {
            get => (int)row["npc6"].Value;
            set => row["npc6"].Value = value;
        }

        // Unknown.
        public int npc7
        {
            get => (int)row["npc7"].Value;
            set => row["npc7"].Value = value;
        }

        // Unknown.
        public int npc8
        {
            get => (int)row["npc8"].Value;
            set => row["npc8"].Value = value;
        }

        // Unknown.
        public int npc9
        {
            get => (int)row["npc9"].Value;
            set => row["npc9"].Value = value;
        }

        // Unknown.
        public int npc10
        {
            get => (int)row["npc10"].Value;
            set => row["npc10"].Value = value;
        }

        // Unknown.
        public int npc11
        {
            get => (int)row["npc11"].Value;
            set => row["npc11"].Value = value;
        }

        // Unknown.
        public int npc12
        {
            get => (int)row["npc12"].Value;
            set => row["npc12"].Value = value;
        }

        // Unknown.
        public int npc13
        {
            get => (int)row["npc13"].Value;
            set => row["npc13"].Value = value;
        }

        // Unknown.
        public int npc14
        {
            get => (int)row["npc14"].Value;
            set => row["npc14"].Value = value;
        }

        // Unknown.
        public int npc15
        {
            get => (int)row["npc15"].Value;
            set => row["npc15"].Value = value;
        }

        // Unknown.
        public int npc16
        {
            get => (int)row["npc16"].Value;
            set => row["npc16"].Value = value;
        }

        // Unknown.
        public int forceJoinBlack_B
        {
            get => (int)row["forceJoinBlack_B"].Value;
            set => row["forceJoinBlack_B"].Value = value;
        }

        // Unknown.
        public int normalWhite_Npc
        {
            get => (int)row["normalWhite_Npc"].Value;
            set => row["normalWhite_Npc"].Value = value;
        }

        // Unknown.
        public int forceJoinBlack_Npc
        {
            get => (int)row["forceJoinBlack_Npc"].Value;
            set => row["forceJoinBlack_Npc"].Value = value;
        }

        // Unknown.
        public int forceJoinBlack_B_Npc
        {
            get => (int)row["forceJoinBlack_B_Npc"].Value;
            set => row["forceJoinBlack_B_Npc"].Value = value;
        }

        // Unknown.
        public int forceJoinBlack_C_Npc
        {
            get => (int)row["forceJoinBlack_C_Npc"].Value;
            set => row["forceJoinBlack_C_Npc"].Value = value;
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
    public NETWORK_MSG_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public NETWORK_MSG_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
