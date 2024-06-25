using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
/// <para />UniqueID: UBLUDT0000015
/// <para />CategoryCode: UDT
/// <para />VersionID: 1.0
/// <para />DictionaryEntryName: Value. Type
/// <para />RepresentationTermName: Value
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ValueType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class ValueType : CctNumericType
{
        
    public static implicit operator ValueType(decimal value)
    {
        return new ValueType { Value = value };
    }

    public static implicit operator decimal(ValueType value)
    {
        return value.Value;
    }

}