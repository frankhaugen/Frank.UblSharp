using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define an application for a Certificate of Origin (CoO).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Certificate Of Origin Application. Details
/// <para />ObjectClass: Certificate Of Origin Application
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CertificateOfOriginApplication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CertificateOfOriginApplication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CertificateOfOriginApplicationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ReferenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CertificateType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__CertificateType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ApplicationStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ApplicationStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginalJobID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IdentifierType @__OriginalJobID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousJobID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__PreviousJobID;
        
    private System.Collections.Generic.List<TextType> _remarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__Remarks
    {
        get
        {
            return _remarks?.ToArray();
        }
        set
        {
            _remarks = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Shipment", Order=6)]
    public ShipmentType @__Shipment;
        
    private System.Collections.Generic.List<EndorserPartyType> _endorserParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EndorserParty", Order=7)]
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
    [System.Xml.Serialization.XmlElementAttribute("PreparationParty", Order=8)]
    public PartyType @__PreparationParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuerParty", Order=9)]
    public PartyType @__IssuerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExporterParty", Order=10)]
    public PartyType @__ExporterParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ImporterParty", Order=11)]
    public PartyType @__ImporterParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuingCountry", Order=12)]
    public CountryType @__IssuingCountry;
        
    private System.Collections.Generic.List<DocumentDistributionType> _documentDistribution;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution", Order=13)]
    public DocumentDistributionType[] @__DocumentDistribution
    {
        get
        {
            return _documentDistribution?.ToArray();
        }
        set
        {
            _documentDistribution = value == null ? null : new System.Collections.Generic.List<DocumentDistributionType>(value);
        }
    }
        
    private System.Collections.Generic.List<DocumentReferenceType> _supportingDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference", Order=14)]
    public DocumentReferenceType[] @__SupportingDocumentReference
    {
        get
        {
            return _supportingDocumentReference?.ToArray();
        }
        set
        {
            _supportingDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<SignatureType> _signature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Signature", Order=15)]
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
        
    /// <summary>
    /// Remarks by the applicant for the CoO.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Remarks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTerm: Remarks
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Remarks
    {
        get { return _remarks ?? (_remarks = new System.Collections.Generic.List<TextType>()); }
        set { _remarks = value; }
    }

        
    /// <summary>
    /// A party providing an endorsement to the CoO.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Endorser Party
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Certificate Of Origin Application
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
    /// An interested party to which the CoO is to be distributed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Document Distribution
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTerm: Document Distribution
    /// <para />AssociatedObjectClass: Document Distribution
    /// <para />RepresentationTerm: Document Distribution
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentDistributionType> DocumentDistribution
    {
        get { return _documentDistribution ?? (_documentDistribution = new System.Collections.Generic.List<DocumentDistributionType>()); }
        set { _documentDistribution = value; }
    }

        
    /// <summary>
    /// A reference to a document supporting this application.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Supporting_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTermQualifier: Supporting
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> SupportingDocumentReference
    {
        get { return _supportingDocumentReference ?? (_supportingDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _supportingDocumentReference = value; }
    }

        
    /// <summary>
    /// A signature applied to this application.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Signature
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Certificate Of Origin Application
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
    /// An identifier for a reference as part of the CoO application.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Reference. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTerm: Reference
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ReferenceID
    {
        get
        {
            if (__ReferenceID == null) { __ReferenceID = new IdentifierType(); }
            return __ReferenceID;
        }
        set
        {
            __ReferenceID = value;
        }
    }

        
    /// <summary>
    /// The type of CoO being applied for (Ordinary, Re-export, Commonwealth Preferential, etc.).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Certificate Type. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTerm: Certificate Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CertificateType
    {
        get
        {
            if (__CertificateType == null) { __CertificateType = new TextType(); }
            return __CertificateType;
        }
        set
        {
            __CertificateType = value;
        }
    }

        
    /// <summary>
    /// A code signifying the status of the application (revision, replacement, etc.).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Application Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTerm: Application Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ApplicationStatusCode
    {
        get
        {
            if (__ApplicationStatusCode == null) { __ApplicationStatusCode = new CodeType(); }
            return __ApplicationStatusCode;
        }
        set
        {
            __ApplicationStatusCode = value;
        }
    }

        
    /// <summary>
    /// The latest job number given to the CoO application. This is used by the system to keep track of amendments to or cancellation of any earlier applications.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Original_ Job Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTermQualifier: Original
    /// <para />PropertyTerm: Job Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType OriginalJobID
    {
        get
        {
            if (__OriginalJobID == null) { __OriginalJobID = new IdentifierType(); }
            return __OriginalJobID;
        }
        set
        {
            __OriginalJobID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the previous job used in case the application requires query or change.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Previous_ Job Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTermQualifier: Previous
    /// <para />PropertyTerm: Job Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType PreviousJobID
    {
        get
        {
            if (__PreviousJobID == null) { __PreviousJobID = new IdentifierType(); }
            return __PreviousJobID;
        }
        set
        {
            __PreviousJobID = value;
        }
    }

        
    /// <summary>
    /// The shipment of goods covered by the CoO.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Shipment
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTerm: Shipment
    /// <para />AssociatedObjectClass: Shipment
    /// <para />RepresentationTerm: Shipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ShipmentType Shipment
    {
        get
        {
            if (__Shipment == null) { __Shipment = new ShipmentType(); }
            return __Shipment;
        }
        set
        {
            __Shipment = value;
        }
    }

        
    /// <summary>
    /// The party (individual, group, or body) that prepared this CoO application.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Preparation_ Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTermQualifier: Preparation
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType PreparationParty
    {
        get
        {
            if (__PreparationParty == null) { __PreparationParty = new PartyType(); }
            return __PreparationParty;
        }
        set
        {
            __PreparationParty = value;
        }
    }

        
    /// <summary>
    /// The organization authorized to issue the CoO requested by this application.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Issuer_ Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTermQualifier: Issuer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType IssuerParty
    {
        get
        {
            if (__IssuerParty == null) { __IssuerParty = new PartyType(); }
            return __IssuerParty;
        }
        set
        {
            __IssuerParty = value;
        }
    }

        
    /// <summary>
    /// The party making an export declaration, or on behalf of which the export declaration is made, and that is the owner of the goods or has similar right of disposal over them at the time when the declaration is accepted.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Exporter_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Certificate Of Origin Application
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
    /// The party making an import declaration, or on behalf of which a customs clearing agent or other authorized person makes an import declaration. This may include a person who has possession of the goods or to whom the goods are consigned.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Importer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Certificate Of Origin Application
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
    /// The country where the requested CoO will be issued.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate Of Origin Application. Issuing_ Country. Country
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate Of Origin Application
    /// <para />PropertyTermQualifier: Issuing
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CountryType IssuingCountry
    {
        get
        {
            if (__IssuingCountry == null) { __IssuingCountry = new CountryType(); }
            return __IssuingCountry;
        }
        set
        {
            __IssuingCountry = value;
        }
    }

}