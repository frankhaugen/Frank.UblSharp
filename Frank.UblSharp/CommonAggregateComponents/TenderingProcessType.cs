using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the process of a formal offer and response to execute work or supply goods at a stated price.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tendering Process. Details
/// <para />ObjectClass: Tendering Process
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TenderingProcessType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginalContractingSystemID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__OriginalContractingSystemID;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _negotiationDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NegotiationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__NegotiationDescription
    {
        get
        {
            return _negotiationDescription?.ToArray();
        }
        set
        {
            _negotiationDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcedureCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__ProcedureCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UrgencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__UrgencyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpenseCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__ExpenseCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartPresentationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__PartPresentationCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractingSystemCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public CodeType @__ContractingSystemCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubmissionMethodCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public CodeType @__SubmissionMethodCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CandidateReductionConstraintIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public IndicatorType @__CandidateReductionConstraintIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GovernmentAgreementConstraintIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public IndicatorType @__GovernmentAgreementConstraintIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentAvailabilityPeriod", Order=12)]
    public PeriodType @__DocumentAvailabilityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderSubmissionDeadlinePeriod", Order=13)]
    public PeriodType @__TenderSubmissionDeadlinePeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvitationSubmissionPeriod", Order=14)]
    public PeriodType @__InvitationSubmissionPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ParticipationRequestReceptionPeriod", Order=15)]
    public PeriodType @__ParticipationRequestReceptionPeriod;
        
    private System.Collections.Generic.List<DocumentReferenceType> _noticeDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NoticeDocumentReference", Order=16)]
    public DocumentReferenceType[] @__NoticeDocumentReference
    {
        get
        {
            return _noticeDocumentReference?.ToArray();
        }
        set
        {
            _noticeDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<DocumentReferenceType> _additionalDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Order=17)]
    public DocumentReferenceType[] @__AdditionalDocumentReference
    {
        get
        {
            return _additionalDocumentReference?.ToArray();
        }
        set
        {
            _additionalDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<ProcessJustificationType> _processJustification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcessJustification", Order=18)]
    public ProcessJustificationType[] @__ProcessJustification
    {
        get
        {
            return _processJustification?.ToArray();
        }
        set
        {
            _processJustification = value == null ? null : new System.Collections.Generic.List<ProcessJustificationType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EconomicOperatorShortList", Order=19)]
    public EconomicOperatorShortListType @__EconomicOperatorShortList;
        
    private System.Collections.Generic.List<EventType> _openTenderEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OpenTenderEvent", Order=20)]
    public EventType[] @__OpenTenderEvent
    {
        get
        {
            return _openTenderEvent?.ToArray();
        }
        set
        {
            _openTenderEvent = value == null ? null : new System.Collections.Generic.List<EventType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AuctionTerms", Order=21)]
    public AuctionTermsType @__AuctionTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FrameworkAgreement", Order=22)]
    public FrameworkAgreementType @__FrameworkAgreement;
        
    /// <summary>
    /// Text describing the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Text describing the negotiation to be followed during the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Negotiation_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Negotiation
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> NegotiationDescription
    {
        get { return _negotiationDescription ?? (_negotiationDescription = new System.Collections.Generic.List<TextType>()); }
        set { _negotiationDescription = value; }
    }

        
    /// <summary>
    /// A reference to a notice pertaining to this tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Notice_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Notice
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> NoticeDocumentReference
    {
        get { return _noticeDocumentReference ?? (_noticeDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _noticeDocumentReference = value; }
    }

        
    /// <summary>
    /// A reference to an additional document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Additional_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> AdditionalDocumentReference
    {
        get { return _additionalDocumentReference ?? (_additionalDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _additionalDocumentReference = value; }
    }

        
    /// <summary>
    /// A justification for the selection of this tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Process Justification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Process Justification
    /// <para />AssociatedObjectClass: Process Justification
    /// <para />RepresentationTerm: Process Justification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ProcessJustificationType> ProcessJustification
    {
        get { return _processJustification ?? (_processJustification = new System.Collections.Generic.List<ProcessJustificationType>()); }
        set { _processJustification = value; }
    }

        
    /// <summary>
    /// Textual description of the legal form required for potential tenderers.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Open Tender_ Event. Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Open Tender
    /// <para />PropertyTerm: Event
    /// <para />AssociatedObjectClass: Event
    /// <para />RepresentationTerm: Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EventType> OpenTenderEvent
    {
        get { return _openTenderEvent ?? (_openTenderEvent = new System.Collections.Generic.List<EventType>()); }
        set { _openTenderEvent = value; }
    }

        
    /// <summary>
    /// An identifier for this tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// When reopening a tendering process, the identifier of the original framework agreement or dynamic purchasing system.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Original_ Contracting System. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Original
    /// <para />PropertyTerm: Contracting System
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType OriginalContractingSystemID
    {
        get
        {
            if (__OriginalContractingSystemID == null) { __OriginalContractingSystemID = new IdentifierType(); }
            return __OriginalContractingSystemID;
        }
        set
        {
            __OriginalContractingSystemID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of this tendering procedure.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Procedure Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Procedure Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Open, Restricted, Negotiated</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ProcedureCode
    {
        get
        {
            if (__ProcedureCode == null) { __ProcedureCode = new CodeType(); }
            return __ProcedureCode;
        }
        set
        {
            __ProcedureCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the urgency of this tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Urgency Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Urgency Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Urgent, Normal, Emergency</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType UrgencyCode
    {
        get
        {
            if (__UrgencyCode == null) { __UrgencyCode = new CodeType(); }
            return __UrgencyCode;
        }
        set
        {
            __UrgencyCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of expense for this tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Expense Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Expense Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Normal, Anticipated</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ExpenseCode
    {
        get
        {
            if (__ExpenseCode == null) { __ExpenseCode = new CodeType(); }
            return __ExpenseCode;
        }
        set
        {
            __ExpenseCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of presentation of tenders required (e.g., one lot, multiple lots, or all the lots).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Part Presentation Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Part Presentation Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>One Lot, Multiple Lots, All Lots</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PartPresentationCode
    {
        get
        {
            if (__PartPresentationCode == null) { __PartPresentationCode = new CodeType(); }
            return __PartPresentationCode;
        }
        set
        {
            __PartPresentationCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of contracting system (e.g., framework agreement, dynamic purchasing system). If the procedure is individual (nonrepetitive), this code should be omitted.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Contracting System Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Contracting System Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Framework Agreement, Dynamic Purchasing System</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ContractingSystemCode
    {
        get
        {
            if (__ContractingSystemCode == null) { __ContractingSystemCode = new CodeType(); }
            return __ContractingSystemCode;
        }
        set
        {
            __ContractingSystemCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the method to be followed in submitting tenders.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Submission Method Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Submission Method Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Manual, Electronically, etc.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SubmissionMethodCode
    {
        get
        {
            if (__SubmissionMethodCode == null) { __SubmissionMethodCode = new CodeType(); }
            return __SubmissionMethodCode;
        }
        set
        {
            __SubmissionMethodCode = value;
        }
    }

        
    /// <summary>
    /// An indicator that the number of candidates participating in this process has been reduced (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Candidate Reduction_ Constraint. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Candidate Reduction
    /// <para />PropertyTerm: Constraint
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType CandidateReductionConstraintIndicator
    {
        get
        {
            if (__CandidateReductionConstraintIndicator == null) { __CandidateReductionConstraintIndicator = new IndicatorType(); }
            return __CandidateReductionConstraintIndicator;
        }
        set
        {
            __CandidateReductionConstraintIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that the project associated with this tendering process is constrained by a government procurement agreement (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendering Process. Government Agreement_ Constraint. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Government Agreement
    /// <para />PropertyTerm: Constraint
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType GovernmentAgreementConstraintIndicator
    {
        get
        {
            if (__GovernmentAgreementConstraintIndicator == null) { __GovernmentAgreementConstraintIndicator = new IndicatorType(); }
            return __GovernmentAgreementConstraintIndicator;
        }
        set
        {
            __GovernmentAgreementConstraintIndicator = value;
        }
    }

        
    /// <summary>
    /// The period during which documents relating to this tendering process must be completed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Document Availability_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Document Availability
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType DocumentAvailabilityPeriod
    {
        get
        {
            if (__DocumentAvailabilityPeriod == null) { __DocumentAvailabilityPeriod = new PeriodType(); }
            return __DocumentAvailabilityPeriod;
        }
        set
        {
            __DocumentAvailabilityPeriod = value;
        }
    }

        
    /// <summary>
    /// The period during which tenders must be delivered.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Tender Submission Deadline_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Tender Submission Deadline
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType TenderSubmissionDeadlinePeriod
    {
        get
        {
            if (__TenderSubmissionDeadlinePeriod == null) { __TenderSubmissionDeadlinePeriod = new PeriodType(); }
            return __TenderSubmissionDeadlinePeriod;
        }
        set
        {
            __TenderSubmissionDeadlinePeriod = value;
        }
    }

        
    /// <summary>
    /// The period during which invitations to tender must be completed and delivered.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Invitation Submission_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Invitation Submission
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType InvitationSubmissionPeriod
    {
        get
        {
            if (__InvitationSubmissionPeriod == null) { __InvitationSubmissionPeriod = new PeriodType(); }
            return __InvitationSubmissionPeriod;
        }
        set
        {
            __InvitationSubmissionPeriod = value;
        }
    }

        
    /// <summary>
    /// The period during which requests for participation must be completed and delivered.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Participation Request Reception_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTermQualifier: Participation Request Reception
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ParticipationRequestReceptionPeriod
    {
        get
        {
            if (__ParticipationRequestReceptionPeriod == null) { __ParticipationRequestReceptionPeriod = new PeriodType(); }
            return __ParticipationRequestReceptionPeriod;
        }
        set
        {
            __ParticipationRequestReceptionPeriod = value;
        }
    }

        
    /// <summary>
    /// A set of criteria used to create a short list of candidates.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Economic Operator Short List
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Economic Operator Short List
    /// <para />AssociatedObjectClass: Economic Operator Short List
    /// <para />RepresentationTerm: Economic Operator Short List
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public EconomicOperatorShortListType EconomicOperatorShortList
    {
        get
        {
            if (__EconomicOperatorShortList == null) { __EconomicOperatorShortList = new EconomicOperatorShortListType(); }
            return __EconomicOperatorShortList;
        }
        set
        {
            __EconomicOperatorShortList = value;
        }
    }

        
    /// <summary>
    /// The terms to be fulfilled by tenderers if an auction is to be executed before the awarding of a tender.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Auction Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Auction Terms
    /// <para />AssociatedObjectClass: Auction Terms
    /// <para />RepresentationTerm: Auction Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AuctionTermsType AuctionTerms
    {
        get
        {
            if (__AuctionTerms == null) { __AuctionTerms = new AuctionTermsType(); }
            return __AuctionTerms;
        }
        set
        {
            __AuctionTerms = value;
        }
    }

        
    /// <summary>
    /// A tendering framework agreement.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendering Process. Framework Agreement
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendering Process
    /// <para />PropertyTerm: Framework Agreement
    /// <para />AssociatedObjectClass: Framework Agreement
    /// <para />RepresentationTerm: Framework Agreement
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public FrameworkAgreementType FrameworkAgreement
    {
        get
        {
            if (__FrameworkAgreement == null) { __FrameworkAgreement = new FrameworkAgreementType(); }
            return __FrameworkAgreement;
        }
        set
        {
            __FrameworkAgreement = value;
        }
    }

}