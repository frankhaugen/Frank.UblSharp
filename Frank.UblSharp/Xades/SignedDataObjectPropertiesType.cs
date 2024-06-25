namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignedDataObjectPropertiesType
{
        
    private System.Collections.Generic.List<DataObjectFormatType> _dataObjectFormat;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DataObjectFormat", Order=0)]
    public DataObjectFormatType[] @__DataObjectFormat
    {
        get
        {
            return _dataObjectFormat?.ToArray();
        }
        set
        {
            _dataObjectFormat = value == null ? null : new System.Collections.Generic.List<DataObjectFormatType>(value);
        }
    }
        
    private System.Collections.Generic.List<CommitmentTypeIndicationType> _commitmentTypeIndication;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeIndication", Order=1)]
    public CommitmentTypeIndicationType[] @__CommitmentTypeIndication
    {
        get
        {
            return _commitmentTypeIndication?.ToArray();
        }
        set
        {
            _commitmentTypeIndication = value == null ? null : new System.Collections.Generic.List<CommitmentTypeIndicationType>(value);
        }
    }
        
    private System.Collections.Generic.List<XAdESTimeStampType> _allDataObjectsTimeStamp;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllDataObjectsTimeStamp", Order=2)]
    public XAdESTimeStampType[] @__AllDataObjectsTimeStamp
    {
        get
        {
            return _allDataObjectsTimeStamp?.ToArray();
        }
        set
        {
            _allDataObjectsTimeStamp = value == null ? null : new System.Collections.Generic.List<XAdESTimeStampType>(value);
        }
    }
        
    private System.Collections.Generic.List<XAdESTimeStampType> _individualDataObjectsTimeStamp;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndividualDataObjectsTimeStamp", Order=3)]
    public XAdESTimeStampType[] @__IndividualDataObjectsTimeStamp
    {
        get
        {
            return _individualDataObjectsTimeStamp?.ToArray();
        }
        set
        {
            _individualDataObjectsTimeStamp = value == null ? null : new System.Collections.Generic.List<XAdESTimeStampType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DataObjectFormatType> DataObjectFormat
    {
        get { return _dataObjectFormat ?? (_dataObjectFormat = new System.Collections.Generic.List<DataObjectFormatType>()); }
        set { _dataObjectFormat = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CommitmentTypeIndicationType> CommitmentTypeIndication
    {
        get { return _commitmentTypeIndication ?? (_commitmentTypeIndication = new System.Collections.Generic.List<CommitmentTypeIndicationType>()); }
        set { _commitmentTypeIndication = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<XAdESTimeStampType> AllDataObjectsTimeStamp
    {
        get { return _allDataObjectsTimeStamp ?? (_allDataObjectsTimeStamp = new System.Collections.Generic.List<XAdESTimeStampType>()); }
        set { _allDataObjectsTimeStamp = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<XAdESTimeStampType> IndividualDataObjectsTimeStamp
    {
        get { return _individualDataObjectsTimeStamp ?? (_individualDataObjectsTimeStamp = new System.Collections.Generic.List<XAdESTimeStampType>()); }
        set { _individualDataObjectsTimeStamp = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Id
    {
        get
        {
            return __Id;
        }
        set
        {
            __Id = value;
        }
    }

}