using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe one stage of movement in a transport of goods.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Shipment Stage. Details
/// <para />ObjectClass: Shipment Stage
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("MainCarriageShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("MainCarriageShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ShipmentStageType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportModeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__TransportModeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportMeansTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__TransportMeansTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransitDirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__TransitDirectionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreCarriageIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IndicatorType @__PreCarriageIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OnCarriageIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IndicatorType @__OnCarriageIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDeliveryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public DateType @__EstimatedDeliveryDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDeliveryTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TimeType @__EstimatedDeliveryTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredDeliveryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public DateType @__RequiredDeliveryDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredDeliveryTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public TimeType @__RequiredDeliveryTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingSequenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public IdentifierType @__LoadingSequenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SuccessiveSequenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public IdentifierType @__SuccessiveSequenceID;
        
    private System.Collections.Generic.List<TextType> _instructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public TextType[] @__Instructions
    {
        get
        {
            return _instructions?.ToArray();
        }
        set
        {
            _instructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _demurrageInstructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DemurrageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public TextType[] @__DemurrageInstructions
    {
        get
        {
            return _demurrageInstructions?.ToArray();
        }
        set
        {
            _demurrageInstructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CrewQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public QuantityType @__CrewQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PassengerQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public QuantityType @__PassengerQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransitPeriod", Order=16)]
    public PeriodType @__TransitPeriod;
        
    private System.Collections.Generic.List<PartyType> _carrierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CarrierParty", Order=17)]
    public PartyType[] @__CarrierParty
    {
        get
        {
            return _carrierParty?.ToArray();
        }
        set
        {
            _carrierParty = value == null ? null : new System.Collections.Generic.List<PartyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportMeans", Order=18)]
    public TransportMeansType @__TransportMeans;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingPortLocation", Order=19)]
    public LocationType @__LoadingPortLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnloadingPortLocation", Order=20)]
    public LocationType @__UnloadingPortLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransshipPortLocation", Order=21)]
    public LocationType @__TransshipPortLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LoadingTransportEvent", Order=22)]
    public TransportEventType @__LoadingTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExaminationTransportEvent", Order=23)]
    public TransportEventType @__ExaminationTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AvailabilityTransportEvent", Order=24)]
    public TransportEventType @__AvailabilityTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExportationTransportEvent", Order=25)]
    public TransportEventType @__ExportationTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DischargeTransportEvent", Order=26)]
    public TransportEventType @__DischargeTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarehousingTransportEvent", Order=27)]
    public TransportEventType @__WarehousingTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TakeoverTransportEvent", Order=28)]
    public TransportEventType @__TakeoverTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OptionalTakeoverTransportEvent", Order=29)]
    public TransportEventType @__OptionalTakeoverTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DropoffTransportEvent", Order=30)]
    public TransportEventType @__DropoffTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualPickupTransportEvent", Order=31)]
    public TransportEventType @__ActualPickupTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTransportEvent", Order=32)]
    public TransportEventType @__DeliveryTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceiptTransportEvent", Order=33)]
    public TransportEventType @__ReceiptTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StorageTransportEvent", Order=34)]
    public TransportEventType @__StorageTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AcceptanceTransportEvent", Order=35)]
    public TransportEventType @__AcceptanceTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TerminalOperatorParty", Order=36)]
    public PartyType @__TerminalOperatorParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomsAgentParty", Order=37)]
    public PartyType @__CustomsAgentParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedTransitPeriod", Order=38)]
    public PeriodType @__EstimatedTransitPeriod;
        
    private System.Collections.Generic.List<AllowanceChargeType> _freightAllowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order=39)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightChargeLocation", Order=40)]
    public LocationType @__FreightChargeLocation;
        
    private System.Collections.Generic.List<TransportEventType> _detentionTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DetentionTransportEvent", Order=41)]
    public TransportEventType[] @__DetentionTransportEvent
    {
        get
        {
            return _detentionTransportEvent?.ToArray();
        }
        set
        {
            _detentionTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedDepartureTransportEvent", Order=42)]
    public TransportEventType @__RequestedDepartureTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedArrivalTransportEvent", Order=43)]
    public TransportEventType @__RequestedArrivalTransportEvent;
        
    private System.Collections.Generic.List<TransportEventType> _requestedWaypointTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedWaypointTransportEvent", Order=44)]
    public TransportEventType[] @__RequestedWaypointTransportEvent
    {
        get
        {
            return _requestedWaypointTransportEvent?.ToArray();
        }
        set
        {
            _requestedWaypointTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedDepartureTransportEvent", Order=45)]
    public TransportEventType @__PlannedDepartureTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedArrivalTransportEvent", Order=46)]
    public TransportEventType @__PlannedArrivalTransportEvent;
        
    private System.Collections.Generic.List<TransportEventType> _plannedWaypointTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedWaypointTransportEvent", Order=47)]
    public TransportEventType[] @__PlannedWaypointTransportEvent
    {
        get
        {
            return _plannedWaypointTransportEvent?.ToArray();
        }
        set
        {
            _plannedWaypointTransportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualDepartureTransportEvent", Order=48)]
    public TransportEventType @__ActualDepartureTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualWaypointTransportEvent", Order=49)]
    public TransportEventType @__ActualWaypointTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualArrivalTransportEvent", Order=50)]
    public TransportEventType @__ActualArrivalTransportEvent;
        
    private System.Collections.Generic.List<TransportEventType> _transportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent", Order=51)]
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
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDepartureTransportEvent", Order=52)]
    public TransportEventType @__EstimatedDepartureTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedArrivalTransportEvent", Order=53)]
    public TransportEventType @__EstimatedArrivalTransportEvent;
        
    private System.Collections.Generic.List<PersonType> _passengerPerson;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PassengerPerson", Order=54)]
    public PersonType[] @__PassengerPerson
    {
        get
        {
            return _passengerPerson?.ToArray();
        }
        set
        {
            _passengerPerson = value == null ? null : new System.Collections.Generic.List<PersonType>(value);
        }
    }
        
    private System.Collections.Generic.List<PersonType> _driverPerson;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DriverPerson", Order=55)]
    public PersonType[] @__DriverPerson
    {
        get
        {
            return _driverPerson?.ToArray();
        }
        set
        {
            _driverPerson = value == null ? null : new System.Collections.Generic.List<PersonType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReportingPerson", Order=56)]
    public PersonType @__ReportingPerson;
        
    private System.Collections.Generic.List<PersonType> _crewMemberPerson;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CrewMemberPerson", Order=57)]
    public PersonType[] @__CrewMemberPerson
    {
        get
        {
            return _crewMemberPerson?.ToArray();
        }
        set
        {
            _crewMemberPerson = value == null ? null : new System.Collections.Generic.List<PersonType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SecurityOfficerPerson", Order=58)]
    public PersonType @__SecurityOfficerPerson;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MasterPerson", Order=59)]
    public PersonType @__MasterPerson;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipsSurgeonPerson", Order=60)]
    public PersonType @__ShipsSurgeonPerson;
        
    /// <summary>
    /// Text of instructions applicable to a shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Instructions
    {
        get { return _instructions ?? (_instructions = new System.Collections.Generic.List<TextType>()); }
        set { _instructions = value; }
    }

        
    /// <summary>
    /// Text of instructions relating to demurrage (the case in which a vessel is prevented from loading or discharging cargo within the stipulated laytime).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Demurrage_ Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Demurrage
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> DemurrageInstructions
    {
        get { return _demurrageInstructions ?? (_demurrageInstructions = new System.Collections.Generic.List<TextType>()); }
        set { _demurrageInstructions = value; }
    }

        
    /// <summary>
    /// A carrier party responsible for this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Carrier_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Carrier
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyType> CarrierParty
    {
        get { return _carrierParty ?? (_carrierParty = new System.Collections.Generic.List<PartyType>()); }
        set { _carrierParty = value; }
    }

        
    /// <summary>
    /// A freight allowance charge for this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Freight_ Allowance Charge. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
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
    /// The detention of a transport means during loading and unloading operations.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Detention_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Detention
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> DetentionTransportEvent
    {
        get { return _detentionTransportEvent ?? (_detentionTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _detentionTransportEvent = value; }
    }

        
    /// <summary>
    /// A waypoint requested by the party requesting a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Requested Waypoint_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Requested Waypoint
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> RequestedWaypointTransportEvent
    {
        get { return _requestedWaypointTransportEvent ?? (_requestedWaypointTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _requestedWaypointTransportEvent = value; }
    }

        
    /// <summary>
    /// A waypoint planned by the party providing a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Planned Waypoint_ Transport Event. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Planned Waypoint
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> PlannedWaypointTransportEvent
    {
        get { return _plannedWaypointTransportEvent ?? (_plannedWaypointTransportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _plannedWaypointTransportEvent = value; }
    }

        
    /// <summary>
    /// A significant occurrence in the course of this shipment of goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
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
    /// A person who travels in a conveyance without participating in its operation.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Passenger_ Person. Person
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Passenger
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PersonType> PassengerPerson
    {
        get { return _passengerPerson ?? (_passengerPerson = new System.Collections.Generic.List<PersonType>()); }
        set { _passengerPerson = value; }
    }

        
    /// <summary>
    /// Describes a person responsible for driving the transport means.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Driver_ Person. Person
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Driver
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PersonType> DriverPerson
    {
        get { return _driverPerson ?? (_driverPerson = new System.Collections.Generic.List<PersonType>()); }
        set { _driverPerson = value; }
    }

        
    /// <summary>
    /// A person operating or serving aboard a transport means.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Crew Member_ Person. Person
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Crew Member
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PersonType> CrewMemberPerson
    {
        get { return _crewMemberPerson ?? (_crewMemberPerson = new System.Collections.Generic.List<PersonType>()); }
        set { _crewMemberPerson = value; }
    }

        
    /// <summary>
    /// An identifier for this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1 , 2 , etc..</example>
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
    /// A code signifying the method of transport used for this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Transport Mode Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTerm: Transport Mode Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Transport Mode
    /// <para />DataType: Transport Mode_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportModeCode
    {
        get
        {
            if (__TransportModeCode == null) { __TransportModeCode = new CodeType(); }
            return __TransportModeCode;
        }
        set
        {
            __TransportModeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the kind of transport means (truck, vessel, etc.) used for this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Transport Means Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTerm: Transport Means Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportMeansTypeCode
    {
        get
        {
            if (__TransportMeansTypeCode == null) { __TransportMeansTypeCode = new CodeType(); }
            return __TransportMeansTypeCode;
        }
        set
        {
            __TransportMeansTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the direction of transit in this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Transit_ Direction Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Transit
    /// <para />PropertyTerm: Direction Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransitDirectionCode
    {
        get
        {
            if (__TransitDirectionCode == null) { __TransitDirectionCode = new CodeType(); }
            return __TransitDirectionCode;
        }
        set
        {
            __TransitDirectionCode = value;
        }
    }

        
    /// <summary>
    /// An indicator that this stage takes place before the main carriage of the shipment (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Pre Carriage_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Pre Carriage
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>Truck delivery to wharf</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType PreCarriageIndicator
    {
        get
        {
            if (__PreCarriageIndicator == null) { __PreCarriageIndicator = new IndicatorType(); }
            return __PreCarriageIndicator;
        }
        set
        {
            __PreCarriageIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that this stage takes place after the main carriage of the shipment (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. On Carriage_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: On Carriage
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>Truck delivery from wharf</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType OnCarriageIndicator
    {
        get
        {
            if (__OnCarriageIndicator == null) { __OnCarriageIndicator = new IndicatorType(); }
            return __OnCarriageIndicator;
        }
        set
        {
            __OnCarriageIndicator = value;
        }
    }

        
    /// <summary>
    /// The estimated date of delivery in this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Estimated_ Delivery Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Estimated
    /// <para />PropertyTerm: Delivery Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType EstimatedDeliveryDate
    {
        get
        {
            if (__EstimatedDeliveryDate == null) { __EstimatedDeliveryDate = new DateType(); }
            return __EstimatedDeliveryDate;
        }
        set
        {
            __EstimatedDeliveryDate = value;
        }
    }

        
    /// <summary>
    /// The estimated time of delivery in this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Estimated_ Delivery Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Estimated
    /// <para />PropertyTerm: Delivery Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType EstimatedDeliveryTime
    {
        get
        {
            if (__EstimatedDeliveryTime == null) { __EstimatedDeliveryTime = new TimeType(); }
            return __EstimatedDeliveryTime;
        }
        set
        {
            __EstimatedDeliveryTime = value;
        }
    }

        
    /// <summary>
    /// The delivery date required by the buyer in this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Required_ Delivery Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Delivery Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType RequiredDeliveryDate
    {
        get
        {
            if (__RequiredDeliveryDate == null) { __RequiredDeliveryDate = new DateType(); }
            return __RequiredDeliveryDate;
        }
        set
        {
            __RequiredDeliveryDate = value;
        }
    }

        
    /// <summary>
    /// The delivery time required by the buyer in this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Required_ Delivery Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Delivery Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType RequiredDeliveryTime
    {
        get
        {
            if (__RequiredDeliveryTime == null) { __RequiredDeliveryTime = new TimeType(); }
            return __RequiredDeliveryTime;
        }
        set
        {
            __RequiredDeliveryTime = value;
        }
    }

        
    /// <summary>
    /// An identifier for the loading sequence (of consignments) associated with this shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Loading_ Sequence Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
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
    /// Identifies the successive loading sequence (of consignments) associated with a shipment stage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Successive_ Sequence Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Successive
    /// <para />PropertyTerm: Sequence Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SuccessiveSequenceID
    {
        get
        {
            if (__SuccessiveSequenceID == null) { __SuccessiveSequenceID = new IdentifierType(); }
            return __SuccessiveSequenceID;
        }
        set
        {
            __SuccessiveSequenceID = value;
        }
    }

        
    /// <summary>
    /// The total number of crew aboard a transport means.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Crew Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTerm: Crew Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType CrewQuantity
    {
        get
        {
            if (__CrewQuantity == null) { __CrewQuantity = new QuantityType(); }
            return __CrewQuantity;
        }
        set
        {
            __CrewQuantity = value;
        }
    }

        
    /// <summary>
    /// The total number of passengers aboard a transport means.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shipment Stage. Passenger Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTerm: Passenger Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType PassengerQuantity
    {
        get
        {
            if (__PassengerQuantity == null) { __PassengerQuantity = new QuantityType(); }
            return __PassengerQuantity;
        }
        set
        {
            __PassengerQuantity = value;
        }
    }

        
    /// <summary>
    /// The period during which this shipment stage actually took place.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Transit_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Transit
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType TransitPeriod
    {
        get
        {
            if (__TransitPeriod == null) { __TransitPeriod = new PeriodType(); }
            return __TransitPeriod;
        }
        set
        {
            __TransitPeriod = value;
        }
    }

        
    /// <summary>
    /// The means of transport used in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Transport Means
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTerm: Transport Means
    /// <para />AssociatedObjectClass: Transport Means
    /// <para />RepresentationTerm: Transport Means
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportMeansType TransportMeans
    {
        get
        {
            if (__TransportMeans == null) { __TransportMeans = new TransportMeansType(); }
            return __TransportMeans;
        }
        set
        {
            __TransportMeans = value;
        }
    }

        
    /// <summary>
    /// The location of loading for a shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Loading Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Loading Port
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType LoadingPortLocation
    {
        get
        {
            if (__LoadingPortLocation == null) { __LoadingPortLocation = new LocationType(); }
            return __LoadingPortLocation;
        }
        set
        {
            __LoadingPortLocation = value;
        }
    }

        
    /// <summary>
    /// The location of unloading for a shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Unloading Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Unloading Port
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType UnloadingPortLocation
    {
        get
        {
            if (__UnloadingPortLocation == null) { __UnloadingPortLocation = new LocationType(); }
            return __UnloadingPortLocation;
        }
        set
        {
            __UnloadingPortLocation = value;
        }
    }

        
    /// <summary>
    /// The location of transshipment relating to a shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Transship Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Transship Port
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType TransshipPortLocation
    {
        get
        {
            if (__TransshipPortLocation == null) { __TransshipPortLocation = new LocationType(); }
            return __TransshipPortLocation;
        }
        set
        {
            __TransshipPortLocation = value;
        }
    }

        
    /// <summary>
    /// The loading of goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Loading_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Loading
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType LoadingTransportEvent
    {
        get
        {
            if (__LoadingTransportEvent == null) { __LoadingTransportEvent = new TransportEventType(); }
            return __LoadingTransportEvent;
        }
        set
        {
            __LoadingTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The examination of shipments in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Examination_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Examination
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType ExaminationTransportEvent
    {
        get
        {
            if (__ExaminationTransportEvent == null) { __ExaminationTransportEvent = new TransportEventType(); }
            return __ExaminationTransportEvent;
        }
        set
        {
            __ExaminationTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The making available of shipments in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Availability_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Availability
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType AvailabilityTransportEvent
    {
        get
        {
            if (__AvailabilityTransportEvent == null) { __AvailabilityTransportEvent = new TransportEventType(); }
            return __AvailabilityTransportEvent;
        }
        set
        {
            __AvailabilityTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The export event associated with this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Exportation_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Exportation
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType ExportationTransportEvent
    {
        get
        {
            if (__ExportationTransportEvent == null) { __ExportationTransportEvent = new TransportEventType(); }
            return __ExportationTransportEvent;
        }
        set
        {
            __ExportationTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The discharge event associated with this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Discharge_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Discharge
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType DischargeTransportEvent
    {
        get
        {
            if (__DischargeTransportEvent == null) { __DischargeTransportEvent = new TransportEventType(); }
            return __DischargeTransportEvent;
        }
        set
        {
            __DischargeTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The warehousing event associated with this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Warehousing_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Warehousing
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType WarehousingTransportEvent
    {
        get
        {
            if (__WarehousingTransportEvent == null) { __WarehousingTransportEvent = new TransportEventType(); }
            return __WarehousingTransportEvent;
        }
        set
        {
            __WarehousingTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The receiver&apos;s takeover of the goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Takeover_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Takeover
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType TakeoverTransportEvent
    {
        get
        {
            if (__TakeoverTransportEvent == null) { __TakeoverTransportEvent = new TransportEventType(); }
            return __TakeoverTransportEvent;
        }
        set
        {
            __TakeoverTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The optional takeover of the goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Optional Takeover_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Optional Takeover
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType OptionalTakeoverTransportEvent
    {
        get
        {
            if (__OptionalTakeoverTransportEvent == null) { __OptionalTakeoverTransportEvent = new TransportEventType(); }
            return __OptionalTakeoverTransportEvent;
        }
        set
        {
            __OptionalTakeoverTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The dropping off of goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Dropoff_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Dropoff
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType DropoffTransportEvent
    {
        get
        {
            if (__DropoffTransportEvent == null) { __DropoffTransportEvent = new TransportEventType(); }
            return __DropoffTransportEvent;
        }
        set
        {
            __DropoffTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The pickup of goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Actual Pickup_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Actual Pickup
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType ActualPickupTransportEvent
    {
        get
        {
            if (__ActualPickupTransportEvent == null) { __ActualPickupTransportEvent = new TransportEventType(); }
            return __ActualPickupTransportEvent;
        }
        set
        {
            __ActualPickupTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The delivery of goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Delivery_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType DeliveryTransportEvent
    {
        get
        {
            if (__DeliveryTransportEvent == null) { __DeliveryTransportEvent = new TransportEventType(); }
            return __DeliveryTransportEvent;
        }
        set
        {
            __DeliveryTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The receipt of goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Receipt_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Receipt
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType ReceiptTransportEvent
    {
        get
        {
            if (__ReceiptTransportEvent == null) { __ReceiptTransportEvent = new TransportEventType(); }
            return __ReceiptTransportEvent;
        }
        set
        {
            __ReceiptTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The storage of goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Storage_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Storage
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType StorageTransportEvent
    {
        get
        {
            if (__StorageTransportEvent == null) { __StorageTransportEvent = new TransportEventType(); }
            return __StorageTransportEvent;
        }
        set
        {
            __StorageTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The acceptance of goods in this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Acceptance_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Acceptance
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType AcceptanceTransportEvent
    {
        get
        {
            if (__AcceptanceTransportEvent == null) { __AcceptanceTransportEvent = new TransportEventType(); }
            return __AcceptanceTransportEvent;
        }
        set
        {
            __AcceptanceTransportEvent = value;
        }
    }

        
    /// <summary>
    /// A terminal operator associated with this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Terminal Operator_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Terminal Operator
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType TerminalOperatorParty
    {
        get
        {
            if (__TerminalOperatorParty == null) { __TerminalOperatorParty = new PartyType(); }
            return __TerminalOperatorParty;
        }
        set
        {
            __TerminalOperatorParty = value;
        }
    }

        
    /// <summary>
    /// A customs agent associated with this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Customs Agent_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Customs Agent
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType CustomsAgentParty
    {
        get
        {
            if (__CustomsAgentParty == null) { __CustomsAgentParty = new PartyType(); }
            return __CustomsAgentParty;
        }
        set
        {
            __CustomsAgentParty = value;
        }
    }

        
    /// <summary>
    /// The estimated transit period of this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Estimated Transit_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Estimated Transit
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType EstimatedTransitPeriod
    {
        get
        {
            if (__EstimatedTransitPeriod == null) { __EstimatedTransitPeriod = new PeriodType(); }
            return __EstimatedTransitPeriod;
        }
        set
        {
            __EstimatedTransitPeriod = value;
        }
    }

        
    /// <summary>
    /// The location associated with a freight charge related to this shipment stage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Freight Charge_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Freight Charge
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType FreightChargeLocation
    {
        get
        {
            if (__FreightChargeLocation == null) { __FreightChargeLocation = new LocationType(); }
            return __FreightChargeLocation;
        }
        set
        {
            __FreightChargeLocation = value;
        }
    }

        
    /// <summary>
    /// The departure requested by the party requesting a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Requested Departure_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Requested Departure
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType RequestedDepartureTransportEvent
    {
        get
        {
            if (__RequestedDepartureTransportEvent == null) { __RequestedDepartureTransportEvent = new TransportEventType(); }
            return __RequestedDepartureTransportEvent;
        }
        set
        {
            __RequestedDepartureTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The arrival requested by the party requesting a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Requested Arrival_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Requested Arrival
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType RequestedArrivalTransportEvent
    {
        get
        {
            if (__RequestedArrivalTransportEvent == null) { __RequestedArrivalTransportEvent = new TransportEventType(); }
            return __RequestedArrivalTransportEvent;
        }
        set
        {
            __RequestedArrivalTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The departure planned by the party providing a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Planned Departure_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Planned Departure
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType PlannedDepartureTransportEvent
    {
        get
        {
            if (__PlannedDepartureTransportEvent == null) { __PlannedDepartureTransportEvent = new TransportEventType(); }
            return __PlannedDepartureTransportEvent;
        }
        set
        {
            __PlannedDepartureTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The arrival planned by the party providing a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Planned Arrival_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Planned Arrival
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType PlannedArrivalTransportEvent
    {
        get
        {
            if (__PlannedArrivalTransportEvent == null) { __PlannedArrivalTransportEvent = new TransportEventType(); }
            return __PlannedArrivalTransportEvent;
        }
        set
        {
            __PlannedArrivalTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The actual departure from a specific location during a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Actual Departure_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Actual Departure
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType ActualDepartureTransportEvent
    {
        get
        {
            if (__ActualDepartureTransportEvent == null) { __ActualDepartureTransportEvent = new TransportEventType(); }
            return __ActualDepartureTransportEvent;
        }
        set
        {
            __ActualDepartureTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The location of an actual waypoint during a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Actual Waypoint_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Actual Waypoint
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType ActualWaypointTransportEvent
    {
        get
        {
            if (__ActualWaypointTransportEvent == null) { __ActualWaypointTransportEvent = new TransportEventType(); }
            return __ActualWaypointTransportEvent;
        }
        set
        {
            __ActualWaypointTransportEvent = value;
        }
    }

        
    /// <summary>
    /// The actual arrival at a specific location during a transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Actual Arrival_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Actual Arrival
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType ActualArrivalTransportEvent
    {
        get
        {
            if (__ActualArrivalTransportEvent == null) { __ActualArrivalTransportEvent = new TransportEventType(); }
            return __ActualArrivalTransportEvent;
        }
        set
        {
            __ActualArrivalTransportEvent = value;
        }
    }

        
    /// <summary>
    /// Describes an estimated departure at a location during a transport service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Estimated Departure_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Estimated Departure
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType EstimatedDepartureTransportEvent
    {
        get
        {
            if (__EstimatedDepartureTransportEvent == null) { __EstimatedDepartureTransportEvent = new TransportEventType(); }
            return __EstimatedDepartureTransportEvent;
        }
        set
        {
            __EstimatedDepartureTransportEvent = value;
        }
    }

        
    /// <summary>
    /// Describes an estimated arrival at a location during a transport service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Estimated Arrival_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Estimated Arrival
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEventType EstimatedArrivalTransportEvent
    {
        get
        {
            if (__EstimatedArrivalTransportEvent == null) { __EstimatedArrivalTransportEvent = new TransportEventType(); }
            return __EstimatedArrivalTransportEvent;
        }
        set
        {
            __EstimatedArrivalTransportEvent = value;
        }
    }

        
    /// <summary>
    /// Describes a person being responsible for providing the required administrative reporting relating to a transport.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Reporting_ Person. Person
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Reporting
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PersonType ReportingPerson
    {
        get
        {
            if (__ReportingPerson == null) { __ReportingPerson = new PersonType(); }
            return __ReportingPerson;
        }
        set
        {
            __ReportingPerson = value;
        }
    }

        
    /// <summary>
    /// The person on board the vessel, accountable to the master, designated by the company as responsible for the security of the ship, including implementation and maintenance of the ship security plan and for the liaison with the company security officer and the port facility security officers.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Security Officer_ Person. Person
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Security Officer
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PersonType SecurityOfficerPerson
    {
        get
        {
            if (__SecurityOfficerPerson == null) { __SecurityOfficerPerson = new PersonType(); }
            return __SecurityOfficerPerson;
        }
        set
        {
            __SecurityOfficerPerson = value;
        }
    }

        
    /// <summary>
    /// The person responsible for the ship&apos;s safe and efficient operation, including cargo operations, navigation, crew management and for ensuring that the vessel complies with local and international laws, as well as company and flag state policies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Master_ Person. Person
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Master
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PersonType MasterPerson
    {
        get
        {
            if (__MasterPerson == null) { __MasterPerson = new PersonType(); }
            return __MasterPerson;
        }
        set
        {
            __MasterPerson = value;
        }
    }

        
    /// <summary>
    /// The person responsible for the health of the people aboard a ship at sea.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shipment Stage. Ships Surgeon_ Person. Person
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shipment Stage
    /// <para />PropertyTermQualifier: Ships Surgeon
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PersonType ShipsSurgeonPerson
    {
        get
        {
            if (__ShipsSurgeonPerson == null) { __ShipsSurgeonPerson = new PersonType(); }
            return __ShipsSurgeonPerson;
        }
        set
        {
            __ShipsSurgeonPerson = value;
        }
    }

}