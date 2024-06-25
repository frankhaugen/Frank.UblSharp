using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A video representation.
/// <para />UniqueID: UBLUDT000006
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Video. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Video
/// <para />PrimitiveType: binary
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("VideoType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class VideoType : CctBinaryObjectType
{
}