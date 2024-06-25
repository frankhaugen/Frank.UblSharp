using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a miscellaneous event associated with a retail event.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Miscellaneous Event. Details
/// <para />ObjectClass: Miscellaneous Event
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("MiscellaneousEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("MiscellaneousEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class MiscellaneousEventType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MiscellaneousEventTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__MiscellaneousEventTypeCode;
        
    private System.Collections.Generic.List<EventLineItemType> _eventLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EventLineItem", Order=1)]
    public EventLineItemType[] @__EventLineItem
    {
        get
        {
            return _eventLineItem?.ToArray();
        }
        set
        {
            _eventLineItem = value == null ? null : new System.Collections.Generic.List<EventLineItemType>(value);
        }
    }
        
    /// <summary>
    /// An event line item for this miscellaneous retail event.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Miscellaneous Event. Event Line Item
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Miscellaneous Event
    /// <para />PropertyTerm: Event Line Item
    /// <para />AssociatedObjectClass: Event Line Item
    /// <para />RepresentationTerm: Event Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EventLineItemType> EventLineItem
    {
        get { return _eventLineItem ?? (_eventLineItem = new System.Collections.Generic.List<EventLineItemType>()); }
        set { _eventLineItem = value; }
    }

        
    /// <summary>
    /// A code signifying the type of this miscellaneous event. Examples are: ASSORTMENT_CHARGE DISASTER FORECAST_DECREASE FORECAST_INCREASE FREIGHT_FLOW_ALLOCATION INVENTORY_POLICY_CHANGE LOCATION_CLOSING LOCATION_OPENING OTHER OUT_OF_STOCK PACKAGING_LABELING_CHANGE PRICE_DECREASE PRICE_INCREASE STORE_FORMAT_OR_PLANOGRAM_CHANGE TEST_MARKET WEATHER
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Miscellaneous Event. Miscellaneous Event Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Miscellaneous Event
    /// <para />PropertyTerm: Miscellaneous Event Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType MiscellaneousEventTypeCode
    {
        get
        {
            if (__MiscellaneousEventTypeCode == null) { __MiscellaneousEventTypeCode = new CodeType(); }
            return __MiscellaneousEventTypeCode;
        }
        set
        {
            __MiscellaneousEventTypeCode = value;
        }
    }

}