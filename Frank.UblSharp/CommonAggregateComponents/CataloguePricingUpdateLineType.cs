using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line describing a pricing update to a catalogue line.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Catalogue Pricing Update Line. Details
/// <para />ObjectClass: Catalogue Pricing Update Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CataloguePricingUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CataloguePricingUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CataloguePricingUpdateLineType
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
        
    private System.Collections.Generic.List<ItemLocationQuantityType> _requiredItemLocationQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity", Order=3)]
    public ItemLocationQuantityType[] @__RequiredItemLocationQuantity
    {
        get
        {
            return _requiredItemLocationQuantity?.ToArray();
        }
        set
        {
            _requiredItemLocationQuantity = value == null ? null : new System.Collections.Generic.List<ItemLocationQuantityType>(value);
        }
    }
        
    /// <summary>
    /// Updated properties of the item in this catalogue line that are dependent on location and quantity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Pricing Update Line. Required_ Item Location Quantity. Item Location Quantity
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Pricing Update Line
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Item Location Quantity
    /// <para />AssociatedObjectClass: Item Location Quantity
    /// <para />RepresentationTerm: Item Location Quantity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemLocationQuantityType> RequiredItemLocationQuantity
    {
        get { return _requiredItemLocationQuantity ?? (_requiredItemLocationQuantity = new System.Collections.Generic.List<ItemLocationQuantityType>()); }
        set { _requiredItemLocationQuantity = value; }
    }

        
    /// <summary>
    /// An identifier for the catalogue line to be updated.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Pricing Update Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Pricing Update Line
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
    /// The customer responsible for the contract associated with the catalogue line being updated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Pricing Update Line. Contractor_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Pricing Update Line
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
    /// The seller/supplier responsible for the contract associated with the catalogue line being updated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Pricing Update Line. Seller_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Pricing Update Line
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

}