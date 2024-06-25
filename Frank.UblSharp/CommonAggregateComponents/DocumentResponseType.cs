namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an application-level response to a document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Document Response. Details
/// <para />ObjectClass: Document Response
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalDocumentResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalDocumentResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DocumentResponseType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Response", Order=0)]
    public ResponseType @__Response;
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=1)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuerParty", Order=2)]
    public PartyType @__IssuerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RecipientParty", Order=3)]
    public PartyType @__RecipientParty;
        
    private System.Collections.Generic.List<LineResponseType> _lineResponse;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineResponse", Order=4)]
    public LineResponseType[] @__LineResponse
    {
        get
        {
            return _lineResponse?.ToArray();
        }
        set
        {
            _lineResponse = value == null ? null : new System.Collections.Generic.List<LineResponseType>(value);
        }
    }
        
    /// <summary>
    /// A referenced document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Response. Document Reference
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Document Response
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
    /// A response to a particular line in the document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Response. Line Response
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Document Response
    /// <para />PropertyTerm: Line Response
    /// <para />AssociatedObjectClass: Line Response
    /// <para />RepresentationTerm: Line Response
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineResponseType> LineResponse
    {
        get { return _lineResponse ?? (_lineResponse = new System.Collections.Generic.List<LineResponseType>()); }
        set { _lineResponse = value; }
    }

        
    /// <summary>
    /// A response to the document as a whole.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Response. Response
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Document Response
    /// <para />PropertyTerm: Response
    /// <para />AssociatedObjectClass: Response
    /// <para />RepresentationTerm: Response
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ResponseType Response
    {
        get
        {
            if (__Response == null) { __Response = new ResponseType(); }
            return __Response;
        }
        set
        {
            __Response = value;
        }
    }

        
    /// <summary>
    /// The party that issued the document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Response. Issuer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Response
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
    /// The party for which the document is intended.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Document Response. Recipient_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Document Response
    /// <para />PropertyTermQualifier: Recipient
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType RecipientParty
    {
        get
        {
            if (__RecipientParty == null) { __RecipientParty = new PartyType(); }
            return __RecipientParty;
        }
        set
        {
            __RecipientParty = value;
        }
    }

}