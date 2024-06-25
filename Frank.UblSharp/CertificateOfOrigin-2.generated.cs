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
    /// A document that describes the Certificate of Origin.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Certificate Of Origin. Details
    /// <para />ObjectClass: Certificate Of Origin
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CertificateOfOrigin", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CertificateOfOrigin-2")]
    [System.Xml.Serialization.XmlRootAttribute("CertificateOfOrigin", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CertificateOfOrigin-2", IsNullable=false)]
    public partial class CertificateOfOriginType
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
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public TimeType @__IssueTime;
        
        private System.Collections.Generic.List<TextType> _description;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
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
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public IdentifierType @__VersionID;
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=12)]
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
        [System.Xml.Serialization.XmlElementAttribute("ExporterParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=13)]
        public PartyType @__ExporterParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ImporterParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=14)]
        public PartyType @__ImporterParty;
        
        private System.Collections.Generic.List<EndorserPartyType> _endorserParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("EndorserParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public EndorserPartyType[] @__EndorserParty
        {
            get
            {
                return _endorserParty?.ToArray();
            }
            set
            {
                _endorserParty = value == null ? null : new System.Collections.Generic.List<EndorserPartyType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateOfOriginApplication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public CertificateOfOriginApplicationType @__CertificateOfOriginApplication;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssuerEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public EndorsementType @__IssuerEndorsement;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("EmbassyEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public EndorsementType @__EmbassyEndorsement;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("InsuranceEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public EndorsementType @__InsuranceEndorsement;
        
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
        /// Textual description of the document instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Description. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Certificate Of Origin
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
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Certificate Of Origin
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
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Certificate Of Origin
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
        /// The Party providing the endorsement.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Endorser Party
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTerm: Endorser Party
        /// <para />AssociatedObjectClass: Endorser Party
        /// <para />RepresentationTerm: Endorser Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<EndorserPartyType> EndorserParty
        {
            get { return _endorserParty ?? (_endorserParty = new System.Collections.Generic.List<EndorserPartyType>()); }
            set { _endorserParty = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0.5</example>
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
        /// <para />DictionaryEntryName: Certificate Of Origin. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>NES</example>
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
        /// <para />DictionaryEntryName: Certificate Of Origin. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BasicProcurementProcess</example>
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
        /// <para />DictionaryEntryName: Certificate Of Origin. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BPP-1001</example>
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
        /// <para />DictionaryEntryName: Certificate Of Origin. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Certificate Of Origin
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
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
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
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Issue Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
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
        /// <para />DictionaryEntryName: Certificate Of Origin. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
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
        /// Identifies the version of this Certificate of Origin.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
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
        /// The Party who makes the export declaration, or on whose behalf the export declaration is made, and who is the owner of the goods or has similar right of disposal over them at the time when the declaration is accepted.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Exporter_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTermQualifier: Exporter
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// <para />AlternativeBusinessTerms: Exporter (WCO ID 41 and 42)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ExporterParty
        {
            get
            {
                if (__ExporterParty == null) { __ExporterParty = new PartyType(); }
                return __ExporterParty;
            }
            set
            {
                __ExporterParty = value;
            }
        }

        
        /// <summary>
        /// The Party who makes an import declaration, or on whose behalf a Customs clearing agent or other authorized person makes an import declaration. This may include a person who has possession of the goods or to whom the goods are consigned.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Importer_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTermQualifier: Importer
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// <para />AlternativeBusinessTerms: Importer (WCO ID 39 and 40)
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ImporterParty
        {
            get
            {
                if (__ImporterParty == null) { __ImporterParty = new PartyType(); }
                return __ImporterParty;
            }
            set
            {
                __ImporterParty = value;
            }
        }

        
        /// <summary>
        /// Details of the application for a Certificate of Origin.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Certificate Of Origin Application
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTerm: Certificate Of Origin Application
        /// <para />AssociatedObjectClass: Certificate Of Origin Application
        /// <para />RepresentationTerm: Certificate Of Origin Application
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CertificateOfOriginApplicationType CertificateOfOriginApplication
        {
            get
            {
                if (__CertificateOfOriginApplication == null) { __CertificateOfOriginApplication = new CertificateOfOriginApplicationType(); }
                return __CertificateOfOriginApplication;
            }
            set
            {
                __CertificateOfOriginApplication = value;
            }
        }

        
        /// <summary>
        /// Issuer Endorsement details.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Issuer_ Endorsement. Endorsement
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTermQualifier: Issuer
        /// <para />PropertyTerm: Endorsement
        /// <para />AssociatedObjectClass: Endorsement
        /// <para />RepresentationTerm: Endorsement
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public EndorsementType IssuerEndorsement
        {
            get
            {
                if (__IssuerEndorsement == null) { __IssuerEndorsement = new EndorsementType(); }
                return __IssuerEndorsement;
            }
            set
            {
                __IssuerEndorsement = value;
            }
        }

        
        /// <summary>
        /// Embassy Endorsement details.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Embassy_ Endorsement. Endorsement
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTermQualifier: Embassy
        /// <para />PropertyTerm: Endorsement
        /// <para />AssociatedObjectClass: Endorsement
        /// <para />RepresentationTerm: Endorsement
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public EndorsementType EmbassyEndorsement
        {
            get
            {
                if (__EmbassyEndorsement == null) { __EmbassyEndorsement = new EndorsementType(); }
                return __EmbassyEndorsement;
            }
            set
            {
                __EmbassyEndorsement = value;
            }
        }

        
        /// <summary>
        /// Insurance Endorsement details.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Certificate Of Origin. Insurance_ Endorsement. Endorsement
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Certificate Of Origin
        /// <para />PropertyTermQualifier: Insurance
        /// <para />PropertyTerm: Endorsement
        /// <para />AssociatedObjectClass: Endorsement
        /// <para />RepresentationTerm: Endorsement
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public EndorsementType InsuranceEndorsement
        {
            get
            {
                if (__InsuranceEndorsement == null) { __InsuranceEndorsement = new EndorsementType(); }
                return __InsuranceEndorsement;
            }
            set
            {
                __InsuranceEndorsement = value;
            }
        }

    }
}
