/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SoundType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PictureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryObjectType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EmbeddedDocumentBinaryObjectType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
public partial class BinaryObjectType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
    public string mimeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
    public string encodingCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
    public string characterSetCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string uri { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string filename { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
    public byte[] Value { get; set; }
}