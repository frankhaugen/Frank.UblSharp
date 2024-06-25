using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define the subtotal for a particular tax category within a particular taxation scheme, such as standard rate within VAT.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tax Subtotal. Details
/// <para />ObjectClass: Tax Subtotal
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TaxSubtotalType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__TaxableAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__TaxAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CalculationSequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public NumericType @__CalculationSequenceNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransactionCurrencyTaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__TransactionCurrencyTaxAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public PercentType @__Percent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BaseUnitMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public MeasureType @__BaseUnitMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerUnitAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__PerUnitAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TierRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__TierRange;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TierRatePercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public PercentType @__TierRatePercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxCategory", Order=9)]
    public TaxCategoryType @__TaxCategory;
        
    /// <summary>
    /// The net amount to which the tax percent (rate) is applied to calculate the tax amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Taxable_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTermQualifier: Taxable
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TaxableAmount
    {
        get
        {
            if (__TaxableAmount == null) { __TaxableAmount = new AmountType(); }
            return __TaxableAmount;
        }
        set
        {
            __TaxableAmount = value;
        }
    }

        
    /// <summary>
    /// The amount of this tax subtotal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Tax Amount. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Tax Subtotal
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
    /// The number of this tax subtotal in the sequence of subtotals corresponding to the order in which multiple taxes are applied. If all taxes are applied to the same taxable amount (i.e., their order of application is inconsequential), then CalculationSequenceNumeric is 1 for all tax subtotals applied to a given amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Calculation Sequence. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTerm: Calculation Sequence
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType CalculationSequenceNumeric
    {
        get
        {
            if (__CalculationSequenceNumeric == null) { __CalculationSequenceNumeric = new NumericType(); }
            return __CalculationSequenceNumeric;
        }
        set
        {
            __CalculationSequenceNumeric = value;
        }
    }

        
    /// <summary>
    /// The amount of this tax subtotal, expressed in the currency used for invoicing.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Transaction Currency_ Tax Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTermQualifier: Transaction Currency
    /// <para />PropertyTerm: Tax Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TransactionCurrencyTaxAmount
    {
        get
        {
            if (__TransactionCurrencyTaxAmount == null) { __TransactionCurrencyTaxAmount = new AmountType(); }
            return __TransactionCurrencyTaxAmount;
        }
        set
        {
            __TransactionCurrencyTaxAmount = value;
        }
    }

        
    /// <summary>
    /// The tax rate of the tax category applied to this tax subtotal, expressed as a percentage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTerm: Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType Percent
    {
        get
        {
            if (__Percent == null) { __Percent = new PercentType(); }
            return __Percent;
        }
        set
        {
            __Percent = value;
        }
    }

        
    /// <summary>
    /// The unit of measure on which the tax calculation is based
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Base Unit Measure. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTerm: Base Unit Measure
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType BaseUnitMeasure
    {
        get
        {
            if (__BaseUnitMeasure == null) { __BaseUnitMeasure = new MeasureType(); }
            return __BaseUnitMeasure;
        }
        set
        {
            __BaseUnitMeasure = value;
        }
    }

        
    /// <summary>
    /// Where a tax is applied at a certain rate per unit, the rate per unit applied.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Per Unit_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTermQualifier: Per Unit
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PerUnitAmount
    {
        get
        {
            if (__PerUnitAmount == null) { __PerUnitAmount = new AmountType(); }
            return __PerUnitAmount;
        }
        set
        {
            __PerUnitAmount = value;
        }
    }

        
    /// <summary>
    /// Where a tax is tiered, the range of taxable amounts that determines the rate of tax applicable to this tax subtotal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Tier Range. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTerm: Tier Range
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TierRange
    {
        get
        {
            if (__TierRange == null) { __TierRange = new TextType(); }
            return __TierRange;
        }
        set
        {
            __TierRange = value;
        }
    }

        
    /// <summary>
    /// Where a tax is tiered, the tax rate that applies within a specified range of taxable amounts for this tax subtotal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Tier Rate. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTerm: Tier Rate
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType TierRatePercent
    {
        get
        {
            if (__TierRatePercent == null) { __TierRatePercent = new PercentType(); }
            return __TierRatePercent;
        }
        set
        {
            __TierRatePercent = value;
        }
    }

        
    /// <summary>
    /// The tax category applicable to this subtotal.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tax Subtotal. Tax Category
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Tax Subtotal
    /// <para />PropertyTerm: Tax Category
    /// <para />AssociatedObjectClass: Tax Category
    /// <para />RepresentationTerm: Tax Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TaxCategoryType TaxCategory
    {
        get
        {
            if (__TaxCategory == null) { __TaxCategory = new TaxCategoryType(); }
            return __TaxCategory;
        }
        set
        {
            __TaxCategory = value;
        }
    }

}