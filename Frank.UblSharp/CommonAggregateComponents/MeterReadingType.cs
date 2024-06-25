using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a meter reading.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Meter Reading. Details
/// <para />ObjectClass: Meter Reading
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("MeterReading", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("MeterReading", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class MeterReadingType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterReadingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__MeterReadingType1;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterReadingTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__MeterReadingTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousMeterReadingDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__PreviousMeterReadingDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousMeterQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__PreviousMeterQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestMeterReadingDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public DateType @__LatestMeterReadingDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestMeterQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public QuantityType @__LatestMeterQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousMeterReadingMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__PreviousMeterReadingMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousMeterReadingMethodCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public CodeType @__PreviousMeterReadingMethodCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestMeterReadingMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public TextType @__LatestMeterReadingMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestMeterReadingMethodCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public CodeType @__LatestMeterReadingMethodCode;
        
    private System.Collections.Generic.List<TextType> _meterReadingComments;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterReadingComments", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType[] @__MeterReadingComments
    {
        get
        {
            return _meterReadingComments?.ToArray();
        }
        set
        {
            _meterReadingComments = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveredQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public QuantityType @__DeliveredQuantity;
        
    /// <summary>
    /// Text containing comments on this meter reading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Meter Reading_ Comments. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Meter Reading
    /// <para />PropertyTerm: Comments
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>The last stated meterstand is estimated</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> MeterReadingComments
    {
        get { return _meterReadingComments ?? (_meterReadingComments = new System.Collections.Generic.List<TextType>()); }
        set { _meterReadingComments = value; }
    }

        
    /// <summary>
    /// An identifier for this meter reading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>7411013716x</example>
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

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MeterReadingType1
    {
        get
        {
            if (__MeterReadingType1 == null) { __MeterReadingType1 = new TextType(); }
            return __MeterReadingType1;
        }
        set
        {
            __MeterReadingType1 = value;
        }
    }

        
    /// <summary>
    /// The type of this meter reading, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Meter Reading Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTerm: Meter Reading Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Electricity</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType MeterReadingTypeCode
    {
        get
        {
            if (__MeterReadingTypeCode == null) { __MeterReadingTypeCode = new CodeType(); }
            return __MeterReadingTypeCode;
        }
        set
        {
            __MeterReadingTypeCode = value;
        }
    }

        
    /// <summary>
    /// The date of the previous meter reading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Previous_ Meter Reading Date. Date
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Previous
    /// <para />PropertyTerm: Meter Reading Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    /// <example>2006-09-01</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType PreviousMeterReadingDate
    {
        get
        {
            if (__PreviousMeterReadingDate == null) { __PreviousMeterReadingDate = new DateType(); }
            return __PreviousMeterReadingDate;
        }
        set
        {
            __PreviousMeterReadingDate = value;
        }
    }

        
    /// <summary>
    /// The quantity of the previous meter reading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Previous_ Meter Quantity. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Previous
    /// <para />PropertyTerm: Meter Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>122604.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType PreviousMeterQuantity
    {
        get
        {
            if (__PreviousMeterQuantity == null) { __PreviousMeterQuantity = new QuantityType(); }
            return __PreviousMeterQuantity;
        }
        set
        {
            __PreviousMeterQuantity = value;
        }
    }

        
    /// <summary>
    /// The date of the latest meter reading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Latest_ Meter Reading Date. Date
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Meter Reading Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    /// <example>2006-09-01</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType LatestMeterReadingDate
    {
        get
        {
            if (__LatestMeterReadingDate == null) { __LatestMeterReadingDate = new DateType(); }
            return __LatestMeterReadingDate;
        }
        set
        {
            __LatestMeterReadingDate = value;
        }
    }

        
    /// <summary>
    /// The quantity of the latest meter reading.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Latest_ Meter Quantity. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Meter Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>128365.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType LatestMeterQuantity
    {
        get
        {
            if (__LatestMeterQuantity == null) { __LatestMeterQuantity = new QuantityType(); }
            return __LatestMeterQuantity;
        }
        set
        {
            __LatestMeterQuantity = value;
        }
    }

        
    /// <summary>
    /// The method used for the previous meter reading, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Previous Meter Reading_ Method. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Previous Meter Reading
    /// <para />PropertyTerm: Method
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Manuel</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PreviousMeterReadingMethod
    {
        get
        {
            if (__PreviousMeterReadingMethod == null) { __PreviousMeterReadingMethod = new TextType(); }
            return __PreviousMeterReadingMethod;
        }
        set
        {
            __PreviousMeterReadingMethod = value;
        }
    }

        
    /// <summary>
    /// The method used for the previous meter reading, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Previous Meter Reading_ Method Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Previous Meter Reading
    /// <para />PropertyTerm: Method Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Estimated</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PreviousMeterReadingMethodCode
    {
        get
        {
            if (__PreviousMeterReadingMethodCode == null) { __PreviousMeterReadingMethodCode = new CodeType(); }
            return __PreviousMeterReadingMethodCode;
        }
        set
        {
            __PreviousMeterReadingMethodCode = value;
        }
    }

        
    /// <summary>
    /// The method used for the latest meter reading, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Latest Meter Reading_ Method. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Latest Meter Reading
    /// <para />PropertyTerm: Method
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Manuel</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType LatestMeterReadingMethod
    {
        get
        {
            if (__LatestMeterReadingMethod == null) { __LatestMeterReadingMethod = new TextType(); }
            return __LatestMeterReadingMethod;
        }
        set
        {
            __LatestMeterReadingMethod = value;
        }
    }

        
    /// <summary>
    /// The method used for the latest meter reading, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Latest Meter Reading_ Method Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Latest Meter Reading
    /// <para />PropertyTerm: Method Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Estimated</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LatestMeterReadingMethodCode
    {
        get
        {
            if (__LatestMeterReadingMethodCode == null) { __LatestMeterReadingMethodCode = new CodeType(); }
            return __LatestMeterReadingMethodCode;
        }
        set
        {
            __LatestMeterReadingMethodCode = value;
        }
    }

        
    /// <summary>
    /// Consumption in the period from PreviousMeterReadingDate to LatestMeterReadingDate.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Reading. Delivered_ Quantity. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Meter Reading
    /// <para />PropertyTermQualifier: Delivered
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType DeliveredQuantity
    {
        get
        {
            if (__DeliveredQuantity == null) { __DeliveredQuantity = new QuantityType(); }
            return __DeliveredQuantity;
        }
        set
        {
            __DeliveredQuantity = value;
        }
    }

}