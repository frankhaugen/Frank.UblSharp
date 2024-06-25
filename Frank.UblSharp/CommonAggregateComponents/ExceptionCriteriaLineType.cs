using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in an ExceptionCriteria document that specifies a threshold for forecast variance, product activity, or performance history, the exceeding of which should trigger an exception message.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Exception Criteria Line. Details
/// <para />ObjectClass: Exception Criteria Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ExceptionCriteriaLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ExceptionCriteriaLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ExceptionCriteriaLineType
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
    [System.Xml.Serialization.XmlElementAttribute("ThresholdValueComparisonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ThresholdValueComparisonCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ThresholdQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__ThresholdQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExceptionStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__ExceptionStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CollaborationPriorityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__CollaborationPriorityCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExceptionResolutionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__ExceptionResolutionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplyChainActivityTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__SupplyChainActivityTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerformanceMetricTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public CodeType @__PerformanceMetricTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EffectivePeriod", Order=9)]
    public PeriodType @__EffectivePeriod;
        
    private System.Collections.Generic.List<ItemType> _supplyItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplyItem", Order=10)]
    public ItemType[] @__SupplyItem
    {
        get
        {
            return _supplyItem?.ToArray();
        }
        set
        {
            _supplyItem = value == null ? null : new System.Collections.Generic.List<ItemType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastExceptionCriterionLine", Order=11)]
    public ForecastExceptionCriterionLineType @__ForecastExceptionCriterionLine;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Exception Criteria Line
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
    /// The Trade Item that is the subject of the Exception Criterion.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Supply_ Item. Item
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTermQualifier: Supply
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemType> SupplyItem
    {
        get { return _supplyItem ?? (_supplyItem = new System.Collections.Generic.List<ItemType>()); }
        set { _supplyItem = value; }
    }

        
    /// <summary>
    /// An identifier for this exception criteria line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exception Criteria Line
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
    /// Type of comparison to be carried out in reference to the set threshold.&quot; Allowed values are: EXCEEDS_EXCEPTION_VALUE FALLS_BELOW_EXCEPTION_VALUE
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Threshold Value Comparison Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTerm: Threshold Value Comparison Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ThresholdValueComparisonCode
    {
        get
        {
            if (__ThresholdValueComparisonCode == null) { __ThresholdValueComparisonCode = new CodeType(); }
            return __ThresholdValueComparisonCode;
        }
        set
        {
            __ThresholdValueComparisonCode = value;
        }
    }

        
    /// <summary>
    /// A quantity beyond which an exception will be triggered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Threshold_ Quantity. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTermQualifier: Threshold
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ThresholdQuantity
    {
        get
        {
            if (__ThresholdQuantity == null) { __ThresholdQuantity = new QuantityType(); }
            return __ThresholdQuantity;
        }
        set
        {
            __ThresholdQuantity = value;
        }
    }

        
    /// <summary>
    /// A code signifying status specific to a shipment exception.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Exception Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTerm: Exception Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ExceptionStatusCode
    {
        get
        {
            if (__ExceptionStatusCode == null) { __ExceptionStatusCode = new CodeType(); }
            return __ExceptionStatusCode;
        }
        set
        {
            __ExceptionStatusCode = value;
        }
    }

        
    /// <summary>
    /// A collaboratively assigned code signifying priority of the Exception. Possible values are: HIGH, LOW, MEDIUM
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Collaboration_ Priority Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTermQualifier: Collaboration
    /// <para />PropertyTerm: Priority Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CollaborationPriorityCode
    {
        get
        {
            if (__CollaborationPriorityCode == null) { __CollaborationPriorityCode = new CodeType(); }
            return __CollaborationPriorityCode;
        }
        set
        {
            __CollaborationPriorityCode = value;
        }
    }

        
    /// <summary>
    /// Coded representation of possible resolution methods&quot;. Possible values are: DEFAULT_TO_AVERAGE_OF_COMPARED_VALUES DEFAULT_TO_BUYERS_VALUE DEFAULT_TO_HIGH_VALUE DEFAULT_TO_LOW_VALUE DEFAULT_TO_SELLERS_VALUE MANUAL_RESOLUTION MUTUALLY_DEFINED
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Exception_ Resolution Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTermQualifier: Exception
    /// <para />PropertyTerm: Resolution Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ExceptionResolutionCode
    {
        get
        {
            if (__ExceptionResolutionCode == null) { __ExceptionResolutionCode = new CodeType(); }
            return __ExceptionResolutionCode;
        }
        set
        {
            __ExceptionResolutionCode = value;
        }
    }

        
    /// <summary>
    /// Establishes the criterion for one of the three types of exceptions. There can be three types of exception criteria: Operational, Metric and Forecast Exceptions. This will be set if this Exception is about an Operational Exception. Description could be: A code used to identify an operational exception. Possible values are: CANCELED_ORDERS EMERGENCY_ORDERS ON_HAND ORDERS RECEIPTS SALES SHIPMENTS
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Supply Chain Activity Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Criteria Line
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
    /// A code signifying a measure of performance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Performance Metric Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Criteria Line
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
    /// The period during which this exception criteria line is in effect.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Effective_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTermQualifier: Effective
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType EffectivePeriod
    {
        get
        {
            if (__EffectivePeriod == null) { __EffectivePeriod = new PeriodType(); }
            return __EffectivePeriod;
        }
        set
        {
            __EffectivePeriod = value;
        }
    }

        
    /// <summary>
    /// Establishes the criterion for one of the three types of exceptions. This class provides the criterion for the kind of forecast exception, the identification of the purpose of the forecast, the source of data and the time basis criterion for the exception.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exception Criteria Line. Forecast Exception Criterion Line
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Criteria Line
    /// <para />PropertyTerm: Forecast Exception Criterion Line
    /// <para />AssociatedObjectClass: Forecast Exception Criterion Line
    /// <para />RepresentationTerm: Forecast Exception Criterion Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ForecastExceptionCriterionLineType ForecastExceptionCriterionLine
    {
        get
        {
            if (__ForecastExceptionCriterionLine == null) { __ForecastExceptionCriterionLine = new ForecastExceptionCriterionLineType(); }
            return __ForecastExceptionCriterionLine;
        }
        set
        {
            __ForecastExceptionCriterionLine = value;
        }
    }

}