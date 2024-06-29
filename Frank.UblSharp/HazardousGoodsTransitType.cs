/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class HazardousGoodsTransitType
{
    private HazardousRegulationCodeType hazardousRegulationCodeField;
    private InhalationToxicityZoneCodeType inhalationToxicityZoneCodeField;
    private TransportAuthorizationCodeType transportAuthorizationCodeField;
    private TemperatureType maximumTemperatureField;
    private TemperatureType minimumTemperatureField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportEmergencyCardCodeType TransportEmergencyCardCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackingCriteriaCodeType PackingCriteriaCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRegulationCodeType HazardousRegulationCode
    {
        get
        {
            return this.hazardousRegulationCodeField;
        }

        set
        {
            this.hazardousRegulationCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InhalationToxicityZoneCodeType InhalationToxicityZoneCode
    {
        get
        {
            return this.inhalationToxicityZoneCodeField;
        }

        set
        {
            this.inhalationToxicityZoneCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportAuthorizationCodeType TransportAuthorizationCode
    {
        get
        {
            return this.transportAuthorizationCodeField;
        }

        set
        {
            this.transportAuthorizationCodeField = value;
        }
    }

    /// <remarks/>
    public TemperatureType MaximumTemperature
    {
        get
        {
            return this.maximumTemperatureField;
        }

        set
        {
            this.maximumTemperatureField = value;
        }
    }

    /// <remarks/>
    public TemperatureType MinimumTemperature
    {
        get
        {
            return this.minimumTemperatureField;
        }

        set
        {
            this.minimumTemperatureField = value;
        }
    }
}