using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define an unstructured address line.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Address Line. Details
/// <para />ObjectClass: Address Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AddressLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AddressLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AddressLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Line", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__Line;
        
    /// <summary>
    /// An address line expressed as unstructured text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address Line. Line. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Address Line
    /// <para />PropertyTerm: Line
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>123 Standard Chartered Tower</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Line
    {
        get
        {
            if (__Line == null) { __Line = new TextType(); }
            return __Line;
        }
        set
        {
            __Line = value;
        }
    }

}