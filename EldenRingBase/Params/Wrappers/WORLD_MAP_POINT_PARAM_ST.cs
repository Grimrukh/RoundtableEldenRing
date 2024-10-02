using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class WORLD_MAP_POINT_PARAM_ST
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
        public uint eventFlagId
        {
            get => (uint)row["eventFlagId"].Value;
            set => row["eventFlagId"].Value = value;
        }

        // Unknown.
        public uint distViewEventFlagId
        {
            get => (uint)row["distViewEventFlagId"].Value;
            set => row["distViewEventFlagId"].Value = value;
        }

        // Unknown.
        public ushort iconId
        {
            get => (ushort)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public short bgmPlaceType
        {
            get => (short)row["bgmPlaceType"].Value;
            set => row["bgmPlaceType"].Value = value;
        }

        // Unknown.
        public byte isAreaIcon
        {
            get => (byte)row["isAreaIcon"].Value;
            set => row["isAreaIcon"].Value = value;
        }

        // Unknown.
        public byte isOverrideDistViewMarkPos
        {
            get => (byte)row["isOverrideDistViewMarkPos"].Value;
            set => row["isOverrideDistViewMarkPos"].Value = value;
        }

        // Unknown.
        public byte isEnableNoText
        {
            get => (byte)row["isEnableNoText"].Value;
            set => row["isEnableNoText"].Value = value;
        }

        // Unknown.
        public byte areaNo_forDistViewMark
        {
            get => (byte)row["areaNo_forDistViewMark"].Value;
            set => row["areaNo_forDistViewMark"].Value = value;
        }

        // Unknown.
        public byte gridXNo_forDistViewMark
        {
            get => (byte)row["gridXNo_forDistViewMark"].Value;
            set => row["gridXNo_forDistViewMark"].Value = value;
        }

        // Unknown.
        public byte gridZNo_forDistViewMark
        {
            get => (byte)row["gridZNo_forDistViewMark"].Value;
            set => row["gridZNo_forDistViewMark"].Value = value;
        }

        // Unknown.
        public uint clearedEventFlagId
        {
            get => (uint)row["clearedEventFlagId"].Value;
            set => row["clearedEventFlagId"].Value = value;
        }

        // Unknown.
        public byte dispMask00
        {
            get => (byte)row["dispMask00"].Value;
            set => row["dispMask00"].Value = value;
        }

        // Unknown.
        public byte dispMask01
        {
            get => (byte)row["dispMask01"].Value;
            set => row["dispMask01"].Value = value;
        }

        // Unknown.
        public ushort distViewIconId
        {
            get => (ushort)row["distViewIconId"].Value;
            set => row["distViewIconId"].Value = value;
        }

        // Unknown.
        public float angle
        {
            get => (float)row["angle"].Value;
            set => row["angle"].Value = value;
        }

        // Unknown.
        public byte areaNo
        {
            get => (byte)row["areaNo"].Value;
            set => row["areaNo"].Value = value;
        }

        // Unknown.
        public byte gridXNo
        {
            get => (byte)row["gridXNo"].Value;
            set => row["gridXNo"].Value = value;
        }

        // Unknown.
        public byte gridZNo
        {
            get => (byte)row["gridZNo"].Value;
            set => row["gridZNo"].Value = value;
        }

        // Unknown.
        public float posX
        {
            get => (float)row["posX"].Value;
            set => row["posX"].Value = value;
        }

        // Unknown.
        public float posY
        {
            get => (float)row["posY"].Value;
            set => row["posY"].Value = value;
        }

        // Unknown.
        public float posZ
        {
            get => (float)row["posZ"].Value;
            set => row["posZ"].Value = value;
        }

        // Unknown.
        public int textId1
        {
            get => (int)row["textId1"].Value;
            set => row["textId1"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId1
        {
            get => (uint)row["textEnableFlagId1"].Value;
            set => row["textEnableFlagId1"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId1
        {
            get => (uint)row["textDisableFlagId1"].Value;
            set => row["textDisableFlagId1"].Value = value;
        }

        // Unknown.
        public int textId2
        {
            get => (int)row["textId2"].Value;
            set => row["textId2"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId2
        {
            get => (uint)row["textEnableFlagId2"].Value;
            set => row["textEnableFlagId2"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId2
        {
            get => (uint)row["textDisableFlagId2"].Value;
            set => row["textDisableFlagId2"].Value = value;
        }

        // Unknown.
        public int textId3
        {
            get => (int)row["textId3"].Value;
            set => row["textId3"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId3
        {
            get => (uint)row["textEnableFlagId3"].Value;
            set => row["textEnableFlagId3"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId3
        {
            get => (uint)row["textDisableFlagId3"].Value;
            set => row["textDisableFlagId3"].Value = value;
        }

        // Unknown.
        public int textId4
        {
            get => (int)row["textId4"].Value;
            set => row["textId4"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId4
        {
            get => (uint)row["textEnableFlagId4"].Value;
            set => row["textEnableFlagId4"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId4
        {
            get => (uint)row["textDisableFlagId4"].Value;
            set => row["textDisableFlagId4"].Value = value;
        }

        // Unknown.
        public int textId5
        {
            get => (int)row["textId5"].Value;
            set => row["textId5"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId5
        {
            get => (uint)row["textEnableFlagId5"].Value;
            set => row["textEnableFlagId5"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId5
        {
            get => (uint)row["textDisableFlagId5"].Value;
            set => row["textDisableFlagId5"].Value = value;
        }

        // Unknown.
        public int textId6
        {
            get => (int)row["textId6"].Value;
            set => row["textId6"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId6
        {
            get => (uint)row["textEnableFlagId6"].Value;
            set => row["textEnableFlagId6"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId6
        {
            get => (uint)row["textDisableFlagId6"].Value;
            set => row["textDisableFlagId6"].Value = value;
        }

        // Unknown.
        public int textId7
        {
            get => (int)row["textId7"].Value;
            set => row["textId7"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId7
        {
            get => (uint)row["textEnableFlagId7"].Value;
            set => row["textEnableFlagId7"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId7
        {
            get => (uint)row["textDisableFlagId7"].Value;
            set => row["textDisableFlagId7"].Value = value;
        }

        // Unknown.
        public int textId8
        {
            get => (int)row["textId8"].Value;
            set => row["textId8"].Value = value;
        }

        // Unknown.
        public uint textEnableFlagId8
        {
            get => (uint)row["textEnableFlagId8"].Value;
            set => row["textEnableFlagId8"].Value = value;
        }

        // Unknown.
        public uint textDisableFlagId8
        {
            get => (uint)row["textDisableFlagId8"].Value;
            set => row["textDisableFlagId8"].Value = value;
        }

        // Unknown.
        public byte textType1
        {
            get => (byte)row["textType1"].Value;
            set => row["textType1"].Value = value;
        }

        // Unknown.
        public byte textType2
        {
            get => (byte)row["textType2"].Value;
            set => row["textType2"].Value = value;
        }

        // Unknown.
        public byte textType3
        {
            get => (byte)row["textType3"].Value;
            set => row["textType3"].Value = value;
        }

        // Unknown.
        public byte textType4
        {
            get => (byte)row["textType4"].Value;
            set => row["textType4"].Value = value;
        }

        // Unknown.
        public byte textType5
        {
            get => (byte)row["textType5"].Value;
            set => row["textType5"].Value = value;
        }

        // Unknown.
        public byte textType6
        {
            get => (byte)row["textType6"].Value;
            set => row["textType6"].Value = value;
        }

        // Unknown.
        public byte textType7
        {
            get => (byte)row["textType7"].Value;
            set => row["textType7"].Value = value;
        }

        // Unknown.
        public byte textType8
        {
            get => (byte)row["textType8"].Value;
            set => row["textType8"].Value = value;
        }

        // Unknown.
        public int distViewId
        {
            get => (int)row["distViewId"].Value;
            set => row["distViewId"].Value = value;
        }

        // Unknown.
        public float posX_forDistViewMark
        {
            get => (float)row["posX_forDistViewMark"].Value;
            set => row["posX_forDistViewMark"].Value = value;
        }

        // Unknown.
        public float posY_forDistViewMark
        {
            get => (float)row["posY_forDistViewMark"].Value;
            set => row["posY_forDistViewMark"].Value = value;
        }

        // Unknown.
        public float posZ_forDistViewMark
        {
            get => (float)row["posZ_forDistViewMark"].Value;
            set => row["posZ_forDistViewMark"].Value = value;
        }

        // Unknown.
        public int distViewId1
        {
            get => (int)row["distViewId1"].Value;
            set => row["distViewId1"].Value = value;
        }

        // Unknown.
        public int distViewId2
        {
            get => (int)row["distViewId2"].Value;
            set => row["distViewId2"].Value = value;
        }

        // Unknown.
        public int distViewId3
        {
            get => (int)row["distViewId3"].Value;
            set => row["distViewId3"].Value = value;
        }

        // Unknown.
        public byte dispMinZoomStep
        {
            get => (byte)row["dispMinZoomStep"].Value;
            set => row["dispMinZoomStep"].Value = value;
        }

        // Unknown.
        public byte selectMinZoomStep
        {
            get => (byte)row["selectMinZoomStep"].Value;
            set => row["selectMinZoomStep"].Value = value;
        }

        // Unknown.
        public byte entryFEType
        {
            get => (byte)row["entryFEType"].Value;
            set => row["entryFEType"].Value = value;
        }

        public int unkC0
        {
            get => (int)row["unkC0"].Value;
            set => row["unkC0"].Value = value;
        }

        public int unkC4
        {
            get => (int)row["unkC4"].Value;
            set => row["unkC4"].Value = value;
        }

        public int unkC8
        {
            get => (int)row["unkC8"].Value;
            set => row["unkC8"].Value = value;
        }

        public int unkCC
        {
            get => (int)row["unkCC"].Value;
            set => row["unkCC"].Value = value;
        }

        public int unkD0
        {
            get => (int)row["unkD0"].Value;
            set => row["unkD0"].Value = value;
        }

        public int unkD4
        {
            get => (int)row["unkD4"].Value;
            set => row["unkD4"].Value = value;
        }

        public int unkD8
        {
            get => (int)row["unkD8"].Value;
            set => row["unkD8"].Value = value;
        }

        public int unkDC
        {
            get => (int)row["unkDC"].Value;
            set => row["unkDC"].Value = value;
        }

        public int unkE0
        {
            get => (int)row["unkE0"].Value;
            set => row["unkE0"].Value = value;
        }

        public int unkE4
        {
            get => (int)row["unkE4"].Value;
            set => row["unkE4"].Value = value;
        }

        public int unkE8
        {
            get => (int)row["unkE8"].Value;
            set => row["unkE8"].Value = value;
        }

        public int unkEC
        {
            get => (int)row["unkEC"].Value;
            set => row["unkEC"].Value = value;
        }

        public int unkF0
        {
            get => (int)row["unkF0"].Value;
            set => row["unkF0"].Value = value;
        }

        public int unkF4
        {
            get => (int)row["unkF4"].Value;
            set => row["unkF4"].Value = value;
        }

        public int unkF8
        {
            get => (int)row["unkF8"].Value;
            set => row["unkF8"].Value = value;
        }

        public int unkFC
        {
            get => (int)row["unkFC"].Value;
            set => row["unkFC"].Value = value;
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
    public WORLD_MAP_POINT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WORLD_MAP_POINT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
