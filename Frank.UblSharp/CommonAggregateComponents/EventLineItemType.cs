using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line item describing the expected impacts associated with a retail event involving a specific product at a specific location.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Event Line Item. Details
/// <para />ObjectClass: Event Line Item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EventLineItemType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineNumberNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NumericType @__LineNumberNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ParticipatingLocationsLocation", Order=1)]
    public LocationType @__ParticipatingLocationsLocation;
        
    private System.Collections.Generic.List<RetailPlannedImpactType> _retailPlannedImpact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RetailPlannedImpact", Order=2)]
    public RetailPlannedImpactType[] @__RetailPlannedImpact
    {
        get
        {
            return _retailPlannedImpact?.ToArray();
        }
        set
        {
            _retailPlannedImpact = value == null ? null : new System.Collections.Generic.List<RetailPlannedImpactType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplyItem", Order=3)]
    public ItemType @__SupplyItem;
        
    /// <summary>
    /// A planned impact of the event described in this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event Line Item. Retail Planned Impact
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Event Line Item
    /// <para />PropertyTerm: Retail Planned Impact
    /// <para />AssociatedObjectClass: Retail Planned Impact
    /// <para />RepresentationTerm: Retail Planned Impact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RetailPlannedImpactType> RetailPlannedImpact
    {
        get { return _retailPlannedImpact ?? (_retailPlannedImpact = new System.Collections.Generic.List<RetailPlannedImpactType>()); }
        set { _retailPlannedImpact = value; }
    }

        
    /// <summary>
    /// The number of this event line item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Line Item. Line Number. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Line Item
    /// <para />PropertyTerm: Line Number
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType LineNumberNumeric
    {
        get
        {
            if (__LineNumberNumeric == null) { __LineNumberNumeric = new NumericType(); }
            return __LineNumberNumeric;
        }
        set
        {
            __LineNumberNumeric = value;
        }
    }

        
    /// <summary>
    /// The location of the stores involved in the event described in this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event Line Item. Participating Locations_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Line Item
    /// <para />PropertyTermQualifier: Participating Locations
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType ParticipatingLocationsLocation
    {
        get
        {
            if (__ParticipatingLocationsLocation == null) { __ParticipatingLocationsLocation = new LocationType(); }
            return __ParticipatingLocationsLocation;
        }
        set
        {
            __ParticipatingLocationsLocation = value;
        }
    }

        
    /// <summary>
    /// The product with which the event is associated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event Line Item. Supply_ Item. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Event Line Item
    /// <para />PropertyTermQualifier: Supply
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemType SupplyItem
    {
        get
        {
            if (__SupplyItem == null) { __SupplyItem = new ItemType(); }
            return __SupplyItem;
        }
        set
        {
            __SupplyItem = value;
        }
    }

}