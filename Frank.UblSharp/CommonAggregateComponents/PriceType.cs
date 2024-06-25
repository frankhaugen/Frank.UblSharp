using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a price, expressed in a data structure containing multiple properties (compare with UnstructuredPrice).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Price. Details
/// <para />ObjectClass: Price
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AlternativeConditionPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AlternativeConditionPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PriceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__PriceAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BaseQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__BaseQuantity;
        
    private System.Collections.Generic.List<TextType> _priceChangeReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceChangeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__PriceChangeReason
    {
        get
        {
            return _priceChangeReason?.ToArray();
        }
        set
        {
            _priceChangeReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__PriceTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__PriceType1;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderableUnitFactorRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public RateType @__OrderableUnitFactorRate;
        
    private System.Collections.Generic.List<PeriodType> _validityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=6)]
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
    [System.Xml.Serialization.XmlElementAttribute("PriceList", Order=7)]
    public PriceListType @__PriceList;
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=8)]
    public AllowanceChargeType[] @__AllowanceCharge
    {
        get
        {
            return _allowanceCharge?.ToArray();
        }
        set
        {
            _allowanceCharge = value == null ? null : new System.Collections.Generic.List<AllowanceChargeType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PricingExchangeRate", Order=9)]
    public ExchangeRateType @__PricingExchangeRate;
        
    /// <summary>
    /// A reason for a price change.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Price. Price Change_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Price
    /// <para />PropertyTermQualifier: Price Change
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Clearance of old stock , New contract applies</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> PriceChangeReason
    {
        get { return _priceChangeReason ?? (_priceChangeReason = new System.Collections.Generic.List<TextType>()); }
        set { _priceChangeReason = value; }
    }

        
    /// <summary>
    /// A period during which this price is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Price. Validity_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Price
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
    /// An allowance or charge associated with this price.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Price. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Price
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AllowanceChargeType> AllowanceCharge
    {
        get { return _allowanceCharge ?? (_allowanceCharge = new System.Collections.Generic.List<AllowanceChargeType>()); }
        set { _allowanceCharge = value; }
    }

        
    /// <summary>
    /// The amount of the price.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Price. Price Amount. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Price
    /// <para />PropertyTerm: Price Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: unit price
    /// </summary>
    /// <example>23.45</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PriceAmount
    {
        get
        {
            if (__PriceAmount == null) { __PriceAmount = new AmountType(); }
            return __PriceAmount;
        }
        set
        {
            __PriceAmount = value;
        }
    }

        
    /// <summary>
    /// The quantity at which this price applies.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Price. Base_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price
    /// <para />PropertyTermQualifier: Base
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType BaseQuantity
    {
        get
        {
            if (__BaseQuantity == null) { __BaseQuantity = new QuantityType(); }
            return __BaseQuantity;
        }
        set
        {
            __BaseQuantity = value;
        }
    }

        
    /// <summary>
    /// The type of price, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Price. Price Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price
    /// <para />PropertyTerm: Price Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PriceTypeCode
    {
        get
        {
            if (__PriceTypeCode == null) { __PriceTypeCode = new CodeType(); }
            return __PriceTypeCode;
        }
        set
        {
            __PriceTypeCode = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PriceType1
    {
        get
        {
            if (__PriceType1 == null) { __PriceType1 = new TextType(); }
            return __PriceType1;
        }
        set
        {
            __PriceType1 = value;
        }
    }

        
    /// <summary>
    /// The factor by which the base price unit can be converted to the orderable unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Price. Orderable Unit Factor. Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price
    /// <para />PropertyTerm: Orderable Unit Factor
    /// <para />RepresentationTerm: Rate
    /// <para />DataType: Rate. Type
    /// </summary>
    /// <example>Nails are priced by weight but ordered by quantity. So this would say how many nails per kilo</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RateType OrderableUnitFactorRate
    {
        get
        {
            if (__OrderableUnitFactorRate == null) { __OrderableUnitFactorRate = new RateType(); }
            return __OrderableUnitFactorRate;
        }
        set
        {
            __OrderableUnitFactorRate = value;
        }
    }

        
    /// <summary>
    /// Information about a price list applicable to this price.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Price. Price List
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price
    /// <para />PropertyTerm: Price List
    /// <para />AssociatedObjectClass: Price List
    /// <para />RepresentationTerm: Price List
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PriceListType PriceList
    {
        get
        {
            if (__PriceList == null) { __PriceList = new PriceListType(); }
            return __PriceList;
        }
        set
        {
            __PriceList = value;
        }
    }

        
    /// <summary>
    /// The exchange rate applicable to this price, if it differs from the exchange rate applicable to the document as a whole.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Price. Pricing_ Exchange Rate. Exchange Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Price
    /// <para />PropertyTermQualifier: Pricing
    /// <para />PropertyTerm: Exchange Rate
    /// <para />AssociatedObjectClass: Exchange Rate
    /// <para />RepresentationTerm: Exchange Rate
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ExchangeRateType PricingExchangeRate
    {
        get
        {
            if (__PricingExchangeRate == null) { __PricingExchangeRate = new ExchangeRateType(); }
            return __PricingExchangeRate;
        }
        set
        {
            __PricingExchangeRate = value;
        }
    }

}