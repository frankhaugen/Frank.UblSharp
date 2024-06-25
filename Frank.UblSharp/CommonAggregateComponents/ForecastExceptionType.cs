using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// As explained in Exception Criteria Line: Three types of exception criteria can be defined, Operational, Metric or Forecast Exceptions. This class provides criteria for forecast exception type: the identification of the purpose of the forecast, the source of data and the time basis criteria for the exception.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Forecast Exception. Details
/// <para />ObjectClass: Forecast Exception
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ForecastException", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ForecastException", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ForecastExceptionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__ForecastPurposeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ForecastTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TimeType @__IssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DataSourceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__DataSourceCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ComparisonDataCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__ComparisonDataCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ComparisonForecastIssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TimeType @__ComparisonForecastIssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ComparisonForecastIssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public DateType @__ComparisonForecastIssueDate;
        
    /// <summary>
    /// It is either Sales forecast or Order Forecast. Definition can be changed like: &quot;The purpose of the Forecast (either sales or order), about which an exception criteria is being defined&quot;.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Forecast_ Purpose Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Exception
    /// <para />PropertyTermQualifier: Forecast
    /// <para />PropertyTerm: Purpose Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ForecastPurposeCode
    {
        get
        {
            if (__ForecastPurposeCode == null) { __ForecastPurposeCode = new CodeType(); }
            return __ForecastPurposeCode;
        }
        set
        {
            __ForecastPurposeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of forecast. Example of values are:BASE PROMOTIONAL SEASONAL TOTAL
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Forecast Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Exception
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
    /// The date on which the forecast was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Issue Date. Date
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Exception
    /// <para />PropertyTerm: Issue Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType IssueDate
    {
        get
        {
            if (__IssueDate == null) { __IssueDate = new DateType(); }
            return __IssueDate;
        }
        set
        {
            __IssueDate = value;
        }
    }

        
    /// <summary>
    /// The time at which the forecast was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Exception
    /// <para />PropertyTerm: Issue Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType IssueTime
    {
        get
        {
            if (__IssueTime == null) { __IssueTime = new TimeType(); }
            return __IssueTime;
        }
        set
        {
            __IssueTime = value;
        }
    }

        
    /// <summary>
    /// A code signifying the partner who provides this information.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Data Source Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Exception
    /// <para />PropertyTerm: Data Source Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DataSourceCode
    {
        get
        {
            if (__DataSourceCode == null) { __DataSourceCode = new CodeType(); }
            return __DataSourceCode;
        }
        set
        {
            __DataSourceCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the partner providing the information in this forecast exception.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Comparison Data Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Exception
    /// <para />PropertyTerm: Comparison Data Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ComparisonDataCode
    {
        get
        {
            if (__ComparisonDataCode == null) { __ComparisonDataCode = new CodeType(); }
            return __ComparisonDataCode;
        }
        set
        {
            __ComparisonDataCode = value;
        }
    }

        
    /// <summary>
    /// The time at which this comparison forecast was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Comparison Forecast Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Exception
    /// <para />PropertyTerm: Comparison Forecast Issue Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ComparisonForecastIssueTime
    {
        get
        {
            if (__ComparisonForecastIssueTime == null) { __ComparisonForecastIssueTime = new TimeType(); }
            return __ComparisonForecastIssueTime;
        }
        set
        {
            __ComparisonForecastIssueTime = value;
        }
    }

        
    /// <summary>
    /// The date on which this comparison forecast was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception. Comparison Forecast Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Exception
    /// <para />PropertyTerm: Comparison Forecast Issue Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ComparisonForecastIssueDate
    {
        get
        {
            if (__ComparisonForecastIssueDate == null) { __ComparisonForecastIssueDate = new DateType(); }
            return __ComparisonForecastIssueDate;
        }
        set
        {
            __ComparisonForecastIssueDate = value;
        }
    }

}