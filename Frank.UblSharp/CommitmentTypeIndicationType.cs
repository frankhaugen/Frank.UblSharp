/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class CommitmentTypeIndicationType
{
    private AnyType[] commitmentTypeQualifiersField;
    /// <remarks/>
    public ObjectIdentifierType CommitmentTypeId { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllSignedDataObjects", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("ObjectReference", typeof(string), DataType = "anyURI")]
    public object[] Items { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CommitmentTypeQualifier", IsNullable = false)]
    public AnyType[] CommitmentTypeQualifiers
    {
        get
        {
            return this.commitmentTypeQualifiersField;
        }

        set
        {
            this.commitmentTypeQualifiersField = value;
        }
    }
}