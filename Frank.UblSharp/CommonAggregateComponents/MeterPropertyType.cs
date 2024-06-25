using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The name of this meter property.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Meter Property. Details
/// <para />ObjectClass: Meter Property
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("MeterProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("MeterProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class MeterPropertyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NameCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__NameCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Value", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__Value;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValueQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__ValueQuantity;
        
    private System.Collections.Generic.List<TextType> _valueQualifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__ValueQualifier
    {
        get
        {
            return _valueQualifier?.ToArray();
        }
        set
        {
            _valueQualifier = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    /// <summary>
    /// An additional value to qualify the value of the meter
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Property. Value Qualifier. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Meter Property
    /// <para />PropertyTerm: Value Qualifier
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ValueQualifier
    {
        get { return _valueQualifier ?? (_valueQualifier = new System.Collections.Generic.List<TextType>()); }
        set { _valueQualifier = value; }
    }

        
    /// <summary>
    /// The name of this meter property, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Property. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Property
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Energy Rating , Collar Size , Fat Content</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType Name
    {
        get
        {
            if (__Name == null) { __Name = new NameType(); }
            return __Name;
        }
        set
        {
            __Name = value;
        }
    }

        
    /// <summary>
    /// The value of this meter property, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Property. Name Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Property
    /// <para />PropertyTerm: Name Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType NameCode
    {
        get
        {
            if (__NameCode == null) { __NameCode = new CodeType(); }
            return __NameCode;
        }
        set
        {
            __NameCode = value;
        }
    }

        
    /// <summary>
    /// The value of this meter property, expressed as a quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Property. Value. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Property
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>100 watts , 15 European , 20% +/- 5%</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Value
    {
        get
        {
            if (__Value == null) { __Value = new TextType(); }
            return __Value;
        }
        set
        {
            __Value = value;
        }
    }

        
    /// <summary>
    /// The value of this meter property, expressed as a quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Meter Property. Value_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Meter Property
    /// <para />PropertyTermQualifier: Value
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ValueQuantity
    {
        get
        {
            if (__ValueQuantity == null) { __ValueQuantity = new QuantityType(); }
            return __ValueQuantity;
        }
        set
        {
            __ValueQuantity = value;
        }
    }

}