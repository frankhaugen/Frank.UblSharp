/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("Include", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class IncludeType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string URI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool referencedData { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool referencedDataSpecified { get; set; }
}