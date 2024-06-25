using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a period of time.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Period. Details
/// <para />ObjectClass: Period
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ActivityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActivityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PeriodType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public DateType @__StartDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StartTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TimeType @__StartTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EndDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__EndDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EndTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TimeType @__EndTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DurationMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public MeasureType @__DurationMeasure;
        
    private System.Collections.Generic.List<CodeType> _descriptionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DescriptionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType[] @__DescriptionCode
    {
        get
        {
            return _descriptionCode?.ToArray();
        }
        set
        {
            _descriptionCode = value == null ? null : new System.Collections.Generic.List<CodeType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
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
        
    /// <summary>
    /// A description of this period, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Period. Description Code. Code
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Period
    /// <para />PropertyTerm: Description Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CodeType> DescriptionCode
    {
        get { return _descriptionCode ?? (_descriptionCode = new System.Collections.Generic.List<CodeType>()); }
        set { _descriptionCode = value; }
    }

        
    /// <summary>
    /// A description of this period, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Period. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Period
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
    /// The date on which this period begins.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Period. Start Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Period
    /// <para />PropertyTerm: Start Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType StartDate
    {
        get
        {
            if (__StartDate == null) { __StartDate = new DateType(); }
            return __StartDate;
        }
        set
        {
            __StartDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this period begins.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Period. Start Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Period
    /// <para />PropertyTerm: Start Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType StartTime
    {
        get
        {
            if (__StartTime == null) { __StartTime = new TimeType(); }
            return __StartTime;
        }
        set
        {
            __StartTime = value;
        }
    }

        
    /// <summary>
    /// The date on which this period ends.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Period. End Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Period
    /// <para />PropertyTerm: End Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType EndDate
    {
        get
        {
            if (__EndDate == null) { __EndDate = new DateType(); }
            return __EndDate;
        }
        set
        {
            __EndDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this period ends.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Period. End Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Period
    /// <para />PropertyTerm: End Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType EndTime
    {
        get
        {
            if (__EndTime == null) { __EndTime = new TimeType(); }
            return __EndTime;
        }
        set
        {
            __EndTime = value;
        }
    }

        
    /// <summary>
    /// The duration of this period, expressed as an ISO 8601 code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Period. Duration. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Period
    /// <para />PropertyTerm: Duration
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType DurationMeasure
    {
        get
        {
            if (__DurationMeasure == null) { __DurationMeasure = new MeasureType(); }
            return __DurationMeasure;
        }
        set
        {
            __DurationMeasure = value;
        }
    }

}