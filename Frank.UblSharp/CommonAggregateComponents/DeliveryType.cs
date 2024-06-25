using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a delivery.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Delivery. Details
/// <para />ObjectClass: Delivery
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ContractualDelivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractualDelivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DeliveryType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__MinimumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__MaximumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualDeliveryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__ActualDeliveryDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualDeliveryTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TimeType @__ActualDeliveryTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestDeliveryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public DateType @__LatestDeliveryDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestDeliveryTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TimeType @__LatestDeliveryTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReleaseID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IdentifierType @__ReleaseID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TrackingID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IdentifierType @__TrackingID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryAddress", Order=10)]
    public AddressType @__DeliveryAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryLocation", Order=11)]
    public LocationType @__DeliveryLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AlternativeDeliveryLocation", Order=12)]
    public LocationType @__AlternativeDeliveryLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedDeliveryPeriod", Order=13)]
    public PeriodType @__RequestedDeliveryPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PromisedDeliveryPeriod", Order=14)]
    public PeriodType @__PromisedDeliveryPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDeliveryPeriod", Order=15)]
    public PeriodType @__EstimatedDeliveryPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CarrierParty", Order=16)]
    public PartyType @__CarrierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryParty", Order=17)]
    public PartyType @__DeliveryParty;
        
    private System.Collections.Generic.List<PartyType> _notifyParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotifyParty", Order=18)]
    public PartyType[] @__NotifyParty
    {
        get
        {
            return _notifyParty?.ToArray();
        }
        set
        {
            _notifyParty = value == null ? null : new System.Collections.Generic.List<PartyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Despatch", Order=19)]
    public DespatchType @__Despatch;
        
    private System.Collections.Generic.List<DeliveryTermsType> _deliveryTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Order=20)]
    public DeliveryTermsType[] @__DeliveryTerms
    {
        get
        {
            return _deliveryTerms?.ToArray();
        }
        set
        {
            _deliveryTerms = value == null ? null : new System.Collections.Generic.List<DeliveryTermsType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumDeliveryUnit", Order=21)]
    public DeliveryUnitType @__MinimumDeliveryUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumDeliveryUnit", Order=22)]
    public DeliveryUnitType @__MaximumDeliveryUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Shipment", Order=23)]
    public ShipmentType @__Shipment;
        
    /// <summary>
    /// A party to be notified of this delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Notify_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Notify
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyType> NotifyParty
    {
        get { return _notifyParty ?? (_notifyParty = new System.Collections.Generic.List<PartyType>()); }
        set { _notifyParty = value; }
    }

        
    /// <summary>
    /// Terms and conditions relating to the delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Delivery Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTerm: Delivery Terms
    /// <para />AssociatedObjectClass: Delivery Terms
    /// <para />RepresentationTerm: Delivery Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DeliveryTermsType> DeliveryTerms
    {
        get { return _deliveryTerms ?? (_deliveryTerms = new System.Collections.Generic.List<DeliveryTermsType>()); }
        set { _deliveryTerms = value; }
    }

        
    /// <summary>
    /// An identifier for this delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
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
    /// The quantity of items, child consignments, shipments in this delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
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
    /// The minimum quantity of items, child consignments, shipments in this delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Minimum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumQuantity
    {
        get
        {
            if (__MinimumQuantity == null) { __MinimumQuantity = new QuantityType(); }
            return __MinimumQuantity;
        }
        set
        {
            __MinimumQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum quantity of items, child consignments, shipments in this delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Maximum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumQuantity
    {
        get
        {
            if (__MaximumQuantity == null) { __MaximumQuantity = new QuantityType(); }
            return __MaximumQuantity;
        }
        set
        {
            __MaximumQuantity = value;
        }
    }

        
    /// <summary>
    /// The actual date of delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Actual_ Delivery Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Delivery Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ActualDeliveryDate
    {
        get
        {
            if (__ActualDeliveryDate == null) { __ActualDeliveryDate = new DateType(); }
            return __ActualDeliveryDate;
        }
        set
        {
            __ActualDeliveryDate = value;
        }
    }

        
    /// <summary>
    /// The actual time of delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Actual_ Delivery Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Delivery Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ActualDeliveryTime
    {
        get
        {
            if (__ActualDeliveryTime == null) { __ActualDeliveryTime = new TimeType(); }
            return __ActualDeliveryTime;
        }
        set
        {
            __ActualDeliveryTime = value;
        }
    }

        
    /// <summary>
    /// The latest date of delivery allowed by the buyer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Latest_ Delivery Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Delivery Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType LatestDeliveryDate
    {
        get
        {
            if (__LatestDeliveryDate == null) { __LatestDeliveryDate = new DateType(); }
            return __LatestDeliveryDate;
        }
        set
        {
            __LatestDeliveryDate = value;
        }
    }

        
    /// <summary>
    /// The latest time of delivery allowed by the buyer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Latest_ Delivery Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Delivery Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType LatestDeliveryTime
    {
        get
        {
            if (__LatestDeliveryTime == null) { __LatestDeliveryTime = new TimeType(); }
            return __LatestDeliveryTime;
        }
        set
        {
            __LatestDeliveryTime = value;
        }
    }

        
    /// <summary>
    /// An identifier used for approval of access to delivery locations (e.g., port terminals).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Release. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTerm: Release
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ReleaseID
    {
        get
        {
            if (__ReleaseID == null) { __ReleaseID = new IdentifierType(); }
            return __ReleaseID;
        }
        set
        {
            __ReleaseID = value;
        }
    }

        
    /// <summary>
    /// The delivery Tracking ID (for transport tracking).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery. Tracking Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTerm: Tracking Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TrackingID
    {
        get
        {
            if (__TrackingID == null) { __TrackingID = new IdentifierType(); }
            return __TrackingID;
        }
        set
        {
            __TrackingID = value;
        }
    }

        
    /// <summary>
    /// The delivery address.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Delivery_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType DeliveryAddress
    {
        get
        {
            if (__DeliveryAddress == null) { __DeliveryAddress = new AddressType(); }
            return __DeliveryAddress;
        }
        set
        {
            __DeliveryAddress = value;
        }
    }

        
    /// <summary>
    /// The delivery location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Delivery_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType DeliveryLocation
    {
        get
        {
            if (__DeliveryLocation == null) { __DeliveryLocation = new LocationType(); }
            return __DeliveryLocation;
        }
        set
        {
            __DeliveryLocation = value;
        }
    }

        
    /// <summary>
    /// An alternative delivery location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Alternative Delivery_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Alternative Delivery
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType AlternativeDeliveryLocation
    {
        get
        {
            if (__AlternativeDeliveryLocation == null) { __AlternativeDeliveryLocation = new LocationType(); }
            return __AlternativeDeliveryLocation;
        }
        set
        {
            __AlternativeDeliveryLocation = value;
        }
    }

        
    /// <summary>
    /// The period requested for delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Requested Delivery_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Requested Delivery
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType RequestedDeliveryPeriod
    {
        get
        {
            if (__RequestedDeliveryPeriod == null) { __RequestedDeliveryPeriod = new PeriodType(); }
            return __RequestedDeliveryPeriod;
        }
        set
        {
            __RequestedDeliveryPeriod = value;
        }
    }

        
    /// <summary>
    /// The period promised for delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Promised Delivery_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Promised Delivery
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType PromisedDeliveryPeriod
    {
        get
        {
            if (__PromisedDeliveryPeriod == null) { __PromisedDeliveryPeriod = new PeriodType(); }
            return __PromisedDeliveryPeriod;
        }
        set
        {
            __PromisedDeliveryPeriod = value;
        }
    }

        
    /// <summary>
    /// The period estimated for delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Estimated Delivery_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Estimated Delivery
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType EstimatedDeliveryPeriod
    {
        get
        {
            if (__EstimatedDeliveryPeriod == null) { __EstimatedDeliveryPeriod = new PeriodType(); }
            return __EstimatedDeliveryPeriod;
        }
        set
        {
            __EstimatedDeliveryPeriod = value;
        }
    }

        
    /// <summary>
    /// The party responsible for delivering the goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Carrier_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Carrier
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType CarrierParty
    {
        get
        {
            if (__CarrierParty == null) { __CarrierParty = new PartyType(); }
            return __CarrierParty;
        }
        set
        {
            __CarrierParty = value;
        }
    }

        
    /// <summary>
    /// The party to whom the goods are delivered.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Delivery_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType DeliveryParty
    {
        get
        {
            if (__DeliveryParty == null) { __DeliveryParty = new PartyType(); }
            return __DeliveryParty;
        }
        set
        {
            __DeliveryParty = value;
        }
    }

        
    /// <summary>
    /// The despatch (pickup) associated with this delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Despatch
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTerm: Despatch
    /// <para />AssociatedObjectClass: Despatch
    /// <para />RepresentationTerm: Despatch
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DespatchType Despatch
    {
        get
        {
            if (__Despatch == null) { __Despatch = new DespatchType(); }
            return __Despatch;
        }
        set
        {
            __Despatch = value;
        }
    }

        
    /// <summary>
    /// The minimum delivery unit for this delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Minimum_ Delivery Unit. Delivery Unit
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Delivery Unit
    /// <para />AssociatedObjectClass: Delivery Unit
    /// <para />RepresentationTerm: Delivery Unit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DeliveryUnitType MinimumDeliveryUnit
    {
        get
        {
            if (__MinimumDeliveryUnit == null) { __MinimumDeliveryUnit = new DeliveryUnitType(); }
            return __MinimumDeliveryUnit;
        }
        set
        {
            __MinimumDeliveryUnit = value;
        }
    }

        
    /// <summary>
    /// The maximum delivery unit for this delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Maximum_ Delivery Unit. Delivery Unit
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Delivery Unit
    /// <para />AssociatedObjectClass: Delivery Unit
    /// <para />RepresentationTerm: Delivery Unit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DeliveryUnitType MaximumDeliveryUnit
    {
        get
        {
            if (__MaximumDeliveryUnit == null) { __MaximumDeliveryUnit = new DeliveryUnitType(); }
            return __MaximumDeliveryUnit;
        }
        set
        {
            __MaximumDeliveryUnit = value;
        }
    }

        
    /// <summary>
    /// The shipment being delivered.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery. Shipment
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery
    /// <para />PropertyTerm: Shipment
    /// <para />AssociatedObjectClass: Shipment
    /// <para />RepresentationTerm: Shipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ShipmentType Shipment
    {
        get
        {
            if (__Shipment == null) { __Shipment = new ShipmentType(); }
            return __Shipment;
        }
        set
        {
            __Shipment = value;
        }
    }

}