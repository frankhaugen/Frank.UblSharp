/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SubscriberConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class SubscriberConsumptionType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionIDType ConsumptionID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecificationTypeCodeType SpecificationTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalMeteredQuantityType TotalMeteredQuantity { get; set; }

    /// <remarks/>
    public PartyType SubscriberParty { get; set; }

    /// <remarks/>
    public ConsumptionPointType UtilityConsumptionPoint { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OnAccountPayment")]
    public OnAccountPaymentType[] OnAccountPayment { get; set; }

    /// <remarks/>
    public ConsumptionType Consumption { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SupplierConsumption")]
    public SupplierConsumptionType[] SupplierConsumption { get; set; }
}