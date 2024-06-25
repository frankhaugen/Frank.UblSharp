using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the total tax for a particular taxation scheme.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tax Total. Details
/// <para />ObjectClass: Tax Total
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TaxTotalType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__TaxAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RoundingAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__RoundingAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxEvidenceIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IndicatorType @__TaxEvidenceIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxIncludedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IndicatorType @__TaxIncludedIndicator;
        
    private System.Collections.Generic.List<TaxSubtotalType> _taxSubtotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxSubtotal", Order=4)]
    public TaxSubtotalType[] @__TaxSubtotal
    {
        get
        {
            return _taxSubtotal?.ToArray();
        }
        set
        {
            _taxSubtotal = value == null ? null : new System.Collections.Generic.List<TaxSubtotalType>(value);
        }
    }
        
    /// <summary>
    /// One of the subtotals the sum of which equals the total tax amount for a particular taxation scheme.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tax Total. Tax Subtotal
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tax Total
    /// <para />PropertyTerm: Tax Subtotal
    /// <para />AssociatedObjectClass: Tax Subtotal
    /// <para />RepresentationTerm: Tax Subtotal
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TaxSubtotalType> TaxSubtotal
    {
        get { return _taxSubtotal ?? (_taxSubtotal = new System.Collections.Generic.List<TaxSubtotalType>()); }
        set { _taxSubtotal = value; }
    }

        
    /// <summary>
    /// The total tax amount for a particular taxation scheme, e.g., VAT; the sum of the tax subtotals for each tax category within the taxation scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Total. Tax Amount. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Tax Total
    /// <para />PropertyTerm: Tax Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TaxAmount
    {
        get
        {
            if (__TaxAmount == null) { __TaxAmount = new AmountType(); }
            return __TaxAmount;
        }
        set
        {
            __TaxAmount = value;
        }
    }

        
    /// <summary>
    /// The rounding amount (positive or negative) added to the calculated tax total to produce the rounded TaxAmount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Total. Rounding Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Total
    /// <para />PropertyTerm: Rounding Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType RoundingAmount
    {
        get
        {
            if (__RoundingAmount == null) { __RoundingAmount = new AmountType(); }
            return __RoundingAmount;
        }
        set
        {
            __RoundingAmount = value;
        }
    }

        
    /// <summary>
    /// An indicator that this total is recognized as legal evidence for taxation purposes (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Total. Tax Evidence_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Total
    /// <para />PropertyTermQualifier: Tax Evidence
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType TaxEvidenceIndicator
    {
        get
        {
            if (__TaxEvidenceIndicator == null) { __TaxEvidenceIndicator = new IndicatorType(); }
            return __TaxEvidenceIndicator;
        }
        set
        {
            __TaxEvidenceIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that tax is included in the calculation (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Total. Tax Included_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Total
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

}