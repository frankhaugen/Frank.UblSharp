/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CertificateOfOriginApplication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class CertificateOfOriginApplicationType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceIDType ReferenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeType CertificateType { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ApplicationStatusCodeType ApplicationStatusCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OriginalJobIDType OriginalJobID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreviousJobIDType PreviousJobID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks { get; set; }

    /// <remarks/>
    public ShipmentType Shipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EndorserParty")]
    public EndorserPartyType[] EndorserParty { get; set; }

    /// <remarks/>
    public PartyType PreparationParty { get; set; }

    /// <remarks/>
    public PartyType IssuerParty { get; set; }

    /// <remarks/>
    public PartyType ExporterParty { get; set; }

    /// <remarks/>
    public PartyType ImporterParty { get; set; }

    /// <remarks/>
    public CountryType IssuingCountry { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution")]
    public DocumentDistributionType[] DocumentDistribution { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference")]
    public DocumentReferenceType[] SupportingDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature")]
    public SignatureType[] Signature { get; set; }
}