using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a delivery unit.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Delivery Unit. Details
/// <para />ObjectClass: Delivery Unit
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DeliveryUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DeliveryUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DeliveryUnitType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BatchQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public QuantityType @__BatchQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumerUnitQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__ConsumerUnitQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousRiskIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IndicatorType @__HazardousRiskIndicator;
        
    /// <summary>
    /// The quantity of ordered Items that constitutes a batch for delivery purposes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Unit. Batch Quantity. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Delivery Unit
    /// <para />PropertyTerm: Batch Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>100 units , by the dozen</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType BatchQuantity
    {
        get
        {
            if (__BatchQuantity == null) { __BatchQuantity = new QuantityType(); }
            return __BatchQuantity;
        }
        set
        {
            __BatchQuantity = value;
        }
    }

        
    /// <summary>
    /// The quantity of units in the Delivery Unit expressed in the units used by the consumer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Unit. Consumer_ Unit. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery Unit
    /// <para />PropertyTermQualifier: Consumer
    /// <para />PropertyTerm: Unit
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>packs of 10</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ConsumerUnitQuantity
    {
        get
        {
            if (__ConsumerUnitQuantity == null) { __ConsumerUnitQuantity = new QuantityType(); }
            return __ConsumerUnitQuantity;
        }
        set
        {
            __ConsumerUnitQuantity = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported goods are subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Unit. Hazardous Risk_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery Unit
    /// <para />PropertyTermQualifier: Hazardous Risk
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>Default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType HazardousRiskIndicator
    {
        get
        {
            if (__HazardousRiskIndicator == null) { __HazardousRiskIndicator = new IndicatorType(); }
            return __HazardousRiskIndicator;
        }
        set
        {
            __HazardousRiskIndicator = value;
        }
    }

}