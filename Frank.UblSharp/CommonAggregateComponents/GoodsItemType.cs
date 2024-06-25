using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a separately identifiable quantity of goods of a single product type.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Goods Item. Details
/// <para />ObjectClass: Goods Item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ContainedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContainedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class GoodsItemType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__SequenceNumberID;
        
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
    [System.Xml.Serialization.XmlElementAttribute("HazardousRiskIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IndicatorType @__HazardousRiskIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredCustomsValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__DeclaredCustomsValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredForCarriageValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public AmountType @__DeclaredForCarriageValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredStatisticsValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__DeclaredStatisticsValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreeOnBoardValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public AmountType @__FreeOnBoardValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InsuranceValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__InsuranceValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public AmountType @__ValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public MeasureType @__GrossWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public MeasureType @__NetWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetNetWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public MeasureType @__NetNetWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChargeableWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public MeasureType @__ChargeableWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public MeasureType @__GrossVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public MeasureType @__NetVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreferenceCriterionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
    public CodeType @__PreferenceCriterionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredCustomsID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=18)]
    public IdentifierType @__RequiredCustomsID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomsStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=19)]
    public CodeType @__CustomsStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomsTariffQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=20)]
    public QuantityType @__CustomsTariffQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomsImportClassifiedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=21)]
    public IndicatorType @__CustomsImportClassifiedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChargeableQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=22)]
    public QuantityType @__ChargeableQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReturnableQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=23)]
    public QuantityType @__ReturnableQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TraceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=24)]
    public IdentifierType @__TraceID;
        
    private System.Collections.Generic.List<ItemType> _item;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=25)]
    public ItemType[] @__Item
    {
        get
        {
            return _item?.ToArray();
        }
        set
        {
            _item = value == null ? null : new System.Collections.Generic.List<ItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<GoodsItemContainerType> _goodsItemContainer;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GoodsItemContainer", Order=26)]
    public GoodsItemContainerType[] @__GoodsItemContainer
    {
        get
        {
            return _goodsItemContainer?.ToArray();
        }
        set
        {
            _goodsItemContainer = value == null ? null : new System.Collections.Generic.List<GoodsItemContainerType>(value);
        }
    }
        
    private System.Collections.Generic.List<AllowanceChargeType> _freightAllowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order=27)]
    public AllowanceChargeType[] @__FreightAllowanceCharge
    {
        get
        {
            return _freightAllowanceCharge?.ToArray();
        }
        set
        {
            _freightAllowanceCharge = value == null ? null : new System.Collections.Generic.List<AllowanceChargeType>(value);
        }
    }
        
    private System.Collections.Generic.List<InvoiceLineType> _invoiceLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Order=28)]
    public InvoiceLineType[] @__InvoiceLine
    {
        get
        {
            return _invoiceLine?.ToArray();
        }
        set
        {
            _invoiceLine = value == null ? null : new System.Collections.Generic.List<InvoiceLineType>(value);
        }
    }
        
    private System.Collections.Generic.List<TemperatureType> _temperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Temperature", Order=29)]
    public TemperatureType[] @__Temperature
    {
        get
        {
            return _temperature?.ToArray();
        }
        set
        {
            _temperature = value == null ? null : new System.Collections.Generic.List<TemperatureType>(value);
        }
    }
        
    private System.Collections.Generic.List<GoodsItemType> _containedGoodsItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContainedGoodsItem", Order=30)]
    public GoodsItemType[] @__ContainedGoodsItem
    {
        get
        {
            return _containedGoodsItem?.ToArray();
        }
        set
        {
            _containedGoodsItem = value == null ? null : new System.Collections.Generic.List<GoodsItemType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginAddress", Order=31)]
    public AddressType @__OriginAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=32)]
    public DeliveryType @__Delivery;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Pickup", Order=33)]
    public PickupType @__Pickup;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Despatch", Order=34)]
    public DespatchType @__Despatch;
        
    private System.Collections.Generic.List<DimensionType> _measurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order=35)]
    public DimensionType[] @__MeasurementDimension
    {
        get
        {
            return _measurementDimension?.ToArray();
        }
        set
        {
            _measurementDimension = value == null ? null : new System.Collections.Generic.List<DimensionType>(value);
        }
    }
        
    private System.Collections.Generic.List<PackageType> _containingPackage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContainingPackage", Order=36)]
    public PackageType[] @__ContainingPackage
    {
        get
        {
            return _containingPackage?.ToArray();
        }
        set
        {
            _containingPackage = value == null ? null : new System.Collections.Generic.List<PackageType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference", Order=37)]
    public DocumentReferenceType @__ShipmentDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumTemperature", Order=38)]
    public TemperatureType @__MinimumTemperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumTemperature", Order=39)]
    public TemperatureType @__MaximumTemperature;
        
    /// <summary>
    /// Text describing this goods item to identify it for customs, statistical, or transport purposes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Description of goods (WCO ID 137)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Product information relating to a goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemType> Item
    {
        get { return _item ?? (_item = new System.Collections.Generic.List<ItemType>()); }
        set { _item = value; }
    }

        
    /// <summary>
    /// The transporting of a goods item in a unit of transport equipment (e.g., container).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Goods Item Container
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Goods Item Container
    /// <para />AssociatedObjectClass: Goods Item Container
    /// <para />RepresentationTerm: Goods Item Container
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<GoodsItemContainerType> GoodsItemContainer
    {
        get { return _goodsItemContainer ?? (_goodsItemContainer = new System.Collections.Generic.List<GoodsItemContainerType>()); }
        set { _goodsItemContainer = value; }
    }

        
    /// <summary>
    /// A cost incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance to the extent that they relate to the freight costs.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Freight_ Allowance Charge. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Freight
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// <para />AlternativeBusinessTerms: Freight Costs
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AllowanceChargeType> FreightAllowanceCharge
    {
        get { return _freightAllowanceCharge ?? (_freightAllowanceCharge = new System.Collections.Generic.List<AllowanceChargeType>()); }
        set { _freightAllowanceCharge = value; }
    }

        
    /// <summary>
    /// Information about an invoice line relating to this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Invoice Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Invoice Line
    /// <para />AssociatedObjectClass: Invoice Line
    /// <para />RepresentationTerm: Invoice Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<InvoiceLineType> InvoiceLine
    {
        get { return _invoiceLine ?? (_invoiceLine = new System.Collections.Generic.List<InvoiceLineType>()); }
        set { _invoiceLine = value; }
    }

        
    /// <summary>
    /// The temperature of the goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Temperature
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    /// <example>maximum, storage, minimum</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TemperatureType> Temperature
    {
        get { return _temperature ?? (_temperature = new System.Collections.Generic.List<TemperatureType>()); }
        set { _temperature = value; }
    }

        
    /// <summary>
    /// A goods item contained in this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Contained_ Goods Item. Goods Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Contained
    /// <para />PropertyTerm: Goods Item
    /// <para />AssociatedObjectClass: Goods Item
    /// <para />RepresentationTerm: Goods Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<GoodsItemType> ContainedGoodsItem
    {
        get { return _containedGoodsItem ?? (_containedGoodsItem = new System.Collections.Generic.List<GoodsItemType>()); }
        set { _containedGoodsItem = value; }
    }

        
    /// <summary>
    /// A measurable dimension (length, mass, weight, or volume) of this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Measurement
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DimensionType> MeasurementDimension
    {
        get { return _measurementDimension ?? (_measurementDimension = new System.Collections.Generic.List<DimensionType>()); }
        set { _measurementDimension = value; }
    }

        
    /// <summary>
    /// A package containing this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Containing_ Package. Package
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Containing
    /// <para />PropertyTerm: Package
    /// <para />AssociatedObjectClass: Package
    /// <para />RepresentationTerm: Package
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PackageType> ContainingPackage
    {
        get { return _containingPackage ?? (_containingPackage = new System.Collections.Generic.List<PackageType>()); }
        set { _containingPackage = value; }
    }

        
    /// <summary>
    /// An identifier for this goods item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
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
    /// A sequence number differentiating a specific goods item within a consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Sequence Number. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Sequence Number
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SequenceNumberID
    {
        get
        {
            if (__SequenceNumberID == null) { __SequenceNumberID = new IdentifierType(); }
            return __SequenceNumberID;
        }
        set
        {
            __SequenceNumberID = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods item is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Hazardous Risk_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Hazardous Risk
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
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
    /// The total declared value for customs purposes of the goods item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Declared Customs_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Declared Customs
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: For Customs Value (WCO ID 108)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType DeclaredCustomsValueAmount
    {
        get
        {
            if (__DeclaredCustomsValueAmount == null) { __DeclaredCustomsValueAmount = new AmountType(); }
            return __DeclaredCustomsValueAmount;
        }
        set
        {
            __DeclaredCustomsValueAmount = value;
        }
    }

        
    /// <summary>
    /// The value of this goods item, declared by the shipper or his agent solely for the purpose of varying the carrier&apos;s level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Declared For Carriage_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Declared For Carriage
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: Interest in delivery, declared value for carriage
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType DeclaredForCarriageValueAmount
    {
        get
        {
            if (__DeclaredForCarriageValueAmount == null) { __DeclaredForCarriageValueAmount = new AmountType(); }
            return __DeclaredForCarriageValueAmount;
        }
        set
        {
            __DeclaredForCarriageValueAmount = value;
        }
    }

        
    /// <summary>
    /// The total declared value of all the goods items in the same consignment with this goods item that have the same statistical heading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Declared Statistics_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Declared Statistics
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: Statistical Value (WCO ID 114)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType DeclaredStatisticsValueAmount
    {
        get
        {
            if (__DeclaredStatisticsValueAmount == null) { __DeclaredStatisticsValueAmount = new AmountType(); }
            return __DeclaredStatisticsValueAmount;
        }
        set
        {
            __DeclaredStatisticsValueAmount = value;
        }
    }

        
    /// <summary>
    /// The monetary amount that has to be or has been paid as calculated under the applicable trade delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Free On Board_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Free On Board
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: FOB Value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType FreeOnBoardValueAmount
    {
        get
        {
            if (__FreeOnBoardValueAmount == null) { __FreeOnBoardValueAmount = new AmountType(); }
            return __FreeOnBoardValueAmount;
        }
        set
        {
            __FreeOnBoardValueAmount = value;
        }
    }

        
    /// <summary>
    /// The amount covered by insurance for this goods item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Insurance_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Insurance
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: Value Insured
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType InsuranceValueAmount
    {
        get
        {
            if (__InsuranceValueAmount == null) { __InsuranceValueAmount = new AmountType(); }
            return __InsuranceValueAmount;
        }
        set
        {
            __InsuranceValueAmount = value;
        }
    }

        
    /// <summary>
    /// The amount on which a duty, tax, or fee will be assessed.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType ValueAmount
    {
        get
        {
            if (__ValueAmount == null) { __ValueAmount = new AmountType(); }
            return __ValueAmount;
        }
        set
        {
            __ValueAmount = value;
        }
    }

        
    /// <summary>
    /// The weight of this goods item, including packing and packaging but excluding the carrier&apos;s equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Gross_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Gross
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// <para />AlternativeBusinessTerms: Actual Gross Weight
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType GrossWeightMeasure
    {
        get
        {
            if (__GrossWeightMeasure == null) { __GrossWeightMeasure = new MeasureType(); }
            return __GrossWeightMeasure;
        }
        set
        {
            __GrossWeightMeasure = value;
        }
    }

        
    /// <summary>
    /// The weight of this goods item, excluding packing but including packaging that normally accompanies the goods.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Net_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Net
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType NetWeightMeasure
    {
        get
        {
            if (__NetWeightMeasure == null) { __NetWeightMeasure = new MeasureType(); }
            return __NetWeightMeasure;
        }
        set
        {
            __NetWeightMeasure = value;
        }
    }

        
    /// <summary>
    /// The total weight of this goods item, excluding all packing and packaging.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Net Net_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Net Net
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// <para />AlternativeBusinessTerms: Customs Weight (WCO ID 128)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType NetNetWeightMeasure
    {
        get
        {
            if (__NetNetWeightMeasure == null) { __NetNetWeightMeasure = new MeasureType(); }
            return __NetNetWeightMeasure;
        }
        set
        {
            __NetNetWeightMeasure = value;
        }
    }

        
    /// <summary>
    /// The weight on which a charge is to be based.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Chargeable_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Chargeable
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType ChargeableWeightMeasure
    {
        get
        {
            if (__ChargeableWeightMeasure == null) { __ChargeableWeightMeasure = new MeasureType(); }
            return __ChargeableWeightMeasure;
        }
        set
        {
            __ChargeableWeightMeasure = value;
        }
    }

        
    /// <summary>
    /// The volume of this goods item, normally calculated by multiplying its maximum length, width, and height.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Gross_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Gross
    /// <para />PropertyTerm: Volume
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// <para />AlternativeBusinessTerms: Volume, Gross Measurement Cube (GMC), Cube (WCO ID 134)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType GrossVolumeMeasure
    {
        get
        {
            if (__GrossVolumeMeasure == null) { __GrossVolumeMeasure = new MeasureType(); }
            return __GrossVolumeMeasure;
        }
        set
        {
            __GrossVolumeMeasure = value;
        }
    }

        
    /// <summary>
    /// The volume contained by a goods item, excluding the volume of any packaging material.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Net_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Net
    /// <para />PropertyTerm: Volume
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType NetVolumeMeasure
    {
        get
        {
            if (__NetVolumeMeasure == null) { __NetVolumeMeasure = new MeasureType(); }
            return __NetVolumeMeasure;
        }
        set
        {
            __NetVolumeMeasure = value;
        }
    }

        
    /// <summary>
    /// The number of units making up this goods item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// A code signifying the treatment preference for this goods item according to international trading agreements.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Preference Criterion Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Preference Criterion Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Preference Criterion is used in the following manner in the paper CO of another country (e.g.):
    ///A - The good is wholly obtained or produced entirely in the territory of one or more of the NAFTA countries as reference in Article 415. Note: The purchase of a good in the territory does not necessarily render it wholly obtained or produced . If the good is an agricultural good, see also criterion F and Annex 703.2. (Reference: Article 401(a), 415).
    ///B - ...
    ///C - ...
    ///D - ...
    ///E - ...
    ///F - The good is an originating agricultural good under preference criterion A,B, or C above and is not subjected to quantitative restriction in the importing NAFTA country because....
    ///Thus, the column Preference Criterion will indicate either A, B, C,...</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PreferenceCriterionCode
    {
        get
        {
            if (__PreferenceCriterionCode == null) { __PreferenceCriterionCode = new CodeType(); }
            return __PreferenceCriterionCode;
        }
        set
        {
            __PreferenceCriterionCode = value;
        }
    }

        
    /// <summary>
    /// An identifier for a set of tariff codes required to specify a type of goods for customs, transport, statistical, or other regulatory purposes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Required_ Customs Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Customs Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Tariff code extensions (WCO ID 255)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType RequiredCustomsID
    {
        get
        {
            if (__RequiredCustomsID == null) { __RequiredCustomsID = new IdentifierType(); }
            return __RequiredCustomsID;
        }
        set
        {
            __RequiredCustomsID = value;
        }
    }

        
    /// <summary>
    /// A code assigned by customs to signify the status of this goods item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Customs Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Customs Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Customs status of goods (WCO ID 094)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CustomsStatusCode
    {
        get
        {
            if (__CustomsStatusCode == null) { __CustomsStatusCode = new CodeType(); }
            return __CustomsStatusCode;
        }
        set
        {
            __CustomsStatusCode = value;
        }
    }

        
    /// <summary>
    /// Quantity of the units in this goods item as required by customs for tariff, statistical, or fiscal purposes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Customs Tariff Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Customs Tariff Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType CustomsTariffQuantity
    {
        get
        {
            if (__CustomsTariffQuantity == null) { __CustomsTariffQuantity = new QuantityType(); }
            return __CustomsTariffQuantity;
        }
        set
        {
            __CustomsTariffQuantity = value;
        }
    }

        
    /// <summary>
    /// An indicator that this goods item has been classified for import by customs (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Customs Import_ Classified Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Customs Import
    /// <para />PropertyTerm: Classified Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType CustomsImportClassifiedIndicator
    {
        get
        {
            if (__CustomsImportClassifiedIndicator == null) { __CustomsImportClassifiedIndicator = new IndicatorType(); }
            return __CustomsImportClassifiedIndicator;
        }
        set
        {
            __CustomsImportClassifiedIndicator = value;
        }
    }

        
    /// <summary>
    /// The number of units in the goods item to which charges apply.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Chargeable_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Chargeable
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ChargeableQuantity
    {
        get
        {
            if (__ChargeableQuantity == null) { __ChargeableQuantity = new QuantityType(); }
            return __ChargeableQuantity;
        }
        set
        {
            __ChargeableQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of units in the goods item that may be returned.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Returnable_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Returnable
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ReturnableQuantity
    {
        get
        {
            if (__ReturnableQuantity == null) { __ReturnableQuantity = new QuantityType(); }
            return __ReturnableQuantity;
        }
        set
        {
            __ReturnableQuantity = value;
        }
    }

        
    /// <summary>
    /// An identifier for use in tracing this goods item, such as the EPC number used in RFID.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item. Trace_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Trace
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TraceID
    {
        get
        {
            if (__TraceID == null) { __TraceID = new IdentifierType(); }
            return __TraceID;
        }
        set
        {
            __TraceID = value;
        }
    }

        
    /// <summary>
    /// The region in which the goods have been produced or manufactured, according to criteria laid down for the purposes of application of the customs tariff, or of quantitative restrictions, or of any other measure related to trade.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Origin_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Origin
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// <para />AlternativeBusinessTerms: Region of origin (WCO ID 066)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType OriginAddress
    {
        get
        {
            if (__OriginAddress == null) { __OriginAddress = new AddressType(); }
            return __OriginAddress;
        }
        set
        {
            __OriginAddress = value;
        }
    }

        
    /// <summary>
    /// The delivery of this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Delivery
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Delivery
    /// <para />AssociatedObjectClass: Delivery
    /// <para />RepresentationTerm: Delivery
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DeliveryType Delivery
    {
        get
        {
            if (__Delivery == null) { __Delivery = new DeliveryType(); }
            return __Delivery;
        }
        set
        {
            __Delivery = value;
        }
    }

        
    /// <summary>
    /// The pickup of this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Pickup
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Pickup
    /// <para />AssociatedObjectClass: Pickup
    /// <para />RepresentationTerm: Pickup
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PickupType Pickup
    {
        get
        {
            if (__Pickup == null) { __Pickup = new PickupType(); }
            return __Pickup;
        }
        set
        {
            __Pickup = value;
        }
    }

        
    /// <summary>
    /// The despatch of this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Despatch
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTerm: Despatch
    /// <para />AssociatedObjectClass: Despatch
    /// <para />RepresentationTerm: Despatch
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DespatchType Despatch
    {
        get
        {
            if (__Despatch == null) { __Despatch = new DespatchType(); }
            return __Despatch;
        }
        set
        {
            __Despatch = value;
        }
    }

        
    /// <summary>
    /// A reference to a shipping document associated with this goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Shipment_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Shipment
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType ShipmentDocumentReference
    {
        get
        {
            if (__ShipmentDocumentReference == null) { __ShipmentDocumentReference = new DocumentReferenceType(); }
            return __ShipmentDocumentReference;
        }
        set
        {
            __ShipmentDocumentReference = value;
        }
    }

        
    /// <summary>
    /// Information about minimum temperature.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Minimum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TemperatureType MinimumTemperature
    {
        get
        {
            if (__MinimumTemperature == null) { __MinimumTemperature = new TemperatureType(); }
            return __MinimumTemperature;
        }
        set
        {
            __MinimumTemperature = value;
        }
    }

        
    /// <summary>
    /// Information about maximum temperature.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item. Maximum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TemperatureType MaximumTemperature
    {
        get
        {
            if (__MaximumTemperature == null) { __MaximumTemperature = new TemperatureType(); }
            return __MaximumTemperature;
        }
        set
        {
            __MaximumTemperature = value;
        }
    }

}