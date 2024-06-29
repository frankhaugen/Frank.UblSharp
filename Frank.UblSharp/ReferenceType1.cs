/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReferenceType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public partial class ReferenceType1
{
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
    public TransformType[] Transforms { get; set; }

    /// <remarks/>
    public DigestMethodType DigestMethod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] DigestValue { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string URI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Type { get; set; }
}