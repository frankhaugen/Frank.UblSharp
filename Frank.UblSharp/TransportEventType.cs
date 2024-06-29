/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AcceptanceTransportEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TransportEventType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IdentificationIDType IdentificationID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OccurrenceDateType OccurrenceDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OccurrenceTimeType OccurrenceTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportEventTypeCodeType TransportEventTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CompletionIndicatorType CompletionIndicator { get; set; }

    /// <remarks/>
    public ShipmentType ReportedShipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CurrentStatus")]
    public StatusType[] CurrentStatus { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Contact")]
    public ContactType[] Contact { get; set; }

    /// <remarks/>
    public LocationType1 Location { get; set; }

    /// <remarks/>
    public SignatureType Signature { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Period")]
    public PeriodType[] Period { get; set; }
}