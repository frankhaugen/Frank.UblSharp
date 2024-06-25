using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a name/value pair for a property of an inventory planning activity.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Activity Property. Details
/// <para />ObjectClass: Activity Property
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ActivityProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActivityProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ActivityPropertyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Value", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__Value;
        
    /// <summary>
    /// The name of this activity property.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Activity Property. Name
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Activity Property
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType Name
    {
        get
        {
            if (__Name == null) { __Name = new NameType(); }
            return __Name;
        }
        set
        {
            __Name = value;
        }
    }

        
    /// <summary>
    /// The value of this activity property.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Activity Property. Value. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Activity Property
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Value
    {
        get
        {
            if (__Value == null) { __Value = new TextType(); }
            return __Value;
        }
        set
        {
            __Value = value;
        }
    }

}