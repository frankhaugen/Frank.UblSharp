using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// An audio representation.
/// <para />UniqueID: UBLUDT000005
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Sound. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Sound
/// <para />PrimitiveType: binary
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SoundType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class SoundType : CctBinaryObjectType
{
}