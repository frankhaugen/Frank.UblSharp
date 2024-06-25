using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an endorsement of a document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Endorsement. Details
/// <para />ObjectClass: Endorsement
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EmbassyEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EmbassyEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EndorsementType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__DocumentID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ApprovalStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__ApprovalStatus;
        
    private System.Collections.Generic.List<TextType> _remarks;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute("EndorserParty", Order=3)]
    public EndorserPartyType @__EndorserParty;
        
    private System.Collections.Generic.List<SignatureType> _signature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Signature", Order=4)]
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
    /// Remarks provided by the endorsing party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Endorsement. Remarks. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Endorsement
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
    /// A signature applied to this endorsement.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Endorsement. Signature
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Endorsement
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
    /// An identifier for this endorsement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Endorsement. Document. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Endorsement
    /// <para />PropertyTerm: Document
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType DocumentID
    {
        get
        {
            if (__DocumentID == null) { __DocumentID = new IdentifierType(); }
            return __DocumentID;
        }
        set
        {
            __DocumentID = value;
        }
    }

        
    /// <summary>
    /// The status of this endorsement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Endorsement. Approval Status. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Endorsement
    /// <para />PropertyTerm: Approval Status
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Authentication Code
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ApprovalStatus
    {
        get
        {
            if (__ApprovalStatus == null) { __ApprovalStatus = new TextType(); }
            return __ApprovalStatus;
        }
        set
        {
            __ApprovalStatus = value;
        }
    }

        
    /// <summary>
    /// The type of party providing this endorsement.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Endorsement. Endorser Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Endorsement
    /// <para />PropertyTerm: Endorser Party
    /// <para />AssociatedObjectClass: Endorser Party
    /// <para />RepresentationTerm: Endorser Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public EndorserPartyType EndorserParty
    {
        get
        {
            if (__EndorserParty == null) { __EndorserParty = new EndorserPartyType(); }
            return __EndorserParty;
        }
        set
        {
            __EndorserParty = value;
        }
    }

}