/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class SupplierConsumptionType
{
    private PartyType utilityCustomerPartyField;
    private ConsumptionType consumptionField;
    private ContractType contractField;
    private ConsumptionLineType[] consumptionLineField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    public PartyType UtilitySupplierParty { get; set; }

    /// <remarks/>
    public PartyType UtilityCustomerParty
    {
        get
        {
            return this.utilityCustomerPartyField;
        }

        set
        {
            this.utilityCustomerPartyField = value;
        }
    }

    /// <remarks/>
    public ConsumptionType Consumption
    {
        get
        {
            return this.consumptionField;
        }

        set
        {
            this.consumptionField = value;
        }
    }

    /// <remarks/>
    public ContractType Contract
    {
        get
        {
            return this.contractField;
        }

        set
        {
            this.contractField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionLine")]
    public ConsumptionLineType[] ConsumptionLine
    {
        get
        {
            return this.consumptionLineField;
        }

        set
        {
            this.consumptionLineField = value;
        }
    }
}