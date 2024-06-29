/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class DespatchType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestedDespatchDateType RequestedDespatchDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestedDespatchTimeType RequestedDespatchTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDespatchDateType EstimatedDespatchDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDespatchTimeType EstimatedDespatchTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDespatchDateType ActualDespatchDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDespatchTimeType ActualDespatchTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GuaranteedDespatchDateType GuaranteedDespatchDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GuaranteedDespatchTimeType GuaranteedDespatchTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReleaseIDType ReleaseID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionsType[] Instructions { get; set; }

    /// <remarks/>
    public AddressType DespatchAddress { get; set; }

    /// <remarks/>
    public LocationType1 DespatchLocation { get; set; }

    /// <remarks/>
    public PartyType DespatchParty { get; set; }

    /// <remarks/>
    public PartyType CarrierParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
    public PartyType[] NotifyParty { get; set; }

    /// <remarks/>
    public ContactType Contact { get; set; }

    /// <remarks/>
    public PeriodType EstimatedDespatchPeriod { get; set; }

    /// <remarks/>
    public PeriodType RequestedDespatchPeriod { get; set; }
}