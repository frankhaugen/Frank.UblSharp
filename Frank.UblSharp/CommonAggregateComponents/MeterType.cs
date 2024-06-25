using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a meter and its readings.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Meter. Details
/// <para />ObjectClass: Meter
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Meter", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Meter", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class MeterType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterNumber", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__MeterNumber;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__MeterName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterConstant", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__MeterConstant;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterConstantCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__MeterConstantCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalDeliveredQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__TotalDeliveredQuantity;
        
    private System.Collections.Generic.List<MeterReadingType> _meterReading;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterReading", Order=5)]
    public MeterReadingType[] @__MeterReading
    {
        get
        {
            return _meterReading?.ToArray();
        }
        set
        {
            _meterReading = value == null ? null : new System.Collections.Generic.List<MeterReadingType>(value);
        }
    }
        
    private System.Collections.Generic.List<MeterPropertyType> _meterProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterProperty", Order=6)]
    public MeterPropertyType[] @__MeterProperty
    {
        get
        {
            return _meterProperty?.ToArray();
        }
        set
        {
            _meterProperty = value == null ? null : new System.Collections.Generic.List<MeterPropertyType>(value);
        }
    }
        
    /// <summary>
    /// A reading of this meter.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Meter. Meter Reading
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Meter
    /// <para />PropertyTerm: Meter Reading
    /// <para />AssociatedObjectClass: Meter Reading
    /// <para />RepresentationTerm: Meter Reading
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<MeterReadingType> MeterReading
    {
        get { return _meterReading ?? (_meterReading = new System.Collections.Generic.List<MeterReadingType>()); }
        set { _meterReading = value; }
    }

        
    /// <summary>
    /// A property of this meter.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Meter. Meter Property
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Meter
    /// <para />PropertyTerm: Meter Property
    /// <para />AssociatedObjectClass: Meter Property
    /// <para />RepresentationTerm: Meter Property
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<MeterPropertyType> MeterProperty
    {
        get { return _meterProperty ?? (_meterProperty = new System.Collections.Generic.List<MeterPropertyType>()); }
        set { _meterProperty = value; }
    }

        
    /// <summary>
    /// The meter number, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter. Meter Number. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter
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
    /// The name of this meter, which serves as an identifier to distinguish a main meter from a submeter.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter. Meter Name. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter
    /// <para />PropertyTerm: Meter Name
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MeterName
    {
        get
        {
            if (__MeterName == null) { __MeterName = new TextType(); }
            return __MeterName;
        }
        set
        {
            __MeterName = value;
        }
    }

        
    /// <summary>
    /// The factor by which readings of this meter must be multiplied to calculate consumption, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter. Meter Constant. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter
    /// <para />PropertyTerm: Meter Constant
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>1.000</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MeterConstant
    {
        get
        {
            if (__MeterConstant == null) { __MeterConstant = new TextType(); }
            return __MeterConstant;
        }
        set
        {
            __MeterConstant = value;
        }
    }

        
    /// <summary>
    /// A code signifying the formula to be used in applying the meter constant.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter. Meter Constant Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter
    /// <para />PropertyTerm: Meter Constant Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Factor</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType MeterConstantCode
    {
        get
        {
            if (__MeterConstantCode == null) { __MeterConstantCode = new CodeType(); }
            return __MeterConstantCode;
        }
        set
        {
            __MeterConstantCode = value;
        }
    }

        
    /// <summary>
    /// The quantity delivered; the total quantity consumed as calculated from the meter readings.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter. Total_ Delivered Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Delivered Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>5761.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TotalDeliveredQuantity
    {
        get
        {
            if (__TotalDeliveredQuantity == null) { __TotalDeliveredQuantity = new QuantityType(); }
            return __TotalDeliveredQuantity;
        }
        set
        {
            __TotalDeliveredQuantity = value;
        }
    }

}