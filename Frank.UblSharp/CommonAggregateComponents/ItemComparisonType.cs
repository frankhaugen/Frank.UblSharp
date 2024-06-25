using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to provide information about price and quantity of an item for use in price comparisons based on price, quantity, or measurements.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Comparison. Details
/// <para />ObjectClass: Item Comparison
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ItemComparison", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemComparison", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemComparisonType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__PriceAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__Quantity;
        
    /// <summary>
    /// The price for the Item Comparison
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Comparison. Price Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Comparison
    /// <para />PropertyTerm: Price Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PriceAmount
    {
        get
        {
            if (__PriceAmount == null) { __PriceAmount = new AmountType(); }
            return __PriceAmount;
        }
        set
        {
            __PriceAmount = value;
        }
    }

        
    /// <summary>
    /// The quantity for which this comparison is valid.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Comparison. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Comparison
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>per unit</example>
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

}