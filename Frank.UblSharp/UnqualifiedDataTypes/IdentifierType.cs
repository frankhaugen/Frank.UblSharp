using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A character string to identify and uniquely distinguish one instance of an object in an identification scheme from all other objects in the same scheme, together with relevant supplementary information.
/// <para />UniqueID: UBLUDT0000011
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Identifier. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Identifier
/// <para />PrimitiveType: string
/// <para />UsageRule: Other supplementary components in the CCT are captured as part of the token and name for the schema module containing the identifier list and thus, are not declared as attributes.
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IdentifierType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class IdentifierType : CctIdentifierType
{
        
    public static implicit operator IdentifierType(string value)
    {
        return value == null ? null : new IdentifierType { Value = value };
    }

    public static implicit operator string(IdentifierType value)
    {
        return value.Value;
    }

}