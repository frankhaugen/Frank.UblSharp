/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignaturePolicyIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class SignaturePolicyIdentifierType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyId", typeof(SignaturePolicyIdType))]
    [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyImplied", typeof(object))]
    public object Item { get; set; }
}