using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A numeric value determined by measuring an object using a specified unit of measure.
/// <para />UniqueID: UBLUDT0000013
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Measure. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Measure
/// <para />PropertyTermName: Type
/// <para />PrimitiveType: decimal
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("MeasureType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class MeasureType : CctMeasureType
{
}