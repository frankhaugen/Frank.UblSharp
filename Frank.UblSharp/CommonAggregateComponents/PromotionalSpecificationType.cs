using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a promotional event as a set of item locations that share a set of promotional tactics.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Promotional Specification. Details
/// <para />ObjectClass: Promotional Specification
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PromotionalSpecification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PromotionalSpecification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PromotionalSpecificationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecificationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__SpecificationID;
        
    private System.Collections.Generic.List<PromotionalEventLineItemType> _promotionalEventLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PromotionalEventLineItem", Order=1)]
    public PromotionalEventLineItemType[] @__PromotionalEventLineItem
    {
        get
        {
            return _promotionalEventLineItem?.ToArray();
        }
        set
        {
            _promotionalEventLineItem = value == null ? null : new System.Collections.Generic.List<PromotionalEventLineItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<EventTacticType> _eventTactic;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EventTactic", Order=2)]
    public EventTacticType[] @__EventTactic
    {
        get
        {
            return _eventTactic?.ToArray();
        }
        set
        {
            _eventTactic = value == null ? null : new System.Collections.Generic.List<EventTacticType>(value);
        }
    }
        
    /// <summary>
    /// A line item for a promotional event involving a specific product at a specific location; it describes the expected impacts associated with the event and specifies the promotional price of the item.&quot;
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Promotional Specification. Promotional Event Line Item
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Promotional Specification
    /// <para />PropertyTerm: Promotional Event Line Item
    /// <para />AssociatedObjectClass: Promotional Event Line Item
    /// <para />RepresentationTerm: Promotional Event Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PromotionalEventLineItemType> PromotionalEventLineItem
    {
        get { return _promotionalEventLineItem ?? (_promotionalEventLineItem = new System.Collections.Generic.List<PromotionalEventLineItemType>()); }
        set { _promotionalEventLineItem = value; }
    }

        
    /// <summary>
    /// An event tactic associated with this promotion.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Promotional Specification. Event Tactic
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Promotional Specification
    /// <para />PropertyTerm: Event Tactic
    /// <para />AssociatedObjectClass: Event Tactic
    /// <para />RepresentationTerm: Event Tactic
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EventTacticType> EventTactic
    {
        get { return _eventTactic ?? (_eventTactic = new System.Collections.Generic.List<EventTacticType>()); }
        set { _eventTactic = value; }
    }

        
    /// <summary>
    /// An identifier for this promotional specification.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Promotional Specification. Specification Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Promotional Specification
    /// <para />PropertyTerm: Specification Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SpecificationID
    {
        get
        {
            if (__SpecificationID == null) { __SpecificationID = new IdentifierType(); }
            return __SpecificationID;
        }
        set
        {
            __SpecificationID = value;
        }
    }

}