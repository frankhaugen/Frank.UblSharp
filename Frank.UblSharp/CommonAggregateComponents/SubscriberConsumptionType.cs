using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The consumption for a specific party for given consumption point provided by a numbers of suppliers. An enterprise can have one utility statement for several parties (e.g. a ministry of defence receiving a telephone bill). In this way each subscriber consumption represent a sub utility statement.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Subscriber Consumption. Details
/// <para />ObjectClass: Subscriber Consumption
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SubscriberConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SubscriberConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class SubscriberConsumptionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ConsumptionID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecificationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__SpecificationTypeCode;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Note
    {
        get
        {
            return _note?.ToArray();
        }
        set
        {
            _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalMeteredQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__TotalMeteredQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubscriberParty", Order=4)]
    public PartyType @__SubscriberParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UtilityConsumptionPoint", Order=5)]
    public ConsumptionPointType @__UtilityConsumptionPoint;
        
    private System.Collections.Generic.List<OnAccountPaymentType> _onAccountPayment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OnAccountPayment", Order=6)]
    public OnAccountPaymentType[] @__OnAccountPayment
    {
        get
        {
            return _onAccountPayment?.ToArray();
        }
        set
        {
            _onAccountPayment = value == null ? null : new System.Collections.Generic.List<OnAccountPaymentType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Consumption", Order=7)]
    public ConsumptionType @__Consumption;
        
    private System.Collections.Generic.List<SupplierConsumptionType> _supplierConsumption;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupplierConsumption", Order=8)]
    public SupplierConsumptionType[] @__SupplierConsumption
    {
        get
        {
            return _supplierConsumption?.ToArray();
        }
        set
        {
            _supplierConsumption = value == null ? null : new System.Collections.Generic.List<SupplierConsumptionType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>This is how we have calculating your yearly statement</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// The planned prepayments (on account) regarding this subscription.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. On Account Payment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTerm: On Account Payment
    /// <para />AssociatedObjectClass: On Account Payment
    /// <para />RepresentationTerm: On Account Payment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<OnAccountPaymentType> OnAccountPayment
    {
        get { return _onAccountPayment ?? (_onAccountPayment = new System.Collections.Generic.List<OnAccountPaymentType>()); }
        set { _onAccountPayment = value; }
    }

        
    /// <summary>
    /// The consumption in case the consumption is from more than one supplier.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Supplier Consumption
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTerm: Supplier Consumption
    /// <para />AssociatedObjectClass: Supplier Consumption
    /// <para />RepresentationTerm: Supplier Consumption
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<SupplierConsumptionType> SupplierConsumption
    {
        get { return _supplierConsumption ?? (_supplierConsumption = new System.Collections.Generic.List<SupplierConsumptionType>()); }
        set { _supplierConsumption = value; }
    }

        
    /// <summary>
    /// The identifier tor this specification.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Consumption Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTerm: Consumption Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ConsumptionID
    {
        get
        {
            if (__ConsumptionID == null) { __ConsumptionID = new IdentifierType(); }
            return __ConsumptionID;
        }
        set
        {
            __ConsumptionID = value;
        }
    }

        
    /// <summary>
    /// The code which specifies the type of this specification, e.g. an on account specification or the yearly specification.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Specification Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTerm: Specification Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SpecificationTypeCode
    {
        get
        {
            if (__SpecificationTypeCode == null) { __SpecificationTypeCode = new CodeType(); }
            return __SpecificationTypeCode;
        }
        set
        {
            __SpecificationTypeCode = value;
        }
    }

        
    /// <summary>
    /// The total quantity consumed, as calculated from meter readings.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Total Metered Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTerm: Total Metered Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>2000.0</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType TotalMeteredQuantity
    {
        get
        {
            if (__TotalMeteredQuantity == null) { __TotalMeteredQuantity = new QuantityType(); }
            return __TotalMeteredQuantity;
        }
        set
        {
            __TotalMeteredQuantity = value;
        }
    }

        
    /// <summary>
    /// The party subscribing to the utility.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Subscriber_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTermQualifier: Subscriber
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType SubscriberParty
    {
        get
        {
            if (__SubscriberParty == null) { __SubscriberParty = new PartyType(); }
            return __SubscriberParty;
        }
        set
        {
            __SubscriberParty = value;
        }
    }

        
    /// <summary>
    /// The point at which the utility is consumed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Utility_ Consumption Point. Consumption Point
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTermQualifier: Utility
    /// <para />PropertyTerm: Consumption Point
    /// <para />AssociatedObjectClass: Consumption Point
    /// <para />RepresentationTerm: Consumption Point
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ConsumptionPointType UtilityConsumptionPoint
    {
        get
        {
            if (__UtilityConsumptionPoint == null) { __UtilityConsumptionPoint = new ConsumptionPointType(); }
            return __UtilityConsumptionPoint;
        }
        set
        {
            __UtilityConsumptionPoint = value;
        }
    }

        
    /// <summary>
    /// The consumption in case the consumption is from one and only one supplier.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Subscriber Consumption. Consumption
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Subscriber Consumption
    /// <para />PropertyTerm: Consumption
    /// <para />AssociatedObjectClass: Consumption
    /// <para />RepresentationTerm: Consumption
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ConsumptionType Consumption
    {
        get
        {
            if (__Consumption == null) { __Consumption = new ConsumptionType(); }
            return __Consumption;
        }
        set
        {
            __Consumption = value;
        }
    }

}