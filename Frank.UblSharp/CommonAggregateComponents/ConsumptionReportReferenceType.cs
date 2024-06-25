using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to an earlier consumption report (e.g., last year&apos;s consumption).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption Report Reference. Details
/// <para />ObjectClass: Consumption Report Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsumptionReportReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionReportReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionReportReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionReportID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ConsumptionReportID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__ConsumptionType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ConsumptionTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalConsumedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__TotalConsumedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=4)]
    public PeriodType @__Period;
        
    /// <summary>
    /// An identifier for the referenced consumption report.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report Reference. Consumption_ Report Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Report Reference
    /// <para />PropertyTermQualifier: Consumption
    /// <para />PropertyTerm: Report Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>n/a</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ConsumptionReportID
    {
        get
        {
            if (__ConsumptionReportID == null) { __ConsumptionReportID = new IdentifierType(); }
            return __ConsumptionReportID;
        }
        set
        {
            __ConsumptionReportID = value;
        }
    }

        
    /// <summary>
    /// The reported consumption type, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report Reference. Consumption Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report Reference
    /// <para />PropertyTerm: Consumption Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Consumption</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ConsumptionType
    {
        get
        {
            if (__ConsumptionType == null) { __ConsumptionType = new TextType(); }
            return __ConsumptionType;
        }
        set
        {
            __ConsumptionType = value;
        }
    }

        
    /// <summary>
    /// The reported consumption type, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report Reference. Consumption Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report Reference
    /// <para />PropertyTerm: Consumption Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Consumption</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ConsumptionTypeCode
    {
        get
        {
            if (__ConsumptionTypeCode == null) { __ConsumptionTypeCode = new CodeType(); }
            return __ConsumptionTypeCode;
        }
        set
        {
            __ConsumptionTypeCode = value;
        }
    }

        
    /// <summary>
    /// The total quantity consumed during the period of the referenced report.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report Reference. Total_ Consumed Quantity. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Report Reference
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Consumed Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>20479.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TotalConsumedQuantity
    {
        get
        {
            if (__TotalConsumedQuantity == null) { __TotalConsumedQuantity = new QuantityType(); }
            return __TotalConsumedQuantity;
        }
        set
        {
            __TotalConsumedQuantity = value;
        }
    }

        
    /// <summary>
    /// The period of consumption covered by the referenced report.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Report Reference. Period
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Report Reference
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