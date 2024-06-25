using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A counted number of non-monetary units, possibly including a fractional part.
/// <para />UniqueID: UBLUDT0000018
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Quantity. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Quantity
/// <para />PrimitiveType: decimal
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("QuantityType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class QuantityType : CctQuantityType
{
        
    public static implicit operator QuantityType(decimal value)
    {
        return new QuantityType { Value = value };
    }

    public static implicit operator decimal(QuantityType value)
    {
        return value.Value;
    }

}