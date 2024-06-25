using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an item of evidentiary support for representations of capabilities or the ability to meet tendering requirements, which an economic operator must provide for acceptance into a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Evidence. Details
/// <para />ObjectClass: Evidence
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Evidence", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Evidence", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EvidenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EvidenceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__EvidenceTypeCode;
        
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
        
    private System.Collections.Generic.List<TextType> _candidateStatement;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CandidateStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__CandidateStatement
    {
        get
        {
            return _candidateStatement?.ToArray();
        }
        set
        {
            _candidateStatement = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EvidenceIssuingParty", Order=4)]
    public PartyType @__EvidenceIssuingParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=5)]
    public DocumentReferenceType @__DocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Language", Order=6)]
    public LanguageType @__Language;
        
    /// <summary>
    /// The textual description for this Evidence.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evidence. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Evidence
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
    /// Information about a candidate statement that the contracting authority accepts as a sufficient response.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evidence. Candidate_ Statement. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Evidence
    /// <para />PropertyTermQualifier: Candidate
    /// <para />PropertyTerm: Statement
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> CandidateStatement
    {
        get { return _candidateStatement ?? (_candidateStatement = new System.Collections.Generic.List<TextType>()); }
        set { _candidateStatement = value; }
    }

        
    /// <summary>
    /// An identifier for this item of evidentiary support.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evidence. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evidence
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
    /// A code signifying the type of evidence.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evidence. Evidence Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evidence
    /// <para />PropertyTerm: Evidence Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType EvidenceTypeCode
    {
        get
        {
            if (__EvidenceTypeCode == null) { __EvidenceTypeCode = new CodeType(); }
            return __EvidenceTypeCode;
        }
        set
        {
            __EvidenceTypeCode = value;
        }
    }

        
    /// <summary>
    /// A class to describe a party issuing an evidentiary document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Evidence. Evidence Issuing_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evidence
    /// <para />PropertyTermQualifier: Evidence Issuing
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType EvidenceIssuingParty
    {
        get
        {
            if (__EvidenceIssuingParty == null) { __EvidenceIssuingParty = new PartyType(); }
            return __EvidenceIssuingParty;
        }
        set
        {
            __EvidenceIssuingParty = value;
        }
    }

        
    /// <summary>
    /// A reference to the evidentiary document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Evidence. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evidence
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType DocumentReference
    {
        get
        {
            if (__DocumentReference == null) { __DocumentReference = new DocumentReferenceType(); }
            return __DocumentReference;
        }
        set
        {
            __DocumentReference = value;
        }
    }

        
    /// <summary>
    /// Information about a required translation to be part of the response, i.e. the language.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Evidence. Language
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evidence
    /// <para />PropertyTerm: Language
    /// <para />AssociatedObjectClass: Language
    /// <para />RepresentationTerm: Language
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LanguageType Language
    {
        get
        {
            if (__Language == null) { __Language = new LanguageType(); }
            return __Language;
        }
        set
        {
            __Language = value;
        }
    }

}