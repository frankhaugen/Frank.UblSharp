using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class defining budgeted monetary amounts.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Requested Tender Total. Details
/// <para />ObjectClass: Requested Tender Total
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RequestedTenderTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RequestedTenderTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RequestedTenderTotalType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedOverallContractAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__EstimatedOverallContractAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__TotalAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxIncludedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IndicatorType @__TaxIncludedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__MinimumAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__MaximumAmount;
        
    private System.Collections.Generic.List<TextType> _monetaryScope;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MonetaryScope", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__MonetaryScope
    {
        get
        {
            return _monetaryScope?.ToArray();
        }
        set
        {
            _monetaryScope = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AverageSubsequentContractAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__AverageSubsequentContractAmount;
        
    private System.Collections.Generic.List<TaxCategoryType> _applicableTaxCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory", Order=7)]
    public TaxCategoryType[] @__ApplicableTaxCategory
    {
        get
        {
            return _applicableTaxCategory?.ToArray();
        }
        set
        {
            _applicableTaxCategory = value == null ? null : new System.Collections.Generic.List<TaxCategoryType>(value);
        }
    }
        
    /// <summary>
    /// A description of the monetary scope of the budget.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Monetary Scope. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTerm: Monetary Scope
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> MonetaryScope
    {
        get { return _monetaryScope ?? (_monetaryScope = new System.Collections.Generic.List<TextType>()); }
        set { _monetaryScope = value; }
    }

        
    /// <summary>
    /// Describes the categories of taxes that apply to the budget amount.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Applicable_ Tax Category. Tax Category
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTermQualifier: Applicable
    /// <para />PropertyTerm: Tax Category
    /// <para />AssociatedObjectClass: Tax Category
    /// <para />RepresentationTerm: Tax Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TaxCategoryType> ApplicableTaxCategory
    {
        get { return _applicableTaxCategory ?? (_applicableTaxCategory = new System.Collections.Generic.List<TaxCategoryType>()); }
        set { _applicableTaxCategory = value; }
    }

        
    /// <summary>
    /// The estimated overall monetary amount of a contract.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Estimated_ Overall Contract. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTermQualifier: Estimated
    /// <para />PropertyTerm: Overall Contract
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType EstimatedOverallContractAmount
    {
        get
        {
            if (__EstimatedOverallContractAmount == null) { __EstimatedOverallContractAmount = new AmountType(); }
            return __EstimatedOverallContractAmount;
        }
        set
        {
            __EstimatedOverallContractAmount = value;
        }
    }

        
    /// <summary>
    /// The monetary amount of the total budget including net amount, taxes, and material and instalment costs.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Total_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TotalAmount
    {
        get
        {
            if (__TotalAmount == null) { __TotalAmount = new AmountType(); }
            return __TotalAmount;
        }
        set
        {
            __TotalAmount = value;
        }
    }

        
    /// <summary>
    /// Indicates whether the amounts are taxes included (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Tax Included_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTermQualifier: Tax Included
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType TaxIncludedIndicator
    {
        get
        {
            if (__TaxIncludedIndicator == null) { __TaxIncludedIndicator = new IndicatorType(); }
            return __TaxIncludedIndicator;
        }
        set
        {
            __TaxIncludedIndicator = value;
        }
    }

        
    /// <summary>
    /// The minimum monetary amount of the budget.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Minimum_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MinimumAmount
    {
        get
        {
            if (__MinimumAmount == null) { __MinimumAmount = new AmountType(); }
            return __MinimumAmount;
        }
        set
        {
            __MinimumAmount = value;
        }
    }

        
    /// <summary>
    /// The maximum monetary amount of the budget.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Maximum_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MaximumAmount
    {
        get
        {
            if (__MaximumAmount == null) { __MaximumAmount = new AmountType(); }
            return __MaximumAmount;
        }
        set
        {
            __MaximumAmount = value;
        }
    }

        
    /// <summary>
    /// The average monetary amount for the subsequent contracts following this budget amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Requested Tender Total. Average_ Subsequent Contract. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Requested Tender Total
    /// <para />PropertyTermQualifier: Average
    /// <para />PropertyTerm: Subsequent Contract
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType AverageSubsequentContractAmount
    {
        get
        {
            if (__AverageSubsequentContractAmount == null) { __AverageSubsequentContractAmount = new AmountType(); }
            return __AverageSubsequentContractAmount;
        }
        set
        {
            __AverageSubsequentContractAmount = value;
        }
    }

}