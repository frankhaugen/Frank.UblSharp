/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CompleteCertificateRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class CompleteCertificateRefsType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable = false)]
    public CertIDType[] CertRefs { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id { get; set; }
}