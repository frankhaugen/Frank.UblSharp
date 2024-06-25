using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the measurement of a type of consumption during a particular period, used for the subscriber to get an overview of his consumption
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption History. Details
/// <para />ObjectClass: Consumption History
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsumptionHistory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionHistory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionHistoryType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterNumber", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__MeterNumber;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__ConsumptionLevelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionLevel", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__ConsumptionLevel;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
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
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=6)]
    public PeriodType @__Period;
        
    /// <summary>
    /// Text describing the consumption itself.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption History. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption History
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>2004/2005</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// A text identifier for the meter measuring the consumption.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption History. Meter Number. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption History
    /// <para />PropertyTerm: Meter Number
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>61722x</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MeterNumber
    {
        get
        {
            if (__MeterNumber == null) { __MeterNumber = new TextType(); }
            return __MeterNumber;
        }
        set
        {
            __MeterNumber = value;
        }
    }

        
    /// <summary>
    /// The quantity consumed.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption History. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption History
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>7621.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// The monetary amount to be charged for the quantity consumed.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption History. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption History
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
    /// The consumption level, expressed as a code used explain the consumption quantity, e.g.. diversion from the normal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption History. Consumption Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption History
    /// <para />PropertyTerm: Consumption Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>B</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ConsumptionLevelCode
    {
        get
        {
            if (__ConsumptionLevelCode == null) { __ConsumptionLevelCode = new CodeType(); }
            return __ConsumptionLevelCode;
        }
        set
        {
            __ConsumptionLevelCode = value;
        }
    }

        
    /// <summary>
    /// The consumption level, expressed as text, used explain the consumption quantity, e.g.. diversion from the normal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption History. Consumption Level Text. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption History
    /// <para />PropertyTerm: Consumption Level Text
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Average</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ConsumptionLevel
    {
        get
        {
            if (__ConsumptionLevel == null) { __ConsumptionLevel = new TextType(); }
            return __ConsumptionLevel;
        }
        set
        {
            __ConsumptionLevel = value;
        }
    }

        
    /// <summary>
    /// The period during which the consumption took place.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption History. Period
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption History
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