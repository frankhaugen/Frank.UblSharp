﻿using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A diagram, graph, mathematical curve, or similar representation.
/// <para />UniqueID: UBLUDT000003
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Graphic. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Graphic
/// <para />PrimitiveType: binary
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("GraphicType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class GraphicType : CctBinaryObjectType
{
}