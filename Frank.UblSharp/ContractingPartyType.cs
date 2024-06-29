/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ContractingPartyType
{
    private ContractingActivityType[] contractingActivityField;
    private PartyType partyField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BuyerProfileURIType BuyerProfileURI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractingPartyType")]
    public ContractingPartyTypeType[] ContractingPartyType1 { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractingActivity")]
    public ContractingActivityType[] ContractingActivity
    {
        get
        {
            return this.contractingActivityField;
        }

        set
        {
            this.contractingActivityField = value;
        }
    }

    /// <remarks/>
    public PartyType Party
    {
        get
        {
            return this.partyField;
        }

        set
        {
            this.partyField = value;
        }
    }
}