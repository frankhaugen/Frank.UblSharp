/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CompleteRevocationRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class CompleteRevocationRefsType
{
    private AnyType[] otherRefsField;
    private string idField;
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable = false)]
    public CRLRefType[] CRLRefs { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable = false)]
    public OCSPRefType[] OCSPRefs { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable = false)]
    public AnyType[] OtherRefs
    {
        get
        {
            return this.otherRefsField;
        }

        set
        {
            this.otherRefsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }

        set
        {
            this.idField = value;
        }
    }
}