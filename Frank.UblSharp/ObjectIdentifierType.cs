/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("ObjectIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class ObjectIdentifierType
{
    /// <remarks/>
    public IdentifierType2 Identifier { get; set; }

    /// <remarks/>
    public string Description { get; set; }

    /// <remarks/>
    public DocumentationReferencesType DocumentationReferences { get; set; }
}