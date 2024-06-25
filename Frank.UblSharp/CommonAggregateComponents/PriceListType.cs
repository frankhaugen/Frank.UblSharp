using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a price list.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Price List. Details
/// <para />ObjectClass: Price List
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PreviousPriceList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PreviousPriceList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PriceListType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__StatusCode;
        
    private System.Collections.Generic.List<PeriodType> _validityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=2)]
    public PeriodType[] @__ValidityPeriod
    {
        get
        {
            return _validityPeriod?.ToArray();
        }
        set
        {
            _validityPeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousPriceList", Order=3)]
    public PriceListType @__PreviousPriceList;
        
    /// <summary>
    /// A period during which this price list is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Price List. Validity_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Price List
    /// <para />PropertyTermQualifier: Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PeriodType> ValidityPeriod
    {
        get { return _validityPeriod ?? (_validityPeriod = new System.Collections.Generic.List<PeriodType>()); }
        set { _validityPeriod = value; }
    }

        
    /// <summary>
    /// An identifier for this price list.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Price List. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price List
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// A code signifying whether this price list is an original, copy, revision, or cancellation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Price List. Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price List
    /// <para />PropertyTerm: Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>new - announcement only , new and available , deleted - announcement only</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType StatusCode
    {
        get
        {
            if (__StatusCode == null) { __StatusCode = new CodeType(); }
            return __StatusCode;
        }
        set
        {
            __StatusCode = value;
        }
    }

        
    /// <summary>
    /// The previous price list.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Price List. Previous_ Price List. Price List
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price List
    /// <para />PropertyTermQualifier: Previous
    /// <para />PropertyTerm: Price List
    /// <para />AssociatedObjectClass: Price List
    /// <para />RepresentationTerm: Price List
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PriceListType PreviousPriceList
    {
        get
        {
            if (__PreviousPriceList == null) { __PreviousPriceList = new PriceListType(); }
            return __PreviousPriceList;
        }
        set
        {
            __PreviousPriceList = value;
        }
    }

}