using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class BUDGET_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float vram_all
        {
            get => (float)row["vram_all"].Value;
            set => row["vram_all"].Value = value;
        }

        // Unknown.
        public float vram_mapobj_tex
        {
            get => (float)row["vram_mapobj_tex"].Value;
            set => row["vram_mapobj_tex"].Value = value;
        }

        // Unknown.
        public float vram_mapobj_mdl
        {
            get => (float)row["vram_mapobj_mdl"].Value;
            set => row["vram_mapobj_mdl"].Value = value;
        }

        // Unknown.
        public float vram_map
        {
            get => (float)row["vram_map"].Value;
            set => row["vram_map"].Value = value;
        }

        // Unknown.
        public float vram_chr
        {
            get => (float)row["vram_chr"].Value;
            set => row["vram_chr"].Value = value;
        }

        // Unknown.
        public float vram_parts
        {
            get => (float)row["vram_parts"].Value;
            set => row["vram_parts"].Value = value;
        }

        // Unknown.
        public float vram_sfx
        {
            get => (float)row["vram_sfx"].Value;
            set => row["vram_sfx"].Value = value;
        }

        // Unknown.
        public float vram_chr_tex
        {
            get => (float)row["vram_chr_tex"].Value;
            set => row["vram_chr_tex"].Value = value;
        }

        // Unknown.
        public float vram_chr_mdl
        {
            get => (float)row["vram_chr_mdl"].Value;
            set => row["vram_chr_mdl"].Value = value;
        }

        // Unknown.
        public float vram_parts_tex
        {
            get => (float)row["vram_parts_tex"].Value;
            set => row["vram_parts_tex"].Value = value;
        }

        // Unknown.
        public float vram_parts_mdl
        {
            get => (float)row["vram_parts_mdl"].Value;
            set => row["vram_parts_mdl"].Value = value;
        }

        // Unknown.
        public float vram_sfx_tex
        {
            get => (float)row["vram_sfx_tex"].Value;
            set => row["vram_sfx_tex"].Value = value;
        }

        // Unknown.
        public float vram_sfx_mdl
        {
            get => (float)row["vram_sfx_mdl"].Value;
            set => row["vram_sfx_mdl"].Value = value;
        }

        // Unknown.
        public float vram_gi
        {
            get => (float)row["vram_gi"].Value;
            set => row["vram_gi"].Value = value;
        }

        // Unknown.
        public float vram_menu_tex
        {
            get => (float)row["vram_menu_tex"].Value;
            set => row["vram_menu_tex"].Value = value;
        }

        // Unknown.
        public float vram_decal_rt
        {
            get => (float)row["vram_decal_rt"].Value;
            set => row["vram_decal_rt"].Value = value;
        }

        // Unknown.
        public float vram_decal
        {
            get => (float)row["vram_decal"].Value;
            set => row["vram_decal"].Value = value;
        }

        // Unknown.
        public float vram_other_tex
        {
            get => (float)row["vram_other_tex"].Value;
            set => row["vram_other_tex"].Value = value;
        }

        // Unknown.
        public float vram_other_mdl
        {
            get => (float)row["vram_other_mdl"].Value;
            set => row["vram_other_mdl"].Value = value;
        }

        // Unknown.
        public float havok_anim
        {
            get => (float)row["havok_anim"].Value;
            set => row["havok_anim"].Value = value;
        }

        // Unknown.
        public float havok_ins
        {
            get => (float)row["havok_ins"].Value;
            set => row["havok_ins"].Value = value;
        }

        // Unknown.
        public float havok_hit
        {
            get => (float)row["havok_hit"].Value;
            set => row["havok_hit"].Value = value;
        }

        // Unknown.
        public float vram_other
        {
            get => (float)row["vram_other"].Value;
            set => row["vram_other"].Value = value;
        }

        // Unknown.
        public float vram_detail_all
        {
            get => (float)row["vram_detail_all"].Value;
            set => row["vram_detail_all"].Value = value;
        }

        // Unknown.
        public float vram_chr_and_parts
        {
            get => (float)row["vram_chr_and_parts"].Value;
            set => row["vram_chr_and_parts"].Value = value;
        }

        // Unknown.
        public float havok_navimesh
        {
            get => (float)row["havok_navimesh"].Value;
            set => row["havok_navimesh"].Value = value;
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
    public BUDGET_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public BUDGET_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
