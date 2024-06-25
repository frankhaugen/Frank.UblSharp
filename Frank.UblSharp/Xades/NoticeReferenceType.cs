namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("NoticeReferenceType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class NoticeReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Organization", Order=0)]
    public string @__Organization;
        
    private System.Collections.Generic.List<System.String> _noticeNumbers;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("NoticeNumbers", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("int", DataType="integer", IsNullable=false)]
    public string[] @__NoticeNumbers
    {
        get
        {
            return _noticeNumbers?.ToArray();
        }
        set
        {
            _noticeNumbers = value == null ? null : new System.Collections.Generic.List<System.String>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.String> NoticeNumbers
    {
        get { return _noticeNumbers ?? (_noticeNumbers = new System.Collections.Generic.List<System.String>()); }
        set { _noticeNumbers = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Organization
    {
        get
        {
            return __Organization;
        }
        set
        {
            __Organization = value;
        }
    }

}