using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class for information about pricing structure, lead time, and location associated with an item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Location Quantity. Details
/// <para />ObjectClass: Item Location Quantity
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ItemLocationQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemLocationQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemLocationQuantityType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LeadTimeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public MeasureType @__LeadTimeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__MinimumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__MaximumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousRiskIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IndicatorType @__HazardousRiskIndicator;
        
    private System.Collections.Generic.List<TextType> _tradingRestrictions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__TradingRestrictions
    {
        get
        {
            return _tradingRestrictions?.ToArray();
        }
        set
        {
            _tradingRestrictions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<AddressType> _applicableTerritoryAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ApplicableTerritoryAddress", Order=5)]
    public AddressType[] @__ApplicableTerritoryAddress
    {
        get
        {
            return _applicableTerritoryAddress?.ToArray();
        }
        set
        {
            _applicableTerritoryAddress = value == null ? null : new System.Collections.Generic.List<AddressType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Price", Order=6)]
    public PriceType @__Price;
        
    private System.Collections.Generic.List<DeliveryUnitType> _deliveryUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit", Order=7)]
    public DeliveryUnitType[] @__DeliveryUnit
    {
        get
        {
            return _deliveryUnit?.ToArray();
        }
        set
        {
            _deliveryUnit = value == null ? null : new System.Collections.Generic.List<DeliveryUnitType>(value);
        }
    }
        
    private System.Collections.Generic.List<TaxCategoryType> _applicableTaxCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory", Order=8)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Package", Order=9)]
    public PackageType @__Package;
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=10)]
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
    [System.Xml.Serialization.XmlElementAttribute("DependentPriceReference", Order=11)]
    public DependentPriceReferenceType @__DependentPriceReference;
        
    /// <summary>
    /// Text describing trade restrictions on the quantity of this item or on the item itself.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Trading Restrictions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTerm: Trading Restrictions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>not for export</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> TradingRestrictions
    {
        get { return _tradingRestrictions ?? (_tradingRestrictions = new System.Collections.Generic.List<TextType>()); }
        set { _tradingRestrictions = value; }
    }

        
    /// <summary>
    /// The applicable sales territory.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Applicable Territory_ Address. Address
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTermQualifier: Applicable Territory
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AddressType> ApplicableTerritoryAddress
    {
        get { return _applicableTerritoryAddress ?? (_applicableTerritoryAddress = new System.Collections.Generic.List<AddressType>()); }
        set { _applicableTerritoryAddress = value; }
    }

        
    /// <summary>
    /// A delivery unit in which the item is located.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Delivery Unit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTerm: Delivery Unit
    /// <para />AssociatedObjectClass: Delivery Unit
    /// <para />RepresentationTerm: Delivery Unit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DeliveryUnitType> DeliveryUnit
    {
        get { return _deliveryUnit ?? (_deliveryUnit = new System.Collections.Generic.List<DeliveryUnitType>()); }
        set { _deliveryUnit = value; }
    }

        
    /// <summary>
    /// A tax category applicable to this item location quantity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Applicable_ Tax Category. Tax Category
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Location Quantity
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
    /// An allowance or charge associated with this item location quantity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Location Quantity
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
    /// The lead time, i.e., the time taken from the time at which an item is ordered to the time of its delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Lead Time. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTerm: Lead Time
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    /// <example>2 days , 24 hours</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType LeadTimeMeasure
    {
        get
        {
            if (__LeadTimeMeasure == null) { __LeadTimeMeasure = new MeasureType(); }
            return __LeadTimeMeasure;
        }
        set
        {
            __LeadTimeMeasure = value;
        }
    }

        
    /// <summary>
    /// The minimum quantity that can be ordered to qualify for a specific price.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Minimum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>10 boxes , 1 carton , 1000 sheets</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumQuantity
    {
        get
        {
            if (__MinimumQuantity == null) { __MinimumQuantity = new QuantityType(); }
            return __MinimumQuantity;
        }
        set
        {
            __MinimumQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum quantity that can be ordered to qualify for a specific price.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Maximum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>10 boxes , 1 carton , 1000 sheets</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumQuantity
    {
        get
        {
            if (__MaximumQuantity == null) { __MaximumQuantity = new QuantityType(); }
            return __MaximumQuantity;
        }
        set
        {
            __MaximumQuantity = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported item, as delivered, in the stated quantity to the stated location, is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Hazardous Risk_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTermQualifier: Hazardous Risk
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>Default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType HazardousRiskIndicator
    {
        get
        {
            if (__HazardousRiskIndicator == null) { __HazardousRiskIndicator = new IndicatorType(); }
            return __HazardousRiskIndicator;
        }
        set
        {
            __HazardousRiskIndicator = value;
        }
    }

        
    /// <summary>
    /// The price associated with the given location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Price
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTerm: Price
    /// <para />AssociatedObjectClass: Price
    /// <para />RepresentationTerm: Price
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PriceType Price
    {
        get
        {
            if (__Price == null) { __Price = new PriceType(); }
            return __Price;
        }
        set
        {
            __Price = value;
        }
    }

        
    /// <summary>
    /// The package to which this price applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Package
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTerm: Package
    /// <para />AssociatedObjectClass: Package
    /// <para />RepresentationTerm: Package
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PackageType Package
    {
        get
        {
            if (__Package == null) { __Package = new PackageType(); }
            return __Package;
        }
        set
        {
            __Package = value;
        }
    }

        
    /// <summary>
    /// The price of the item as a percentage of the price of some other item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Location Quantity. Dependent Price Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Location Quantity
    /// <para />PropertyTerm: Dependent Price Reference
    /// <para />AssociatedObjectClass: Dependent Price Reference
    /// <para />RepresentationTerm: Dependent Price Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DependentPriceReferenceType DependentPriceReference
    {
        get
        {
            if (__DependentPriceReference == null) { __DependentPriceReference = new DependentPriceReferenceType(); }
            return __DependentPriceReference;
        }
        set
        {
            __DependentPriceReference = value;
        }
    }

}