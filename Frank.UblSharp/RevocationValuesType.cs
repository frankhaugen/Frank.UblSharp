/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("RevocationValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class RevocationValuesType
{
    private AnyType[] otherValuesField;
    private string idField;
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable = false)]
    public EncapsulatedPKIDataType[] CRLValues { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable = false)]
    public EncapsulatedPKIDataType[] OCSPValues { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable = false)]
    public AnyType[] OtherValues
    {
        get
        {
            return this.otherValuesField;
        }

        set
        {
            this.otherValuesField = value;
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