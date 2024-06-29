/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalInformationParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PartyType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarkCareIndicatorType MarkCareIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarkAttentionIndicatorType MarkAttentionIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WebsiteURIType WebsiteURI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LogoReferenceIDType LogoReferenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EndpointIDType EndpointID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IndustryClassificationCodeType IndustryClassificationCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
    public PartyIdentificationType[] PartyIdentification { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PartyName")]
    public PartyNameType[] PartyName { get; set; }

    /// <remarks/>
    public LanguageType Language { get; set; }

    /// <remarks/>
    public AddressType PostalAddress { get; set; }

    /// <remarks/>
    public LocationType1 PhysicalLocation { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PartyTaxScheme")]
    public PartyTaxSchemeType[] PartyTaxScheme { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity")]
    public PartyLegalEntityType[] PartyLegalEntity { get; set; }

    /// <remarks/>
    public ContactType Contact { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Person")]
    public PersonType[] Person { get; set; }

    /// <remarks/>
    public PartyType AgentParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ServiceProviderParty")]
    public ServiceProviderPartyType[] ServiceProviderParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PowerOfAttorney")]
    public PowerOfAttorneyType[] PowerOfAttorney { get; set; }

    /// <remarks/>
    public FinancialAccountType FinancialAccount { get; set; }
}