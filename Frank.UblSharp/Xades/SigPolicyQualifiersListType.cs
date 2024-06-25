namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SigPolicyQualifiersListType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class SigPolicyQualifiersListType
{
        
    private System.Collections.Generic.List<AnyType> _sigPolicyQualifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SigPolicyQualifier", Order=0)]
    public AnyType[] @__SigPolicyQualifier
    {
        get
        {
            return _sigPolicyQualifier?.ToArray();
        }
        set
        {
            _sigPolicyQualifier = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> SigPolicyQualifier
    {
        get { return _sigPolicyQualifier ?? (_sigPolicyQualifier = new System.Collections.Generic.List<AnyType>()); }
        set { _sigPolicyQualifier = value; }
    }

}