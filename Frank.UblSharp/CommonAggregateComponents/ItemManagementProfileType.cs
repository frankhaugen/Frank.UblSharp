using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a management profile for an item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Management Profile. Details
/// <para />ObjectClass: Item Management Profile
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ItemManagementProfile", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemManagementProfile", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemManagementProfileType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FrozenPeriodDaysNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NumericType @__FrozenPeriodDaysNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumInventoryQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__MinimumInventoryQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MultipleOrderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__MultipleOrderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderIntervalDaysNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public NumericType @__OrderIntervalDaysNumeric;
        
    private System.Collections.Generic.List<TextType> _replenishmentOwnerDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReplenishmentOwnerDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__ReplenishmentOwnerDescription
    {
        get
        {
            return _replenishmentOwnerDescription?.ToArray();
        }
        set
        {
            _replenishmentOwnerDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TargetServicePercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public PercentType @__TargetServicePercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TargetInventoryQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public QuantityType @__TargetInventoryQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EffectivePeriod", Order=7)]
    public PeriodType @__EffectivePeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=8)]
    public ItemType @__Item;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemLocationQuantity", Order=9)]
    public ItemLocationQuantityType @__ItemLocationQuantity;
        
    /// <summary>
    /// The trading partner maintaining this item management profile.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Management Profile. Replenishment Owner Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTerm: Replenishment Owner Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ReplenishmentOwnerDescription
    {
        get { return _replenishmentOwnerDescription ?? (_replenishmentOwnerDescription = new System.Collections.Generic.List<TextType>()); }
        set { _replenishmentOwnerDescription = value; }
    }

        
    /// <summary>
    /// The number of days in the future that an order forecast quantity automatically becomes a confirmed order for a product.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Management Profile. Frozen Period Days. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTerm: Frozen Period Days
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType FrozenPeriodDaysNumeric
    {
        get
        {
            if (__FrozenPeriodDaysNumeric == null) { __FrozenPeriodDaysNumeric = new NumericType(); }
            return __FrozenPeriodDaysNumeric;
        }
        set
        {
            __FrozenPeriodDaysNumeric = value;
        }
    }

        
    /// <summary>
    /// The quantity of the item that should trigger a replenishment order to avoid depleting the safety stock.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Management Profile. Minimum_ Inventory Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Inventory Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumInventoryQuantity
    {
        get
        {
            if (__MinimumInventoryQuantity == null) { __MinimumInventoryQuantity = new QuantityType(); }
            return __MinimumInventoryQuantity;
        }
        set
        {
            __MinimumInventoryQuantity = value;
        }
    }

        
    /// <summary>
    /// The order quantity multiples in which the product may be ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Management Profile. Multiple_ Order Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTermQualifier: Multiple
    /// <para />PropertyTerm: Order Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MultipleOrderQuantity
    {
        get
        {
            if (__MultipleOrderQuantity == null) { __MultipleOrderQuantity = new QuantityType(); }
            return __MultipleOrderQuantity;
        }
        set
        {
            __MultipleOrderQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of days between regular replenishment orders for the product.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Management Profile. Order Interval Days. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTerm: Order Interval Days
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType OrderIntervalDaysNumeric
    {
        get
        {
            if (__OrderIntervalDaysNumeric == null) { __OrderIntervalDaysNumeric = new NumericType(); }
            return __OrderIntervalDaysNumeric;
        }
        set
        {
            __OrderIntervalDaysNumeric = value;
        }
    }

        
    /// <summary>
    /// The Unit Service Level the trading partners expect to be maintained, expressed as a percentage. Unite Service Level (USL) is a term used in Inventory Management, which is sometimes known as &quot;fill rate&quot;, counts the average number of units short expressed as the percentage of the order quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Management Profile. Target Service Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTerm: Target Service Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType TargetServicePercent
    {
        get
        {
            if (__TargetServicePercent == null) { __TargetServicePercent = new PercentType(); }
            return __TargetServicePercent;
        }
        set
        {
            __TargetServicePercent = value;
        }
    }

        
    /// <summary>
    /// The target inventory quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Management Profile. Target_ Inventory Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTermQualifier: Target
    /// <para />PropertyTerm: Inventory Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TargetInventoryQuantity
    {
        get
        {
            if (__TargetInventoryQuantity == null) { __TargetInventoryQuantity = new QuantityType(); }
            return __TargetInventoryQuantity;
        }
        set
        {
            __TargetInventoryQuantity = value;
        }
    }

        
    /// <summary>
    /// The period during which this profile is effective.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Management Profile. Effective_ Period. Period
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTermQualifier: Effective
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType EffectivePeriod
    {
        get
        {
            if (__EffectivePeriod == null) { __EffectivePeriod = new PeriodType(); }
            return __EffectivePeriod;
        }
        set
        {
            __EffectivePeriod = value;
        }
    }

        
    /// <summary>
    /// The item associated with this item management profile.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Management Profile. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Item Management Profile
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

        
    /// <summary>
    /// A set of location-specific properties (e.g., price and quantity) associated with the item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Management Profile. Item Location Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Management Profile
    /// <para />PropertyTerm: Item Location Quantity
    /// <para />AssociatedObjectClass: Item Location Quantity
    /// <para />RepresentationTerm: Item Location Quantity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemLocationQuantityType ItemLocationQuantity
    {
        get
        {
            if (__ItemLocationQuantity == null) { __ItemLocationQuantity = new ItemLocationQuantityType(); }
            return __ItemLocationQuantity;
        }
        set
        {
            __ItemLocationQuantity = value;
        }
    }

}