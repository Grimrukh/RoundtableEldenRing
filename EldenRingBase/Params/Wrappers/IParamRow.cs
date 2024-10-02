using SoulsFormats;

namespace EldenRingBase.Params.Wrappers;

public interface IParamRow
{
    public PARAM.Row InternalRow { get; }
    public int ID { get; }
    
    // Other fields.
    
    public object this[string fieldName] { get; set; }
}