/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("MainCarriageShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ShipmentStageType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportModeCodeType TransportModeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportMeansTypeCodeType TransportMeansTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransitDirectionCodeType TransitDirectionCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreCarriageIndicatorType PreCarriageIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OnCarriageIndicatorType OnCarriageIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDeliveryDateType EstimatedDeliveryDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDeliveryTimeType EstimatedDeliveryTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredDeliveryDateType RequiredDeliveryDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredDeliveryTimeType RequiredDeliveryTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LoadingSequenceIDType LoadingSequenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SuccessiveSequenceIDType SuccessiveSequenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionsType[] Instructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DemurrageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DemurrageInstructionsType[] DemurrageInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CrewQuantityType CrewQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PassengerQuantityType PassengerQuantity { get; set; }

    /// <remarks/>
    public PeriodType TransitPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CarrierParty")]
    public PartyType[] CarrierParty { get; set; }

    /// <remarks/>
    public TransportMeansType TransportMeans { get; set; }

    /// <remarks/>
    public LocationType1 LoadingPortLocation { get; set; }

    /// <remarks/>
    public LocationType1 UnloadingPortLocation { get; set; }

    /// <remarks/>
    public LocationType1 TransshipPortLocation { get; set; }

    /// <remarks/>
    public TransportEventType LoadingTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ExaminationTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType AvailabilityTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ExportationTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType DischargeTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType WarehousingTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType TakeoverTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType OptionalTakeoverTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType DropoffTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ActualPickupTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType DeliveryTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ReceiptTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType StorageTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType AcceptanceTransportEvent { get; set; }

    /// <remarks/>
    public PartyType TerminalOperatorParty { get; set; }

    /// <remarks/>
    public PartyType CustomsAgentParty { get; set; }

    /// <remarks/>
    public PeriodType EstimatedTransitPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge { get; set; }

    /// <remarks/>
    public LocationType1 FreightChargeLocation { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DetentionTransportEvent")]
    public TransportEventType[] DetentionTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType RequestedDepartureTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType RequestedArrivalTransportEvent { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequestedWaypointTransportEvent")]
    public TransportEventType[] RequestedWaypointTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType PlannedDepartureTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType PlannedArrivalTransportEvent { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PlannedWaypointTransportEvent")]
    public TransportEventType[] PlannedWaypointTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ActualDepartureTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ActualWaypointTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ActualArrivalTransportEvent { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
    public TransportEventType[] TransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType EstimatedDepartureTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType EstimatedArrivalTransportEvent { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PassengerPerson")]
    public PersonType[] PassengerPerson { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DriverPerson")]
    public PersonType[] DriverPerson { get; set; }

    /// <remarks/>
    public PersonType ReportingPerson { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CrewMemberPerson")]
    public PersonType[] CrewMemberPerson { get; set; }

    /// <remarks/>
    public PersonType SecurityOfficerPerson { get; set; }

    /// <remarks/>
    public PersonType MasterPerson { get; set; }

    /// <remarks/>
    public PersonType ShipsSurgeonPerson { get; set; }
}