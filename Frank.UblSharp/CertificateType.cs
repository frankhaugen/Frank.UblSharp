/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Certificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class CertificateType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeCodeType CertificateTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CertificateType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeType CertificateType1 { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks { get; set; }

    /// <remarks/>
    public PartyType IssuerParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
    public DocumentReferenceType[] DocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature")]
    public SignatureType[] Signature { get; set; }
}