using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a branch or a division of an organization.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Branch. Details
/// <para />ObjectClass: Branch
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Branch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Branch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class BranchType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinancialInstitution", Order=2)]
    public FinancialInstitutionType @__FinancialInstitution;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Address", Order=3)]
    public AddressType @__Address;
        
    /// <summary>
    /// An identifier for this branch or division of an organization.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Branch. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Branch
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
    /// The name of this branch or division of an organization.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Branch. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Branch
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
    /// The financial institution that this branch belongs to (if applicable).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Branch. Financial Institution
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Branch
    /// <para />PropertyTerm: Financial Institution
    /// <para />AssociatedObjectClass: Financial Institution
    /// <para />RepresentationTerm: Financial Institution
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public FinancialInstitutionType FinancialInstitution
    {
        get
        {
            if (__FinancialInstitution == null) { __FinancialInstitution = new FinancialInstitutionType(); }
            return __FinancialInstitution;
        }
        set
        {
            __FinancialInstitution = value;
        }
    }

        
    /// <summary>
    /// The address of this branch or division.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Branch. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Branch
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