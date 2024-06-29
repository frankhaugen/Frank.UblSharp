/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ShareholderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ShareholderPartyType
{
    private PartecipationPercentType partecipationPercentField;
    private PartyType partyField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PartecipationPercentType PartecipationPercent
    {
        get
        {
            return this.partecipationPercentField;
        }

        set
        {
            this.partecipationPercentField = value;
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