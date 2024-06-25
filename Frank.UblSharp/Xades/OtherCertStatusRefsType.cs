namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OtherCertStatusRefsType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class OtherCertStatusRefsType
{
        
    private System.Collections.Generic.List<AnyType> _otherRef;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OtherRef", Order=0)]
    public AnyType[] @__OtherRef
    {
        get
        {
            return _otherRef?.ToArray();
        }
        set
        {
            _otherRef = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> OtherRef
    {
        get { return _otherRef ?? (_otherRef = new System.Collections.Generic.List<AnyType>()); }
        set { _otherRef = value; }
    }

}