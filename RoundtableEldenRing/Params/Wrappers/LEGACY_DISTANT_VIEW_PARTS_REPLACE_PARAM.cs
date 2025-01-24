using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class LEGACY_DISTANT_VIEW_PARTS_REPLACE_PARAM
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int TargetMapId
        {
            get => (int)row["TargetMapId"].Value;
            set => row["TargetMapId"].Value = value;
        }

        // Unknown.
        public uint TargetEventId
        {
            get => (uint)row["TargetEventId"].Value;
            set => row["TargetEventId"].Value = value;
        }

        // Unknown.
        public int SrcAssetId
        {
            get => (int)row["SrcAssetId"].Value;
            set => row["SrcAssetId"].Value = value;
        }

        // Unknown.
        public int SrcAssetPartsNo
        {
            get => (int)row["SrcAssetPartsNo"].Value;
            set => row["SrcAssetPartsNo"].Value = value;
        }

        // Unknown.
        public int DstAssetId
        {
            get => (int)row["DstAssetId"].Value;
            set => row["DstAssetId"].Value = value;
        }

        // Unknown.
        public int DstAssetPartsNo
        {
            get => (int)row["DstAssetPartsNo"].Value;
            set => row["DstAssetPartsNo"].Value = value;
        }

        // Unknown.
        public int SrcAssetIdRangeMin
        {
            get => (int)row["SrcAssetIdRangeMin"].Value;
            set => row["SrcAssetIdRangeMin"].Value = value;
        }

        // Unknown.
        public int SrcAssetIdRangeMax
        {
            get => (int)row["SrcAssetIdRangeMax"].Value;
            set => row["SrcAssetIdRangeMax"].Value = value;
        }

        // Unknown.
        public int DstAssetIdRangeMin
        {
            get => (int)row["DstAssetIdRangeMin"].Value;
            set => row["DstAssetIdRangeMin"].Value = value;
        }

        // Unknown.
        public int DstAssetIdRangeMax
        {
            get => (int)row["DstAssetIdRangeMax"].Value;
            set => row["DstAssetIdRangeMax"].Value = value;
        }

        // Unknown.
        public sbyte LimitedMapRegionId0
        {
            get => (sbyte)row["LimitedMapRegionId0"].Value;
            set => row["LimitedMapRegionId0"].Value = value;
        }

        // Unknown.
        public sbyte LimitedMapRegionId1
        {
            get => (sbyte)row["LimitedMapRegionId1"].Value;
            set => row["LimitedMapRegionId1"].Value = value;
        }

        // Unknown.
        public sbyte LimitedMapRegionId2
        {
            get => (sbyte)row["LimitedMapRegionId2"].Value;
            set => row["LimitedMapRegionId2"].Value = value;
        }

        // Unknown.
        public sbyte LimitedMapRegionId3
        {
            get => (sbyte)row["LimitedMapRegionId3"].Value;
            set => row["LimitedMapRegionId3"].Value = value;
        }

        // Unknown.
        public int LimitedMapRegionAssetId
        {
            get => (int)row["LimitedMapRegionAssetId"].Value;
            set => row["LimitedMapRegionAssetId"].Value = value;
        }

        // Unknown.
        public int LimitedMapRegioAssetPartsNo
        {
            get => (int)row["LimitedMapRegioAssetPartsNo"].Value;
            set => row["LimitedMapRegioAssetPartsNo"].Value = value;
        }

        // Unknown.
        public int LimitedMapRegioAssetIdRangeMin
        {
            get => (int)row["LimitedMapRegioAssetIdRangeMin"].Value;
            set => row["LimitedMapRegioAssetIdRangeMin"].Value = value;
        }

        // Unknown.
        public int LimitedMapRegioAssetIdRangeMax
        {
            get => (int)row["LimitedMapRegioAssetIdRangeMax"].Value;
            set => row["LimitedMapRegioAssetIdRangeMax"].Value = value;
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
    public LEGACY_DISTANT_VIEW_PARTS_REPLACE_PARAM(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public LEGACY_DISTANT_VIEW_PARTS_REPLACE_PARAM(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
