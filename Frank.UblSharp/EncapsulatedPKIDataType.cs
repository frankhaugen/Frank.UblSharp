/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("EncapsulatedPKIData", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class EncapsulatedPKIDataType
{
    private byte[] valueField;
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Encoding { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
    public byte[] Value
    {
        get
        {
            return this.valueField;
        }

        set
        {
            this.valueField = value;
        }
    }
}