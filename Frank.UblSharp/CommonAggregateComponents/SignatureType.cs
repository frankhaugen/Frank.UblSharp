using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a signature.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Signature. Details
/// <para />ObjectClass: Signature
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class SignatureType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute("ValidationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__ValidationDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidationTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TimeType @__ValidationTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidatorID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__ValidatorID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CanonicalizationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType @__CanonicalizationMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignatureMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__SignatureMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignatoryParty", Order=7)]
    public PartyType @__SignatoryParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DigitalSignatureAttachment", Order=8)]
    public AttachmentType @__DigitalSignatureAttachment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginalDocumentReference", Order=9)]
    public DocumentReferenceType @__OriginalDocumentReference;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures; in particular, information regarding the circumstances in which the signature is being used.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Signature. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Signature
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
    /// An identifier for this signature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Signature. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Signature
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
    /// The date upon which this signature was verified.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Signature. Validation Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTerm: Validation Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ValidationDate
    {
        get
        {
            if (__ValidationDate == null) { __ValidationDate = new DateType(); }
            return __ValidationDate;
        }
        set
        {
            __ValidationDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this signature was verified.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Signature. Validation Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTerm: Validation Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ValidationTime
    {
        get
        {
            if (__ValidationTime == null) { __ValidationTime = new TimeType(); }
            return __ValidationTime;
        }
        set
        {
            __ValidationTime = value;
        }
    }

        
    /// <summary>
    /// An identifier for the organization, person, service, or server that verified this signature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Signature. Validator. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTerm: Validator
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ValidatorID
    {
        get
        {
            if (__ValidatorID == null) { __ValidatorID = new IdentifierType(); }
            return __ValidatorID;
        }
        set
        {
            __ValidatorID = value;
        }
    }

        
    /// <summary>
    /// The method used to perform XML canonicalization of this signature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Signature. Canonicalization Method. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTerm: Canonicalization Method
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CanonicalizationMethod
    {
        get
        {
            if (__CanonicalizationMethod == null) { __CanonicalizationMethod = new TextType(); }
            return __CanonicalizationMethod;
        }
        set
        {
            __CanonicalizationMethod = value;
        }
    }

        
    /// <summary>
    /// Text describing the method of signature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Signature. Signature Method. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTerm: Signature Method
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType SignatureMethod
    {
        get
        {
            if (__SignatureMethod == null) { __SignatureMethod = new TextType(); }
            return __SignatureMethod;
        }
        set
        {
            __SignatureMethod = value;
        }
    }

        
    /// <summary>
    /// The signing party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Signature. Signatory_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTermQualifier: Signatory
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType SignatoryParty
    {
        get
        {
            if (__SignatoryParty == null) { __SignatoryParty = new PartyType(); }
            return __SignatoryParty;
        }
        set
        {
            __SignatoryParty = value;
        }
    }

        
    /// <summary>
    /// The actual encoded signature (e.g., in XMLDsig format).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Signature. Digital Signature_ Attachment. Attachment
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTermQualifier: Digital Signature
    /// <para />PropertyTerm: Attachment
    /// <para />AssociatedObjectClass: Attachment
    /// <para />RepresentationTerm: Attachment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AttachmentType DigitalSignatureAttachment
    {
        get
        {
            if (__DigitalSignatureAttachment == null) { __DigitalSignatureAttachment = new AttachmentType(); }
            return __DigitalSignatureAttachment;
        }
        set
        {
            __DigitalSignatureAttachment = value;
        }
    }

        
    /// <summary>
    /// A reference to the document that the signature applies to. For evidentiary purposes, this may be the document image that the signatory party saw when applying their signature.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Signature. Original_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Signature
    /// <para />PropertyTermQualifier: Original
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType OriginalDocumentReference
    {
        get
        {
            if (__OriginalDocumentReference == null) { __OriginalDocumentReference = new DocumentReferenceType(); }
            return __OriginalDocumentReference;
        }
        set
        {
            __OriginalDocumentReference = value;
        }
    }

}