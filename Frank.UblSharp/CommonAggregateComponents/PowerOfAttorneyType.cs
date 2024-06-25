using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a power of attorney.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Power Of Attorney. Details
/// <para />ObjectClass: Power Of Attorney
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PowerOfAttorney", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PowerOfAttorney", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PowerOfAttorneyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__IssueTime;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotaryParty", Order=4)]
    public PartyType @__NotaryParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AgentParty", Order=5)]
    public PartyType @__AgentParty;
        
    private System.Collections.Generic.List<PartyType> _witnessParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WitnessParty", Order=6)]
    public PartyType[] @__WitnessParty
    {
        get
        {
            return _witnessParty?.ToArray();
        }
        set
        {
            _witnessParty = value == null ? null : new System.Collections.Generic.List<PartyType>(value);
        }
    }
        
    private System.Collections.Generic.List<DocumentReferenceType> _mandateDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MandateDocumentReference", Order=7)]
    public DocumentReferenceType[] @__MandateDocumentReference
    {
        get
        {
            return _mandateDocumentReference?.ToArray();
        }
        set
        {
            _mandateDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this power of attorney.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Power Of Attorney
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
    /// An association to a WitnessParty.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Witness_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Power Of Attorney
    /// <para />PropertyTermQualifier: Witness
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyType> WitnessParty
    {
        get { return _witnessParty ?? (_witnessParty = new System.Collections.Generic.List<PartyType>()); }
        set { _witnessParty = value; }
    }

        
    /// <summary>
    /// A reference to a mandate associated with this power of attorney.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Mandate_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Power Of Attorney
    /// <para />PropertyTermQualifier: Mandate
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> MandateDocumentReference
    {
        get { return _mandateDocumentReference ?? (_mandateDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _mandateDocumentReference = value; }
    }

        
    /// <summary>
    /// An identifier for this power of attorney.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Power Of Attorney
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
    /// The date on which this power of attorney was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Power Of Attorney
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
    /// The time at which this power of attorney was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Power Of Attorney
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
    /// The party notarizing this power of attorney.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Notary_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Power Of Attorney
    /// <para />PropertyTermQualifier: Notary
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType NotaryParty
    {
        get
        {
            if (__NotaryParty == null) { __NotaryParty = new PartyType(); }
            return __NotaryParty;
        }
        set
        {
            __NotaryParty = value;
        }
    }

        
    /// <summary>
    /// The party who acts as an agent or fiduciary for the principal and who holds this power of attorney on behalf of the principal.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Power Of Attorney. Agent_ Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Power Of Attorney
    /// <para />PropertyTermQualifier: Agent
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType AgentParty
    {
        get
        {
            if (__AgentParty == null) { __AgentParty = new PartyType(); }
            return __AgentParty;
        }
        set
        {
            __AgentParty = value;
        }
    }

}