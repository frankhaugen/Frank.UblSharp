using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the party endorsing a document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Endorser Party. Details
/// <para />ObjectClass: Endorser Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EndorserParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EndorserParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EndorserPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RoleCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__RoleCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NumericType @__SequenceNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=2)]
    public PartyType @__Party;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignatoryContact", Order=3)]
    public ContactType @__SignatoryContact;
        
    /// <summary>
    /// A code specifying the role of the party providing the endorsement (e.g., issuer, embassy, insurance, etc.).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Endorser Party. Role Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Endorser Party
    /// <para />PropertyTerm: Role Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType RoleCode
    {
        get
        {
            if (__RoleCode == null) { __RoleCode = new CodeType(); }
            return __RoleCode;
        }
        set
        {
            __RoleCode = value;
        }
    }

        
    /// <summary>
    /// A number indicating the order of the endorsement provided by this party in the sequence in which endorsements are to be applied.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Endorser Party. Sequence. Numeric
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Endorser Party
    /// <para />PropertyTerm: Sequence
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType SequenceNumeric
    {
        get
        {
            if (__SequenceNumeric == null) { __SequenceNumeric = new NumericType(); }
            return __SequenceNumeric;
        }
        set
        {
            __SequenceNumeric = value;
        }
    }

        
    /// <summary>
    /// The party endorsing the application.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Endorser Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Endorser Party
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

        
    /// <summary>
    /// The individual representing the exporter who signs the Certificate of Origin application before submitting it to the issuer party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Endorser Party. Signatory_ Contact. Contact
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Endorser Party
    /// <para />PropertyTermQualifier: Signatory
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType SignatoryContact
    {
        get
        {
            if (__SignatoryContact == null) { __SignatoryContact = new ContactType(); }
            return __SignatoryContact;
        }
        set
        {
            __SignatoryContact = value;
        }
    }

}