/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class SignedDataObjectPropertiesType
{
    private XAdESTimeStampType[] allDataObjectsTimeStampField;
    private XAdESTimeStampType[] individualDataObjectsTimeStampField;
    private string idField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataObjectFormat")]
    public DataObjectFormatType[] DataObjectFormat { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeIndication")]
    public CommitmentTypeIndicationType[] CommitmentTypeIndication { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllDataObjectsTimeStamp")]
    public XAdESTimeStampType[] AllDataObjectsTimeStamp
    {
        get
        {
            return this.allDataObjectsTimeStampField;
        }

        set
        {
            this.allDataObjectsTimeStampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IndividualDataObjectsTimeStamp")]
    public XAdESTimeStampType[] IndividualDataObjectsTimeStamp
    {
        get
        {
            return this.individualDataObjectsTimeStampField;
        }

        set
        {
            this.individualDataObjectsTimeStampField = value;
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