using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in an Exception Notification.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Exception Notification Line. Details
/// <para />ObjectClass: Exception Notification Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ExceptionNotificationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ExceptionNotificationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ExceptionNotificationLineType
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
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExceptionStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__ExceptionStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CollaborationPriorityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__CollaborationPriorityCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResolutionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__ResolutionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ComparedValueMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public MeasureType @__ComparedValueMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SourceValueMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public MeasureType @__SourceValueMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VarianceQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public QuantityType @__VarianceQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplyChainActivityTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public CodeType @__SupplyChainActivityTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerformanceMetricTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public CodeType @__PerformanceMetricTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExceptionObservationPeriod", Order=11)]
    public PeriodType @__ExceptionObservationPeriod;
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=12)]
    public DocumentReferenceType[] @__DocumentReference
    {
        get
        {
            return _documentReference?.ToArray();
        }
        set
        {
            _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastException", Order=13)]
    public ForecastExceptionType @__ForecastException;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplyItem", Order=14)]
    public ItemType @__SupplyItem;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Exception Notification Line
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
    /// Text describing the exception.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// A reference to Exception Criteria document can be provided.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
    {
        get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _documentReference = value; }
    }

        
    /// <summary>
    /// An identifier for this exception notification line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exception Notification Line
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
    /// A code signifying status specific to a shipment exception.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Exception Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
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
    /// Priority of Exception.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Collaboration_ Priority Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
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
    /// <para />DictionaryEntryName: Exception Notification Line. Resolution Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTerm: Resolution Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ResolutionCode
    {
        get
        {
            if (__ResolutionCode == null) { __ResolutionCode = new CodeType(); }
            return __ResolutionCode;
        }
        set
        {
            __ResolutionCode = value;
        }
    }

        
    /// <summary>
    /// The value that was compared with the source value that resulted in the exception
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Compared Value. Measure
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTerm: Compared Value
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType ComparedValueMeasure
    {
        get
        {
            if (__ComparedValueMeasure == null) { __ComparedValueMeasure = new MeasureType(); }
            return __ComparedValueMeasure;
        }
        set
        {
            __ComparedValueMeasure = value;
        }
    }

        
    /// <summary>
    /// The value used as the basis of comparison
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Source Value. Measure
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTerm: Source Value
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType SourceValueMeasure
    {
        get
        {
            if (__SourceValueMeasure == null) { __SourceValueMeasure = new MeasureType(); }
            return __SourceValueMeasure;
        }
        set
        {
            __SourceValueMeasure = value;
        }
    }

        
    /// <summary>
    /// The variance of a data item from an expected value during a particular time interval.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Variance. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTerm: Variance
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType VarianceQuantity
    {
        get
        {
            if (__VarianceQuantity == null) { __VarianceQuantity = new QuantityType(); }
            return __VarianceQuantity;
        }
        set
        {
            __VarianceQuantity = value;
        }
    }

        
    /// <summary>
    /// Establishes the criterion for one of the three types of exceptions: Operational, performance metric and forecast. This reports an exception notification about an operational exception. Description could be: A code used to identify an operational exception. Possible values are: CANCELED_ORDERS EMERGENCY_ORDERS ON_HAND ORDERS RECEIPTS SALES SHIPMENTS
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Supply Chain Activity Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
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
    /// A code used to identify a measure of performance. It defines the type of the Performance Metric on which an exception criteria is being defined
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Performance Metric Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
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
    /// The period (start-end date) when this exception is observed
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Exception Observation_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTermQualifier: Exception Observation
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ExceptionObservationPeriod
    {
        get
        {
            if (__ExceptionObservationPeriod == null) { __ExceptionObservationPeriod = new PeriodType(); }
            return __ExceptionObservationPeriod;
        }
        set
        {
            __ExceptionObservationPeriod = value;
        }
    }

        
    /// <summary>
    /// A forecast accuracy or comparison exception.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Forecast Exception
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTerm: Forecast Exception
    /// <para />AssociatedObjectClass: Forecast Exception
    /// <para />RepresentationTerm: Forecast Exception
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ForecastExceptionType ForecastException
    {
        get
        {
            if (__ForecastException == null) { __ForecastException = new ForecastExceptionType(); }
            return __ForecastException;
        }
        set
        {
            __ForecastException = value;
        }
    }

        
    /// <summary>
    /// The product associated with this exception notification line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exception Notification Line. Supply_ Item. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exception Notification Line
    /// <para />PropertyTermQualifier: Supply
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemType SupplyItem
    {
        get
        {
            if (__SupplyItem == null) { __SupplyItem = new ItemType(); }
            return __SupplyItem;
        }
        set
        {
            __SupplyItem = value;
        }
    }

}