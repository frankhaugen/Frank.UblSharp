/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TransportationServiceType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportServiceCodeType TransportServiceCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffClassCodeType TariffClassCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriorityType Priority { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreightRateClassCodeType FreightRateClassCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportationServiceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportationServiceDescriptionType[] TransportationServiceDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportationServiceDetailsURIType TransportationServiceDetailsURI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NominationDateType NominationDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NominationTimeType NominationTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumericType SequenceNumeric { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
    public TransportEquipmentType[] TransportEquipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SupportedTransportEquipment")]
    public TransportEquipmentType[] SupportedTransportEquipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("UnsupportedTransportEquipment")]
    public TransportEquipmentType[] UnsupportedTransportEquipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
    public CommodityClassificationType[] CommodityClassification { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SupportedCommodityClassification")]
    public CommodityClassificationType[] SupportedCommodityClassification { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("UnsupportedCommodityClassification")]
    public CommodityClassificationType[] UnsupportedCommodityClassification { get; set; }

    /// <remarks/>
    public DimensionType TotalCapacityDimension { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
    public ShipmentStageType[] ShipmentStage { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
    public TransportEventType[] TransportEvent { get; set; }

    /// <remarks/>
    public PartyType ResponsibleTransportServiceProviderParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
    public EnvironmentalEmissionType[] EnvironmentalEmission { get; set; }

    /// <remarks/>
    public PeriodType EstimatedDurationPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ScheduledServiceFrequency")]
    public ServiceFrequencyType[] ScheduledServiceFrequency { get; set; }
}