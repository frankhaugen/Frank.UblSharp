namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CertIDListType
{
        
    private System.Collections.Generic.List<CertIDType> _cert;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Cert", Order=0)]
    public CertIDType[] @__Cert
    {
        get
        {
            return _cert?.ToArray();
        }
        set
        {
            _cert = value == null ? null : new System.Collections.Generic.List<CertIDType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CertIDType> Cert
    {
        get { return _cert ?? (_cert = new System.Collections.Generic.List<CertIDType>()); }
        set { _cert = value; }
    }

}