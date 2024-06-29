/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TendererPartyQualification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TendererPartyQualificationType
{
    private QualifyingPartyType[] additionalQualifyingPartyField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InterestedProcurementProjectLot")]
    public ProcurementProjectLotType[] InterestedProcurementProjectLot { get; set; }

    /// <remarks/>
    public QualifyingPartyType MainQualifyingParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty")]
    public QualifyingPartyType[] AdditionalQualifyingParty
    {
        get
        {
            return this.additionalQualifyingPartyField;
        }

        set
        {
            this.additionalQualifyingPartyField = value;
        }
    }
}