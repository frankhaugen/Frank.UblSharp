using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe utility consumption, including details of the environment in which consumption takes place.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption Report. Details
/// <para />ObjectClass: Consumption Report
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsumptionReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionReportType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__ConsumptionType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ConsumptionTypeCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
    [System.Xml.Serialization.XmlElementAttribute("TotalConsumedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__TotalConsumedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BasicConsumedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__BasicConsumedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResidentOccupantsNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public NumericType @__ResidentOccupantsNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumersEnergyLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__ConsumersEnergyLevelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumersEnergyLevel", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType @__ConsumersEnergyLevel;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResidenceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public TextType @__ResidenceType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResidenceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public CodeType @__ResidenceTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HeatingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType @__HeatingType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HeatingTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public CodeType @__HeatingTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=13)]
    public PeriodType @__Period;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GuidanceDocumentReference", Order=14)]
    public DocumentReferenceType @__GuidanceDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=15)]
    public DocumentReferenceType @__DocumentReference;
        
    private System.Collections.Generic.List<ConsumptionReportReferenceType> _consumptionReportReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionReportReference", Order=16)]
    public ConsumptionReportReferenceType[] @__ConsumptionReportReference
    {
        get
        {
            return _consumptionReportReference?.ToArray();
        }
        set
        {
            _consumptionReportReference = value == null ? null : new System.Collections.Generic.List<ConsumptionReportReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<ConsumptionHistoryType> _consumptionHistory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionHistory", Order=17)]
    public ConsumptionHistoryType[] @__ConsumptionHistory
    {
        get
        {
            return _consumptionHistory?.ToArray();
        }
        set
        {
            _consumptionHistory = value == null ? null : new System.Collections.Generic.List<ConsumptionHistoryType>(value);
        }
    }
        
    /// <summary>
    /// Text reporting utility consumption.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>This report contain the latest year consumption</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// A reference to a previous consumption report.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Report. Consumption Report Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Consumption Report Reference
    /// <para />AssociatedObjectClass: Consumption Report Reference
    /// <para />RepresentationTerm: Consumption Report Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsumptionReportReferenceType> ConsumptionReportReference
    {
        get { return _consumptionReportReference ?? (_consumptionReportReference = new System.Collections.Generic.List<ConsumptionReportReferenceType>()); }
        set { _consumptionReportReference = value; }
    }

        
    /// <summary>
    /// A report describing historical parameters relating to a specific instance of consumption.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Report. Consumption History
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Consumption History
    /// <para />AssociatedObjectClass: Consumption History
    /// <para />RepresentationTerm: Consumption History
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsumptionHistoryType> ConsumptionHistory
    {
        get { return _consumptionHistory ?? (_consumptionHistory = new System.Collections.Generic.List<ConsumptionHistoryType>()); }
        set { _consumptionHistory = value; }
    }

        
    /// <summary>
    /// An identifier for this consumption report.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>n/a</example>
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
    /// The type of consumption, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Consumption Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
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
    /// The type of consumption, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Consumption Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
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
    /// The total quantity consumed.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Total_ Consumed Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
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
    /// The basic quantity consumed, excluding additional consumption.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Basic_ Consumed Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTermQualifier: Basic
    /// <para />PropertyTerm: Consumed Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>20000.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType BasicConsumedQuantity
    {
        get
        {
            if (__BasicConsumedQuantity == null) { __BasicConsumedQuantity = new QuantityType(); }
            return __BasicConsumedQuantity;
        }
        set
        {
            __BasicConsumedQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of people occupying the residence covered by this report.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Resident_ Occupants Numeric. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTermQualifier: Resident
    /// <para />PropertyTerm: Occupants Numeric
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    /// <example>4.0</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType ResidentOccupantsNumeric
    {
        get
        {
            if (__ResidentOccupantsNumeric == null) { __ResidentOccupantsNumeric = new NumericType(); }
            return __ResidentOccupantsNumeric;
        }
        set
        {
            __ResidentOccupantsNumeric = value;
        }
    }

        
    /// <summary>
    /// The level of energy consumed, compared to the average for this residence type and the number of people living in the residence, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Consumers_ Energy Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTermQualifier: Consumers
    /// <para />PropertyTerm: Energy Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>B</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ConsumersEnergyLevelCode
    {
        get
        {
            if (__ConsumersEnergyLevelCode == null) { __ConsumersEnergyLevelCode = new CodeType(); }
            return __ConsumersEnergyLevelCode;
        }
        set
        {
            __ConsumersEnergyLevelCode = value;
        }
    }

        
    /// <summary>
    /// The level of energy consumed, compared to the average for this residence type and the number of people living in the residence, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Consumers_ Energy Level. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTermQualifier: Consumers
    /// <para />PropertyTerm: Energy Level
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Middel</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ConsumersEnergyLevel
    {
        get
        {
            if (__ConsumersEnergyLevel == null) { __ConsumersEnergyLevel = new TextType(); }
            return __ConsumersEnergyLevel;
        }
        set
        {
            __ConsumersEnergyLevel = value;
        }
    }

        
    /// <summary>
    /// The type of residence (house, apartment, etc.) covered in this report, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Residence Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Residence Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>House</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ResidenceType
    {
        get
        {
            if (__ResidenceType == null) { __ResidenceType = new TextType(); }
            return __ResidenceType;
        }
        set
        {
            __ResidenceType = value;
        }
    }

        
    /// <summary>
    /// The type of residence (house, apartment, etc.) covered in this report, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Residence Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Residence Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>House</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ResidenceTypeCode
    {
        get
        {
            if (__ResidenceTypeCode == null) { __ResidenceTypeCode = new CodeType(); }
            return __ResidenceTypeCode;
        }
        set
        {
            __ResidenceTypeCode = value;
        }
    }

        
    /// <summary>
    /// The type of heating in the residence covered in this report, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Heating Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Heating Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>District heating</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType HeatingType
    {
        get
        {
            if (__HeatingType == null) { __HeatingType = new TextType(); }
            return __HeatingType;
        }
        set
        {
            __HeatingType = value;
        }
    }

        
    /// <summary>
    /// The type of heating in the residence covered in this report, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Report. Heating Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Heating Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>DistrictHeating</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType HeatingTypeCode
    {
        get
        {
            if (__HeatingTypeCode == null) { __HeatingTypeCode = new CodeType(); }
            return __HeatingTypeCode;
        }
        set
        {
            __HeatingTypeCode = value;
        }
    }

        
    /// <summary>
    /// The period of consumption covered in this report.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Report. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
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

        
    /// <summary>
    /// A reference to a document providing an explanation of this kind of report.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Report. Guidance_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTermQualifier: Guidance
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType GuidanceDocumentReference
    {
        get
        {
            if (__GuidanceDocumentReference == null) { __GuidanceDocumentReference = new DocumentReferenceType(); }
            return __GuidanceDocumentReference;
        }
        set
        {
            __GuidanceDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to some other document (for example, this report in another format).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Report. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Report
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType DocumentReference
    {
        get
        {
            if (__DocumentReference == null) { __DocumentReference = new DocumentReferenceType(); }
            return __DocumentReference;
        }
        set
        {
            __DocumentReference = value;
        }
    }

}