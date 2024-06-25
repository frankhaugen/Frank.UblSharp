using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a line item associated with a promotional event.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Promotional Event Line Item. Details
/// <para />ObjectClass: Promotional Event Line Item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PromotionalEventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PromotionalEventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PromotionalEventLineItemType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EventLineItem", Order=1)]
    public EventLineItemType @__EventLineItem;
        
    /// <summary>
    /// The amount associated with this promotional event line item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Promotional Event Line Item. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Promotional Event Line Item
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType Amount
    {
        get
        {
            if (__Amount == null) { __Amount = new AmountType(); }
            return __Amount;
        }
        set
        {
            __Amount = value;
        }
    }

        
    /// <summary>
    /// A line item describing the expected impacts associated with this promotional event for a specific product at a specific location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Promotional Event Line Item. Event Line Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Promotional Event Line Item
    /// <para />PropertyTerm: Event Line Item
    /// <para />AssociatedObjectClass: Event Line Item
    /// <para />RepresentationTerm: Event Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public EventLineItemType EventLineItem
    {
        get
        {
            if (__EventLineItem == null) { __EventLineItem = new EventLineItemType(); }
            return __EventLineItem;
        }
        set
        {
            __EventLineItem = value;
        }
    }

}