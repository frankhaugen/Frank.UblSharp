using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a uniquely identifiable unit consisting of one or more packages, goods items, or pieces of transport equipment.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transport Handling Unit. Details
/// <para />ObjectClass: Transport Handling Unit
/// <para />AlternativeBusinessTerms: Logistics Unit, Handling Unit, THU
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PackagedTransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PackagedTransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportHandlingUnitType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnitTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__TransportHandlingUnitTypeCode;
        
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousRiskIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IndicatorType @__HazardousRiskIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalGoodsItemQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__TotalGoodsItemQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalPackageQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public QuantityType @__TotalPackageQuantity;
        
    private System.Collections.Generic.List<TextType> _damageRemarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType[] @__DamageRemarks
    {
        get
        {
            return _damageRemarks?.ToArray();
        }
        set
        {
            _damageRemarks = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _shippingMarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShippingMarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType[] @__ShippingMarks
    {
        get
        {
            return _shippingMarks?.ToArray();
        }
        set
        {
            _shippingMarks = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TraceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IdentifierType @__TraceID;
        
    private System.Collections.Generic.List<DespatchLineType> _handlingUnitDespatchLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HandlingUnitDespatchLine", Order=10)]
    public DespatchLineType[] @__HandlingUnitDespatchLine
    {
        get
        {
            return _handlingUnitDespatchLine?.ToArray();
        }
        set
        {
            _handlingUnitDespatchLine = value == null ? null : new System.Collections.Generic.List<DespatchLineType>(value);
        }
    }
        
    private System.Collections.Generic.List<PackageType> _actualPackage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualPackage", Order=11)]
    public PackageType[] @__ActualPackage
    {
        get
        {
            return _actualPackage?.ToArray();
        }
        set
        {
            _actualPackage = value == null ? null : new System.Collections.Generic.List<PackageType>(value);
        }
    }
        
    private System.Collections.Generic.List<ReceiptLineType> _receivedHandlingUnitReceiptLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceivedHandlingUnitReceiptLine", Order=12)]
    public ReceiptLineType[] @__ReceivedHandlingUnitReceiptLine
    {
        get
        {
            return _receivedHandlingUnitReceiptLine?.ToArray();
        }
        set
        {
            _receivedHandlingUnitReceiptLine = value == null ? null : new System.Collections.Generic.List<ReceiptLineType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEquipmentType> _transportEquipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEquipment", Order=13)]
    public TransportEquipmentType[] @__TransportEquipment
    {
        get
        {
            return _transportEquipment?.ToArray();
        }
        set
        {
            _transportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportMeansType> _transportMeans;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportMeans", Order=14)]
    public TransportMeansType[] @__TransportMeans
    {
        get
        {
            return _transportMeans?.ToArray();
        }
        set
        {
            _transportMeans = value == null ? null : new System.Collections.Generic.List<TransportMeansType>(value);
        }
    }
        
    private System.Collections.Generic.List<HazardousGoodsTransitType> _hazardousGoodsTransit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit", Order=15)]
    public HazardousGoodsTransitType[] @__HazardousGoodsTransit
    {
        get
        {
            return _hazardousGoodsTransit?.ToArray();
        }
        set
        {
            _hazardousGoodsTransit = value == null ? null : new System.Collections.Generic.List<HazardousGoodsTransitType>(value);
        }
    }
        
    private System.Collections.Generic.List<DimensionType> _measurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order=16)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumTemperature", Order=17)]
    public TemperatureType @__MinimumTemperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumTemperature", Order=18)]
    public TemperatureType @__MaximumTemperature;
        
    private System.Collections.Generic.List<GoodsItemType> _goodsItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order=19)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FloorSpaceMeasurementDimension", Order=20)]
    public DimensionType @__FloorSpaceMeasurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PalletSpaceMeasurementDimension", Order=21)]
    public DimensionType @__PalletSpaceMeasurementDimension;
        
    private System.Collections.Generic.List<DocumentReferenceType> _shipmentDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference", Order=22)]
    public DocumentReferenceType[] @__ShipmentDocumentReference
    {
        get
        {
            return _shipmentDocumentReference?.ToArray();
        }
        set
        {
            _shipmentDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<StatusType> _status;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Status", Order=23)]
    public StatusType[] @__Status
    {
        get
        {
            return _status?.ToArray();
        }
        set
        {
            _status = value == null ? null : new System.Collections.Generic.List<StatusType>(value);
        }
    }
        
    private System.Collections.Generic.List<CustomsDeclarationType> _customsDeclaration;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration", Order=24)]
    public CustomsDeclarationType[] @__CustomsDeclaration
    {
        get
        {
            return _customsDeclaration?.ToArray();
        }
        set
        {
            _customsDeclaration = value == null ? null : new System.Collections.Generic.List<CustomsDeclarationType>(value);
        }
    }
        
    private System.Collections.Generic.List<ShipmentType> _referencedShipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferencedShipment", Order=25)]
    public ShipmentType[] @__ReferencedShipment
    {
        get
        {
            return _referencedShipment?.ToArray();
        }
        set
        {
            _referencedShipment = value == null ? null : new System.Collections.Generic.List<ShipmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<PackageType> _package;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Package", Order=26)]
    public PackageType[] @__Package
    {
        get
        {
            return _package?.ToArray();
        }
        set
        {
            _package = value == null ? null : new System.Collections.Generic.List<PackageType>(value);
        }
    }
        
    /// <summary>
    /// The handling required for this transport handling unit, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Handling_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
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
    /// Text describing damage associated with this transport handling unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Damage_ Remarks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Damage
    /// <para />PropertyTerm: Remarks
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> DamageRemarks
    {
        get { return _damageRemarks ?? (_damageRemarks = new System.Collections.Generic.List<TextType>()); }
        set { _damageRemarks = value; }
    }

        
    /// <summary>
    /// Text describing the marks and numbers on this transport handling unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Shipping_ Marks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Shipping
    /// <para />PropertyTerm: Marks
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Marks and Numbers, Shipping Marks
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ShippingMarks
    {
        get { return _shippingMarks ?? (_shippingMarks = new System.Collections.Generic.List<TextType>()); }
        set { _shippingMarks = value; }
    }

        
    /// <summary>
    /// A despatch line associated with this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Handling Unit_ Despatch Line. Despatch Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Handling Unit
    /// <para />PropertyTerm: Despatch Line
    /// <para />AssociatedObjectClass: Despatch Line
    /// <para />RepresentationTerm: Despatch Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DespatchLineType> HandlingUnitDespatchLine
    {
        get { return _handlingUnitDespatchLine ?? (_handlingUnitDespatchLine = new System.Collections.Generic.List<DespatchLineType>()); }
        set { _handlingUnitDespatchLine = value; }
    }

        
    /// <summary>
    /// A package contained in this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Actual_ Package. Package
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Package
    /// <para />AssociatedObjectClass: Package
    /// <para />RepresentationTerm: Package
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PackageType> ActualPackage
    {
        get { return _actualPackage ?? (_actualPackage = new System.Collections.Generic.List<PackageType>()); }
        set { _actualPackage = value; }
    }

        
    /// <summary>
    /// A receipt line associated with this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Received Handling Unit_ Receipt Line. Receipt Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Received Handling Unit
    /// <para />PropertyTerm: Receipt Line
    /// <para />AssociatedObjectClass: Receipt Line
    /// <para />RepresentationTerm: Receipt Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ReceiptLineType> ReceivedHandlingUnitReceiptLine
    {
        get { return _receivedHandlingUnitReceiptLine ?? (_receivedHandlingUnitReceiptLine = new System.Collections.Generic.List<ReceiptLineType>()); }
        set { _receivedHandlingUnitReceiptLine = value; }
    }

        
    /// <summary>
    /// A piece of transport equipment associated with this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Transport Equipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentType> TransportEquipment
    {
        get { return _transportEquipment ?? (_transportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
        set { _transportEquipment = value; }
    }

        
    /// <summary>
    /// A means of transport associated with this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Transport Means
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTerm: Transport Means
    /// <para />AssociatedObjectClass: Transport Means
    /// <para />RepresentationTerm: Transport Means
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportMeansType> TransportMeans
    {
        get { return _transportMeans ?? (_transportMeans = new System.Collections.Generic.List<TransportMeansType>()); }
        set { _transportMeans = value; }
    }

        
    /// <summary>
    /// Transit-related information regarding a type of hazardous goods contained in this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Hazardous Goods Transit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTerm: Hazardous Goods Transit
    /// <para />AssociatedObjectClass: Hazardous Goods Transit
    /// <para />RepresentationTerm: Hazardous Goods Transit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<HazardousGoodsTransitType> HazardousGoodsTransit
    {
        get { return _hazardousGoodsTransit ?? (_hazardousGoodsTransit = new System.Collections.Generic.List<HazardousGoodsTransitType>()); }
        set { _hazardousGoodsTransit = value; }
    }

        
    /// <summary>
    /// A measurable dimension (length, mass, weight, or volume) of this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
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
    /// A goods item contained in this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Goods Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
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
    /// A reference to a shipping document associated with this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Shipment_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Shipment
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> ShipmentDocumentReference
    {
        get { return _shipmentDocumentReference ?? (_shipmentDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _shipmentDocumentReference = value; }
    }

        
    /// <summary>
    /// The status of this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Status
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTerm: Status
    /// <para />AssociatedObjectClass: Status
    /// <para />RepresentationTerm: Status
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<StatusType> Status
    {
        get { return _status ?? (_status = new System.Collections.Generic.List<StatusType>()); }
        set { _status = value; }
    }

        
    /// <summary>
    /// Describes identifiers or references relating to customs procedures.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Customs Declaration
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTerm: Customs Declaration
    /// <para />AssociatedObjectClass: Customs Declaration
    /// <para />RepresentationTerm: Customs Declaration
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CustomsDeclarationType> CustomsDeclaration
    {
        get { return _customsDeclaration ?? (_customsDeclaration = new System.Collections.Generic.List<CustomsDeclarationType>()); }
        set { _customsDeclaration = value; }
    }

        
    /// <summary>
    /// A shipment associated with this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Referenced_ Shipment. Shipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Referenced
    /// <para />PropertyTerm: Shipment
    /// <para />AssociatedObjectClass: Shipment
    /// <para />RepresentationTerm: Shipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentType> ReferencedShipment
    {
        get { return _referencedShipment ?? (_referencedShipment = new System.Collections.Generic.List<ShipmentType>()); }
        set { _referencedShipment = value; }
    }

        
    /// <summary>
    /// A package contained in this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Package
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTerm: Package
    /// <para />AssociatedObjectClass: Package
    /// <para />RepresentationTerm: Package
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PackageType> Package
    {
        get { return _package ?? (_package = new System.Collections.Generic.List<PackageType>()); }
        set { _package = value; }
    }

        
    /// <summary>
    /// An identifier for this transport handling unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
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
    /// A code signifying the type of this transport handling unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Transport Handling Unit Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTerm: Transport Handling Unit Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportHandlingUnitTypeCode
    {
        get
        {
            if (__TransportHandlingUnitTypeCode == null) { __TransportHandlingUnitTypeCode = new CodeType(); }
            return __TransportHandlingUnitTypeCode;
        }
        set
        {
            __TransportHandlingUnitTypeCode = value;
        }
    }

        
    /// <summary>
    /// The handling required for this transport handling unit, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Handling Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
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
    /// An indicator that the materials contained in this transport handling unit are subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Hazardous Risk_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
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
    /// The total number of goods items in this transport handling unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Total_ Goods Item Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
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
    /// The total number of packages in this transport handling unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Total_ Package Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Package Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TotalPackageQuantity
    {
        get
        {
            if (__TotalPackageQuantity == null) { __TotalPackageQuantity = new QuantityType(); }
            return __TotalPackageQuantity;
        }
        set
        {
            __TotalPackageQuantity = value;
        }
    }

        
    /// <summary>
    /// An identifier for use in tracing this transport handling unit, such as the EPC number used in RFID.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Trace_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
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
    /// The minimum required operating temperature of this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Minimum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
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
    /// The maximum allowable operating temperature of this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Maximum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
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

        
    /// <summary>
    /// The floor space measurement dimension associated with this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Floor Space Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Floor Space Measurement
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DimensionType FloorSpaceMeasurementDimension
    {
        get
        {
            if (__FloorSpaceMeasurementDimension == null) { __FloorSpaceMeasurementDimension = new DimensionType(); }
            return __FloorSpaceMeasurementDimension;
        }
        set
        {
            __FloorSpaceMeasurementDimension = value;
        }
    }

        
    /// <summary>
    /// The pallet space measurement dimension associated to this transport handling unit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Handling Unit. Pallet Space Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Handling Unit
    /// <para />PropertyTermQualifier: Pallet Space Measurement
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DimensionType PalletSpaceMeasurementDimension
    {
        get
        {
            if (__PalletSpaceMeasurementDimension == null) { __PalletSpaceMeasurementDimension = new DimensionType(); }
            return __PalletSpaceMeasurementDimension;
        }
        set
        {
            __PalletSpaceMeasurementDimension = value;
        }
    }

}