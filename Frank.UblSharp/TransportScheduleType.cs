/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportSchedule", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TransportScheduleType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumericType SequenceNumeric { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceDateType ReferenceDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceTimeType ReferenceTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReliabilityPercentType ReliabilityPercent { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks { get; set; }

    /// <remarks/>
    public LocationType1 StatusLocation { get; set; }

    /// <remarks/>
    public TransportEventType ActualArrivalTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType ActualDepartureTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType EstimatedDepartureTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType EstimatedArrivalTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType PlannedDepartureTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType PlannedArrivalTransportEvent { get; set; }
}