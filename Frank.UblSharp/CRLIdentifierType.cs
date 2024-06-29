/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public partial class CRLIdentifierType
{
    private string numberField;
    private string uRIField;
    /// <remarks/>
    public string Issuer { get; set; }

    /// <remarks/>
    public System.DateTime IssueTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string Number
    {
        get
        {
            return this.numberField;
        }

        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string URI
    {
        get
        {
            return this.uRIField;
        }

        set
        {
            this.uRIField = value;
        }
    }
}