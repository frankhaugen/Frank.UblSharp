using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A character string that constitutes the distinctive designation of a person, place, thing or concept.
/// <para />UniqueID: UBLUDT0000020
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Name. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Name
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("NameType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class NameType : CctTextType
{
        
    public static implicit operator NameType(string value)
    {
        return value == null ? null : new NameType { Value = value };
    }

    public static implicit operator string(NameType value)
    {
        return value.Value;
    }

}