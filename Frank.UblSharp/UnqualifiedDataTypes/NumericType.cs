using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
/// <para />UniqueID: UBLUDT0000014
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Numeric. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Numeric
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("NumericType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class NumericType : CctNumericType
{
        
    public static implicit operator NumericType(decimal value)
    {
        return new NumericType { Value = value };
    }

    public static implicit operator decimal(NumericType value)
    {
        return value.Value;
    }

}