using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe subcontract terms for a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Subcontract Terms. Details
/// <para />ObjectClass: Subcontract Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AllowedSubcontractTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AllowedSubcontractTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class SubcontractTermsType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Rate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public RateType @__Rate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnknownPriceIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IndicatorType @__UnknownPriceIndicator;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubcontractingConditionsCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__SubcontractingConditionsCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public PercentType @__MaximumPercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public PercentType @__MinimumPercent;
        
    /// <summary>
    /// Text describing the subcontract terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subcontract Terms. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Subcontract Terms
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// MF: I agree with the query. Rate?
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subcontract Terms. Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subcontract Terms
    /// <para />PropertyTerm: Rate
    /// <para />RepresentationTerm: Rate
    /// <para />DataType: Rate. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RateType Rate
    {
        get
        {
            if (__Rate == null) { __Rate = new RateType(); }
            return __Rate;
        }
        set
        {
            __Rate = value;
        }
    }

        
    /// <summary>
    /// An indicator that the subcontract price is known (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subcontract Terms. Unknown_ Price. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subcontract Terms
    /// <para />PropertyTermQualifier: Unknown
    /// <para />PropertyTerm: Price
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType UnknownPriceIndicator
    {
        get
        {
            if (__UnknownPriceIndicator == null) { __UnknownPriceIndicator = new IndicatorType(); }
            return __UnknownPriceIndicator;
        }
        set
        {
            __UnknownPriceIndicator = value;
        }
    }

        
    /// <summary>
    /// The monetary amount assigned to the subcontracted task.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subcontract Terms. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subcontract Terms
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType Amount
    {
        get
        {
            if (__Amount == null) { __Amount = new AmountType(); }
            return __Amount;
        }
        set
        {
            __Amount = value;
        }
    }

        
    /// <summary>
    /// A code specifying the conditions for subcontracting.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subcontract Terms. Subcontracting Conditions Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subcontract Terms
    /// <para />PropertyTerm: Subcontracting Conditions Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SubcontractingConditionsCode
    {
        get
        {
            if (__SubcontractingConditionsCode == null) { __SubcontractingConditionsCode = new CodeType(); }
            return __SubcontractingConditionsCode;
        }
        set
        {
            __SubcontractingConditionsCode = value;
        }
    }

        
    /// <summary>
    /// The maximum percentage allowed to be subcontracted.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subcontract Terms. Maximum_ Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subcontract Terms
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType MaximumPercent
    {
        get
        {
            if (__MaximumPercent == null) { __MaximumPercent = new PercentType(); }
            return __MaximumPercent;
        }
        set
        {
            __MaximumPercent = value;
        }
    }

        
    /// <summary>
    /// The minimum percentage allowed to be subcontracted.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subcontract Terms. Minimum_ Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subcontract Terms
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType MinimumPercent
    {
        get
        {
            if (__MinimumPercent == null) { __MinimumPercent = new PercentType(); }
            return __MinimumPercent;
        }
        set
        {
            __MinimumPercent = value;
        }
    }

}