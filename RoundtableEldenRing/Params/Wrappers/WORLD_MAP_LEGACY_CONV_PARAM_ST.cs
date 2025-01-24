using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class WORLD_MAP_LEGACY_CONV_PARAM_ST
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
        public byte srcAreaNo
        {
            get => (byte)row["srcAreaNo"].Value;
            set => row["srcAreaNo"].Value = value;
        }

        // Unknown.
        public byte srcGridXNo
        {
            get => (byte)row["srcGridXNo"].Value;
            set => row["srcGridXNo"].Value = value;
        }

        // Unknown.
        public byte srcGridZNo
        {
            get => (byte)row["srcGridZNo"].Value;
            set => row["srcGridZNo"].Value = value;
        }

        // Unknown.
        public float srcPosX
        {
            get => (float)row["srcPosX"].Value;
            set => row["srcPosX"].Value = value;
        }

        // Unknown.
        public float srcPosY
        {
            get => (float)row["srcPosY"].Value;
            set => row["srcPosY"].Value = value;
        }

        // Unknown.
        public float srcPosZ
        {
            get => (float)row["srcPosZ"].Value;
            set => row["srcPosZ"].Value = value;
        }

        // Unknown.
        public byte dstAreaNo
        {
            get => (byte)row["dstAreaNo"].Value;
            set => row["dstAreaNo"].Value = value;
        }

        // Unknown.
        public byte dstGridXNo
        {
            get => (byte)row["dstGridXNo"].Value;
            set => row["dstGridXNo"].Value = value;
        }

        // Unknown.
        public byte dstGridZNo
        {
            get => (byte)row["dstGridZNo"].Value;
            set => row["dstGridZNo"].Value = value;
        }

        // Unknown.
        public float dstPosX
        {
            get => (float)row["dstPosX"].Value;
            set => row["dstPosX"].Value = value;
        }

        // Unknown.
        public float dstPosY
        {
            get => (float)row["dstPosY"].Value;
            set => row["dstPosY"].Value = value;
        }

        // Unknown.
        public float dstPosZ
        {
            get => (float)row["dstPosZ"].Value;
            set => row["dstPosZ"].Value = value;
        }

        // Unknown.
        public byte isBasePoint
        {
            get => (byte)row["isBasePoint"].Value;
            set => row["isBasePoint"].Value = value;
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
    public WORLD_MAP_LEGACY_CONV_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WORLD_MAP_LEGACY_CONV_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
