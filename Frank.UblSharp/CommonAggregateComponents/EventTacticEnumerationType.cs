using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a set of codes that describes a retail tactic.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Event Tactic Enumeration. Details
/// <para />ObjectClass: Event Tactic Enumeration
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EventTacticEnumeration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EventTacticEnumeration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EventTacticEnumerationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumerIncentiveTacticTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__ConsumerIncentiveTacticTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DisplayTacticTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__DisplayTacticTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FeatureTacticTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__FeatureTacticTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TradeItemPackingLabelingTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__TradeItemPackingLabelingTypeCode;
        
    /// <summary>
    /// A code signifying the type of consumer incentive. Examples include:Free Item, Temporary Price reduction
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Tactic Enumeration. Consumer Incentive Tactic Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Tactic Enumeration
    /// <para />PropertyTerm: Consumer Incentive Tactic Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ConsumerIncentiveTacticTypeCode
    {
        get
        {
            if (__ConsumerIncentiveTacticTypeCode == null) { __ConsumerIncentiveTacticTypeCode = new CodeType(); }
            return __ConsumerIncentiveTacticTypeCode;
        }
        set
        {
            __ConsumerIncentiveTacticTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of display. Examples Include: ON_COUNTER_DISPLAY, FLOOR_GRAPHICS FLOOR_STACK_DISPLAY
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Tactic Enumeration. Display Tactic Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Tactic Enumeration
    /// <para />PropertyTerm: Display Tactic Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DisplayTacticTypeCode
    {
        get
        {
            if (__DisplayTacticTypeCode == null) { __DisplayTacticTypeCode = new CodeType(); }
            return __DisplayTacticTypeCode;
        }
        set
        {
            __DisplayTacticTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying a special feature. Examples Include: BILLBOARD DIRECT_MAIL_AD, FLYER
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Tactic Enumeration. Feature Tactic Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Tactic Enumeration
    /// <para />PropertyTerm: Feature Tactic Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType FeatureTacticTypeCode
    {
        get
        {
            if (__FeatureTacticTypeCode == null) { __FeatureTacticTypeCode = new CodeType(); }
            return __FeatureTacticTypeCode;
        }
        set
        {
            __FeatureTacticTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of trade item packing and labeling. Examples Include: BONUS_SIZE CO_BRANDED_TRADE_ITEM
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Tactic Enumeration. Trade Item Packing Labeling Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Tactic Enumeration
    /// <para />PropertyTerm: Trade Item Packing Labeling Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TradeItemPackingLabelingTypeCode
    {
        get
        {
            if (__TradeItemPackingLabelingTypeCode == null) { __TradeItemPackingLabelingTypeCode = new CodeType(); }
            return __TradeItemPackingLabelingTypeCode;
        }
        set
        {
            __TradeItemPackingLabelingTypeCode = value;
        }
    }

}