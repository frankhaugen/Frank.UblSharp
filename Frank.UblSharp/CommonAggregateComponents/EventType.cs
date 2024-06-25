using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a significant occurrence relating to an object, process, or person.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Event. Details
/// <para />ObjectClass: Event
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Event", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Event", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EventType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IdentificationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__IdentificationID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OccurrenceDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__OccurrenceDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OccurrenceTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__OccurrenceTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__TypeCode;
        
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
    [System.Xml.Serialization.XmlElementAttribute("CompletionIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IndicatorType @__CompletionIndicator;
        
    private System.Collections.Generic.List<StatusType> _currentStatus;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CurrentStatus", Order=6)]
    public StatusType[] @__CurrentStatus
    {
        get
        {
            return _currentStatus?.ToArray();
        }
        set
        {
            _currentStatus = value == null ? null : new System.Collections.Generic.List<StatusType>(value);
        }
    }
        
    private System.Collections.Generic.List<ContactType> _contact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Contact", Order=7)]
    public ContactType[] @__Contact
    {
        get
        {
            return _contact?.ToArray();
        }
        set
        {
            _contact = value == null ? null : new System.Collections.Generic.List<ContactType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OccurenceLocation", Order=8)]
    public LocationType @__OccurenceLocation;
        
    /// <summary>
    /// Text describing this event.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Event
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// The current status of this event.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event. Current_ Status. Status
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Event
    /// <para />PropertyTermQualifier: Current
    /// <para />PropertyTerm: Status
    /// <para />AssociatedObjectClass: Status
    /// <para />RepresentationTerm: Status
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<StatusType> CurrentStatus
    {
        get { return _currentStatus ?? (_currentStatus = new System.Collections.Generic.List<StatusType>()); }
        set { _currentStatus = value; }
    }

        
    /// <summary>
    /// Contacts associated with this event.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event. Contact
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Event
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ContactType> Contact
    {
        get { return _contact ?? (_contact = new System.Collections.Generic.List<ContactType>()); }
        set { _contact = value; }
    }

        
    /// <summary>
    /// An identifier for this event within an agreed event identification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event. Identification. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event
    /// <para />PropertyTerm: Identification
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType IdentificationID
    {
        get
        {
            if (__IdentificationID == null) { __IdentificationID = new IdentifierType(); }
            return __IdentificationID;
        }
        set
        {
            __IdentificationID = value;
        }
    }

        
    /// <summary>
    /// The date of this event.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event. Occurrence Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event
    /// <para />PropertyTerm: Occurrence Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType OccurrenceDate
    {
        get
        {
            if (__OccurrenceDate == null) { __OccurrenceDate = new DateType(); }
            return __OccurrenceDate;
        }
        set
        {
            __OccurrenceDate = value;
        }
    }

        
    /// <summary>
    /// The time of this event.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event. Occurrence Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event
    /// <para />PropertyTerm: Occurrence Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType OccurrenceTime
    {
        get
        {
            if (__OccurrenceTime == null) { __OccurrenceTime = new TimeType(); }
            return __OccurrenceTime;
        }
        set
        {
            __OccurrenceTime = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of this event.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event. Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event
    /// <para />PropertyTerm: Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TypeCode
    {
        get
        {
            if (__TypeCode == null) { __TypeCode = new CodeType(); }
            return __TypeCode;
        }
        set
        {
            __TypeCode = value;
        }
    }

        
    /// <summary>
    /// An indicator that this event has been completed (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event. Completion_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event
    /// <para />PropertyTermQualifier: Completion
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType CompletionIndicator
    {
        get
        {
            if (__CompletionIndicator == null) { __CompletionIndicator = new IndicatorType(); }
            return __CompletionIndicator;
        }
        set
        {
            __CompletionIndicator = value;
        }
    }

        
    /// <summary>
    /// The location of this event.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Event. Occurence_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event
    /// <para />PropertyTermQualifier: Occurence
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType OccurenceLocation
    {
        get
        {
            if (__OccurenceLocation == null) { __OccurenceLocation = new LocationType(); }
            return __OccurenceLocation;
        }
        set
        {
            __OccurenceLocation = value;
        }
    }

}