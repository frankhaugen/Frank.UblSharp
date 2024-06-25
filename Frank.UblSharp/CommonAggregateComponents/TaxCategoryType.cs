using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe one of the tax categories within a taxation scheme (e.g., High Rate VAT, Low Rate VAT).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tax Category. Details
/// <para />ObjectClass: Tax Category
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ApplicableTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ApplicableTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TaxCategoryType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public PercentType @__Percent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BaseUnitMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public MeasureType @__BaseUnitMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerUnitAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__PerUnitAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxExemptionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__TaxExemptionReasonCode;
        
    private System.Collections.Generic.List<TextType> _taxExemptionReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType[] @__TaxExemptionReason
    {
        get
        {
            return _taxExemptionReason?.ToArray();
        }
        set
        {
            _taxExemptionReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TierRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__TierRange;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TierRatePercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public PercentType @__TierRatePercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxScheme", Order=9)]
    public TaxSchemeType @__TaxScheme;
        
    /// <summary>
    /// The reason for tax being exempted, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Tax Exemption Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tax Category
    /// <para />PropertyTerm: Tax Exemption Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> TaxExemptionReason
    {
        get { return _taxExemptionReason ?? (_taxExemptionReason = new System.Collections.Generic.List<TextType>()); }
        set { _taxExemptionReason = value; }
    }

        
    /// <summary>
    /// An identifier for this tax category.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>http://www.unece.org/uncefact/codelist/standard/UNECE_DutyorTaxorFeeCategoryCode_D09B.xsd</example>
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
    /// The name of this tax category.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Luxury Goods , Wine Equalization , Exempt</example>
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
    /// The tax rate for this category, expressed as a percentage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
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
    /// A Unit of Measures used as the basic for the tax calculation applied at a certain rate per unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Base Unit Measure. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
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
    /// <para />DictionaryEntryName: Tax Category. Per Unit_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
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
    /// The reason for tax being exempted, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Tax Exemption Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
    /// <para />PropertyTerm: Tax Exemption Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>http://www.unece.org/uncefact/codelist/standard/UNECE_DutyTaxFeeTypeCode_D09B.xsd</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TaxExemptionReasonCode
    {
        get
        {
            if (__TaxExemptionReasonCode == null) { __TaxExemptionReasonCode = new CodeType(); }
            return __TaxExemptionReasonCode;
        }
        set
        {
            __TaxExemptionReasonCode = value;
        }
    }

        
    /// <summary>
    /// Where a tax is tiered, the range of taxable amounts that determines the rate of tax applicable to this tax category.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Tier Range. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
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
    /// Where a tax is tiered, the tax rate that applies within the specified range of taxable amounts for this tax category.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Category. Tier Rate. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Category
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
    /// The taxation scheme within which this tax category is defined.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tax Category. Tax Scheme
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Tax Category
    /// <para />PropertyTerm: Tax Scheme
    /// <para />AssociatedObjectClass: Tax Scheme
    /// <para />RepresentationTerm: Tax Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TaxSchemeType TaxScheme
    {
        get
        {
            if (__TaxScheme == null) { __TaxScheme = new TaxSchemeType(); }
            return __TaxScheme;
        }
        set
        {
            __TaxScheme = value;
        }
    }

}