/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdentifierType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public partial class IdentifierType2
{
    private string valueField;
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public QualifierType Qualifier { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool QualifierSpecified { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "anyURI")]
    public string Value
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