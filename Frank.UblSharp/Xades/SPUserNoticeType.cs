namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SPUserNotice", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SPUserNotice", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SPUserNoticeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NoticeRef", Order=0)]
    public NoticeReferenceType @__NoticeRef;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExplicitText", Order=1)]
    public string @__ExplicitText;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NoticeReferenceType NoticeRef
    {
        get
        {
            if (__NoticeRef == null) { __NoticeRef = new NoticeReferenceType(); }
            return __NoticeRef;
        }
        set
        {
            __NoticeRef = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ExplicitText
    {
        get
        {
            return __ExplicitText;
        }
        set
        {
            __ExplicitText = value;
        }
    }

}