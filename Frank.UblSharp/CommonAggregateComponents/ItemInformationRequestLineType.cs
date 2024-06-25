using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in an Item Information Request asking a trading partner for item information.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Information Request Line. Details
/// <para />ObjectClass: Item Information Request Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ItemInformationRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemInformationRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemInformationRequestLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TimeFrequencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__TimeFrequencyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplyChainActivityTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__SupplyChainActivityTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ForecastTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerformanceMetricTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__PerformanceMetricTypeCode;
        
    private System.Collections.Generic.List<PeriodType> _period;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=4)]
    public PeriodType[] @__Period
    {
        get
        {
            return _period?.ToArray();
        }
        set
        {
            _period = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
        }
    }
        
    private System.Collections.Generic.List<SalesItemType> _salesItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SalesItem", Order=5)]
    public SalesItemType[] @__SalesItem
    {
        get
        {
            return _salesItem?.ToArray();
        }
        set
        {
            _salesItem = value == null ? null : new System.Collections.Generic.List<SalesItemType>(value);
        }
    }
        
    /// <summary>
    /// A period for which this information is requested.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Information Request Line. Period
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Item Information Request Line
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PeriodType> Period
    {
        get { return _period ?? (_period = new System.Collections.Generic.List<PeriodType>()); }
        set { _period = value; }
    }

        
    /// <summary>
    /// Sales information for the item to which this line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Information Request Line. Sales Item
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Item Information Request Line
    /// <para />PropertyTerm: Sales Item
    /// <para />AssociatedObjectClass: Sales Item
    /// <para />RepresentationTerm: Sales Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<SalesItemType> SalesItem
    {
        get { return _salesItem ?? (_salesItem = new System.Collections.Generic.List<SalesItemType>()); }
        set { _salesItem = value; }
    }

        
    /// <summary>
    /// A code signifying the frequency with which item information should be sent to the requester.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Information Request Line. Time Frequency Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Information Request Line
    /// <para />PropertyTerm: Time Frequency Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TimeFrequencyCode
    {
        get
        {
            if (__TimeFrequencyCode == null) { __TimeFrequencyCode = new CodeType(); }
            return __TimeFrequencyCode;
        }
        set
        {
            __TimeFrequencyCode = value;
        }
    }

        
    /// <summary>
    /// A code used to identify the type of supply chain activity about which information request is issued. Examples: CANCELED_ORDERS EMERGENCY_ORDERS ON_HAND ORDERS
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Information Request Line. Supply Chain Activity Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Information Request Line
    /// <para />PropertyTerm: Supply Chain Activity Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SupplyChainActivityTypeCode
    {
        get
        {
            if (__SupplyChainActivityTypeCode == null) { __SupplyChainActivityTypeCode = new CodeType(); }
            return __SupplyChainActivityTypeCode;
        }
        set
        {
            __SupplyChainActivityTypeCode = value;
        }
    }

        
    /// <summary>
    /// The information request can be either about supply chain activity or about forecasts or about performance metrics, so it should be optional
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Information Request Line. Forecast Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Information Request Line
    /// <para />PropertyTerm: Forecast Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ForecastTypeCode
    {
        get
        {
            if (__ForecastTypeCode == null) { __ForecastTypeCode = new CodeType(); }
            return __ForecastTypeCode;
        }
        set
        {
            __ForecastTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying a measure of performance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Information Request Line. Performance Metric Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Information Request Line
    /// <para />PropertyTerm: Performance Metric Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PerformanceMetricTypeCode
    {
        get
        {
            if (__PerformanceMetricTypeCode == null) { __PerformanceMetricTypeCode = new CodeType(); }
            return __PerformanceMetricTypeCode;
        }
        set
        {
            __PerformanceMetricTypeCode = value;
        }
    }

}