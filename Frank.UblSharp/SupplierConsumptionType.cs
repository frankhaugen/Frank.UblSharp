/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class SupplierConsumptionType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    public PartyType UtilitySupplierParty { get; set; }

    /// <remarks/>
    public PartyType UtilityCustomerParty { get; set; }

    /// <remarks/>
    public ConsumptionType Consumption { get; set; }

    /// <remarks/>
    public ContractType Contract { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionLine")]
    public ConsumptionLineType[] ConsumptionLine { get; set; }
}