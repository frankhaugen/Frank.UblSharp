using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class for describing the terms of a trade agreement.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Trading Terms. Details
/// <para />ObjectClass: Trading Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("HaulageTradingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("HaulageTradingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TradingTermsType
{
        
    private System.Collections.Generic.List<TextType> _information;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType[] @__Information
    {
        get
        {
            return _information?.ToArray();
        }
        set
        {
            _information = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Reference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__Reference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ApplicableAddress", Order=2)]
    public AddressType @__ApplicableAddress;
        
    /// <summary>
    /// Text describing the terms of a trade agreement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Trading Terms. Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Trading Terms
    /// <para />PropertyTerm: Information
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Unless credit terms have been expressly agreed by Dell, payment for the products or services shall be made in full before physical delivery of products or services. Customer shall pay for all shipping and handling charges.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Information
    {
        get { return _information ?? (_information = new System.Collections.Generic.List<TextType>()); }
        set { _information = value; }
    }

        
    /// <summary>
    /// A reference quoting the basis of the terms
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Trading Terms. Reference. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Trading Terms
    /// <para />PropertyTerm: Reference
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>http://www1.ap.dell.com/content/topics/topic.aspx/ap/policy/en/au/sales_terms_au?c=au&amp;l=en&amp;s=gen</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Reference
    {
        get
        {
            if (__Reference == null) { __Reference = new TextType(); }
            return __Reference;
        }
        set
        {
            __Reference = value;
        }
    }

        
    /// <summary>
    /// The address at which these trading terms apply.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Trading Terms. Applicable_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Trading Terms
    /// <para />PropertyTermQualifier: Applicable
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType ApplicableAddress
    {
        get
        {
            if (__ApplicableAddress == null) { __ApplicableAddress = new AddressType(); }
            return __ApplicableAddress;
        }
        set
        {
            __ApplicableAddress = value;
        }
    }

}