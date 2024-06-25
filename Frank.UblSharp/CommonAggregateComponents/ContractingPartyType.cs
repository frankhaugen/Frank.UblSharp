using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an individual, a group, or a body having a procurement role in a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Contracting Party. Details
/// <para />ObjectClass: Contracting Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ContractingPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuyerProfileURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__BuyerProfileURI;
        
    private System.Collections.Generic.List<ContractingPartyTypeType> _contractingPartyType1;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractingPartyType", Order=1)]
    public ContractingPartyTypeType[] @__ContractingPartyType1
    {
        get
        {
            return _contractingPartyType1?.ToArray();
        }
        set
        {
            _contractingPartyType1 = value == null ? null : new System.Collections.Generic.List<ContractingPartyTypeType>(value);
        }
    }
        
    private System.Collections.Generic.List<ContractingActivityType> _contractingActivity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractingActivity", Order=2)]
    public ContractingActivityType[] @__ContractingActivity
    {
        get
        {
            return _contractingActivity?.ToArray();
        }
        set
        {
            _contractingActivity = value == null ? null : new System.Collections.Generic.List<ContractingActivityType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=3)]
    public PartyType @__Party;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ContractingPartyTypeType> ContractingPartyType1
    {
        get { return _contractingPartyType1 ?? (_contractingPartyType1 = new System.Collections.Generic.List<ContractingPartyTypeType>()); }
        set { _contractingPartyType1 = value; }
    }

        
    /// <summary>
    /// The nature of the type of business of the organization
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contracting Party. Contracting Activity
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contracting Party
    /// <para />PropertyTerm: Contracting Activity
    /// <para />AssociatedObjectClass: Contracting Activity
    /// <para />RepresentationTerm: Contracting Activity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ContractingActivityType> ContractingActivity
    {
        get { return _contractingActivity ?? (_contractingActivity = new System.Collections.Generic.List<ContractingActivityType>()); }
        set { _contractingActivity = value; }
    }

        
    /// <summary>
    /// The buyer profile is typically located on a web site where the contracting party publishes its procurement opportunities
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contracting Party. Buyer Profile_ URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contracting Party
    /// <para />PropertyTermQualifier: Buyer Profile
    /// <para />PropertyTerm: URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Buyer Profile
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType BuyerProfileURI
    {
        get
        {
            if (__BuyerProfileURI == null) { __BuyerProfileURI = new IdentifierType(); }
            return __BuyerProfileURI;
        }
        set
        {
            __BuyerProfileURI = value;
        }
    }

        
    /// <summary>
    /// The contracting party itself.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contracting Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Contracting Party
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType Party
    {
        get
        {
            if (__Party == null) { __Party = new PartyType(); }
            return __Party;
        }
        set
        {
            __Party = value;
        }
    }

}