using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a trade financing instrument.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Trade Financing. Details
/// <para />ObjectClass: Trade Financing
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TradeFinancing", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TradeFinancing", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TradeFinancingType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinancingInstrumentCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__FinancingInstrumentCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Order=2)]
    public DocumentReferenceType @__ContractDocumentReference;
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=3)]
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
    [System.Xml.Serialization.XmlElementAttribute("FinancingParty", Order=4)]
    public PartyType @__FinancingParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinancingFinancialAccount", Order=5)]
    public FinancialAccountType @__FinancingFinancialAccount;
        
    private System.Collections.Generic.List<ClauseType> _clause;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Clause", Order=6)]
    public ClauseType[] @__Clause
    {
        get
        {
            return _clause?.ToArray();
        }
        set
        {
            _clause = value == null ? null : new System.Collections.Generic.List<ClauseType>(value);
        }
    }
        
    /// <summary>
    /// A reference to a document associated with this trade financing instrument.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Trade Financing. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Trade Financing
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
    /// A clause applicable to this trade financing instrument.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Trade Financing. Clause
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Trade Financing
    /// <para />PropertyTerm: Clause
    /// <para />AssociatedObjectClass: Clause
    /// <para />RepresentationTerm: Clause
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ClauseType> Clause
    {
        get { return _clause ?? (_clause = new System.Collections.Generic.List<ClauseType>()); }
        set { _clause = value; }
    }

        
    /// <summary>
    /// An identifier for this trade financing instrument.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Trade Financing. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Trade Financing
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
    /// A code signifying the type of this financing instrument.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Trade Financing. Financing Instrument Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Trade Financing
    /// <para />PropertyTerm: Financing Instrument Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Factoring , Invoice Financing , Pre-shipment Financing , Letter of Credit , Irrevocable Letter of Credit .</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType FinancingInstrumentCode
    {
        get
        {
            if (__FinancingInstrumentCode == null) { __FinancingInstrumentCode = new CodeType(); }
            return __FinancingInstrumentCode;
        }
        set
        {
            __FinancingInstrumentCode = value;
        }
    }

        
    /// <summary>
    /// A reference to a contract document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Trade Financing. Contract_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Trade Financing
    /// <para />PropertyTermQualifier: Contract
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType ContractDocumentReference
    {
        get
        {
            if (__ContractDocumentReference == null) { __ContractDocumentReference = new DocumentReferenceType(); }
            return __ContractDocumentReference;
        }
        set
        {
            __ContractDocumentReference = value;
        }
    }

        
    /// <summary>
    /// The financing party (bank or other enabled party).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Trade Financing. Financing_ Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Trade Financing
    /// <para />PropertyTermQualifier: Financing
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType FinancingParty
    {
        get
        {
            if (__FinancingParty == null) { __FinancingParty = new PartyType(); }
            return __FinancingParty;
        }
        set
        {
            __FinancingParty = value;
        }
    }

        
    /// <summary>
    /// An internal bank account used by the bank or its first agent to manage the line of credit granted to the financing requester.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Trade Financing. Financing_ Financial Account. Financial Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Trade Financing
    /// <para />PropertyTermQualifier: Financing
    /// <para />PropertyTerm: Financial Account
    /// <para />AssociatedObjectClass: Financial Account
    /// <para />RepresentationTerm: Financial Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public FinancialAccountType FinancingFinancialAccount
    {
        get
        {
            if (__FinancingFinancialAccount == null) { __FinancingFinancialAccount = new FinancialAccountType(); }
            return __FinancingFinancialAccount;
        }
        set
        {
            __FinancingFinancialAccount = value;
        }
    }

}