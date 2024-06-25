using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define the point of consumption for a utility, such as a meter.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption Point. Details
/// <para />ObjectClass: Consumption Point
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsumptionPoint", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionPoint", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionPointType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute("SubscriberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__SubscriberID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubscriberType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__SubscriberType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubscriberTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__SubscriberTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalDeliveredQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__TotalDeliveredQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Address", Order=6)]
    public AddressType @__Address;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WebSiteAccess", Order=7)]
    public WebSiteAccessType @__WebSiteAccess;
        
    private System.Collections.Generic.List<MeterType> _utilityMeter;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UtilityMeter", Order=8)]
    public MeterType[] @__UtilityMeter
    {
        get
        {
            return _utilityMeter?.ToArray();
        }
        set
        {
            _utilityMeter = value == null ? null : new System.Collections.Generic.List<MeterType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this consumption point.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Point. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Point
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Additional informations concerning the consumption point</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// A meter at this consumption point.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Point. Utility_ Meter. Meter
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Point
    /// <para />PropertyTermQualifier: Utility
    /// <para />PropertyTerm: Meter
    /// <para />AssociatedObjectClass: Meter
    /// <para />RepresentationTerm: Meter
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<MeterType> UtilityMeter
    {
        get { return _utilityMeter ?? (_utilityMeter = new System.Collections.Generic.List<MeterType>()); }
        set { _utilityMeter = value; }
    }

        
    /// <summary>
    /// An identifier for this point of consumption.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Point. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Point
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

        
    /// <summary>
    /// An identifier for the subscriber responsible for the consumption at this consumption point.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Point. Subscriber Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Point
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
    /// The type of subscriber, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Point. Subscriber Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Point
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
    /// The type of subscriber, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Point. Subscriber Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Point
    /// <para />PropertyTerm: Subscriber Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>APL</example>
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
    /// The total quantity delivered, calculated at this consumption point.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Point. Total_ Delivered Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Point
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

        
    /// <summary>
    /// The address of this consumption point.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Point. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Point
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType Address
    {
        get
        {
            if (__Address == null) { __Address = new AddressType(); }
            return __Address;
        }
        set
        {
            __Address = value;
        }
    }

        
    /// <summary>
    /// Access information for the website of this consumption point.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Point. Web Site Access
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Point
    /// <para />PropertyTerm: Web Site Access
    /// <para />AssociatedObjectClass: Web Site Access
    /// <para />RepresentationTerm: Web Site Access
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public WebSiteAccessType WebSiteAccess
    {
        get
        {
            if (__WebSiteAccess == null) { __WebSiteAccess = new WebSiteAccessType(); }
            return __WebSiteAccess;
        }
        set
        {
            __WebSiteAccess = value;
        }
    }

}