using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a piece of equipment used to transport goods.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transport Equipment. Details
/// <para />ObjectClass: Transport Equipment
/// <para />AlternativeBusinessTerms: Shipping Container, Sea Container, Rail Wagon, Pallet, Trailer, Unit Load Device, ULD
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AttachedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AttachedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportEquipmentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<IdentifierType> _referencedConsignmentID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferencedConsignmentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType[] @__ReferencedConsignmentID
    {
        get
        {
            return _referencedConsignmentID?.ToArray();
        }
        set
        {
            _referencedConsignmentID = value == null ? null : new System.Collections.Generic.List<IdentifierType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEquipmentTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__TransportEquipmentTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProviderTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__ProviderTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OwnerTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__OwnerTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SizeTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__SizeTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DispositionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__DispositionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FullnessIndicationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__FullnessIndicationCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RefrigerationOnIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IndicatorType @__RefrigerationOnIndicator;
        
    private System.Collections.Generic.List<TextType> _information;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
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
    [System.Xml.Serialization.XmlElementAttribute("ReturnabilityIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public IndicatorType @__ReturnabilityIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LegalStatusIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public IndicatorType @__LegalStatusIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AirFlowPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public PercentType @__AirFlowPercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HumidityPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public PercentType @__HumidityPercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AnimalFoodApprovedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public IndicatorType @__AnimalFoodApprovedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HumanFoodApprovedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public IndicatorType @__HumanFoodApprovedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DangerousGoodsApprovedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public IndicatorType @__DangerousGoodsApprovedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RefrigeratedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
    public IndicatorType @__RefrigeratedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Characteristics", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=18)]
    public TextType @__Characteristics;
        
    private System.Collections.Generic.List<TextType> _damageRemarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=19)]
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
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=20)]
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
        
    private System.Collections.Generic.List<TextType> _specialTransportRequirements;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecialTransportRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=21)]
    public TextType[] @__SpecialTransportRequirements
    {
        get
        {
            return _specialTransportRequirements?.ToArray();
        }
        set
        {
            _specialTransportRequirements = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=22)]
    public MeasureType @__GrossWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=23)]
    public MeasureType @__GrossVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TareWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=24)]
    public MeasureType @__TareWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TrackingDeviceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=25)]
    public CodeType @__TrackingDeviceCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PowerIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=26)]
    public IndicatorType @__PowerIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TraceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=27)]
    public IdentifierType @__TraceID;
        
    private System.Collections.Generic.List<DimensionType> _measurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order=28)]
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
        
    private System.Collections.Generic.List<TransportEquipmentSealType> _transportEquipmentSeal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEquipmentSeal", Order=29)]
    public TransportEquipmentSealType[] @__TransportEquipmentSeal
    {
        get
        {
            return _transportEquipmentSeal?.ToArray();
        }
        set
        {
            _transportEquipmentSeal = value == null ? null : new System.Collections.Generic.List<TransportEquipmentSealType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumTemperature", Order=30)]
    public TemperatureType @__MinimumTemperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumTemperature", Order=31)]
    public TemperatureType @__MaximumTemperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProviderParty", Order=32)]
    public PartyType @__ProviderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingProofParty", Order=33)]
    public PartyType @__LoadingProofParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplierParty", Order=34)]
    public SupplierPartyType @__SupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OwnerParty", Order=35)]
    public PartyType @__OwnerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OperatingParty", Order=36)]
    public PartyType @__OperatingParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingLocation", Order=37)]
    public LocationType @__LoadingLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnloadingLocation", Order=38)]
    public LocationType @__UnloadingLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StorageLocation", Order=39)]
    public LocationType @__StorageLocation;
        
    private System.Collections.Generic.List<TransportEventType> _positioningTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PositioningTransportEvent", Order=40)]
    public TransportEventType[] @__PositioningTransportEvent
    {
        get
        {
            return _positioningTransportEvent?.ToArray();
        }
        set
        {
            _positioningTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEventType> _quarantineTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("QuarantineTransportEvent", Order=41)]
    public TransportEventType[] @__QuarantineTransportEvent
    {
        get
        {
            return _quarantineTransportEvent?.ToArray();
        }
        set
        {
            _quarantineTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEventType> _deliveryTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTransportEvent", Order=42)]
    public TransportEventType[] @__DeliveryTransportEvent
    {
        get
        {
            return _deliveryTransportEvent?.ToArray();
        }
        set
        {
            _deliveryTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEventType> _pickupTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PickupTransportEvent", Order=43)]
    public TransportEventType[] @__PickupTransportEvent
    {
        get
        {
            return _pickupTransportEvent?.ToArray();
        }
        set
        {
            _pickupTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEventType> _handlingTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HandlingTransportEvent", Order=44)]
    public TransportEventType[] @__HandlingTransportEvent
    {
        get
        {
            return _handlingTransportEvent?.ToArray();
        }
        set
        {
            _handlingTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEventType> _loadingTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingTransportEvent", Order=45)]
    public TransportEventType[] @__LoadingTransportEvent
    {
        get
        {
            return _loadingTransportEvent?.ToArray();
        }
        set
        {
            _loadingTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEventType> _transportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent", Order=46)]
    public TransportEventType[] @__TransportEvent
    {
        get
        {
            return _transportEvent?.ToArray();
        }
        set
        {
            _transportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ApplicableTransportMeans", Order=47)]
    public TransportMeansType @__ApplicableTransportMeans;
        
    private System.Collections.Generic.List<TradingTermsType> _haulageTradingTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HaulageTradingTerms", Order=48)]
    public TradingTermsType[] @__HaulageTradingTerms
    {
        get
        {
            return _haulageTradingTerms?.ToArray();
        }
        set
        {
            _haulageTradingTerms = value == null ? null : new System.Collections.Generic.List<TradingTermsType>(value);
        }
    }
        
    private System.Collections.Generic.List<HazardousGoodsTransitType> _hazardousGoodsTransit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit", Order=49)]
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
        
    private System.Collections.Generic.List<TransportHandlingUnitType> _packagedTransportHandlingUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackagedTransportHandlingUnit", Order=50)]
    public TransportHandlingUnitType[] @__PackagedTransportHandlingUnit
    {
        get
        {
            return _packagedTransportHandlingUnit?.ToArray();
        }
        set
        {
            _packagedTransportHandlingUnit = value == null ? null : new System.Collections.Generic.List<TransportHandlingUnitType>(value);
        }
    }
        
    private System.Collections.Generic.List<AllowanceChargeType> _serviceAllowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ServiceAllowanceCharge", Order=51)]
    public AllowanceChargeType[] @__ServiceAllowanceCharge
    {
        get
        {
            return _serviceAllowanceCharge?.ToArray();
        }
        set
        {
            _serviceAllowanceCharge = value == null ? null : new System.Collections.Generic.List<AllowanceChargeType>(value);
        }
    }
        
    private System.Collections.Generic.List<AllowanceChargeType> _freightAllowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order=52)]
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
        
    private System.Collections.Generic.List<TransportEquipmentType> _attachedTransportEquipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AttachedTransportEquipment", Order=53)]
    public TransportEquipmentType[] @__AttachedTransportEquipment
    {
        get
        {
            return _attachedTransportEquipment?.ToArray();
        }
        set
        {
            _attachedTransportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=54)]
    public DeliveryType @__Delivery;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Pickup", Order=55)]
    public PickupType @__Pickup;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Despatch", Order=56)]
    public DespatchType @__Despatch;
        
    private System.Collections.Generic.List<DocumentReferenceType> _shipmentDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference", Order=57)]
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
        
    private System.Collections.Generic.List<TransportEquipmentType> _containedInTransportEquipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContainedInTransportEquipment", Order=58)]
    public TransportEquipmentType[] @__ContainedInTransportEquipment
    {
        get
        {
            return _containedInTransportEquipment?.ToArray();
        }
        set
        {
            _containedInTransportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<PackageType> _package;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Package", Order=59)]
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
        
    private System.Collections.Generic.List<GoodsItemType> _goodsItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order=60)]
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
        
    /// <summary>
    /// An identifier for the consignment contained by this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Referenced_ Consignment Identifier. Identifier
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Referenced
    /// <para />PropertyTerm: Consignment Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<IdentifierType> ReferencedConsignmentID
    {
        get { return _referencedConsignmentID ?? (_referencedConsignmentID = new System.Collections.Generic.List<IdentifierType>()); }
        set { _referencedConsignmentID = value; }
    }

        
    /// <summary>
    /// Additional information about this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// Damage associated with this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Damage_ Remarks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// Text describing this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// Special transport requirements expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Special_ Transport Requirements. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Special
    /// <para />PropertyTerm: Transport Requirements
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> SpecialTransportRequirements
    {
        get { return _specialTransportRequirements ?? (_specialTransportRequirements = new System.Collections.Generic.List<TextType>()); }
        set { _specialTransportRequirements = value; }
    }

        
    /// <summary>
    /// A measurable dimension (length, mass, weight, or volume) of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// A seal securing the door of a piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Transport Equipment Seal
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Transport Equipment Seal
    /// <para />AssociatedObjectClass: Transport Equipment Seal
    /// <para />RepresentationTerm: Transport Equipment Seal
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentSealType> TransportEquipmentSeal
    {
        get { return _transportEquipmentSeal ?? (_transportEquipmentSeal = new System.Collections.Generic.List<TransportEquipmentSealType>()); }
        set { _transportEquipmentSeal = value; }
    }

        
    /// <summary>
    /// A positioning of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Positioning_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Positioning
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> PositioningTransportEvent
    {
        get { return _positioningTransportEvent ?? (_positioningTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _positioningTransportEvent = value; }
    }

        
    /// <summary>
    /// A quarantine of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Quarantine_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Quarantine
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> QuarantineTransportEvent
    {
        get { return _quarantineTransportEvent ?? (_quarantineTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _quarantineTransportEvent = value; }
    }

        
    /// <summary>
    /// A delivery of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Delivery_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> DeliveryTransportEvent
    {
        get { return _deliveryTransportEvent ?? (_deliveryTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _deliveryTransportEvent = value; }
    }

        
    /// <summary>
    /// A pickup of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Pickup_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Pickup
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> PickupTransportEvent
    {
        get { return _pickupTransportEvent ?? (_pickupTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _pickupTransportEvent = value; }
    }

        
    /// <summary>
    /// A handling of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Handling_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Handling
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> HandlingTransportEvent
    {
        get { return _handlingTransportEvent ?? (_handlingTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _handlingTransportEvent = value; }
    }

        
    /// <summary>
    /// A loading of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Loading_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Loading
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> LoadingTransportEvent
    {
        get { return _loadingTransportEvent ?? (_loadingTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _loadingTransportEvent = value; }
    }

        
    /// <summary>
    /// A transport event associated with this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> TransportEvent
    {
        get { return _transportEvent ?? (_transportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _transportEvent = value; }
    }

        
    /// <summary>
    /// A set of haulage trading terms associated with this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Haulage_ Trading Terms. Trading Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Haulage
    /// <para />PropertyTerm: Trading Terms
    /// <para />AssociatedObjectClass: Trading Terms
    /// <para />RepresentationTerm: Trading Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TradingTermsType> HaulageTradingTerms
    {
        get { return _haulageTradingTerms ?? (_haulageTradingTerms = new System.Collections.Generic.List<TradingTermsType>()); }
        set { _haulageTradingTerms = value; }
    }

        
    /// <summary>
    /// Transit-related information regarding a type of hazardous goods contained in this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Hazardous Goods Transit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// A packaged transport handling unit associated with this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Packaged_ Transport Handling Unit. Transport Handling Unit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Packaged
    /// <para />PropertyTerm: Transport Handling Unit
    /// <para />AssociatedObjectClass: Transport Handling Unit
    /// <para />RepresentationTerm: Transport Handling Unit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportHandlingUnitType> PackagedTransportHandlingUnit
    {
        get { return _packagedTransportHandlingUnit ?? (_packagedTransportHandlingUnit = new System.Collections.Generic.List<TransportHandlingUnitType>()); }
        set { _packagedTransportHandlingUnit = value; }
    }

        
    /// <summary>
    /// A service allowance charge associated with this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Service_ Allowance Charge. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Service
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AllowanceChargeType> ServiceAllowanceCharge
    {
        get { return _serviceAllowanceCharge ?? (_serviceAllowanceCharge = new System.Collections.Generic.List<AllowanceChargeType>()); }
        set { _serviceAllowanceCharge = value; }
    }

        
    /// <summary>
    /// A freight allowance charge associated with this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Freight_ Allowance Charge. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Freight
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AllowanceChargeType> FreightAllowanceCharge
    {
        get { return _freightAllowanceCharge ?? (_freightAllowanceCharge = new System.Collections.Generic.List<AllowanceChargeType>()); }
        set { _freightAllowanceCharge = value; }
    }

        
    /// <summary>
    /// A piece of transport equipment attached to this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Attached_ Transport Equipment. Transport Equipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Attached
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentType> AttachedTransportEquipment
    {
        get { return _attachedTransportEquipment ?? (_attachedTransportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
        set { _attachedTransportEquipment = value; }
    }

        
    /// <summary>
    /// A reference to a shipping document associated with this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Shipment_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// A piece of transport equipment contained in this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Contained In_ Transport Equipment. Transport Equipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Contained In
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    /// <example>e.g. pallets inside containers</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentType> ContainedInTransportEquipment
    {
        get { return _containedInTransportEquipment ?? (_containedInTransportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
        set { _containedInTransportEquipment = value; }
    }

        
    /// <summary>
    /// A package contained in this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Package
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// A goods item contained in this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Goods Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Equipment
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
    /// An identifier for this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>OCLU 1234567</example>
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
    /// A code signifying the type of this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Transport Equipment Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Transport Equipment Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Transport Equipment Type
    /// <para />DataType: Transport Equipment Type_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportEquipmentTypeCode
    {
        get
        {
            if (__TransportEquipmentTypeCode == null) { __TransportEquipmentTypeCode = new CodeType(); }
            return __TransportEquipmentTypeCode;
        }
        set
        {
            __TransportEquipmentTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of provider of this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Provider Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Provider Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ProviderTypeCode
    {
        get
        {
            if (__ProviderTypeCode == null) { __ProviderTypeCode = new CodeType(); }
            return __ProviderTypeCode;
        }
        set
        {
            __ProviderTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of owner of this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Owner Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Owner Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType OwnerTypeCode
    {
        get
        {
            if (__OwnerTypeCode == null) { __OwnerTypeCode = new CodeType(); }
            return __OwnerTypeCode;
        }
        set
        {
            __OwnerTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the size and type of this piece of piece of transport equipment. When the piece of transport equipment is a shipping container, it is recommended to use ContainerSizeTypeCode for validation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Size Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Size Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Container Size Type Code
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SizeTypeCode
    {
        get
        {
            if (__SizeTypeCode == null) { __SizeTypeCode = new CodeType(); }
            return __SizeTypeCode;
        }
        set
        {
            __SizeTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the current disposition of this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Disposition Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Disposition Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Status
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DispositionCode
    {
        get
        {
            if (__DispositionCode == null) { __DispositionCode = new CodeType(); }
            return __DispositionCode;
        }
        set
        {
            __DispositionCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying whether this piece of transport equipment is full, partially full, or empty.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Fullness Indication Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Fullness Indication Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType FullnessIndicationCode
    {
        get
        {
            if (__FullnessIndicationCode == null) { __FullnessIndicationCode = new CodeType(); }
            return __FullnessIndicationCode;
        }
        set
        {
            __FullnessIndicationCode = value;
        }
    }

        
    /// <summary>
    /// An indicator that this piece of transport equipment&apos;s refrigeration is on (true) or off (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Refrigeration On_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Refrigeration On
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType RefrigerationOnIndicator
    {
        get
        {
            if (__RefrigerationOnIndicator == null) { __RefrigerationOnIndicator = new IndicatorType(); }
            return __RefrigerationOnIndicator;
        }
        set
        {
            __RefrigerationOnIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that this piece of transport equipment is returnable (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Returnability_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Returnability
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType ReturnabilityIndicator
    {
        get
        {
            if (__ReturnabilityIndicator == null) { __ReturnabilityIndicator = new IndicatorType(); }
            return __ReturnabilityIndicator;
        }
        set
        {
            __ReturnabilityIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication of the legal status of this piece of transport equipment with respect to the Container Convention Code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Legal Status_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Legal Status
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType LegalStatusIndicator
    {
        get
        {
            if (__LegalStatusIndicator == null) { __LegalStatusIndicator = new IndicatorType(); }
            return __LegalStatusIndicator;
        }
        set
        {
            __LegalStatusIndicator = value;
        }
    }

        
    /// <summary>
    /// The percent of the airflow within this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Air Flow Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Air Flow Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType AirFlowPercent
    {
        get
        {
            if (__AirFlowPercent == null) { __AirFlowPercent = new PercentType(); }
            return __AirFlowPercent;
        }
        set
        {
            __AirFlowPercent = value;
        }
    }

        
    /// <summary>
    /// The percent humidity within this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Humidity Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Humidity Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType HumidityPercent
    {
        get
        {
            if (__HumidityPercent == null) { __HumidityPercent = new PercentType(); }
            return __HumidityPercent;
        }
        set
        {
            __HumidityPercent = value;
        }
    }

        
    /// <summary>
    /// An indicator that this piece of transport equipment is approved for animal food (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Animal Food_ Approved Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Animal Food
    /// <para />PropertyTerm: Approved Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType AnimalFoodApprovedIndicator
    {
        get
        {
            if (__AnimalFoodApprovedIndicator == null) { __AnimalFoodApprovedIndicator = new IndicatorType(); }
            return __AnimalFoodApprovedIndicator;
        }
        set
        {
            __AnimalFoodApprovedIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that this piece of transport equipment is approved for human food (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Human Food_ Approved Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Human Food
    /// <para />PropertyTerm: Approved Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType HumanFoodApprovedIndicator
    {
        get
        {
            if (__HumanFoodApprovedIndicator == null) { __HumanFoodApprovedIndicator = new IndicatorType(); }
            return __HumanFoodApprovedIndicator;
        }
        set
        {
            __HumanFoodApprovedIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that this piece of transport equipment is approved for dangerous goods (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Dangerous Goods_ Approved Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Dangerous Goods
    /// <para />PropertyTerm: Approved Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType DangerousGoodsApprovedIndicator
    {
        get
        {
            if (__DangerousGoodsApprovedIndicator == null) { __DangerousGoodsApprovedIndicator = new IndicatorType(); }
            return __DangerousGoodsApprovedIndicator;
        }
        set
        {
            __DangerousGoodsApprovedIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that this piece of transport equipment is refrigerated (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Refrigerated_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Refrigerated
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType RefrigeratedIndicator
    {
        get
        {
            if (__RefrigeratedIndicator == null) { __RefrigeratedIndicator = new IndicatorType(); }
            return __RefrigeratedIndicator;
        }
        set
        {
            __RefrigeratedIndicator = value;
        }
    }

        
    /// <summary>
    /// Characteristics of this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Characteristics. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Characteristics
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Characteristics
    {
        get
        {
            if (__Characteristics == null) { __Characteristics = new TextType(); }
            return __Characteristics;
        }
        set
        {
            __Characteristics = value;
        }
    }

        
    /// <summary>
    /// The gross weight of this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Gross_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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
    /// The gross volume of this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Gross_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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
    /// The weight of this piece of transport equipment when empty.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Tare_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Tare
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType TareWeightMeasure
    {
        get
        {
            if (__TareWeightMeasure == null) { __TareWeightMeasure = new MeasureType(); }
            return __TareWeightMeasure;
        }
        set
        {
            __TareWeightMeasure = value;
        }
    }

        
    /// <summary>
    /// A code signifying the tracking device for this piece of transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Tracking Device Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Tracking Device Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TrackingDeviceCode
    {
        get
        {
            if (__TrackingDeviceCode == null) { __TrackingDeviceCode = new CodeType(); }
            return __TrackingDeviceCode;
        }
        set
        {
            __TrackingDeviceCode = value;
        }
    }

        
    /// <summary>
    /// An indicator that this piece of transport equipment can supply power (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Power. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Power
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType PowerIndicator
    {
        get
        {
            if (__PowerIndicator == null) { __PowerIndicator = new IndicatorType(); }
            return __PowerIndicator;
        }
        set
        {
            __PowerIndicator = value;
        }
    }

        
    /// <summary>
    /// An identifier for use in tracing this piece of transport equipment, such as the EPC number used in RFID.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment. Trace_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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
    /// In the case of a refrigeration unit, the minimum allowable operating temperature for this container.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Minimum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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
    /// In the case of a refrigeration unit, the maximum allowable operating temperature for this container.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Maximum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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
    /// The party providing this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Provider_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Provider
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ProviderParty
    {
        get
        {
            if (__ProviderParty == null) { __ProviderParty = new PartyType(); }
            return __ProviderParty;
        }
        set
        {
            __ProviderParty = value;
        }
    }

        
    /// <summary>
    /// The authorized party responsible for certifying that the goods were loaded into this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Loading Proof_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Loading Proof
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Party responsible for proof of vanning (WCO ID 059)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType LoadingProofParty
    {
        get
        {
            if (__LoadingProofParty == null) { __LoadingProofParty = new PartyType(); }
            return __LoadingProofParty;
        }
        set
        {
            __LoadingProofParty = value;
        }
    }

        
    /// <summary>
    /// The party that supplies this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTerm: Supplier Party
    /// <para />AssociatedObjectClass: Supplier Party
    /// <para />RepresentationTerm: Supplier Party
    /// <para />AlternativeBusinessTerms: Party responsible for proof of vanning (WCO ID 059)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SupplierPartyType SupplierParty
    {
        get
        {
            if (__SupplierParty == null) { __SupplierParty = new SupplierPartyType(); }
            return __SupplierParty;
        }
        set
        {
            __SupplierParty = value;
        }
    }

        
    /// <summary>
    /// The party that owns this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Owner_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Owner
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Party responsible for proof of vanning (WCO ID 059)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType OwnerParty
    {
        get
        {
            if (__OwnerParty == null) { __OwnerParty = new PartyType(); }
            return __OwnerParty;
        }
        set
        {
            __OwnerParty = value;
        }
    }

        
    /// <summary>
    /// The party that operates this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Operating_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Operating
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Party responsible for proof of vanning (WCO ID 059)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType OperatingParty
    {
        get
        {
            if (__OperatingParty == null) { __OperatingParty = new PartyType(); }
            return __OperatingParty;
        }
        set
        {
            __OperatingParty = value;
        }
    }

        
    /// <summary>
    /// The location where this piece of transport equipment is loaded.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Loading_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Loading
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// <para />AlternativeBusinessTerms: Vanning address (WCO ID 068), Stuffing location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType LoadingLocation
    {
        get
        {
            if (__LoadingLocation == null) { __LoadingLocation = new LocationType(); }
            return __LoadingLocation;
        }
        set
        {
            __LoadingLocation = value;
        }
    }

        
    /// <summary>
    /// The location where this piece of transport equipment is unloaded.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Unloading_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Unloading
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType UnloadingLocation
    {
        get
        {
            if (__UnloadingLocation == null) { __UnloadingLocation = new LocationType(); }
            return __UnloadingLocation;
        }
        set
        {
            __UnloadingLocation = value;
        }
    }

        
    /// <summary>
    /// The location where this piece of transport equipment is being stored.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Storage_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Storage
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType StorageLocation
    {
        get
        {
            if (__StorageLocation == null) { __StorageLocation = new LocationType(); }
            return __StorageLocation;
        }
        set
        {
            __StorageLocation = value;
        }
    }

        
    /// <summary>
    /// The applicable transport means associated with this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Applicable_ Transport Means. Transport Means
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
    /// <para />PropertyTermQualifier: Applicable
    /// <para />PropertyTerm: Transport Means
    /// <para />AssociatedObjectClass: Transport Means
    /// <para />RepresentationTerm: Transport Means
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportMeansType ApplicableTransportMeans
    {
        get
        {
            if (__ApplicableTransportMeans == null) { __ApplicableTransportMeans = new TransportMeansType(); }
            return __ApplicableTransportMeans;
        }
        set
        {
            __ApplicableTransportMeans = value;
        }
    }

        
    /// <summary>
    /// The delivery of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Delivery
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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
    /// The pickup of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Pickup
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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
    /// The despatch of this piece of transport equipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Equipment. Despatch
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment
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

}