using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to a document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Document Reference. Details
/// <para />ObjectClass: Document Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DocumentReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IndicatorType @__CopyIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__IssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__DocumentTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__DocumentType;
        
    private System.Collections.Generic.List<TextType> _xPath;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("XPath", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType[] @__XPath
    {
        get
        {
            return _xPath?.ToArray();
        }
        set
        {
            _xPath = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LanguageID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IdentifierType @__LanguageID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LocaleCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public CodeType @__LocaleCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public IdentifierType @__VersionID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public CodeType @__DocumentStatusCode;
        
    private System.Collections.Generic.List<TextType> _documentDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public TextType[] @__DocumentDescription
    {
        get
        {
            return _documentDescription?.ToArray();
        }
        set
        {
            _documentDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Attachment", Order=13)]
    public AttachmentType @__Attachment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=14)]
    public PeriodType @__ValidityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuerParty", Order=15)]
    public PartyType @__IssuerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResultOfVerification", Order=16)]
    public ResultOfVerificationType @__ResultOfVerification;
        
    /// <summary>
    /// A reference to another place in the same XML document instance in which DocumentReference appears.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. XPath. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: XPath
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> XPath
    {
        get { return _xPath ?? (_xPath = new System.Collections.Generic.List<TextType>()); }
        set { _xPath = value; }
    }

        
    /// <summary>
    /// Text describing the referenced document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Document_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTermQualifier: Document
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>stock no longer provided</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> DocumentDescription
    {
        get { return _documentDescription ?? (_documentDescription = new System.Collections.Generic.List<TextType>()); }
        set { _documentDescription = value; }
    }

        
    /// <summary>
    /// An identifier for the referenced document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>PO-001 3333-44-123</example>
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
    /// An indicator that the referenced document is a copy (true) or the original (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Copy_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
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
    /// A universally unique identifier for this document reference.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
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
    /// The date, assigned by the sender of the referenced document, on which the document was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
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
    /// The time, assigned by the sender of the referenced document, at which the document was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
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
    /// The type of document being referenced, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Document Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Document Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DocumentTypeCode
    {
        get
        {
            if (__DocumentTypeCode == null) { __DocumentTypeCode = new CodeType(); }
            return __DocumentTypeCode;
        }
        set
        {
            __DocumentTypeCode = value;
        }
    }

        
    /// <summary>
    /// The type of document being referenced, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Document Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Document Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType DocumentType
    {
        get
        {
            if (__DocumentType == null) { __DocumentType = new TextType(); }
            return __DocumentType;
        }
        set
        {
            __DocumentType = value;
        }
    }

        
    /// <summary>
    /// An identifier for the language used in the referenced document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Language. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Language
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LanguageID
    {
        get
        {
            if (__LanguageID == null) { __LanguageID = new IdentifierType(); }
            return __LanguageID;
        }
        set
        {
            __LanguageID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the locale in which the language in the referenced document is used.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Locale Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Locale Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LocaleCode
    {
        get
        {
            if (__LocaleCode == null) { __LocaleCode = new CodeType(); }
            return __LocaleCode;
        }
        set
        {
            __LocaleCode = value;
        }
    }

        
    /// <summary>
    /// An identifier for the current version of the referenced document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Version. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
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
    /// A code signifying the status of the reference document with respect to its original state.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Document Reference. Document Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Document Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Document Status
    /// <para />DataType: Document Status_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DocumentStatusCode
    {
        get
        {
            if (__DocumentStatusCode == null) { __DocumentStatusCode = new CodeType(); }
            return __DocumentStatusCode;
        }
        set
        {
            __DocumentStatusCode = value;
        }
    }

        
    /// <summary>
    /// The referenced document as an attachment to the document from which it is referenced.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Reference. Attachment
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Attachment
    /// <para />AssociatedObjectClass: Attachment
    /// <para />RepresentationTerm: Attachment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AttachmentType Attachment
    {
        get
        {
            if (__Attachment == null) { __Attachment = new AttachmentType(); }
            return __Attachment;
        }
        set
        {
            __Attachment = value;
        }
    }

        
    /// <summary>
    /// The period for which this document reference is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Reference. Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTermQualifier: Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ValidityPeriod
    {
        get
        {
            if (__ValidityPeriod == null) { __ValidityPeriod = new PeriodType(); }
            return __ValidityPeriod;
        }
        set
        {
            __ValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// The party who issued the referenced document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Reference. Issuer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
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
    /// The result of an attempt to verify a signature associated with the referenced document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Reference. Result Of Verification
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Reference
    /// <para />PropertyTerm: Result Of Verification
    /// <para />AssociatedObjectClass: Result Of Verification
    /// <para />RepresentationTerm: Result Of Verification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ResultOfVerificationType ResultOfVerification
    {
        get
        {
            if (__ResultOfVerification == null) { __ResultOfVerification = new ResultOfVerificationType(); }
            return __ResultOfVerification;
        }
        set
        {
            __ResultOfVerification = value;
        }
    }

}