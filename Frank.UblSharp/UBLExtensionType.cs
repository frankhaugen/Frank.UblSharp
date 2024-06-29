/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
public partial class UBLExtensionType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name { get; set; }

    /// <remarks/>
    public ExtensionAgencyIDType ExtensionAgencyID { get; set; }

    /// <remarks/>
    public ExtensionAgencyNameType ExtensionAgencyName { get; set; }

    /// <remarks/>
    public ExtensionVersionIDType ExtensionVersionID { get; set; }

    /// <remarks/>
    public ExtensionAgencyURIType ExtensionAgencyURI { get; set; }

    /// <remarks/>
    public ExtensionURIType ExtensionURI { get; set; }

    /// <remarks/>
    public ExtensionReasonCodeType ExtensionReasonCode { get; set; }

    /// <remarks/>
    public ExtensionReasonType ExtensionReason { get; set; }

    /// <remarks/>
    public System.Xml.XmlElement ExtensionContent { get; set; }
}