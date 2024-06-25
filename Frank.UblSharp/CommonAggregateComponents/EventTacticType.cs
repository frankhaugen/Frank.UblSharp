using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class defining a specific type of action or situation arranged by the Buyer or the Seller to promote the product or products.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Event Tactic. Details
/// <para />ObjectClass: Event Tactic
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EventTactic", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EventTactic", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EventTacticType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Comment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__Comment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EventTacticEnumeration", Order=2)]
    public EventTacticEnumerationType @__EventTacticEnumeration;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=3)]
    public PeriodType @__Period;
        
    /// <summary>
    /// Generic field to add additional information or to specify mutually defined eventTacticTypes that are not currently listed.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Tactic. Comment. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Tactic
    /// <para />PropertyTerm: Comment
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Comment
    {
        get
        {
            if (__Comment == null) { __Comment = new TextType(); }
            return __Comment;
        }
        set
        {
            __Comment = value;
        }
    }

        
    /// <summary>
    /// The currencies, units, etc. that describes what is need for the event or promotion Usage example: Number of pallets per store for a stack display
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Tactic. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Tactic
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
    /// The set of codes that describes this event tactic.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event Tactic. Event Tactic Enumeration
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Event Tactic
    /// <para />PropertyTerm: Event Tactic Enumeration
    /// <para />AssociatedObjectClass: Event Tactic Enumeration
    /// <para />RepresentationTerm: Event Tactic Enumeration
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public EventTacticEnumerationType EventTacticEnumeration
    {
        get
        {
            if (__EventTacticEnumeration == null) { __EventTacticEnumeration = new EventTacticEnumerationType(); }
            return __EventTacticEnumeration;
        }
        set
        {
            __EventTacticEnumeration = value;
        }
    }

        
    /// <summary>
    /// The period covered by this event tactic.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event Tactic. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Tactic
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType Period
    {
        get
        {
            if (__Period == null) { __Period = new PeriodType(); }
            return __Period;
        }
        set
        {
            __Period = value;
        }
    }

}