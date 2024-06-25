using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A set of finite-length sequences of binary octets.
/// <para />UniqueID: UBLUDT000002
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Binary Object. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Binary Object
/// <para />PrimitiveType: binary
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("BinaryObjectType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class BinaryObjectType : CctBinaryObjectType
{
}