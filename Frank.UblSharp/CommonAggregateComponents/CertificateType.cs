using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a certificate applied to the item. Certificated can be a requirement to sell goods or services in a jurisdiction.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Certificate. Details
/// <para />ObjectClass: Certificate
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Certificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Certificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CertificateType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CertificateTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__CertificateTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CertificateType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__CertificateType1;
        
    private System.Collections.Generic.List<TextType> _remarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
    [System.Xml.Serialization.XmlElementAttribute("IssuerParty", Order=4)]
    public PartyType @__IssuerParty;
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=5)]
    public DocumentReferenceType[] @__DocumentReference
    {
        get
        {
            return _documentReference?.ToArray();
        }
        set
        {
            _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<SignatureType> _signature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Signature", Order=6)]
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
    /// Remarks by the applicant for this certificate.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate. Remarks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Certificate
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
    /// A reference to a document relevant to this certificate or an application for this certificate.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Certificate
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
    {
        get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _documentReference = value; }
    }

        
    /// <summary>
    /// A signature applied to this certificate.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate. Signature
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Certificate
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
    /// An identifier for this certificate.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate
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
    /// The type of this certificate, expressed as a code. The type specifies what array it belongs to, e.g.. Environmental, security, health improvement etc.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Certificate. Certificate Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate
    /// <para />PropertyTerm: Certificate Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CertificateTypeCode
    {
        get
        {
            if (__CertificateTypeCode == null) { __CertificateTypeCode = new CodeType(); }
            return __CertificateTypeCode;
        }
        set
        {
            __CertificateTypeCode = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CertificateType1
    {
        get
        {
            if (__CertificateType1 == null) { __CertificateType1 = new TextType(); }
            return __CertificateType1;
        }
        set
        {
            __CertificateType1 = value;
        }
    }

        
    /// <summary>
    /// The authorized organization that issued this certificate, the provider of the certificate.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Certificate. Issuer_ Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Certificate
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

}