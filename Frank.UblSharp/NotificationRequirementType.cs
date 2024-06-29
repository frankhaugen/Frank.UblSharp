/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("NotificationRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class NotificationRequirementType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NotificationTypeCodeType NotificationTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PostEventNotificationDurationMeasureType PostEventNotificationDurationMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreEventNotificationDurationMeasureType PreEventNotificationDurationMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
    public PartyType[] NotifyParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NotificationPeriod")]
    public PeriodType[] NotificationPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NotificationLocation")]
    public LocationType1[] NotificationLocation { get; set; }
}