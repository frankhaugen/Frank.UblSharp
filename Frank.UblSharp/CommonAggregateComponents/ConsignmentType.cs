using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an identifiable collection of one or more goods items to be transported between the consignor and the consignee. This information may be defined within a transport contract. A consignment may comprise more than one shipment (e.g., when consolidated by a freight forwarder).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consignment. Details
/// <para />ObjectClass: Consignment
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ChildConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ChildConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsignmentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CarrierAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__CarrierAssignedID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsigneeAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__ConsigneeAssignedID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsignorAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IdentifierType @__ConsignorAssignedID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightForwarderAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__FreightForwarderAssignedID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BrokerAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IdentifierType @__BrokerAssignedID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractedCarrierAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IdentifierType @__ContractedCarrierAssignedID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerformingCarrierAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public IdentifierType @__PerformingCarrierAssignedID;
        
    private System.Collections.Generic.List<TextType> _summaryDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SummaryDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType[] @__SummaryDescription
    {
        get
        {
            return _summaryDescription?.ToArray();
        }
        set
        {
            _summaryDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalInvoiceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public AmountType @__TotalInvoiceAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredCustomsValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public AmountType @__DeclaredCustomsValueAmount;
        
    private System.Collections.Generic.List<TextType> _tariffDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TariffDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType[] @__TariffDescription
    {
        get
        {
            return _tariffDescription?.ToArray();
        }
        set
        {
            _tariffDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TariffCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public CodeType @__TariffCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InsurancePremiumAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public AmountType @__InsurancePremiumAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public MeasureType @__GrossWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public MeasureType @__NetWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetNetWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public MeasureType @__NetNetWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChargeableWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
    public MeasureType @__ChargeableWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=18)]
    public MeasureType @__GrossVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=19)]
    public MeasureType @__NetVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingLengthMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=20)]
    public MeasureType @__LoadingLengthMeasure;
        
    private System.Collections.Generic.List<TextType> _remarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=21)]
    public TextType[] @__Remarks
    {
        get
        {
            return _remarks?.ToArray();
        }
        set
        {
            _remarks = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousRiskIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=22)]
    public IndicatorType @__HazardousRiskIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AnimalFoodIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=23)]
    public IndicatorType @__AnimalFoodIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HumanFoodIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=24)]
    public IndicatorType @__HumanFoodIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LivestockIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=25)]
    public IndicatorType @__LivestockIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BulkCargoIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=26)]
    public IndicatorType @__BulkCargoIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContainerizedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=27)]
    public IndicatorType @__ContainerizedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GeneralCargoIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=28)]
    public IndicatorType @__GeneralCargoIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecialSecurityIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=29)]
    public IndicatorType @__SpecialSecurityIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ThirdPartyPayerIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=30)]
    public IndicatorType @__ThirdPartyPayerIndicator;
        
    private System.Collections.Generic.List<TextType> _carrierServiceInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CarrierServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=31)]
    public TextType[] @__CarrierServiceInstructions
    {
        get
        {
            return _carrierServiceInstructions?.ToArray();
        }
        set
        {
            _carrierServiceInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _customsClearanceServiceInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomsClearanceServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=32)]
    public TextType[] @__CustomsClearanceServiceInstructions
    {
        get
        {
            return _customsClearanceServiceInstructions?.ToArray();
        }
        set
        {
            _customsClearanceServiceInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _forwarderServiceInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForwarderServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=33)]
    public TextType[] @__ForwarderServiceInstructions
    {
        get
        {
            return _forwarderServiceInstructions?.ToArray();
        }
        set
        {
            _forwarderServiceInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _specialServiceInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecialServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=34)]
    public TextType[] @__SpecialServiceInstructions
    {
        get
        {
            return _specialServiceInstructions?.ToArray();
        }
        set
        {
            _specialServiceInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=35)]
    public IdentifierType @__SequenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShippingPriorityLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=36)]
    public CodeType @__ShippingPriorityLevelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HandlingCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=37)]
    public CodeType @__HandlingCode;
        
    private System.Collections.Generic.List<TextType> _handlingInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=38)]
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
    [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=39)]
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
    [System.Xml.Serialization.XmlElementAttribute("TotalGoodsItemQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=40)]
    public QuantityType @__TotalGoodsItemQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalTransportHandlingUnitQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=41)]
    public QuantityType @__TotalTransportHandlingUnitQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InsuranceValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=42)]
    public AmountType @__InsuranceValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredForCarriageValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=43)]
    public AmountType @__DeclaredForCarriageValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeclaredStatisticsValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=44)]
    public AmountType @__DeclaredStatisticsValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreeOnBoardValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=45)]
    public AmountType @__FreeOnBoardValueAmount;
        
    private System.Collections.Generic.List<TextType> _specialInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=46)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SplitConsignmentIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=47)]
    public IndicatorType @__SplitConsignmentIndicator;
        
    private System.Collections.Generic.List<TextType> _deliveryInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=48)]
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
    [System.Xml.Serialization.XmlElementAttribute("ConsignmentQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=49)]
    public QuantityType @__ConsignmentQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsolidatableIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=50)]
    public IndicatorType @__ConsolidatableIndicator;
        
    private System.Collections.Generic.List<TextType> _haulageInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HaulageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=51)]
    public TextType[] @__HaulageInstructions
    {
        get
        {
            return _haulageInstructions?.ToArray();
        }
        set
        {
            _haulageInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingSequenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=52)]
    public IdentifierType @__LoadingSequenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChildConsignmentQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=53)]
    public QuantityType @__ChildConsignmentQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalPackagesQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=54)]
    public QuantityType @__TotalPackagesQuantity;
        
    private System.Collections.Generic.List<ShipmentType> _consolidatedShipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsolidatedShipment", Order=55)]
    public ShipmentType[] @__ConsolidatedShipment
    {
        get
        {
            return _consolidatedShipment?.ToArray();
        }
        set
        {
            _consolidatedShipment = value == null ? null : new System.Collections.Generic.List<ShipmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<CustomsDeclarationType> _customsDeclaration;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration", Order=56)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedPickupTransportEvent", Order=57)]
    public TransportEventType @__RequestedPickupTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedDeliveryTransportEvent", Order=58)]
    public TransportEventType @__RequestedDeliveryTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedPickupTransportEvent", Order=59)]
    public TransportEventType @__PlannedPickupTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedDeliveryTransportEvent", Order=60)]
    public TransportEventType @__PlannedDeliveryTransportEvent;
        
    private System.Collections.Generic.List<StatusType> _status;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Status", Order=61)]
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
        
    private System.Collections.Generic.List<ConsignmentType> _childConsignment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChildConsignment", Order=62)]
    public ConsignmentType[] @__ChildConsignment
    {
        get
        {
            return _childConsignment?.ToArray();
        }
        set
        {
            _childConsignment = value == null ? null : new System.Collections.Generic.List<ConsignmentType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsigneeParty", Order=63)]
    public PartyType @__ConsigneeParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExporterParty", Order=64)]
    public PartyType @__ExporterParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsignorParty", Order=65)]
    public PartyType @__ConsignorParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ImporterParty", Order=66)]
    public PartyType @__ImporterParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CarrierParty", Order=67)]
    public PartyType @__CarrierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightForwarderParty", Order=68)]
    public PartyType @__FreightForwarderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotifyParty", Order=69)]
    public PartyType @__NotifyParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginalDespatchParty", Order=70)]
    public PartyType @__OriginalDespatchParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinalDeliveryParty", Order=71)]
    public PartyType @__FinalDeliveryParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerformingCarrierParty", Order=72)]
    public PartyType @__PerformingCarrierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubstituteCarrierParty", Order=73)]
    public PartyType @__SubstituteCarrierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LogisticsOperatorParty", Order=74)]
    public PartyType @__LogisticsOperatorParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportAdvisorParty", Order=75)]
    public PartyType @__TransportAdvisorParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousItemNotificationParty", Order=76)]
    public PartyType @__HazardousItemNotificationParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InsuranceParty", Order=77)]
    public PartyType @__InsuranceParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MortgageHolderParty", Order=78)]
    public PartyType @__MortgageHolderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BillOfLadingHolderParty", Order=79)]
    public PartyType @__BillOfLadingHolderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginalDepartureCountry", Order=80)]
    public CountryType @__OriginalDepartureCountry;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinalDestinationCountry", Order=81)]
    public CountryType @__FinalDestinationCountry;
        
    private System.Collections.Generic.List<CountryType> _transitCountry;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransitCountry", Order=82)]
    public CountryType[] @__TransitCountry
    {
        get
        {
            return _transitCountry?.ToArray();
        }
        set
        {
            _transitCountry = value == null ? null : new System.Collections.Generic.List<CountryType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportContract", Order=83)]
    public ContractType @__TransportContract;
        
    private System.Collections.Generic.List<TransportEventType> _transportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent", Order=84)]
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
    [System.Xml.Serialization.XmlElementAttribute("OriginalDespatchTransportationService", Order=85)]
    public TransportationServiceType @__OriginalDespatchTransportationService;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinalDeliveryTransportationService", Order=86)]
    public TransportationServiceType @__FinalDeliveryTransportationService;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Order=87)]
    public DeliveryTermsType @__DeliveryTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Order=88)]
    public PaymentTermsType @__PaymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CollectPaymentTerms", Order=89)]
    public PaymentTermsType @__CollectPaymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DisbursementPaymentTerms", Order=90)]
    public PaymentTermsType @__DisbursementPaymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrepaidPaymentTerms", Order=91)]
    public PaymentTermsType @__PrepaidPaymentTerms;
        
    private System.Collections.Generic.List<AllowanceChargeType> _freightAllowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order=92)]
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
        
    private System.Collections.Generic.List<AllowanceChargeType> _extraAllowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExtraAllowanceCharge", Order=93)]
    public AllowanceChargeType[] @__ExtraAllowanceCharge
    {
        get
        {
            return _extraAllowanceCharge?.ToArray();
        }
        set
        {
            _extraAllowanceCharge = value == null ? null : new System.Collections.Generic.List<AllowanceChargeType>(value);
        }
    }
        
    private System.Collections.Generic.List<ShipmentStageType> _mainCarriageShipmentStage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MainCarriageShipmentStage", Order=94)]
    public ShipmentStageType[] @__MainCarriageShipmentStage
    {
        get
        {
            return _mainCarriageShipmentStage?.ToArray();
        }
        set
        {
            _mainCarriageShipmentStage = value == null ? null : new System.Collections.Generic.List<ShipmentStageType>(value);
        }
    }
        
    private System.Collections.Generic.List<ShipmentStageType> _preCarriageShipmentStage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreCarriageShipmentStage", Order=95)]
    public ShipmentStageType[] @__PreCarriageShipmentStage
    {
        get
        {
            return _preCarriageShipmentStage?.ToArray();
        }
        set
        {
            _preCarriageShipmentStage = value == null ? null : new System.Collections.Generic.List<ShipmentStageType>(value);
        }
    }
        
    private System.Collections.Generic.List<ShipmentStageType> _onCarriageShipmentStage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OnCarriageShipmentStage", Order=96)]
    public ShipmentStageType[] @__OnCarriageShipmentStage
    {
        get
        {
            return _onCarriageShipmentStage?.ToArray();
        }
        set
        {
            _onCarriageShipmentStage = value == null ? null : new System.Collections.Generic.List<ShipmentStageType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportHandlingUnitType> _transportHandlingUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit", Order=97)]
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
    [System.Xml.Serialization.XmlElementAttribute("FirstArrivalPortLocation", Order=98)]
    public LocationType @__FirstArrivalPortLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LastExitPortLocation", Order=99)]
    public LocationType @__LastExitPortLocation;
        
    /// <summary>
    /// A textual summary description of the consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Summary_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Summary
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> SummaryDescription
    {
        get { return _summaryDescription ?? (_summaryDescription = new System.Collections.Generic.List<TextType>()); }
        set { _summaryDescription = value; }
    }

        
    /// <summary>
    /// Text describing the tariff applied to this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Tariff Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Tariff Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> TariffDescription
    {
        get { return _tariffDescription ?? (_tariffDescription = new System.Collections.Generic.List<TextType>()); }
        set { _tariffDescription = value; }
    }

        
    /// <summary>
    /// Remarks concerning the complete consignment, to be printed on the transport document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Remarks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Remarks
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Remarks
    {
        get { return _remarks ?? (_remarks = new System.Collections.Generic.List<TextType>()); }
        set { _remarks = value; }
    }

        
    /// <summary>
    /// Service instructions to the carrier, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Carrier Service_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Carrier Service
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> CarrierServiceInstructions
    {
        get { return _carrierServiceInstructions ?? (_carrierServiceInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _carrierServiceInstructions = value; }
    }

        
    /// <summary>
    /// Service instructions for customs clearance, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Customs Clearance Service_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Customs Clearance Service
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> CustomsClearanceServiceInstructions
    {
        get { return _customsClearanceServiceInstructions ?? (_customsClearanceServiceInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _customsClearanceServiceInstructions = value; }
    }

        
    /// <summary>
    /// Service instructions for the forwarder, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Forwarder Service_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Forwarder Service
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ForwarderServiceInstructions
    {
        get { return _forwarderServiceInstructions ?? (_forwarderServiceInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _forwarderServiceInstructions = value; }
    }

        
    /// <summary>
    /// Special service instructions, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Special Service_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Special Service
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> SpecialServiceInstructions
    {
        get { return _specialServiceInstructions ?? (_specialServiceInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _specialServiceInstructions = value; }
    }

        
    /// <summary>
    /// The handling required for this consignment, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Handling_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// Free-form text pertinent to this consignment, conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// Special instructions relating to this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Special_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// A set of delivery instructions relating to this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Delivery_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// Instructions regarding haulage of this consignment, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Haulage_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Haulage
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> HaulageInstructions
    {
        get { return _haulageInstructions ?? (_haulageInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _haulageInstructions = value; }
    }

        
    /// <summary>
    /// A consolidated shipment (a shipment created by an act of consolidation).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Consolidated_ Shipment. Shipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Consolidated
    /// <para />PropertyTerm: Shipment
    /// <para />AssociatedObjectClass: Shipment
    /// <para />RepresentationTerm: Shipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentType> ConsolidatedShipment
    {
        get { return _consolidatedShipment ?? (_consolidatedShipment = new System.Collections.Generic.List<ShipmentType>()); }
        set { _consolidatedShipment = value; }
    }

        
    /// <summary>
    /// A class describing identifiers or references relating to customs procedures.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Customs Declaration
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// The status of a particular condition associated with this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Status
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// One of the child consignments of which a consolidated consignment is composed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Child_ Consignment. Consignment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Child
    /// <para />PropertyTerm: Consignment
    /// <para />AssociatedObjectClass: Consignment
    /// <para />RepresentationTerm: Consignment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsignmentType> ChildConsignment
    {
        get { return _childConsignment ?? (_childConsignment = new System.Collections.Generic.List<ConsignmentType>()); }
        set { _childConsignment = value; }
    }

        
    /// <summary>
    /// One of the countries through which goods or passengers in this consignment are routed between the country of original departure and the country of final destination.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Transit_ Country. Country
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Transit
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// <para />AlternativeBusinessTerms: Country(ies) of routing (WCO ID 064)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CountryType> TransitCountry
    {
        get { return _transitCountry ?? (_transitCountry = new System.Collections.Generic.List<CountryType>()); }
        set { _transitCountry = value; }
    }

        
    /// <summary>
    /// A class describing a significant occurrence or happening related to the transportation of goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// A cost incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage for this consignment. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance to the extent that they relate to the freight costs.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Freight_ Allowance Charge. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// A charge for extra allowance.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Extra_ Allowance Charge. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Extra
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AllowanceChargeType> ExtraAllowanceCharge
    {
        get { return _extraAllowanceCharge ?? (_extraAllowanceCharge = new System.Collections.Generic.List<AllowanceChargeType>()); }
        set { _extraAllowanceCharge = value; }
    }

        
    /// <summary>
    /// A shipment stage during main carriage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Main Carriage_ Shipment Stage. Shipment Stage
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Main Carriage
    /// <para />PropertyTerm: Shipment Stage
    /// <para />AssociatedObjectClass: Shipment Stage
    /// <para />RepresentationTerm: Shipment Stage
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentStageType> MainCarriageShipmentStage
    {
        get { return _mainCarriageShipmentStage ?? (_mainCarriageShipmentStage = new System.Collections.Generic.List<ShipmentStageType>()); }
        set { _mainCarriageShipmentStage = value; }
    }

        
    /// <summary>
    /// A shipment stage during precarriage (usually refers to movement activity that takes place prior to the container being loaded at a port of loading).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Pre Carriage_ Shipment Stage. Shipment Stage
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Pre Carriage
    /// <para />PropertyTerm: Shipment Stage
    /// <para />AssociatedObjectClass: Shipment Stage
    /// <para />RepresentationTerm: Shipment Stage
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentStageType> PreCarriageShipmentStage
    {
        get { return _preCarriageShipmentStage ?? (_preCarriageShipmentStage = new System.Collections.Generic.List<ShipmentStageType>()); }
        set { _preCarriageShipmentStage = value; }
    }

        
    /// <summary>
    /// A shipment stage during on-carriage (usually refers to movement activity that takes place after the container is discharged at a port of discharge).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. On Carriage_ Shipment Stage. Shipment Stage
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: On Carriage
    /// <para />PropertyTerm: Shipment Stage
    /// <para />AssociatedObjectClass: Shipment Stage
    /// <para />RepresentationTerm: Shipment Stage
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentStageType> OnCarriageShipmentStage
    {
        get { return _onCarriageShipmentStage ?? (_onCarriageShipmentStage = new System.Collections.Generic.List<ShipmentStageType>()); }
        set { _onCarriageShipmentStage = value; }
    }

        
    /// <summary>
    /// A transport handling unit used for loose and containerized goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Transport Handling Unit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consignment
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
    /// An identifier assigned to a collection of goods for both import and export.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Unique consignment reference number (UCR)
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
    /// An identifier for this consignment, assigned by the carrier.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Carrier Assigned_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Carrier Assigned
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType CarrierAssignedID
    {
        get
        {
            if (__CarrierAssignedID == null) { __CarrierAssignedID = new IdentifierType(); }
            return __CarrierAssignedID;
        }
        set
        {
            __CarrierAssignedID = value;
        }
    }

        
    /// <summary>
    /// An identifier for this consignment, assigned by the consignee.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Consignee Assigned_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Consignee Assigned
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ConsigneeAssignedID
    {
        get
        {
            if (__ConsigneeAssignedID == null) { __ConsigneeAssignedID = new IdentifierType(); }
            return __ConsigneeAssignedID;
        }
        set
        {
            __ConsigneeAssignedID = value;
        }
    }

        
    /// <summary>
    /// An identifier for this consignment, assigned by the consignor.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Consignor Assigned_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Consignor Assigned
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ConsignorAssignedID
    {
        get
        {
            if (__ConsignorAssignedID == null) { __ConsignorAssignedID = new IdentifierType(); }
            return __ConsignorAssignedID;
        }
        set
        {
            __ConsignorAssignedID = value;
        }
    }

        
    /// <summary>
    /// An identifier for this consignment, assigned by the freight forwarder.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Freight Forwarder Assigned_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Freight Forwarder Assigned
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType FreightForwarderAssignedID
    {
        get
        {
            if (__FreightForwarderAssignedID == null) { __FreightForwarderAssignedID = new IdentifierType(); }
            return __FreightForwarderAssignedID;
        }
        set
        {
            __FreightForwarderAssignedID = value;
        }
    }

        
    /// <summary>
    /// An identifier for this consignment, assigned by the broker.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Broker Assigned_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Broker Assigned
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType BrokerAssignedID
    {
        get
        {
            if (__BrokerAssignedID == null) { __BrokerAssignedID = new IdentifierType(); }
            return __BrokerAssignedID;
        }
        set
        {
            __BrokerAssignedID = value;
        }
    }

        
    /// <summary>
    /// An identifier for this consignment, assigned by the contracted carrier.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Contracted Carrier Assigned_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Contracted Carrier Assigned
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ContractedCarrierAssignedID
    {
        get
        {
            if (__ContractedCarrierAssignedID == null) { __ContractedCarrierAssignedID = new IdentifierType(); }
            return __ContractedCarrierAssignedID;
        }
        set
        {
            __ContractedCarrierAssignedID = value;
        }
    }

        
    /// <summary>
    /// An identifier for this consignment, assigned by the performing carrier.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Performing Carrier Assigned_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Performing Carrier Assigned
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType PerformingCarrierAssignedID
    {
        get
        {
            if (__PerformingCarrierAssignedID == null) { __PerformingCarrierAssignedID = new IdentifierType(); }
            return __PerformingCarrierAssignedID;
        }
        set
        {
            __PerformingCarrierAssignedID = value;
        }
    }

        
    /// <summary>
    /// The total of all invoice amounts declared in this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Total_ Invoice Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Invoice Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TotalInvoiceAmount
    {
        get
        {
            if (__TotalInvoiceAmount == null) { __TotalInvoiceAmount = new AmountType(); }
            return __TotalInvoiceAmount;
        }
        set
        {
            __TotalInvoiceAmount = value;
        }
    }

        
    /// <summary>
    /// The total declared value for customs purposes of all the goods in this consignment, regardless of whether they are subject to the same customs procedure, tariff/statistical categorization, country information, or duty regime.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Declared Customs_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// A code signifying the tariff applied to this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Tariff Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Tariff Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Tariff code number (WCO ID 145)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TariffCode
    {
        get
        {
            if (__TariffCode == null) { __TariffCode = new CodeType(); }
            return __TariffCode;
        }
        set
        {
            __TariffCode = value;
        }
    }

        
    /// <summary>
    /// The amount of the premium payable to an insurance company for insuring the goods contained in this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Insurance Premium Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Insurance Premium Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// <para />AlternativeBusinessTerms: Insurance Cost
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType InsurancePremiumAmount
    {
        get
        {
            if (__InsurancePremiumAmount == null) { __InsurancePremiumAmount = new AmountType(); }
            return __InsurancePremiumAmount;
        }
        set
        {
            __InsurancePremiumAmount = value;
        }
    }

        
    /// <summary>
    /// The total declared weight of the goods in this consignment, including packaging but excluding the carrier&apos;s equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Gross_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Gross
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// <para />AlternativeBusinessTerms: Total gross weight (WCO ID 131)
    /// </summary>
    /// <example>Total cube of all goods items referred to as one consignment.</example>
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
    /// The total net weight of all the goods items referred to as one consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Net_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The total net weight of the goods in this consignment, exclusive of packaging.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Net Net_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The weight upon which a charge is to be based.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Chargeable_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Chargeable
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// <para />AlternativeBusinessTerms: Chargeable Weight. Basis.Measure
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
    /// The total volume of the goods referred to as one consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Gross_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Gross
    /// <para />PropertyTerm: Volume
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// <para />AlternativeBusinessTerms: Cube
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
    /// The total net volume of all goods items referred to as one consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Net_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The total length in a means of transport or a piece of transport equipment which, given the width and height of the transport means, will accommodate all of the consignments in a single consolidation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Loading_ Length. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Loading
    /// <para />PropertyTerm: Length
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType LoadingLengthMeasure
    {
        get
        {
            if (__LoadingLengthMeasure == null) { __LoadingLengthMeasure = new MeasureType(); }
            return __LoadingLengthMeasure;
        }
        set
        {
            __LoadingLengthMeasure = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods in this consignment are subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Hazardous Risk_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Hazardous Risk
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// <para />AlternativeBusinessTerms: Dangerous Goods RID Indicator
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
    /// An indication that the transported goods in this consignment are animal foodstuffs (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Animal_ Food Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Animal
    /// <para />PropertyTerm: Food Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType AnimalFoodIndicator
    {
        get
        {
            if (__AnimalFoodIndicator == null) { __AnimalFoodIndicator = new IndicatorType(); }
            return __AnimalFoodIndicator;
        }
        set
        {
            __AnimalFoodIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods in this consignment are for human consumption (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Human_ Food Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Human
    /// <para />PropertyTerm: Food Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType HumanFoodIndicator
    {
        get
        {
            if (__HumanFoodIndicator == null) { __HumanFoodIndicator = new IndicatorType(); }
            return __HumanFoodIndicator;
        }
        set
        {
            __HumanFoodIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods are livestock (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Livestock_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Livestock
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType LivestockIndicator
    {
        get
        {
            if (__LivestockIndicator == null) { __LivestockIndicator = new IndicatorType(); }
            return __LivestockIndicator;
        }
        set
        {
            __LivestockIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods in this consignment are bulk cargoes (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Bulk Cargo_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Bulk Cargo
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType BulkCargoIndicator
    {
        get
        {
            if (__BulkCargoIndicator == null) { __BulkCargoIndicator = new IndicatorType(); }
            return __BulkCargoIndicator;
        }
        set
        {
            __BulkCargoIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods in this consignment are containerized cargoes (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Containerized_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Containerized
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType ContainerizedIndicator
    {
        get
        {
            if (__ContainerizedIndicator == null) { __ContainerizedIndicator = new IndicatorType(); }
            return __ContainerizedIndicator;
        }
        set
        {
            __ContainerizedIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods in this consignment are general cargoes (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. General Cargo_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: General Cargo
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType GeneralCargoIndicator
    {
        get
        {
            if (__GeneralCargoIndicator == null) { __GeneralCargoIndicator = new IndicatorType(); }
            return __GeneralCargoIndicator;
        }
        set
        {
            __GeneralCargoIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods in this consignment require special security (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Special_ Security Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Special
    /// <para />PropertyTerm: Security Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType SpecialSecurityIndicator
    {
        get
        {
            if (__SpecialSecurityIndicator == null) { __SpecialSecurityIndicator = new IndicatorType(); }
            return __SpecialSecurityIndicator;
        }
        set
        {
            __SpecialSecurityIndicator = value;
        }
    }

        
    /// <summary>
    /// An indication that this consignment will be paid for by a third party (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Third Party Payer_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Third Party Payer
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType ThirdPartyPayerIndicator
    {
        get
        {
            if (__ThirdPartyPayerIndicator == null) { __ThirdPartyPayerIndicator = new IndicatorType(); }
            return __ThirdPartyPayerIndicator;
        }
        set
        {
            __ThirdPartyPayerIndicator = value;
        }
    }

        
    /// <summary>
    /// A sequence identifier for this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Sequence Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Sequence Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SequenceID
    {
        get
        {
            if (__SequenceID == null) { __SequenceID = new IdentifierType(); }
            return __SequenceID;
        }
        set
        {
            __SequenceID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the priority or level of service required for this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Shipping Priority Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Shipping Priority Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
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
    /// The handling required for this consignment, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Handling Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The total number of goods items in this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Total_ Goods Item Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The number of pieces of transport handling equipment (pallets, boxes, cases, etc.) in this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Total_ Transport Handling Unit Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The amount covered by insurance for this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Insurance_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The value of this consignment, declared by the shipper or his agent solely for the purpose of varying the carrier&apos;s level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Declared For Carriage_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The value, declared for statistical purposes, of those goods in this consignment that have the same statistical heading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Declared Statistics_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// <para />DictionaryEntryName: Consignment. Free On Board_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// An indicator that this consignment has been split in transit (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Split Consignment_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The count in this consignment considering goods items, child consignments, shipments
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Consignment_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// An indicator that this consignment can be consolidated (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Consolidatable_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Consolidatable
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType ConsolidatableIndicator
    {
        get
        {
            if (__ConsolidatableIndicator == null) { __ConsolidatableIndicator = new IndicatorType(); }
            return __ConsolidatableIndicator;
        }
        set
        {
            __ConsolidatableIndicator = value;
        }
    }

        
    /// <summary>
    /// An identifier for the loading sequence of this consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Loading_ Sequence Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Loading
    /// <para />PropertyTerm: Sequence Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LoadingSequenceID
    {
        get
        {
            if (__LoadingSequenceID == null) { __LoadingSequenceID = new IdentifierType(); }
            return __LoadingSequenceID;
        }
        set
        {
            __LoadingSequenceID = value;
        }
    }

        
    /// <summary>
    /// The quantity of (consolidated) child consignments
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Child Consignment Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Child Consignment Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ChildConsignmentQuantity
    {
        get
        {
            if (__ChildConsignmentQuantity == null) { __ChildConsignmentQuantity = new QuantityType(); }
            return __ChildConsignmentQuantity;
        }
        set
        {
            __ChildConsignmentQuantity = value;
        }
    }

        
    /// <summary>
    /// The total number of packages associated with a Consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consignment. Total_ Packages Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Packages Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TotalPackagesQuantity
    {
        get
        {
            if (__TotalPackagesQuantity == null) { __TotalPackagesQuantity = new QuantityType(); }
            return __TotalPackagesQuantity;
        }
        set
        {
            __TotalPackagesQuantity = value;
        }
    }

        
    /// <summary>
    /// The pickup of this consignment requested by the party requesting a transportation service (the transport user).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Requested Pickup_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Requested Pickup
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType RequestedPickupTransportEvent
    {
        get
        {
            if (__RequestedPickupTransportEvent == null) { __RequestedPickupTransportEvent = new TransportEventType(); }
            return __RequestedPickupTransportEvent;
        }
        set
        {
            __RequestedPickupTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The delivery of this consignment requested by the party requesting a transportation service (the transport user).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Requested Delivery_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Requested Delivery
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType RequestedDeliveryTransportEvent
    {
        get
        {
            if (__RequestedDeliveryTransportEvent == null) { __RequestedDeliveryTransportEvent = new TransportEventType(); }
            return __RequestedDeliveryTransportEvent;
        }
        set
        {
            __RequestedDeliveryTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The pickup of this consignment planned by the party responsible for providing the transportation service (the transport service provider).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Planned Pickup_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Planned Pickup
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType PlannedPickupTransportEvent
    {
        get
        {
            if (__PlannedPickupTransportEvent == null) { __PlannedPickupTransportEvent = new TransportEventType(); }
            return __PlannedPickupTransportEvent;
        }
        set
        {
            __PlannedPickupTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The delivery of this consignment planned by the party responsible for providing the transportation service (the transport service provider).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Planned Delivery_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Planned Delivery
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType PlannedDeliveryTransportEvent
    {
        get
        {
            if (__PlannedDeliveryTransportEvent == null) { __PlannedDeliveryTransportEvent = new TransportEventType(); }
            return __PlannedDeliveryTransportEvent;
        }
        set
        {
            __PlannedDeliveryTransportEvent = value;
        }
    }

        
    /// <summary>
    /// A party to which goods are consigned.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Consignee_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Consignee
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Consignee (WCO ID 51 and 52)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ConsigneeParty
    {
        get
        {
            if (__ConsigneeParty == null) { __ConsigneeParty = new PartyType(); }
            return __ConsigneeParty;
        }
        set
        {
            __ConsigneeParty = value;
        }
    }

        
    /// <summary>
    /// The party that makes the export declaration, or on behalf of which the export declaration is made, and that is the owner of the goods in this consignment or has similar right of disposal over them at the time when the declaration is accepted.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Exporter_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Exporter
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Exporter (WCO ID 41 and 42)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ExporterParty
    {
        get
        {
            if (__ExporterParty == null) { __ExporterParty = new PartyType(); }
            return __ExporterParty;
        }
        set
        {
            __ExporterParty = value;
        }
    }

        
    /// <summary>
    /// The party consigning goods, as stipulated in the transport contract by the party ordering transport.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Consignor_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Consignor
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Consignor (WCO ID 71 and 72)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ConsignorParty
    {
        get
        {
            if (__ConsignorParty == null) { __ConsignorParty = new PartyType(); }
            return __ConsignorParty;
        }
        set
        {
            __ConsignorParty = value;
        }
    }

        
    /// <summary>
    /// The party that makes an import declaration regarding this consignment, or on behalf of which a customs clearing agent or other authorized person makes an import declaration regarding this consignment. This may include a person who has possession of the goods or to whom the goods are consigned.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Importer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Importer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Importer (WCO ID 39 and 40)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ImporterParty
    {
        get
        {
            if (__ImporterParty == null) { __ImporterParty = new PartyType(); }
            return __ImporterParty;
        }
        set
        {
            __ImporterParty = value;
        }
    }

        
    /// <summary>
    /// The party providing the transport of goods in this consignment between named points.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Carrier_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Carrier
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Transport Company, Shipping Line, NVOCC, Airline, Haulier, Courier, Carrier (WCO ID 49 and 50)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType CarrierParty
    {
        get
        {
            if (__CarrierParty == null) { __CarrierParty = new PartyType(); }
            return __CarrierParty;
        }
        set
        {
            __CarrierParty = value;
        }
    }

        
    /// <summary>
    /// The party combining individual smaller consignments into a single larger shipment (the consolidated shipment), which is sent to a counterpart that mirrors the consolidator&apos;s activity by dividing the consolidated consignment into its original components.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Freight Forwarder_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Freight Forwarder
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: Consolidator (WCO ID 192 AND 193)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType FreightForwarderParty
    {
        get
        {
            if (__FreightForwarderParty == null) { __FreightForwarderParty = new PartyType(); }
            return __FreightForwarderParty;
        }
        set
        {
            __FreightForwarderParty = value;
        }
    }

        
    /// <summary>
    /// The party to be notified upon arrival of goods and when special occurrences (usually pre-defined) take place during a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Notify_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Notify
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// <para />AlternativeBusinessTerms: WCO ID 57 and 58
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType NotifyParty
    {
        get
        {
            if (__NotifyParty == null) { __NotifyParty = new PartyType(); }
            return __NotifyParty;
        }
        set
        {
            __NotifyParty = value;
        }
    }

        
    /// <summary>
    /// The original despatch (sender) party for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Original Despatch_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Original Despatch
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType OriginalDespatchParty
    {
        get
        {
            if (__OriginalDespatchParty == null) { __OriginalDespatchParty = new PartyType(); }
            return __OriginalDespatchParty;
        }
        set
        {
            __OriginalDespatchParty = value;
        }
    }

        
    /// <summary>
    /// The final delivery party for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Final Delivery_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Final Delivery
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType FinalDeliveryParty
    {
        get
        {
            if (__FinalDeliveryParty == null) { __FinalDeliveryParty = new PartyType(); }
            return __FinalDeliveryParty;
        }
        set
        {
            __FinalDeliveryParty = value;
        }
    }

        
    /// <summary>
    /// The party performing the carriage of this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Performing Carrier_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Performing Carrier
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType PerformingCarrierParty
    {
        get
        {
            if (__PerformingCarrierParty == null) { __PerformingCarrierParty = new PartyType(); }
            return __PerformingCarrierParty;
        }
        set
        {
            __PerformingCarrierParty = value;
        }
    }

        
    /// <summary>
    /// A substitute party performing the carriage of this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Substitute Carrier_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Substitute Carrier
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType SubstituteCarrierParty
    {
        get
        {
            if (__SubstituteCarrierParty == null) { __SubstituteCarrierParty = new PartyType(); }
            return __SubstituteCarrierParty;
        }
        set
        {
            __SubstituteCarrierParty = value;
        }
    }

        
    /// <summary>
    /// The logistics operator party for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Logistics Operator_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Logistics Operator
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType LogisticsOperatorParty
    {
        get
        {
            if (__LogisticsOperatorParty == null) { __LogisticsOperatorParty = new PartyType(); }
            return __LogisticsOperatorParty;
        }
        set
        {
            __LogisticsOperatorParty = value;
        }
    }

        
    /// <summary>
    /// The party providing transport advice this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Transport Advisor_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Transport Advisor
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType TransportAdvisorParty
    {
        get
        {
            if (__TransportAdvisorParty == null) { __TransportAdvisorParty = new PartyType(); }
            return __TransportAdvisorParty;
        }
        set
        {
            __TransportAdvisorParty = value;
        }
    }

        
    /// <summary>
    /// The party that would be notified of a hazardous item in this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Hazardous Item Notification_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Hazardous Item Notification
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType HazardousItemNotificationParty
    {
        get
        {
            if (__HazardousItemNotificationParty == null) { __HazardousItemNotificationParty = new PartyType(); }
            return __HazardousItemNotificationParty;
        }
        set
        {
            __HazardousItemNotificationParty = value;
        }
    }

        
    /// <summary>
    /// The party holding the insurance for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Insurance_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Insurance
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType InsuranceParty
    {
        get
        {
            if (__InsuranceParty == null) { __InsuranceParty = new PartyType(); }
            return __InsuranceParty;
        }
        set
        {
            __InsuranceParty = value;
        }
    }

        
    /// <summary>
    /// The party holding the mortgage for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Mortgage Holder_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Mortgage Holder
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType MortgageHolderParty
    {
        get
        {
            if (__MortgageHolderParty == null) { __MortgageHolderParty = new PartyType(); }
            return __MortgageHolderParty;
        }
        set
        {
            __MortgageHolderParty = value;
        }
    }

        
    /// <summary>
    /// The party holding the bill of lading for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Bill Of Lading Holder_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Bill Of Lading Holder
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType BillOfLadingHolderParty
    {
        get
        {
            if (__BillOfLadingHolderParty == null) { __BillOfLadingHolderParty = new PartyType(); }
            return __BillOfLadingHolderParty;
        }
        set
        {
            __BillOfLadingHolderParty = value;
        }
    }

        
    /// <summary>
    /// The country from which the goods in this consignment were originally exported, without any commercial transaction taking place in intermediate countries.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Original Departure_ Country. Country
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Original Departure
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// <para />AlternativeBusinessTerms: Country of origin (WCO ID 062)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CountryType OriginalDepartureCountry
    {
        get
        {
            if (__OriginalDepartureCountry == null) { __OriginalDepartureCountry = new CountryType(); }
            return __OriginalDepartureCountry;
        }
        set
        {
            __OriginalDepartureCountry = value;
        }
    }

        
    /// <summary>
    /// The country in which the goods in this consignment are to be delivered to the final consignee or buyer.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Final Destination_ Country. Country
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Final Destination
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// <para />AlternativeBusinessTerms: Ultimate Destination Country, Country of Final Arrival, Country of Destination
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CountryType FinalDestinationCountry
    {
        get
        {
            if (__FinalDestinationCountry == null) { __FinalDestinationCountry = new CountryType(); }
            return __FinalDestinationCountry;
        }
        set
        {
            __FinalDestinationCountry = value;
        }
    }

        
    /// <summary>
    /// A transport contract relating to this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Transport_ Contract. Contract
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Transport
    /// <para />PropertyTerm: Contract
    /// <para />AssociatedObjectClass: Contract
    /// <para />RepresentationTerm: Contract
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContractType TransportContract
    {
        get
        {
            if (__TransportContract == null) { __TransportContract = new ContractType(); }
            return __TransportContract;
        }
        set
        {
            __TransportContract = value;
        }
    }

        
    /// <summary>
    /// The service for pickup from the consignor under the transport contract for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Original Despatch_ Transportation Service. Transportation Service
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Original Despatch
    /// <para />PropertyTerm: Transportation Service
    /// <para />AssociatedObjectClass: Transportation Service
    /// <para />RepresentationTerm: Transportation Service
    /// </summary>
    /// <example>Door-to-door , Pier-to-door</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportationServiceType OriginalDespatchTransportationService
    {
        get
        {
            if (__OriginalDespatchTransportationService == null) { __OriginalDespatchTransportationService = new TransportationServiceType(); }
            return __OriginalDespatchTransportationService;
        }
        set
        {
            __OriginalDespatchTransportationService = value;
        }
    }

        
    /// <summary>
    /// The service for delivery to the consignee under the transport contract for this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Final Delivery_ Transportation Service. Transportation Service
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Final Delivery
    /// <para />PropertyTerm: Transportation Service
    /// <para />AssociatedObjectClass: Transportation Service
    /// <para />RepresentationTerm: Transportation Service
    /// </summary>
    /// <example>Door-to-door , Pier-to-door</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportationServiceType FinalDeliveryTransportationService
    {
        get
        {
            if (__FinalDeliveryTransportationService == null) { __FinalDeliveryTransportationService = new TransportationServiceType(); }
            return __FinalDeliveryTransportationService;
        }
        set
        {
            __FinalDeliveryTransportationService = value;
        }
    }

        
    /// <summary>
    /// The conditions agreed upon between a seller and a buyer with regard to the delivery of goods and/or services (e.g., CIF, FOB, or EXW from the INCOTERMS Terms of Delivery).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Delivery Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Delivery Terms
    /// <para />AssociatedObjectClass: Delivery Terms
    /// <para />RepresentationTerm: Delivery Terms
    /// <para />AlternativeBusinessTerms: Trade Terms, INCOTERMS
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DeliveryTermsType DeliveryTerms
    {
        get
        {
            if (__DeliveryTerms == null) { __DeliveryTerms = new DeliveryTermsType(); }
            return __DeliveryTerms;
        }
        set
        {
            __DeliveryTerms = value;
        }
    }

        
    /// <summary>
    /// The terms of payment between the parties (such as logistics service client, logistics service provider) in a transaction.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType PaymentTerms
    {
        get
        {
            if (__PaymentTerms == null) { __PaymentTerms = new PaymentTermsType(); }
            return __PaymentTerms;
        }
        set
        {
            __PaymentTerms = value;
        }
    }

        
    /// <summary>
    /// The terms of payment that apply to the collection of this consignment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Collect_ Payment Terms. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Collect
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType CollectPaymentTerms
    {
        get
        {
            if (__CollectPaymentTerms == null) { __CollectPaymentTerms = new PaymentTermsType(); }
            return __CollectPaymentTerms;
        }
        set
        {
            __CollectPaymentTerms = value;
        }
    }

        
    /// <summary>
    /// The terms of payment for disbursement.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Disbursement_ Payment Terms. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Disbursement
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType DisbursementPaymentTerms
    {
        get
        {
            if (__DisbursementPaymentTerms == null) { __DisbursementPaymentTerms = new PaymentTermsType(); }
            return __DisbursementPaymentTerms;
        }
        set
        {
            __DisbursementPaymentTerms = value;
        }
    }

        
    /// <summary>
    /// The terms of payment for prepayment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Prepaid_ Payment Terms. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
    /// <para />PropertyTermQualifier: Prepaid
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType PrepaidPaymentTerms
    {
        get
        {
            if (__PrepaidPaymentTerms == null) { __PrepaidPaymentTerms = new PaymentTermsType(); }
            return __PrepaidPaymentTerms;
        }
        set
        {
            __PrepaidPaymentTerms = value;
        }
    }

        
    /// <summary>
    /// The first arrival location in a transport. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. First Arrival Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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
    /// The final exporting location in a transport. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consignment. Last Exit Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consignment
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

}