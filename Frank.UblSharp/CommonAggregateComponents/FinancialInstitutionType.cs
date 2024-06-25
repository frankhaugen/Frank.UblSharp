using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a financial institution.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Financial Institution. Details
/// <para />ObjectClass: Financial Institution
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("FinancialInstitution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("FinancialInstitution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class FinancialInstitutionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Address", Order=2)]
    public AddressType @__Address;
        
    /// <summary>
    /// An identifier for this financial institution. It is recommended that the ISO 9362 Bank Identification Code (BIC) be used as the ID.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Financial Institution. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Financial Institution
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
    /// The name of this financial institution.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Financial Institution. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Financial Institution
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType Name
    {
        get
        {
            if (__Name == null) { __Name = new NameType(); }
            return __Name;
        }
        set
        {
            __Name = value;
        }
    }

        
    /// <summary>
    /// The address of this financial institution.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Financial Institution. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Financial Institution
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType Address
    {
        get
        {
            if (__Address == null) { __Address = new AddressType(); }
            return __Address;
        }
        set
        {
            __Address = value;
        }
    }

}