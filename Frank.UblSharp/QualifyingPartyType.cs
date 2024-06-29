/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalQualifyingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class QualifyingPartyType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ParticipationPercentType ParticipationPercent { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PersonalSituationType[] PersonalSituation { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OperatingYearsQuantityType OperatingYearsQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EmployeeQuantityType EmployeeQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BusinessClassificationEvidenceIDType BusinessClassificationEvidenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BusinessIdentityEvidenceIDType BusinessIdentityEvidenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TendererRoleCodeType TendererRoleCode { get; set; }

    /// <remarks/>
    public ClassificationSchemeType BusinessClassificationScheme { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TechnicalCapability")]
    public CapabilityType[] TechnicalCapability { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FinancialCapability")]
    public CapabilityType[] FinancialCapability { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CompletedTask")]
    public CompletedTaskType[] CompletedTask { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Declaration")]
    public DeclarationType[] Declaration { get; set; }

    /// <remarks/>
    public PartyType Party { get; set; }

    /// <remarks/>
    public EconomicOperatorRoleType EconomicOperatorRole { get; set; }
}