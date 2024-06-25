using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// Establishes the criterion for one of the three types of exceptions. This class provides criteria for the kind of forecast exception, the identification of the purpose of the forecast, the source of data and the time basis criterion for the exception.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Forecast Exception Criterion Line. Details
/// <para />ObjectClass: Forecast Exception Criterion Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ForecastExceptionCriterionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ForecastExceptionCriterionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ForecastExceptionCriterionLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__ForecastPurposeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ForecastTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ComparisonDataSourceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ComparisonDataSourceCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DataSourceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__DataSourceCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TimeDeltaDaysQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__TimeDeltaDaysQuantity;
        
    /// <summary>
    /// A description of the purpose for the forecast that is assigned to each forecast data item exception criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception Criterion Line. Forecast_ Purpose Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Exception Criterion Line
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
    /// A description of a Forecast selected from a list.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception Criterion Line. Forecast Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Exception Criterion Line
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
    /// If it is a forecast comparison exception, this value indicates the other source of information.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception Criterion Line. Comparison Data Source Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Exception Criterion Line
    /// <para />PropertyTerm: Comparison Data Source Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ComparisonDataSourceCode
    {
        get
        {
            if (__ComparisonDataSourceCode == null) { __ComparisonDataSourceCode = new CodeType(); }
            return __ComparisonDataSourceCode;
        }
        set
        {
            __ComparisonDataSourceCode = value;
        }
    }

        
    /// <summary>
    /// Indication of the partner who provides the information.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception Criterion Line. Data Source Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Forecast Exception Criterion Line
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
    /// Time basis in days for the Exception.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Forecast Exception Criterion Line. Time Delta Days Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Forecast Exception Criterion Line
    /// <para />PropertyTerm: Time Delta Days Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TimeDeltaDaysQuantity
    {
        get
        {
            if (__TimeDeltaDaysQuantity == null) { __TimeDeltaDaysQuantity = new QuantityType(); }
            return __TimeDeltaDaysQuantity;
        }
        set
        {
            __TimeDeltaDaysQuantity = value;
        }
    }

}