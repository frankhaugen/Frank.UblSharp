using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a planned effect of a retail event (e.g., a promotion or a change in inventory policy) upon supply or demand.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Retail Planned Impact. Details
/// <para />ObjectClass: Retail Planned Impact
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RetailPlannedImpact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RetailPlannedImpact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RetailPlannedImpactType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ForecastPurposeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForecastTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ForecastTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=3)]
    public PeriodType @__Period;
        
    /// <summary>
    /// Estimated monetary value of the planned event as an impact
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Retail Planned Impact. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Retail Planned Impact
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType Amount
    {
        get
        {
            if (__Amount == null) { __Amount = new AmountType(); }
            return __Amount;
        }
        set
        {
            __Amount = value;
        }
    }

        
    /// <summary>
    /// It will have impact on either Sales forecast or Order Forecast
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Retail Planned Impact. Forecast_ Purpose Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Retail Planned Impact
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
    /// A code signifying the type of forecast. Examples of values are: BASE PROMOTIONAL SEASONAL TOTAL
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Retail Planned Impact. Forecast Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Retail Planned Impact
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
    /// The period to which this impact applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Retail Planned Impact. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Retail Planned Impact
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

}