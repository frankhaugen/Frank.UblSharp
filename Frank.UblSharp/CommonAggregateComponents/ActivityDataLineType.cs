using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to associate a time period and locations (activity data) with an item for inventory planning purposes.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Activity Data Line. Details
/// <para />ObjectClass: Activity Data Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ActivityDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActivityDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ActivityDataLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplyChainActivityTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__SupplyChainActivityTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuyerCustomerParty", Order=2)]
    public CustomerPartyType @__BuyerCustomerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Order=3)]
    public SupplierPartyType @__SellerSupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActivityPeriod", Order=4)]
    public PeriodType @__ActivityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActivityOriginLocation", Order=5)]
    public LocationType @__ActivityOriginLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActivityFinalLocation", Order=6)]
    public LocationType @__ActivityFinalLocation;
        
    private System.Collections.Generic.List<SalesItemType> _salesItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SalesItem", Order=7)]
    public SalesItemType[] @__SalesItem
    {
        get
        {
            return _salesItem?.ToArray();
        }
        set
        {
            _salesItem = value == null ? null : new System.Collections.Generic.List<SalesItemType>(value);
        }
    }
        
    /// <summary>
    /// Sales information for an item to which this line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Activity Data Line. Sales Item
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Activity Data Line
    /// <para />PropertyTerm: Sales Item
    /// <para />AssociatedObjectClass: Sales Item
    /// <para />RepresentationTerm: Sales Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<SalesItemType> SalesItem
    {
        get { return _salesItem ?? (_salesItem = new System.Collections.Generic.List<SalesItemType>()); }
        set { _salesItem = value; }
    }

        
    /// <summary>
    /// An identifier for this activity data line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Activity Data Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Activity Data Line
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
    /// A code signifying the type of supply chain activity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Activity Data Line. Supply Chain Activity Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Activity Data Line
    /// <para />PropertyTerm: Supply Chain Activity Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SupplyChainActivityTypeCode
    {
        get
        {
            if (__SupplyChainActivityTypeCode == null) { __SupplyChainActivityTypeCode = new CodeType(); }
            return __SupplyChainActivityTypeCode;
        }
        set
        {
            __SupplyChainActivityTypeCode = value;
        }
    }

        
    /// <summary>
    /// The buyer of the item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Activity Data Line. Buyer_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Activity Data Line
    /// <para />PropertyTermQualifier: Buyer
    /// <para />PropertyTerm: Customer Party
    /// <para />AssociatedObjectClass: Customer Party
    /// <para />RepresentationTerm: Customer Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CustomerPartyType BuyerCustomerParty
    {
        get
        {
            if (__BuyerCustomerParty == null) { __BuyerCustomerParty = new CustomerPartyType(); }
            return __BuyerCustomerParty;
        }
        set
        {
            __BuyerCustomerParty = value;
        }
    }

        
    /// <summary>
    /// The seller of the item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Activity Data Line. Seller_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Activity Data Line
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
    /// The period during which the activity is realized.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Activity Data Line. Activity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Activity Data Line
    /// <para />PropertyTermQualifier: Activity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ActivityPeriod
    {
        get
        {
            if (__ActivityPeriod == null) { __ActivityPeriod = new PeriodType(); }
            return __ActivityPeriod;
        }
        set
        {
            __ActivityPeriod = value;
        }
    }

        
    /// <summary>
    /// Either the location where the movement of goods is observed or the location from which the goods are moved.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Activity Data Line. Activity Origin_ Location. Location
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Activity Data Line
    /// <para />PropertyTermQualifier: Activity Origin
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType ActivityOriginLocation
    {
        get
        {
            if (__ActivityOriginLocation == null) { __ActivityOriginLocation = new LocationType(); }
            return __ActivityOriginLocation;
        }
        set
        {
            __ActivityOriginLocation = value;
        }
    }

        
    /// <summary>
    /// The location to which the goods are moved.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Activity Data Line. Activity Final_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Activity Data Line
    /// <para />PropertyTermQualifier: Activity Final
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType ActivityFinalLocation
    {
        get
        {
            if (__ActivityFinalLocation == null) { __ActivityFinalLocation = new LocationType(); }
            return __ActivityFinalLocation;
        }
        set
        {
            __ActivityFinalLocation = value;
        }
    }

}