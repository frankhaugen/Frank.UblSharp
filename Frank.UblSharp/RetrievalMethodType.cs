/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public partial class RetrievalMethodType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
    public TransformType[] Transforms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string URI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Type { get; set; }
}