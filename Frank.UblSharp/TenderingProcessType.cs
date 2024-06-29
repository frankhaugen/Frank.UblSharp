/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TenderingProcessType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OriginalContractingSystemIDType OriginalContractingSystemID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NegotiationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NegotiationDescriptionType[] NegotiationDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcedureCodeType ProcedureCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UrgencyCodeType UrgencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpenseCodeType ExpenseCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PartPresentationCodeType PartPresentationCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractingSystemCodeType ContractingSystemCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubmissionMethodCodeType SubmissionMethodCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CandidateReductionConstraintIndicatorType CandidateReductionConstraintIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GovernmentAgreementConstraintIndicatorType GovernmentAgreementConstraintIndicator { get; set; }

    /// <remarks/>
    public PeriodType DocumentAvailabilityPeriod { get; set; }

    /// <remarks/>
    public PeriodType TenderSubmissionDeadlinePeriod { get; set; }

    /// <remarks/>
    public PeriodType InvitationSubmissionPeriod { get; set; }

    /// <remarks/>
    public PeriodType ParticipationRequestReceptionPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NoticeDocumentReference")]
    public DocumentReferenceType[] NoticeDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference")]
    public DocumentReferenceType[] AdditionalDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ProcessJustification")]
    public ProcessJustificationType[] ProcessJustification { get; set; }

    /// <remarks/>
    public EconomicOperatorShortListType EconomicOperatorShortList { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OpenTenderEvent")]
    public EventType[] OpenTenderEvent { get; set; }

    /// <remarks/>
    public AuctionTermsType AuctionTerms { get; set; }

    /// <remarks/>
    public FrameworkAgreementType FrameworkAgreement { get; set; }
}