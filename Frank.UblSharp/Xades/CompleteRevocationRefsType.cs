namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CompleteRevocationRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CompleteRevocationRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CompleteRevocationRefsType
{
        
    private System.Collections.Generic.List<CRLRefType> _cRLRefs;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("CRLRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable=false)]
    public CRLRefType[] @__CRLRefs
    {
        get
        {
            return _cRLRefs?.ToArray();
        }
        set
        {
            _cRLRefs = value == null ? null : new System.Collections.Generic.List<CRLRefType>(value);
        }
    }
        
    private System.Collections.Generic.List<OCSPRefType> _oCSPRefs;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("OCSPRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable=false)]
    public OCSPRefType[] @__OCSPRefs
    {
        get
        {
            return _oCSPRefs?.ToArray();
        }
        set
        {
            _oCSPRefs = value == null ? null : new System.Collections.Generic.List<OCSPRefType>(value);
        }
    }
        
    private System.Collections.Generic.List<AnyType> _otherRefs;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("OtherRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable=false)]
    public AnyType[] @__OtherRefs
    {
        get
        {
            return _otherRefs?.ToArray();
        }
        set
        {
            _otherRefs = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CRLRefType> CRLRefs
    {
        get { return _cRLRefs ?? (_cRLRefs = new System.Collections.Generic.List<CRLRefType>()); }
        set { _cRLRefs = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<OCSPRefType> OCSPRefs
    {
        get { return _oCSPRefs ?? (_oCSPRefs = new System.Collections.Generic.List<OCSPRefType>()); }
        set { _oCSPRefs = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> OtherRefs
    {
        get { return _otherRefs ?? (_otherRefs = new System.Collections.Generic.List<AnyType>()); }
        set { _otherRefs = value; }
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