/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Evidence", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class EvidenceType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EvidenceTypeCodeType EvidenceTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CandidateStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CandidateStatementType[] CandidateStatement { get; set; }

    /// <remarks/>
    public PartyType EvidenceIssuingParty { get; set; }

    /// <remarks/>
    public DocumentReferenceType DocumentReference { get; set; }

    /// <remarks/>
    public LanguageType Language { get; set; }
}