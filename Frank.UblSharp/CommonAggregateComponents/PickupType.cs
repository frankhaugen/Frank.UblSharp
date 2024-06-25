using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a pickup for delivery.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Pickup. Details
/// <para />ObjectClass: Pickup
/// <para />AlternativeBusinessTerms: Collection
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PickupType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualPickupDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__ActualPickupDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualPickupTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__ActualPickupTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EarliestPickupDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__EarliestPickupDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EarliestPickupTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__EarliestPickupTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestPickupDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public DateType @__LatestPickupDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestPickupTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TimeType @__LatestPickupTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PickupLocation", Order=7)]
    public LocationType @__PickupLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PickupParty", Order=8)]
    public PartyType @__PickupParty;
        
    /// <summary>
    /// An identifier for this pickup.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Pickup. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
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
    /// The actual pickup date.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Pickup. Actual_ Pickup Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Pickup Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ActualPickupDate
    {
        get
        {
            if (__ActualPickupDate == null) { __ActualPickupDate = new DateType(); }
            return __ActualPickupDate;
        }
        set
        {
            __ActualPickupDate = value;
        }
    }

        
    /// <summary>
    /// The actual pickup time.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Pickup. Actual_ Pickup Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Pickup Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ActualPickupTime
    {
        get
        {
            if (__ActualPickupTime == null) { __ActualPickupTime = new TimeType(); }
            return __ActualPickupTime;
        }
        set
        {
            __ActualPickupTime = value;
        }
    }

        
    /// <summary>
    /// The earliest pickup date.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Pickup. Earliest_ Pickup Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Earliest
    /// <para />PropertyTerm: Pickup Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType EarliestPickupDate
    {
        get
        {
            if (__EarliestPickupDate == null) { __EarliestPickupDate = new DateType(); }
            return __EarliestPickupDate;
        }
        set
        {
            __EarliestPickupDate = value;
        }
    }

        
    /// <summary>
    /// The earliest pickup time.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Pickup. Earliest_ Pickup Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Earliest
    /// <para />PropertyTerm: Pickup Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType EarliestPickupTime
    {
        get
        {
            if (__EarliestPickupTime == null) { __EarliestPickupTime = new TimeType(); }
            return __EarliestPickupTime;
        }
        set
        {
            __EarliestPickupTime = value;
        }
    }

        
    /// <summary>
    /// The latest pickup date.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Pickup. Latest_ Pickup Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Pickup Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType LatestPickupDate
    {
        get
        {
            if (__LatestPickupDate == null) { __LatestPickupDate = new DateType(); }
            return __LatestPickupDate;
        }
        set
        {
            __LatestPickupDate = value;
        }
    }

        
    /// <summary>
    /// The latest pickup time.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Pickup. Latest_ Pickup Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Pickup Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType LatestPickupTime
    {
        get
        {
            if (__LatestPickupTime == null) { __LatestPickupTime = new TimeType(); }
            return __LatestPickupTime;
        }
        set
        {
            __LatestPickupTime = value;
        }
    }

        
    /// <summary>
    /// The pickup location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Pickup. Pickup_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Pickup
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType PickupLocation
    {
        get
        {
            if (__PickupLocation == null) { __PickupLocation = new LocationType(); }
            return __PickupLocation;
        }
        set
        {
            __PickupLocation = value;
        }
    }

        
    /// <summary>
    /// The party responsible for picking up a delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Pickup. Pickup_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Pickup
    /// <para />PropertyTermQualifier: Pickup
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType PickupParty
    {
        get
        {
            if (__PickupParty == null) { __PickupParty = new PartyType(); }
            return __PickupParty;
        }
        set
        {
            __PickupParty = value;
        }
    }

}