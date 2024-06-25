using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a notification requirement.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Notification Requirement. Details
/// <para />ObjectClass: Notification Requirement
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("NotificationRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("NotificationRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class NotificationRequirementType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotificationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__NotificationTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PostEventNotificationDurationMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public MeasureType @__PostEventNotificationDurationMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreEventNotificationDurationMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public MeasureType @__PreEventNotificationDurationMeasure;
        
    private System.Collections.Generic.List<PartyType> _notifyParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotifyParty", Order=3)]
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
        
    private System.Collections.Generic.List<PeriodType> _notificationPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotificationPeriod", Order=4)]
    public PeriodType[] @__NotificationPeriod
    {
        get
        {
            return _notificationPeriod?.ToArray();
        }
        set
        {
            _notificationPeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
        }
    }
        
    private System.Collections.Generic.List<LocationType> _notificationLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotificationLocation", Order=5)]
    public LocationType[] @__NotificationLocation
    {
        get
        {
            return _notificationLocation?.ToArray();
        }
        set
        {
            _notificationLocation = value == null ? null : new System.Collections.Generic.List<LocationType>(value);
        }
    }
        
    /// <summary>
    /// A party to be notified.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Notification Requirement. Notify_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Notification Requirement
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
    /// A period during which a notification should be issued.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Notification Requirement. Notification_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Notification Requirement
    /// <para />PropertyTermQualifier: Notification
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PeriodType> NotificationPeriod
    {
        get { return _notificationPeriod ?? (_notificationPeriod = new System.Collections.Generic.List<PeriodType>()); }
        set { _notificationPeriod = value; }
    }

        
    /// <summary>
    /// A location at which a notification should be issued.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Notification Requirement. Notification_ Location. Location
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Notification Requirement
    /// <para />PropertyTermQualifier: Notification
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LocationType> NotificationLocation
    {
        get { return _notificationLocation ?? (_notificationLocation = new System.Collections.Generic.List<LocationType>()); }
        set { _notificationLocation = value; }
    }

        
    /// <summary>
    /// A code signifying the type of notification (e.g., pickup status).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Notification Requirement. Notification Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Notification Requirement
    /// <para />PropertyTerm: Notification Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType NotificationTypeCode
    {
        get
        {
            if (__NotificationTypeCode == null) { __NotificationTypeCode = new CodeType(); }
            return __NotificationTypeCode;
        }
        set
        {
            __NotificationTypeCode = value;
        }
    }

        
    /// <summary>
    /// The length of time between the occurrence of a given event and the issuance of a notification.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Notification Requirement. Post Event Notification Duration. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Notification Requirement
    /// <para />PropertyTerm: Post Event Notification Duration
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType PostEventNotificationDurationMeasure
    {
        get
        {
            if (__PostEventNotificationDurationMeasure == null) { __PostEventNotificationDurationMeasure = new MeasureType(); }
            return __PostEventNotificationDurationMeasure;
        }
        set
        {
            __PostEventNotificationDurationMeasure = value;
        }
    }

        
    /// <summary>
    /// The length of time to elapse between the issuance of a notification and the occurrence of the event it relates to.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Notification Requirement. Pre Event Notification Duration. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Notification Requirement
    /// <para />PropertyTerm: Pre Event Notification Duration
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType PreEventNotificationDurationMeasure
    {
        get
        {
            if (__PreEventNotificationDurationMeasure == null) { __PreEventNotificationDurationMeasure = new MeasureType(); }
            return __PreEventNotificationDurationMeasure;
        }
        set
        {
            __PreEventNotificationDurationMeasure = value;
        }
    }

}