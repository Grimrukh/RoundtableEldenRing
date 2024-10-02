using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class GRASS_TYPE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        public ushort lodRange
        {
            get => (ushort)row["lodRange"].Value;
            set => row["lodRange"].Value = value;
        }

        public byte lod0ClusterType
        {
            get => (byte)row["lod0ClusterType"].Value;
            set => row["lod0ClusterType"].Value = value;
        }

        public byte lod1ClusterType
        {
            get => (byte)row["lod1ClusterType"].Value;
            set => row["lod1ClusterType"].Value = value;
        }

        public byte lod2ClusterType
        {
            get => (byte)row["lod2ClusterType"].Value;
            set => row["lod2ClusterType"].Value = value;
        }

        public byte distributionType
        {
            get => (byte)row["distributionType"].Value;
            set => row["distributionType"].Value = value;
        }

        public float baseDensity
        {
            get => (float)row["baseDensity"].Value;
            set => row["baseDensity"].Value = value;
        }

        public string model0Name
        {
            get => (string)row["model0Name"].Value;
            set => row["model0Name"].Value = value;
        }

        public string flatTextureName
        {
            get => (string)row["flatTextureName"].Value;
            set => row["flatTextureName"].Value = value;
        }

        public string billboardTextureName
        {
            get => (string)row["billboardTextureName"].Value;
            set => row["billboardTextureName"].Value = value;
        }

        public byte normalInfluence
        {
            get => (byte)row["normalInfluence"].Value;
            set => row["normalInfluence"].Value = value;
        }

        public byte inclinationMax
        {
            get => (byte)row["inclinationMax"].Value;
            set => row["inclinationMax"].Value = value;
        }

        public byte inclinationJitter
        {
            get => (byte)row["inclinationJitter"].Value;
            set => row["inclinationJitter"].Value = value;
        }

        public byte scaleBaseMin
        {
            get => (byte)row["scaleBaseMin"].Value;
            set => row["scaleBaseMin"].Value = value;
        }

        public byte scaleBaseMax
        {
            get => (byte)row["scaleBaseMax"].Value;
            set => row["scaleBaseMax"].Value = value;
        }

        public byte scaleHeightMin
        {
            get => (byte)row["scaleHeightMin"].Value;
            set => row["scaleHeightMin"].Value = value;
        }

        public byte scaleHeightMax
        {
            get => (byte)row["scaleHeightMax"].Value;
            set => row["scaleHeightMax"].Value = value;
        }

        public byte colorShade1_r
        {
            get => (byte)row["colorShade1_r"].Value;
            set => row["colorShade1_r"].Value = value;
        }

        public byte colorShade1_g
        {
            get => (byte)row["colorShade1_g"].Value;
            set => row["colorShade1_g"].Value = value;
        }

        public byte colorShade1_b
        {
            get => (byte)row["colorShade1_b"].Value;
            set => row["colorShade1_b"].Value = value;
        }

        public byte colorShade2_r
        {
            get => (byte)row["colorShade2_r"].Value;
            set => row["colorShade2_r"].Value = value;
        }

        public byte colorShade2_g
        {
            get => (byte)row["colorShade2_g"].Value;
            set => row["colorShade2_g"].Value = value;
        }

        public byte colorShade2_b
        {
            get => (byte)row["colorShade2_b"].Value;
            set => row["colorShade2_b"].Value = value;
        }

        public byte flatSplitType
        {
            get => (byte)row["flatSplitType"].Value;
            set => row["flatSplitType"].Value = value;
        }

        public byte flatBladeCount
        {
            get => (byte)row["flatBladeCount"].Value;
            set => row["flatBladeCount"].Value = value;
        }

        public sbyte flatSlant
        {
            get => (sbyte)row["flatSlant"].Value;
            set => row["flatSlant"].Value = value;
        }

        public float flatRadius
        {
            get => (float)row["flatRadius"].Value;
            set => row["flatRadius"].Value = value;
        }

        public byte castShadow
        {
            get => (byte)row["castShadow"].Value;
            set => row["castShadow"].Value = value;
        }

        public byte windAmplitude
        {
            get => (byte)row["windAmplitude"].Value;
            set => row["windAmplitude"].Value = value;
        }

        public byte windCycle
        {
            get => (byte)row["windCycle"].Value;
            set => row["windCycle"].Value = value;
        }

        // Unknown.
        public float orientationAngle
        {
            get => (float)row["orientationAngle"].Value;
            set => row["orientationAngle"].Value = value;
        }

        public float orientationRange
        {
            get => (float)row["orientationRange"].Value;
            set => row["orientationRange"].Value = value;
        }

        public float spacing
        {
            get => (float)row["spacing"].Value;
            set => row["spacing"].Value = value;
        }

        public byte dithering
        {
            get => (byte)row["dithering"].Value;
            set => row["dithering"].Value = value;
        }

        public string simpleModelName
        {
            get => (string)row["simpleModelName"].Value;
            set => row["simpleModelName"].Value = value;
        }

        public string model1Name
        {
            get => (string)row["model1Name"].Value;
            set => row["model1Name"].Value = value;
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
    public GRASS_TYPE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public GRASS_TYPE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
