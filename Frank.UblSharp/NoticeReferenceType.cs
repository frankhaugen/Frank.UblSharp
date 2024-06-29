/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public partial class NoticeReferenceType
{
    /// <remarks/>
    public string Organization { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("int", DataType = "integer", IsNullable = false)]
    public string[] NoticeNumbers { get; set; }
}