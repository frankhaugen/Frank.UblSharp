/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TenderingTermsType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AwardingMethodTypeCodeType AwardingMethodTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceEvaluationCodeType PriceEvaluationCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumVariantQuantityType MaximumVariantQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VariantConstraintIndicatorType VariantConstraintIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AcceptedVariantsDescriptionType[] AcceptedVariantsDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PriceRevisionFormulaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceRevisionFormulaDescriptionType[] PriceRevisionFormulaDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FundingProgramCodeType FundingProgramCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FundingProgram", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FundingProgramType[] FundingProgram { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumAdvertisementAmountType MaximumAdvertisementAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentFrequencyCodeType PaymentFrequencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EconomicOperatorRegistryURIType EconomicOperatorRegistryURI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredCurriculaIndicatorType RequiredCurriculaIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OtherConditionsIndicatorType OtherConditionsIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalConditionsType[] AdditionalConditions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestSecurityClearanceDateType LatestSecurityClearanceDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentationFeeAmountType DocumentationFeeAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PenaltyClause")]
    public ClauseType[] PenaltyClause { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequiredFinancialGuarantee")]
    public FinancialGuaranteeType[] RequiredFinancialGuarantee { get; set; }

    /// <remarks/>
    public DocumentReferenceType ProcurementLegislationDocumentReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType FiscalLegislationDocumentReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType EnvironmentalLegislationDocumentReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType EmploymentLegislationDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractualDocumentReference")]
    public DocumentReferenceType[] ContractualDocumentReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType CallForTendersDocumentReference { get; set; }

    /// <remarks/>
    public PeriodType WarrantyValidityPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
    public PaymentTermsType[] PaymentTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TendererQualificationRequest")]
    public TendererQualificationRequestType[] TendererQualificationRequest { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowedSubcontractTerms")]
    public SubcontractTermsType[] AllowedSubcontractTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TenderPreparation")]
    public TenderPreparationType[] TenderPreparation { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractExecutionRequirement")]
    public ContractExecutionRequirementType[] ContractExecutionRequirement { get; set; }

    /// <remarks/>
    public AwardingTermsType AwardingTerms { get; set; }

    /// <remarks/>
    public PartyType AdditionalInformationParty { get; set; }

    /// <remarks/>
    public PartyType DocumentProviderParty { get; set; }

    /// <remarks/>
    public PartyType TenderRecipientParty { get; set; }

    /// <remarks/>
    public PartyType ContractResponsibleParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TenderEvaluationParty")]
    public PartyType[] TenderEvaluationParty { get; set; }

    /// <remarks/>
    public PeriodType TenderValidityPeriod { get; set; }

    /// <remarks/>
    public PeriodType ContractAcceptancePeriod { get; set; }

    /// <remarks/>
    public AppealTermsType AppealTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Language")]
    public LanguageType[] Language { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BudgetAccountLine")]
    public BudgetAccountLineType[] BudgetAccountLine { get; set; }

    /// <remarks/>
    public DocumentReferenceType ReplacedNoticeDocumentReference { get; set; }
}