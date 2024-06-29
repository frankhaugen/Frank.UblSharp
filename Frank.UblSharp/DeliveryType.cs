/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractualDelivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class DeliveryType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumQuantityType MinimumQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumQuantityType MaximumQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDeliveryDateType ActualDeliveryDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDeliveryTimeType ActualDeliveryTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestDeliveryDateType LatestDeliveryDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestDeliveryTimeType LatestDeliveryTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReleaseIDType ReleaseID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TrackingIDType TrackingID { get; set; }

    /// <remarks/>
    public AddressType DeliveryAddress { get; set; }

    /// <remarks/>
    public LocationType1 DeliveryLocation { get; set; }

    /// <remarks/>
    public LocationType1 AlternativeDeliveryLocation { get; set; }

    /// <remarks/>
    public PeriodType RequestedDeliveryPeriod { get; set; }

    /// <remarks/>
    public PeriodType PromisedDeliveryPeriod { get; set; }

    /// <remarks/>
    public PeriodType EstimatedDeliveryPeriod { get; set; }

    /// <remarks/>
    public PartyType CarrierParty { get; set; }

    /// <remarks/>
    public PartyType DeliveryParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
    public PartyType[] NotifyParty { get; set; }

    /// <remarks/>
    public DespatchType Despatch { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
    public DeliveryTermsType[] DeliveryTerms { get; set; }

    /// <remarks/>
    public DeliveryUnitType MinimumDeliveryUnit { get; set; }

    /// <remarks/>
    public DeliveryUnitType MaximumDeliveryUnit { get; set; }

    /// <remarks/>
    public ShipmentType Shipment { get; set; }
}