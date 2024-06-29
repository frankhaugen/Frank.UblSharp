/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public partial class TransformType
{
    private string algorithmField;
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
    public object[] Items { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }

        set
        {
            this.algorithmField = value;
        }
    }
}