/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class EventLineItemType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineNumberNumericType LineNumberNumeric { get; set; }

    /// <remarks/>
    public LocationType1 ParticipatingLocationsLocation { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RetailPlannedImpact")]
    public RetailPlannedImpactType[] RetailPlannedImpact { get; set; }

    /// <remarks/>
    public ItemType SupplyItem { get; set; }
}