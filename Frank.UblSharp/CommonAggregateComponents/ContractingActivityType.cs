using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The nature of the type of business of the organization.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Contracting Activity. Details
/// <para />ObjectClass: Contracting Activity
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ContractingActivity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractingActivity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ContractingActivityType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActivityTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__ActivityTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActivityType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__ActivityType;
        
    /// <summary>
    /// A code specifying the nature of the type of business of the organization.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contracting Activity. Activity Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contracting Activity
    /// <para />PropertyTerm: Activity Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ActivityTypeCode
    {
        get
        {
            if (__ActivityTypeCode == null) { __ActivityTypeCode = new CodeType(); }
            return __ActivityTypeCode;
        }
        set
        {
            __ActivityTypeCode = value;
        }
    }

        
    /// <summary>
    /// The nature of the type of business of the organization, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contracting Activity. Activity Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contracting Activity
    /// <para />PropertyTerm: Activity Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ActivityType
    {
        get
        {
            if (__ActivityType == null) { __ActivityType = new TextType(); }
            return __ActivityType;
        }
        set
        {
            __ActivityType = value;
        }
    }

}