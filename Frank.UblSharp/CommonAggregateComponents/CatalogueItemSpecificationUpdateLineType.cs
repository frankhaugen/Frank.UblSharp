using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line describing the transaction that updates the specification of an item in a catalogue.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Catalogue Item Specification Update Line. Details
/// <para />ObjectClass: Catalogue Item Specification Update Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CatalogueItemSpecificationUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueItemSpecificationUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CatalogueItemSpecificationUpdateLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractorCustomerParty", Order=1)]
    public CustomerPartyType @__ContractorCustomerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Order=2)]
    public SupplierPartyType @__SellerSupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=3)]
    public ItemType @__Item;
        
    /// <summary>
    /// An identifier for the line to be updated in a catalogue.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Item Specification Update Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Item Specification Update Line
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1</example>
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
    /// The customer responsible for the contract associated with the catalogue item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Item Specification Update Line. Contractor_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Item Specification Update Line
    /// <para />PropertyTermQualifier: Contractor
    /// <para />PropertyTerm: Customer Party
    /// <para />AssociatedObjectClass: Customer Party
    /// <para />RepresentationTerm: Customer Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CustomerPartyType ContractorCustomerParty
    {
        get
        {
            if (__ContractorCustomerParty == null) { __ContractorCustomerParty = new CustomerPartyType(); }
            return __ContractorCustomerParty;
        }
        set
        {
            __ContractorCustomerParty = value;
        }
    }

        
    /// <summary>
    /// The seller/supplier responsible for the contract associated with the catalogue item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Item Specification Update Line. Seller_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Item Specification Update Line
    /// <para />PropertyTermQualifier: Seller
    /// <para />PropertyTerm: Supplier Party
    /// <para />AssociatedObjectClass: Supplier Party
    /// <para />RepresentationTerm: Supplier Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SupplierPartyType SellerSupplierParty
    {
        get
        {
            if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
            return __SellerSupplierParty;
        }
        set
        {
            __SellerSupplierParty = value;
        }
    }

        
    /// <summary>
    /// The catalogue item to be updated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Item Specification Update Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Item Specification Update Line
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemType Item
    {
        get
        {
            if (__Item == null) { __Item = new ItemType(); }
            return __Item;
        }
        set
        {
            __Item = value;
        }
    }

}