using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a specific property of an item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Property. Details
/// <para />ObjectClass: Item Property
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemPropertyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NameCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__NameCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TestMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__TestMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Value", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__Value;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValueQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__ValueQuantity;
        
    private System.Collections.Generic.List<TextType> _valueQualifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ImportanceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__ImportanceCode;
        
    private System.Collections.Generic.List<TextType> _listValue;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ListValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType[] @__ListValue
    {
        get
        {
            return _listValue?.ToArray();
        }
        set
        {
            _listValue = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UsabilityPeriod", Order=9)]
    public PeriodType @__UsabilityPeriod;
        
    private System.Collections.Generic.List<ItemPropertyGroupType> _itemPropertyGroup;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemPropertyGroup", Order=10)]
    public ItemPropertyGroupType[] @__ItemPropertyGroup
    {
        get
        {
            return _itemPropertyGroup?.ToArray();
        }
        set
        {
            _itemPropertyGroup = value == null ? null : new System.Collections.Generic.List<ItemPropertyGroupType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RangeDimension", Order=11)]
    public DimensionType @__RangeDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemPropertyRange", Order=12)]
    public ItemPropertyRangeType @__ItemPropertyRange;
        
    /// <summary>
    /// Text qualifying the value of the property.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Value Qualifier. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Property
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
    /// The value expressed as a text in case the property is a value in a list. For example, a colour.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. List Value. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTerm: List Value
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ListValue
    {
        get { return _listValue ?? (_listValue = new System.Collections.Generic.List<TextType>()); }
        set { _listValue = value; }
    }

        
    /// <summary>
    /// A description of the property group to which this item property belongs.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Property. Item Property Group
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTerm: Item Property Group
    /// <para />AssociatedObjectClass: Item Property Group
    /// <para />RepresentationTerm: Item Property Group
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemPropertyGroupType> ItemPropertyGroup
    {
        get { return _itemPropertyGroup ?? (_itemPropertyGroup = new System.Collections.Generic.List<ItemPropertyGroupType>()); }
        set { _itemPropertyGroup = value; }
    }

        
    /// <summary>
    /// An identifier for this property of an item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
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
    /// The name of this item property.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Name
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Item Property
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
    /// The name of this item property, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Name Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
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
    /// The method of testing the value of this item property.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Test Method. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTerm: Test Method
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>100 watts , 15 European , 20% +/- 5%</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TestMethod
    {
        get
        {
            if (__TestMethod == null) { __TestMethod = new TextType(); }
            return __TestMethod;
        }
        set
        {
            __TestMethod = value;
        }
    }

        
    /// <summary>
    /// The value of this item property, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Value. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
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
    /// The value of this item property, expressed as a quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Value_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
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

        
    /// <summary>
    /// A code signifying the importance of this property in using it to describe a related Item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property. Importance Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTerm: Importance Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ImportanceCode
    {
        get
        {
            if (__ImportanceCode == null) { __ImportanceCode = new CodeType(); }
            return __ImportanceCode;
        }
        set
        {
            __ImportanceCode = value;
        }
    }

        
    /// <summary>
    /// The period during which this item property is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Property. Usability_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTermQualifier: Usability
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType UsabilityPeriod
    {
        get
        {
            if (__UsabilityPeriod == null) { __UsabilityPeriod = new PeriodType(); }
            return __UsabilityPeriod;
        }
        set
        {
            __UsabilityPeriod = value;
        }
    }

        
    /// <summary>
    /// The range of values for the dimensions of this property.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Property. Range_ Dimension. Dimension
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTermQualifier: Range
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DimensionType RangeDimension
    {
        get
        {
            if (__RangeDimension == null) { __RangeDimension = new DimensionType(); }
            return __RangeDimension;
        }
        set
        {
            __RangeDimension = value;
        }
    }

        
    /// <summary>
    /// A range of values for this item property.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Property. Item Property Range
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property
    /// <para />PropertyTerm: Item Property Range
    /// <para />AssociatedObjectClass: Item Property Range
    /// <para />RepresentationTerm: Item Property Range
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemPropertyRangeType ItemPropertyRange
    {
        get
        {
            if (__ItemPropertyRange == null) { __ItemPropertyRange = new ItemPropertyRangeType(); }
            return __ItemPropertyRange;
        }
        set
        {
            __ItemPropertyRange = value;
        }
    }

}