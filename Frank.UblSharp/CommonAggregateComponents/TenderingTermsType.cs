using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe tendering terms for a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tendering Terms. Details
/// <para />ObjectClass: Tendering Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TenderingTermsType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardingMethodTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__AwardingMethodTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceEvaluationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__PriceEvaluationCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumVariantQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__MaximumVariantQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VariantConstraintIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IndicatorType @__VariantConstraintIndicator;
        
    private System.Collections.Generic.List<TextType> _acceptedVariantsDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__AcceptedVariantsDescription
    {
        get
        {
            return _acceptedVariantsDescription?.ToArray();
        }
        set
        {
            _acceptedVariantsDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _priceRevisionFormulaDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceRevisionFormulaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__PriceRevisionFormulaDescription
    {
        get
        {
            return _priceRevisionFormulaDescription?.ToArray();
        }
        set
        {
            _priceRevisionFormulaDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FundingProgramCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__FundingProgramCode;
        
    private System.Collections.Generic.List<TextType> _fundingProgram;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FundingProgram", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType[] @__FundingProgram
    {
        get
        {
            return _fundingProgram?.ToArray();
        }
        set
        {
            _fundingProgram = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumAdvertisementAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__MaximumAdvertisementAmount;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public TextType[] @__Note
    {
        get
        {
            return _note?.ToArray();
        }
        set
        {
            _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFrequencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public CodeType @__PaymentFrequencyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EconomicOperatorRegistryURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public IdentifierType @__EconomicOperatorRegistryURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredCurriculaIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public IndicatorType @__RequiredCurriculaIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OtherConditionsIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public IndicatorType @__OtherConditionsIndicator;
        
    private System.Collections.Generic.List<TextType> _additionalConditions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public TextType[] @__AdditionalConditions
    {
        get
        {
            return _additionalConditions?.ToArray();
        }
        set
        {
            _additionalConditions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestSecurityClearanceDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public DateType @__LatestSecurityClearanceDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentationFeeAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public AmountType @__DocumentationFeeAmount;
        
    private System.Collections.Generic.List<ClauseType> _penaltyClause;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PenaltyClause", Order=17)]
    public ClauseType[] @__PenaltyClause
    {
        get
        {
            return _penaltyClause?.ToArray();
        }
        set
        {
            _penaltyClause = value == null ? null : new System.Collections.Generic.List<ClauseType>(value);
        }
    }
        
    private System.Collections.Generic.List<FinancialGuaranteeType> _requiredFinancialGuarantee;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredFinancialGuarantee", Order=18)]
    public FinancialGuaranteeType[] @__RequiredFinancialGuarantee
    {
        get
        {
            return _requiredFinancialGuarantee?.ToArray();
        }
        set
        {
            _requiredFinancialGuarantee = value == null ? null : new System.Collections.Generic.List<FinancialGuaranteeType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcurementLegislationDocumentReference", Order=19)]
    public DocumentReferenceType @__ProcurementLegislationDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FiscalLegislationDocumentReference", Order=20)]
    public DocumentReferenceType @__FiscalLegislationDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EnvironmentalLegislationDocumentReference", Order=21)]
    public DocumentReferenceType @__EnvironmentalLegislationDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmploymentLegislationDocumentReference", Order=22)]
    public DocumentReferenceType @__EmploymentLegislationDocumentReference;
        
    private System.Collections.Generic.List<DocumentReferenceType> _contractualDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractualDocumentReference", Order=23)]
    public DocumentReferenceType[] @__ContractualDocumentReference
    {
        get
        {
            return _contractualDocumentReference?.ToArray();
        }
        set
        {
            _contractualDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallForTendersDocumentReference", Order=24)]
    public DocumentReferenceType @__CallForTendersDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyValidityPeriod", Order=25)]
    public PeriodType @__WarrantyValidityPeriod;
        
    private System.Collections.Generic.List<PaymentTermsType> _paymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Order=26)]
    public PaymentTermsType[] @__PaymentTerms
    {
        get
        {
            return _paymentTerms?.ToArray();
        }
        set
        {
            _paymentTerms = value == null ? null : new System.Collections.Generic.List<PaymentTermsType>(value);
        }
    }
        
    private System.Collections.Generic.List<TendererQualificationRequestType> _tendererQualificationRequest;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TendererQualificationRequest", Order=27)]
    public TendererQualificationRequestType[] @__TendererQualificationRequest
    {
        get
        {
            return _tendererQualificationRequest?.ToArray();
        }
        set
        {
            _tendererQualificationRequest = value == null ? null : new System.Collections.Generic.List<TendererQualificationRequestType>(value);
        }
    }
        
    private System.Collections.Generic.List<SubcontractTermsType> _allowedSubcontractTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowedSubcontractTerms", Order=28)]
    public SubcontractTermsType[] @__AllowedSubcontractTerms
    {
        get
        {
            return _allowedSubcontractTerms?.ToArray();
        }
        set
        {
            _allowedSubcontractTerms = value == null ? null : new System.Collections.Generic.List<SubcontractTermsType>(value);
        }
    }
        
    private System.Collections.Generic.List<TenderPreparationType> _tenderPreparation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderPreparation", Order=29)]
    public TenderPreparationType[] @__TenderPreparation
    {
        get
        {
            return _tenderPreparation?.ToArray();
        }
        set
        {
            _tenderPreparation = value == null ? null : new System.Collections.Generic.List<TenderPreparationType>(value);
        }
    }
        
    private System.Collections.Generic.List<ContractExecutionRequirementType> _contractExecutionRequirement;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractExecutionRequirement", Order=30)]
    public ContractExecutionRequirementType[] @__ContractExecutionRequirement
    {
        get
        {
            return _contractExecutionRequirement?.ToArray();
        }
        set
        {
            _contractExecutionRequirement = value == null ? null : new System.Collections.Generic.List<ContractExecutionRequirementType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardingTerms", Order=31)]
    public AwardingTermsType @__AwardingTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalInformationParty", Order=32)]
    public PartyType @__AdditionalInformationParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentProviderParty", Order=33)]
    public PartyType @__DocumentProviderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderRecipientParty", Order=34)]
    public PartyType @__TenderRecipientParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractResponsibleParty", Order=35)]
    public PartyType @__ContractResponsibleParty;
        
    private System.Collections.Generic.List<PartyType> _tenderEvaluationParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderEvaluationParty", Order=36)]
    public PartyType[] @__TenderEvaluationParty
    {
        get
        {
            return _tenderEvaluationParty?.ToArray();
        }
        set
        {
            _tenderEvaluationParty = value == null ? null : new System.Collections.Generic.List<PartyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderValidityPeriod", Order=37)]
    public PeriodType @__TenderValidityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractAcceptancePeriod", Order=38)]
    public PeriodType @__ContractAcceptancePeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AppealTerms", Order=39)]
    public AppealTermsType @__AppealTerms;
        
    private System.Collections.Generic.List<LanguageType> _language;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Language", Order=40)]
    public LanguageType[] @__Language
    {
        get
        {
            return _language?.ToArray();
        }
        set
        {
            _language = value == null ? null : new System.Collections.Generic.List<LanguageType>(value);
        }
    }
        
    private System.Collections.Generic.List<BudgetAccountLineType> _budgetAccountLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BudgetAccountLine", Order=41)]
    public BudgetAccountLineType[] @__BudgetAccountLine
    {
        get
        {
            return _budgetAccountLine?.ToArray();
        }
        set
        {
            _budgetAccountLine = value == null ? null : new System.Collections.Generic.List<BudgetAccountLineType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReplacedNoticeDocumentReference", Order=42)]
    public DocumentReferenceType @__ReplacedNoticeDocumentReference;
        
    /// <summary>
    /// Text specifying the things for which variants are accepted.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Accepted Variants_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Accepted Variants
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> AcceptedVariantsDescription
    {
        get { return _acceptedVariantsDescription ?? (_acceptedVariantsDescription = new System.Collections.Generic.List<TextType>()); }
        set { _acceptedVariantsDescription = value; }
    }

        
    /// <summary>
    /// Text describing the formula for price revision.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Price Revision_ Formula Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Price Revision
    /// <para />PropertyTerm: Formula Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> PriceRevisionFormulaDescription
    {
        get { return _priceRevisionFormulaDescription ?? (_priceRevisionFormulaDescription = new System.Collections.Generic.List<TextType>()); }
        set { _priceRevisionFormulaDescription = value; }
    }

        
    /// <summary>
    /// The program that funds the tendering process (e.g., EU 6th Framework Program) expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Funding_ Program. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Funding
    /// <para />PropertyTerm: Program
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> FundingProgram
    {
        get { return _fundingProgram ?? (_fundingProgram = new System.Collections.Generic.List<TextType>()); }
        set { _fundingProgram = value; }
    }

        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// Other existing conditions.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Additional_ Conditions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Conditions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> AdditionalConditions
    {
        get { return _additionalConditions ?? (_additionalConditions = new System.Collections.Generic.List<TextType>()); }
        set { _additionalConditions = value; }
    }

        
    /// <summary>
    /// The penalty clauses
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Penalty_ Clause. Clause
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Penalty
    /// <para />PropertyTerm: Clause
    /// <para />AssociatedObjectClass: Clause
    /// <para />RepresentationTerm: Clause
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ClauseType> PenaltyClause
    {
        get { return _penaltyClause ?? (_penaltyClause = new System.Collections.Generic.List<ClauseType>()); }
        set { _penaltyClause = value; }
    }

        
    /// <summary>
    /// A financial guarantee of a tenderer or bid submitter&apos;s actual entry into a contract in the event that it is the successful bidder.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Required_ Financial Guarantee. Financial Guarantee
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Financial Guarantee
    /// <para />AssociatedObjectClass: Financial Guarantee
    /// <para />RepresentationTerm: Financial Guarantee
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<FinancialGuaranteeType> RequiredFinancialGuarantee
    {
        get { return _requiredFinancialGuarantee ?? (_requiredFinancialGuarantee = new System.Collections.Generic.List<FinancialGuaranteeType>()); }
        set { _requiredFinancialGuarantee = value; }
    }

        
    /// <summary>
    /// A reference to a document that will become part of the awarded contract.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Contractual_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Contractual
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> ContractualDocumentReference
    {
        get { return _contractualDocumentReference ?? (_contractualDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _contractualDocumentReference = value; }
    }

        
    /// <summary>
    /// A specification of payment terms associated with the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Payment Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PaymentTermsType> PaymentTerms
    {
        get { return _paymentTerms ?? (_paymentTerms = new System.Collections.Generic.List<PaymentTermsType>()); }
        set { _paymentTerms = value; }
    }

        
    /// <summary>
    /// Required set of qualifications for a tenderer in this tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Tenderer Qualification Request
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Tenderer Qualification Request
    /// <para />AssociatedObjectClass: Tenderer Qualification Request
    /// <para />RepresentationTerm: Tenderer Qualification Request
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TendererQualificationRequestType> TendererQualificationRequest
    {
        get { return _tendererQualificationRequest ?? (_tendererQualificationRequest = new System.Collections.Generic.List<TendererQualificationRequestType>()); }
        set { _tendererQualificationRequest = value; }
    }

        
    /// <summary>
    /// Subcontract terms for the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Allowed_ Subcontract Terms. Subcontract Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Allowed
    /// <para />PropertyTerm: Subcontract Terms
    /// <para />AssociatedObjectClass: Subcontract Terms
    /// <para />RepresentationTerm: Subcontract Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<SubcontractTermsType> AllowedSubcontractTerms
    {
        get { return _allowedSubcontractTerms ?? (_allowedSubcontractTerms = new System.Collections.Generic.List<SubcontractTermsType>()); }
        set { _allowedSubcontractTerms = value; }
    }

        
    /// <summary>
    /// Directions for preparing a tender for the+D2057 tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Tender Preparation
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Tender Preparation
    /// <para />AssociatedObjectClass: Tender Preparation
    /// <para />RepresentationTerm: Tender Preparation
    /// </summary>
    /// <example>Curricula required, Experience required, ....</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TenderPreparationType> TenderPreparation
    {
        get { return _tenderPreparation ?? (_tenderPreparation = new System.Collections.Generic.List<TenderPreparationType>()); }
        set { _tenderPreparation = value; }
    }

        
    /// <summary>
    /// A requirement relating to execution of the contract that will be awarded as a result of the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Contract Execution Requirement
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Contract Execution Requirement
    /// <para />AssociatedObjectClass: Contract Execution Requirement
    /// <para />RepresentationTerm: Contract Execution Requirement
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ContractExecutionRequirementType> ContractExecutionRequirement
    {
        get { return _contractExecutionRequirement ?? (_contractExecutionRequirement = new System.Collections.Generic.List<ContractExecutionRequirementType>()); }
        set { _contractExecutionRequirement = value; }
    }

        
    /// <summary>
    /// A party in the contracting authority responsible for evaluating tenders received.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Tender Evaluation_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Tender Evaluation
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyType> TenderEvaluationParty
    {
        get { return _tenderEvaluationParty ?? (_tenderEvaluationParty = new System.Collections.Generic.List<PartyType>()); }
        set { _tenderEvaluationParty = value; }
    }

        
    /// <summary>
    /// One of the default languages specified for the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Language
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Language
    /// <para />AssociatedObjectClass: Language
    /// <para />RepresentationTerm: Language
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LanguageType> Language
    {
        get { return _language ?? (_language = new System.Collections.Generic.List<LanguageType>()); }
        set { _language = value; }
    }

        
    /// <summary>
    /// A budget account line associated with the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Budget Account Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Budget Account Line
    /// <para />AssociatedObjectClass: Budget Account Line
    /// <para />RepresentationTerm: Budget Account Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<BudgetAccountLineType> BudgetAccountLine
    {
        get { return _budgetAccountLine ?? (_budgetAccountLine = new System.Collections.Generic.List<BudgetAccountLineType>()); }
        set { _budgetAccountLine = value; }
    }

        
    /// <summary>
    /// A code signifying the awarding method in a tendering process (e.g., a method favoring the tender with the lowest price or the tender that is most economically advantageous).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Awarding Method Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Awarding Method Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Price, Multiple criteria</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AwardingMethodTypeCode
    {
        get
        {
            if (__AwardingMethodTypeCode == null) { __AwardingMethodTypeCode = new CodeType(); }
            return __AwardingMethodTypeCode;
        }
        set
        {
            __AwardingMethodTypeCode = value;
        }
    }

        
    /// <summary>
    /// Textual description of the legal form required for potential tenderers.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Price Evaluation Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Price Evaluation Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Unit prices, global price</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PriceEvaluationCode
    {
        get
        {
            if (__PriceEvaluationCode == null) { __PriceEvaluationCode = new CodeType(); }
            return __PriceEvaluationCode;
        }
        set
        {
            __PriceEvaluationCode = value;
        }
    }

        
    /// <summary>
    /// Maximum number of variants the tenderer is allowed to present for this tendering project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Maximum Variant_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Maximum Variant
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumVariantQuantity
    {
        get
        {
            if (__MaximumVariantQuantity == null) { __MaximumVariantQuantity = new QuantityType(); }
            return __MaximumVariantQuantity;
        }
        set
        {
            __MaximumVariantQuantity = value;
        }
    }

        
    /// <summary>
    /// An indicator that variants are allowed and unconstrained in number (true) or not allowed (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Variant_ Constraint. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Variant
    /// <para />PropertyTerm: Constraint
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType VariantConstraintIndicator
    {
        get
        {
            if (__VariantConstraintIndicator == null) { __VariantConstraintIndicator = new IndicatorType(); }
            return __VariantConstraintIndicator;
        }
        set
        {
            __VariantConstraintIndicator = value;
        }
    }

        
    /// <summary>
    /// The program that funds the tendering process (e.g., &quot;National&quot;, &quot;European&quot;), expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Funding_ Program Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Funding
    /// <para />PropertyTerm: Program Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType FundingProgramCode
    {
        get
        {
            if (__FundingProgramCode == null) { __FundingProgramCode = new CodeType(); }
            return __FundingProgramCode;
        }
        set
        {
            __FundingProgramCode = value;
        }
    }

        
    /// <summary>
    /// The maximum advertised monetary value of the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Maximum_ Advertisement. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Advertisement
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MaximumAdvertisementAmount
    {
        get
        {
            if (__MaximumAdvertisementAmount == null) { __MaximumAdvertisementAmount = new AmountType(); }
            return __MaximumAdvertisementAmount;
        }
        set
        {
            __MaximumAdvertisementAmount = value;
        }
    }

        
    /// <summary>
    /// A code signifying the frequency of payment in the contract associated with the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Payment Frequency Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Payment Frequency Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PaymentFrequencyCode
    {
        get
        {
            if (__PaymentFrequencyCode == null) { __PaymentFrequencyCode = new CodeType(); }
            return __PaymentFrequencyCode;
        }
        set
        {
            __PaymentFrequencyCode = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) of an electronic registry of economic operators.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Economic Operator Registry_ URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Economic Operator Registry
    /// <para />PropertyTerm: URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Web site
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType EconomicOperatorRegistryURI
    {
        get
        {
            if (__EconomicOperatorRegistryURI == null) { __EconomicOperatorRegistryURI = new IdentifierType(); }
            return __EconomicOperatorRegistryURI;
        }
        set
        {
            __EconomicOperatorRegistryURI = value;
        }
    }

        
    /// <summary>
    /// An indicator that tenderers are required to provide a curriculum vitae for each participant in the project (true) or are not so required (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Required Curricula. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Required Curricula
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType RequiredCurriculaIndicator
    {
        get
        {
            if (__RequiredCurriculaIndicator == null) { __RequiredCurriculaIndicator = new IndicatorType(); }
            return __RequiredCurriculaIndicator;
        }
        set
        {
            __RequiredCurriculaIndicator = value;
        }
    }

        
    /// <summary>
    /// Indicates whether other conditions exist (true) or not (false). If the indicator is true, the description may be provided.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Other_ Conditions. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Other
    /// <para />PropertyTerm: Conditions
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType OtherConditionsIndicator
    {
        get
        {
            if (__OtherConditionsIndicator == null) { __OtherConditionsIndicator = new IndicatorType(); }
            return __OtherConditionsIndicator;
        }
        set
        {
            __OtherConditionsIndicator = value;
        }
    }

        
    /// <summary>
    /// The end date until which the candidates can obtain the necessary level of security clearance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Latest_ Security Clearance Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Security Clearance Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType LatestSecurityClearanceDate
    {
        get
        {
            if (__LatestSecurityClearanceDate == null) { __LatestSecurityClearanceDate = new DateType(); }
            return __LatestSecurityClearanceDate;
        }
        set
        {
            __LatestSecurityClearanceDate = value;
        }
    }

        
    /// <summary>
    /// The amount to be paid to obtain the contract documents and additional documentation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Terms. Documentation Fee Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Documentation Fee Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType DocumentationFeeAmount
    {
        get
        {
            if (__DocumentationFeeAmount == null) { __DocumentationFeeAmount = new AmountType(); }
            return __DocumentationFeeAmount;
        }
        set
        {
            __DocumentationFeeAmount = value;
        }
    }

        
    /// <summary>
    /// A reference to a document providing references to procurement legislation applicable to the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Procurement Legislation_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Procurement Legislation
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType ProcurementLegislationDocumentReference
    {
        get
        {
            if (__ProcurementLegislationDocumentReference == null) { __ProcurementLegislationDocumentReference = new DocumentReferenceType(); }
            return __ProcurementLegislationDocumentReference;
        }
        set
        {
            __ProcurementLegislationDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a document providing references to fiscal legislation applicable to the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Fiscal Legislation_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Fiscal Legislation
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType FiscalLegislationDocumentReference
    {
        get
        {
            if (__FiscalLegislationDocumentReference == null) { __FiscalLegislationDocumentReference = new DocumentReferenceType(); }
            return __FiscalLegislationDocumentReference;
        }
        set
        {
            __FiscalLegislationDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a document providing references to environmental legislation applicable to the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Environmental Legislation_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Environmental Legislation
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType EnvironmentalLegislationDocumentReference
    {
        get
        {
            if (__EnvironmentalLegislationDocumentReference == null) { __EnvironmentalLegislationDocumentReference = new DocumentReferenceType(); }
            return __EnvironmentalLegislationDocumentReference;
        }
        set
        {
            __EnvironmentalLegislationDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a document providing references to employment legislation applicable to the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Employment Legislation_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Employment Legislation
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType EmploymentLegislationDocumentReference
    {
        get
        {
            if (__EmploymentLegislationDocumentReference == null) { __EmploymentLegislationDocumentReference = new DocumentReferenceType(); }
            return __EmploymentLegislationDocumentReference;
        }
        set
        {
            __EmploymentLegislationDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to the Call for Tender associated with these tendering terms.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Call For Tenders_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Call For Tenders
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType CallForTendersDocumentReference
    {
        get
        {
            if (__CallForTendersDocumentReference == null) { __CallForTendersDocumentReference = new DocumentReferenceType(); }
            return __CallForTendersDocumentReference;
        }
        set
        {
            __CallForTendersDocumentReference = value;
        }
    }

        
    /// <summary>
    /// The period during which a warranty for work, service, or goods associated with these tendering terms is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Warranty Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Warranty Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType WarrantyValidityPeriod
    {
        get
        {
            if (__WarrantyValidityPeriod == null) { __WarrantyValidityPeriod = new PeriodType(); }
            return __WarrantyValidityPeriod;
        }
        set
        {
            __WarrantyValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// The terms in the tendering process for awarding the contract for a project.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Awarding Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Awarding Terms
    /// <para />AssociatedObjectClass: Awarding Terms
    /// <para />RepresentationTerm: Awarding Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AwardingTermsType AwardingTerms
    {
        get
        {
            if (__AwardingTerms == null) { __AwardingTerms = new AwardingTermsType(); }
            return __AwardingTerms;
        }
        set
        {
            __AwardingTerms = value;
        }
    }

        
    /// <summary>
    /// A party that has additional information about the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Additional Information_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Additional Information
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType AdditionalInformationParty
    {
        get
        {
            if (__AdditionalInformationParty == null) { __AdditionalInformationParty = new PartyType(); }
            return __AdditionalInformationParty;
        }
        set
        {
            __AdditionalInformationParty = value;
        }
    }

        
    /// <summary>
    /// The party that has the contract documents for the tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Document Provider_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Document Provider
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType DocumentProviderParty
    {
        get
        {
            if (__DocumentProviderParty == null) { __DocumentProviderParty = new PartyType(); }
            return __DocumentProviderParty;
        }
        set
        {
            __DocumentProviderParty = value;
        }
    }

        
    /// <summary>
    /// The party to which tenders should be presented.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Tender Recipient_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Tender Recipient
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType TenderRecipientParty
    {
        get
        {
            if (__TenderRecipientParty == null) { __TenderRecipientParty = new PartyType(); }
            return __TenderRecipientParty;
        }
        set
        {
            __TenderRecipientParty = value;
        }
    }

        
    /// <summary>
    /// The party responsible for the execution of the contract.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Contract Responsible_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Contract Responsible
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ContractResponsibleParty
    {
        get
        {
            if (__ContractResponsibleParty == null) { __ContractResponsibleParty = new PartyType(); }
            return __ContractResponsibleParty;
        }
        set
        {
            __ContractResponsibleParty = value;
        }
    }

        
    /// <summary>
    /// The period during which tenders submitted for this tendering process must remain valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Tender Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Tender Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType TenderValidityPeriod
    {
        get
        {
            if (__TenderValidityPeriod == null) { __TenderValidityPeriod = new PeriodType(); }
            return __TenderValidityPeriod;
        }
        set
        {
            __TenderValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// The period of time during which the contracting authority may accept a contract.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Contract Acceptance_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Contract Acceptance
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ContractAcceptancePeriod
    {
        get
        {
            if (__ContractAcceptancePeriod == null) { __ContractAcceptancePeriod = new PeriodType(); }
            return __ContractAcceptancePeriod;
        }
        set
        {
            __ContractAcceptancePeriod = value;
        }
    }

        
    /// <summary>
    /// Information about the terms to present for an appeal against a tender award.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Appeal Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTerm: Appeal Terms
    /// <para />AssociatedObjectClass: Appeal Terms
    /// <para />RepresentationTerm: Appeal Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AppealTermsType AppealTerms
    {
        get
        {
            if (__AppealTerms == null) { __AppealTerms = new AppealTermsType(); }
            return __AppealTerms;
        }
        set
        {
            __AppealTerms = value;
        }
    }

        
    /// <summary>
    /// A class defining a reference to the notice that is being replaced.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Terms. Replaced Notice_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Terms
    /// <para />PropertyTermQualifier: Replaced Notice
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType ReplacedNoticeDocumentReference
    {
        get
        {
            if (__ReplacedNoticeDocumentReference == null) { __ReplacedNoticeDocumentReference = new DocumentReferenceType(); }
            return __ReplacedNoticeDocumentReference;
        }
        set
        {
            __ReplacedNoticeDocumentReference = value;
        }
    }

}