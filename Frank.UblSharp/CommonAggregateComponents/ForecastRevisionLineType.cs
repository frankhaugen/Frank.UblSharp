using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Forecast Revision describing a revision to a line in a Forecast.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Forecast Revision Line. Details
/// <para />ObjectClass: Forecast Revision Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ForecastRevisionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ForecastRevisionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ForecastRevisionLineType
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
    [System.Xml.Serialization.XmlElementAttribute("RevisedForecastLineID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IdentifierType @__RevisedForecastLineID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SourceForecastIssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__SourceForecastIssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SourceForecastIssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TimeType @__SourceForecastIssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdjustmentReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__AdjustmentReasonCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastPeriod", Order=7)]
    public PeriodType @__ForecastPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SalesItem", Order=8)]
    public SalesItemType @__SalesItem;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Forecast Revision Line
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
    /// Text describing the revision to this line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Forecast Revision Line
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
    /// An identifier for this forecast revision line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Revision Line
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
    /// An identifier for the revised forecast line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Revised_ Forecast Line Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Revision Line
    /// <para />PropertyTermQualifier: Revised
    /// <para />PropertyTerm: Forecast Line Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType RevisedForecastLineID
    {
        get
        {
            if (__RevisedForecastLineID == null) { __RevisedForecastLineID = new IdentifierType(); }
            return __RevisedForecastLineID;
        }
        set
        {
            __RevisedForecastLineID = value;
        }
    }

        
    /// <summary>
    /// The date on which the forecast modified by this revision was generated or created.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Source Forecast_ Issue Date. Date
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Revision Line
    /// <para />PropertyTermQualifier: Source Forecast
    /// <para />PropertyTerm: Issue Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType SourceForecastIssueDate
    {
        get
        {
            if (__SourceForecastIssueDate == null) { __SourceForecastIssueDate = new DateType(); }
            return __SourceForecastIssueDate;
        }
        set
        {
            __SourceForecastIssueDate = value;
        }
    }

        
    /// <summary>
    /// The time at which the forecast modified by this revision was generated or created.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Source Forecast_ Issue Time. Time
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Revision Line
    /// <para />PropertyTermQualifier: Source Forecast
    /// <para />PropertyTerm: Issue Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType SourceForecastIssueTime
    {
        get
        {
            if (__SourceForecastIssueTime == null) { __SourceForecastIssueTime = new TimeType(); }
            return __SourceForecastIssueTime;
        }
        set
        {
            __SourceForecastIssueTime = value;
        }
    }

        
    /// <summary>
    /// A code signifying the reason for the adjustment specified in this forecast revision line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Adjustment Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Revision Line
    /// <para />PropertyTerm: Adjustment Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AdjustmentReasonCode
    {
        get
        {
            if (__AdjustmentReasonCode == null) { __AdjustmentReasonCode = new CodeType(); }
            return __AdjustmentReasonCode;
        }
        set
        {
            __AdjustmentReasonCode = value;
        }
    }

        
    /// <summary>
    /// The period to which this forecast revision line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Forecast Revision Line. Forecast_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Revision Line
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
    /// <para />DictionaryEntryName: Forecast Revision Line. Sales Item
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Revision Line
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