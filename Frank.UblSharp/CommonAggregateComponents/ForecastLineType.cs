using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// Detailed information about a particular Forecast Line within a Forecast Document
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Forecast Line. Details
/// <para />ObjectClass: Forecast Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ForecastLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ForecastLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ForecastLineType
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
    [System.Xml.Serialization.XmlElementAttribute("FrozenDocumentIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IndicatorType @__FrozenDocumentIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__ForecastTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastPeriod", Order=4)]
    public PeriodType @__ForecastPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SalesItem", Order=5)]
    public SalesItemType @__SalesItem;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Forecast Line
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
    /// An identifier for this forecast line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Line
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
    /// An indicator that the status of the forecast is modifiable (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Line. Frozen Document Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Line
    /// <para />PropertyTerm: Frozen Document Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType FrozenDocumentIndicator
    {
        get
        {
            if (__FrozenDocumentIndicator == null) { __FrozenDocumentIndicator = new IndicatorType(); }
            return __FrozenDocumentIndicator;
        }
        set
        {
            __FrozenDocumentIndicator = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of forecast. Examples: BASE PROMOTIONAL SEASONAL TOTAL
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Line. Forecast Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Line
    /// <para />PropertyTerm: Forecast Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>seasonal, total</example>
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
    /// The period to which the forecast applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Forecast Line. Forecast_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Line
    /// <para />PropertyTermQualifier: Forecast
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ForecastPeriod
    {
        get
        {
            if (__ForecastPeriod == null) { __ForecastPeriod = new PeriodType(); }
            return __ForecastPeriod;
        }
        set
        {
            __ForecastPeriod = value;
        }
    }

        
    /// <summary>
    /// Sales information for the item to which this line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Forecast Line. Sales Item
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Line
    /// <para />PropertyTerm: Sales Item
    /// <para />AssociatedObjectClass: Sales Item
    /// <para />RepresentationTerm: Sales Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SalesItemType SalesItem
    {
        get
        {
            if (__SalesItem == null) { __SalesItem = new SalesItemType(); }
            return __SalesItem;
        }
        set
        {
            __SalesItem = value;
        }
    }

}