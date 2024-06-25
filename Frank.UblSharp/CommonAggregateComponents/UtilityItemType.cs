using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the consumption of a utility product.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Utility Item. Details
/// <para />ObjectClass: Utility Item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("UtilityItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("UtilityItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class UtilityItemType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubscriberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__SubscriberID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubscriberType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__SubscriberType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubscriberTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__SubscriberTypeCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
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
    [System.Xml.Serialization.XmlElementAttribute("PackQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__PackQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackSizeNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public NumericType @__PackSizeNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__ConsumptionType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public CodeType @__ConsumptionTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CurrentChargeType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public TextType @__CurrentChargeType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CurrentChargeTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public CodeType @__CurrentChargeTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OneTimeChargeType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType @__OneTimeChargeType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OneTimeChargeTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public CodeType @__OneTimeChargeTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxCategory", Order=13)]
    public TaxCategoryType @__TaxCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Contract", Order=14)]
    public ContractType @__Contract;
        
    /// <summary>
    /// Text describing the consumption product.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Basis price quarter (5.761 kWh per 35,58 cents), Transport of electricity, etc.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// An identifier for this utility item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1</example>
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
    /// An identifier for the subscriber to the utility.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Subscriber Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Subscriber Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>98143211</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SubscriberID
    {
        get
        {
            if (__SubscriberID == null) { __SubscriberID = new IdentifierType(); }
            return __SubscriberID;
        }
        set
        {
            __SubscriberID = value;
        }
    }

        
    /// <summary>
    /// Identification of the subscriber type, expressed as text..
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Subscriber Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Subscriber Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType SubscriberType
    {
        get
        {
            if (__SubscriberType == null) { __SubscriberType = new TextType(); }
            return __SubscriberType;
        }
        set
        {
            __SubscriberType = value;
        }
    }

        
    /// <summary>
    /// The code identifying for the service type.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Subscriber Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Subscriber Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SubscriberTypeCode
    {
        get
        {
            if (__SubscriberTypeCode == null) { __SubscriberTypeCode = new CodeType(); }
            return __SubscriberTypeCode;
        }
        set
        {
            __SubscriberTypeCode = value;
        }
    }

        
    /// <summary>
    /// The unit packaging quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Pack Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Pack Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>1</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType PackQuantity
    {
        get
        {
            if (__PackQuantity == null) { __PackQuantity = new QuantityType(); }
            return __PackQuantity;
        }
        set
        {
            __PackQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of items in a pack.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Pack Size. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Pack Size
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType PackSizeNumeric
    {
        get
        {
            if (__PackSizeNumeric == null) { __PackSizeNumeric = new NumericType(); }
            return __PackSizeNumeric;
        }
        set
        {
            __PackSizeNumeric = value;
        }
    }

        
    /// <summary>
    /// The type of product consumed, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Consumption Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
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
    /// The type of product consumed, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Consumption Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
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
    /// Information of the actual payments type for the utility Item
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Current_ Charge Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTermQualifier: Current
    /// <para />PropertyTerm: Charge Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CurrentChargeType
    {
        get
        {
            if (__CurrentChargeType == null) { __CurrentChargeType = new TextType(); }
            return __CurrentChargeType;
        }
        set
        {
            __CurrentChargeType = value;
        }
    }

        
    /// <summary>
    /// Information of the actual payments type code expressed as a code
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. Current_ Charge Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTermQualifier: Current
    /// <para />PropertyTerm: Charge Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CurrentChargeTypeCode
    {
        get
        {
            if (__CurrentChargeTypeCode == null) { __CurrentChargeTypeCode = new CodeType(); }
            return __CurrentChargeTypeCode;
        }
        set
        {
            __CurrentChargeTypeCode = value;
        }
    }

        
    /// <summary>
    /// Information about the one-time payment type in case everything is paid One time
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. One Time_ Charge Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTermQualifier: One Time
    /// <para />PropertyTerm: Charge Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType OneTimeChargeType
    {
        get
        {
            if (__OneTimeChargeType == null) { __OneTimeChargeType = new TextType(); }
            return __OneTimeChargeType;
        }
        set
        {
            __OneTimeChargeType = value;
        }
    }

        
    /// <summary>
    /// Information about the one-time payment type code
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Utility Item. One Time_ Charge Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTermQualifier: One Time
    /// <para />PropertyTerm: Charge Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType OneTimeChargeTypeCode
    {
        get
        {
            if (__OneTimeChargeTypeCode == null) { __OneTimeChargeTypeCode = new CodeType(); }
            return __OneTimeChargeTypeCode;
        }
        set
        {
            __OneTimeChargeTypeCode = value;
        }
    }

        
    /// <summary>
    /// The tax category applicable to this utility item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Utility Item. Tax Category
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Tax Category
    /// <para />AssociatedObjectClass: Tax Category
    /// <para />RepresentationTerm: Tax Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TaxCategoryType TaxCategory
    {
        get
        {
            if (__TaxCategory == null) { __TaxCategory = new TaxCategoryType(); }
            return __TaxCategory;
        }
        set
        {
            __TaxCategory = value;
        }
    }

        
    /// <summary>
    /// A contract setting forth conditions applicable to this utility item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Utility Item. Contract
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Utility Item
    /// <para />PropertyTerm: Contract
    /// <para />AssociatedObjectClass: Contract
    /// <para />RepresentationTerm: Contract
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContractType Contract
    {
        get
        {
            if (__Contract == null) { __Contract = new ContractType(); }
            return __Contract;
        }
        set
        {
            __Contract = value;
        }
    }

}