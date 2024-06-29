/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ApplicableTransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TransportMeansType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public JourneyIDType JourneyID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationNationalityIDType RegistrationNationalityID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationNationalityType[] RegistrationNationality { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DirectionCodeType DirectionCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportMeansTypeCodeType TransportMeansTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TradeServiceCodeType TradeServiceCode { get; set; }

    /// <remarks/>
    public StowageType Stowage { get; set; }

    /// <remarks/>
    public AirTransportType AirTransport { get; set; }

    /// <remarks/>
    public RoadTransportType RoadTransport { get; set; }

    /// <remarks/>
    public RailTransportType RailTransport { get; set; }

    /// <remarks/>
    public MaritimeTransportType MaritimeTransport { get; set; }

    /// <remarks/>
    public PartyType OwnerParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
    public DimensionType[] MeasurementDimension { get; set; }
}