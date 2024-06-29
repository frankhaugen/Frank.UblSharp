/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AwardingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class AwardingTermsType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WeightingAlgorithmCodeType WeightingAlgorithmCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TechnicalCommitteeDescriptionType[] TechnicalCommitteeDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LowTendersDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LowTendersDescriptionType[] LowTendersDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrizeIndicatorType PrizeIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PrizeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrizeDescriptionType[] PrizeDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentDescriptionType[] PaymentDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FollowupContractIndicatorType FollowupContractIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BindingOnBuyerIndicatorType BindingOnBuyerIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AwardingCriterion")]
    public AwardingCriterionType[] AwardingCriterion { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteePerson")]
    public PersonType[] TechnicalCommitteePerson { get; set; }
}