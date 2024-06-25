using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the distribution of a document to an interested party.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Document Distribution. Details
/// <para />ObjectClass: Document Distribution
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DocumentDistribution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DocumentDistribution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DocumentDistributionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrintQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__PrintQualifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumCopiesNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NumericType @__MaximumCopiesNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=2)]
    public PartyType @__Party;
        
    /// <summary>
    /// Text describing the interested party&apos;s distribution rights.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Distribution. Print_ Qualifier. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Document Distribution
    /// <para />PropertyTermQualifier: Print
    /// <para />PropertyTerm: Qualifier
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PrintQualifier
    {
        get
        {
            if (__PrintQualifier == null) { __PrintQualifier = new TextType(); }
            return __PrintQualifier;
        }
        set
        {
            __PrintQualifier = value;
        }
    }

        
    /// <summary>
    /// The maximum number of printed copies of the document that the interested party is allowed to make.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Distribution. Maximum_ Copies. Numeric
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Document Distribution
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Copies
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType MaximumCopiesNumeric
    {
        get
        {
            if (__MaximumCopiesNumeric == null) { __MaximumCopiesNumeric = new NumericType(); }
            return __MaximumCopiesNumeric;
        }
        set
        {
            __MaximumCopiesNumeric = value;
        }
    }

        
    /// <summary>
    /// The interested party to which the document should be distributed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Distribution. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Document Distribution
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType Party
    {
        get
        {
            if (__Party == null) { __Party = new PartyType(); }
            return __Party;
        }
        set
        {
            __Party = value;
        }
    }

}