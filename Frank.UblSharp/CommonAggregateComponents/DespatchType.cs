using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the despatching of goods (their pickup for delivery).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Despatch. Details
/// <para />ObjectClass: Despatch
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DespatchType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedDespatchDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__RequestedDespatchDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedDespatchTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__RequestedDespatchTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDespatchDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__EstimatedDespatchDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDespatchTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__EstimatedDespatchTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualDespatchDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public DateType @__ActualDespatchDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualDespatchTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TimeType @__ActualDespatchTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GuaranteedDespatchDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public DateType @__GuaranteedDespatchDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GuaranteedDespatchTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TimeType @__GuaranteedDespatchTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReleaseID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IdentifierType @__ReleaseID;
        
    private System.Collections.Generic.List<TextType> _instructions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public TextType[] @__Instructions
    {
        get
        {
            return _instructions?.ToArray();
        }
        set
        {
            _instructions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DespatchAddress", Order=11)]
    public AddressType @__DespatchAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DespatchLocation", Order=12)]
    public LocationType @__DespatchLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DespatchParty", Order=13)]
    public PartyType @__DespatchParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CarrierParty", Order=14)]
    public PartyType @__CarrierParty;
        
    private System.Collections.Generic.List<PartyType> _notifyParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotifyParty", Order=15)]
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
    [System.Xml.Serialization.XmlElementAttribute("Contact", Order=16)]
    public ContactType @__Contact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDespatchPeriod", Order=17)]
    public PeriodType @__EstimatedDespatchPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedDespatchPeriod", Order=18)]
    public PeriodType @__RequestedDespatchPeriod;
        
    /// <summary>
    /// Text describing any special instructions applying to the despatch (pickup).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Instructions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTerm: Instructions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Instructions
    {
        get { return _instructions ?? (_instructions = new System.Collections.Generic.List<TextType>()); }
        set { _instructions = value; }
    }

        
    /// <summary>
    /// A party to be notified of this despatch (pickup).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Notify_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Despatch
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
    /// An identifier for this despatch event.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
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
    /// The despatch (pickup) date requested, normally by the buyer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Requested_ Despatch Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Requested
    /// <para />PropertyTerm: Despatch Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType RequestedDespatchDate
    {
        get
        {
            if (__RequestedDespatchDate == null) { __RequestedDespatchDate = new DateType(); }
            return __RequestedDespatchDate;
        }
        set
        {
            __RequestedDespatchDate = value;
        }
    }

        
    /// <summary>
    /// The despatch (pickup) time requested, normally by the buyer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Requested_ Despatch Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Requested
    /// <para />PropertyTerm: Despatch Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType RequestedDespatchTime
    {
        get
        {
            if (__RequestedDespatchTime == null) { __RequestedDespatchTime = new TimeType(); }
            return __RequestedDespatchTime;
        }
        set
        {
            __RequestedDespatchTime = value;
        }
    }

        
    /// <summary>
    /// The estimated despatch (pickup) date.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Estimated_ Despatch Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Estimated
    /// <para />PropertyTerm: Despatch Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType EstimatedDespatchDate
    {
        get
        {
            if (__EstimatedDespatchDate == null) { __EstimatedDespatchDate = new DateType(); }
            return __EstimatedDespatchDate;
        }
        set
        {
            __EstimatedDespatchDate = value;
        }
    }

        
    /// <summary>
    /// The estimated despatch (pickup) time.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Estimated_ Despatch Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Estimated
    /// <para />PropertyTerm: Despatch Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType EstimatedDespatchTime
    {
        get
        {
            if (__EstimatedDespatchTime == null) { __EstimatedDespatchTime = new TimeType(); }
            return __EstimatedDespatchTime;
        }
        set
        {
            __EstimatedDespatchTime = value;
        }
    }

        
    /// <summary>
    /// The actual despatch (pickup) date.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Actual_ Despatch Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Despatch Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ActualDespatchDate
    {
        get
        {
            if (__ActualDespatchDate == null) { __ActualDespatchDate = new DateType(); }
            return __ActualDespatchDate;
        }
        set
        {
            __ActualDespatchDate = value;
        }
    }

        
    /// <summary>
    /// The actual despatch (pickup) time.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Actual_ Despatch Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Despatch Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ActualDespatchTime
    {
        get
        {
            if (__ActualDespatchTime == null) { __ActualDespatchTime = new TimeType(); }
            return __ActualDespatchTime;
        }
        set
        {
            __ActualDespatchTime = value;
        }
    }

        
    /// <summary>
    /// The date guaranteed for the despatch (pickup).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Guaranteed_ Despatch Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Guaranteed
    /// <para />PropertyTerm: Despatch Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType GuaranteedDespatchDate
    {
        get
        {
            if (__GuaranteedDespatchDate == null) { __GuaranteedDespatchDate = new DateType(); }
            return __GuaranteedDespatchDate;
        }
        set
        {
            __GuaranteedDespatchDate = value;
        }
    }

        
    /// <summary>
    /// The time guaranteed for the despatch (pickup).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Guaranteed_ Despatch Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Guaranteed
    /// <para />PropertyTerm: Despatch Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType GuaranteedDespatchTime
    {
        get
        {
            if (__GuaranteedDespatchTime == null) { __GuaranteedDespatchTime = new TimeType(); }
            return __GuaranteedDespatchTime;
        }
        set
        {
            __GuaranteedDespatchTime = value;
        }
    }

        
    /// <summary>
    /// An identifier for the release of the despatch used as security control or cargo control (pick-up).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch. Release. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
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
    /// The address of the despatch (pickup).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Despatch_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Despatch
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType DespatchAddress
    {
        get
        {
            if (__DespatchAddress == null) { __DespatchAddress = new AddressType(); }
            return __DespatchAddress;
        }
        set
        {
            __DespatchAddress = value;
        }
    }

        
    /// <summary>
    /// The location of the despatch (pickup).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Despatch_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Despatch
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType DespatchLocation
    {
        get
        {
            if (__DespatchLocation == null) { __DespatchLocation = new LocationType(); }
            return __DespatchLocation;
        }
        set
        {
            __DespatchLocation = value;
        }
    }

        
    /// <summary>
    /// The party despatching the goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Despatch_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Despatch
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType DespatchParty
    {
        get
        {
            if (__DespatchParty == null) { __DespatchParty = new PartyType(); }
            return __DespatchParty;
        }
        set
        {
            __DespatchParty = value;
        }
    }

        
    /// <summary>
    /// The party carrying the goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Carrier_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
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
    /// The primary contact for this despatch (pickup).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType Contact
    {
        get
        {
            if (__Contact == null) { __Contact = new ContactType(); }
            return __Contact;
        }
        set
        {
            __Contact = value;
        }
    }

        
    /// <summary>
    /// The period estimated for the despatch (pickup) of goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Estimated Despatch_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Estimated Despatch
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType EstimatedDespatchPeriod
    {
        get
        {
            if (__EstimatedDespatchPeriod == null) { __EstimatedDespatchPeriod = new PeriodType(); }
            return __EstimatedDespatchPeriod;
        }
        set
        {
            __EstimatedDespatchPeriod = value;
        }
    }

        
    /// <summary>
    /// The period requested for the despatch (pickup) of goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch. Requested Despatch_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch
    /// <para />PropertyTermQualifier: Requested Despatch
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType RequestedDespatchPeriod
    {
        get
        {
            if (__RequestedDespatchPeriod == null) { __RequestedDespatchPeriod = new PeriodType(); }
            return __RequestedDespatchPeriod;
        }
        set
        {
            __RequestedDespatchPeriod = value;
        }
    }

}