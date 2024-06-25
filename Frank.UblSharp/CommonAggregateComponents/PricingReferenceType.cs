namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A reference to the basis for pricing. This may be based on a catalogue or a quoted amount from a price list and include some alternative pricing conditions.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Pricing Reference. Details
/// <para />ObjectClass: Pricing Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PricingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PricingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PricingReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginalItemLocationQuantity", Order=0)]
    public ItemLocationQuantityType @__OriginalItemLocationQuantity;
        
    private System.Collections.Generic.List<PriceType> _alternativeConditionPrice;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice", Order=1)]
    public PriceType[] @__AlternativeConditionPrice
    {
        get
        {
            return _alternativeConditionPrice?.ToArray();
        }
        set
        {
            _alternativeConditionPrice = value == null ? null : new System.Collections.Generic.List<PriceType>(value);
        }
    }
        
    /// <summary>
    /// The price expressed in terms other than the actual price, e.g., the list price v. the contracted price, or the price in bags v. the price in kilos, or the list price in bags v. the contracted price in kilos.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Pricing Reference. Alternative Condition_ Price. Price
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Pricing Reference
    /// <para />PropertyTermQualifier: Alternative Condition
    /// <para />PropertyTerm: Price
    /// <para />AssociatedObjectClass: Price
    /// <para />RepresentationTerm: Price
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PriceType> AlternativeConditionPrice
    {
        get { return _alternativeConditionPrice ?? (_alternativeConditionPrice = new System.Collections.Generic.List<PriceType>()); }
        set { _alternativeConditionPrice = value; }
    }

        
    /// <summary>
    /// An original set of location-specific properties (e.g., price and quantity) associated with this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Pricing Reference. Original_ Item Location Quantity. Item Location Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pricing Reference
    /// <para />PropertyTermQualifier: Original
    /// <para />PropertyTerm: Item Location Quantity
    /// <para />AssociatedObjectClass: Item Location Quantity
    /// <para />RepresentationTerm: Item Location Quantity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemLocationQuantityType OriginalItemLocationQuantity
    {
        get
        {
            if (__OriginalItemLocationQuantity == null) { __OriginalItemLocationQuantity = new ItemLocationQuantityType(); }
            return __OriginalItemLocationQuantity;
        }
        set
        {
            __OriginalItemLocationQuantity = value;
        }
    }

}