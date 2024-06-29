/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ContractingPartyType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BuyerProfileURIType BuyerProfileURI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractingPartyType")]
    public ContractingPartyTypeType[] ContractingPartyType1 { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractingActivity")]
    public ContractingActivityType[] ContractingActivity { get; set; }

    /// <remarks/>
    public PartyType Party { get; set; }
}