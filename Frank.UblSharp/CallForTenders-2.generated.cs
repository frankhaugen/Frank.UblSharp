// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace Frank.UblSharp
{
    using Frank.UblSharp.CommonAggregateComponents;
    using Frank.UblSharp.UnqualifiedDataTypes;
    using Frank.UblSharp.CommonExtensionComponents;
    
    
    /// <summary>
    /// A document used by a Contracting Party to define a procurement project to buy goods, services, or works during a specified period.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Call For Tenders. Details
    /// <para />ObjectClass: Call For Tenders
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CallForTenders", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2")]
    [System.Xml.Serialization.XmlRootAttribute("CallForTenders", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2", IsNullable=false)]
    public partial class CallForTendersType
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractFolderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public IdentifierType @__ContractFolderID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ApprovalDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public DateType @__ApprovalDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public TimeType @__IssueTime;
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
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
        [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public IdentifierType @__VersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("PreviousVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public IdentifierType @__PreviousVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("LegalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public DocumentReferenceType @__LegalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TechnicalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public DocumentReferenceType @__TechnicalDocumentReference;
        
        private System.Collections.Generic.List<DocumentReferenceType> _additionalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
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
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public ContractingPartyType @__ContractingParty;
        
        private System.Collections.Generic.List<CustomerPartyType> _originatorCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public CustomerPartyType[] @__OriginatorCustomerParty
        {
            get
            {
                return _originatorCustomerParty?.ToArray();
            }
            set
            {
                _originatorCustomerParty = value == null ? null : new System.Collections.Generic.List<CustomerPartyType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public TenderingTermsType @__TenderingTerms;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public TenderingProcessType @__TenderingProcess;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=24)]
        public ProcurementProjectType @__ProcurementProject;
        
        private System.Collections.Generic.List<ProcurementProjectLotType> _procurementProjectLot;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=25)]
        public ProcurementProjectLotType[] @__ProcurementProjectLot
        {
            get
            {
                return _procurementProjectLot?.ToArray();
            }
            set
            {
                _procurementProjectLot = value == null ? null : new System.Collections.Generic.List<ProcurementProjectLotType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<UBLExtensionType> UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
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
        /// A reference to an additional document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Additional_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
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
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<SignatureType> Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// The party who originated Order.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Originator_ Customer Party. Customer Party
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Originator
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<CustomerPartyType> OriginatorCustomerParty
        {
            get { return _originatorCustomerParty ?? (_originatorCustomerParty = new System.Collections.Generic.List<CustomerPartyType>()); }
            set { _originatorCustomerParty = value; }
        }

        
        /// <summary>
        /// One of the procurement project lots into which this contract can be split.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Procurement Project Lot
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Procurement Project Lot
        /// <para />AssociatedObjectClass: Procurement Project Lot
        /// <para />RepresentationTerm: Procurement Project Lot
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ProcurementProjectLotType> ProcurementProjectLot
        {
            get { return _procurementProjectLot ?? (_procurementProjectLot = new System.Collections.Generic.List<ProcurementProjectLotType>()); }
            set { _procurementProjectLot = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
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
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// An identifier, assigned by the sender, for the process file (i.e., record) to which this document belongs.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Contract Folder Identifier. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Contract Folder Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ContractFolderID
        {
            get
            {
                if (__ContractFolderID == null) { __ContractFolderID = new IdentifierType(); }
                return __ContractFolderID;
            }
            set
            {
                __ContractFolderID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the contracting party, on which the Call For Tenders was approved.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Approval Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Approval Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType ApprovalDate
        {
            get
            {
                if (__ApprovalDate == null) { __ApprovalDate = new DateType(); }
                return __ApprovalDate;
            }
            set
            {
                __ApprovalDate = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// Indicates the current version of the Call for Tenders.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>1.1</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType VersionID
        {
            get
            {
                if (__VersionID == null) { __VersionID = new IdentifierType(); }
                return __VersionID;
            }
            set
            {
                __VersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies the previous version of the Call for Tenders which is superceded by this version.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Call For Tenders. Previous_ Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Previous
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>1.0</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType PreviousVersionID
        {
            get
            {
                if (__PreviousVersionID == null) { __PreviousVersionID = new IdentifierType(); }
                return __PreviousVersionID;
            }
            set
            {
                __PreviousVersionID = value;
            }
        }

        
        /// <summary>
        /// A reference to a legal document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Legal_ Document Reference. Document Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Legal
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType LegalDocumentReference
        {
            get
            {
                if (__LegalDocumentReference == null) { __LegalDocumentReference = new DocumentReferenceType(); }
                return __LegalDocumentReference;
            }
            set
            {
                __LegalDocumentReference = value;
            }
        }

        
        /// <summary>
        /// A reference to a technical document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Technical_ Document Reference. Document Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Technical
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType TechnicalDocumentReference
        {
            get
            {
                if (__TechnicalDocumentReference == null) { __TechnicalDocumentReference = new DocumentReferenceType(); }
                return __TechnicalDocumentReference;
            }
            set
            {
                __TechnicalDocumentReference = value;
            }
        }

        
        /// <summary>
        /// The contracting party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Contracting Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Contracting Party
        /// <para />AssociatedObjectClass: Contracting Party
        /// <para />RepresentationTerm: Contracting Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ContractingPartyType ContractingParty
        {
            get
            {
                if (__ContractingParty == null) { __ContractingParty = new ContractingPartyType(); }
                return __ContractingParty;
            }
            set
            {
                __ContractingParty = value;
            }
        }

        
        /// <summary>
        /// The party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Receiver_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        
        /// <summary>
        /// The tendering terms associated with this tendering process.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Tendering Terms
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Tendering Terms
        /// <para />AssociatedObjectClass: Tendering Terms
        /// <para />RepresentationTerm: Tendering Terms
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TenderingTermsType TenderingTerms
        {
            get
            {
                if (__TenderingTerms == null) { __TenderingTerms = new TenderingTermsType(); }
                return __TenderingTerms;
            }
            set
            {
                __TenderingTerms = value;
            }
        }

        
        /// <summary>
        /// A description of the tendering process itself.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Tendering Process
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Tendering Process
        /// <para />AssociatedObjectClass: Tendering Process
        /// <para />RepresentationTerm: Tendering Process
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TenderingProcessType TenderingProcess
        {
            get
            {
                if (__TenderingProcess == null) { __TenderingProcess = new TenderingProcessType(); }
                return __TenderingProcess;
            }
            set
            {
                __TenderingProcess = value;
            }
        }

        
        /// <summary>
        /// An overall definition of this procurement project.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Call For Tenders. Procurement Project
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Call For Tenders
        /// <para />PropertyTerm: Procurement Project
        /// <para />AssociatedObjectClass: Procurement Project
        /// <para />RepresentationTerm: Procurement Project
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ProcurementProjectType ProcurementProject
        {
            get
            {
                if (__ProcurementProject == null) { __ProcurementProject = new ProcurementProjectType(); }
                return __ProcurementProject;
            }
            set
            {
                __ProcurementProject = value;
            }
        }

    }
}
