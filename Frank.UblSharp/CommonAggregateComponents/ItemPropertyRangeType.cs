using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a range of values for an item property.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Property Range. Details
/// <para />ObjectClass: Item Property Range
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ItemPropertyRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemPropertyRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemPropertyRangeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__MinimumValue;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__MaximumValue;
        
    /// <summary>
    /// The minimum value in this range of values.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property Range. Minimum_ Value. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property Range
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MinimumValue
    {
        get
        {
            if (__MinimumValue == null) { __MinimumValue = new TextType(); }
            return __MinimumValue;
        }
        set
        {
            __MinimumValue = value;
        }
    }

        
    /// <summary>
    /// The maximum value in this range of values.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property Range. Maximum_ Value. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property Range
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MaximumValue
    {
        get
        {
            if (__MaximumValue == null) { __MaximumValue = new TextType(); }
            return __MaximumValue;
        }
        set
        {
            __MaximumValue = value;
        }
    }

}