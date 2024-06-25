using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a customer party.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Customer Party. Details
/// <para />ObjectClass: Customer Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CustomerPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomerAssignedAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__CustomerAssignedAccountID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplierAssignedAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__SupplierAssignedAccountID;
        
    private System.Collections.Generic.List<IdentifierType> _additionalAccountID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=3)]
    public PartyType @__Party;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryContact", Order=4)]
    public ContactType @__DeliveryContact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingContact", Order=5)]
    public ContactType @__AccountingContact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuyerContact", Order=6)]
    public ContactType @__BuyerContact;
        
    /// <summary>
    /// An identifier for the customer&apos;s account, assigned by a third party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Customer Party. Additional_ Account Identifier. Identifier
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Customer Party
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
    /// An identifier for the customer&apos;s account, assigned by the customer itself.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Customer Party. Customer Assigned_ Account Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Customer Party
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
    /// An identifier for the customer&apos;s account, assigned by the supplier.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Customer Party. Supplier Assigned_ Account Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Customer Party
    /// <para />PropertyTermQualifier: Supplier Assigned
    /// <para />PropertyTerm: Account Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SupplierAssignedAccountID
    {
        get
        {
            if (__SupplierAssignedAccountID == null) { __SupplierAssignedAccountID = new IdentifierType(); }
            return __SupplierAssignedAccountID;
        }
        set
        {
            __SupplierAssignedAccountID = value;
        }
    }

        
    /// <summary>
    /// The customer party itself.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Customer Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Customer Party
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
    /// A customer contact for deliveries.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Customer Party. Delivery_ Contact. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Customer Party
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType DeliveryContact
    {
        get
        {
            if (__DeliveryContact == null) { __DeliveryContact = new ContactType(); }
            return __DeliveryContact;
        }
        set
        {
            __DeliveryContact = value;
        }
    }

        
    /// <summary>
    /// A customer contact for accounting.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Customer Party. Accounting_ Contact. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Customer Party
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
    /// A customer contact for purchasing.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Customer Party. Buyer_ Contact. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Customer Party
    /// <para />PropertyTermQualifier: Buyer
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType BuyerContact
    {
        get
        {
            if (__BuyerContact == null) { __BuyerContact = new ContactType(); }
            return __BuyerContact;
        }
        set
        {
            __BuyerContact = value;
        }
    }

}