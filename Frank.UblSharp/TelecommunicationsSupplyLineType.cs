/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TelecommunicationsSupplyLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TelecommunicationsSupplyLineType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PhoneNumberType PhoneNumber { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExchangeRate")]
    public ExchangeRateType[] ExchangeRate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
    public TaxTotalType[] TaxTotal { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsService")]
    public TelecommunicationsServiceType[] TelecommunicationsService { get; set; }
}