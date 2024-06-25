namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CompleteCertificateRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CompleteCertificateRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CompleteCertificateRefsType
{
        
    private System.Collections.Generic.List<CertIDType> _certRefs;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("CertRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable=false)]
    public CertIDType[] @__CertRefs
    {
        get
        {
            return _certRefs?.ToArray();
        }
        set
        {
            _certRefs = value == null ? null : new System.Collections.Generic.List<CertIDType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CertIDType> CertRefs
    {
        get { return _certRefs ?? (_certRefs = new System.Collections.Generic.List<CertIDType>()); }
        set { _certRefs = value; }
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