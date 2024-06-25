using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a supplier party.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Supplier Party. Details
/// <para />ObjectClass: Supplier Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class SupplierPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomerAssignedAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__CustomerAssignedAccountID;
        
    private System.Collections.Generic.List<IdentifierType> _additionalAccountID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType[] @__AdditionalAccountID
    {
        get
        {
            return _additionalAccountID?.ToArray();
        }
        set
        {
            _additionalAccountID = value == null ? null : new System.Collections.Generic.List<IdentifierType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DataSendingCapability", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__DataSendingCapability;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=3)]
    public PartyType @__Party;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DespatchContact", Order=4)]
    public ContactType @__DespatchContact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingContact", Order=5)]
    public ContactType @__AccountingContact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerContact", Order=6)]
    public ContactType @__SellerContact;
        
    /// <summary>
    /// An additional identifier for this supplier party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Supplier Party. Additional_ Account Identifier. Identifier
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Supplier Party
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Account Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<IdentifierType> AdditionalAccountID
    {
        get { return _additionalAccountID ?? (_additionalAccountID = new System.Collections.Generic.List<IdentifierType>()); }
        set { _additionalAccountID = value; }
    }

        
    /// <summary>
    /// An identifier for this supplier party, assigned by the customer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Supplier Party. Customer Assigned_ Account Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Party
    /// <para />PropertyTermQualifier: Customer Assigned
    /// <para />PropertyTerm: Account Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType CustomerAssignedAccountID
    {
        get
        {
            if (__CustomerAssignedAccountID == null) { __CustomerAssignedAccountID = new IdentifierType(); }
            return __CustomerAssignedAccountID;
        }
        set
        {
            __CustomerAssignedAccountID = value;
        }
    }

        
    /// <summary>
    /// Text describing the supplier&apos;s ability to send invoice data via a purchase card provider (e.g., VISA, MasterCard, American Express).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Supplier Party. Data Sending Capability. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Party
    /// <para />PropertyTerm: Data Sending Capability
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType DataSendingCapability
    {
        get
        {
            if (__DataSendingCapability == null) { __DataSendingCapability = new TextType(); }
            return __DataSendingCapability;
        }
        set
        {
            __DataSendingCapability = value;
        }
    }

        
    /// <summary>
    /// The supplier party itself.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Party
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
    /// A contact at this supplier party for despatches (pickups).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Party. Despatch_ Contact. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Party
    /// <para />PropertyTermQualifier: Despatch
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType DespatchContact
    {
        get
        {
            if (__DespatchContact == null) { __DespatchContact = new ContactType(); }
            return __DespatchContact;
        }
        set
        {
            __DespatchContact = value;
        }
    }

        
    /// <summary>
    /// A contact at this supplier party for accounting.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Party. Accounting_ Contact. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Party
    /// <para />PropertyTermQualifier: Accounting
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType AccountingContact
    {
        get
        {
            if (__AccountingContact == null) { __AccountingContact = new ContactType(); }
            return __AccountingContact;
        }
        set
        {
            __AccountingContact = value;
        }
    }

        
    /// <summary>
    /// The primary contact for this supplier party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Party. Seller_ Contact. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Party
    /// <para />PropertyTermQualifier: Seller
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType SellerContact
    {
        get
        {
            if (__SellerContact == null) { __SellerContact = new ContactType(); }
            return __SellerContact;
        }
        set
        {
            __SellerContact = value;
        }
    }

}