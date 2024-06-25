using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// Describes the location and schedule relating to a transport means.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transport Schedule. Details
/// <para />ObjectClass: Transport Schedule
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TransportSchedule", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportSchedule", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportScheduleType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NumericType @__SequenceNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__ReferenceDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__ReferenceTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReliabilityPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public PercentType @__ReliabilityPercent;
        
    private System.Collections.Generic.List<TextType> _remarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
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
    [System.Xml.Serialization.XmlElementAttribute("StatusLocation", Order=5)]
    public LocationType @__StatusLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualArrivalTransportEvent", Order=6)]
    public TransportEventType @__ActualArrivalTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualDepartureTransportEvent", Order=7)]
    public TransportEventType @__ActualDepartureTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDepartureTransportEvent", Order=8)]
    public TransportEventType @__EstimatedDepartureTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedArrivalTransportEvent", Order=9)]
    public TransportEventType @__EstimatedArrivalTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedDepartureTransportEvent", Order=10)]
    public TransportEventType @__PlannedDepartureTransportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedArrivalTransportEvent", Order=11)]
    public TransportEventType @__PlannedArrivalTransportEvent;
        
    /// <summary>
    /// Remarks related to the transport schedule status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Schedule. Remarks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Schedule
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
    /// A number indicating the order of this status in the sequence in which statuses are to be presented.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Schedule. Sequence. Numeric
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Transport Schedule
    /// <para />PropertyTerm: Sequence
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType SequenceNumeric
    {
        get
        {
            if (__SequenceNumeric == null) { __SequenceNumeric = new NumericType(); }
            return __SequenceNumeric;
        }
        set
        {
            __SequenceNumeric = value;
        }
    }

        
    /// <summary>
    /// The reference date for the transport schedule status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Schedule. Reference Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
    /// <para />PropertyTerm: Reference Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ReferenceDate
    {
        get
        {
            if (__ReferenceDate == null) { __ReferenceDate = new DateType(); }
            return __ReferenceDate;
        }
        set
        {
            __ReferenceDate = value;
        }
    }

        
    /// <summary>
    /// The reference time for the transport schedule status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Schedule. Reference Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
    /// <para />PropertyTerm: Reference Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ReferenceTime
    {
        get
        {
            if (__ReferenceTime == null) { __ReferenceTime = new TimeType(); }
            return __ReferenceTime;
        }
        set
        {
            __ReferenceTime = value;
        }
    }

        
    /// <summary>
    /// The reliability of the transport schedule status, expressed as a percentage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Schedule. Reliability Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
    /// <para />PropertyTerm: Reliability Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType ReliabilityPercent
    {
        get
        {
            if (__ReliabilityPercent == null) { __ReliabilityPercent = new PercentType(); }
            return __ReliabilityPercent;
        }
        set
        {
            __ReliabilityPercent = value;
        }
    }

        
    /// <summary>
    /// The location for which status is reported.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Schedule. Status_ Location. Location
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Transport Schedule
    /// <para />PropertyTermQualifier: Status
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType StatusLocation
    {
        get
        {
            if (__StatusLocation == null) { __StatusLocation = new LocationType(); }
            return __StatusLocation;
        }
        set
        {
            __StatusLocation = value;
        }
    }

        
    /// <summary>
    /// The actual arrival at a location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Schedule. Actual Arrival_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
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
    /// The actual departure from a location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Schedule. Actual Departure_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
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
    /// An estimated departure from a specified location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Schedule. Estimated Departure_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
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
    /// An estimated arrival at a specified location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Schedule. Estimated Arrival_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
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
    /// The planned departure from a specified location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Schedule. Planned Departure_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
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
    /// The planned arrival at a specified location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Schedule. Planned Arrival_ Transport Event. Transport Event
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Schedule
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

}