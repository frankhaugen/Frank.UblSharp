using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the bond guarantee of a tenderer or bid submitter&apos;s actual entry into a contract in the event that it is the successful bidder.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Financial Guarantee. Details
/// <para />ObjectClass: Financial Guarantee
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("FinalFinancialGuarantee", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("FinalFinancialGuarantee", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class FinancialGuaranteeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GuaranteeTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__GuaranteeTypeCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute("LiabilityAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__LiabilityAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AmountRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public RateType @__AmountRate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConstitutionPeriod", Order=4)]
    public PeriodType @__ConstitutionPeriod;
        
    /// <summary>
    /// Text describing this financial guarantee.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Financial Guarantee. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Financial Guarantee
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
    /// A code signifying the type of financial guarantee. For instance &quot;Provisional Guarantee&quot; or &quot;Final Guarantee&quot;
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Financial Guarantee. Guarantee Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Financial Guarantee
    /// <para />PropertyTerm: Guarantee Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType GuaranteeTypeCode
    {
        get
        {
            if (__GuaranteeTypeCode == null) { __GuaranteeTypeCode = new CodeType(); }
            return __GuaranteeTypeCode;
        }
        set
        {
            __GuaranteeTypeCode = value;
        }
    }

        
    /// <summary>
    /// The amount of liability in this financial guarantee.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Financial Guarantee. Liability. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Financial Guarantee
    /// <para />PropertyTerm: Liability
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType LiabilityAmount
    {
        get
        {
            if (__LiabilityAmount == null) { __LiabilityAmount = new AmountType(); }
            return __LiabilityAmount;
        }
        set
        {
            __LiabilityAmount = value;
        }
    }

        
    /// <summary>
    /// The rate used to calculate the amount of liability in this financial guarantee.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Financial Guarantee. Amount. Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Financial Guarantee
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Rate
    /// <para />DataType: Rate. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RateType AmountRate
    {
        get
        {
            if (__AmountRate == null) { __AmountRate = new RateType(); }
            return __AmountRate;
        }
        set
        {
            __AmountRate = value;
        }
    }

        
    /// <summary>
    /// The period during the tendering process to which this financial guarantee has to be settled.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Financial Guarantee. Constitution_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Financial Guarantee
    /// <para />PropertyTermQualifier: Constitution
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ConstitutionPeriod
    {
        get
        {
            if (__ConstitutionPeriod == null) { __ConstitutionPeriod = new PeriodType(); }
            return __ConstitutionPeriod;
        }
        set
        {
            __ConstitutionPeriod = value;
        }
    }

}