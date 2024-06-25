using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a specific, trackable instance of an item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Instance. Details
/// <para />ObjectClass: Item Instance
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ItemInstance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemInstance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemInstanceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProductTraceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ProductTraceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ManufactureDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__ManufactureDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ManufactureTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__ManufactureTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BestBeforeDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__BestBeforeDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__RegistrationID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SerialID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IdentifierType @__SerialID;
        
    private System.Collections.Generic.List<ItemPropertyType> _additionalItemProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty", Order=6)]
    public ItemPropertyType[] @__AdditionalItemProperty
    {
        get
        {
            return _additionalItemProperty?.ToArray();
        }
        set
        {
            _additionalItemProperty = value == null ? null : new System.Collections.Generic.List<ItemPropertyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LotIdentification", Order=7)]
    public LotIdentificationType @__LotIdentification;
        
    /// <summary>
    /// An additional property of this item instance.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Instance. Additional_ Item Property. Item Property
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Item Property
    /// <para />AssociatedObjectClass: Item Property
    /// <para />RepresentationTerm: Item Property
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemPropertyType> AdditionalItemProperty
    {
        get { return _additionalItemProperty ?? (_additionalItemProperty = new System.Collections.Generic.List<ItemPropertyType>()); }
        set { _additionalItemProperty = value; }
    }

        
    /// <summary>
    /// An identifier used for tracing this item instance, such as the EPC number used in RFID.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Instance. Product Trace_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTermQualifier: Product Trace
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ProductTraceID
    {
        get
        {
            if (__ProductTraceID == null) { __ProductTraceID = new IdentifierType(); }
            return __ProductTraceID;
        }
        set
        {
            __ProductTraceID = value;
        }
    }

        
    /// <summary>
    /// The date on which this item instance was manufactured.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Instance. Manufacture Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTerm: Manufacture Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ManufactureDate
    {
        get
        {
            if (__ManufactureDate == null) { __ManufactureDate = new DateType(); }
            return __ManufactureDate;
        }
        set
        {
            __ManufactureDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this item instance was manufactured.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Instance. Manufacture Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTerm: Manufacture Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ManufactureTime
    {
        get
        {
            if (__ManufactureTime == null) { __ManufactureTime = new TimeType(); }
            return __ManufactureTime;
        }
        set
        {
            __ManufactureTime = value;
        }
    }

        
    /// <summary>
    /// The date before which it is best to use this item instance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Instance. Best Before Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTerm: Best Before Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType BestBeforeDate
    {
        get
        {
            if (__BestBeforeDate == null) { __BestBeforeDate = new DateType(); }
            return __BestBeforeDate;
        }
        set
        {
            __BestBeforeDate = value;
        }
    }

        
    /// <summary>
    /// The registration identifier of this item instance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Instance. Registration Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTerm: Registration Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>car registration or licensing number</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType RegistrationID
    {
        get
        {
            if (__RegistrationID == null) { __RegistrationID = new IdentifierType(); }
            return __RegistrationID;
        }
        set
        {
            __RegistrationID = value;
        }
    }

        
    /// <summary>
    /// The serial number of this item instance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Instance. Serial Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTerm: Serial Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>chassis number of a car</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SerialID
    {
        get
        {
            if (__SerialID == null) { __SerialID = new IdentifierType(); }
            return __SerialID;
        }
        set
        {
            __SerialID = value;
        }
    }

        
    /// <summary>
    /// The lot identifier of this item instance (the identifier that allows recall of the item if necessary).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Instance. Lot Identification
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Instance
    /// <para />PropertyTerm: Lot Identification
    /// <para />AssociatedObjectClass: Lot Identification
    /// <para />RepresentationTerm: Lot Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LotIdentificationType LotIdentification
    {
        get
        {
            if (__LotIdentification == null) { __LotIdentification = new LotIdentificationType(); }
            return __LotIdentification;
        }
        set
        {
            __LotIdentification = value;
        }
    }

}