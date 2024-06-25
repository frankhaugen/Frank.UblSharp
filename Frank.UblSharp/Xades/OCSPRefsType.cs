namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OCSPRefsType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class OCSPRefsType
{
        
    private System.Collections.Generic.List<OCSPRefType> _oCSPRef;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OCSPRef", Order=0)]
    public OCSPRefType[] @__OCSPRef
    {
        get
        {
            return _oCSPRef?.ToArray();
        }
        set
        {
            _oCSPRef = value == null ? null : new System.Collections.Generic.List<OCSPRefType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<OCSPRefType> OCSPRef
    {
        get { return _oCSPRef ?? (_oCSPRef = new System.Collections.Generic.List<OCSPRefType>()); }
        set { _oCSPRef = value; }
    }

}