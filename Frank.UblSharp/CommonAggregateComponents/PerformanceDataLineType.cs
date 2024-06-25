using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Performance History.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Performance Data Line. Details
/// <para />ObjectClass: Performance Data Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PerformanceDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PerformanceDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PerformanceDataLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__Note
    {
        get
        {
            return _note?.ToArray();
        }
        set
        {
            _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerformanceValueQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__PerformanceValueQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerformanceMetricTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__PerformanceMetricTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=4)]
    public PeriodType @__Period;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=5)]
    public ItemType @__Item;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Performance Data Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Performance Data Line
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// An identifier for this performance data line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Performance Data Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Performance Data Line
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// The value of the reported attribute.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Performance Data Line. Performance Value. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Performance Data Line
    /// <para />PropertyTerm: Performance Value
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType PerformanceValueQuantity
    {
        get
        {
            if (__PerformanceValueQuantity == null) { __PerformanceValueQuantity = new QuantityType(); }
            return __PerformanceValueQuantity;
        }
        set
        {
            __PerformanceValueQuantity = value;
        }
    }

        
    /// <summary>
    /// A code signifying the measure of performance applicable to the reported attribute.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Performance Data Line. Performance Metric Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Performance Data Line
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

        
    /// <summary>
    /// The period to which this performance data line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Performance Data Line. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Performance Data Line
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

        
    /// <summary>
    /// The item whose performance is reported in this data line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Performance Data Line. Item
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Performance Data Line
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

}