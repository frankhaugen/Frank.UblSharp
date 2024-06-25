using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// Numeric information that is assigned or is determined by calculation, counting, or sequencing and is expressed as a percentage. It does not require a unit of quantity or unit of measure.
/// <para />UniqueID: UBLUDT0000016
/// <para />CategoryCode: UDT
/// <para />VersionID: 1.0
/// <para />DictionaryEntryName: Percent. Type
/// <para />RepresentationTermName: Percent
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PercentType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class PercentType : CctNumericType
{
        
    public static implicit operator PercentType(decimal value)
    {
        return new PercentType { Value = value };
    }

    public static implicit operator decimal(PercentType value)
    {
        return value.Value;
    }

}