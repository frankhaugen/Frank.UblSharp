using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to specify which day of the week a transport service is operational.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Service Frequency. Details
/// <para />ObjectClass: Service Frequency
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ScheduledServiceFrequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ScheduledServiceFrequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ServiceFrequencyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WeekDayCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__WeekDayCode;
        
    /// <summary>
    /// A day of the week, expressed as code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Service Frequency. Week Day. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Service Frequency
    /// <para />PropertyTerm: Week Day
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Week Day
    /// <para />DataType: Week Day_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType WeekDayCode
    {
        get
        {
            if (__WeekDayCode == null) { __WeekDayCode = new CodeType(); }
            return __WeekDayCode;
        }
        set
        {
            __WeekDayCode = value;
        }
    }

}