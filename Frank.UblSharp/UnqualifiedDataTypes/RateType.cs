using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A numeric expression of a rate that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
/// <para />UniqueID: UBLUDT0000017
/// <para />CategoryCode: UDT
/// <para />VersionID: 1.0
/// <para />DictionaryEntryName: Rate. Type
/// <para />RepresentationTermName: Rate
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RateType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class RateType : CctNumericType
{
        
    public static implicit operator RateType(decimal value)
    {
        return new RateType { Value = value };
    }

    public static implicit operator decimal(RateType value)
    {
        return value.Value;
    }

}