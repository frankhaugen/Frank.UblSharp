using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe information related to an item in a sales context
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Sales Item. Details
/// <para />ObjectClass: Sales Item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SalesItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SalesItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class SalesItemType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public QuantityType @__Quantity;
        
    private System.Collections.Generic.List<ActivityPropertyType> _activityProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActivityProperty", Order=1)]
    public ActivityPropertyType[] @__ActivityProperty
    {
        get
        {
            return _activityProperty?.ToArray();
        }
        set
        {
            _activityProperty = value == null ? null : new System.Collections.Generic.List<ActivityPropertyType>(value);
        }
    }
        
    private System.Collections.Generic.List<PriceType> _taxExclusivePrice;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxExclusivePrice", Order=2)]
    public PriceType[] @__TaxExclusivePrice
    {
        get
        {
            return _taxExclusivePrice?.ToArray();
        }
        set
        {
            _taxExclusivePrice = value == null ? null : new System.Collections.Generic.List<PriceType>(value);
        }
    }
        
    private System.Collections.Generic.List<PriceType> _taxInclusivePrice;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxInclusivePrice", Order=3)]
    public PriceType[] @__TaxInclusivePrice
    {
        get
        {
            return _taxInclusivePrice?.ToArray();
        }
        set
        {
            _taxInclusivePrice = value == null ? null : new System.Collections.Generic.List<PriceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=4)]
    public ItemType @__Item;
        
    /// <summary>
    /// A class to describe the activity (for example &quot;sales&quot;, &quot;movement&quot;, ...) related to the item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Sales Item. Activity Property
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Sales Item
    /// <para />PropertyTerm: Activity Property
    /// <para />AssociatedObjectClass: Activity Property
    /// <para />RepresentationTerm: Activity Property
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ActivityPropertyType> ActivityProperty
    {
        get { return _activityProperty ?? (_activityProperty = new System.Collections.Generic.List<ActivityPropertyType>()); }
        set { _activityProperty = value; }
    }

        
    /// <summary>
    /// A price for this sales item, exclusive of tax.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Sales Item. Tax Exclusive_ Price. Price
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Sales Item
    /// <para />PropertyTermQualifier: Tax Exclusive
    /// <para />PropertyTerm: Price
    /// <para />AssociatedObjectClass: Price
    /// <para />RepresentationTerm: Price
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PriceType> TaxExclusivePrice
    {
        get { return _taxExclusivePrice ?? (_taxExclusivePrice = new System.Collections.Generic.List<PriceType>()); }
        set { _taxExclusivePrice = value; }
    }

        
    /// <summary>
    /// A price for this sales item, including tax.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Sales Item. Tax Inclusive_ Price. Price
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Sales Item
    /// <para />PropertyTermQualifier: Tax Inclusive
    /// <para />PropertyTerm: Price
    /// <para />AssociatedObjectClass: Price
    /// <para />RepresentationTerm: Price
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PriceType> TaxInclusivePrice
    {
        get { return _taxInclusivePrice ?? (_taxInclusivePrice = new System.Collections.Generic.List<PriceType>()); }
        set { _taxInclusivePrice = value; }
    }

        
    /// <summary>
    /// The quantity the given information are related to
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Sales Item. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Sales Item
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// The sales item itself.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Sales Item. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Sales Item
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