using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class defining an identifiable collection of one or more goods items to be transported between the seller party and the buyer party. This information may be defined within a commercial contract. A shipment can be transported in different consignments (e.g., split for logistical purposes).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Shipment. Details
/// <para />ObjectClass: Shipment
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsolidatedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsolidatedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ShipmentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShippingPriorityLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ShippingPriorityLevelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HandlingCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__HandlingCode;
        
    private System.Collections.Generic.List<TextType> _handlingInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__HandlingInstructions
    {
        get
        {
            return _handlingInstructions?.ToArray();
        }
        set
        {
            _handlingInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _information;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__Information
    {
        get
        {
            return _information?.ToArray();
        }
        set
        {
            _information = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public MeasureType @__GrossWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public MeasureType @__NetWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetNetWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public MeasureType @__NetNetWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public MeasureType @__GrossVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public MeasureType @__NetVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalGoodsItemQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public QuantityType @__TotalGoodsItemQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalTransportHandlingUnitQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public QuantityType @__TotalTransportHandlingUnitQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InsuranceValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public AmountType @__InsuranceValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredCustomsValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public AmountType @__DeclaredCustomsValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredForCarriageValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public AmountType @__DeclaredForCarriageValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredStatisticsValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public AmountType @__DeclaredStatisticsValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreeOnBoardValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public AmountType @__FreeOnBoardValueAmount;
        
    private System.Collections.Generic.List<TextType> _specialInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
    public TextType[] @__SpecialInstructions
    {
        get
        {
            return _specialInstructions?.ToArray();
        }
        set
        {
            _specialInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _deliveryInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=18)]
    public TextType[] @__DeliveryInstructions
    {
        get
        {
            return _deliveryInstructions?.ToArray();
        }
        set
        {
            _deliveryInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SplitConsignmentIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=19)]
    public IndicatorType @__SplitConsignmentIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsignmentQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=20)]
    public QuantityType @__ConsignmentQuantity;
        
    private System.Collections.Generic.List<ConsignmentType> _consignment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Consignment", Order=21)]
    public ConsignmentType[] @__Consignment
    {
        get
        {
            return _consignment?.ToArray();
        }
        set
        {
            _consignment = value == null ? null : new System.Collections.Generic.List<ConsignmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<GoodsItemType> _goodsItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order=22)]
    public GoodsItemType[] @__GoodsItem
    {
        get
        {
            return _goodsItem?.ToArray();
        }
        set
        {
            _goodsItem = value == null ? null : new System.Collections.Generic.List<GoodsItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<ShipmentStageType> _shipmentStage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipmentStage", Order=23)]
    public ShipmentStageType[] @__ShipmentStage
    {
        get
        {
            return _shipmentStage?.ToArray();
        }
        set
        {
            _shipmentStage = value == null ? null : new System.Collections.Generic.List<ShipmentStageType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=24)]
    public DeliveryType @__Delivery;
        
    private System.Collections.Generic.List<TransportHandlingUnitType> _transportHandlingUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit", Order=25)]
    public TransportHandlingUnitType[] @__TransportHandlingUnit
    {
        get
        {
            return _transportHandlingUnit?.ToArray();
        }
        set
        {
            _transportHandlingUnit = value == null ? null : new System.Collections.Generic.List<TransportHandlingUnitType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReturnAddress", Order=26)]
    public AddressType @__ReturnAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginAddress", Order=27)]
    public AddressType @__OriginAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FirstArrivalPortLocation", Order=28)]
    public LocationType @__FirstArrivalPortLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LastExitPortLocation", Order=29)]
    public LocationType @__LastExitPortLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExportCountry", Order=30)]
    public CountryType @__ExportCountry;
        
    private System.Collections.Generic.List<AllowanceChargeType> _freightAllowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order=31)]
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
        
    /// <summary>
    /// The handling required for this shipment, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Handling_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Handling
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> HandlingInstructions
    {
        get { return _handlingInstructions ?? (_handlingInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _handlingInstructions = value; }
    }

        
    /// <summary>
    /// Free-form text pertinent to this shipment, conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Information
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Information
    {
        get { return _information ?? (_information = new System.Collections.Generic.List<TextType>()); }
        set { _information = value; }
    }

        
    /// <summary>
    /// Special instructions relating to this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Special_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Special
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> SpecialInstructions
    {
        get { return _specialInstructions ?? (_specialInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _specialInstructions = value; }
    }

        
    /// <summary>
    /// Delivery instructions relating to this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Delivery_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> DeliveryInstructions
    {
        get { return _deliveryInstructions ?? (_deliveryInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _deliveryInstructions = value; }
    }

        
    /// <summary>
    /// A consignment covering this shipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Consignment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Consignment
    /// <para />AssociatedObjectClass: Consignment
    /// <para />RepresentationTerm: Consignment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsignmentType> Consignment
    {
        get { return _consignment ?? (_consignment = new System.Collections.Generic.List<ConsignmentType>()); }
        set { _consignment = value; }
    }

        
    /// <summary>
    /// A goods item included in this shipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Goods Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Goods Item
    /// <para />AssociatedObjectClass: Goods Item
    /// <para />RepresentationTerm: Goods Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<GoodsItemType> GoodsItem
    {
        get { return _goodsItem ?? (_goodsItem = new System.Collections.Generic.List<GoodsItemType>()); }
        set { _goodsItem = value; }
    }

        
    /// <summary>
    /// A stage in the transport movement of this shipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Shipment Stage
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Shipment Stage
    /// <para />AssociatedObjectClass: Shipment Stage
    /// <para />RepresentationTerm: Shipment Stage
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentStageType> ShipmentStage
    {
        get { return _shipmentStage ?? (_shipmentStage = new System.Collections.Generic.List<ShipmentStageType>()); }
        set { _shipmentStage = value; }
    }

        
    /// <summary>
    /// A transport handling unit associated with this shipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Transport Handling Unit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Transport Handling Unit
    /// <para />AssociatedObjectClass: Transport Handling Unit
    /// <para />RepresentationTerm: Transport Handling Unit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportHandlingUnitType> TransportHandlingUnit
    {
        get { return _transportHandlingUnit ?? (_transportHandlingUnit = new System.Collections.Generic.List<TransportHandlingUnitType>()); }
        set { _transportHandlingUnit = value; }
    }

        
    /// <summary>
    /// A cost incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance to the extent that they relate to the freight costs.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Freight_ Allowance Charge. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment
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
    /// An identifier for this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Waybill Number
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
    /// A code signifying the priority or level of service required for this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Shipping Priority Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Shipping Priority Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Service Level, Service Priority
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ShippingPriorityLevelCode
    {
        get
        {
            if (__ShippingPriorityLevelCode == null) { __ShippingPriorityLevelCode = new CodeType(); }
            return __ShippingPriorityLevelCode;
        }
        set
        {
            __ShippingPriorityLevelCode = value;
        }
    }

        
    /// <summary>
    /// The handling required for this shipment, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Handling Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTerm: Handling Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Special Handling
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType HandlingCode
    {
        get
        {
            if (__HandlingCode == null) { __HandlingCode = new CodeType(); }
            return __HandlingCode;
        }
        set
        {
            __HandlingCode = value;
        }
    }

        
    /// <summary>
    /// The total gross weight of a shipment; the weight of the goods plus packaging plus transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Gross_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Gross
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
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
    /// The net weight of this shipment, excluding packaging.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Net_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
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
    /// The total net weight of this shipment, excluding packaging and transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Net Net_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Net Net
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
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
    /// The total volume of the goods in this shipment, including packaging.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Gross_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Gross
    /// <para />PropertyTerm: Volume
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
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
    /// The total volume of the goods in this shipment, excluding packaging and transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Net_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
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
    /// The total number of goods items in this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Total_ Goods Item Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Goods Item Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TotalGoodsItemQuantity
    {
        get
        {
            if (__TotalGoodsItemQuantity == null) { __TotalGoodsItemQuantity = new QuantityType(); }
            return __TotalGoodsItemQuantity;
        }
        set
        {
            __TotalGoodsItemQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of pieces of transport handling equipment (pallets, boxes, cases, etc.) in this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Total_ Transport Handling Unit Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Transport Handling Unit Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// <para />AlternativeBusinessTerms: Number of THUs
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TotalTransportHandlingUnitQuantity
    {
        get
        {
            if (__TotalTransportHandlingUnitQuantity == null) { __TotalTransportHandlingUnitQuantity = new QuantityType(); }
            return __TotalTransportHandlingUnitQuantity;
        }
        set
        {
            __TotalTransportHandlingUnitQuantity = value;
        }
    }

        
    /// <summary>
    /// The amount covered by insurance for this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Insurance_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
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
    /// The total declared value for customs purposes of those goods in this shipment that are subject to the same customs procedure and have the same tariff/statistical heading, country information, and duty regime.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Declared Customs_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Declared Customs
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
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
    /// The value of this shipment, declared by the shipper or his agent solely for the purpose of varying the carrier&apos;s level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Declared For Carriage_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Declared For Carriage
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: Declared value for carriage, Interest in delivery
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
    /// The value, declared for statistical purposes, of those goods in this shipment that have the same statistical heading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Declared Statistics_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Declared Statistics
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: Statistical Value
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
    /// <para />DictionaryEntryName: Shipment. Free On Board_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
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
    /// An indicator that the consignment has been split in transit (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Split Consignment_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Split Consignment
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType SplitConsignmentIndicator
    {
        get
        {
            if (__SplitConsignmentIndicator == null) { __SplitConsignmentIndicator = new IndicatorType(); }
            return __SplitConsignmentIndicator;
        }
        set
        {
            __SplitConsignmentIndicator = value;
        }
    }

        
    /// <summary>
    /// The total number of consignments within this shipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment. Consignment_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Consignment
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ConsignmentQuantity
    {
        get
        {
            if (__ConsignmentQuantity == null) { __ConsignmentQuantity = new QuantityType(); }
            return __ConsignmentQuantity;
        }
        set
        {
            __ConsignmentQuantity = value;
        }
    }

        
    /// <summary>
    /// The delivery of this shipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Delivery
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
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
    /// The address to which a shipment should be returned.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Return_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Return
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType ReturnAddress
    {
        get
        {
            if (__ReturnAddress == null) { __ReturnAddress = new AddressType(); }
            return __ReturnAddress;
        }
        set
        {
            __ReturnAddress = value;
        }
    }

        
    /// <summary>
    /// The region in which the goods have been produced or manufactured, according to criteria laid down for the purposes of application of the customs tariff, or of quantitative restrictions, or of any other measure related to trade.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Origin_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Origin
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
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
    /// The first arrival location of a shipment. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. First Arrival Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: First Arrival Port
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType FirstArrivalPortLocation
    {
        get
        {
            if (__FirstArrivalPortLocation == null) { __FirstArrivalPortLocation = new LocationType(); }
            return __FirstArrivalPortLocation;
        }
        set
        {
            __FirstArrivalPortLocation = value;
        }
    }

        
    /// <summary>
    /// The final exporting location for a shipment. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Last Exit Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Last Exit Port
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType LastExitPortLocation
    {
        get
        {
            if (__LastExitPortLocation == null) { __LastExitPortLocation = new LocationType(); }
            return __LastExitPortLocation;
        }
        set
        {
            __LastExitPortLocation = value;
        }
    }

        
    /// <summary>
    /// The country from which the goods were originally exported, without any commercial transaction taking place in intermediate countries.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment. Export_ Country. Country
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment
    /// <para />PropertyTermQualifier: Export
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// <para />AlternativeBusinessTerms: Country of exportation (WCO ID 062)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CountryType ExportCountry
    {
        get
        {
            if (__ExportCountry == null) { __ExportCountry = new CountryType(); }
            return __ExportCountry;
        }
        set
        {
            __ExportCountry = value;
        }
    }

}