namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CRLRefsType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class CRLRefsType
{
        
    private System.Collections.Generic.List<CRLRefType> _cRLRef;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CRLRef", Order=0)]
    public CRLRefType[] @__CRLRef
    {
        get
        {
            return _cRLRef?.ToArray();
        }
        set
        {
            _cRLRef = value == null ? null : new System.Collections.Generic.List<CRLRefType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CRLRefType> CRLRef
    {
        get { return _cRLRef ?? (_cRLRef = new System.Collections.Generic.List<CRLRefType>()); }
        set { _cRLRef = value; }
    }

}